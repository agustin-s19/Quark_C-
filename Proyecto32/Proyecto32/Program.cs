using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto32
{

    //METODO DE EXTENSION
    //public static class Extension
    //{
    //public static string MitadPrimera(this string cadena)
    //    {
    //        return cadena.Substring(0, cadena.Length / 2);
    //    }
    //public static string SegundaMitad(this string cadena)
    //    {
    //        return cadena.Substring(cadena.Length / 2, cadena.Length / 2);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string cadena1 = "Viento";
    //        Console.WriteLine(cadena1.MitadPrimera());
    //        Console.WriteLine(cadena1.SegundaMitad());
    //        Console.ReadKey();
    //    }
    //}

    //public static class Lista
    //{
    //    public static void Imprimir<T>(this List<T> lista)
    //    {
    //        foreach( var elemento in lista)
    //        {
    //            Console.WriteLine(elemento + " - ");
    //        }
    //    }
    //}
    //class Program{

    //static void Main(string[] args)
    //    {
    //        List<int> lista = new List<int>();
    //        lista.Add(200);
    //        lista.Add(400);
    //        lista.Add(12);
    //        lista.Add(500);
    //        lista.Imprimir();
    //        Console.ReadKey();

    //    }
    //}



    //public static class Extension
    //{
    //    public static void Imprimir(this int val, int fin)
    //    {
    //        for (var inicio = 0; inicio <= fin; inicio++)
    //        {
    //            Console.WriteLine("{0} - ", inicio);
    //        }
    //    }
    //}
    //class Program { 
    //    static void Main(string[] args)
    //    {
    //        10.Imprimir(30);
    //        Console.WriteLine();
    //        int va = 100;
    //        va.Imprimir(150);
    //        Console.ReadKey();


    //    }
    //}
    // INTERPOLACION DE STRING


    //EJEMPLO 1
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int v1 = 20;
    //        int v2 = 30;
    //        int suma = v1 + v2;
    //        Console.WriteLine($"La suma de {v1} + {v2} es igual a {suma}");
    //        Console.WriteLine($"La suma de {v2} + {v1} es igual a {v1 + v2}");
    //        Console.ReadKey();
    //    }
    //}
    //class Program
    //{
    //    public static int Mayor(int x1, int x2)
    //    {
    //        if (x1 < x2)
    //        {
    //            return x2;
    //        }
    //        else
    //        {
    //            return x1;
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Ingrese el primer valor:");
    //        int x1 = int.Parse(Console.ReadLine());
    //        Console.WriteLine("Ingrese el primer valor:");
    //        int x2 = int.Parse(Console.ReadLine());
    //        Console.WriteLine($"El numero mayor entre {x1} y {x2} es {Mayor(x1,x2)}");
    //        Console.ReadKey();

    //    }
    //}
    class Program
    {

        static void Main(string[] args)
        {
            string[] alumnos = { "Juan", "Maria", "Ricardo", "Alfredo" };
            int[] notas = { 10, 2, 7, 8 };
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine($"{alumnos[i],-20}{notas[i],2}");
            }
            Console.ReadKey();
        }
    }
}
