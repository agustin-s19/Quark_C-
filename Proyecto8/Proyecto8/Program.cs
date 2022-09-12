using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto8
{

    //CONSTRUCTOR 1
    //internal class Empleado
    //{
    //    private int[] sueldo;
    //    public Empleado()
    //    {
    //        sueldo = new int[4];
    //        for (int i = 0; i < sueldo.Length; i++)
    //        {
    //            Console.Write("Ingrese sueldo: ");
    //            sueldo[i]=int.Parse(Console.ReadLine());
    //        }
    //    }
    //    public void Imprimir()
    //    {
    //        for(int i = 0; i < sueldo.Length; i++)
    //        {
    //            Console.Write("$" + sueldo[i] + " - ");
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Empleado empleado = new Empleado();
    //        empleado.Imprimir();
    //        Console.ReadKey();
    //    }
    //}

    //CONSTRUCTOR 2
    //class Alumno
    //{
    //    private string alumno;
    //    private int edad;

    //    public Alumno()
    //    {
    //        Console.WriteLine("Ingrese el nombre del alumno: ");
    //        alumno = Console.ReadLine();
    //        Console.WriteLine("Ingrese la edad del alumno: ");
    //        edad = int.Parse(Console.ReadLine());
    //    }

    //    public void Imprimir()
    //    {
    //        Console.WriteLine("Nombre del alumno: " + alumno +" - " + edad + " años");
    //    }

    //    public void EsMayor()
    //    {
    //        if (edad >= 18)
    //        {
    //            Console.WriteLine( alumno + " es mayor de edad");

    //        }
    //        else
    //        {
    //            Console.WriteLine(alumno + " no es mayor de edad");
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        Alumno alum = new Alumno();
    //        alum.Imprimir();
    //        alum.EsMayor();
    //        Console.ReadKey();
    //    }
    //}
    //Clases Problema 1
    //namespace Colaboracion1
    //{
    //    class Cliente
    //    {
    //        private string nombre;
    //        private int  monto;
    //        public Cliente(string nom)
    //        {
    //            nombre = nom;
    //            monto = 0;
    //        }
    //        public void Depositar(int m)
    //        {
    //            monto = monto + m;
    //        }

    //        public void Extraer(int m)
    //        {
    //            monto = monto - m;
    //        }

    //        public int RetornarMonto()
    //        {
    //            return monto;
    //        }
    //        public void Imprimir() {
    //            Console.WriteLine("EL monto actual es de $" + monto);
    //        }
    //    }

    //    class Banco
    //    {
    //        private Cliente cliente1,cliente2, cliente3;
    //        public Banco()
    //        {
    //            cliente1 = new Cliente("Marcelo");
    //            cliente2 = new Cliente("Roberto");
    //            cliente3 = new Cliente("Matias");
    //        }
    //        public void Operar()
    //        {
    //            cliente1.Depositar(200);
    //            cliente3.Depositar(900);
    //            cliente2.Depositar(2000);
    //            cliente3.Extraer(400);
    //        }
    //        public void DepositosTotales()
    //        {
    //            int t = cliente1.RetornarMonto() +
    //                    cliente2.RetornarMonto() +
    //                    cliente3.RetornarMonto();
    //            Console.WriteLine("el total de dinero en el banco es $" + t);
    //            cliente1.Imprimir();
    //            cliente2.Imprimir();
    //            cliente3.Imprimir();

    //        }

    //        static void Main()
    //        {
    //            Banco banco1 = new Banco();
    //            banco1.Operar();
    //            banco1.DepositosTotales();
    //            Console.ReadKey();
    //        }
    //    }
    //}
    //JUEGO DE DADOS
    //class Dado
    //{
    //    private int valor;
    //    private static Random aleatorio;

    //    public Dado()
    //    {
    //        aleatorio = new Random();

    //    }
    //    public void Tirar()
    //    {
    //        valor = aleatorio.Next(1, 7);
    //    }
    //    public void Imprimir()
    //    {
    //        Console.WriteLine("El valor del dado es de " + valor);
    //    }
    //    public int RetornarValor()
    //    {
    //        return valor;
    //    }

    //}
    //class JuegoDeDados
    //{
    //    private Dado dado1, dado2, dado3;

    //    public JuegoDeDados()
    //    {
    //        dado1 = new Dado();
    //        dado2 = new Dado();
    //        dado3 = new Dado();
    //    }

    //    public void Jugar()
    //    {
    //        dado1.Tirar();
    //        dado1.Imprimir();
    //        dado2.Tirar();
    //        dado2.Imprimir();
    //        dado3.Tirar();
    //        dado3.Imprimir();
    //        if (dado1 == dado2 && dado1 == dado3)
    //        {
    //            Console.Write("Felicitaciones Ganaste");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Perdiste! Mala suerte");
    //        }


    //    }
    //    static void Main(string[] args)
    //    {
    //        JuegoDeDados juego1 = new JuegoDeDados();
    //        juego1.Jugar();
    //        Console.ReadKey();
    //    }
    //}
}
