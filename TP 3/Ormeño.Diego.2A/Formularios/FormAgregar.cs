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
using System.Text.Json;
using System.IO;


namespace Formularios
{
    public partial class FormAgregar : Form
    {

        #region Atributos

        Producto nuevaRopa;
        Deposito<Producto> miDeposito;

    
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="miDeposito"></param>
        public FormAgregar(Deposito<Producto> miDeposito)
        {
            InitializeComponent();
            this.miDeposito = miDeposito;
            
        }
       
        /// <summary>
        /// 
        /// </summary>
        private void LimpiarDatos()
        {
            this.cmbTipoRopa.Text = "";
            this.cmbOrigen.Text = "";
            this.cmbTalle.Text = "";
            this.cmbMaterial.Text = "";
            this.txtMarca.Text = "";
            this.txtPrecio.Text = "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAgregar_Load(object sender, EventArgs e)
        {

            // Agrego Lista de Tipos al cmbTipoRopa
            foreach (ETipo item in Enum.GetValues(typeof(ETipo)))
            {
                this.cmbTipoRopa.Items.Add(item);
            }
            
            // Agrego Lista de Origen al cmbOrigen
            foreach (EOrigen item in Enum.GetValues(typeof(EOrigen)))
            {
                this.cmbOrigen.Items.Add(item);
            }

            // Agrego Lista de Talles al cmbTalle
            foreach (ETalle item in Enum.GetValues(typeof(ETalle)))
            {
                this.cmbTalle.Items.Add(item);
            }

           

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="cSymbol"></param>
        public static void AllowNumber(object sender, KeyPressEventArgs e, char cSymbol)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != cSymbol)
            {
                e.Handled = true;
            }

            if (e.KeyChar == cSymbol && (sender as TextBox).Text.IndexOf(cSymbol) > -1)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// TxtPrecio aceptara solo digitos y '.'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(sender, e, ','); //permitir sólo números decimales separados por sólo una coma
        }


        /// <summary>
        /// TxtMarca aceptara solo letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Validara que los campos esten completos y agregara un nuevo Producto, caso contrario mostrara un mensaje detallando el los requisitos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtMarca.Text) && !String.IsNullOrWhiteSpace(txtPrecio.Text) 
                && !String.IsNullOrWhiteSpace(cmbOrigen.Text) && !String.IsNullOrWhiteSpace(cmbTipoRopa.Text))
            {

                switch(cmbTipoRopa.Text)
                {
                    case "Remera":
                        AgregarRemera();
                        break;

                    case "Pantalon":
                        AgregarPantalon();
                        break;

                    case "Bermuda":
                        AgregarBermuda();
                        break;

                    case "Cinturon":
                        AgregarCinturon();
                        break;

                    default:
                        break;
                }

            }
            else
            {
                MessageBox.Show("Debe Ingresar todos los datos del Prodcuto", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        /// <summary>
        /// 
        /// </summary>
        private void AgregarPantalon()
        {
            nuevaRopa = new Pantalon((ETipoMaterial)cmbMaterial.SelectedItem, (ETalle)cmbTalle.SelectedItem, Convert.ToDecimal(txtPrecio.Text), (EOrigen)cmbOrigen.SelectedItem, txtMarca.Text);

            if (miDeposito.Agregar(nuevaRopa))
            {
                MessageBox.Show("Producto Agregado");
                LimpiarDatos();
              
            }
        }


       

        /// <summary>
        /// 
        /// </summary>
        private void AgregarRemera()
        {
            nuevaRopa = new Remera((ETipoMaterial)cmbMaterial.SelectedItem, (ETalle)cmbTalle.SelectedItem, Convert.ToDecimal(txtPrecio.Text), (EOrigen)cmbOrigen.SelectedItem, txtMarca.Text);

            if (miDeposito.Agregar(nuevaRopa))
            {
                MessageBox.Show("Producto Agregado");
                LimpiarDatos();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void AgregarBermuda()
        {
            nuevaRopa = new Bermuda((ETipoMaterial)cmbMaterial.SelectedItem, (ETalle)cmbTalle.SelectedItem, Convert.ToDecimal(txtPrecio.Text), (EOrigen)cmbOrigen.SelectedItem, txtMarca.Text);

            if (miDeposito.Agregar(nuevaRopa))
            {
                MessageBox.Show("Producto Agregado");
                LimpiarDatos();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void AgregarCinturon()
        {
            nuevaRopa = new Cinturon((ETipoMaterial)cmbMaterial.SelectedItem, (ETalle)cmbTalle.SelectedItem, Convert.ToDecimal(txtPrecio.Text), (EOrigen)cmbOrigen.SelectedItem, txtMarca.Text);
            if (miDeposito.Agregar(nuevaRopa))
            {
                MessageBox.Show("Producto Agregado");
                LimpiarDatos();
            }
        }

        /// <summary>
        /// Agregara items en el cmbMaterial, segun el tipo de Producto seleccionado en cmbTipoRopa. 
        /// Limpio el cmbMaterial cada vez q se vuelve a producir cambios en el cmbTipoRopa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTipoRopa_SelectedValueChanged(object sender, EventArgs e)
        {
     
            this.cmbMaterial.Items.Clear();

            switch (cmbTipoRopa.Text)
            {
                case "Remera":
                    this.cmbMaterial.Items.Add(ETipoMaterial.Algodon);
                    break;

                case "Pantalon":
                    this.cmbMaterial.Items.Add(ETipoMaterial.Jean);
                    this.cmbMaterial.Items.Add(ETipoMaterial.Gabardina);
                    break;

                case "Bermuda":
                    this.cmbMaterial.Items.Add(ETipoMaterial.Jean);
                    this.cmbMaterial.Items.Add(ETipoMaterial.Gabardina);
                    break;

                case "Campera":
                    this.cmbMaterial.Items.Add(ETipoMaterial.Jean);
                    this.cmbMaterial.Items.Add(ETipoMaterial.Cuero);
                    break;

                case "Cinturon":
                    this.cmbMaterial.Items.Add(ETipoMaterial.Cuero);
                    break;
            }
        }



    }
}
