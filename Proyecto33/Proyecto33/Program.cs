using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto33
{

    class OperacionNumeros
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        public OperacionNumeros()
        {
            MenuOpciones();
        }
        private void MenuOpciones() {
        
        string opciones = (@"
1 - Carga de 2 valores
2 - Mostrar la suma
3 - Mostrar la resta
4 - Mostrar el producto
5 - Mostrar la division
6 - Finalizar");
            int op;
            do
            {
                Console.WriteLine(opciones);
                Console.WriteLine("elija su opcion: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Cargar();
                        break;
                    case 2:
                        Console.WriteLine($"La suma entre {Numero1} y {Numero2} es {Numero1 + Numero2}");
                        break;
                    case 3:
                        Console.WriteLine($"La resta entre {Numero1} y {Numero2} es {Numero1 - Numero2}");
                        break;
                    case 4:
                        Console.WriteLine($"El producto entre {Numero1} y {Numero2} es {Numero1 * Numero2}");
                        break;
                    case 5:
                        Console.WriteLine($"La division entre {Numero1} y {Numero2} es {Numero1 / Numero1}");
                        break;


                }
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();

            } while (op != 6);
           
        }
        private void Cargar()
        {
            Console.Write("Ingresar Valor:");
            Numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrsear Segundo Valor: ");
            Numero2 = int.Parse(Console.ReadLine());
        

        }
}
    internal class Program
    {

        static void Main(string[] args)
        {
            new OperacionNumeros();
        }
    }
}
