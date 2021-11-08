using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos
{
    public class Pantalon : Producto, Ivendible
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

        public Pantalon()
        {

        }
        public Pantalon(ETipoMaterial tela, ETalle talle, decimal precio, EOrigen origen, string marca) 
            :base(precio, origen, ETipo.Pantalon, marca)
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
        public static bool operator ==(Pantalon p1, Pantalon p2)
        {
            bool ret = false;

            if(p1 is not null && p2 is not null)
            {
                ret = (p1.talle == p2.talle) && (p1.tipoTela == p2.tipoTela);
            }

            return ret;
        }

        public static bool operator !=(Pantalon p1, Pantalon p2)
        {
            return !(p1 == p2);
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Retornara la informacion completa de Pantalon
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
            Pantalon pantalon = obj as Pantalon;

            return pantalon is not null && pantalon == this;
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
