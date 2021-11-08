using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Productos.Accesorios;
using Entidades.Productos;
using Entidades.Deposito;

namespace Formularios
{
    public partial class FormStock : Form
    {
        Deposito<Producto> miDepo;
       

        public FormStock(Deposito<Producto> miDepo)
        {
            InitializeComponent();
            this.miDepo = miDepo;
            
        }

        private void FormStock_Load(object sender, EventArgs e)
        {

           foreach(Producto item in miDepo._lista)
            {
                listStock.Items.Add(item.ToString());
            }
        }

        public void OrdenarRopa(EOrdenamiento o)
        {
            switch (o)
            {
               
                case EOrdenamiento.Precio:
                    this.miDepo._lista.Sort(OrdenarPorPrecio);
                    break;

                case EOrdenamiento.Tipo:
                    this.miDepo._lista.Sort(OrdenarPorTipo);
                    break;

                case EOrdenamiento.Origen:
                    this.miDepo._lista.Sort(OrdenarPorOrigen);
                    break;

                case EOrdenamiento.Ganancia:
                    this.miDepo._lista.Sort(OrdenarPorGanancia);
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Compara dos Productos por su atributo Ganancia.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int OrdenarPorGanancia(Producto a, Producto b)
        {
            return Convert.ToInt32(a.Ganancia - b.Ganancia);
        }
        /// <summary>
        /// Compara dos Productos por su atributo precio.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int OrdenarPorPrecio(Producto a, Producto b)
        {
            return Convert.ToInt32(a.Precio - b.Precio);
        }

        /// <summary>
        /// Compara dos Productos por su atributo tipo.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int OrdenarPorTipo(Producto a, Producto b)
        {
            return String.Compare(a.Tipo , b.Tipo);
        }

        /// <summary>
        /// Compara dos Productos por su atributo Origen.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int OrdenarPorOrigen(Producto a, Producto b)
        {
            return String.Compare(a.Origen , b.Origen);
        }
        /// <summary>
        /// Ordena la lista por el criterio de ordenamiento Precio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrdenarPorPrecio_Click(object sender, EventArgs e)
        {
            this.listStock.Items.Clear();
            OrdenarRopa(EOrdenamiento.Precio);
            foreach (Producto item in miDepo._lista)
            {
                listStock.Items.Add(item.ToString());
            }

        }

        /// <summary>
        /// Ordena la lista por el criterio de ordenamiento Tipo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrdenarPorTipo_Click(object sender, EventArgs e)
        {
            this.listStock.Items.Clear();
            OrdenarRopa(EOrdenamiento.Tipo);
            foreach (Producto item in miDepo._lista)
            {
                listStock.Items.Add(item.ToString());
            }
        }

        private void btnOrdenarPorOrigen_Click(object sender, EventArgs e)
        {
            this.listStock.Items.Clear();
            OrdenarRopa(EOrdenamiento.Origen);
            foreach (Producto item in miDepo._lista)
            {
                listStock.Items.Add(item.ToString());
            }
        }

        private void btnOrdenarPorGanancia_Click(object sender, EventArgs e)
        {
            this.listStock.Items.Clear();
            OrdenarRopa(EOrdenamiento.Ganancia);
            foreach (Producto item in miDepo._lista)
            {
                listStock.Items.Add(item.ToString());
            }
        }
    }
}
