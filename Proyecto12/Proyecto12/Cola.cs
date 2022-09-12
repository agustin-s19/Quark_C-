using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto12
{
    public partial class Cola
    {
        class Nodo // se crea la clase nodo
        {
            public int info; // variable entera llamada info
            public Nodo sig; // variable nodo que se llama siguiente

        }

        private Nodo raiz, fondo;// variables privadas que son los apuntadores raiz y el fondo

        public Cola(){ // Propiedad Cola 
            raiz = null;  //Determina que raiz va a estar siempre al final del nodo *
            fondo = null;//Determina que fondo va a estar siempre al final del nodo *
        }

        public bool Vacia() // Metodo para ver si la Cola esta vacia o no
        {
            if (raiz == null) // Si raiz es igual a nulo
            {
                return true; // La cola esta vacia
            }
            else
            {
                return false; //Sino tiene por lo menos 1 elemento
            }
        }

        public void Insertar(int info) // creo Metodo Insertar el cual va a necesitar de un valor entero como parametro
        {
            Nodo nuevo; // creo objeto tipo nodo
            nuevo = new Nodo();
            nuevo.info = info; // la informacion del nuevo(el objeto) sera el numero que nosotros escribamos como parametro 
            nuevo.sig = null; // lo que le sigue al numero por parametro es igual a *
            if(Vacia()) // Si la Cola esta vacia
            {
                raiz = nuevo; // el apuntador raiz apunta a nuevo
                fondo = nuevo; // el apuntador fondo apunta a nuevo
            }
            else //Sino
            {
                fondo.sig = nuevo; //Se enlaza el ultimo nodo con el recien creado
                fondo = nuevo; // Ahora fondo apunta al * del ultimo nodo que llego

            }

        }

        public int Eliminar()
        {
            if (!Vacia())
            {
                int informacion = raiz.info; // Se guarda la informacion del primer nodo en una variable tipo raiz
                if (raiz == fondo) // Se comprueba que la lista no esta vacia
                {
                    raiz = null;
                    fondo = null;
                }
                else
                {
                    raiz = raiz.sig; // se recorre la cola 
                }
                return informacion; 

            }
            else
            {
                return int.MaxValue;
            }
        }
        public int Cantidad(){
            int cant = 0;
            Nodo reco = raiz;
            if (reco != null)
            {
                cant++;
                reco = reco.sig;
            }
            return cant;
        }
        class pepe
        {
            static void Main(string[] args)
            {
            }
        }
    }
}
