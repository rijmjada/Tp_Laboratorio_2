using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        #region Atributos
        /// <summary>
        /// Atributo de tipo enumerado
        /// </summary>
        private ETipo tipo;

        #endregion

        #region Enumerado
        /// <summary>
        /// Enumerado de 'Tipo de Vehiculo'
        /// </summary>
        public enum ETipo { CuatroPuertas, CincoPuertas }

        #endregion

        #region Constructores

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : this(marca, chasis, color,ETipo.CuatroPuertas)
        {
        }
        /// <summary>
        /// Constructor de Sedan, llama a constructor base 
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : base(marca, chasis, color)
        {
            this.tipo = tipo;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio { get { return ETamanio.Mediano; } }

        #endregion

        #region Metodos
        /// <summary>
        /// Retorna los datos de un Sedan
        /// </summary>
        /// <returns> string </returns>
        public override  string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat("TIPO  : {0}\r\n", this.tipo.ToString());
            sb.AppendLine("");
            sb.AppendLine("---------------------");


            return sb.ToString();
        }

        #endregion

    }
}
