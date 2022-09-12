using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto34
{
    internal class Program
    {

        //static void Main(string[] args)
        //{
        //    bool continua;
        //    do
        //    {
        //        try
        //        {
        //            continua = false;
        //            int v1;
        //            Console.WriteLine("Ingresa valor 1:");
        //            v1 = int.Parse(Console.ReadLine());

        //            Console.WriteLine($"El cuadrado de {v1} es {v1 * v1}");

        //        }
        //        catch (FormatException e)
        //        {
        //            Console.Clear();
        //            Console.WriteLine("Solo puede ingresar numeros");
        //            Console.WriteLine();
        //            continua = true;
        //        }
        //    } while (continua);

        //    Console.ReadKey();
        //}
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese el valor para dividir: ");
                var num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo valor: ");
                var num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"La division entre {num1} y {num2} es {num1 / num2}");
            }
            catch(FormatException e)
            {
                Console.Write("Debe ingresar obligatoriamente numeros enteros");
            }
            catch(DivideByZeroException e)
            {
                Console.Write("No se puede dividir por cero");
            }
            Console.ReadKey();
        }
    }
}
