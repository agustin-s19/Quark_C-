using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto13
{
    internal class ListaGenerica
    {
        class Nodo
        {
            public int info;
            public Nodo sig;
        }
        private Nodo raiz;

        public ListaGenerica(){
         raiz= null;   
        }

        void Insertar(int pos, int x)
        {
            if(pos <= Cantidad() + 1)
            {
                Nodo nuevo = new Nodo();
                nuevo.info = x;
                if(pos == 1)
                {
                    nuevo.sig = raiz;
                    raiz = nuevo;
                }
                else
                {
                    if(pos == Cantidad() + 1)
                    {
                        Nodo reco = raiz;
                        while(reco.sig != null)
                        {
                            reco = reco.sig;
                        }
                        reco.sig = nuevo;
                        reco.sig = null;
                    }
                    else
                    {
                        Nodo reco = raiz;
                        for(int i = 0; i <= pos; i++)
                        {
                            reco = reco.sig;
                            Nodo siguiente = reco.sig;
                            reco.sig = nuevo;
                            nuevo.sig = siguiente;
                        }
                    }

                }
            }
            
        }
        public int Extraer(int pos)
        {

        }
        public int Cantidad()
        {
            int cant = 0;
            Nodo reco = raiz;
            while (reco != null)
            {
                reco = reco.sig;
                cant++;
            }
            return cant;
        }

        static void Main(string[] args)
        {
        }
    }
}
