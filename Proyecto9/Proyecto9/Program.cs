using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto9
{
    //class Cliente // creo clase cliente
    //{
    //    private string nombre; // posee 2 atributos nombre y monto
    //    private int monto;

    //    public string Nombre // creo la propiedad de nombre
    //        {
    //            set
    //            {
    //                nombre = value;
    //            }
    //            get {
    //                return nombre; 
    //            }
    //        }
    //    public int Monto{ // creo la propiedad de monto
    //            set{
    //                monto = value;
    //            }
    //            get{
    //                return monto;
    //            }
    //    }
    //    public void Imprimir() // armo un metodo para imprimir
    //    {
    //        Console.WriteLine("El cliente " + Nombre + "tiene en cuenta un monto de " + Monto);
    //    }
    //}
    //class Banco { // se crea la clase banco
    //    private Cliente cliente1, cliente2, cliente3; //creo 3 clientes privados

    //    public Banco() // se crea la propiedad banco
    //    {
    //        cliente1 = new Cliente(); // se crea el cliente y va a tener dos valores vacios nombre y monto
    //        cliente1.Nombre = "Pedro"; // Se setea el nombre al cliente 1
    //        cliente1.Monto = 0; // Se setea el monto inicial del cliente 1
    //        cliente2 = new Cliente(); // se crea el cliente 2 vacio 
    //        cliente2.Nombre = "Maria"; //Se setea el nombre al cliente 2
    //        cliente2.Monto = 0; // Se setea el monto inicial del cliente 2
    //        cliente3 = new Cliente(); // se crea el cliente 3 vacio 
    //        cliente3.Nombre = "Reyna";//Se setea el nombre al cliente 3
    //        cliente3.Monto = 0;// Se setea el monto inicial del cliente 3

    //    }

    //    public void Operar() // creo el metodo operar para setear nuevos montos a los clientes
    //    {
    //        cliente1.Monto = cliente1.Monto + 200;
    //        cliente2.Monto = cliente2.Monto + 600;
    //        cliente3.Monto = cliente3.Monto + 1000;

    //    }

    //    public void DepositosTotales() // se crea el ultimo metodo el cual sacara cuanto es la suma de los depositos realizados
    //    {
    //        int t = cliente1.Monto + cliente2.Monto + cliente3.Monto;
    //        Console.WriteLine("El monto total es de " + t);
    //        cliente1.Imprimir();
    //        cliente2.Imprimir();
    //        cliente3.Imprimir();

    //    }
    //    static void Main(string[] args)
    //    {
    //        Banco banco1 = new Banco();
    //        banco1.Operar();
    //        banco1.DepositosTotales();
    //        Console.ReadKey();
    //    }
    //}

    //class Dados
    //{
    //    private int valor;

    //    public int Valor
    //    {
    //        set { 
    //            valor = value; 
    //        }
    //        get
    //        {
    //            return valor;
    //        }
    //    }
    //    private static Random aleatorio;

    //    public Dados()
    //        {
    //        aleatorio = new Random();
    //        }

    //    public void Tirar()
    //    {
    //        Valor = aleatorio.Next(1, 7);
    //    }
    //    public void Imprimir()
    //    {
    //        Console.WriteLine("El valor del dado es " + valor);
    //    }

    //    }

    //class JuegoDeDados
    //{
    //    private Dados dado1, dado2, dado3;
    //    public JuegoDeDados(){
    //        dado1 = new Dados();
    //        dado2 = new Dados();
    //        dado3 = new Dados();
    //    }

    //    public void Jugar()
    //    {
    //        dado1.Tirar();
    //        dado1.Imprimir();
    //        dado2.Tirar();
    //        dado2.Imprimir();
    //        dado3.Tirar();
    //        dado3.Imprimir();
    //        if(dado1.Valor == dado2.Valor && dado1.Valor == dado3.Valor)
    //        {
    //            Console.WriteLine("Felicitaciones ganaste Maquina!!!!");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Mala suerte. Perdiste esta vez");
    //        }
    //    }

    //    static void Main(string[] args) {
    //        JuegoDeDados juego1 = new JuegoDeDados();
    //        juego1.Jugar();
    //        Console.ReadKey();
    //    }
    //}
    // HERENCIA
    //public class Operacion
    //{
    //    protected int valor1, valor2;
    //    protected int resultado;

    //    public int Valor1
    //    {
    //        set
    //        {
    //            valor1 = value;
    //        }
    //        get
    //        {
    //            return valor1;
    //        }
    //    }
    //    public int Valor2
    //    {
    //        set
    //        {
    //            valor2 = value;
    //        }
    //        get
    //        {
    //            return valor2;
    //        }
    //    }
    //    public int Resultado
    //    {
    //        set
    //        {
    //            resultado = value;
    //        }
    //        get
    //        {
    //            return resultado;
    //        }
    //    }

    //}
    //public class Sumar: Operacion
    //{
    //      public void suma(){
    //        Resultado = Valor1 + Valor2;

    //      }
    //}
    //public class Restar: Operacion
    //{
    //    public void resta()
    //    {
    //        Resultado = Valor1 - Valor2;

    //    }

    //}
    //class Prueba
    //{
    // static void Main(string[] args)
    //    {
    //        Sumar suma1 = new Sumar();
    //        suma1.Valor1 = 12;
    //        suma1.Valor2 = 15;
    //        suma1.suma();
    //        Console.WriteLine("El valor de la suma es de " + suma1.Resultado);
    //        Restar resta1 = new Restar();
    //        resta1.Valor1 = 30;
    //        resta1.Valor2 = 10;
    //        resta1.resta();
    //        Console.WriteLine("El valor de la resta es de "+ resta1.Resultado);
    //        Console.ReadKey();
    //    }
    //}
    public class Persona {
        protected string nombre;
        protected int edad;
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("Nombre: "+Nombre+" - Edad: " +Edad);
        }

    }
    public class Empleado: Persona
    {
        protected int sueldo;
        public int Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }
        new public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("El sueldo del empleado es de $"+ Sueldo);
        }

    }
    class Prueba
    {
        static void Main(string[] args) {
        
            Persona persona1 = new Persona();
            persona1.Nombre = "Alfredo";
            persona1.Edad = 20;
            persona1.Imprimir();
            Empleado empleado1 = new Empleado();
            empleado1.Nombre = "Agustina";
            empleado1.Edad = 19;
            empleado1.Sueldo = 200000;
            empleado1.Imprimir();
           

            Console.ReadKey();
        }
    }
}

