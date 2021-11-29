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
using AccesoDatos_BD;
using AccesoBD;



namespace Formularios
{
    public partial class FormInicio : Form
    {

        public static string archivo;
        public static Deposito<Producto> miDeposito;
        public static List<Venta> listaVentas;


        /// <summary>
        /// Inicializo el deposito de ropa con una capacidad de 50 productos
        /// </summary>
        public FormInicio()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
            miDeposito = new Deposito<Producto>(100);

        }


        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            FormAgregar frmAgregar = new FormAgregar(miDeposito);

            frmAgregar.StartPosition = FormStartPosition.CenterScreen;
            DialogResult ret = frmAgregar.ShowDialog();

        }

        private void btnVisualizaciones_Click(object sender, EventArgs e)
        {
            FormStock frmDepo = new FormStock(miDeposito);

            frmDepo.StartPosition = FormStartPosition.CenterScreen;
            DialogResult ret = frmDepo.ShowDialog();
        }


        private void FormInicio_Load(object sender, EventArgs e)
        {
           
            foreach(Producto item in AccesoDatos_BD.Stock_BD.LeerStock())
            {
                switch(item.Tipo)
                {
                    case ETipo.Bermuda:
                        miDeposito._lista.Add(new Bermuda(item.TipoMaterial, item.Talle, item.Precio, item.Origen, item.Marca));
                        break;

                    case ETipo.Cinturon:
                        miDeposito._lista.Add(new Cinturon(item.TipoMaterial, item.Talle, item.Precio, item.Origen, item.Marca));

                        break;

                    case ETipo.Pantalon:
                        miDeposito._lista.Add(new Pantalon(item.TipoMaterial, item.Talle, item.Precio, item.Origen, item.Marca));
                        break;

                    case ETipo.Remera:
                        miDeposito._lista.Add(new Remera(item.TipoMaterial,item.Talle,item.Precio,item.Origen,item.Marca));
                        break;
                }
            }

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVender frmVenta = new FormVender(miDeposito, listaVentas);

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

        /// <summary>
        /// Se utilizo en tp3.
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="depo"></param>
        private void SerializarXml(string ruta, Deposito<Producto> depo)
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                XmlSerializer xs = new XmlSerializer(depo._lista.GetType());
                xs.Serialize(sw, depo._lista);
            }
        }

        /// <summary>
        /// Se utilizo en tp3.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private List<Producto> DeserializarXml(string path)
        {

            using (StreamReader sw = new StreamReader(path))
            {

                XmlSerializer xs = new XmlSerializer(typeof(List<Producto>));
                List<Producto> aux = xs.Deserialize(sw) as List<Producto>;
                return aux;
            }

        }


        /// <summary>
        /// Se utilizo en tp3.
        /// </summary>
        /// <returns></returns>
        private static string CrearDirectorioYArchivo()
        {
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test Xml");

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }

            return ruta = Path.Combine(ruta, "datos.xml");
        }
    }
}
