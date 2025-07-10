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

        private void txtBoxAnularPrestamo_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAnularPrestamo_Click(object sender, EventArgs e)
        {
            int numeroPrestamo;
            if (int.TryParse(txtBoxAnularPrestamo.Text, out numeroPrestamo))
            {
                if (!TrabajarPrestamo.PrestamoExiste(numeroPrestamo))
                {
                    MessageBox.Show("El número de préstamo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (TrabajarPrestamo.TieneCuotasPagadas(numeroPrestamo))
                {
                    MessageBox.Show("No se puede anular el préstamo porque ya tiene cuotas pagadas.", "No se puede anular", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("¿Está seguro que desea anular el préstamo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    TrabajarPrestamo.AnularPrestamo(numeroPrestamo);
                    MessageBox.Show("Préstamo anulado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBoxAnularPrestamo.Clear();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número de préstamo válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void labelAnular_Click(object sender, EventArgs e)
        {

        }


        





    }
}