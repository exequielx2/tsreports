using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSReports.Models;
using TSReports.Models.Entities;
using TSReports.Services;
using TSReports.Utils.Exceptions;

namespace TSReports.Views
{
    partial class FormReport : Form
    {
        Reporte reporte;
        DataTable source;
        public FormReport(Reporte reporte)
        {
            this.reporte = reporte;
            this.source = new DataTable();
            InitializeComponent();
        }
        private int limit = 500;
        private int offset = 0;
        private Thread hilo;

        private void FormReport_Load(object sender, EventArgs e)
        {
            try {
                this._fromReport_labelStatus.Text = "Recovering data...";
                this.Text = reporte.descripcion;
                ThreadStart hiloref = new ThreadStart(FillGrid);
                this.hilo = new Thread(hiloref);
                hilo.Start();
            } catch (CustomException cex) {
                throw cex;
            } catch (Exception ex) {
                throw new CustomException(ex);
            }
        }



        private void FillGrid()
        {
            try {
                List<dynamic> parametros = new List<dynamic>();
                foreach (Campo c in reporte.campos ?? Enumerable.Empty<Campo>()) {
                    foreach (Filtro f in c.filtros ?? Enumerable.Empty<Filtro>()) {
                        if (((CheckBox)f.control[0]).Checked) {
                            parametros.Add(new { idcampo = c.id, id = f.id, valor = f.parseControl().valor });
                        }
                    }
                }
                IList<string> columns = null;
                int cont = 0;
                dynamic resp;
                do {
                    resp = ReporteService.Instance.Ejecutar(this.reporte.id, this.limit, this.offset, parametros);
                    foreach (JObject item in resp.data) {
                        if (columns == null) {
                            columns = item.Properties().Select(p => p.Name).ToList();
                            foreach (string col in columns) {
                                this.source.Columns.Add(col.ToUpper());
                            }
                        }
                        IList<string> fila = new List<string>();
                        foreach (string col in columns) {
                            fila.Add(item[col].ToString());
                        }
                        this.source.Rows.Add(fila.ToArray());
                        cont++;
                    }
                    this._fromReport_dataGridView.BeginInvoke((MethodInvoker)delegate () {
                        this._fromReport_dataGridView.DataSource = this.source;
                        this._fromReport_labelCantidad.Text = cont.ToString();
                    });
                    this.offset = this.offset + this.limit;

                } while (resp.data.Count == this.limit);

                
                this._fromReport_labelStatus.BeginInvoke((MethodInvoker)delegate () {
                    if(columns != null) {
                        this._fromReport_comboBoxColumnSearch.Items.AddRange(columns.ToArray());
                    } 
                    this._fromReport_labelStatus.Text = "Done.";
                    this._fromReport_labelCantidad.Text = cont++.ToString();
                });
                
            } catch (CustomException cex) {
                throw cex;
            } catch (Exception ex) {
                throw new CustomException(ex);
            }
        }

        private void _fromReport_textBoxColumnSearch_TextChanged(object sender, EventArgs e)
        {
            try {
                if (this._fromReport_comboBoxColumnSearch.SelectedIndex != -1) {
                    this.source.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", this._fromReport_comboBoxColumnSearch.SelectedItem.ToString().ToUpper(), ((TextBox)sender).Text);
                    this._fromReport_labelCantidad.Text = this.source.DefaultView.Count.ToString();
                }
            } catch (CustomException cex) {
                throw cex;
            } catch (Exception ex) {
                throw new CustomException(ex);
            }
        }
    }
}
