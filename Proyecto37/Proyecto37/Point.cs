using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto37
{
    class Point
    {
        protected int x; // protected puede ser heredado

        protected int y;
    
        public int X // publico puede ser heredado 
            {
                get { 
                    return x; 
                }
                set {
                    x = value; 
                }
        }
        public int Y { 
                get {
                    return y; 
                }
                set {
                    y = value; 
                }
        }
        public virtual void MostrarMensaje()
        {
            Console.WriteLine("Este mensaje esta siendo invocado desde la clase Point");
        }
    }

}
