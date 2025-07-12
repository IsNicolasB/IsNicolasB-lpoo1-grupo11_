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
    public partial class frmAnularPrestamo : Form
    {
        public frmAnularPrestamo()
        {
            InitializeComponent();
        }


        private void frmAnularPrestamo_Load(object sender, EventArgs e)
        {
            cargarPrestamosActivos();
        }

        private void cargarPrestamosActivos() {
            DataTable prestamos = TrabajarPrestamo.getPrestamos();

            cboNumeroPrestamo.DataSource = prestamos;
            cboNumeroPrestamo.DisplayMember = "pre_numero";
            cboNumeroPrestamo.ValueMember = "pre_numero";

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (cboNumeroPrestamo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un número de préstamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int numeroPrestamo = Convert.ToInt32(cboNumeroPrestamo.SelectedValue);

            if (TrabajarPrestamo.TieneCuotasPagadas(numeroPrestamo))
            {
                MessageBox.Show("No se puede anular el préstamo porque ya tiene cuotas pagadas.", "No se puede anular", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "¿Está seguro que desea anular el préstamo?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                TrabajarPrestamo.AnularPrestamo(numeroPrestamo);
                MessageBox.Show("Préstamo anulado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // refresca el ComboBox si querés
                cargarPrestamosActivos();
            }
        }




        





    }
}