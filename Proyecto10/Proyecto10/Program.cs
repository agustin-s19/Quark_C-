using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto10
{

    //ORDEN DE EJECUCION DE LOS CONSTRUCTORES CON HERENCIA
    //public class A
    //{
    //    public A(){
    //    Console.WriteLine("Constructor de la clase A");
    //    }
    //}
    //public class B: A
    //{
    //    public B()
    //    {
    //        Console.WriteLine("Constructor de la clase B");
    //    }
    //}
    //public class C : B
    //{
    //    public C()
    //    {
    //        Console.WriteLine("Constructor de la clase C");
    //    }


    //}
    //public class Resolver { 
    //    static void Main(string[] args)
    //    {
    //        C ejemplo = new C();
    //        Console.ReadKey();


    //    }
    //}

    // Ejercicio 2
    //public class A
    //{
    //    public A(int a)
    //    {

    //        Console.WriteLine(a);
    //    }

    //}
    //public class B : A
    //{
    //    public B(int b) : base(b / 2)
    //    {
    //        Console.WriteLine(b);
    //    }
    //}
    //public class C : B
    //{
    //    public C(int c) : base(c / 2)
    //    {
    //        Console.WriteLine(c);
    //    }
    //}
    //public class Resolver
    //{

    //    static void Main(string[] args)
    //    {
    //        C prueba = new C(20);
    //        Console.ReadKey();
    //    }
    //}
    class Prueba
    {
        static void Main(string[] args)
        {
            Rectangulo rect = new Rectangulo();
            rect.Lado1 = 20;
            rect.Lado2 = 60;
            rect.RetornarPerimetro();
            rect.RetornarSuperficie();
            Console.ReadKey();
        }
    }
}
