using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horasTrabajadas;
            float costoHora;
            float sueldo;
            string linea;
            Console.WriteLine("Escriba Horas trabajadas por el operario: ");
            linea = Console.ReadLine();
            horasTrabajadas = int.Parse(linea);
            Console.WriteLine("Ingrese el pago por hora: ");
            linea = Console.ReadLine();
            costoHora =int.Parse(linea);
            sueldo = horasTrabajadas * costoHora;
            Console.Write("El sueldo total del operario es de ");
            Console.Write("$" + sueldo);
            Console.ReadKey();

        }
    }
}
