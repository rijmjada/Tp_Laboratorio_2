using System;
using Entidades;
using Entidades.Productos;
using Entidades.Deposito;
using Entidades.Productos.Accesorios;
using System.Collections.Generic;
using AccesoBD;
using AccesoDatos_BD;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Venta> lista = new List<Venta>();
            List<Producto> listProducto = new List<Producto>();

            Remera remera = new Remera(ETipoMaterial.Algodon, ETalle.Medium, 666, EOrigen.Argentina, "dsa");
            Pantalon pantalon = new Pantalon(ETipoMaterial.Gabardina, ETalle.Large, 1010, EOrigen.Taiwan, "asd");
            Bermuda bermuda = new Bermuda(ETipoMaterial.Jean, ETalle.Small, 666, EOrigen.China, "qwe");

            // TABLA DE VENTAS BD
            // LeerDatosBD();
            // AgregarVentaBD();
            // EliminarVentaBD();
            // ModificarVentaBD();

            // TABLA DE STOCK BD
            // LeerStockBD();
            // AccesoDatos_BD.Stock_BD.Agregar(pantalon);

            foreach (Producto item in AccesoDatos_BD.Stock_BD.LeerStock())
            {
                switch (item.Tipo)
                {
                    case ETipo.Remera:
                        listProducto.Add(new Remera(item.TipoMaterial, item.Talle, item.Precio, item.Origen, item.Marca));
                        break;

                    case ETipo.Pantalon:
                        listProducto.Add(new Pantalon(item.TipoMaterial, item.Talle, item.Precio, item.Origen, item.Marca));
                        break;

                    case ETipo.Bermuda:
                        listProducto.Add(new Bermuda(item.TipoMaterial, item.Talle, item.Precio, item.Origen, item.Marca));
                        break;

                    case ETipo.Cinturon:
                        listProducto.Add(new Entidades.Productos.Accesorios.Cinturon(item.TipoMaterial, item.Talle, item.Precio, item.Origen, item.Marca));
                        break;
                }

            }

            foreach(Producto item in listProducto)
            {
               Console.WriteLine(item.ToString());
    
            }


            //Stock_BD.Eliminar(pantalon);


            Console.ReadKey();
        }

        public static void LeerDatosBD()
        {
            List<Venta> lista = new List<Venta>();
            // Traer datos de la BD.
            lista = Ventas_BD.LeerVentas();

            foreach (Venta item in lista)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void AgregarVentaBD()
        {
            List<Venta> lista = new List<Venta>();
            Venta unaVenta = new Venta(DateTime.Now, 999);

            Ventas_BD.Agregar(unaVenta);
        }

        public static void EliminarVentaBD()
        {
            Ventas_BD.Eliminar(7);
            Ventas_BD.Eliminar(6);
            Ventas_BD.Eliminar(5);
        }

        public static void ModificarVentaBD()
        {
            Ventas_BD.Modificar(4, DateTime.Now, 9999);
        }

        public static void LeerStockBD()
        {
            List<Producto> listaProductos = new List<Producto>();

            listaProductos = Stock_BD.LeerStock();

            foreach (Producto item in listaProductos)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void AgregarProductoEnBD()
        {
            Remera remera = new Remera(ETipoMaterial.Algodon, ETalle.Medium, 996, EOrigen.Argentina, "adidas");
            Pantalon pantalon = new Pantalon(ETipoMaterial.Gabardina, ETalle.Large, 997, EOrigen.Taiwan, "nike");
            Bermuda bermuda = new Bermuda(ETipoMaterial.Jean, ETalle.Small, 998, EOrigen.China, "zara");
            Cinturon cinturon = new Cinturon(ETipoMaterial.Cuero, ETalle.Xl, 999, EOrigen.EEUU, "brown");

            Stock_BD.Agregar(remera);
            Stock_BD.Agregar(pantalon);
            Stock_BD.Agregar(bermuda);
            Stock_BD.Agregar(cinturon);
        }
      

    }
}
