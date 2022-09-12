using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo auto = new Auto(); // CREAMOS UN NUEVO AUTO DE TIPO VEHICULO
            auto.Nombre = "Chevrolet Etios"; // ASIGNAMOS NOMBRE MEDIANTE LA PROPIEDAD SET
                
            Vehiculo heli = new Helicoptero(); // CREAMOS UN NUEVO HELICOPTERO DE TIPO VEHICULO
            heli.Nombre = "Helicopter Fiu Fiu"; // ASIGNAMOS NOMBRE MEDIANTE LA PROPIEDAD SET


            // CREAMOS UN ARRAY QUE CONTIENE OBJETOS DE TIPO VEHICULO
            Vehiculo[] vehiculos = new Vehiculo[2];


            // ALMACENAMOS LOS OBJETOS EN EL ARRAY
            vehiculos[0] = auto;
            vehiculos[1] = heli;

            // APLICANDO POLIMORFISMO
            foreach (Vehiculo vehiculo in vehiculos)
            {
                //No me importa si el vehiculo es un auto o un helicoptero, aca se inca el metodo estacionarse de cada tipo de vehiculo.
                vehiculo.Estacionarse();
            }
        }
    }
}
