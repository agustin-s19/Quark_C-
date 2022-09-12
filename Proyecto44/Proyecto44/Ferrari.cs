using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto44
{
    class Ferrari : Vehiculo, Icorredor
    {
        public void Correr() {
            Console.WriteLine("La Ferrari comenzo a andar....");
        }
    }
}
