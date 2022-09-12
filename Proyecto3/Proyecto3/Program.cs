using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IMPUESTOS CONDICIONAL SIMPLE
            //float sueldo;
            //string linea;
            //Console.WriteLine("Ingrese su sueldo");
            //linea = Console.ReadLine();
            //sueldo = int.Parse(linea);
            //if (sueldo > 3000) {
            //    Console.WriteLine("Usted debe pagar impuestos.");
            //    Console.WriteLine("Bienvenido a la Argentina!");
            //}
            //Console.ReadKey();

            //CONDICIONAL COMPUESTO NUMERO MAS GRANDE
            //int num1, num2;
            //string linea;
            //Console.WriteLine("Ingrese el primer numero: ");
            //linea = Console.ReadLine();
            //num1 = int.Parse(linea);
            //Console.WriteLine("Ingrese el segundo numero: ");
            //linea = Console.ReadLine();
            //num2 = int.Parse(linea);
            //if(num1 > num2)
            //{
            //    Console.WriteLine("El numero mas grande entre los 2 que escribiste es " + num1);
            //}
            //else
            //{
            //    Console.WriteLine("El numero mas grande entre los 2 que escribiste es " + num2);
            //}
            //Console.ReadKey();

            //CONDICIONAL SUMA RESTA PRODUCTO DIVISION
            //int num1, num2,suma,resta,producto,division;
            //string linea;


            //Console.WriteLine("Ingrese numero 1: ");
            //linea = Console.ReadLine();
            //num1 = int.Parse(linea);
            //Console.WriteLine("Ingrese numero 2: ");
            //linea= Console.ReadLine();
            //num2 = int.Parse(linea);
            //if(num1 > num2)
            //{
            //    suma = num1 + num2;
            //    resta = num1 - num2;
            //    Console.WriteLine("La suma de los numeros seria: " + suma + " y la resta seria: " + resta);
            //}
            //else
            //{
            //    producto = num1 * num2;
            //    division = num1 / num2;
            //    Console.WriteLine("El producto de los numeros seria: " + producto + "y el resultado de la division seria: "+ division);
            //}
            //Console.ReadKey();
            //CONDICIONAL PROMEDIO
            //int nota1, nota2, nota3, promedio;
            //string linea;
            //Console.WriteLine("Ingrese nota 1: ");
            //linea = Console.ReadLine();
            //nota1 = int.Parse(linea);
            //Console.WriteLine("Ingrese nota 2: ");
            //linea = Console.ReadLine();
            //nota2 = int.Parse(linea);
            //Console.WriteLine("Ingrese nota 3: ");
            //linea = Console.ReadLine();
            //nota3 = int.Parse(linea);
            //promedio = (nota1 + nota2 + nota3) / 3;
            //if(promedio >= 7)
            //{
            //    Console.WriteLine("Promocionado");
            //}
            //else
            //{
            //    Console.WriteLine("No Promociona");
            //}
            //Console.ReadKey();
            //DIGITOS
            //int numero;
            //string linea;
            //Console.WriteLine("Ingrese un numero del 1 al 99");
            //linea = Console.ReadLine();
            //numero = int.Parse(linea);
            //if (numero >= 10)
            //{
            //    Console.WriteLine("El número ingresado tiene 2 numeros");
            //}
            //else
            //{
            //    Console.WriteLine("El número ingresado  tiene un solo número");
            //}
            //Console.ReadKey();

            //CONDICIONAL ANIDADO
            //int nota1, nota2, nota3, promedio;
            //string linea;
            //Console.WriteLine("Ingrese nota 1: ");
            //linea = Console.ReadLine();
            //nota1 = int.Parse(linea);
            //Console.WriteLine("Ingrese nota 2: ");
            //linea = Console.ReadLine();
            //nota2 = int.Parse(linea);
            //Console.WriteLine("Ingrese nota 3: ");
            //linea = Console.ReadLine();
            //nota3 = int.Parse(linea);
            //promedio = (nota1 + nota2 + nota3) / 3;
            //if (promedio >= 7)
            //{
            //    Console.WriteLine("Promocionado");
            //}
            //else
            //{
            //    if (promedio >= 4)
            //    {
            //        Console.WriteLine("Regular");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Reprobado");
            //    }
            //}
            //Console.ReadKey();

            //ANIDADO 1
            //int num1, num2, num3;
            //string linea;
            //Console.WriteLine("Ingrese numero 1: ");
            //linea = Console.ReadLine();
            //num1 = int.Parse(linea);
            //Console.WriteLine("Ingrese numero 2: ");
            //linea = Console.ReadLine();
            //num2 = int.Parse(linea);
            //Console.WriteLine("Ingrese numero 3: ");
            //linea = Console.ReadLine();
            //num3 = int.Parse(linea);
            //if(num1 > num2 && num1 > num3)
            //{
            //    Console.WriteLine("El numero mayor es " + num1);
            //}
            //else
            //{
            //    if(num2 > num1 && num2 > num3)
            //    {
            //        Console.WriteLine("El numero mayor es " + num2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("El numero mayor es " + num3);
            //    }
            //}
            //Console.ReadKey();

            //ANIDADO 2
            //int num;
            //string linea;
            //Console.WriteLine("Ingrese un numero: ");
            //linea = Console.ReadLine();
            //num = int.Parse(linea);
            //if(num >= 1)
            //{
            //    Console.WriteLine("El número es positivo");

            //}
            //else
            //{
            //    if(num == 0)
            //    {
            //       Console.WriteLine("El número es nulo");
            //    }
            //    else
            //    {
            //        Console.WriteLine("El numero es negativo");
            //    }
            //}
            //Console.ReadKey();

            //ANIDADO 3
            //int num;
            //string linea;
            //Console.WriteLine("Ingrese un numero: ");
            //linea = Console.ReadLine();
            //num = int.Parse(linea);
            //if(num < 10)
            //{
            //    Console.WriteLine("El numero solo tien una cifra");
            //}
            //else
            //{
            //    if(num < 100)
            //    {
            //        Console.WriteLine("El numero tiene 2 cifras");
            //    }
            //    else
            //    {
            //        Console.WriteLine("El numero tiene 3 cifras");
            //    }
            //}
            //Console.ReadKey();
            //ANIDADO 4
            //int cantPreguntas, cantCorrectas, porcentaje;
            //string linea;
            //Console.WriteLine("Ingrese cantidad de preguntas realizadas: ");
            //linea = Console.ReadLine();
            //cantPreguntas = int.Parse(linea);
            //Console.WriteLine("Ingrese cantidad de preguntas correctas: ");
            //linea = Console.ReadLine();
            //cantCorrectas = int.Parse(linea);
            //porcentaje = (100 * cantCorrectas) / cantPreguntas;
            //if(porcentaje >= 90)
            //{
            //    Console.WriteLine("Nivel Maximo");
            //}
            //else
            //{
            //    if(porcentaje >= 75 && porcentaje < 90)
            //    {
            //        Console.WriteLine("Nivel Medio");
            //    }
            //    else
            //    {
            //        if (porcentaje >= 50 && porcentaje < 75)
            //        {
            //            Console.WriteLine("Nivel regular");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Fuera de nivel");
            //        }
            //    }
            //}
            //Console.ReadLine();

            // DE 0 A 100
            ////CICLO WHILE
            ////int X;
            ////X = 1;

            ////while (X <= 100)
            ////{
            ////    Console.WriteLine(X);
            ////    X = (X + 1);
            ////}
            ////Console.ReadKey();

            //DE 50 A 100
            //int x;
            //x = 50;
            //while (x <= 100)
            //{
            //    Console.WriteLine(x);
            //    x = x + 1;
            //}
            //Console.ReadKey();

            //DE -50 A 0
            //int x;
            //x = -50;
            //while(x < 0)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}
            //Console.ReadKey();

            // INICIA EN 2 HASTA EL 100 PERO INCREMENTA DE A 2
            //int x;
            //x = 2;
            //while (x <= 100)
            //{
            //    Console.WriteLine(x);
            //    x = x + 2;
            //}
            //Console.ReadKey();

            //int num;
            //int x;
            //string linea;
            //Console.WriteLine("Ingrese un numero: ");
            //linea = Console.ReadLine();
            //num = int.Parse(linea);
            //x = 1;
            //while(x <= num)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}
            //Console.ReadKey();

            //Escribe 10 numeros, sumalos y promedio
            //int x, suma, valor, promedio;
            //string linea;
            //x = 1;
            //suma = 0;

            //while(x <= 10)
            //{
            //    Console.Write("Escribi un numero: ");
            //    linea = Console.ReadLine();
            //    valor = int.Parse(linea);
            //    suma = suma + valor;
            //    Console.WriteLine(suma);
            //    x = x + 1; 
            //}
            //promedio = suma / 10;
            //Console.WriteLine("Suma total: " + suma);
            //Console.WriteLine("Promedio: " + promedio);

            //Console.ReadKey();

            //LONGITUD DE PIEZAS Y ACEPTAR LAS VALIDAS
            //int piezas,x,n;
            //float longitud;
            //piezas = 0;
            //string linea;

            //x = 1;

            //Console.WriteLine("Cuantas piezas procesaras: ");
            //linea = Console.ReadLine();
            //n = int.Parse(linea);
            //while (x <= n)
            //{
            //    Console.WriteLine("Ingrese longitud: ");
            //    linea = Console.ReadLine();
            //    longitud = float.Parse(linea);
            //    if (longitud <= 1.30 && longitud >= 1.20)
            //    {
            //        piezas = piezas +1;
            //    }
            //    x++;
                
            //}
            //Console.WriteLine("La cantidad de piezas aptas son: " + piezas);
            //Console.ReadKey();
        }
    }
}
