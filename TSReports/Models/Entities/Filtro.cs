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
        public Control control;

        public Filtro parseControl()
        {
            if (this.control is NumericUpDown) {
                this.valor = ((NumericUpDown)this.control).Value.ToString();
            }else if (this.control is TextBox) {
                this.valor = ((TextBox)this.control).Text;
            } else if (this.control is CheckBox) {
                this.valor = ((CheckBox)this.control).Checked ? "1" : "0";
            } else if (this.control is DateTimePicker) {
                this.valor = ((DateTimePicker)this.control).Value.ToString("yyyy-MM-dd HH:mm:ss");
            }
            return this;
        }
    }
}
