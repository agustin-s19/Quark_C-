using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto23
{
    // METODOS ESTATICOS
    //class Operacion
    //{
    //    static public int Sumar(int x1, int x2){
    //        int sum = x1 + x2;
    //        return sum;
    //    }
    //    static public int Restar(int x1, int x2)
    //    {
    //        int res = x1 - x2;
    //        return res;
    //    }
    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine(Operacion.Sumar(2, 6));
    //        Console.WriteLine(Operacion.Restar(6, 2));
    //        Console.ReadKey();
    //    }
    //}

    // EJERCICIO 2
    //class Vectores
    //{

    //    public static int Menor(int[] vec) {
    //        int men = vec[0];
    //        for(int i=0; i< vec.Length; i++)
    //        {
    //            if (vec[i]< men)
    //            {
    //                men = vec[i];
    //            }
    //        }
    //        return men;
    //    }
    //    public static int Mayor(int[] vec)
    //    {
    //        int may = vec[0];
    //        for (int i = 0; i < vec.Length; i++)
    //        {
    //            if (vec[i] > may)
    //            {
    //                may = vec[i];
    //            }
    //        }
    //        return may;

    //    }
    //    public static int Suma(int[] vec)
    //    {
    //        int suma = 0;
    //        for (int i = 0;i < vec.Length; i++)
    //        {
    //            suma = suma + vec[i];

    //        }
    //        return suma;
    //    }

    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] v = { 20, 10, 50, 90 };
    //        Console.WriteLine("La suma de los numeros 20+10+50+90 es:");
    //        Console.WriteLine(Vectores.Suma(v));
    //        Console.WriteLine(Vectores.Menor(v));
    //        Console.WriteLine(Vectores.Mayor(v));
    //        Console.ReadKey();
    //    }
    //}
    //class PropiedadesEstaticas
    //{
    //    private string nombre;
    //    private int edad;
    //    public static int cantidad;

    //    public PropiedadesEstaticas(string nom, int ed)
    //    {
    //        cantidad++;
    //        nombre = nom;
    //        edad = ed;
    //    }
    //    public void Imprimir()
    //    {
    //        Console.WriteLine(nombre + " - " + edad);
    //    }

    //}
    //class Program
    //{
    //    static void Main(string [] args)
    //    {
    //        Console.WriteLine("Valor del atributo estatico " + PropiedadesEstaticas.cantidad);
    //        PropiedadesEstaticas per1 = new PropiedadesEstaticas("Ricardo", 23);
    //        per1.Imprimir();
    //        Console.WriteLine("Valor del atributo estatico " + PropiedadesEstaticas.cantidad);
    //        PropiedadesEstaticas per2 = new PropiedadesEstaticas("Ricardo", 23);
    //        per2.Imprimir();
    //        Console.WriteLine("Valor del atributo estatico " + PropiedadesEstaticas.cantidad);
    //        PropiedadesEstaticas per3 = new PropiedadesEstaticas("Ricardo", 23);
    //        per3.Imprimir();
    //        Console.ReadKey();
    //    }
    //}

    //EJERCICIO2
    //class PropiedadesEstaticas
    //{
    //    private string nombre;
    //    private int edad;
    //    private static int cantidad;

    //    public static int Cantidad
    //    {
    //        set
    //        {
    //            cantidad = value;
    //        }
    //        get
    //        {
    //            return cantidad;
    //        }
    //    }

    //    public PropiedadesEstaticas(string nom, int ed)
    //    {
    //        cantidad++;
    //        nombre = nom;
    //        edad = ed;
    //    }
    //    public void Imprimir()
    //    {
    //        Console.WriteLine(nombre + " - " + edad);
    //    }

    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Valor del atributo estatico " + PropiedadesEstaticas.Cantidad);
    //        PropiedadesEstaticas per1 = new PropiedadesEstaticas("Ricardo", 23);
    //        per1.Imprimir();
    //        Console.WriteLine("Valor del atributo estatico " + PropiedadesEstaticas.Cantidad);
    //        PropiedadesEstaticas per2 = new PropiedadesEstaticas("Ricardo", 23);
    //        per2.Imprimir();
    //        Console.WriteLine("Valor del atributo estatico " + PropiedadesEstaticas.Cantidad);
    //        PropiedadesEstaticas per3 = new PropiedadesEstaticas("Ricardo", 23);
    //        per3.Imprimir();
    //        Console.ReadKey();
    //    }
    //}
    static class Operaciones
    {
        public static int Sumar(int x1, int x2)
        {
            return x1 + x2;
        }
        public static int Restar(int x1, int x2)
        {
            return x1 - x2;
        }
        public static int Producto(int x1, int x2)
        {
            return x1 * x2;
        }
        public static int Division(int x1, int x2)
        {
            return x1 / x2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Operaciones.Sumar(20, 60));
            Console.WriteLine(Operaciones.Restar(60, 20));
            Console.WriteLine(Operaciones.Producto(20, 20));
            Console.WriteLine(Operaciones.Division(200,10));
            Console.ReadKey();
        } 
    }
}
