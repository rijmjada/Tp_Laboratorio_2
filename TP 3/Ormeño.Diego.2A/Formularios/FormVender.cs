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
using Entidades.Deposito;
using Entidades.Productos;
using Entidades.Productos.Accesorios;

namespace Formularios
{
    public partial class FormVender : Form
    {
        #region Atributos

        Deposito<Producto> miDeposito;

        #endregion

        public FormVender(Deposito<Producto> miDeposito)
        {
            InitializeComponent();
            this.miDeposito = miDeposito;
        }

        /// <summary>
        /// Cuando sea seleccionado un Tipo de Producto se listaran los mismos que se contengan en el Deposito.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            listProductoSeleccionado.Items.Clear();

            switch(cmbProducto.Text)
            {
                case "Remera":
                    AgregarAlListBox(miDeposito,ETipo.Remera);
                    break;

                case "Pantalon":
                    AgregarAlListBox(miDeposito, ETipo.Pantalon);
                    break;

                case "Bermuda":
                    AgregarAlListBox(miDeposito, ETipo.Bermuda);
                    break;

                case "Cinturon":
                    AgregarAlListBox(miDeposito, ETipo.Cinturon);
                    break;

            }
        }

        /// <summary>
        /// Agregara los productos del Etipo correspondiente al ListBox.
        /// </summary>
        /// <param name="depo"></param>
        /// <param name="tipo"></param>
        private void AgregarAlListBox(Deposito<Producto> depo, ETipo tipo)
        {
            foreach(Producto item in depo._lista)
            {
                if(item.Tipo == tipo.ToString())
                {
                    listProductoSeleccionado.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Agregara lista de Tipos al cmbProducto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVender_Load(object sender, EventArgs e)
        {
            // Agrego Lista de Tipos al cmbTipoRopa
            foreach (ETipo item in Enum.GetValues(typeof(ETipo)))
            {
                this.cmbProducto.Items.Add(item);
            }
        }


        /// <summary>
        /// Agregara la venta al archivo Ventas y eliminara el Producto del Deposito.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e)
        {
            if(listProductoSeleccionado.SelectedItem != null)
            {
                try
                {
                    this.miDeposito.Remover((Producto)listProductoSeleccionado.SelectedItem);
                    MessageBox.Show("Producto Vendido!");
                    this.listProductoSeleccionado.Items.Remove(listProductoSeleccionado.SelectedItem);
                    this.listProductoSeleccionado.ClearSelected();
                }
                catch
                {

                }
            }
                        
        }
    }
}
