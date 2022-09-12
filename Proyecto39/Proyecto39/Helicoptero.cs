using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto39
{
    internal class Helicoptero : Vehiculo
    {
        public override void Estacionarse() {

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("1) El piloto acomoda el helicoptero sobre el espacio de estacionamiento.");
            Console.WriteLine("2) El piloto realiza maniobra de aterrizaje.");
            Console.WriteLine("3) El piloto apaga los motores");
            Console.WriteLine("4) El Helicoptero "+ this.Nombre + "se estaciono con exito.");
        }
    }
}
