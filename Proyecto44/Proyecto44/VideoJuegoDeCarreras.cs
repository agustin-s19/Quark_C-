using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto44
{
    class VideoJuegoDeCarreras
    {
        List<Icorredor> corredores = new List<Icorredor>();

        public VideoJuegoDeCarreras() { // propiedad
            Perro perro = new Perro();
            corredores.Add(perro);
                Caballo caballo = new Caballo();
            corredores.Add(caballo);
                Ferrari ferrari = new Ferrari();
            corredores.Add(ferrari);
                Maratonista maratonista = new Maratonista();
            corredores.Add(maratonista);
        } 
        public void IniciarCarrera() // metodo
        {
            foreach (Icorredor corredor in corredores)
            {
                corredor.Correr(); // por cada elemento en la lista, ejecutaremos el metodo correr
            }

        }

       

      

    }
}
