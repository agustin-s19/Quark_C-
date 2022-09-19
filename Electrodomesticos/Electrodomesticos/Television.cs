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

        public bool Sintetizador { get;} = false;
        protected int Resolucion { get; } = 20;
       
        public Television() { 
        
        }
        public Television(int precio, int peso)
        {

        }

        public Television(float resolucion,bool sintetizador)
        {

        }
        public override void PrecioFinal()
        {
            
            if (resolucion >= 40)
            {
                if (sintetizador == true)
                {
                    precioFinal * 1.5;
                }
                precioFinal = precioFinal * 1.3;
            }
            
        }
    }
}
