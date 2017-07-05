using System;
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
    public partial class FormElegirTabla : Form
    {
        List<Tabla> tablas { get; set; }
        private string origen;
        private Tabla tablaSeleccionada;

        public FormElegirTabla()
        {
            InitializeComponent();

        } 

        public FormElegirTabla(string origen, ListBox.ObjectCollection tablas)
        {
            InitializeComponent();
            this.origen = origen; 
            this.label1.Text += " '" + this.origen + "' con:";
            this.listBox1.ValueMember = "id";
            this.listBox1.DisplayMember = "titulo";
            this.listBox1.Items.AddRange(tablas);
           
        }

        private void FormElegirTabla_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1) {
                MessageBox.Show("Debe seleccionar una tabla para relacionar: "+ this.origen);
                return;
            }
            this.tablaSeleccionada = (Tabla)listBox1.SelectedItem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        internal Tabla getTablaSeleccionada()
        {
            return tablaSeleccionada;
        }
    }
}
