using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto39
{
    internal class Auto : Vehiculo
    {

        public override void Estacionarse()
        {
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("1) Los sensores del auto miden el espacio para estacionar.");
            Console.WriteLine("2) El auto se coloca en posicion paralela a su espacio de estacionamiento.");
            Console.WriteLine("3) El sistema automatico del auto realiza maniobra de estacionamiento.");
            Console.WriteLine("4) Los sensores del auto corrigen la posicion final.");
            Console.WriteLine("5) El auto " + this.Nombre + " se estaciono con exito.");
        }
    }
}
