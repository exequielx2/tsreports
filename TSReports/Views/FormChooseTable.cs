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
        public FormChooseTable()
        {
            InitializeComponent();
        }

        public FormChooseTable(dynamic resp)
        {
            var list = new ArrayList();
            foreach (dynamic objresp in resp.data) {
                int c_origen = objresp["id_campo_origen"];
                int c_destino = objresp["id_campo_destino"];
                int t_origen = objresp["id_tabla_origen"];
                int t_destino = objresp["id_tabla_destino"];
                string nombre_tabla_origen = objresp["tabla_origen"];
                string nombre_tabla_destino = objresp["tabla_destino"];
                string nombre_campo_origen = objresp["campo_origen"];
                string nombre_campo_destino = objresp["campo_destino"];
                 

                list.Add(new KeyValuePair<int, string>(t_destino, nombre_tabla_origen + " -> " + nombre_tabla_destino + "[" + nombre_campo_origen + "->" + nombre_campo_destino + "]"));
            }
        }

        public int idtablaelegida { get; set; }

        private void _formChoseColumns_buttonOk_Click(object sender, EventArgs e)
        {
            this.idtablaelegida = (int)_formChoseColumns_listBoxDestinos.SelectedItem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
