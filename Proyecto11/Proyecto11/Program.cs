using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto11
{
   class Pila
    {
        class Nodo {
            public int info;
            public Nodo sig;
        }
        private Nodo raiz;

        public Pila()
        {
            raiz = null;
        }

        public void Insertar(int x)
        {
            Nodo nuevo; // DIFINO EL PUNTERO TIPO NODO
            nuevo = new Nodo(); // CREO EL PUNTERO
            nuevo.info = x; //SE GUARDA LA INFORMACION DE LO QUE EL PUNTERO ESTA SEÑALANDO EN ESTE CASO EL VALOR QUE NOSOTROS INGRESAMOS X
            if(raiz == null) // SI RAIZ ES IGUAL A NULO SIGNIFICA QUE LA LISTA NO CONTIENE VALORES Y POR ENDE ESTE VACIA
            {
                nuevo.sig = null; // NUEVO.SIG VA A SER NULL, PORQUE NO HAY VALORES
                raiz = nuevo; //RAIZ VA A SER IGUAL A NUEVO PORQUE NO VA HA HABER NINGUN NODO
            }
            else
            {
                nuevo.sig = raiz; // CONECTO EL NUEVO NODO AL ULTIMO CREADO QUE ES DONDE EMPIEZA LA RAIZ
                raiz = nuevo; // RAIZ SE VA A POSICIONAR EN EL PRIMER Y NUEVO NODO CREADO
            }

        }
        public int Eliminar()
        {
            if (raiz != null) {
                int informacion = raiz.info;
                raiz = raiz.sig;
                return informacion;
            }
            else
            {
                return int.MaxValue;
            }
            
        } 
        public void Imprimir()
        {
            Nodo reco = raiz;
            Console.WriteLine("Listado de la Pila: ");
            while(reco != null) {
                Console.WriteLine(reco.info + " - ");
                reco = reco.sig;
            }

       
            
        }
        public bool Vacio()
        {
            if (raiz == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Cantidad()
        {
            int cant = 0;
            Nodo reco = raiz;
            while(reco != null)
            {
                cant++;
                reco = reco.sig;
            }
            return cant;
        }
        public int PrimerNodo()
        {
            if(raiz != null)
            {
                int informacion = raiz.info;
                return informacion;
            }else
            {
                return int.MaxValue;
            }

        }
        static void Main(string[] args)
        {
            Pila pila1 = new Pila();
            pila1.Insertar(2);
            pila1.Insertar(10);
            pila1.Insertar(20);
            pila1.Imprimir();
            pila1.Eliminar();
            pila1.Eliminar();
            pila1.Insertar(40);
            pila1.Imprimir();
            pila1.Vacio();
            pila1.Insertar(600);
            Console.WriteLine("El primer nodo es "+pila1.PrimerNodo());
            pila1.Imprimir();
            Console.WriteLine("Hay "+pila1.Cantidad()+ " de elementos en la pila");
            while(pila1.Vacio() == false)
            {
                Console.WriteLine("Elemento que se borra: "+pila1.Eliminar());
               
            }
            
            Console.ReadKey();
        }
    }
}
