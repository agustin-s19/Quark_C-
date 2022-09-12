using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto44
{
    class Perro : Animal, Icorredor
    {
        public void Correr()
        {
            Console.WriteLine("El Perro comenzo a correr....");
        }
    }
}
