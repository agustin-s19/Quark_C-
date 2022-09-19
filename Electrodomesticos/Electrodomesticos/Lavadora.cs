using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    internal class Lavadora :  Electrodomestico
    {
        private int carga;
        protected int precioCarga;

        protected int Carga { get; set; } = 5;

        public Lavadora()
        {

        }
        public Lavadora(int precio, int peso)
        {

        }
        public Lavadora(int carga, int precioBase, string color, int peso, string ce)
        {

        }

        public override void PrecioFinal()
        {
            if (carga >= 30)
            {
                precioCarga = 50;
            }
            else
            {
                precioCarga = 0;
            }
        }
    }
}
