using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto36
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("INgrese un numero entero que represente al atributo Lado: ");
            string entrada = Console.ReadLine();

            Cubo cubito = new Cubo(entrada);

            cubito.calcularArea();
            cubito.calcularVolumen();
            //Console.WriteLine($"El valor de lado del cubo es {cubito.lado}, su area: {cubito.area} y su volumen es {cubito.volumen}");
            Console.ReadKey();
        }
    }
}
