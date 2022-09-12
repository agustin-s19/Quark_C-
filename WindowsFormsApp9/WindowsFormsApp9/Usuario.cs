using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9
{
    class Usuario
    {
        private String nombre;
        private String apellido;
        private String dni;
        private String email;
        private String direccion;

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido;}
        public string Dni { get => dni;}
        public string Email { get => email;}
        public string Direccion { get => direccion; set => direccion = value; }

        public Usuario(string nom, string ape, string dni, string email, string direccion = "")
        {
            this.nombre = nom;
            this.apellido = ape;
            this.dni = dni;
            this.email = email;
            this.direccion = direccion;
        }
    }
}
