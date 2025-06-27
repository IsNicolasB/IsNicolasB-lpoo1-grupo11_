using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

using ClasesBase;

namespace Vistas
{
    public partial class FrmAltaDestino : Form
    {
        public FrmAltaDestino()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmDestino_Load);

        }

        //Lista desplegable
        private void FrmDestino_Load(object sender, EventArgs e)
        {
      
        }

        //Agregar Destino y Codigo
        private void txtDestinoDes_TextChanged(object sender, EventArgs e)
        {

        }

        //Botones

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Destino d = new Destino();
            d.DES_Descripcion = txtDestinoDes.Text;
            TrabajarDestino.InsertarDestino(d);

            string mensaje = "Descripción: " + d.DES_Descripcion;
            MessageBox.Show(mensaje, "Destino creado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtDestinoDes.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}