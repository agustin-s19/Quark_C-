using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto39
{
    abstract class Vehiculo
    {
        private string nombre; // ATRIBUTO PRIVADO

        public string Nombre{ // PROPIEDAD POR LA CUAL INGRESAN AL ATRBUTO
           get{
                return nombre;
           }
            set
            {
                nombre = value;
            }
        }

        // Metodos
        public Vehiculo() { } // Constructor

        public abstract void Estacionarse(); // MMetodo abstracto(es implementado en las clases hijas)
    }
}
