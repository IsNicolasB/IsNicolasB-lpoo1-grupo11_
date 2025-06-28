using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

using ClasesBase;

namespace Vistas
{
    public partial class FrmEliminarDestino : Form
    {
        public FrmEliminarDestino()
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
        //LISTADO
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDestinoCod.Text))
            {
                int cod;
                if (int.TryParse(txtDestinoCod.Text, out cod))
                {
                    // Verificar si el código existe en el ComboBox
                    bool codigoExiste = false;
                    foreach (DataRowView item in cmbDestino.Items)
                    {
                        if ((int)item["DES_Codigo"] == cod)
                        {
                            codigoExiste = true;
                            break;
                        }
                    }

                    if (codigoExiste)
                    {
                        TrabajarDestino.EliminarDestino(cod);
                        MessageBox.Show("Destino eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDestinos();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("El código ingresado no corresponde a ningún destino del listado.", "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un código válido (número entero).", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un destino para eliminar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
