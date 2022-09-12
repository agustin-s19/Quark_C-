using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto41real
{
    class Cliente
    {
        
        private String nombre, apellido, dni;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }

        public Cliente(String nombre, String apellido, String dni ){
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
    }
}
