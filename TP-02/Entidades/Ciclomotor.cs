using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region Constructor
        /// <summary>
        /// Constructor Ciclomotor, llama a constructor base
        /// </summary>
        /// <param name="marca"> marca ciclomotor </param>
        /// <param name="chasis"> chasis ciclomotor </param>
        /// <param name="color"> color ciclomotor </param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(marca, chasis, color)
        {
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio { get { return ETamanio.Chico; } }

        #endregion

        #region Metodos
        /// <summary>
        /// Lista las caracteristicas del Ciclomotor 
        /// </summary>
        /// <returns></returns>
        public override  string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendFormat(base.Mostrar());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
