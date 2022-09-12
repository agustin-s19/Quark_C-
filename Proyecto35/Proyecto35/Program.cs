using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto35
{

    //public class PersonaAdulta
    //{

    //    public string Name { get; set; }
    //    private int age;
    //    public int Age
    //    {
    //        get
    //        {
    //            return age;
    //        }
    //        set
    //        {
    //            if (value < 18)
    //            {
    //                throw new Exception($"No es adulta la persona {Name} porque tiene {value} años");
    //            }
    //            age = value;
    //        }

    //    }


    //    public PersonaAdulta(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //    public void Imprimir()
    //    {
    //        Console.WriteLine($"{Name} - {Age}");
    //    }
    //}
    //    class Program {
    //        static void Main(string[] args) {

    //        try
    //        {

    //            PersonaAdulta persona2 = new PersonaAdulta("Agustin", 22);
    //            persona2.Imprimir();
    //            PersonaAdulta persona3 = new PersonaAdulta("Jazmin", 17);
    //            persona3.Imprimir();

    //        }
    //        catch(Exception ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //        Console.ReadKey();
    //        }
    //    }

    public class Operaciones
    {
        public int Valor1 { get; set; }
        public int Valor2 { get; set; }
        public Operaciones(int valor1, int valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }
        public int Sumar()
        {
            return Valor1 + Valor2;
        }
        public int Restar()
        {
            return Valor1 - Valor2;
        }
        public int Producto()
        {
            return Valor1 * Valor2;
        }
        public int Division()
        {
            if (Valor2 == 0)
            {
                throw new Exception($"No se puede dividir el valor {Valor1} por 0");
            }
            return Valor1 / Valor2;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Operaciones op = new Operaciones(20,0);
            Console.Write(op.Sumar());
            Console.WriteLine(op.Restar());
            Console.WriteLine(op.Producto());
            try
            {
                Console.WriteLine(op.Division());
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            
            

            Console.ReadKey();

        }
    }

        
        
        // FINALLY

        //static void Main(string[] args)
        //{
        //    StreamWriter txt = null;
        //    try
        //    {
        //        txt = new StreamWriter("datos.txt");
        //        txt.WriteLine("Linea 1");
        //        txt.WriteLine("Linea 2");
        //    }
        //    catch(IOException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    finally
        //    {
        //        if(txt != null)
        //        {
        //            txt.Close();
        //        }
        //    }
        //    StreamReader txtleer = null;
        //    try
        //    {
        //        txtleer = new StreamReader("datos.txt");
        //        string linea = txtleer.ReadLine();
        //        while (linea != null)
        //        {
        //            Console.WriteLine(linea);
        //            linea = txtleer.ReadLine();
        //        }
        //    }catch(IOException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    finally
        //    {
        //        if(txtleer != null)
        //        {
        //            txtleer.Close();
        //        }
        //    }
        //    Console.ReadKey();
        //}









        //CLASE PADRE EXCEPTION
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        Console.WriteLine("Ingrese un valor:");
        //        int valor = int.Parse(Console.ReadLine());
        //        var cuadrado = valor * valor;
        //        Console.WriteLine($"eL CUADRADO DE {valor} es {cuadrado}");
        //    }
        //    catch( FormatException e)
        //    {
        //        Console.WriteLine($"Propiedad Message: {e.Message}\n");
        //        Console.WriteLine($"Propiedad StackTrade: {e.StackTrace}\n ");
        //        Console.WriteLine($"Propiedad Source: {e.Source}\n");
        //        Console.WriteLine($"Propiedad TargetSize: {e.Source}\n");
        //    }
        //    Console.ReadKey();
        //}
    
}
