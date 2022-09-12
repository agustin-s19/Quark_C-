using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto14
{
    // public class Recursividad1
    //{
    //    public class Recursividad {

    //        public void Repetir()
    //        {
    //            Console.WriteLine("Hola");
    //            Repetir();
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        Recursividad rec = new Recursividad();
    //        rec.Repetir();
    //    }
    //}
    //public class Recursividad2
    //{
    //    public class Recursividad
    //    {
    //        void Imprimir(int x)
    //        {
    //            Console.WriteLine(x + " ");
    //            Imprimir(x-1);
    //        }

    //        static void Main(string[] args)
    //        {
    //            Recursividad rec = new Recursividad();
    //            rec.Imprimir(5);
    //        }
    //    }

    //}
    //public class Recursividad3
    //{
    //    public class Recursividad
    //    {
    //        void Imprimir(int x)
    //        {
    //            if (x > 0)
    //            {
    //                Console.WriteLine(x);
    //                Imprimir(x - 1);
    //            }
    //        }
    //        static void Main(string[] args)
    //        {
    //            Recursividad re = new Recursividad();
    //            re.Imprimir(5);
    //            Console.ReadKey();
    //        }
    //    }
    //}
    //public class Recursiviodad4
    //{
    //    public class Recursividad
    //    {
    //        int Factor(int x) {
    //            if (x > 0)
    //            {
    //                int valor = x * Factor(x - 1);
    //                return valor;
    //            }
    //            else
    //            {
    //                return 1;
    //            }
    //        }
    //        static void Main(string[] args)
    //        {
    //            Recursividad rec = new Recursividad();
    //            int f = rec.Factor(4);
    //            Console.WriteLine("El factorial de 10 es " + f);
    //            Console.ReadKey();

    //        }
    //    }
        
    //}
    public class Recursividad5 {

        public class Recursividad
        {
            int[] vec = { 204, 304, 20, 1440, 1520, 30, 21 };

            void Ordenar(int[] v, int cant)
            {
                if(cant > 1) { 
                    for (int i = 0; i < cant - 1; i++)
                    {
                        if (v[i] > v[i + 1])
                        {
                            int aux = v[i];
                            v[i] = v[i + 1];
                            v[i + 1] = aux;
                        }
                    }
                    Ordenar(v, cant - 1);
                }
            }
            void Precesar()
            {
                Ordenar(vec, vec.Length);
            }
            void Imprimir()
            {
                for(int i = 0;i< vec.Length; i++)
                {
                    Console.WriteLine(vec[i] + " ");
                    Console.WriteLine();
                }
                Console.WriteLine("Aca finaliza");
            }

            static void Main(string[] args)
            {
                Recursividad recu = new Recursividad();
                recu.Imprimir();
                recu.Precesar();
                recu.Imprimir();
                Console.ReadKey();
            }
        }
    }
}
