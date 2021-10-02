using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv :Vehiculo
    {
        #region Constructor

        /// <summary>
        /// Constructor De SUV
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(marca, chasis, color)
        {

        }

        #endregion

        #region Propiedades

        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio { get { return ETamanio.Grande; } }

        #endregion

        #region Metodos
        /// <summary>
        /// Retorna los datos de SUV
        /// </summary>
        /// <returns></returns>
        public override  string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendFormat(base.Mostrar());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
