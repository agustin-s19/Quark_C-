using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto27
{
    class Program
    {
        //LISTAS
        //private static void ImprimirColeccion(List<int> lista)
        //{
        //    for(int i = 0; i < lista.Count; i++)
        //    {
        //        Console.Write(lista[i] + " - ");
        //    }
        //    Console.WriteLine();
        //}
        //private static bool BorrarSiCumple(int valor)
        //{
        //    if(valor > 100)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    List<int> lista = new List<int>();
        //    Console.WriteLine("Cantidad de elementos en la lista: " + lista.Count);
        //    lista.Add(10);
        //    lista.Add(60);
        //    lista.Add(800);
        //    lista.Add(400);
        //    ImprimirColeccion(lista);
        //    lista.Insert(0, 100);
        //    ImprimirColeccion(lista);
        //    lista.Remove(10);
        //    ImprimirColeccion(lista);
        //    lista.RemoveAt(0);
        //    ImprimirColeccion(lista);
        //    lista.RemoveAll(BorrarSiCumple);
        //    ImprimirColeccion(lista);
        //    for (var x = 1; x <= 10; x++)
        //    {
        //        lista.Add(x);
        //    }
        //    ImprimirColeccion(lista);
        //    lista.RemoveRange(0, 4);
        //    ImprimirColeccion(lista);
        //    lista.Sort();
        //    ImprimirColeccion(lista);
        //    lista.Clear();
        //    ImprimirColeccion(lista);

        //}
        private static void ImprimirLista(LinkedList<int> lista)
        {
            LinkedListNode<int> reco = lista.First;
            while (reco != null)
            {
                Console.Write(reco.Value + '-');
                reco = reco.Next;
            }
            Console.WriteLine();
        }
        private static void ImprimirUltimoAlPrimero(LinkedList<int> lista)
        {
            LinkedListNode<int> reco = lista.Last;
            while (reco != null)
            {
                Console.Write(reco.Value + "-");
                reco = reco.Previous;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            LinkedList<int> lista1 = new LinkedList<int>();
            lista1.AddFirst(200);
            lista1.AddFirst(500);
            lista1.AddFirst(300);
            lista1.AddLast(100);
            Console.WriteLine("Imprimimos la lista:");
            ImprimirLista(lista1);
            Console.WriteLine("Cantidad de nodos de la lista: " + lista1.Count);
            ImprimirUltimoAlPrimero(lista1);
            Console.ReadKey();
        }
    }
}
