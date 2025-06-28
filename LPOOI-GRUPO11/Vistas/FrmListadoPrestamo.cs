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

    }
}
