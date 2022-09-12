using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto5
{


    //EJERCICIO 1 POO

    //class Persona
    //{
    //    private string nombre, linea;
    //    private int edad;
    //    public void Inicializar()
    //    {
    //        Console.WriteLine("Ingrese nombre: ");
    //        nombre = Console.ReadLine();
    //        Console.WriteLine("Ingrese la edad: ");
    //        linea = Console.ReadLine();
    //        edad = int.Parse(linea);
    //    }
    //    public void Imprimir()
    //    {
    //        Console.WriteLine("Nombre: "+ nombre+"\nEdad: " + edad);
    //    }

    //    public void EsMayor()
    //    {
    //        if (edad >= 18)
    //        {
    //            Console.WriteLine("Es mayor de edad");
    //        }
    //        else
    //        {
    //            Console.WriteLine("No es mayor de edad");
    //        }
    //    }


    //    static void Main(string[] args)
    //    {
    //        Persona persona1 = new Persona();
    //        persona1.Inicializar();
    //        persona1.Imprimir();
    //        persona1.EsMayor();
    //        Console.ReadKey();

    //    }



    //EJERCICIO 2 POO

    //class triangulo
    //{
    //    private int lado1, lado2, lado3;
    //    private string linea;
    //    public void Iniciar()
    //    {
    //        Console.WriteLine("Ingrese el 1er lado del triangulo: ");
    //        linea = Console.ReadLine();
    //        lado1 = int.Parse(linea);
    //        Console.WriteLine("Ingrese el 2do lado del triangulo: ");
    //        linea = Console.ReadLine();
    //        lado2 = int.Parse(linea);
    //        Console.WriteLine("Ingrese el 3er lado del triangulo: ");
    //        linea = Console.ReadLine();
    //        lado3 = int.Parse(linea);
    //    }

    //    public void LadoMayor()
    //    {
    //        if(lado1 > lado2 && lado1 > lado3)
    //        {
    //            Console.WriteLine("El lado mayor es " + lado1); 
    //        }
    //        else
    //        {
    //            if(lado2 > lado1 && lado2 > lado3)
    //            {
    //                Console.WriteLine("El lado mayor es " + lado2);
    //            }
    //            else
    //            {
    //                Console.WriteLine("El lado mayor es " + lado3);
    //            }
    //        }
    //    }
    //    public void EsEquilatero()
    //    {
    //        if (lado1 == lado2 && lado3 == lado1)
    //        {
    //            Console.WriteLine("El triangulo es equilatero");
    //        }
    //        else
    //        {
    //            Console.WriteLine("El triangulo no es equilatero");

    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        triangulo triangulo1 = new triangulo();
    //        triangulo1.Iniciar();
    //        triangulo1.LadoMayor();
    //        triangulo1.EsEquilatero();
    //        Console.ReadKey();
    //    }
    //}

    //TERCER EJERCICIO POO

    //class Punto
    //{
    //    public int x, y;


    //    public void Inicializar()
    //    {
    //        string linea;
    //        Console.WriteLine("Ingresa X: ");
    //        linea = Console.ReadLine();
    //        x = int.Parse(linea);
    //        Console.WriteLine("Ingresa Y: ");
    //        linea = Console.ReadLine();
    //        y = int.Parse(linea);
    //    }

    //    public void ImprimirCuadrante()
    //    {
    //        if (x > 0 && y > 0)
    //        {
    //            Console.WriteLine("Se encuentra en el primer cuadrante");
    //        }
    //        else
    //        {
    //            if (x < 0 && y > 0)
    //            {
    //                Console.WriteLine("Se encuentra en el segundo cuadrante");
    //            }
    //            else
    //            {
    //                if (x < 0 && y < 0)
    //                {
    //                    Console.WriteLine("Se encuentra en el tercer cuadrante");

    //                }
    //                else
    //                {
    //                    if (x > 0 && y < 0)
    //                    {
    //                        Console.WriteLine("Se encuentra en el cuarto cuadrante");
    //                    }
    //                    else
    //                    {
    //                        Console.WriteLine("No se encuentra en ningun cuadrante");
    //                    }
    //                }
    //            }
    //        }


    //    }
    //    static void Main(string[] args)
    //    {
    //        Punto punto1 = new Punto();
    //        punto1.Inicializar();
    //        punto1.ImprimirCuadrante();
    //        Console.ReadKey();
    //    }

    //}
}
