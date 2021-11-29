using System;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using Entidades.Productos;
using System.Collections.Generic;

namespace AccesoBD
{
    public class Ventas_BD
    {

        static SqlCommand comando;
        static SqlConnection conexion;

        static Ventas_BD()
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

        public static List<Venta> LeerVentas()
        {
            List<Venta> lista = new List<Venta>();

            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "SELECT * FROM ventas";
                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    // Obtengo los datos
                    int id = Convert.ToInt32(dataReader["id_venta"]);
                    DateTime fecha = Convert.ToDateTime(dataReader["fecha"]);
                    double monto = Convert.ToDouble(dataReader["monto"]);

                    // Creo el objecto Ventas
                    Venta nuevaVenta = new Venta(id,fecha,monto);

                    // Agrego la venta a la lista
                    lista.Add(nuevaVenta);
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

        public static bool Agregar(Venta venta)
        {
            bool ret = true;

            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"INSERT INTO ventas (fecha, monto)   VALUES (@fecha,@precio) ";

                comando.Parameters.AddWithValue("@fecha", venta.Fecha);
                comando.Parameters.AddWithValue("@precio", venta.Precio);

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

        public static bool Modificar(int id, DateTime fecha, double precio)
        {
            bool ret = true;

            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE ventas SET fecha = @fecha, monto = @monto WHERE id_venta = {id} ";

                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@monto", precio);

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

        public static bool Eliminar(int id)
        {
            bool ret = true;

            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"DELETE FROM ventas WHERE id_venta = {id}";
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

