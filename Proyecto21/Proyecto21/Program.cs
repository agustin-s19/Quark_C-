using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto21
{
    class Program
    {
        //private int[] vec;
        //public Program(){
        //    Console.WriteLine("Cuantos numeros ingresara: ");
        //    int tam = int.Parse(Console.ReadLine());
        //    vec = new int[tam];
        //}
        //public void Cargar()
        //{
        //    for(var i = 0; i< vec.Length; i++)
        //    {
        //        Console.WriteLine("Ingrese el numero: ");
        //        vec[i] = int.Parse(Console.ReadLine());
        //    }
        //}
        //public void MayorMenor(out int may, out int men)
        //{
        //    may = vec[0];
        //    men = vec[0];
        //    for(var i = 0; i< vec.Length; i++)
        //    {
        //        if(vec[i] > may)
        //        {
        //            may = vec[i];
        //        }
        //        else
        //        {
        //            if (vec[i] < men)
        //            {
        //                men = vec[i];
        //            }
        //        }
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Program p = new Program();
        //    p.Cargar();
        //    int ma, me;
        //    p.MayorMenor(out ma, out me);
        //    Console.WriteLine("El menor numero de la lista es " + me);
        //    Console.WriteLine("El mayor numero de la lista es " + ma);
        //    Console.ReadKey();

        //}

        //ejercicio2
        // public void DosValores(out int valor1, out int valor2)
        //{
        //    Random r = new Random();
        //    valor1 = r.Next(1, 101);
        //    valor2 = r.Next(1, 101);
        //    Console.WriteLine("Valor 1: " + valor1);
        //    Console.WriteLine("Valor 2: "+valor2);
        //}
        //static void Main(string[] args)
        //{
        //    int alea1, alea2;
        //    Program programita = new Program();
        //    programita.DosValores(out alea1, out alea2);
        //    Console.ReadKey();
        //}

        //public int Parametros(params int[] vec)
        //{
        //    int su = 0;

        //    for(int i = 0; i < vec.Length; i++)
        //    {
        //        su = vec[i] + su;
        //    }
        //    return su;
        //}

        //static void Main(string[] args)
        //{
        //    Program pro = new Program();
        //    Console.WriteLine("La suma de los valores da comop resultado: ");
        //    Console.WriteLine(pro.Parametros(10, 40, 50,100,110,5000,103,200));
        //    Console.ReadKey();
        //}

        public void SumaOProducto(string cuenta, params int[] vec)
        {

            if (cuenta == "suma" || cuenta == "Suma")

            {
                int suma = 0;
                for (int i = 0; i < vec.Length; i++)
                {
                    suma = suma + vec[i];
                }
                Console.WriteLine("La suma de lo solicitado es: " + suma);
            }
            else
            {
                if (cuenta == "producto" || cuenta == "Producto")
                {
                    int producto = 1;
                    for (int i = 0; i < vec.Length; i++)
                    {
                        producto = producto * vec[i];
                    }
                    Console.WriteLine("El producto de lo solicitado es: " + producto);
                }
                else
                {
                    Console.WriteLine("Verifique si escribio bien el nombre de la operacion");
                }
            }
            
        }
        static void Main(string[] args)
        {
            Program ejercicio2 = new Program();
            Console.WriteLine("Ingrese que operacion desea realizar: ");
            string operacion = Console.ReadLine();
            ejercicio2.SumaOProducto(operacion, 20,5,100);
            Console.ReadKey();
        }
    }

    
}