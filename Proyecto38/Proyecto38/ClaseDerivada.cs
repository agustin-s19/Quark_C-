using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto38
{
    internal class ClaseDerivada : ClaseBase
    {
        public override void MostrarMensaje()
        {
            Console.WriteLine("Mensaje Lanzado desde la clase derivada");
        }
        public override void DecirHola() // redifinicion de el metodo DecirHola
        {
            Console.WriteLine("Mensaje heredado Sucessfull");
        }
    }
}
