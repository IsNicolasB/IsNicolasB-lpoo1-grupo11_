using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ClasesBase;
using ClasesBase.DataAccess;

namespace Vistas
{
    public partial class FrmPagosPorClienteYFecha : Form
    {
        public FrmPagosPorClienteYFecha()
        {
            InitializeComponent();
        }

        private void FrmPagosPorClienteYFecha_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }
        private void CargarClientes()
        {
            try
            {
                string cadenaConexion = ClasesBase.Properties.Settings.Default.prestamosConnectionString;
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("SELECT cli_dni, cli_apellido + ',' + cli_nombre AS NombreCompleto FROM Cliente", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbClientes.DataSource = dt;
                    cmbClientes.DisplayMember = "NombreCompleto";
                    cmbClientes.ValueMember = "cli_dni";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

    }
}
