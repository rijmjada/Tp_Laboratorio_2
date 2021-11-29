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
        List<Venta> listaVentas;
        Dictionary<string, int> listaSemana = new Dictionary<string, int>();

        public FormStock(Deposito<Producto> depo)
        {
            InitializeComponent();
            this.miDepo = depo;
            this.listaVentas = new List<Venta>();

            Task hiloBD = Task.Run(() =>
            {
                listaVentas = AccesoBD.Ventas_BD.LeerVentas();
            });

        }

        private void cargarDiasSemana()
        {
            listaSemana["Lunes"] = 0;
            listaSemana["Martes"] = 0;
            listaSemana["Miercoles"] = 0;
            listaSemana["Jueves"] = 0;
            listaSemana["Viernes"] = 0;
            listaSemana["Sabado"] = 0;
            listaSemana["Domingo"] = 0;

        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            cargarDiasSemana();
        }

        private void DiasSemanaVentas(List<Venta> list)
        {
            int valor;

            foreach (Venta venta in listaVentas)
            {
                switch(venta.Fecha.DayOfWeek)
                {
                    case DayOfWeek.Monday:

                        if (listaSemana.TryGetValue("Lunes", out valor))
                        {
                            listaSemana["Lunes"] = valor + 1;
                        }
                        valor = 0;
                        break;

                    case DayOfWeek.Tuesday:

                        if (listaSemana.TryGetValue("Martes", out valor))
                        {
                            listaSemana["Martes"] = valor + 1;
                        }
                        valor = 0;
                        break;

                    case DayOfWeek.Wednesday:

                        if (listaSemana.TryGetValue("Miercoles", out valor))
                        {
                            listaSemana["Miercoles"] = valor + 1;
                        }
                        valor = 0;
                        break;

                    case DayOfWeek.Thursday:

                        if (listaSemana.TryGetValue("Jueves", out valor))
                        {
                            listaSemana["Jueves"] = valor + 1;
                        }
                        valor = 0;
                        break;

                    case DayOfWeek.Friday:

                        if (listaSemana.TryGetValue("Viernes", out valor))
                        {
                            listaSemana["Viernes"] = valor + 1;
                        }
                        valor = 0;
                        break;

                    case DayOfWeek.Saturday:

                        if (listaSemana.TryGetValue("Sabado", out valor))
                        {
                            listaSemana["Sabado"] = valor + 1;
                        }
                        valor = 0;
                        break;

                    case DayOfWeek.Sunday:

                        if (listaSemana.TryGetValue("Domingo", out valor))
                        {
                            listaSemana["Domingo"] = valor + 1;
                        }
                        valor = 0;
                        break;
                }
            }
        }
   
        private void btnEstadisticasSemana_Click(object sender, EventArgs e)
        {
            listStock.Items.Clear();

            DiasSemanaVentas(listaVentas);

            listStock.Items.Add("Porcentajes de VENTAS por dias de la semana.");
            listStock.Items.Add("");
            foreach (KeyValuePair<string, int> item in listaSemana)
            {
                listStock.Items.Add(item.Key + " - " + Math.Round(Convert.ToDouble(item.Value * 100) / listaVentas.Count , 2) + "%");
            }
            // Pone todo en 0 de nuevo.
            cargarDiasSemana();
        }

    }
}
