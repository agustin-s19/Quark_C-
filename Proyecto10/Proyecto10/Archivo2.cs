using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto10
{
    partial class Rectangulo
    {
        public void RetornarSuperficie()
        {
            int sup = Lado1 * Lado2;
            Console.WriteLine("La superficie del rectangulo es de "+ sup);
        }

        public void RetornarPerimetro()
        {
            int per = Lado1 * Lado1 + Lado2 * Lado2;
            Console.WriteLine("El perimetro del rectangulo es de " + per);
        }
    }
}
