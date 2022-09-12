using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto22
{
    internal class Program
    {
        // Parametros opcionales
        //public void Imprimir(string palabra, int col = 1, int fil= 1)
        //{
        //    Console.SetCursorPosition(fil, col);
        //    Console.WriteLine(palabra);
        //}
        //static void Main(string[] args)
        //{
        //    Program ob1 = new Program();
        //    ob1.Imprimir("Hola");
        //    ob1.Imprimir("Buenas", 1);
        //    ob1.Imprimir("Aloha", 2, 4);
        //    Console.ReadKey();
        //}
        //Ejercicio 2
        //public void Pares(int cant = 10)
        //{
        //    for (int i = 1; i <= cant; i++)
        //    {
        //        int par = i * 2;
        //        Console.WriteLine(par);
        //    }

        //}
        //static void Main(string[] args)
        //{
        //    Program ob2 = new Program();
        //    ob2.Pares();
        //    ob2.Pares(20);
        //    Console.ReadKey();
        //}

        //Parametros sin orden

        //public void Imprimir(string mensaje,int fil, int col ){
        //    Console.SetCursorPosition(fil, col);
        //    Console.WriteLine(mensaje);
        //}
        //static void Main(string[] args)
        //{
        //    Program obj3 = new Program();
        //    obj3.Imprimir(fil: 3, col: 5, mensaje: "Hola Rey");
        //    obj3.Imprimir(col: 5, mensaje: "Adeus", fil: 20);
        //    Console.ReadKey();
        //}
        //sobrecarga de metodos
        //public int Sumar(int x1,int x2)
        //{
        //    int sum = x1 + x2;
        //    return sum;
        //}
        //public string Sumar(string x1, string x2)
        //{
        //    string sum = x1 + x2;
        //    return sum;
        //}
        //static void Main(string[] args)
        //{
        //    Program obj4 = new Program();
        //    Console.WriteLine(obj4.Sumar("Hola", "Rey"));
        //    Console.WriteLine(obj4.Sumar(22, 48));
        //    Console.ReadKey();
        //}
        //Sobrecarga de metodos
        //public void Mostrar(string mensaje)
        //{
        //    Console.WriteLine(mensaje);
        //}
        //public void Mostrar(string mensaje,int fil,int col)
        //{
        //    Console.SetCursorPosition(col, fil);
        //    Console.WriteLine(mensaje);
        //}
        //public void Mostrar(string mensaje, int fil, int col, ConsoleColor colorletra)
        //{
        //    Console.ForegroundColor = colorletra;
        //    Mostrar(mensaje, col, fil);
        //}

        //public void Mostrar(string mensaje, int fil, int col, ConsoleColor colorletra, ConsoleColor colorfondo)
        //{
        //    Console.BackgroundColor = colorfondo;
        //    Mostrar(mensaje, col, fil, colorletra);
        //}
        //static void Main(string[] args)
        //{
        //    Program v = new Program();
        //    v.Mostrar("Buenas");
        //    v.Mostrar("Buenas", 1, 1);
        //    v.Mostrar("Buenas", 10, 10, ConsoleColor.Red);
        //    v.Mostrar("Adiosito", 20, 20, ConsoleColor.Green, ConsoleColor.White);
        //    Console.ReadKey();

        //}
        private string name;
        private int fila;
        private int columna;
        public Program(string titulo)
        {
            name = titulo;
            fila = 1;
            columna = 1;
        }
        public Program(string name, int fila, int columna) : this(name)
        {
            this.fila = fila;
            this.columna = columna;
        }
        public void Imprimir() {
            Console.SetCursorPosition(fila, columna);
            Console.WriteLine(name);
            
        }
        static void Main(string[] args)
        {
            Program nuevo = new Program("Titulo");
            nuevo.Imprimir();
            Program nuevo2 = new Program("Titulo2", 11, 20);
            nuevo2.Imprimir();
            Console.ReadKey();
        }
    }
}
