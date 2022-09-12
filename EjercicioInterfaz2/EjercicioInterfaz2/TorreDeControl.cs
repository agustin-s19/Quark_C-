using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaz2
{
    internal class TorreDeControl
    {
        List<Ivolador> voladores = new List<Ivolador>();

        
        public void vuelenTodos()
        {
            foreach( Ivolador i in voladores)
            {
                i.Volador();
            }
        }
        public void agregarVolador(string volador) {
            switch (volador) {
                case "pato":
                    Pato pato = new Pato();
                    voladores.Add(pato);
                    break;
                case "superman":
                    Superman superman = new Superman();
                    voladores.Add(superman);
                    break;
                case "boing747":
                    Boing747 boing747 = new Boing747();
                    voladores.Add(boing747);
                    break;
                default: 
                    break;
            }
        }
    }
}
