using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterface
{
    class Impresora
    {
        List<Iimprimible> colaDeImpresion = new List<Iimprimible>();

        
        

        public void AgregarImprimible(string unImprimible)
        {
            switch (unImprimible)
            {
                case "foto":
                    Foto foto = new Foto();
                    colaDeImpresion.Add(foto);
                    break;
                case "contrato":
                    Contreto contrato = new Contreto();
                    colaDeImpresion.Add(contrato);
                    break;
                case "documento":
                    Documento documento = new Documento();
                    colaDeImpresion.Add(documento);
                    break;
                default:
                    break;

            }
        }
        public void ImprimirTodo() {
            foreach(Iimprimible  c in colaDeImpresion)
            {
                c.Imprimir();
            }
        }
    }
}
