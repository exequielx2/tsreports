using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TSReports.Models;
using TSReports.Models.Entities;
using TSReports.Utils.Exceptions;

namespace TSReports.Views
{
    public partial class FormPrincipal : Form
    {
        private List<Control> dynamic_controls = new List<Control>();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void _formPrincipal_button_add_Click(object sender, EventArgs e)
        {
            FormAdd _formAdd = new FormAdd();
            _formAdd.ShowDialog();
        }

        private void _formPrincipal_button_aplicar_Click(object sender, EventArgs e)
        {
            FormReport _formReport = new FormReport(dynamic_controls);
            _formReport.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try {
                List<Reporte> reportes = Reportes.Instance.List();
                _formPrincipal_treeView_reportes.BeginUpdate();
                foreach (Reporte reporte in reportes) {
                    if (_formPrincipal_treeView_reportes.Nodes.IndexOfKey(reporte.grupo) == -1) {
                        _formPrincipal_treeView_reportes.Nodes.Add(reporte.grupo, reporte.grupo);
                    }
                    _formPrincipal_treeView_reportes.Nodes[reporte.grupo].Nodes.Add(Convert.ToString(reporte.id), Convert.ToString(reporte.descripcion));
                }
                _formPrincipal_treeView_reportes.EndUpdate();
            } catch (CustomException cex) {
                throw cex;
            } catch (Exception ex) {
                throw new CustomException(ex);
            }

        }

        private void _formPrincipal_treeView_reportes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level > 0) {
                this.clear_dynamic_controls();
                Reporte reporte = Reportes.Instance.Get(Int32.Parse(e.Node.Name));
                foreach (Campo campo in reporte.campos ?? Enumerable.Empty<Campo>()) {
                    foreach (Filtro filtro in campo.filtros ?? Enumerable.Empty<Filtro>()) {
                        Label label = new Label();
                        label.Text = campo.titulo + ":";
                        _formPrincipal_flowLayout.Controls.Add(label);
                        _formPrincipal_flowLayout.Controls.Add(this.getControl(filtro.tipodato));
                    }
                }
            }
        }

        private Control getControl(string type)
        {
            Control control = null;
            if (type.Equals("integer")) {
                control = new NumericUpDown();
                ((NumericUpDown)control).Minimum = 0;
                ((NumericUpDown)control).Maximum = 100000;
            } else if (type.Equals("varchar")) {
                control = new TextBox();
            } else if (type.Equals("boolean")) {
                control = new CheckBox();
                ((CheckBox)control).Checked = true;
            } else if (type.Equals("timestamp")) {
                control = new DateTimePicker();
                ((DateTimePicker)control).Format = DateTimePickerFormat.Custom;
                ((DateTimePicker)control).CustomFormat = "dd-MM-yyyy HH:mm:ss";
            }
            if (control != null) {
                dynamic_controls.Add(control);
            }
            return control;
        }

        private void clear_dynamic_controls()
        {
            this.dynamic_controls = new List<Control>();
            _formPrincipal_flowLayout.Controls.Clear();
        }

    }
}
