using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto31
{
    public delegate void Retorna(int elemento);
    class Admin
    {
        public int[] vec = {100,20,30,400,50 };

        public void Imprimir()
        {
            Console.WriteLine("Litsado completo del vector");
            foreach(var elemento in vec)
            {
                Console.Write("{0} -", elemento);
                Console.WriteLine();
            }
        }
        public void Recorrer(Retorna retorna)
        {
            foreach (var elemento in vec)
            {
                retorna(elemento);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin vector = new Admin();
            vector.Imprimir();
            var multiplos3 = 0;
            vector.Recorrer(elemento => { if (elemento %3 == 0) { multiplos3++; } });
            Console.WriteLine("Aquellos numeros que son multiplos de 3 son: {0}", multiplos3);
            var suma = 0;
            vector.Recorrer(elemento => { if (elemento > 50) { suma += elemento; } });
            Console.WriteLine("La suma de todos los numeros mayores a 50 es: {0}", suma);
            Console.ReadKey();
        }
    }
}
