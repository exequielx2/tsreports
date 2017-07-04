using System.Collections.Generic;
using System.Windows.Forms;

namespace TSReports.Models.Entities
{
    class Filtro
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public string tipodato { get; set; }
        public bool visible { get; set; }
        public bool requerido { get; set; }
        public string valor { get; set; }
        public int orden { get; set; }
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
