using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Proyecto43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------- ARRAYLIST DE OBJETOS ---------------");
            #region
            // CREACION DE ARRAYLIST
            ArrayList arrayListDeObjetos = new ArrayList();
            // CREACION DE OBJETO ANIMAL
            Animal perro = new Animal();
            perro.nombre = "Doverman";
            // CRACION DE OBJETO VEHICULO
            Vehiculo auto = new Vehiculo();
            auto.nombre = "FORD KA";
            // AGREGO LOS OBJETOS AL ARRAYLIST
            arrayListDeObjetos.Add(perro);
            arrayListDeObjetos.Add(auto);

            // recorremos el ArrayList
            foreach(object objetoDeTipoDesconocido in arrayListDeObjetos)
            {
                // Como no sabemos de que Clase es el objeto que se encuentra en el tipo de arraylist necesitamos obtener el Type(tipo de objeto)
                Type tipo = objetoDeTipoDesconocido.GetType();

                switch (tipo.Name) {
                    case "Animal":
                        // Reconstruimos el objeto
                        Animal objetoDeClaseAnimal = (Animal)objetoDeTipoDesconocido;
                        // Mostramos su atributo
                        Console.WriteLine(objetoDeClaseAnimal.nombre);   
                        break;
                    case "Vehiculo":
                        Vehiculo objetodeClaseVehiculo = (Vehiculo)objetoDeTipoDesconocido;
                        Console.WriteLine(objetodeClaseVehiculo.nombre);
                        break;
                        // Si el objeto es de cualquier otro tipo
                    default:
                        break; // Lo ignoramos y pasamos al siguiente objeto
                }
            }
            #endregion
            // LIST DE OBJETOS
            // Una list de objetos sirve para guardar en una lista objetos que sean del mismo tipo
            #region
            Console.WriteLine("\n\n");
            Console.WriteLine("-------------- LISTA DE OBJETOS ----------------");

            //Creamos la list de un tipo determinado
            List<Animal> objetosDeTipoAnimal = new List<Animal>();
            // Creamos algunos objetos de tipo Animal
            Animal a1 = new Animal();
            a1.nombre = "Lagarto";
            Animal a2 = new Animal();
            a2.nombre = "Serpiente";
            Animal a3 = new Animal();
            a3.nombre = "Gatito";

            // Los agregamos a la lista
            objetosDeTipoAnimal.Add(a1);
            objetosDeTipoAnimal.Add (a2);
            objetosDeTipoAnimal.Add(a3);

            // Recoreremos la lista y mostramos los atributos
            foreach(Animal objeto in objetosDeTipoAnimal)
            {
                Console.WriteLine(objeto.nombre);
            }

            #endregion
            Console.ReadKey();
      
        }
    }

    class Animal
    {
        public string nombre;
    }
    class Vehiculo
    {
        public string nombre;
    }
}
