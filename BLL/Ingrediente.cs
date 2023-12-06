using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Ingrediente
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public double cantidad { get; set; }
        public double Precio { get; set; }
        public double CostoTotal { get; set; }






        public void CalcularCosto() {
            CostoTotal = cantidad * Precio;

        }

    }
}
