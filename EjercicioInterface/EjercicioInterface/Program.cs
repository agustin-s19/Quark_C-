using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Impresora impresora1 = new Impresora();
            impresora1.AgregarImprimible("foto");
            impresora1.AgregarImprimible("documento");
            impresora1.AgregarImprimible("contrato");
            impresora1.ImprimirTodo();
            Console.ReadKey();
        }
    }
}
