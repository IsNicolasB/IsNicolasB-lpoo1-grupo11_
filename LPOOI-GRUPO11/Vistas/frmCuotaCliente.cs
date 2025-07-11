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
    public partial class frmCuotaCliente : Form
    {
        public frmCuotaCliente()
        {
            InitializeComponent();
        }


        private void frmCuotaCliente_Load(object sender, EventArgs e)
        {   
            string cadenaConexion = ClasesBase.Properties.Settings.Default.prestamosConnectionString;
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT cli_dni, cli_apellido + ', ' + cli_nombre AS NombreCompleto FROM Cliente ORDER BY cli_apellido, cli_nombre";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Esto es clave: usar la tabla directamente como fuente
                cmbClientes.DataSource = dt;
                cmbClientes.DisplayMember = "NombreCompleto";  // lo que se muestra
                cmbClientes.ValueMember = "cli_dni";           // lo que se guarda internamente

                cmbClientes.SelectedIndex = -1; // Ninguno seleccionado al principio
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtNroPrestamo.Text))
            {
                MessageBox.Show("Seleccioná un cliente y escribí el número de préstamo.");
                return;
            }

            DataRowView filaSeleccionada = (DataRowView)cmbClientes.SelectedItem;
            string dni = filaSeleccionada["cli_dni"].ToString();

            int nroPrestamo = Convert.ToInt32(txtNroPrestamo.Text);

            DataTable cuotas = TrabajarCuota.getCuotasPorClienteYPrestamo(dni, nroPrestamo);
            dgvCuotas.DataSource = cuotas;

            CalcularTotales(cuotas);

        }

        private void CalcularTotales(DataTable dt)
        {
            int pagadas = 0, pendientes = 0;
            decimal importePagado = 0, importePendiente = 0;

            foreach (DataRow row in dt.Rows)
            {
                string estado = row["Estado"].ToString();
                decimal importe = Convert.ToDecimal(row["Importe"]);

                if (estado == "PAGADA")
                {
                    pagadas++;
                    importePagado += importe;
                }
                else if (estado == "PENDIENTE")
                {
                    pendientes++;
                    importePendiente += importe;
                }
            }

            lblPagadas.Text = "Cuotas Pagadas: " + pagadas;
            lblPendientes.Text = "Cuotas Pendientes: " + pendientes;
            lblTotalPagado.Text = "Importe pagado: $" + importePagado.ToString("N2");
            lblTotalPendiente.Text = "Importe pendiente: $" + importePendiente.ToString("N2");

        }


    }
}
