using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto6
{

    // VECTORES 1
    //internal class Sueldos
    //{
    //    private int[] sueldos;

    //    public void Cargar()
    //    {
    //        sueldos = new int[5];
    //        for (int x = 1; x<5; x++)
    //        {
    //            string linea; 
    //            Console.WriteLine("Ingrese sueldo :");
    //            linea = Console.ReadLine();
    //            sueldos[x] = int.Parse(linea);
    //        }

    //    }

    //    public void Imprimir()
    //    {
    //        for (int x = 1; x<5; x++)
    //        {
    //            Console.WriteLine(sueldos[x]);
    //        }
    //        Console.ReadKey();
    //    }



    //    static void Main(string[] args)
    //    {
    //        Sueldos sueldos1 = new Sueldos();
    //        sueldos1.Cargar();
    //        sueldos1.Imprimir();
    //    }
    //}
    //VECTORES 2

    //class Vectores
    //{
    //    private float[] componente;
    //    private float promedio,masBajo,masAlto;

    //    public void PedirDatos()
    //    {
    //        componente = new float[5];
    //        for(int x = 0; x < 5; x++)
    //        {
    //            string linea;
    //            Console.WriteLine("Ingrese su altura: ");
    //            linea = Console.ReadLine();
    //            componente[x] = float.Parse(linea);
    //        }

    //    }
    //    public void Calcular()
    //    {
    //        float suma;
    //        suma = 0;
    //        for (int x = 0; x < 5; x++)
    //        {
    //            suma = suma+componente[x];
    //        }
    //        promedio = suma / 5;
    //        Console.WriteLine("El promedio es " + promedio);
    //    }
    //    public void MayorOMenor()
    //    {
    //        masBajo = 0;
    //        masAlto = 0;
    //        for(int x = 0; x < 5; x++)
    //        {
    //            if(componente[x] > promedio)
    //            {
    //                masAlto++;
    //            }
    //            else
    //            {
    //                if (componente[x] < promedio)
    //                {
    //                    masBajo++;
    //                }
    //            }
    //        }
    //        Console.WriteLine("La cantidad de personas mayores al promedio es de " + masAlto);
    //        Console.WriteLine("La cantidad de personas menores al promedio es de " + masBajo);
    //        Console.ReadKey();
    //    }
    //    static void Main(string[] args)
    //    {
    //        Vectores vectores1 = new Vectores();
    //        vectores1.PedirDatos();
    //        vectores1.Calcular();
    //        vectores1.MayorOMenor();

    //    }
    //}

    //class pv3
    //{
    //    private int[] sueldoMañana, sueldoTarde;

    //    public void PedirSueldos()
    //    {
    //        string linea;
    //        sueldoMañana = new int[4];
    //        sueldoTarde = new int[4];
    //        Console.WriteLine("Bienvenido \nSueldos Turno Mañana");
    //        for(int x = 0; x < 4; x++)
    //        {
    //            Console.WriteLine("Ingrese sueldo:");
    //            linea = Console.ReadLine();
    //            sueldoMañana[x] = int.Parse(linea);
    //        }
    //        Console.WriteLine("Sueldos Turno Tarde");
    //        for (int x = 0; x < 4; x++)
    //        {
    //            Console.WriteLine("Ingrese sueldo: ");
    //            linea = Console.ReadLine();
    //            sueldoTarde[x] = int.Parse(linea);
    //        }

    //    }
    //    public void Imprimir()
    //    {
    //        int sumaMañana = 0;
    //        int sumaTarde = 0;
    //        int suma = 0;
    //        for(int x = 0; x < 4; x++)
    //        {
    //            sumaMañana = sumaMañana + sueldoMañana[x];
    //            sumaTarde = sumaTarde + sueldoTarde[x];
    //        }
    //        Console.WriteLine("El sueldo total de la tarde es de $" + sumaTarde);
    //        Console.WriteLine("El sueldo total de la mañana es de $" + sumaMañana);

    //        suma = sumaMañana + sumaTarde;

    //        Console.WriteLine("La suma total de los sueldos es de $" + suma);


    //    }
    //    static void Main(string[] args)
    //    {
    //        pv3 turnos = new pv3();
    //        turnos.PedirSueldos();
    //        turnos.Imprimir();
    //        Console.ReadKey();
    //    }
    //}

    //VECTOR .LENGTH
    //class Vector4
    //{
    //    private int[] sueldos;

    //    public void Ingresar()
    //    {
    //        string linea;
    //        Console.WriteLine("Ingresar cantidad de sueldos a colocar: ");
    //        linea = Console.ReadLine();
    //        int cant = int.Parse(linea);
    //        sueldos = new int[cant];
    //        for(int i=0;i< sueldos.Length; i++)
    //        {
    //            Console.WriteLine("Ingrese el sueldo: ");
    //            linea = Console.ReadLine();
    //            sueldos[i] = int.Parse(linea);
    //        }
    //    }
    //    public void Imprimir()
    //    {
    //        for(int i=0;i<sueldos.Length; i++)
    //        {
    //            Console.WriteLine(sueldos[i]);
    //        }
    //        Console.ReadKey();
    //    }
    //    static void Main(string[] args)
    //    {
    //        Vector4 v = new Vector4();
    //        v.Ingresar();
    //        v.Imprimir();
    //    }
    //}

    //VECTORES PARALELOS
    //class Vector5
    //{

    //    private string[] nombre;
    //    private int[] edad;

    //    public void IngresarDatos()
    //    {
    //        nombre = new string[5];
    //        edad = new int[5];
    //        for(int i=0; i < nombre.Length; i++)
    //        {
    //            string linea;
    //            Console.WriteLine("Ingrese su nombre: ");
    //            nombre[i] = Console.ReadLine();
    //            Console.WriteLine("Ingrese su edad: ");
    //            linea = Console.ReadLine();
    //            edad[i] = int.Parse(linea);

    //        }
    //    }
    //    public void EsMayor()
    //    {
    //        Console.WriteLine("\nLas personas mayores de edad son:");
    //        for (int i = 0; i < edad.Length; i++)
    //        {
    //            if (edad[i] >= 18)
    //            {
    //                Console.WriteLine(nombre[i]);
    //            }
    //        }
    //        Console.ReadKey();
    //    }

    //    static void Main()
    //    {
    //        Vector5 vector5 = new Vector5();
    //        vector5.IngresarDatos();
    //        vector5.EsMayor();
    //    }
    //}
    //class MayorMenor
    //{
    //    private string[] operarios;
    //    private int[] sueldos;

    //    public void IngresarDatos()
    //    {
    //        operarios = new string [5];
    //        sueldos = new int[5];
    //        for (int i=0; i < operarios.Length; i++)
    //        {
    //            string linea;
    //            Console.WriteLine("Ingrese su nombre: ");
    //            operarios[i] = Console.ReadLine();
    //            Console.WriteLine("Ingrese su sueldo: ");
    //            linea = Console.ReadLine();
    //            sueldos[i] = int.Parse(linea);
    //        }
    //    }
    //    public void MayorSueldo()
    //    {
    //        int pos = 0;
    //        int mayor;
    //        mayor = sueldos[0];

    //        for (int i = 1; i < sueldos.Length; i++){
    //            if (sueldos[i] > mayor)
    //            {
    //                mayor = sueldos[i];
    //                pos = i;
    //            }
    //        }
    //        Console.WriteLine("El empleado con mayor sueldo es " + operarios[pos]);
    //        Console.WriteLine("Tiene un sueldo de " + mayor);
    //        Console.ReadKey();
    //    }

    //static void Main(string[] args)
    //    {
    //        MayorMenor mayor = new MayorMenor();
    //        mayor.IngresarDatos();
    //        mayor.MayorSueldo();
    //    }

    //}

    //ORDENAMIENTO
    //class Vector6
    //{
    //    private int[] sueldos;

    //    public void Cargar()
    //    {
    //        sueldos = new int[5];
    //        for (int i = 0; i < sueldos.Length; i++)
    //        {
    //            string linea;
    //            Console.WriteLine("Ingrese sueldo: ");
    //            linea = Console.ReadLine();
    //            sueldos[i] = int.Parse(linea);
    //        }
    //    }
    //    public void Ordenar()
    //    {
    //        for(int i = 0; i < 4; i++)
    //        {
    //            for(int x = 0;x < 4 - i; x++)
    //            {
    //                if(sueldos[x] > sueldos[x + 1])
    //                {
    //                    int aux;
    //                    aux = sueldos[x];
    //                    sueldos[x] = sueldos[x + 1];
    //                    sueldos[x + 1] = aux;
    //                }
    //            }
    //        }
    //    }
    //    public void Imprimir()
    //    {
    //        Console.WriteLine("Sueldos ordenados de mayor a menor: ");
    //        for(int i = 0; i < sueldos.Length; i++)
    //        {
    //            Console.WriteLine(sueldos[i]);

    //        }
    //        Console.ReadKey();
    //    }
    //    static void Main(string[] args)
    //    {
    //        Vector6 vector = new Vector6();
    //        vector.Cargar();
    //        vector.Ordenar();
    //        vector.Imprimir();
    //    }
    //}


    //ORDENAMIENTO CADENAS DE CARACTERES
    //class Cadenas
    //{
    //    private string[] paises;

    //    public void Cargar()
    //    {
    //        paises = new string[5];
    //        for (int i = 0; i < paises.Length; i++)
    //        {
    //            Console.WriteLine("Ingrese un pais: ");
    //            paises[i] = Console.ReadLine(); 
    //        }
    //    }

    //    public void Ordenar()
    //    {
    //        for(int i = 0; i < 4; i++)
    //        {
    //            for(int j = 0; j < 4; j++)
    //            {
    //                if (paises[j].CompareTo(paises[j + 1]) > 0)
    //                {
    //                    string aux = paises[j];
    //                    paises[j] = paises[j + 1];
    //                    paises[j + 1] = aux;
    //                }
    //            }
    //        }
    //    }


    //    public void Imprimir()
    //    {
    //        Console.WriteLine("Los paises ordenados de menor a mayor alfabeticamente: ");
    //        for (int i = 0; i < 5; i++)
    //        {
    //                Console.WriteLine(paises[i]);  
    //        }
    //        Console.ReadKey();
    //    }
    //    static void Main(string[] args)
    //    {
    //        Cadenas cad1 = new Cadenas();
    //        cad1.Cargar();
    //        cad1.Ordenar();
    //        cad1.Imprimir();
    //    }
    //}
}
