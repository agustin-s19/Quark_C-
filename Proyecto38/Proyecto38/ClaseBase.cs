using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto38
{
    abstract class ClaseBase
    {
        public int numero; // atributo no abstracto
        public abstract void MostrarMensaje(); // metodo abstracto

        public virtual void DecirHola() { Console.WriteLine("Mensaje enviado desde la clase base"); } // metodo no abstracto , puede ser redificnido en sus clases hijas por la palabra virtual
    }
}
