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
            CargarDestinos();
        }

        private void CargarDestinos()
        {
            try
            {
                cmbDestinos.DataSource = TrabajarDestino.ListarDestinos();
                cmbDestinos.DisplayMember = "DES_Descripcion";
                cmbDestinos.ValueMember = "DES_Codigo";
                cmbDestinos.SelectedIndex = -1; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar destinos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbDestinos.SelectedIndex != -1)
            {
                try
                {
                    int idDestino = Convert.ToInt32(cmbDestinos.SelectedValue);
                    grdPrestamos.DataSource = TrabajarPrestamo.ObtenerPrestamosPorDestino(idDestino);
                    grdPrestamos.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al filtrar los préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccioná un destino para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
