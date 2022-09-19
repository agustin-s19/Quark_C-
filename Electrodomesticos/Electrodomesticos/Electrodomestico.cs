using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    abstract class Electrodomestico
    {
        private int precioBase;
        private string color;
        protected int peso;
        protected string ce;
        protected int precioFinal;
        public int Peso { get; } = 5;
        public string Color { get; } = "blanco";
        public int PrecioBase { get; } = 100;
        public string Ce { get; } = "F";
        int consumoE, precioPeso;

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
            //List<string> list = new List<string>() { "blanco", "negro","azul","rojo","gris"};
           
            if (color != "blanco" || color != "negro" || color != "azul" || color != "rojo" || color != "gris")
            {
                color = "blanco";
            } 
            
        }

        public virtual void PrecioFinal()
        {
            
            if (peso >= 1 && peso <= 19) {
                precioPeso = 10;
             }
             else if(peso >= 20 && peso <= 49)
            {
                precioPeso = 50;
            }
             else if( peso >= 50 && peso <= 79)
            {
                precioPeso = 80;
            }
             else if(peso > 80) 
            {
                precioPeso = 100;
            }
            

            precioFinal = precioBase + consumoE+ precioPeso;
                ; 
            Console.WriteLine($"El precio final del producto es de {precioFinal}");
        }

        
    }
}
      


