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
    public partial class FrmABMClientes : Form
    {
        public FrmABMClientes()
        {
            InitializeComponent();
        }

        private void ABM_Clientes_Load(object sender, EventArgs e)
        {
            cargarDNIClientes();

            cmbSexoCli.Items.Add("...");
            cmbSexoCli.Items.Add("M");
            cmbSexoCli.Items.Add("F");
            cmbSexoCli.SelectedIndex = 0;

            dtpFechaNacimientoMod.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimientoMod.CustomFormat = "dd/MM/yyyy";

            // Opcional: evitar fechas futuras
            dtpFechaNacimientoMod.MaxDate = DateTime.Today;
        }

        private void cargarDNIClientes()
        {
            DataTable dt = TrabajarCliente.getClientesDNI();

            cmbEliminarDNI.DisplayMember = "CLI_DNI";
            cmbEliminarDNI.ValueMember = "CLI_DNI";
            cmbEliminarDNI.DataSource = dt;

            cmbModificarDNI.DisplayMember = "CLI_DNI";
            cmbModificarDNI.ValueMember = "CLI_DNI";
            cmbModificarDNI.DataSource = dt;
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea guardar los cambios realizados?", "Confirmar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    Cliente oCliente = new Cliente();

                    oCliente.CLI_DNI = cmbModificarDNI.SelectedValue.ToString();

                    oCliente.CLI_Nombre = txtNombreMod.Text;
                    oCliente.CLI_Apellido = txtApellidoMod.Text;
                    oCliente.CLI_Sexo = cmbSexoCli.SelectedItem.ToString();
                    oCliente.CLI_FechaNacimiento = dtpFechaNacimientoMod.Value;
                    oCliente.CLI_Ingresos = Convert.ToDecimal(txtIngresosMod.Text);
                    oCliente.CLI_Direccion = txtDireccionMod.Text;
                    oCliente.CLI_Telefono = txtTelefonoMod.Text;

                    TrabajarCliente.updateCliente(oCliente);

                    MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Verifique que los campos como Ingresos sean numéricos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            string dni = cmbEliminarDNI.SelectedValue.ToString();

            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar al cliente con DNI: " + dni + "?", "Confirmar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                TrabajarCliente.deleteCliente(dni);
                MessageBox.Show("Cliente eliminado correctamente.");

                cargarDNIClientes(); // actualiza el ComboBox
            }

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarNombre.Text;
            string apellido = txtBuscarApellido.Text;

            dgvClientes.DataSource = TrabajarCliente.buscarClientes(nombre, apellido);

        }

        private void cmbModificarDNI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModificarDNI.SelectedValue != null)
            {
                string dniSeleccionado = cmbModificarDNI.SelectedValue.ToString();

                Cliente cli = TrabajarCliente.buscarClientePorDNI(dniSeleccionado);

                if (cli != null)
                {
                    txtNombreMod.Text = cli.CLI_Nombre;
                    txtApellidoMod.Text = cli.CLI_Apellido;
                    cmbSexoCli.SelectedItem = cli.CLI_Sexo;
                    dtpFechaNacimientoMod.Value = cli.CLI_FechaNacimiento;
                    txtIngresosMod.Text = cli.CLI_Ingresos.ToString("F2");
                    txtDireccionMod.Text = cli.CLI_Direccion;
                    txtTelefonoMod.Text = cli.CLI_Telefono;
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            dvgClientesOrdenados.DataSource = TrabajarCliente.getClientesOrdenadosPorApellido();
        }

        private void dvgClientesOrdenados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
