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

        public int Carga { get; } = 5;

        public Lavadora()
        {

        }
        public Lavadora(int precio, int peso)
        {

        }
        public Lavadora(int carga, int precioBase, string color, int peso, string ce)
        {
            this.precioBase = precioBase;
            this.carga = carga;
            base.Color = color;
            base.Peso = peso;
            base.ce = ce;
        }

        public Lavadora(int carga)
        {
            this.carga = carga;
           
        }

        public override void CalcularPrecioFinal()
        {
            
            base.CalcularPrecioFinal();
            if (carga >= 30)
            {
                precioCarga = 50;
                precioFinal = precioCarga + precioFinal;
            }
            else
            {
                precioCarga = 0;
                precioFinal = precioCarga + precioFinal;
            }

            Console.WriteLine($"El precio final de la lavadora es de {precioFinal}");
        }
    }
}
