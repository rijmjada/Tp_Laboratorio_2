using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos.Accesorios
{
    public class Cinturon : Producto
    {
        #region Atributos

        protected ETipoMaterial materialCinturon;
        protected ETalle talle;

        #endregion

        #region Constructores
        public Cinturon()
        {

        }
        public Cinturon(ETipoMaterial material, ETalle talle, decimal precio, EOrigen origen, string marca)
            :base(precio, origen,ETipo.Cinturon, marca)
        {
            this.materialCinturon = material;
            this.talle = talle;
        }

        #endregion

        #region Propiedades
        public override double Ganancia
        {
            get
            {
                return Convert.ToDouble(this.precio * 0.75M);
            }
        }
        public override ETipoMaterial TipoMaterial
        {
            get { return this.materialCinturon; }
            set { this.materialCinturon = value; }
        }

        public override ETalle Talle
        {
            get { return this.talle; }
            set { this.talle = value; }
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Retornara True si material y talle son iguales, false caso contrario.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(Cinturon c1, Cinturon c2)
        {
            bool ret = false;

            if(c1 is not null && c2 is not null)
            {
                ret = c1.materialCinturon == c2.materialCinturon && c1.talle == c2.talle;
            }

            return ret;
        }
        public static bool operator !=(Cinturon c1, Cinturon c2)
        {
            return !(c1 == c2);
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Retornara los datos del cinturon.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.AppendFormat("Tipo Material: {0}, ", this.TipoMaterial);
            sb.AppendFormat("Talle: {0}.", this.Talle);
            

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            Cinturon cinturon = obj as Cinturon;

            return cinturon is not null && cinturon == this;
        }

        #endregion
    }
}
