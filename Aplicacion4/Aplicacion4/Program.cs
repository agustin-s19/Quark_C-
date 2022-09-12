using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FOR EJERCICIO 1
            //int x;

            //for (x=1; x <= 100; x++)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.ReadLine();

            //for EJERCICIO 2
            //int x, contador,numero, suma, promedio;
            //string linea;
            //suma = 0;
            //contador = 10;
            //for (x=1; x<=contador; x++)
            //{
            //    Console.WriteLine("Ingrese un numero: ");
            //    linea = Console.ReadLine();
            //    numero = int.Parse(linea);
            //    suma = numero + suma;


            //}
            //promedio = suma / 10;
            //Console.WriteLine("La suma total es de " + suma);
            //Console.WriteLine("El promedio total es de" + promedio);
            //Console.ReadKey();


            //for EJERCICIO 3
            //int aprobados, desaprobados, x, nota;
            //string linea;
            //aprobados = 0;
            //desaprobados=0;
            //for (x = 1; x <=10; x++)
            //{
            //    Console.WriteLine("Ingrese una nota: ");
            //    linea = Console.ReadLine();
            //    nota = int.Parse(linea);
            //    if (nota >= 7)
            //    {
            //        aprobados++;
            //    }
            //    else
            //    {
            //        desaprobados++;
            //    }
            //}
            //Console.WriteLine("La cantidad de aprobados es de " + aprobados);
            //Console.WriteLine("La cantidad de desaprobados es de " + desaprobados);
            //Console.ReadLine();

            //FOR EJERCICIO 3
            //int x, num, mul3, mul5;
            //string linea;
            //mul3 = 0;
            //mul5 = 0;
            //for (x = 1; x <= 10; x++)
            //{
            //    Console.WriteLine("Ingrese un numero: ");
            //    linea = Console.ReadLine();
            //    num = int.Parse(linea);
            //    if (num % 3 == 0)
            //    {
            //        mul3++;
            //    }
            //    else if (num % 5 == 0)
            //    {
            //        mul5++;
            //    }

            //}
            //Console.WriteLine("La cantidad de numeros multiplos de 3 es de: " + mul3);
            //Console.WriteLine("La cantidad de numeros multiplos de 5 es de "+ mul5);
            //Console.ReadKey();

            // FOR EJERCICIO 4
            //int x,num, cantidad, mayor;
            //string linea;
            //cantidad = 0;
            //mayor = 0;
            //Console.WriteLine("Ingrese cuantos numeros ingresara: ");
            //linea = Console.ReadLine();
            //cantidad = int.Parse(linea);
            //for (x = 1; x <= cantidad; x++)
            //{
            //    Console.WriteLine("Ingrese su numero: ");
            //    linea = Console.ReadLine();
            //    num = int.Parse(linea);
            //    if (num >= 1000)
            //    {
            //        mayor++;
            //    }
            //}
            //Console.WriteLine("La cantidad de numeros mayores a 1000 es de " + mayor);
            //Console.ReadKey();

            //DO WHILE EJERCICIO 1
            //int valor,digitos;
            //string linea;
            //digitos = 0;
            //do
            //{
            //    Console.WriteLine("Ingrese un numero del 1 al 999: ");
            //    linea = Console.ReadLine();
            //    valor = int.Parse(linea);
            //    if (valor >= 100)
            //    {
            //        digitos = 3;
            //    }
            //    else
            //    {
            //        if (valor >= 10)
            //        {
            //            digitos = 2;
            //        }
            //        else
            //        {
            //            digitos = 1;
            //        }
            //    }
            //}
            //while (valor != 0);

            //Console.WriteLine("La cantidad de digitos del numero ingresado es de " + digitos);
            //Console.ReadKey();

            //DO WHILE EJERCICIO 2
            //int suma, promedio, num, cant;
            //string linea;
            //suma = 0;
            //cant = 0;
            //do
            //{
            //    Console.WriteLine("Ingrese un numero:(con el 0 finaliza): ");
            //    linea = Console.ReadLine();
            //    num = int.Parse(linea);
            //    if (num != 0)
            //    {
            //        suma = (suma + num);
            //        cant++;
            //    }
            //} while (num != 0);
            //if (cant != 0)
            //{
            //    promedio = (suma / cant);
            //    Console.WriteLine("El promedio es de " + promedio);
            //}
            //else
            //{
            //    Console.WriteLine("No se ingresaron valores");
            //}
            //Console.ReadKey();

            //DO WHILE EJERCICIO 3

            //float num,cant,menos,aprobadas,mas;
            //string linea;
            //cant = 0;
            //menos = 0;
            //aprobadas = 0;
            //mas = 0;
            //do
            //{
            //    Console.WriteLine("Ingrese un numero: ");
            //    linea = Console.ReadLine();
            //    num = float.Parse(linea);
            //    if (num <= 10.2 && num >= 9.2)
            //    {
            //        aprobadas++;
            //    }
            //    else
            //    {
            //        if(num > 10.2)
            //        {

            //            menos++;
            //        }
            //        else
            //            if(num>0)
            //        {

            //            mas++;
            //        }
            //    }
            //} while (num != 0);
            //cant = (aprobadas + menos + mas);
            //Console.WriteLine("La cantidad de piezas aceptadas son: " + aprobadas);
            //Console.WriteLine("La cantidad de piezas menor a 9.2 son: " + menos);
            //Console.WriteLine("La cantidad de piezas mayor a 10.2 son: " + mas);
            //Console.WriteLine("La cantidad total de piezas pedidas son: " + cant);
            //Console.ReadKey();

            //cadena de caracteres EJERCICIO 1
            //int edad1, edad2;
            //string nombre1, nombre2, linea;
            //Console.WriteLine("Ingrese su nombre: ");
            //nombre1 = Console.ReadLine();
            //Console.WriteLine("Ingrese su edad: ");
            //linea = Console.ReadLine();
            //edad1 = int.Parse(linea);
            //Console.WriteLine("Ingrese su nombre: ");
            //nombre2 = Console.ReadLine();
            //Console.WriteLine("Ingrese su edad: ");
            //linea = Console.ReadLine();
            //edad2 = int.Parse(linea);
            //if (edad1 < edad2)
            //{
            //    Console.WriteLine(nombre2);
            //}
            //else
            //{
            //    Console.WriteLine(nombre1);
            //}
            //Console.ReadKey();

            //cadena de caracteres EJERCICIO 2

            //string apellido1, apellido2;
            //Console.WriteLine("Ingrese apellido 1: ");
            //apellido1 = Console.ReadLine();
            //Console.WriteLine("Ingrese apellido 2: ");
            //apellido2 = Console.ReadLine();
            //if (apellido1 == apellido2)
            //{
            //    Console.WriteLine("Los apellidos son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("Los apellidos no son iguales");
            //}
            //Console.ReadKey();
        }
        class Persona
        {
            private string nombre, linea;
            private int edad;
            public void Inicializar()
            {
                Console.WriteLine("Ingrese nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad: ");
                linea = Console.ReadLine();
                edad = int.Parse(linea);
            }

        }


        }
    }

