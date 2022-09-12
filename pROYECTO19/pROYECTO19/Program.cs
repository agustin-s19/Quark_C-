using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pROYECTO19
{
    //internal class Sueldos
    //{
    //    private int[] sueldos;

    //    public void Cargar(){
    //        sueldos = new int[5];
    //        for (int i = 0; i < sueldos.Length; i++) {
    //            Console.WriteLine("Ingrese un numero: ");
    //            string linea;
    //            linea = Console.ReadLine();
    //            sueldos[i] = int.Parse(linea);
    //        }
    //    }
    //    public void Imprimir()
    //    {
    //        foreach (int i in sueldos)
    //        {
    //            Console.WriteLine(i);
    //        }
    //        Console.ReadKey();
    //    }
    //    static void Main(string[] args)
    //    {
    //        Sueldos sueldo1 = new Sueldos();
    //        sueldo1.Cargar();
    //        sueldo1.Imprimir();
    //    }
    //}

    //EJERCICIO FOREACH 2
    //class Vectores
    //{
    //    private int[] vectores;

    //    public void Pedir()
    //    {
    //        Console.WriteLine("Ingrese la cantidad de vectores que va a introducir: ");
    //        string linea;
    //        linea = Console.ReadLine();
    //        int cant = int.Parse(linea);
    //        vectores = new int[cant];
    //        for (int i = 0; i < cant; i++)
    //        {
    //            Console.WriteLine("Ingrese un numero: ");
    //            linea = Console.ReadLine();
    //            vectores[i] = int.Parse(linea);
    //        }
    //    }
    //    public void Imprimir()
    //    {
    //        int cant = 0;

    //        foreach (int i in vectores)
    //        {
    //            if(i > 100)
    //            {
    //                cant++;
    //            }

    //        }
    //        Console.WriteLine("La cantidad de elementos mayores a 100 es de " + cant);
    //        Console.ReadKey();
    //    }

    //    static void Main(string[] args)
    //    {
    //        Vectores vector1 = new Vectores();
    //        vector1.Pedir();
    //        vector1.Imprimir();
    //    }
    //}

    //SWITCH EJERCICIO 1
    //class Switch
    //{
    //    public void NSwitch()
    //    {

    //        Console.WriteLine("Ingrese un valor del 1 al 5:");
    //        int valor = int.Parse(Console.ReadLine());
    //        switch (valor)
    //        {
    //            case 1:
    //                Console.WriteLine("Uno");
    //                break;
    //            case 2:
    //                Console.WriteLine("Dos");
    //                break;
    //            case 3:
    //                Console.WriteLine("Tres");
    //                break;
    //            case 4:
    //                Console.WriteLine("Cuatro");
    //                break;
    //            case 5:
    //                Console.WriteLine("Cinco");
    //                break;
    //            default:
    //                Console.WriteLine("Numero no valido \nIngrese un numero del 1 al 5");
    //                break;
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Switch nintendo = new Switch();
    //        nintendo.NSwitch();
    //        Console.ReadKey();
    //    }
    //}
    class Switch2
    {
        public void NSwitch()
        {

            Console.WriteLine("Ingrese un valor del 1 al 5:");
            string valor = Console.ReadLine();
            switch (valor)
            {
                case "uno":
                    Console.WriteLine(1);
                    break;
                case "dos":
                    Console.WriteLine(2);
                    break;
                case "tres":
                    Console.WriteLine(3);
                    break;
                case "cuatro":
                    Console.WriteLine(4);
                    break;
                case "cinco":
                    Console.WriteLine(5);
                    break;
                default:
                    Console.WriteLine("Numero no valido \nIngrese un numero del 1 al 5");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Switch2 nintendo = new Switch2();
            nintendo.NSwitch();
            Console.ReadKey();
        }
    }
}
