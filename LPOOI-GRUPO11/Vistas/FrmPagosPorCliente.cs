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
    public partial class FrmPagosPorCliente : Form
    {
        public FrmPagosPorCliente()
        {
            InitializeComponent();
        }

        private void FrmPagosPorCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }
        private void CargarClientes()
        {
            try
            {
                cmbClientes.DataSource = TrabajarCliente.getClientes();
                cmbClientes.DisplayMember = "NombreCompleto";
                cmbClientes.ValueMember = "cli_dni";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedValue != null)
            {
                string clienteDNI = cmbClientes.SelectedValue.ToString();
                DataTable pagos = TrabajarPago.ObtenerPagosPorCliente(clienteDNI);
                dgvPagos.DataSource = pagos;

                // Calcular cantidad e importe total
                int cantidadPagos = pagos.Rows.Count;
                decimal totalImporte = 0;

                if (pagos.Columns.Contains("Importe")) // Asegurate que la columna se llama así
                {
                    foreach (DataRow row in pagos.Rows)
                    {
                        decimal importe;
                        if (decimal.TryParse(row["Importe"].ToString(), out importe))
                        {
                            totalImporte += importe;
                        }
                    }
                }

                // Mostrar resumen
                lblResumen.Text = string.Format("Cantidad de pagos: {0}    Total pagado: ${1:F2}", cantidadPagos, totalImporte);

            }
            else
            {
                MessageBox.Show("Seleccione un cliente.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
