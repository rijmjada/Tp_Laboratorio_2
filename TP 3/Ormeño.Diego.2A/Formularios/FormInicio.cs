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
using Entidades.Deposito;
using Entidades.Productos;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace Formularios
{
    public partial class FormInicio : Form
    {
        public static Deposito<Producto> miDepo;
        public static string archivo;

        /// <summary>
        /// Inicializo el deposito de ropa con una capacidad de 50 productos
        /// </summary>
        public FormInicio()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
            miDepo = new Deposito<Producto>(50);
            archivo = CrearDirectorioYArchivo();


        }


        private static string CrearDirectorioYArchivo()
        {
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test Xml");

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }

            return ruta = Path.Combine(ruta, "datos.xml");
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            FormAgregar frmAgregar = new FormAgregar(miDepo);

            frmAgregar.StartPosition = FormStartPosition.CenterScreen;
            DialogResult ret = frmAgregar.ShowDialog();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVisualizaciones_Click(object sender, EventArgs e)
        {
            FormStock frmDepo = new FormStock(miDepo);

            frmDepo.StartPosition = FormStartPosition.CenterScreen;
            DialogResult ret = frmDepo.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormInicio_Load(object sender, EventArgs e)
        {
            SerializarXml(archivo, miDepo);
            
            miDepo._lista = DeserializarXml(archivo);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVender frmVenta = new FormVender(miDepo);

            frmVenta.StartPosition = FormStartPosition.CenterScreen;
            DialogResult ret = frmVenta.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("¿Está seguro de querer salir ?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
            
        }

        private void FormInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
             SerializarXml(archivo, miDepo);
        }

        private void SerializarXml(string ruta, Deposito<Producto> depo)
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                XmlSerializer xs = new XmlSerializer(depo._lista.GetType());
                xs.Serialize(sw, depo._lista);
            }
        }

        private  List<Producto> DeserializarXml(string path)
        {

            using (StreamReader sw = new StreamReader(path))
            {

                XmlSerializer xs = new XmlSerializer(typeof(List<Producto>));
                List<Producto> aux = xs.Deserialize(sw) as List<Producto>;
                return aux;
            }

        }
    }
}
