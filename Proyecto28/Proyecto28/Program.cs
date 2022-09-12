using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto28
{
    class Producto
    {
        public string Descripcion { get; set; }
        public int Precio { get; set; }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Dictionary<int, Producto> producto = new Dictionary<int, Producto>();
            producto.Add(1, new Producto { Descripcion="Papas", Precio=25});
            producto.Add(2, new Producto { Descripcion = "Cebollas", Precio = 10 });
            producto.Add(3, new Producto { Descripcion = "Milanesa", Precio = 200 });
            foreach(KeyValuePair<int, Producto> elemento in producto)
            {
                Console.WriteLine(elemento.Key + " " + elemento.Value.Descripcion + " " + elemento.Value.Precio);
            }
            Console.WriteLine("Ingrese el precio a consultar: ");
            int codigo = int.Parse(Console.ReadLine());
            if (producto.ContainsKey(codigo))
            {
                Console.WriteLine(producto[codigo].Descripcion + " " + producto[codigo].Precio);
            }
            else
            {
                Console.WriteLine("No se encontro ningun producto con dicho codigo");
            }
            Console.ReadKey();
        }

        // Diccionarios
        //static void Main(string[] args)
        //{
        //    Dictionary<string,string> dicc1 = new Dictionary<string,string>();
        //    dicc1["rojo"] = "red";
        //    dicc1["verde"] = "green";
        //    dicc1["blanco"] = "white";
        //    dicc1["negro"] = "black";
        //    foreach( KeyValuePair<string,string> elemento in dicc1)
        //    {
        //        Console.WriteLine(elemento.Key + " = " + elemento.Value);
        //    }
        //    if (dicc1.ContainsKey("rojo"))
        //    {
        //        Console.WriteLine(dicc1["rojo"]);
        //    }
        //    dicc1.Remove("rojo");
        //    if (dicc1.ContainsKey("rojo")){
        //        Console.WriteLine(dicc1["rojo"]);
        //    }
        //    else
        //    {
        //        Console.WriteLine("No existe la clave rojo");
        //    }
        //    Console.ReadKey();
        //}
    }
}
