using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Electrodomestico
    {
        private int precioBase;
        private string color;
        protected int peso;
        protected string ce;

     
        public Electrodomestico()
        {
            comprobarConsumoEnergetico(ce);
            comprobarColor(color);
            PrecioFinal();
        }
        public Electrodomestico(int precioBase, int peso) {

            this.precioBase = precioBase;
            this.peso = peso;
            color = "blanco";
            ce = "F";
            comprobarConsumoEnergetico(ce);
            comprobarColor(color);
            PrecioFinal();

        }


        public Electrodomestico(int precioBase, string color, int peso, string ce)
        {
            this.precioBase = precioBase;
            this.color = color;
            this.peso = peso;
            this.ce = ce;
            comprobarConsumoEnergetico(ce);
            comprobarColor(color);
            PrecioFinal();
        }

        public int Peso { get; } = 5;
        public string Color { get;  } = "blanco";
        public int PrecioBase { get; } = 100;
        public string Ce { get;} = "F";
        int consumoE;

        private void comprobarConsumoEnergetico(string ce) {
            switch (ce)
            {
                case "A":
                    consumoE = 100;
                    break;
                case "B":
                    consumoE = 80;
                    break;
                case "C":
                    consumoE = 60;
                    break;
                case "D":
                    consumoE = 50;
                    break;
                case "E":
                    consumoE = 30;
                    break;
                case "F":
                    consumoE = 10;
                    break;
                default:
                    consumoE = 10;
                    break;   
            }
        }
        private void comprobarColor(string color)
        {
            switch (color)
            {
                case "blanco":
                    color = "blanco";
                    break;
                case "negro":
                    color = "negro";
                    break;
                case "rojo":
                    color = "rojo";
                    break;
                case "azul":
                    color = "azul";
                    break;
                case "gris":
                    color = "gris";
                    break;
                default:
                    color = "blanco";
                    break;

            }
        }

        public void PrecioFinal()
        {
            int precioFinal;

            precioFinal = precioBase + consumoE+ peso;
                ; 
            Console.WriteLine($"El precio final del producto es de {precioFinal}");
        }

        
    }
}
      


