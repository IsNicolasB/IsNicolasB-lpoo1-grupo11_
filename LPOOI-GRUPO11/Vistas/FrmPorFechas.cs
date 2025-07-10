using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmPorFechas : Form
    {
        public FrmPorFechas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string connectionString = ClasesBase.Properties.Settings.Default.prestamosConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_ListarPrestamosPorFecha", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FechaDesde", dtpDesde.Value.Date);
                cmd.Parameters.AddWithValue("@FechaHasta", dtpHasta.Value.Date);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvPrestamos.DataSource = dt;

                // Contar estados
                int total = dt.Rows.Count;
                int otorgados = dt.Rows.Count;
                int pendientes = dt.Select("Estado = 'PENDIENTE'").Length;
                int cancelados = dt.Select("Estado = 'CANCELADO'").Length;
                int anulados = dt.Select("Estado = 'ANULADO'").Length;

                // Mostrar resultados
                lblTotales.Text = "Total: " + total +
                              " | Pendientes: " + pendientes +
                              " | Cancelados: " + cancelados +
                              " | Anulados: " + anulados;
            }
        }

        private void FrmPorFechas_Load(object sender, EventArgs e)
        {

        }
    }
}
