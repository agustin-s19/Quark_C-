using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto42
{
     class ClasePadre
    {
        public int x;
        public virtual void Calcular()
        {
            x = 1;
            MessageBox.Show("Inicialmente x vale: " + x);
        }
    }
}
