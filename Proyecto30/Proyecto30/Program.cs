using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto30
{
    public delegate bool Comparacion(int elemento);
    public class Estudiante
    {
       public string Nombre { get; set; }
       public int Nota { get; set; }
    }
    public class Curso
    {
        private Estudiante[] vec = new Estudiante[5];
        public void Cargar(int pos, Estudiante est)
        {
            vec[pos] = est;
        }
        public void ImprimirTodo()
        {
            foreach (var elemento in vec)
                Console.WriteLine("Nombre: {0} Nota: {1}", elemento.Nombre, elemento.Nota);
        }
        public void ImprimirSi(Comparacion compara)
        {
            foreach (var elemento in vec)
            {
                if (compara(elemento.Nota)){
                    Console.WriteLine("Nombre: {0} Nota: {1}", elemento.Nombre, elemento.Nota);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Curso curso1 = new Curso();
            curso1.Cargar(0, new Estudiante { Nombre = "Alfredo" ,Nota = 10 });
            curso1.Cargar(1, new Estudiante { Nombre = "Anastacia", Nota = 4 });
            curso1.Cargar(2, new Estudiante { Nombre = "Alma", Nota = 5 });
            curso1.Cargar(3, new Estudiante { Nombre = "Augusto", Nota = 1 });
            curso1.Cargar(4, new Estudiante { Nombre = "Amir", Nota = 8 });
            Console.WriteLine("LISTADO DE TODOS LOS DEL CURSO: ");
            curso1.ImprimirTodo();
            Console.WriteLine("Listado de todas las notas mayores a 7");
            curso1.ImprimirSi((nota) => nota >= 7);
            Console.WriteLine("Listado de todos aquellos que se sacaron un 4:");
            curso1.ImprimirSi((nota) => nota == 4);
            Console.WriteLine("Listado completo de todas aquellas personas que utilizaron la funcion ImportarSi/ es decir si tiene o no nota: ");
            curso1.ImprimirSi((nota) => true);
            Console.ReadKey();

        }
    }
}
