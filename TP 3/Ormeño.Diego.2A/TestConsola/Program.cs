using System;
using Entidades;
using Entidades.Productos;
using Entidades.Deposito;
using Entidades.Productos.Accesorios;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Remeras
            Producto remera1 = new Remera(ETipoMaterial.Algodon,ETalle.Medium,388,EOrigen.China,"Nike");
            Producto remera2 = new Remera(ETipoMaterial.Algodon, ETalle.Medium, 388, EOrigen.China, "Nike");

            // Pantalones
            Producto pantalon1 = new Pantalon(ETipoMaterial.Jean, ETalle.Large, 890, EOrigen.Argentina, "Nike");
            Producto pantalon2 = new Pantalon(ETipoMaterial.Jean, ETalle.Large, 890, EOrigen.Taiwan, "Nike");


            // Remeras
            Console.WriteLine("                                                 [ Remeras ]");
            Console.WriteLine("Son iguales?: " + (remera1 == remera2));
            Console.WriteLine("");
            Console.WriteLine(remera1.ToString());
            Console.WriteLine(remera2.ToString());

            Console.WriteLine("\n");
            Console.ReadKey();

            // Pantalones
            Console.WriteLine("                                                 [ Pantalones ]");
            Console.WriteLine("Son iguales?: " + (pantalon1 == pantalon2));
            Console.WriteLine("");
            Console.WriteLine(pantalon1.ToString());
            Console.WriteLine(pantalon2.ToString());

            Console.WriteLine("\n");
            Console.ReadKey();

            // Accesorios
            Cinturon a1 = new Cinturon(ETipoMaterial.Cuero, ETalle.Medium, 540, EOrigen.Taiwan, "asd");
            Cinturon a2 = new Cinturon(ETipoMaterial.Cuero, ETalle.Medium, 540, EOrigen.Taiwan, "asd");

            // Cinturones
            Console.WriteLine("                                                 [ Cinturones ]");
            Console.WriteLine("Son iguales?: " + (a1 == a2));
            Console.WriteLine("");
            Console.WriteLine(a1.ToString());
            Console.WriteLine(a2.ToString());

            Console.WriteLine("\n");
            Console.ReadKey();

            // Deposito de Ropa
            Console.WriteLine("                                                 [ Deposito ]");
            Deposito<Producto> depoRopa = new Deposito<Producto>(2);

            
            // Agrego 1 remera y 1 pantalon
            depoRopa.Agregar(remera1);
            depoRopa.Agregar(pantalon1);

            // Agrego 2 cinturones
            depoRopa.Agregar(a1);
            depoRopa.Agregar(a2);

            // Intento agregar 1 remeras mas
            if (!(depoRopa + pantalon1))
            {
                Console.WriteLine("No se pudo agregar el item!!!");
            }

            // Muestro los datos del deposito y los productos que contenga
            Console.WriteLine(depoRopa);
           

            Console.ReadKey();
        }
    }
}
