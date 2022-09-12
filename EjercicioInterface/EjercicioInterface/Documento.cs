using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterface
{
    internal class Documento : Imprimible, Iimprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy un documento de Word");
        }
    }
}
