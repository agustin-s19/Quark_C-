using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto44
{
    class Maratonista : Persona, Icorredor
    {
        public void Correr()
        {
            Console.WriteLine("El maratonista comenzo a correr....");
        }
    }
}
