using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto20
{
    internal class Program
    {
        //public void MenorOMayor(int menor, int mayor)
        //{
        //    for(var i = menor; i <= mayor; i++)
        //    {
        //        Console.WriteLine(i + " ");
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Program nuevo = new Program();
        //    nuevo.MenorOMayor(60, 300);
        //    Console.ReadKey();

        //}

        //public int elMayor(int x1,int x2,int x3)
        //{


        //    if (x1 >= x2 && x1 >= x3)
        //    {
        //        return x1;
        //    }
        //    else
        //    {
        //        if( x2 >= x1 && x2 >= x3)
        //        {
        //            return x2;
        //        }
        //        else
        //        {
        //            return x3;
        //        }
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Program ejercicio2 = new Program();
        //    Console.WriteLine("Ingrese el componente 1: ");
        //    int x1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Ingrese el componente 2: ");
        //    int x2 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Ingrese el componente 3: ");
        //    int x3 = int.Parse(Console.ReadLine());
        //    Console.WriteLine(ejercicio2.elMayor(x1,x2,x3));
        //    Console.ReadKey();
        //}

        //public void valorAlCastellano(int valor){


        //    switch(valor){
        //        case 1:
        //            Console.WriteLine("Uno");
        //            break;
        //        case 2:
        //            Console.WriteLine("Dos");
        //            break;
        //        case 3:
        //            Console.WriteLine("Tres");
        //            break;
        //        case 4:
        //            Console.WriteLine("Cuatro");
        //            break;
        //        case 5:
        //            Console.WriteLine("Cinco");
        //            break;
        //        case 6:
        //            Console.WriteLine("Seis");
        //            break;
        //        case 7:
        //            Console.WriteLine("Siete");
        //            break;
        //        case 8:
        //            Console.WriteLine("Ocho");
        //            break;
        //        case 9:
        //            Console.WriteLine("Nueve");
        //            break;
        //        case 10:
        //            Console.WriteLine("Diez");
        //            break;
        //        default:
        //            Console.WriteLine("Ingrese un numero del 1 al 10");
        //            break;
        //    } 


        //}
        //static void Main(string[] args)
        //{
        //    Program ejercicio3 = new Program();
        //    Console.WriteLine("Ingrese valor del 1 al 10");
        //    int x = int.Parse(Console.ReadLine());
        //    ejercicio3.valorAlCastellano(x);
        //    Console.ReadKey();
        //}

        // Parametros por referencia
        //public void Intercambiar(ref int valor1, ref int valor2)
        //{
        //    int aux = valor1;
        //    valor1 = valor2;
        //    valor2 = aux;

        //}
        //static void Main(string[] args) {
        //    Program ejercicio1 = new Program();
        //    Console.WriteLine("Ingrese el valor 1");
        //    int x1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Ingrese el valor 2");
        //    int x2 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Actualmente el valor del numero 1 es: " + x1);
        //    Console.WriteLine("Actualmente el valor del numero 2 es: " + x2);
        //    ejercicio1.Intercambiar(ref x1,ref x2);
        //    Console.WriteLine("Ahora el valor del numero 1 es: " + x1);
        //    Console.WriteLine("Actualmente el valor del numero 2 es: " + x2);
        //    Console.ReadKey();


        //} 

        //Ejercicio2

        public void MenorAMayor(ref int v1, ref int v2, ref int v3)
        {
            int menor;
            int intermedio;
            int mayor;
            if (v1 < v2 && v1 < v3)
            {
                menor = v1;

                if (v2 < v3)
                {
                    intermedio = v2;
                    mayor = v3;
                }
                else
                {
                    mayor = v2;
                    intermedio = v3;
                }
            }
            else
            {
                if (v2 <= v3)
                {
                    menor = v2;
                    if (v1 < v3)
                    {
                        intermedio = v1;
                        mayor = v3;
                    }
                    else
                    {
                        intermedio = v1;
                        mayor = v1;
                    }
                }
                else
                {
                    menor = v3;
                    if (v1 < v2)
                    {
                        intermedio = v1;
                        mayor = v2;
                    }
                    else
                    {
                        intermedio = v2;
                        mayor = v1;
                    }
                }
            }


            v1 = menor;
            v2 = intermedio;
            v3 = mayor;


        }


        static void Main(string[] args)
        {
            Program ej2 = new Program();
            Console.WriteLine("Ingrese componente numero 1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese componente numero 2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese componente numero 3: ");
            int x3 = int.Parse(Console.ReadLine());

            Console.WriteLine(x1 + " " + x2 + " " + x3);
            ej2.MenorAMayor(ref x1, ref x2, ref x3);
            Console.WriteLine(x1 + " " + x2 + " " + x3);
            Console.ReadKey();
        }
    }
}
