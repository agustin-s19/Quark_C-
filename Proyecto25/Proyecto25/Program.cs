using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto25
{
    //DEFINICION DE PROPIEDADES AUTOMATICAS
    //class Cuadrado
    //{
    //    public int Lado
    //    {
    //        get;set;
    //    }
    //    public int RetornarSuperficie()
    //    {
    //        return Lado * Lado;
    //    }
    //    static void Main(string[] args)
    //    {
    //        Cuadrado l1 = new Cuadrado();
    //        l1.Lado = 10;
    //        Console.Write(l1.RetornarSuperficie());
    //        Console.ReadKey();
    //    }
    //}
    //
    class Triangulo
    {
        public int Lado1 { get; set; } = 5;
        public int Lado2 { get; set; } = 5;
        public int Lado3 { get; set; } = 5;

        public int RetornarPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }

    static void Main(string[] args)
        {
            Triangulo obj = new Triangulo { Lado1 = 20, Lado2 = 30, Lado3 = 10 };
            Console.WriteLine(obj.RetornarPerimetro());
            Triangulo triangulo2 = new Triangulo { Lado2 = 10 };
            Console.WriteLine((triangulo2.RetornarPerimetro()));
            Console.ReadKey();
        }
    }

}
