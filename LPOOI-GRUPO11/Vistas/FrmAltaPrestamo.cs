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
    public partial class FrmAltaPrestamo : Form
    {
        public FrmAltaPrestamo()
        {
            InitializeComponent();
        }

        private void FrmAltaPrestamo_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarDestinos();
            CargarPeriodos();
        }

        private void CargarClientes()
        {
            cmbCliente.DataSource = TrabajarCliente.getClientes();
            cmbCliente.DisplayMember = "CLI_Nombre";
            cmbCliente.ValueMember = "CLI_DNI";
        }

        private void CargarDestinos()
        {
            cmbDestino.DataSource = TrabajarDestino.ListarDestinos();
            cmbDestino.DisplayMember = "DES_Descripcion";
            cmbDestino.ValueMember = "DES_Codigo";
        }

        private void CargarPeriodos()
        {
            cmbPeriodo.DataSource = TrabajarPeriodo.ListarPeriodos();
            cmbPeriodo.DisplayMember = "PER_Descripcion";
            cmbPeriodo.ValueMember = "PER_Codigo";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearPrestamo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea guardar el préstamo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    Prestamo oPrestamo = new Prestamo();

                    oPrestamo.CLI_DNI = cmbCliente.SelectedValue.ToString();
                    oPrestamo.DES_Codigo = Convert.ToInt32(cmbDestino.SelectedValue);
                    oPrestamo.PER_Codigo = Convert.ToInt32(cmbPeriodo.SelectedValue);
                    oPrestamo.PRE_Fecha = DateTime.Today;
                    oPrestamo.PRE_Importe = Convert.ToDecimal(txtImporte.Text);
                    oPrestamo.PRE_TasaInteres = Convert.ToDouble(txtInteres.Text);
                    oPrestamo.PRE_CantidadCuotas = Convert.ToInt32(txtCantidadCuotas.Text);
                    oPrestamo.PRE_Estado = "PENDIENTE";

                    oPrestamo.PRE_Numero = TrabajarPrestamo.insertPrestamo(oPrestamo);

                    decimal importeTotal = oPrestamo.PRE_Importe * (1 + (decimal)(oPrestamo.PRE_TasaInteres / 100));
                    decimal importePorCuota = Math.Round(importeTotal / oPrestamo.PRE_CantidadCuotas, 2);

                    for (int i = 1; i <= oPrestamo.PRE_CantidadCuotas; i++)
                    {
                        Cuota oCuota = new Cuota();
                        oCuota.PRE_Numero = oPrestamo.PRE_Numero;
                        oCuota.CUO_Numero = i;
                        oCuota.CUO_Importe = importePorCuota;
                        oCuota.CUO_Estado = "PENDIENTE";
                        oCuota.CUO_Vencimiento = oPrestamo.PRE_Fecha.AddMonths(i);

                        TrabajarCuota.insertCuota(oCuota);
                    }

                    string mensaje =
                        "Número de Préstamo: " + oPrestamo.PRE_Numero + Environment.NewLine +
                        "DNI Cliente: " + oPrestamo.CLI_DNI + Environment.NewLine +
                        "Código Destino: " + oPrestamo.DES_Codigo + Environment.NewLine +
                        "Código Período: " + oPrestamo.PER_Codigo + Environment.NewLine +
                        "Fecha: " + oPrestamo.PRE_Fecha.ToString("dd/MM/yyyy") + Environment.NewLine +
                        "Importe: $" + oPrestamo.PRE_Importe.ToString("N2") + Environment.NewLine +
                        "Tasa de Interés: " + oPrestamo.PRE_TasaInteres.ToString("N2") + "%" + Environment.NewLine +
                        "Cantidad de Cuotas: " + oPrestamo.PRE_CantidadCuotas + Environment.NewLine +
                        "Estado: " + oPrestamo.PRE_Estado;

                    MessageBox.Show(mensaje, "Datos del Préstamo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar formulario
                    txtImporte.Clear();
                    txtInteres.Clear();
                    txtCantidadCuotas.Clear();
                    cmbCliente.SelectedIndex = 0;
                    cmbDestino.SelectedIndex = 0;
                    cmbPeriodo.SelectedIndex = 0;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Verifique que los campos numéricos estén correctamente escritos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
