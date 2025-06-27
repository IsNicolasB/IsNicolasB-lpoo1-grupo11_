using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

using ClasesBase;

namespace Vistas
{
    public partial class FrmDestinoModificar : Form
    {
        public FrmDestinoModificar()
        {
            InitializeComponent();
            this.Load += new EventHandler(cmbDestino_Load);
        }
        
        //TITULOS
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //ENTRADA LISTADO
        private void cmbDestino_Load(object sender, EventArgs e)
        {
            CargarDestinos();
        }
        private void CargarDestinos()
        {
            cmbDestino.DataSource = TrabajarDestino.ListarDestinos();
            cmbDestino.DisplayMember = "DES_Descripcion";
            cmbDestino.ValueMember = "DES_Codigo";
        }

        //COMBOBOX ELECCION
        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDestino.SelectedItem != null)
            {
                DataRowView row = cmbDestino.SelectedItem as DataRowView;
                txtDestinoCod.Text = row["DES_Codigo"].ToString();
                txtDestinoDes.Text = row["DES_Descripcion"].ToString();
            }
        }
        

        //DESCRIPCION Y CODIGO
        private void txtDestinoDes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDestinoCod_TextChanged(object sender, EventArgs e)
        {

        }

        //BOTON
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDestinoCod.Text) && !string.IsNullOrEmpty(txtDestinoDes.Text))
            {
                Destino d = new Destino();
                d.DES_Codigo = int.Parse(txtDestinoCod.Text);
                d.DES_Descripcion = txtDestinoDes.Text;

                TrabajarDestino.ModificarDestino(d);
                   MessageBox.Show("Destino modificado correctamente.", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarDestinos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Seleccione un destino y complete la descripción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //EXTRA
        private void LimpiarCampos()
        {
            txtDestinoCod.Text = "";
            txtDestinoDes.Text = "";
        }

        


    }
}
