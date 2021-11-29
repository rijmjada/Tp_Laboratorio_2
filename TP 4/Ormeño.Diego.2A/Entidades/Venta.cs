using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {

        #region Atributos

        private int idVenta;
        private DateTime fecha;
        private double precio;

        #endregion

        #region Propiedades
        public int Id
        {
            get { return this.idVenta; }
            set { this.idVenta = value; }
        }

        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }

        public double Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
        #endregion

        #region Constructores

        public Venta(int id, DateTime fecha, double precio) : this (fecha,precio)
        {
            this.Id = id;
        }
        public Venta(DateTime fecha, double precio) 
        {
            this.Fecha = fecha;
            this.Precio = precio;
        }

        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sw = new StringBuilder();

            sw.AppendLine("ID: " + this.Id);
            sw.AppendLine("Fecha: " + this.Fecha);
            sw.AppendLine("Precio: " + this.Precio);

            return sw.ToString();
        } 

        #endregion

    }
}
