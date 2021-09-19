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

namespace Calculadora_de_Ormeño.Diego
{
    public partial class DiegoOrmenio : Form
    {
        /// <summary>
        /// Lista Operaciones listbox
        /// </summary>
        List<string> listTxtOperaciones = new List<string>();


        public DiegoOrmenio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Se llama a la funcion limpiarCalcu cuando se ejecuta este eveneto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiegoOrmenio_Load(object sender, EventArgs e)
        {
            this.LimpiarCalcu();
        }

        /// <summary>
        /// Hace las operaciones entre dos valores ingresados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBox1.Text) && !String.IsNullOrWhiteSpace(txtBox2.Text) && !string.IsNullOrWhiteSpace(cmbBoxOperator.Text))
            {
                lblResultado.ForeColor = Color.Red; // Vuelvo al color original dps de convert to binario
                
                this.lblResultado.Text = Operar(txtBox1.Text , txtBox2.Text, cmbBoxOperator.Text).ToString();

                btnConvertirABinario.Enabled = true; // Habilito convertir a binario
                btnConvertirABinario.FlatStyle = FlatStyle.Standard;
                btnConvertirADecimal.FlatStyle = FlatStyle.Flat;

                agregarListBox();
            }
            else
            {
                MessageBox.Show("Debe ingresar datos para poder Operar", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Recibe los 3 parametros para hacer el calculo
        /// </summary>
        /// <param name="numero1"> 1° numero a operar </param>
        /// <param name="numero2"> 2° numero a operar </param>
        /// <param name="operador"> Tipo de operador </param>
        /// <returns> valor de la operacion </returns>
        private double Operar(string numero1 ,string numero2, string operador)
        {
            Operando n1 = new Operando(numero1);
            Operando n2 = new Operando(numero2);

            return Calculadora.Operar(n1, n2, operador[0]);
        }
        
        /// <summary>
        /// Agrega las operaciones en el ListBox 
        /// </summary>
        private void agregarListBox()
        {

            listTxtOperaciones.Add(txtBox1.Text + " "  + cmbBoxOperator.Text + " " + txtBox2.Text  + " = " + lblResultado.Text);

            listBoxHistorial.DataSource = null;
            listBoxHistorial.DataSource = listTxtOperaciones;
        }

        /// <summary>
        /// Pone en valores default la calculadora
        /// </summary>
        private void LimpiarCalcu()
        {
            this.lblResultado.Text = "";
            this.txtBox1.Text = "";
            this.txtBox2.Text = "";
            this.cmbBoxOperator.SelectedIndex = -1;
            this.lblResultado.ForeColor = Color.Red; // Color original
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirABinario.FlatStyle = FlatStyle.Flat;
            this.btnConvertirADecimal.Enabled = false;
            this.btnConvertirADecimal.FlatStyle = FlatStyle.Flat;
        }

        /// <summary>
        /// LLama a la funcion LimpiarCalcu();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.LimpiarCalcu();
        }

        /// <summary>
        /// Convierte el resultado de las operaciones en Binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string retDecimalBinario;

            Operando buffer = new Operando(lblResultado.Text);

            retDecimalBinario = buffer.DecimalBinario(lblResultado.Text);

            if(retDecimalBinario == "Valor inválido")
            {
                MessageBox.Show("Debe ser un entero positivo para poder convertirlo a binario", "Warning!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                lblResultado.Text = buffer.DecimalBinario(lblResultado.Text);
                // Cambio color de resultado para ser mas intuitivo
                lblResultado.ForeColor = Color.CadetBlue;
                
                // Desabilito q intente convertir a binario un numero ya binario, hasta q se pase a decimal o se vuelva a hacer otra operacion
                btnConvertirABinario.Enabled = false;
                btnConvertirADecimal.Enabled = true;
                btnConvertirADecimal.FlatStyle = FlatStyle.Standard;
                btnConvertirABinario.FlatStyle = FlatStyle.Flat;
            }
        }

        /// <summary>
        /// Filtra los valores ingresados por teclado en el txtbox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) 
                && !char.IsControl(e.KeyChar) 
                && e.KeyChar != ','
                && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Filtra los valores ingresados por teclado en el txtbox2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) 
                && !char.IsControl(e.KeyChar) 
                && e.KeyChar != ',' 
                && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Convierte un resultado en Binario a Decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            btnConvertirABinario.Enabled = true;

            Operando number = new Operando();

            lblResultado.Text = number.BinarioDecimal(lblResultado.Text);
           
            // Vuelvo al color original dps de convert to binario
            lblResultado.ForeColor = Color.Red;

            btnConvertirABinario.FlatStyle = FlatStyle.Flat;

            // Desabilito q intente convertir a decimal un numero ya decimal, hasta q se pase a binario 
            btnConvertirADecimal.Enabled = false;
            btnConvertirADecimal.FlatStyle = FlatStyle.Flat;
            btnConvertirABinario.FlatStyle = FlatStyle.Standard;

        }

        #region Cierre

        /// <summary>
        /// Cierre aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiegoOrmenio_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("¿Está seguro de querer salir ?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                // Continue
                Dispose();
            }
            else
            {
                // Cancel
                e.Cancel = true;
            }

        }

        /// <summary>
        /// Cierre aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("¿Está seguro de querer salir ?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                // Continue
                Dispose();
            }
        }


        #endregion

    }
}
