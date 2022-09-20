using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    internal class Television: Electrodomestico
    {
        private int resolucion;
        private bool sintetizador;

        public bool Sintetizador { get;  } = false;
        public int Resolucion { get;  } = 20;
       
        public Television() { 
        
        }
        public Television(int precio, int peso)
        {

        }

        public Television(int resolucion, bool sintetizador, int precioBase, string color, int peso, string ce)
        {
            this.resolucion = resolucion;
            this.sintetizador = sintetizador;
            base.precioBase = precioBase;
            base.color = color;
            base.peso = peso;
            base.ce = ce;
        }
        public override void CalcularPrecioFinal()
        {

            base.CalcularPrecioFinal();
            if (resolucion >= 40)
            {
                if (sintetizador != true)
                {
                    precioFinal = Convert.ToInt32(precioFinal * 1.3);
                }
                precioFinal = Convert.ToInt32(precioFinal * 1.5);
            }

            Console.WriteLine($"El precio final del televisor es de {precioFinal}");
        }
    }
}

