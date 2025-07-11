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
    public partial class FrmABMPeriodo : Form
    {
        public FrmABMPeriodo()
        {
            InitializeComponent();
        }

        private void FrmABMPeriodo_Load(object sender, EventArgs e)
        {
            CargarPeriodosCombo();
            CargarPeriodosCmbAEliminar();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, ingrese una descripción.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Periodo nuevoPeriodo = new Periodo
            {
                PER_Descripcion = txtDescripcion.Text.Trim()
            };

            try
            {
                TrabajarPeriodo.AgregarPeriodo(nuevoPeriodo);
                MessageBox.Show("Periodo agregado correctamente.");
                LimpiarCampos();  // Método que limpia los TextBox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el periodo: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtDescripcion.Text = "";
            txtDescripcion.Focus();
            CargarPeriodosCombo();
            CargarPeriodosCmbAEliminar();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataRowView row = cmbPeriodos.SelectedItem as DataRowView;
            if (row != null)
            {
                Periodo seleccionado = new Periodo
                {
                    PER_Codigo = Convert.ToInt32(row["PER_Codigo"]),
                    PER_Descripcion = txtNuevaDescripcion.Text.Trim()
                };

                try
                {
                    TrabajarPeriodo.ModificarPeriodo(seleccionado);
                    MessageBox.Show("Periodo modificado correctamente.");
                    CargarPeriodosCombo();
                    txtNuevaDescripcion.Clear();
                    cmbPeriodos.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el periodo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se pudo obtener el periodo seleccionado.");
            }
        }

        private void CargarPeriodosCombo()
        {
            DataTable dt = TrabajarPeriodo.ListarPeriodos();
            cmbPeriodos.DataSource = dt;
            cmbPeriodos.DisplayMember = "PER_Descripcion";
            cmbPeriodos.ValueMember = "PER_Codigo";
            cmbPeriodos.SelectedIndex = -1;
        }

        private void CargarPeriodosCmbAEliminar()
        {
            DataTable dt = TrabajarPeriodo.ListarPeriodos();
            cmbPeriodosAEliminar.DataSource = dt;
            cmbPeriodosAEliminar.DisplayMember = "PER_Descripcion";
            cmbPeriodosAEliminar.ValueMember = "PER_Codigo";
            cmbPeriodosAEliminar.SelectedIndex = -1;
        }

        private void cmbPeriodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPeriodos.SelectedIndex != -1)
            {
                Periodo seleccionado = cmbPeriodos.SelectedItem as Periodo;
                if (seleccionado != null)
                {
                    txtNuevaDescripcion.Text = seleccionado.PER_Descripcion;
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbPeriodosAEliminar.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un periodo para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener código del periodo seleccionado
            int codigo = Convert.ToInt32(cmbPeriodosAEliminar.SelectedValue);
            string descripcion = ((DataRowView)cmbPeriodosAEliminar.SelectedItem)["PER_Descripcion"].ToString();

            // Confirmación
            DialogResult resultado = MessageBox.Show(
                string.Format("¿Está seguro que desea eliminar el periodo \"{0}\"?", descripcion),
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {
                try
                {
                    TrabajarPeriodo.EliminarPeriodo(codigo);
                    MessageBox.Show("Periodo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    txtNuevaDescripcion.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el periodo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
