using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto26
{
    
    // CLASE GENERICA
    //    class Persona
    //    {
    //        public string Nombre
    //        {
    //            get; set;
    //        }
    //        public int Edad
    //        {
    //            get; set;
    //        }
    //        public override string ToString()
    //        {
    //            return "(" + Nombre + "-" + Edad + ")";
    //        }
    //    }
    //    class ListaGenerica<T>
    //    {
    //        class Nodo
    //        {
    //            public T Info { get; set; }
    //            public Nodo sig { get; set; }
    //        }
    //        private Nodo raiz;
    //        public ListaGenerica()
    //        {
    //            raiz = null;
    //        }
    //        public int Cantidad()
    //        {
    //            int cant = 0;
    //            Nodo reco = raiz;
    //            while(reco != null)
    //            {
    //                cant++;
    //                reco = reco.sig;
    //            }
    //            return cant;
    //        }
    //        public void Insertar(int pos, T x)
    //        {
    //            if (pos <= Cantidad() + 1) {
    //                Nodo nuevo = new Nodo();
    //                nuevo.Info = x;
    //                if(pos == 1)
    //                {
    //                    nuevo.sig = raiz;
    //                    raiz = nuevo;
    //                }
    //                else
    //                {
    //                    if (pos == Cantidad() + 1)
    //                    {
    //                        Nodo reco = raiz;
    //                        while(reco.sig != null)
    //                        {
    //                            reco = reco.sig;
    //                        }
    //                        reco.sig = nuevo;
    //                        nuevo.sig = null;
    //                    }
    //                    else
    //                    {
    //                        Nodo reco = raiz;
    //                        for(int i = 0; i < pos; i++)
    //                        {
    //                            reco = reco.sig;
                               
    //                        }
    //                        Nodo siguiente = reco.sig;
    //                        reco.sig = nuevo;
    //                        nuevo.sig = siguiente;
    //                    }
    //                }
    //            }
    //        }
    //        public T Extraer(int pos)
    //        {
    //            T informacion;
    //            if(pos == 1)
    //            {
    //                informacion = raiz.Info;
    //                raiz = raiz.sig;
    //            }
    //            else
    //            {
    //                Nodo reco;
    //                reco = raiz;
    //                for(int i=0; i<pos; i++)
    //                {
    //                    reco = reco.sig;
    //                }
    //                Nodo prox = reco.sig;
    //                reco.sig = prox.sig;
    //                informacion = prox.Info;
    //            }
    //            return informacion;
    //        }
    //        public void Imprimir()
    //        {
    //            Nodo reco = raiz;
    //            while(reco != null)
    //            {
    //                Console.Write(reco.Info + "-");
    //                reco = reco.sig;
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //    class Program { 
    //    static void Main(string[] args)
    //    {
    //        ListaGenerica<int> lista1 = new ListaGenerica<int>();
    //        lista1.Insertar(1, 10);
    //        lista1.Insertar(2, 50);
    //        lista1.Insertar(3, 70);
    //        lista1.Imprimir();

    //        ListaGenerica<string> lista2 = new ListaGenerica<string>();
    //        lista2.Insertar(1, "uno");
    //        lista2.Insertar(2, "dos");
    //        lista2.Insertar(3, "tres");
    //        lista2.Imprimir();

    //        ListaGenerica<Persona> lista3 = new ListaGenerica<Persona>();
    //        lista3.Insertar(1, new Persona { Nombre = "juan", Edad = 20 });
    //        lista3.Insertar(2, new Persona { Nombre = "ana", Edad = 12 });
    //        lista3.Insertar(3, new Persona { Nombre = "luis", Edad = 40 });
    //        lista3.Imprimir();

    //        Console.ReadKey();
    //    }
    //}
    class Program { 
    
    static void Main(string[] args)
        {
            Stack<int> pila1 = new Stack<int>();
            pila1.Push(1);
            pila1.Push(5);
            pila1.Push(20);
            Console.WriteLine("Cantidad de elementos en la pila:"+pila1.Count);
            Console.WriteLine("Extraemos el ultimo elemento:" + pila1.Pop());
            Console.WriteLine("Cantidad de elementos en la pila:" + pila1.Count);
            Queue<string> cola = new Queue<string>();
            cola.Enqueue("Hola");
            cola.Enqueue("Como estas?");
            cola.Enqueue("Adios");
            Console.WriteLine("Cantidad de elementos en la cola:" + cola.Count);
            Console.WriteLine("Extraemos un elemento de la cola: "+cola.Dequeue());
            Console.WriteLine("Cantidad de elementos en la cola: " + cola.Count);
            Console.ReadKey();
        }
    }
}
