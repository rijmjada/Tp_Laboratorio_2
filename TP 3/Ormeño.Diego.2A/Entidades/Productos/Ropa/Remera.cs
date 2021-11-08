using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos
{
    public class Remera : Producto, Ivendible
    {
        #region Atributos

        protected ETipoMaterial tipoTela;
        protected ETalle talle;

        #endregion

        #region Propiedades

        public ETipoMaterial TipoSet { set { this.tipoTela = value; } }

        public ETalle TalleSet { set { this.talle = value; } }
        public string TipoTela 
        { 
            get 
            { 
                return this.tipoTela.ToString(); 
            } 
        }

        public string Talle 
        { 
            get 
            { 
                return this.talle.ToString(); 
            } 
        }

        /// <summary>
        /// Retorna un tipo de dato double que representa la ganancia sobre el producto.
        /// </summary>
        public override double Ganancia 
        {
            get 
            { 
                return Convert.ToDouble(this.precio * 0.25M); 
            } 
        }
        #endregion

        #region Constructores

        public Remera()
        {

        }
        public Remera(ETipoMaterial tela, ETalle talle, decimal precio, EOrigen origen, string marca)
            : base(precio, origen, ETipo.Remera, marca)
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
        public static bool operator ==(Remera r1, Remera r2)
        {
            bool ret = false;

            if (r1 is not null && r2 is not null)
            {
                ret = (r1.talle == r2.talle) && (r1.tipoTela == r2.tipoTela);
            }

            return ret;
        }

        public static bool operator !=(Remera r1, Remera r2)
        {
            return !(r1 == r2);
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Retornara la informacion completa de Remera
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
            Remera remera = obj as Remera;

            return remera is not null && remera == this;
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
