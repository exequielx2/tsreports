using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSReports.Models.Entities;

namespace TSReports.Views
{
    public partial class FormChooseTable : Form
    {
        public object respuesta;
        private dynamic resp;
        private TreeView tree1aux;
        private TreeView tree2aux;
        bool tree1checked = false;
        bool tree2checked = false;
        public FormChooseTable()
        {
            InitializeComponent();
        }

        public FormChooseTable(dynamic resp)
        {
            this.resp = resp;
            InitializeComponent();
            
        }

        public int idtablaelegida { get; set; }

        private void _formChoseColumns_buttonOk_Click(object sender, EventArgs e)
        {
            object relacionorigen;
            object relaciondestino;
            if (tree1checked == true && tree2checked == true)
            {
                relacionorigen = new { tabladestino = treeView1.Nodes[0].Tag, campoorigen = treeView1.Nodes[0].Nodes[0].Tag};
                relaciondestino = new { tabladestino = treeView2.Nodes[0].Tag, campoorigen = treeView2.Nodes[0].Nodes[0].Tag };
                respuesta = new { relacionorigen, relaciondestino };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar por lo menos un item de cada lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void FormChooseTable_Load(object sender, EventArgs e)
        {
            var list = new ArrayList();
            tree1aux = new TreeView();
            tree2aux = new TreeView();

            foreach (dynamic objresp in resp.data)
            {
                if (objresp.discriminador == "origen")
                {
                    foreach (dynamic destinos in objresp.destino)
                    {
                        TreeNode nododestino = new TreeNode((string)destinos.nombre);
                        nododestino.Tag = new { id = destinos.id, nombre = destinos.nombre, titulo = destinos.titulo};
                        int indexdestino = treeView1.Nodes.Add(nododestino);
                        tree1aux.Nodes.Add((TreeNode)nododestino.Clone());
                        foreach (dynamic campos in destinos.campos)
                        {
                            TreeNode nodocampos = new TreeNode((string)campos.campo_origen + "-" + (string)campos.campo_destino);
                            nodocampos.Tag = campos;
                            treeView1.Nodes[indexdestino].Nodes.Add(nodocampos);
                            tree1aux.Nodes[indexdestino].Nodes.Add((TreeNode)nodocampos.Clone());
                        }
                    }
                    groupBox2.Text = objresp.nombre+" a: ";
                }
                else if (objresp.discriminador == "destino")
                {
                    foreach (dynamic destinos in objresp.destino)
                    {
                        TreeNode nododestino = new TreeNode((string)objresp.nombre);
                        nododestino.Tag = new { id = destinos.id, nombre = destinos.nombre, titulo = destinos.titulo };
                        int indexdestino = treeView2.Nodes.Add(nododestino);
                        tree2aux.Nodes.Add((TreeNode)nododestino.Clone());
                        groupBox3.Text = destinos.nombre+" desde: " ;
                        foreach (dynamic campos in destinos.campos)
                        {
                            TreeNode nodocampos = new TreeNode((string)campos.campo_origen + "-" + (string)campos.campo_destino);
                            nodocampos.Tag = campos;
                            treeView2.Nodes[indexdestino].Nodes.Add(nodocampos);
                            tree2aux.Nodes[indexdestino].Nodes.Add((TreeNode)nodocampos.Clone());
                        }
                    }
                }
            }
            }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            string nombre_padre = "";
            if (e.Node.Level == 0)
            {
                if (tree1checked)
                {
                    eliminarseleccion();
                }
                return;
            }
            if (tree1checked == false)
            {
                if (e.Node.Parent != null)
                {
                    e.Node.Parent.Checked = true;
                    nombre_padre = e.Node.Parent.Text;

                }
                for (int i = 0; i < treeView1.Nodes.Count; i++)
                {
                    TreeNode nodo = treeView1.Nodes[i];
                    if (!nodo.Checked)
                    {
                        treeView1.Nodes.Remove(nodo);
                        i--;
                    }
                    else
                    {
                        for (int j = 0; j < nodo.Nodes.Count; j++)
                        {
                            TreeNode nodohijo = treeView1.Nodes[i].Nodes[j];
                            if (nodohijo.Checked == false)
                            {
                                treeView1.Nodes.Remove(nodohijo);
                                j--;
                            }
                        }
                    }
                }
                tree1checked = true;
                for (int i = 0; i < treeView2.Nodes.Count; i++)
                {
                    if(treeView2.Nodes[i].Text != nombre_padre)
                    {
                        TreeNode t2nodo = treeView2.Nodes[i];
                        treeView2.Nodes.Remove(t2nodo);
                        i--;
                    }
                    else
                    {
                        treeView2.Nodes[i].Expand();
                    }
                }
            }
            else
            {
                eliminarseleccion();
            }
        }

        private void treeView2_AfterCheck(object sender, TreeViewEventArgs e)
        {
            string nombre_padre = "";
            if (e.Node.Level == 0)
            {
                if (tree2checked)
                {
                    eliminarseleccion();
                }
                return;
            }
            if (tree2checked == false)
            {
                if (e.Node.Parent != null)
                {
                    e.Node.Parent.Checked = true;
                    nombre_padre = e.Node.Parent.Text;
                }
                for (int i = 0; i < treeView2.Nodes.Count; i++)
                {
                    TreeNode nodo = treeView2.Nodes[i];
                    if (!nodo.Checked)
                    {
                        treeView2.Nodes.Remove(nodo);
                        i--;
                    }
                    else
                    {
                        for (int j = 0; j < nodo.Nodes.Count; j++)
                        {
                            TreeNode nodohijo = treeView2.Nodes[i].Nodes[j];
                            if (nodohijo.Checked == false)
                            {
                                treeView2.Nodes.Remove(nodohijo);
                                j--;
                            }
                        }
                    }
                }
                tree2checked = true;
                for (int i = 0; i < treeView1.Nodes.Count; i++)
                {
                    if (treeView1.Nodes[i].Text != nombre_padre)
                    {
                        TreeNode t1nodo = treeView1.Nodes[i];
                        treeView1.Nodes.Remove(t1nodo);
                        i--;
                    }
                    else
                    {
                        treeView1.Nodes[i].Expand();
                    }
                }
            }
            else
            {
                eliminarseleccion();
            }
        }
        private void eliminarseleccion()
        {
            treeView2.Nodes.Clear();
            treeView1.Nodes.Clear();
            foreach (TreeNode nodo in tree2aux.Nodes)
            {
                treeView2.Nodes.Add((TreeNode)nodo.Clone());
            }
            foreach (TreeNode nodo in tree1aux.Nodes)
            {
                treeView1.Nodes.Add((TreeNode)nodo.Clone());
            }
            tree1checked = false;
            tree2checked = false;
        }
    }
}
