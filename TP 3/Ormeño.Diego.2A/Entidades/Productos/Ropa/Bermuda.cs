using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos
{
    public class Bermuda : Producto, Ivendible
    {
        #region Atributos

        protected ETipoMaterial tipoTela;
        protected ETalle talle;

        #endregion

        #region Propiedades

        public string TipoTela { get { return this.tipoTela.ToString(); } }

        public string Talle { get { return this.talle.ToString(); } }

        public override double Ganancia
        {
            get
            {
                return Convert.ToDouble(this.precio * 0.45M);
            }

        }

        #endregion

        #region Constructores
        public Bermuda()
        {

        }
        public Bermuda(ETipoMaterial tela, ETalle talle, decimal precio, EOrigen origen, string marca)
            : base(precio, origen, ETipo.Bermuda, marca)
        {
            this.tipoTela = tela;
            this.talle = talle;
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Retornar True si:  talle y tela son iguales, False caso contrario.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Bermuda b1, Bermuda b2)
        {
            bool ret = false;

            if (b1 is not null && b2 is not null)
            {
                ret = (b1.talle == b2.talle) && (b1.tipoTela == b2.tipoTela);
            }

            return ret;
        }

        public static bool operator !=(Bermuda b1, Bermuda b2)
        {
            return !(b1 == b2);
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Retornara la informacion completa de Bermuda
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();


            sb.Append(base.ToString());
            sb.AppendFormat("Tela: {0}, ", this.TipoTela);
            sb.AppendFormat("Talle: {0}.", this.Talle);


            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Bermuda b = obj as Bermuda;

            return b is not null && b == this;
        }

        /// <summary>
        /// Devuelve la ganancia que genera la venta del producto.
        /// </summary>
        /// <returns></returns>
        public double RetornarGanancia()
        {
            return this.Ganancia;
        }

        #endregion
    }
}
