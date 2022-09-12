using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto29
{
    //DELEGADOS
    //delegate int Operar(int x1, int x2);

    //class Program
    //{
    //    public int Sumar(int x, int y)
    //    {
    //        return x + y;
    //    }

    //    public int Restar(int x, int y)
    //    {
    //        return x - y;
    //    }

    //    public void operacion(Operar d, int x, int y)
    //    {
    //        Console.WriteLine(d(10, 5));
    //    }

    //    static void Main(string[] args)
    //    {
    //        Program p = new Program();
    //        Console.WriteLine("Suma y resta de 10 y 5.");
    //        p.operacion(p.Sumar, 10, 5);
    //        p.operacion(p.Restar, 10, 5);
    //        Console.ReadKey();
    //    }
    //}
    delegate int Operacion(int x, int y);
    class Program
    {
        static int Operar(Operacion p, int x, int y)
        {
            return p(x, y);
        }

        static void Main(string[] args)
        {
            var suma = Program.Operar((x, y) => { return x + y; },10, 3);
            Console.WriteLine(suma);
            var resta = Program.Operar((x, y) => { return x - y; }, 20, 3);
            Console.WriteLine("El resultado de la rets es {0}", resta);
            Console.ReadKey();
        }
    }
}