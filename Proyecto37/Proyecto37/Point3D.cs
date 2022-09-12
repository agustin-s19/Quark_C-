using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto37
{
    internal class Point3D : Point
    {
        private int z;

        public int Z{
            get {
                return z;
            }
            set
            {
                value = z;
            }
        }
        public override void MostrarMensaje()
        {
            Console.WriteLine("Metodo invocado desde la clase hija");
        }
    }
}
