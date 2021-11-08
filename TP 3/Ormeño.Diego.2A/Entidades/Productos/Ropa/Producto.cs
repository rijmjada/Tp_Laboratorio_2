using System;
using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Entidades.Productos.Remera))]
    [XmlInclude(typeof(Entidades.Productos.Pantalon))]
    [XmlInclude(typeof(Entidades.Productos.Bermuda))]
    [XmlInclude(typeof(Entidades.Productos.Accesorios.Cinturon))]
    public abstract class Producto
    {
        #region Atributos

        protected decimal precio;
        protected EOrigen origen;
        protected ETipo tipo;
        protected string marca;

        #endregion

        #region Propiedades

        public string Tipo { get { return this.tipo.ToString(); } }
        public  string Origen { get { return this.origen.ToString(); } }
        public  decimal Precio { get { return this.precio; } set { this.precio = value; } }

        public string Marca
        {
            get
            {
                return this.marca;
            }
            set
            {
                this.marca = value;
            }
        }

        public abstract double Ganancia { get; }

        #endregion

        #region Constructores

        public Producto()
        {

        }

        public Producto(decimal precio, EOrigen origen, ETipo tipo, string marca)
        {
            this.precio = precio;
            this.origen = origen;
            this.tipo = tipo;
            this.marca = marca;
        }


        #endregion

        #region Operadores

        /// <summary>
        /// Retornara true si tipo, precio y origen son iguales, false caso contrario.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            bool ret = false;

            if( p1 is not null && p2 is not null)
            {
                ret = (p1.tipo == p2.tipo) && (p1.Precio == p2.Precio) && (p1.origen == p2.origen);
            }

            return ret;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Retornara todos los datos del Producto(tipo, origen y precio)
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private static string ObtenerDatos(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tipo: {0}, ", p.Tipo);
            sb.AppendFormat("Marca: {0}, ", p.marca);
            sb.AppendFormat("Origen: {0}, ", p.Origen);
            sb.AppendFormat("Precio: ${0}, ", p.Precio.ToString()); ; ;

            return sb.ToString();
        }


        /// <summary>
        /// Retornara los datos del Producto, utilizando el metodo ObtenerDatos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ObtenerDatos(this);
        }



        #endregion
    }
}
