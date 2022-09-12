using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto36
{
    class Cubo
    {
        //atributos
        private int lado;
        private int area;
        private int volumen;

        //constructor
        public Cubo()
        {
            lado = 5;
            area = 0;
            volumen = 0;
        }

        public Cubo(string lado)
        {
            int numero = 0;
            // primero hace referencia al atributo de la clase, el parametro lado hace referencia al parametro que necesita el constructor
            try
            {
                numero = int.Parse(lado);
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
            this.lado = numero;
        }

        //propiedades getters y setters
        public int Lado
        {
            get
            {
                return lado;
            }
            set
            {
                lado = value;
            }
        }
        
    public void calcularArea()
        {
            area = (lado * lado)*6;
            Console.Write($"Area: {area}");
        }
    public void calcularVolumen()
        {
            volumen = lado * lado * lado;
            Console.Write($", Volumen: {volumen}");
        }
    }

}
