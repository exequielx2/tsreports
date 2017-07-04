using RestSharp;
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
    public partial class FormAdd : Form
    {
        private TreeView _fieldsTreeCache;
        private Thread hilo;
        public FormAdd()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F)) {
                _formAdd_textBoxFilter.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void _formAdd_buttonUpColumn_Click(object sender, EventArgs e)
        {
            int selectedIndex = _formAdd_listBoxColumns.SelectedIndex;
            if (selectedIndex > 0) {
                _formAdd_listBoxColumns.Items.Insert(selectedIndex - 1, _formAdd_listBoxColumns.Items[selectedIndex]);
                _formAdd_listBoxColumns.Items.RemoveAt(selectedIndex + 1);
                _formAdd_listBoxColumns.SelectedIndex = selectedIndex - 1;
            }
        }

        private void _formAdd_buttonDownColumn_Click(object sender, EventArgs e)
        {
            int selectedIndex = _formAdd_listBoxColumns.SelectedIndex;
            if (selectedIndex < _formAdd_listBoxColumns.Items.Count - 1 & selectedIndex != -1) {
                _formAdd_listBoxColumns.Items.Insert(selectedIndex + 2, _formAdd_listBoxColumns.Items[selectedIndex]);
                _formAdd_listBoxColumns.Items.RemoveAt(selectedIndex);
                _formAdd_listBoxColumns.SelectedIndex = selectedIndex + 1;

            }
        }

        private void _formAdd_buttonUpTable_Click(object sender, EventArgs e)
        {
            int selectedIndex = _formAdd_listBoxTables.SelectedIndex;
            if (selectedIndex > 0) {
                _formAdd_listBoxTables.Items.Insert(selectedIndex - 1, _formAdd_listBoxTables.Items[selectedIndex]);
                _formAdd_listBoxTables.Items.RemoveAt(selectedIndex + 1);
                _formAdd_listBoxTables.SelectedIndex = selectedIndex - 1;
            }
        }

        private void _formAdd_buttonDownTable_Click(object sender, EventArgs e)
        {
            int selectedIndex = _formAdd_listBoxTables.SelectedIndex;
            if (selectedIndex < _formAdd_listBoxTables.Items.Count - 1 & selectedIndex != -1) {
                _formAdd_listBoxTables.Items.Insert(selectedIndex + 2, _formAdd_listBoxTables.Items[selectedIndex]);
                _formAdd_listBoxTables.Items.RemoveAt(selectedIndex);
                _formAdd_listBoxTables.SelectedIndex = selectedIndex + 1;

            }
        }

        private void _formAdd_buttonDelete_Click(object sender, EventArgs e)
        {
            if (_formAdd_listBoxColumns.SelectedIndex != -1) {
                //remove filtros
                foreach (DataGridViewRow row in this._formAdd_dataGridViewFilters.Rows) {
                    if (((Campo)row.Tag).id == ((Campo)_formAdd_listBoxColumns.SelectedItem).id) {
                        this._formAdd_dataGridViewFilters.Rows.RemoveAt(row.Index);
                    }
                }

                //remove tables
                for (int i = 0; i < _formAdd_listBoxTables.Items.Count; i++) {
                    Tabla _t = (Tabla)_formAdd_listBoxTables.Items[i];
                    if (_t == ((Campo)_formAdd_listBoxColumns.SelectedItem).tabla) {
                        _formAdd_listBoxTables.Items.Remove(_t);
                        i--;
                    }
                }
                //remove columns
                _formAdd_listBoxColumns.Items.RemoveAt(_formAdd_listBoxColumns.SelectedIndex);

                //reset
                //RestartNodes();
            }
        }

        private void _formAdd_treeViewReportes_DoubleClick(object sender, EventArgs e)
        {
            TreeNode selected = ((TreeView)sender).SelectedNode;
            this.AddItemToCampos(selected);
        }

        private void AddItemToCampos(TreeNode selected)
        {
            if (selected == null || selected.Level == 0) { return; }
            int idcampo = Int32.Parse(selected.Name);
            int idtabla = Int32.Parse(selected.Parent.Name);
            Tabla tabla = null;
            bool found = false;
            foreach (Tabla _t in _formAdd_listBoxTables.Items) {
                if (_t.id == idtabla) {
                    tabla = _t;
                    foreach (Campo _c in _formAdd_listBoxColumns.Items) {
                        if (_c.id == idcampo) {
                            found = true;
                            break;
                        }
                    }
                    if (found) { break; }
                }
            }
            if (tabla == null) {
                tabla = Utils.Utils.DeepCopy<Tabla>(Tablas.Instance.Get(idtabla));
                tabla.alias = Utils.Utils.TableAlias();
                tabla.campos.Clear();
            }
            if (found) {
                DialogResult dialogResult = MessageBox.Show("El campo ya existe en la proyección\n ¿desea replicar la tabla?", "Replicar Tabla", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    tabla = Utils.Utils.DeepCopy<Tabla>(Tablas.Instance.Get(idtabla));
                    tabla.alias = Utils.Utils.TableAlias();
                    tabla.campos.Clear();
                    _formAdd_listBoxTables.Items.Add(tabla);
                } else {
                    return;
                }
            } else {
                if (!_formAdd_listBoxTables.Items.Contains(tabla)) {
                    _formAdd_listBoxTables.Items.Add(tabla);
                }
            }

             List<int> idsdestino = new List<int>();
             idsdestino.Add(Int32.Parse(selected.Name));
             List<int> idsorigen = new List<int>();
             foreach (Campo c in this._formAdd_listBoxColumns.Items) {
                 idsorigen.Add(c.id);
             }
             dynamic resp = Tablas.Instance.Relaciones(idsorigen, idsdestino);
             if(resp != null) {
                FormChooseTable formct = new FormChooseTable(resp);
                if (formct.ShowDialog() == DialogResult.OK) {

                }
             }

            Campo campo = Utils.Utils.DeepCopy<Campo>(Tablas.Instance.GetCampo(idcampo));
            campo.alias = campo.titulo.ToUpper();
            campo.tabla = tabla;
            tabla.campos.Add(campo);
            _formAdd_listBoxColumns.Items.Add(campo);
            ///selected.Parent.Nodes.RemoveAt(selected.Index); remueve del tree
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            _fieldsTreeCache = new TreeView();
            _formAdd_listBoxColumns.DisplayMember = "titulo";
            _formAdd_listBoxColumns.ValueMember = "id";
            _formAdd_listBoxTables.DisplayMember = "titulo";
            _formAdd_listBoxTables.ValueMember = "id";

            _formAdd_dataGridViewFilters.ColumnCount = 5;
            _formAdd_dataGridViewFilters.Columns[0].Name = "Campo";
            _formAdd_dataGridViewFilters.Columns[1].Name = "Tipo";
            _formAdd_dataGridViewFilters.Columns[2].Name = "Valor Default";
            _formAdd_dataGridViewFilters.Columns[3].Name = "Obligatorio";
            _formAdd_dataGridViewFilters.Columns[3].Width = 60;
            _formAdd_dataGridViewFilters.Columns[4].Name = "Borrar";
            _formAdd_dataGridViewFilters.Columns[4].Width = 50;


            ThreadStart hiloref = new ThreadStart(FillGrid);
            this.hilo = new Thread(hiloref);
            hilo.Start();
        }

        private void FillGrid()
        {
            this._formAdd_treeViewReportes.Invoke(new Action(() => {
                this._formAdd_treeViewReportes.Nodes.Clear();
                List<Tabla> tablas = Tablas.Instance.List();
                this._formAdd_treeViewReportes.BeginUpdate();
                foreach (Tabla t in tablas) {
                    this._formAdd_treeViewReportes.Nodes.Add(t.id.ToString(), t.titulo);
                    this._fieldsTreeCache.Nodes.Add(t.id.ToString(), t.titulo);
                    foreach (Campo c in t.campos) {
                        this._formAdd_treeViewReportes.Nodes[t.id.ToString()].Nodes.Add(c.id.ToString(), c.titulo);
                        this._fieldsTreeCache.Nodes[t.id.ToString()].Nodes.Add(c.id.ToString(), c.titulo);
                    }
                }
                this._formAdd_treeViewReportes.EndUpdate();
            }));
        }



        private void _formAdd_textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            RestartNodes();
        }

        private void RestartNodes()
        {
            int currentNodeIndex = (this._formAdd_treeViewReportes.TopNode != null) ? this._formAdd_treeViewReportes.TopNode.Index : 0;
            this._formAdd_treeViewReportes.Nodes.Clear();
            this._formAdd_treeViewReportes.BeginUpdate();
            foreach (TreeNode _parentNode in _fieldsTreeCache.Nodes) {
                if (this._formAdd_textBoxFilter.Text == string.Empty ||
                    _parentNode.Text.ToUpper().StartsWith(this._formAdd_textBoxFilter.Text.ToUpper())) {
                    TreeNode clonednode = (TreeNode)_parentNode.Clone();
                    if (_parentNode.IsExpanded) {
                        clonednode.Expand();
                    }
                    int index = this._formAdd_treeViewReportes.Nodes.Add(clonednode);
                    RemoveChildNodes(index);
                }
            }
            this._formAdd_treeViewReportes.EndUpdate();
            if (this._formAdd_treeViewReportes.Nodes.Count > currentNodeIndex) {
                this._formAdd_treeViewReportes.TopNode = this._formAdd_treeViewReportes.Nodes[currentNodeIndex];
            }

        }
        private void RemoveChildNodes(int parentnodeindex)
        {
            List<TreeNode> removes = new List<TreeNode>();
            foreach (TreeNode _node in this._fieldsTreeCache.Nodes) {
                foreach (TreeNode _childnode in _formAdd_treeViewReportes.Nodes[parentnodeindex].Nodes) {
                    foreach (Campo _c in this._formAdd_listBoxColumns.Items) {
                        if (_c.id == Int32.Parse(_childnode.Name)) {
                            removes.Add(_childnode);
                            break;
                        }
                    }
                }
            }
            foreach (TreeNode rm in removes) {
                rm.Remove();
            }
        }

        private void _formAdd_treeViewReportes_AfterExpand(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode _tn in this._fieldsTreeCache.Nodes) {
                if (_tn.Name == e.Node.Name) {
                    _tn.Expand();
                    break;
                }
            }
        }

        private void _formAdd_treeViewReportes_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode _tn in this._fieldsTreeCache.Nodes) {
                if (_tn.Name == e.Node.Name) {
                    _tn.Collapse();
                    break;
                }
            }
        }

        private void _formAdd_listBoxColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this._formAdd_listBoxColumns.SelectedIndex != -1) {
                this._formAdd_panelPropColumns.Enabled = true;
                Campo camposelected = (Campo)this._formAdd_listBoxColumns.SelectedItem;
                if (camposelected.orderby == Campo.orderbyenum.ASC) {
                    this._formAdd_radioButtonAsc.Checked = true;
                } else {
                    this._formAdd_radioButtonDesc.Checked = true;
                }
                this._formAdd_checkBoxVisible.Checked = camposelected.visible;
                this._formAdd_textBoxAliasColumn.Text = camposelected.alias;
            } else {
                this._formAdd_panelPropColumns.Enabled = false;
            }
        }

        private void _formAdd_radioButtonDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (this._formAdd_listBoxColumns.SelectedIndex != -1) {
                if (this._formAdd_radioButtonDesc.Checked) {
                    ((Campo)this._formAdd_listBoxColumns.SelectedItem).orderby = Campo.orderbyenum.DESC;
                } else {
                    ((Campo)this._formAdd_listBoxColumns.SelectedItem).orderby = Campo.orderbyenum.ASC;
                }
            }
        }

        private void _formAdd_checkBoxVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (this._formAdd_listBoxColumns.SelectedIndex != -1) {
                ((Campo)this._formAdd_listBoxColumns.SelectedItem).visible = this._formAdd_checkBoxVisible.Checked;
            }
        }

        private void _formAdd_textBoxAliasColumn_TextChanged(object sender, EventArgs e)
        {
            if (this._formAdd_listBoxColumns.SelectedIndex != -1) {
                ((Campo)this._formAdd_listBoxColumns.SelectedItem).alias = this._formAdd_textBoxAliasColumn.Text;
            }
        }

        private void _formAdd_textBoxAliasTable_TextChanged(object sender, EventArgs e)
        {
            if (this._formAdd_listBoxTables.SelectedIndex != -1) {
                ((Tabla)this._formAdd_listBoxTables.SelectedItem).alias = this._formAdd_textBoxAliasTable.Text;
            }
        }

        private void _formAdd_listBoxColumns_DoubleClick(object sender, EventArgs e)
        {
            if (this._formAdd_listBoxColumns.SelectedIndex != -1) {
                DataGridViewCell[] cells = new DataGridViewCell[] { new DataGridViewTextBoxCell(), new DataGridViewComboBoxCell(), new DataGridViewTextBoxCell(), new DataGridViewCheckBoxCell(), new DataGridViewButtonCell() };

                Campo camposelected = (Campo)this._formAdd_listBoxColumns.SelectedItem;
                ((DataGridViewTextBoxCell)cells[0]).Value = camposelected.titulo;
                ((DataGridViewTextBoxCell)cells[0]).Style.ForeColor = Color.Black;

                ((DataGridViewComboBoxCell)cells[1]).ValueMember = "id";
                ((DataGridViewComboBoxCell)cells[1]).DisplayMember = "descripcion";
                ((DataGridViewComboBoxCell)cells[1]).Items.AddRange(camposelected.filtros.ToArray());
                ((DataGridViewComboBoxCell)cells[1]).Style.ForeColor = Color.Black;
                ((DataGridViewComboBoxCell)cells[1]).Value = ((DataGridViewComboBoxCell)cells[1]).Items[0];

                ((DataGridViewTextBoxCell)cells[2]).Style.ForeColor = Color.Black;

                ((DataGridViewCheckBoxCell)cells[3]).Value = true;

                ((DataGridViewButtonCell)cells[4]).Value = "Borrar";
                ((DataGridViewButtonCell)cells[4]).Style.ForeColor = Color.Black;

                DataGridViewRow row = new DataGridViewRow();
                row.Tag = camposelected;
                row.Cells.AddRange(cells);
                row.Cells[0].ReadOnly = true;

                _formAdd_dataGridViewFilters.Rows.Add(row);

                tabControl1.SelectedIndex = 1;

            }
        }

        private void _formAdd_dataGridViewFilters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0) {
                if (MessageBox.Show("Are you sure to delete this item?",
                    "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes
                    ) {
                    this._formAdd_dataGridViewFilters.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void _formAdd_listBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this._formAdd_listBoxTables.SelectedIndex != -1) {
                this._formAdd_panelPropTable.Enabled = true;
                Tabla tablaselected = (Tabla)this._formAdd_listBoxTables.SelectedItem;

                this._formAdd_textBoxAliasTable.Text = tablaselected.alias;
            } else {
                this._formAdd_panelPropTable.Enabled = false;
            }
        }

        private void _formAdd_treeViewReportes_ItemDrag(object sender, ItemDragEventArgs e)
        {
            TreeNode selected = ((TreeView)sender).SelectedNode;
            DoDragDrop(selected, DragDropEffects.Move);
        }

        private void _formAdd_treeViewReportes_listBoxColumns_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNode))) {
                e.Effect = DragDropEffects.Move;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void _formAdd_listBoxColumns_DragDrop(object sender, DragEventArgs e)
        {
            dynamic selected = e.Data.GetData(typeof(TreeNode));
            if (selected != null && selected.GetType() == typeof(TreeNode)) {
                this.AddItemToCampos((TreeNode)selected);
            }
                
        }

        private void _formAdd_treeViewReportes_MouseDown(object sender, MouseEventArgs e)
        {
            _formAdd_treeViewReportes.SelectedNode = _formAdd_treeViewReportes.GetNodeAt(e.X, e.Y);
        }
    }
}
