using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using ClasesBase.DataAccess;

namespace Vistas
{
    public partial class FrmListadoPrestamo : Form
    {
        public FrmListadoPrestamo()
        {
            InitializeComponent();
        }

        private void FrmListadoPrestamo_Load(object sender, EventArgs e)
        {
            dgvPrestamos.DataSource = TrabajarPrestamo.getPrestamos();
            dgvPrestamos.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtpDesde.Value.Date;
            DateTime fechaHasta = dtpHasta.Value.Date;

            // Obtener todos los préstamos en un DataTable
            DataTable dt = TrabajarPrestamo.getPrestamos();

            // Filtrar filas por fecha
            var prestamosFiltrados = dt.AsEnumerable().Where(row =>
            {
                DateTime fecha = Convert.ToDateTime(row["PRE_Fecha"]);
                return fecha >= fechaDesde && fecha <= fechaHasta;
            });

            // Mostrar los préstamos filtrados en la grilla
            dgvPrestamos.DataSource = prestamosFiltrados.CopyToDataTable();

            // Calcular cantidades
            int total = prestamosFiltrados.Count();
            int pendientes = prestamosFiltrados.Count(r => r["PRE_Estado"].ToString().ToUpper() == "PENDIENTE");
            int cancelados = prestamosFiltrados.Count(r => r["PRE_Estado"].ToString().ToUpper() == "CANCELADO");
            int anulados = prestamosFiltrados.Count(r => r["PRE_Estado"].ToString().ToUpper() == "ANULADO");

            // Mostrar en un label llamado lblTotales
            lblTotales.Text = "Total: " + total +
                              " | Pendientes: " + pendientes +
                              " | Cancelados: " + cancelados +
                              " | Anulados: " + anulados;
        }


    }
}
