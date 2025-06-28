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
    public partial class FrmGestionPagos : Form
    {
        public FrmGestionPagos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmGestionPagos_Load(object sender, EventArgs e)
        {
            dargarClientes();
            cmbPrestamos.Enabled = false;
            dgvCuotasPendientes.Enabled = false;
            dgvCuotasPendientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCuotasPendientes.MultiSelect = false;

        }

        private void dargarClientes()
        {   
            DataTable clientes = TrabajarCliente.getClientes();
            DataRow filaVacia = clientes.NewRow();
            filaVacia["CLI_DNI"] = DBNull.Value;
            filaVacia["CLI_Nombre"] = "-- Seleccione un cliente --";

            // Insertar la fila vacía al principio
            clientes.Rows.InsertAt(filaVacia, 0);

            // Asignar al ComboBox
            cmbClientes.DataSource = clientes;
            cmbClientes.DisplayMember = "CLI_Nombre";
            cmbClientes.ValueMember = "CLI_DNI";
        }

        private void cargarPrestramosPendientes()
        {
            string dni = cmbClientes.SelectedValue.ToString();
            DataTable prestamosPendientes = TrabajarPrestamo.getPrestamosPendientes(dni);

            if (prestamosPendientes.Rows.Count > 0)
            {
                DataRow filaVacia = prestamosPendientes.NewRow();
                filaVacia["PRE_Numero"] = DBNull.Value;

                // Insertar la fila vacía al principio
                prestamosPendientes.Rows.InsertAt(filaVacia, 0);
                cmbPrestamos.Enabled = true;
                cmbPrestamos.DataSource = prestamosPendientes;
                cmbPrestamos.DisplayMember = "PRE_Numero";
                cmbPrestamos.ValueMember = "PRE_Numero";
            }
            else
            {
                MessageBox.Show("El cliente no posee préstamos pendientes.");
                cmbPrestamos.DataSource = null;
            }
        }
        
        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (cmbClientes.SelectedValue != DBNull.Value && cmbClientes.SelectedValue is string)
            {
                cargarPrestramosPendientes();
            }
        }

        private void cargarCuotasPendientes(int prestamoId)
        {
            dgvCuotasPendientes.DataSource = TrabajarCuota.getCuotasPendientes(prestamoId);
            dgvCuotasPendientes.Enabled = true;
            dgvCuotasPendientes.Refresh();
        }

        private void cmbPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPrestamos.SelectedValue is int)
            {
                int prestamoId = Convert.ToInt32(cmbPrestamos.SelectedValue);
                cargarCuotasPendientes(prestamoId);
            }
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            if (dgvCuotasPendientes.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una cuota.");
                return;
            }

            int cuotaId = Convert.ToInt32(dgvCuotasPendientes.CurrentRow.Cells["CUO_Codigo"].Value);
            int prestamoId = 0;
            if (cmbPrestamos.SelectedValue is int)
            {   
                prestamoId = Convert.ToInt32(cmbPrestamos.SelectedValue);
            }
            else{
                MessageBox.Show("Debe seleccionar un prestamo.");
                return;
            }
            
            DateTime fechaPago = dtpFechaPago.Value;
            decimal importe = Convert.ToDecimal(dgvCuotasPendientes.CurrentRow.Cells["CUO_Importe"].Value);

            MessageBox.Show(TrabajarPago.insertPagoCuota(cuotaId, prestamoId, fechaPago, importe));

            if (TrabajarPrestamo.esPrestamoCancelado(prestamoId))
            {
                MessageBox.Show("EL PRESTAMO HA SIDO CANCELADO EN SU TOTALIDAD");
                cargarPrestramosPendientes();
            }
            cargarCuotasPendientes(prestamoId);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
