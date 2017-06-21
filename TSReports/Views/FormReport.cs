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

namespace TSReports.Views
{
    partial class FormReport : Form
    {
        Reporte reporte;
        public FormReport(Reporte reporte)
        {
            this.reporte = reporte;
            InitializeComponent();
        }
        private int limit = 500;
        private int offset = 0;
        private Thread hilo;
        private void FormReport_Load(object sender, EventArgs e)
        {
            this._fromReport_labelStatus.Text = "Recovering data...";
            ThreadStart hiloref = new ThreadStart(llenarGrilla);
            this.hilo = new Thread(hiloref);
            hilo.Start();
        }

        private void llenarGrilla()
        {
            List<dynamic> parametros = new List<dynamic>();
            foreach (Campo c in reporte.campos ?? Enumerable.Empty<Campo>()) {
                foreach(Filtro f in c.filtros ?? Enumerable.Empty<Filtro>()) {
                    parametros.Add(new { idcampo = c.id, id = f.id, valor = f.parseControl().valor });
                }
            }
            dynamic resp;
            IList<string> columns = null;
            int cont = 0;
            do {
                string url = "entorno/ejecutarEntorno?identorno=" + this.reporte.id + "&limit=" + this.limit + "&offset=" + this.offset;
                resp = JObject.Parse(RestConnection.Instance.Post(url, parametros).Content);
                foreach (JObject item in resp.data) {
                    if(columns == null) {
                        columns = item.Properties().Select(p => p.Name).ToList();
                        foreach(string col in columns) {
                            this._fromReport_dataGridView.BeginInvoke((MethodInvoker)delegate () {
                                this._fromReport_dataGridView.Columns.Add(col, col.ToUpper());
                            });
                            
                        }
                    }
                    IList<string> filas = new List<string>();
                    foreach (string col in columns) {
                        filas.Add(item[col].ToString());
                    }
                    this._fromReport_dataGridView.BeginInvoke((MethodInvoker)delegate () {
                        this._fromReport_dataGridView.Rows.Add(filas.ToArray());
                        this._fromReport_labelCantidad.Text = cont++.ToString();
                    });

                }
                this.offset = this.offset + this.limit;
            } while (resp.data.Count == this.limit);
            this._fromReport_labelStatus.BeginInvoke((MethodInvoker)delegate () {
                this._fromReport_labelStatus.Text = "Done.";
                this._fromReport_labelCantidad.Text = cont++.ToString();
            });
            
        }


    }
}
