using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto42
{
    class ClaseHija : ClasePadre
    {
        public override void Calcular()
        {
            base.Calcular();

            x = x + 3;

            MessageBox.Show("Ahora el valor de x es " + x);
        }
    }
}
