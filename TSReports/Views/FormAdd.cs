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

        //ATAJOS DE TECLADO
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F)) {
                _formAdd_textBoxFilter.SelectAll();
                _formAdd_textBoxFilter.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //LOAD DEL FORM E INICIALIZACION DE COSAS
        private void FormAdd_Load(object sender, EventArgs e)
        {
            _fieldsTreeCache = new TreeView();
            _formAdd_listBoxColumns.DisplayMember = "titulo";
            _formAdd_listBoxColumns.ValueMember = "id";
            _formAdd_listBoxTables.DisplayMember = "titulo";
            _formAdd_listBoxTables.ValueMember = "id";

            _formAdd_dataGridViewFilters.ColumnCount = 7;
            _formAdd_dataGridViewFilters.Columns[0].Name = "Tabla";
            _formAdd_dataGridViewFilters.Columns[1].Name = "Alias";
            _formAdd_dataGridViewFilters.Columns[2].Name = "Campo";
            _formAdd_dataGridViewFilters.Columns[3].Name = "Tipo";
            _formAdd_dataGridViewFilters.Columns[4].Name = "Valor Default";
            _formAdd_dataGridViewFilters.Columns[5].Name = "Obligatorio";
            _formAdd_dataGridViewFilters.Columns[5].Width = 60;
            _formAdd_dataGridViewFilters.Columns[6].Name = "Borrar";
            _formAdd_dataGridViewFilters.Columns[6].Width = 50;

            this._formAdd_comboBoxGrupo.Items.AddRange(Reportes.Instance.Groups().ToArray());

            ThreadStart hiloref = new ThreadStart(FillGrid);
            this.hilo = new Thread(hiloref);
            hilo.Start();
        }

        //HILO PARA LLENAR EL ARBOL
        private void FillGrid()
        {
            List<Tabla> tablas = Tablas.Instance.List();
            this._formAdd_treeViewReportes.Invoke(new Action(() => {
                this._formAdd_treeViewReportes.Nodes.Clear();
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

        /*BOTONES ELEMNTOS LISTBOX*/
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
        

        private void _formAdd_buttonDelete_Click(object sender, EventArgs e)
        {
            if (_formAdd_listBoxColumns.SelectedIndex != -1) {
                Campo campo = ((Campo)_formAdd_listBoxColumns.SelectedItem);
                //remove filtros
                foreach (DataGridViewRow row in this._formAdd_dataGridViewFilters.Rows) {
                    if (((Campo)row.Tag).id == campo.id) {
                        this._formAdd_dataGridViewFilters.Rows.RemoveAt(row.Index);
                    }
                }

                //remove tables
                for (int i = 0; i < _formAdd_listBoxTables.Items.Count; i++) {
                    Tabla _t = (Tabla)_formAdd_listBoxTables.Items[i];
                    if (_t == campo.tabla && _t.campos.Count == 1) {
                        _formAdd_listBoxTables.Items.Remove(_t);
                        i--;
                    }
                }
                //remove columns
                campo.tabla.campos.Remove(campo);//mmhoimhdgignsugai`ng
                _formAdd_listBoxColumns.Items.RemoveAt(_formAdd_listBoxColumns.SelectedIndex);
                
                //reset
                //RestartNodes();
            }
        }

        private void _formAdd_listBoxColumns_DoubleClick(object sender, EventArgs e)
        {
            AddFiler();
        }

        private void _formAdd_buttonFilter_Click(object sender, EventArgs e)
        {
            AddFiler();
        }

        private void AddFiler()
        {
            if (this._formAdd_listBoxColumns.SelectedIndex != -1) {
                DataGridViewCell[] cells = new DataGridViewCell[] {
                    new DataGridViewTextBoxCell(),
                    new DataGridViewTextBoxCell(),
                    new DataGridViewTextBoxCell(),
                    new DataGridViewComboBoxCell(),
                    new DataGridViewTextBoxCell(),
                    new DataGridViewCheckBoxCell(),
                    new DataGridViewButtonCell() };

                Campo camposelected = (Campo)this._formAdd_listBoxColumns.SelectedItem;
                ((DataGridViewTextBoxCell)cells[0]).Value = camposelected.tabla.titulo;
                ((DataGridViewTextBoxCell)cells[0]).Style.ForeColor = Color.Black;

                ((DataGridViewTextBoxCell)cells[1]).Value = camposelected.tabla.alias;
                ((DataGridViewTextBoxCell)cells[1]).Style.ForeColor = Color.Black;

                ((DataGridViewTextBoxCell)cells[2]).Value = camposelected.titulo;
                ((DataGridViewTextBoxCell)cells[2]).Style.ForeColor = Color.Black;

                ((DataGridViewComboBoxCell)cells[3]).ValueMember = "id";
                ((DataGridViewComboBoxCell)cells[3]).DisplayMember = "descripcion";
                ((DataGridViewComboBoxCell)cells[3]).Items.AddRange(camposelected.filtros.ToArray());
                ((DataGridViewComboBoxCell)cells[3]).Style.ForeColor = Color.Black;
                ((DataGridViewComboBoxCell)cells[3]).Value = ((DataGridViewComboBoxCell)cells[3]).Items[0];

                ((DataGridViewTextBoxCell)cells[4]).Style.ForeColor = Color.Black;

                ((DataGridViewCheckBoxCell)cells[5]).Value = true;

                ((DataGridViewButtonCell)cells[6]).Value = "Borrar";
                ((DataGridViewButtonCell)cells[6]).Style.ForeColor = Color.Black;

                DataGridViewRow row = new DataGridViewRow();
                row.Tag = camposelected;
                row.Cells.AddRange(cells);
                row.Cells[0].ReadOnly = true;

                _formAdd_dataGridViewFilters.Rows.Add(row);

                tabControl1.SelectedIndex = 1;

            }
        }

        /*FIN BOTONES ELEMNTOS LISTBOX*/


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
             
            //agrego la tabla y el campo a sus listboxes
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
                    if (!Relacionar(tabla,idtabla)) { return; }
                    tabla = Utils.Utils.DeepCopy<Tabla>(Tablas.Instance.Get(idtabla));
                    tabla.alias = Utils.Utils.TableAlias();
                    tabla.campos.Clear();
                    _formAdd_listBoxTables.Items.Add(tabla);
                } else {
                    return;
                }
            } else {
                if (!_formAdd_listBoxTables.Items.Contains(tabla)) {
                    if (!Relacionar(tabla, idtabla)) { return; }
                    _formAdd_listBoxTables.Items.Add(tabla);
                }
            }
             
            Campo campo = Utils.Utils.DeepCopy<Campo>(Tablas.Instance.GetCampo(idcampo));
            campo.alias = campo.titulo.ToUpper();
            campo.tabla = tabla;
            tabla.campos.Add(campo);
            _formAdd_listBoxColumns.Items.Add(campo);
            ///selected.Parent.Nodes.RemoveAt(selected.Index); remueve del tree
        }

        //consulto relaciones intermedias.
        private bool Relacionar(Tabla tabla , int iddestino)
        {
            if (this._formAdd_listBoxColumns.Items.Count == 0) { return true; }//si es la primera tabla

            Tabla t_origen = ((Campo)this._formAdd_listBoxColumns.Items[_formAdd_listBoxColumns.Items.Count - 1]).tabla;
            dynamic resp = Tablas.Instance.Relaciones(new List<int>() { t_origen.id }, new List<int>() { iddestino });
            if (resp != null) {
                if(resp.data == null) {
                    return false;
                }else if ((resp.data[0]).discriminador == "unico") {
                    dynamic destino = (resp.data[0]).destino[0];
                    dynamic campos = destino.campos[0];
                    tabla.relacion = new Relacion();
                    tabla.relacion.campoorigen = GetOriginalCampo((int)campos.id_campo_origen);
                    tabla.relacion.campodestino = GetOriginalCampo((int)campos.id_campo_destino);
                    return true;
                } else {
                    FormChooseTable formct = new FormChooseTable(resp);
                    if (formct.ShowDialog() == DialogResult.OK) {
                        dynamic f_resp = formct.respuesta;
                        int idcampoorigen = f_resp.relacionorigen.campoorigen.id_campo_origen; 
                        int idcampodestino = f_resp.relacionorigen.campoorigen.id_campo_destino;
                        //la tabla para el listbox la busco en las relaciones destino de las tablas
                        tabla.relacion = new Relacion();
                        tabla.relacion.campoorigen = GetOriginalCampo(idcampoorigen);
                        tabla.relacion.campodestino = GetOriginalCampo(idcampodestino);

                        idcampoorigen = f_resp.relaciondestino.campoorigen.id_campo_origen;
                        idcampodestino = f_resp.relaciondestino.campoorigen.id_campo_destino;

                        Tabla _t = tabla.relacion.campodestino.tabla;
                        _t.alias = Utils.Utils.TableAlias();
                        _t.relacion = new Relacion();
                        _t.relacion.campoorigen = GetOriginalCampo(idcampoorigen);
                        _t.relacion.campodestino = GetOriginalCampo(idcampodestino);
                        _t.relacion.campodestino.tabla = t_origen;

                        _formAdd_listBoxTables.Items.Add(_t); 

                        return true;
                    }
                }
            }
            return false;
        }

        private Campo GetOriginalCampo(int id)
        {
            foreach(Tabla _t in Tablas.Instance.List()) {
                Tabla _copytable = (Tabla)Utils.Utils.DeepCopy(_t);
                foreach (Campo _c in _copytable.campos) {
                    if(id == _c.id) {
                        _c.tabla = _copytable;
                        return _c;
                    }
                }
            }
            return null;
        }
        
        
        /*FILTRO ARBOL*/
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
                    if (_parentNode.Text.ToUpper().Equals(this._formAdd_textBoxFilter.Text.ToUpper())) {
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
        /*FIN FILTRO ARBOL*/

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
            //propiedades de los campos
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

                //autoseleccionar fila de tabla cuando se selecciona el campo
                foreach (Tabla _t in this._formAdd_listBoxTables.Items) {
                    if (_t.campos.Contains(camposelected)) {
                        _formAdd_listBoxTables.SelectedItem = _t;
                        break;
                    }
                } 
            } else {
                this._formAdd_panelPropColumns.Enabled = false;
            }

        }

        //*PROPIEDADES DE COLUMNAS Y TABLAS*/
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
        //FIN PROPIEDADES DE COLUMNAS Y TABLAS*/

     

        private void _formAdd_dataGridViewFilters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //el indice 6 es la col borrar
            if (e.ColumnIndex == 6 && e.RowIndex >= 0) {
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

        /*DRAG DROP*/
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
        /*FIN DRAG DROP*/

        private void _formAdd_ButtonSave_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            bool from = false;
            foreach(Tabla _t in this._formAdd_listBoxTables.Items) {
                if (!from) {
                    _formAdd_rbSQL.Text += "SELECT * FROM "+_t.nombre+" "+_t.alias+"\n";
                    from = true;
                } else {
                    _formAdd_rbSQL.Text += "LEFT JOIN " + _t.nombre + " " + _t.alias + " ON "+_t.alias+"."+_t.relacion.campoorigen.nombre+" = "+ _t.relacion.campodestino.tabla.alias + "."+_t.relacion.campodestino.nombre + "\n";
                }
                
            }
        }
    }
}
