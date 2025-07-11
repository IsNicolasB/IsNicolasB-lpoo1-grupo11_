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
                        //Primer día de este año
            dtpDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpHasta.Value = DateTime.Today;
            CargarClientes();
        }
        private void CargarClientes()
        {
            try
            {
                DataTable dt = TrabajarCliente.getClientes();
                DataRow rowTodos = dt.NewRow();
                rowTodos["CLI_DNI"] = DBNull.Value; // DNI para "Todos"
                rowTodos["cli_nombre"] = "Todos los Clientes"; // <-- Aquí agregas el nombre "Todos los Clientes"
                dt.Rows.InsertAt(rowTodos, 0);

                cmbClientes.DataSource = dt;
                cmbClientes.DisplayMember = "cli_nombre";
                cmbClientes.ValueMember = "cli_dni";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private void CargarPagos()
        {
            // Validación de fechas
            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.", "Rango de fechas inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir sin ejecutar la consulta
            }

            string dniCliente = null;

            // Obtener el DNI del cliente seleccionado (si no es "Todos")
            if (cmbClientes.SelectedValue != DBNull.Value && cmbClientes.SelectedIndex > -1)
            {
                DataRowView dgvPagos = cmbClientes.SelectedItem as DataRowView;
                if (dgvPagos != null && dgvPagos["CLI_DNI"] != DBNull.Value)
                {
                    dniCliente = dgvPagos["CLI_DNI"].ToString();
                }
            }

            // Obtener las fechas de los DatePicker
            DateTime? fechaDesde = dtpDesde.Value.Date;
            DateTime? fechaHasta = dtpHasta.Value.Date;

            try
            {
                DataTable dt = TrabajarPago.ObtenerPagosFiltrados(dniCliente, fechaDesde, fechaHasta);
                dgvPagos.DataSource = dt;
                ActualizarEstadisticasPagos(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pagos: " + ex.Message);
            }
        }


        private void ActualizarEstadisticasPagos(DataTable dtPagos)
        {
            int cantidadPagos = 0;
            decimal importeTotal = 0;

            if (dtPagos != null)
            {
                cantidadPagos = dtPagos.Rows.Count;
                foreach (DataRow row in dtPagos.Rows)
                {
                    // Asegúrate que la columna se llame 'Importe' en tu DataTable
                    // (esto viene de tu vista vw_PagosClientes y el SP sp_ListarPagosFiltrados)
                    if (row["Importe"] != DBNull.Value)
                    {
                        importeTotal += Convert.ToDecimal(row["Importe"]);
                    }
                }
            }

            lblCantidadDePagos.Text = string.Format("Cantidad de Pagos: {0}", cantidadPagos);
            lblImporteTotal.Text = string.Format("Importe Total: {0:C2}", importeTotal); // Formato moneda
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPagos();
        }
        private void dgvPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarPagos();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            dtpDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpHasta.Value = DateTime.Today;
            // Resetear el ComboBox de clientes a la opción "Todos los Clientes" (primer elemento)
            cmbClientes.SelectedIndex = 0;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



    }
}
