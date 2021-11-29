using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using Entidades.Productos;


namespace AccesoDatos_BD
{
    public class Stock_BD
    {
        static SqlCommand comando;
        static SqlConnection conexion;

        static Stock_BD()
        {

            SqlConnectionStringBuilder strConexion = new SqlConnectionStringBuilder();
            strConexion.DataSource = @"DIEGO-PC\SQLEXPRESS";
            strConexion.InitialCatalog = @"UTN_TP";
            strConexion.IntegratedSecurity = true;


            comando = new SqlCommand();
            conexion = new SqlConnection(strConexion.ToString());
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;

        }

        public static List<Producto> LeerStock()
        {
            List<Producto> lista = new List<Producto>();

            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "SELECT * FROM productos";
                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    // Obtengo los datos

                    EOrigen origen = (EOrigen)Convert.ToInt32(dataReader["id_origen"]);
                    ETipo tipo = (ETipo)dataReader["id_tipo_producto"];
                    string marca = dataReader["marca"].ToString();
                    ETipoMaterial material = (ETipoMaterial)dataReader["id_material"];
                    ETalle talle = (ETalle)dataReader["id_talle"];
                    decimal precio = Convert.ToDecimal(dataReader["precio"]);

                    switch(tipo)
                    {
                        case ETipo.Remera:
                            Remera remera = new Remera(material, talle, precio,origen, marca);
                            lista.Add(remera);
                            break;

                        case ETipo.Pantalon:
                            Pantalon pantalon = new Pantalon(material, talle, precio, origen, marca);
                            lista.Add(pantalon);
                            break;

                        case ETipo.Bermuda:
                            Bermuda bermuda = new Bermuda(material, talle, precio, origen, marca);
                            lista.Add(bermuda);
                            break;

                        case ETipo.Cinturon:
                            Entidades.Productos.Accesorios.Cinturon cinturon = new Entidades.Productos.Accesorios.Cinturon(material, talle, precio, origen, marca);
                            lista.Add(cinturon);
                            break;
                    }

                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conexion.Close();
            }

            return lista;
        }

        public static bool Agregar(Producto producto)
        {
            bool ret = true;

            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"INSERT INTO productos (id_origen, id_tipo_producto, marca, id_material, id_talle, precio) VALUES (@origen, @tipo_producto, @marca, @material, @talle, @precio) ";

                comando.Parameters.AddWithValue("@origen",producto.Origen);
                comando.Parameters.AddWithValue("@tipo_producto", producto.Tipo);
                comando.Parameters.AddWithValue("@marca", producto.Marca);
                comando.Parameters.AddWithValue("@material", producto.TipoMaterial);
                comando.Parameters.AddWithValue("@talle", producto.Talle);
                comando.Parameters.AddWithValue("@precio", producto.Precio);

                comando.ExecuteNonQuery();

            }

            catch (Exception)
            {
                ret = false;
            }

            finally
            {
                conexion.Close();
            }

            return ret;
        }

        public static bool Eliminar(Producto producto)
        {
            bool ret = true;

            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"DELETE FROM productos WHERE id_origen = {Convert.ToInt32(producto.Origen)} " +
                                                                $"AND id_tipo_producto = {Convert.ToInt32(producto.Tipo)}" +
                                                                $"AND id_material = {Convert.ToInt32(producto.TipoMaterial)}" +
                                                                $"AND id_talle = {Convert.ToInt32(producto.Talle)}" +
                                                                $"AND precio LIKE {Convert.ToDouble(producto.Precio)}";


                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                ret = false;
            }
            finally
            {
                conexion.Close();
            }

            return ret;
        }

    }
}
