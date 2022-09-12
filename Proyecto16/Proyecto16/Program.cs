using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto16
{
    //public class ArbolBinarioOrdenado
    //{
    //    class Nodo
    //    {
    //        public int info;
    //        public Nodo izq, der;
    //    }
    //    Nodo raiz;

    //    public ArbolBinarioOrdenado(){
    //        raiz = null;    
    //    }

    //    public void Insertar(int info)
    //    {
    //        Nodo nuevo;
    //        nuevo = new Nodo();
    //        nuevo.info = info;
    //        nuevo.izq = null;
    //        nuevo.der = null;
    //        if(raiz == null)
    //        {
    //            raiz = nuevo;
    //        }
    //        else
    //        {
    //            Nodo anterior = null, reco;
    //            reco = raiz;
    //            while(reco != null)
    //            {
    //                anterior = reco;
    //                if(info < reco.info)
    //                {
    //                    reco = reco.izq;
    //                }
    //                else
    //                {
    //                    reco = reco.der;
    //                }
    //            }
    //            if(info < anterior.info)
    //            {
    //                anterior.izq = nuevo;
    //            }
    //            else
    //            {
    //                anterior.der = nuevo;
    //            }
    //        }

    //    }
    //    private void ImprimirPre(Nodo reco)
    //    {
    //        if (reco != null)
    //        {
    //            Console.WriteLine(reco.info + " ");
    //            ImprimirPre(reco.izq);
    //            ImprimirPre(reco.der);
    //        }
    //    }

    //    public void ImprimirPre()
    //    {
    //        ImprimirPre(raiz);
    //        Console.WriteLine();
    //    }

    //    private void ImprimirEntre(Nodo reco)
    //    {
    //        if(reco != null)
    //        {
    //            ImprimirEntre(reco.izq);
    //            Console.WriteLine(reco.info + " ");
    //            ImprimirEntre(reco.der);
    //        }
    //    }
    //    public void ImprimirEntre()
    //    {
    //        ImprimirEntre(raiz);
    //        Console.WriteLine();
    //    }
    //    private void ImprimirPost(Nodo reco)
    //    {
    //        if(reco != null)
    //        {
    //            ImprimirPost(reco.izq);
    //            ImprimirPost(reco.der);
    //            Console.WriteLine(reco.info);
    //        }
    //    }
    //    public void ImprimirPost()
    //    {
    //        ImprimirPost(raiz);
    //        Console.WriteLine();
    //    }
    //    static void Main(string[] args)
    //    {
    //        ArbolBinarioOrdenado arbolito = new ArbolBinarioOrdenado();
    //        arbolito.Insertar(600);
    //        arbolito.Insertar(2000);
    //        arbolito.Insertar(400);
    //        arbolito.Insertar(20);
    //        arbolito.Insertar(604);
    //        arbolito.Insertar(4000);
    //        arbolito.Insertar(8000);
    //        arbolito.Insertar(254);

    //        Console.WriteLine("Arbol ordenado en Pre Orden: ");
    //        arbolito.ImprimirPre();
    //        Console.WriteLine("Arbol ordenado en Entre Orden: ");
    //        arbolito.ImprimirEntre();
    //        Console.WriteLine("Arbol ordenado en Post Orden: ");
    //        arbolito.ImprimirPost();
    //        Console.ReadKey();
    //    }
    //}
    public class ArbolOrganizado
    {
        class Nodo
        {
            public int info;
            public Nodo izq, der;
        }
        private Nodo raiz;
        private int altura;
        private int cant;

        public ArbolOrganizado() {
            raiz = null;
        }

        public void Insertar(int info)
        {
            if (!Existe(info))
            {
                Nodo nuevo;
                nuevo = new Nodo();
                nuevo.info = info;
                nuevo.izq = null;
                nuevo.der = null;
                if (raiz == null)
                {
                    raiz = nuevo;
                }
                else
                {
                    Nodo anterior = null, reco;
                    reco = raiz;
                    while (reco != null)
                    {
                        anterior = reco;
                        if (info < reco.info)
                        {
                            reco = reco.izq;
                        }
                        else
                        {
                            reco = reco.der;
                        }
                    }
                    if (info < anterior.info)
                    {
                        anterior.izq = nuevo;
                    }
                    else
                    {
                        anterior.der = nuevo;
                    }
                }
            }
        }
        public bool Existe(int info)
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                if (info == reco.info)
                {
                    return true;
                }
                else
                {
                    if (info > reco.info)
                    {
                        reco = reco.der;
                    }
                    else
                    {
                        reco = reco.izq;
                    }

                }

            }
            return false;
        }

        private void ImprimirEntre(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirEntre(reco.izq);
                Console.WriteLine(reco.info + " ");
                ImprimirEntre(reco.der);
            }
        }
        public void ImprimirEntre() {
            ImprimirEntre(raiz);
            Console.WriteLine();
        }

       private void Cantidad(Nodo reco) 
        {
            if (reco!=null) 
            {
                cant++;
                Cantidad(reco.izq);
                Cantidad(reco.der);
            }
        }
    
        public int Cantidad() 
        {
            cant=0;
            Cantidad(raiz);
            return cant;
        }


        
        private void ImprimirEntreConNivel(Nodo reco, int nivel)
        {
            if (reco != null)
            {
                ImprimirEntreConNivel(reco.izq, nivel + 1);
                Console.WriteLine(reco.info + "( " + nivel + " )");
                ImprimirEntreConNivel(reco.der, nivel + 1);
            }
        }

        public void ImprimirEntreConNivel()
        {
            ImprimirEntreConNivel(raiz,1);
            Console.WriteLine();
        }


        private void CantidadNodosHoja(Nodo reco)
        {
            if (reco != null)
            {
                if (reco.izq == null && reco.der == null)
                    cant++;
                CantidadNodosHoja(reco.izq);
                CantidadNodosHoja(reco.der);
            }
        }

        public int CantidadNodosHoja()
        {
            cant = 0;
            CantidadNodosHoja(raiz);
            return cant;
        }


        private void RetornarAltura(Nodo reco,int nivel)
        {
            if(reco != null)
            {
                RetornarAltura(reco.izq, nivel + 1);
                if (nivel > altura)
                {
                    altura = nivel;
                }
                RetornarAltura(reco.der, nivel + 1);
            }
        }
        public int RetornarAltura()
        {
            altura = 0;
            RetornarAltura(raiz, 1);
            return altura;
        }

        public void Mayor()
        {
            if(raiz!= null)
            {
                Nodo reco = raiz;
                while (reco.der != null)
                {
                    reco = reco.der;
                    Console.WriteLine("Mayor valor del arbol: " +  reco.info);
                }
            }
        }

        public void BorrarMenor()
        {
            if(raiz != null)
            {
                if(raiz.izq == null)
                {
                    raiz = raiz.der;
                }
                else
                {
                    Nodo atras = raiz;
                    Nodo reco = raiz.izq;
                    while (reco.izq != null)
                    {
                        atras = reco;
                        reco = reco.izq;
                    }
                    atras.izq = reco.der;
                }
            }
        }
        static void Main(string[] args) {
            ArbolOrganizado abo = new ArbolOrganizado();
            abo.Insertar(100);
            abo.Insertar(50);
            abo.Insertar(25);
            abo.Insertar(75);
            abo.Insertar(150);
            Console.WriteLine("Impresion entreorden: ");
            abo.ImprimirEntre();
            Console.WriteLine("Cantidad de nodos del árbol:" + abo.Cantidad());
            Console.WriteLine("Cantidad de nodos hoja:" + abo.CantidadNodosHoja());
            Console.WriteLine("Impresion en entre orden junto al nivel del nodo.");
            abo.ImprimirEntreConNivel();
            Console.Write("Artura del arbol:");
            Console.WriteLine(abo.RetornarAltura());
            abo.Mayor();
            abo.BorrarMenor();
            Console.WriteLine("Luego de borrar el menor:");
            abo.ImprimirEntre();
            Console.ReadKey();
        }
    }
}
