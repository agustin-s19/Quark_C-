using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Electrodomesticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList Electrodomesticos = new ArrayList();

            Lavadora lava = new Lavadora(200, 100, "negro", 200, "A");
            Electrodomesticos.Add(lava);

            Television tv2 = new Television(40, true, 100, "negro", 20, "A");
            Electrodomesticos.Add(tv2);

            Television tv1 = new Television(40, false, 200, "negro", 20, "C");
            Electrodomesticos.Add(tv1);

            Electrodomestico el1 = new Electrodomestico(300, "rojo", 30,"A");
            Electrodomesticos.Add(el1);

            int sumaElectrodomesticos = 0;
            int sumaLavadoras = 0;
            int sumaTvs = 0;
            int sumaTotal = 0;
            foreach (object item in Electrodomesticos)
            {
                Type tipo = item.GetType();
                switch (tipo.Name)
                {
                    case "Television":
                        Television objTv = (Television)item;
                        objTv.CalcularPrecioFinal();
                        sumaTvs = sumaTvs + objTv.precioFinal;
                        break;
                    case "Lavadora":
                        Lavadora objLava = (Lavadora)item;
                        objLava.CalcularPrecioFinal();
                        sumaLavadoras = sumaLavadoras + objLava.precioFinal;
                        break;
                    case "Electrodomestico":
                        Electrodomestico objElectro = (Electrodomestico)item;
                        objElectro.CalcularPrecioFinal();
                        sumaElectrodomesticos = sumaElectrodomesticos + objElectro.precioFinal;
                        break;
                }
                sumaTotal = sumaElectrodomesticos + sumaLavadoras + sumaTvs;
              
               
            }
            Console.WriteLine(" \nLa suma total de las Lavadoras es de: "+ sumaLavadoras);
            Console.WriteLine("\nLa suma total de las tvs es de: " + sumaTvs);
            Console.WriteLine("\nLa suma total de los electrodomesticos es de "+ sumaElectrodomesticos);
            Console.WriteLine("\nLa suma total de todos los productos es de "+sumaTotal);
            Console.ReadKey();
        }

    }
}
