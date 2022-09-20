using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Electrodomestico
    {
        protected int precioBase = 100;
        protected string color = "blanco";
        protected int peso = 10;
        protected string ce = "F";
        public int precioFinal;
        protected int consumoE, precioPeso;
        public int PrecioBase
        {
            get => precioBase;
            set
            {
                precioBase = value;
            }
        }
        public string Color { 
            get => color;
            set 
            {
                 color = value;
            }
        }
        public int Peso
        {
            get => peso;
            set
            {
                peso = value;
            }
        }

        public string Ce { get=>ce;
            set {
                ce = value;
            } 
        }
       

        public Electrodomestico()
        {
            comprobarConsumoEnergetico(ce);
            comprobarColor(color);
            
        }
        public Electrodomestico(int precioBase, int peso) {

            this.precioBase = precioBase;
            this.peso = peso;
            color = "blanco";
            ce = "F";
            comprobarConsumoEnergetico(ce);
            comprobarColor(color);
            CalcularPrecioFinal();

        }


        public Electrodomestico(int precioBase, string color, int peso, string ce)
        {
            this.precioBase = precioBase;
            this.color = color;
            this.peso = peso;
            this.ce = ce;
            comprobarConsumoEnergetico(ce);
            comprobarColor(color);
            CalcularPrecioFinal();
        }

        

        protected void comprobarConsumoEnergetico(string ce) {
          
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

        public virtual void CalcularPrecioFinal()
        {
            comprobarConsumoEnergetico(ce);
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

            
        }

        
    }
}
      


