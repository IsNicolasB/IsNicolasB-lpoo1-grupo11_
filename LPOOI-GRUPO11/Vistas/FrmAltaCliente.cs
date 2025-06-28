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
    public partial class FrmAltaCliente : Form
    {
        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            cmbSexoCli.Items.Add("...");
            cmbSexoCli.Items.Add("M");
            cmbSexoCli.Items.Add("F");
            cmbSexoCli.SelectedIndex = 0;

            dtpFechaNacimientoCli.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimientoCli.CustomFormat = "dd/MM/yyyy";

            // Opcional: evitar fechas futuras
            dtpFechaNacimientoCli.MaxDate = DateTime.Today;
        }

        private void btnCrearCliente_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea guardar los datos ingresados?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    Cliente oCliente = new Cliente();

                    oCliente.CLI_DNI = txtDNICli.Text;
                    oCliente.CLI_Nombre = txtNombreCli.Text;
                    oCliente.CLI_Apellido = txtApellidoCli.Text;
                    oCliente.CLI_Sexo = cmbSexoCli.SelectedItem.ToString();
                    oCliente.CLI_FechaNacimiento = dtpFechaNacimientoCli.Value;
                    oCliente.CLI_Ingresos = Convert.ToDecimal(txtIngresosCli.Text);
                    oCliente.CLI_Direccion = txtDireccionCli.Text;
                    oCliente.CLI_Telefono = txtTelefonoCli.Text;


                    ClasesBase.DataAccess.TrabajarCliente.insertCliente(oCliente);

                    string mensaje = "DNI: " + oCliente.CLI_DNI + Environment.NewLine +
                                     "Nombre: " + oCliente.CLI_Nombre + Environment.NewLine +
                                     "Apellido: " + oCliente.CLI_Apellido + Environment.NewLine +
                                     "Sexo: " + oCliente.CLI_Sexo + Environment.NewLine +
                                     "Fecha de Nacimiento: " + oCliente.CLI_FechaNacimiento.ToString("dd/MM/yyyy") + Environment.NewLine +
                                     "Ingresos: $" + oCliente.CLI_Ingresos.ToString("N2") + Environment.NewLine +
                                     "Dirección: " + oCliente.CLI_Direccion + Environment.NewLine +
                                     "Teléfono: " + oCliente.CLI_Telefono;


                    MessageBox.Show(mensaje, "Datos del Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtDNICli.Clear();
                    txtNombreCli.Clear();
                    txtApellidoCli.Clear();
                    txtIngresosCli.Clear();
                    txtDireccionCli.Clear();
                    txtTelefonoCli.Clear();

                    cmbSexoCli.SelectedIndex = 0;

                    dtpFechaNacimientoCli.Value = DateTime.Today;

                    txtDNICli.Focus();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Verifique que los campos como ingresos sean numéricos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDNICli_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreCli_Click(object sender, EventArgs e)
        {

        }

        private void lblApellidoCli_Click(object sender, EventArgs e)
        {

        }

        private void lblSexoCli_Click(object sender, EventArgs e)
        {

        }

        private void txtApellidoCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDNICli_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
