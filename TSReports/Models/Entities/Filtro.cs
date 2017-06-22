using System.Collections.Generic;
using System.Windows.Forms;

namespace TSReports.Models.Entities
{
    class Filtro
    {
        public int id;
        public string descripcion;
        public string tipodato;
        public bool visible;
        public bool requerido;
        public string valor;
        public int orden;
        public Control[] control;

        public Filtro parseControl()
        {
                if (this.control[1] is NumericUpDown) {
                    this.valor = ((NumericUpDown)this.control[1]).Value.ToString();
                } else if (this.control[1] is TextBox) {
                    this.valor = ((TextBox)this.control[1]).Text;
                } else if (this.control[1] is CheckBox) {
                    this.valor = ((CheckBox)this.control[1]).Checked ? "1" : "0";
                } else if (this.control[1] is DateTimePicker) {
                    this.valor = ((DateTimePicker)this.control[1]).Value.ToString("yyyy-MM-dd HH:mm:ss");
                }
            return this;
        }
    }
}
