using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TorreDeControl t1 = new TorreDeControl();
            t1.agregarVolador("superman");
            t1.agregarVolador("superman");
            t1.agregarVolador("pato");
            t1.vuelenTodos();
            Console.ReadKey();
        }
    }
}
