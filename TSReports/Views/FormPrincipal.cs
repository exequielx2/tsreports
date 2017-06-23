using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TSReports.Models;
using TSReports.Models.Entities;
using TSReports.Utils.Exceptions;

namespace TSReports.Views
{
    public partial class FormPrincipal : Form
    {
        TreeView _fieldsTreeCache;
        public FormPrincipal()
        {
            _fieldsTreeCache = new TreeView();
            InitializeComponent();
        }

        private void _formPrincipal_button_add_Click(object sender, EventArgs e)
        {
            FormAdd _formAdd = new FormAdd();
            _formAdd.ShowDialog();
        }

        private void _formPrincipal_button_aplicar_Click(object sender, EventArgs e)
        {
            try {
                if (_formPrincipal_treeView_reportes.SelectedNode != null) {
                    FormReport _formReport = new FormReport(Reportes.Instance.Get(Int32.Parse(_formPrincipal_treeView_reportes.SelectedNode.Name)));
                    _formReport.Show();
                }
            } catch (CustomException cex) {
                throw cex;
            } catch (Exception ex) {
                throw new CustomException(ex);
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try {
                List<Reporte> reportes = Reportes.Instance.List();
                _formPrincipal_treeView_reportes.BeginUpdate();
                foreach (Reporte reporte in reportes) {
                    string grupo = " " + reporte.grupo.ToUpper();
                    if (_formPrincipal_treeView_reportes.Nodes.IndexOfKey(grupo) == -1) {
                        _formPrincipal_treeView_reportes.Nodes.Add(grupo, grupo);
                        _fieldsTreeCache.Nodes.Add(grupo, grupo);
                    }
                    _formPrincipal_treeView_reportes.Nodes[grupo].Nodes.Add(Convert.ToString(reporte.id), Convert.ToString(reporte.descripcion));
                    _fieldsTreeCache.Nodes[grupo].Nodes.Add(Convert.ToString(reporte.id), Convert.ToString(reporte.descripcion));
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
            try {
                if (Regex.IsMatch(e.Node.Name, @"^\d+$")) {
                    _formPrincipal_flowLayout.Controls.Clear();
                    Reporte reporte = Reportes.Instance.Get(Int32.Parse(e.Node.Name));
                    foreach (Campo campo in reporte.campos ?? Enumerable.Empty<Campo>()) {
                        foreach (Filtro filtro in campo.filtros ?? Enumerable.Empty<Filtro>()) {
                            CheckBox checkbox = new CheckBox();
                            checkbox.Checked = true;
                            checkbox.Text = campo.titulo + ":";
                            filtro.control = new Control[2] { checkbox, this.getControl(filtro.tipodato) };
                            Panel panel = new Panel();
                            panel.AutoSize = true;
                            filtro.control[1].AutoSize = true;
                            filtro.control[1].Left = checkbox.Width;
                            panel.Controls.AddRange(filtro.control);

                            _formPrincipal_flowLayout.Controls.Add(panel);
                        }
                    }
                } else {
                    this._formPrincipal_treeView_reportes.SelectedNode = null;
                    this._formPrincipal_flowLayout.Controls.Clear();
                }
            } catch (CustomException cex) {
                throw cex;
            } catch (Exception ex) {
                throw new CustomException(ex);
            }
        }

        private Control getControl(string type)
        {
            try {
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
                return control;
            } catch (CustomException cex) {
                throw cex;
            } catch (Exception ex) {
                throw new CustomException(ex);
            }
        }

        private void _formPrincipal_textBox_search_TextChanged(object sender, EventArgs e)
        {
            try {
                this._formPrincipal_flowLayout.Controls.Clear();
                this._formPrincipal_treeView_reportes.SelectedNode = null;
                this._formPrincipal_treeView_reportes.BeginUpdate();
                this._formPrincipal_treeView_reportes.Nodes.Clear();
                if (this._formPrincipal_textBox_search.Text != string.Empty) {
                    foreach (TreeNode _parentNode in _fieldsTreeCache.Nodes) {
                        foreach (TreeNode _childNode in _parentNode.Nodes) {
                            if (_childNode.Text.ToUpper().Contains(this._formPrincipal_textBox_search.Text.ToUpper())) {
                                this._formPrincipal_treeView_reportes.Nodes.Add((TreeNode)_childNode.Clone());
                            }
                        }
                    }
                } else {
                    foreach (TreeNode _node in this._fieldsTreeCache.Nodes) {
                        _formPrincipal_treeView_reportes.Nodes.Add((TreeNode)_node.Clone());
                    }
                }
                this._formPrincipal_treeView_reportes.EndUpdate();
            } catch (CustomException cex) {
                throw cex;
            } catch (Exception ex) {
                throw new CustomException(ex);
            }
        }

        private void _formPrincipal_button_delete_Click(object sender, EventArgs e)
        {
            try {
                if (this._formPrincipal_treeView_reportes.SelectedNode != null &&
                    MessageBox.Show("Are you sure to delete this item?",
                    "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes
                    ) {
                    if (Reportes.Instance.Delete(Int32.Parse(this._formPrincipal_treeView_reportes.SelectedNode.Name))) {
                        this._formPrincipal_treeView_reportes.Nodes.Remove(_formPrincipal_treeView_reportes.SelectedNode);
                        this._fieldsTreeCache.Nodes.Remove(_formPrincipal_treeView_reportes.SelectedNode);
                        this._formPrincipal_flowLayout.Controls.Clear();
                        this._formPrincipal_treeView_reportes.SelectedNode = null;
                    }
                }
            } catch (CustomException cex) {
                throw cex;
            } catch (Exception ex) {
                throw new CustomException(ex);
            }

        }
    }
}
