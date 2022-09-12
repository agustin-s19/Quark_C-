using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto7
{

    //VECTORES PARALELOS
    //internal class VectoresParalelos
    //{
    //    private string[] nombres;
    //    private int[] notas;
    //    private int notaAlta;
    //    public void PedirDatos() {
    //        nombres = new string[5];
    //        notas = new int[5];
    //        for(int i=0; i < nombres.Length; i++)
    //        {
    //            string linea;
    //            Console.WriteLine("Ingrese su nombre: ");
    //            nombres[i] = Console.ReadLine();
    //            Console.WriteLine("Ingrese su nota");
    //            linea = Console.ReadLine();
    //            notas[i] = int.Parse(linea);
    //        }
    //    }

    //    public void Calcular() {


    //        for (int i = 0; i < notas.Length-1; i++)
    //        {
    //            for(int x= 0; x< notas.Length-1; x++)
    //            {
    //                if (notas[x] < notas[x+1])
    //                {
    //                    int auxnota = notas[x];
    //                    notas[x] = notas[x + 1];
    //                    notas[x + 1] = auxnota;
    //                    string auxnombre = nombres[x];
    //                    nombres[x] = nombres[x + 1];
    //                    nombres[x + 1] = auxnombre;
    //                }
    //            }
    //        }
    //    }
    //    public void Imprimir()
    //    {
    //        for (int i = 0; i < nombres.Length; i++) {
    //            Console.WriteLine(nombres[i] + "  -  " + notas[i] );
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        VectoresParalelos vector = new VectoresParalelos();
    //        vector.PedirDatos();
    //        vector.Calcular();
    //        vector.Imprimir();
    //        Console.ReadKey();
    //    }
    //}

    //class matriz
    //{
    //EJERCICIO MATRIZ
    //    private int[,] mat;

    //    public void Cargar()
    //    {
    //        mat = new int[3, 5];
    //        for(int i = 0; i < 3; i++){
    //            for(int x = 0; x < 5; x++)
    //            {
    //                Console.WriteLine("Ingrese el componente: ");
    //                mat[i, x] = int.Parse(Console.ReadLine());
    //            }
    //        }
    //    }

    //    public void Imprimir() {

    //        for (int i = 0; i < 3; i++) {
    //            for( int x =0; x < 5; x++)
    //            {
    //                Console.Write(mat[i, x] + " - ");
    //            }
    //            Console.WriteLine();
    //        }


    //    }

    //    static void Main(string[] args)
    //    {
    //        matriz matriz = new matriz();
    //        matriz.Cargar();
    //        matriz.Imprimir();
    //        Console.ReadKey();

    //    }

    //EJERCICIO DIAGONAL MATRIZ
    //private int[,] mat;
    //public void Cargar()
    //{
    //    mat = new int[4, 4];
    //    for(int i = 0; i < 4; i++)
    //    {
    //        for(int x = 0; x < 4; x++)
    //        {
    //            Console.WriteLine("Ingrese Componente");
    //            mat[i, x] = int.Parse(Console.ReadLine());
    //        }
    //    }
    //}
    //public void Imprimir()
    //{
    //    //Console.WriteLine(mat[0, 0]);
    //    //Console.WriteLine("- " + mat[1, 1]);
    //    //Console.WriteLine("- " + "- "+mat[2, 2]);
    //    //Console.WriteLine("- " + "- " + " - "+mat[3, 3]);
    //    for (int i =0;i< 4; i++)
    //    {
    //        Console.Write(mat[i, i] + " ");
    //    }
    //}

    //static void Main(string[] args)
    //{
    //    matriz matriz = new matriz();
    //    matriz.Cargar();
    //    matriz.Imprimir();
    //    Console.ReadKey();

    //}
    //MATRIZ EJERCICIO 3
    //    private int[,] mat;

    //    public void Cargar()
    //    {
    //        mat = new int[3, 4];
    //        for(int i=0;i< 3; i++)
    //        {
    //            for(int x = 0; x < 4; x++)
    //            {
    //                Console.WriteLine("Ingrese componente: ");
    //                mat[i, x] = int.Parse(Console.ReadLine());
    //            }
    //        }
    //    }

    //    public void PrimeraFila()
    //    {
    //        for (int i = 0; i < 4; i++)
    //        {
    //            Console.Write(mat[0, i] + " ");
    //        }

    //    }

    //    public void UltimaFila()
    //    {
    //        for(int i = 0; i < 4; i++)
    //        {
    //            Console.Write(mat[2,i] + " " );
    //        }
    //    }

    //    public void PrimerColumna()
    //    {
    //        for(int i=0; i<3; i++)
    //        {
    //            Console.Write(mat[i,0] + " ");
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        matriz mat = new matriz();
    //        mat.Cargar();
    //        mat.PrimeraFila();
    //        mat.UltimaFila();
    //        mat.PrimerColumna();
    //        Console.ReadKey();

    //    }
    //}
    //class Matrices
    //    {
    //    private int [,] n;


    //    public void Crear()
    //    {
    //        string linea;
    //        Console.WriteLine("Ingrese cantidad de filas a colocar: ");
    //        linea = Console.ReadLine();
    //        int filas = int.Parse(linea);
    //        Console.WriteLine("Ingrese cantidad de columnas a colocar: ");
    //        linea = Console.ReadLine();
    //        int columnas = int.Parse(linea);

    //        n = new int[filas, columnas];
    //        for(int i=0; i < n.GetLength(0); i++)
    //        {
    //            for(int j=0; j < n.GetLength(1); j++)
    //            {
    //                Console.WriteLine("Ingrese componente: ");
    //                string c = Console.ReadLine();
    //                n[i, j] = int.Parse(c);

    //            }
    //        }
    //    }

    //    public void Imprimir()
    //    {
    //        for (int i=0; i < n.GetLength(0); i++)
    //        {
    //            for( int j=0; j < n.GetLength(1); j++)
    //            {
    //                Console.Write(n[i, j] + " ");
    //            }
    //            Console.WriteLine();
    //        }
    //    }

    //    public void ImprimirUltimaFila()
    //    {
    //        Console.WriteLine("Ultima fila");
    //        for(int i=0; i < n.GetLength(1); i++)
    //        {
    //            Console.Write( n[n.GetLength(0) - 1, i]+ " ");
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        Matrices matriz = new Matrices();
    //        matriz.Crear();
    //        matriz.Imprimir();
    //        matriz.ImprimirUltimaFila();
    //        Console.ReadKey();
    //    }
    //    }

    //GetLength ejercicio 2
    //class Matrix
    //{
    //    private int[,] mat;

    //    public void Pedir()
    //    {
    //        string linea;
    //        Console.WriteLine("Ingrese el numero de filas que quiere ingresar: "); 
    //        linea= Console.ReadLine();
    //        int filas = int.Parse(linea);
    //        Console.WriteLine("Ingrese el numero de columnas que desea crear: ");
    //        linea = Console.ReadLine();
    //        int columnas = int.Parse(linea);
    //        mat = new int[filas,columnas];
    //        for (int i = 0; i < mat.GetLength(0); i++)
    //        {
    //            for(int j = 0; j < mat.GetLength(1); j++)
    //            {
    //                Console.WriteLine("Ingrese componente: ");
    //                mat[i, j] = int.Parse(Console.ReadLine());
    //            }
    //        }
    //    }
    //    public void MostrarMayor()
    //    {
    //        int mayor = mat[0, 0];
    //        int fila = 0;
    //        int columna = 0;
    //        for (int i = 0; i < mat.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < mat.GetLength(1); j++)
    //            {
    //                if(mat[i, j] > mayor)
    //                {
    //                    mayor = mat[i, j];
    //                    fila = i;
    //                    columna = j;
    //                }
    //            }
    //        }
    //        Console.WriteLine("El componente mas grande es: " + mayor);
    //        Console.WriteLine("La fila seria " + fila);
    //        Console.WriteLine("La columna seria " + columna);
    //    }


    //    static void Main(string[] args)
    //    {
    //        Matrix m = new Matrix();
    //        m.Pedir();
    //        m.MostrarMayor();
    //        Console.ReadKey();
    //    }
    //}

    //MATRIZ+VECTORES
    //class MatrizVectorial
    //{

    //    private string[] nombres;
    //    private int[,] sueldos;
    //    private int [] sumaTotal;

    //    public void Cargar()
    //    {

    //        nombres = new string[4];
    //        sueldos = new int[4, 3];
    //        for (int i = 0; i < nombres.Length; i++) {
    //            Console.WriteLine("Ingrese su nombre: ");
    //            nombres[i] = Console.ReadLine(); 

    //        for (int x = 0; x < sueldos.GetLength(1); x++) { 

    //                string linea;
    //                Console.WriteLine("Ingrese el sueldo: ");
    //                linea = Console.ReadLine();
    //                sueldos[i,x] = int.Parse(linea); 

    //        }
    //    }

    //}
    //    public void CalcularSuma()
    //    {
    //        sumaTotal = new int[4];
    //        for (int i = 0; i < nombres.GetLength(0); i++)
    //        {
    //            int suma = 0;

    //            for(int j =0; j < sueldos.GetLength(1); j++)
    //            {
    //                suma = suma + sueldos[i,j];
    //            }
    //            sumaTotal[i] = suma;
    //        }


    //    }

    //    public void Imprimir()
    //    {
    //        Console.WriteLine("Total de sueldos por empleado: ");
    //        for(int i = 0; i < nombres.Length; i++)
    //        {
    //            Console.WriteLine(nombres[i]+ " - $"+ sumaTotal[i]);
    //        }
    //    }

    //    public void EmpleadoMayor()
    //    {
    //        int mayorSueldo = sumaTotal[0];
    //        string nom = nombres[0];
    //        for(int i = 1; i < nombres.Length; i++)
    //        {
    //            if (sumaTotal[i] > mayorSueldo)
    //            {
    //                mayorSueldo = sumaTotal[i];
    //                nom = nombres[i];
    //            }
    //        }
    //        Console.WriteLine("El trabajador mejor pago es " + nom + " con un sueldo de $" + mayorSueldo);

    //    }
    //    static void Main(string[] args)
    //    {
    //        MatrizVectorial mat = new MatrizVectorial();
    //        mat.Cargar();
    //        mat.CalcularSuma();
    //        mat.Imprimir();
    //        mat.EmpleadoMayor();        
    //        Console.ReadKey();
    //    }
    //}
    //class MatrizDentada
    //{
    //    private int[][] mat;

    //    public void Pedir()
    //    {
    //        int filas = 0;
    //        Console.WriteLine("Ingrese cantidad de filas: ");
    //        filas = int.Parse(Console.ReadLine());
    //        mat = new int[filas][];
    //        for (int i = 0; i < mat.Length; i++)
    //        {

    //            Console.WriteLine("Ingrese cantidad de columnas que desea para la fila " + (i + 1));
    //            int columna = int.Parse(Console.ReadLine());
    //            mat[i] = new int[columna];
    //            for (int j = 0; j < columna; j++)
    //            {
    //                string linea;
    //                Console.WriteLine("Ingrese componente: ");
    //                linea = Console.ReadLine();
    //                mat[i][j] = int.Parse(linea);
    //            }

    //        }
    //    }

    //    public void Imprimir()
    //    {
    //        Console.WriteLine("Matriz completa:");
    //        for (int i = 0; i < mat.Length; i++)
    //        {
    //            for (int j = 0; j < mat[i].Length; j++)
    //            {
    //                Console.Write(mat[i][j] + " - ");

    //            }
    //            Console.WriteLine();
    //        }

    //    }

    //    static void Main(string[] args)
    //    {
    //        MatrizDentada mat = new MatrizDentada();
    //        mat.Pedir();
    //        mat.Imprimir();
    //        Console.ReadKey();
    //    }
    //}
}