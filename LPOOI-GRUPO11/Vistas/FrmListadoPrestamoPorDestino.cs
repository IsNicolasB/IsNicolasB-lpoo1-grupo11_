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
using System.Data.SqlClient;
using ClasesBase.Utils;

namespace Vistas
{
    public partial class FrmListadoPrestamoPorDestino : Form
    {
        public FrmListadoPrestamoPorDestino()
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
                    MostrarTotales(idDestino);
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

        private void grdPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void MostrarTotales(int destinoId)
        {
                try
                {
                    DataTable resumen = TrabajarPrestamo.ObtenerResumenPrestamosPorDestino(destinoId);  
                    if (resumen.Rows.Count>0)
                    {
                        DataRow row = resumen.Rows[0];
                        lblOtorgados.Text = "Otorgados: " + row["TotalOtorgados"].ToString();
                        lblPendientes.Text = "Pendientes: " + row["TotalPendientes"].ToString();
                        lblCancelados.Text = "Cancelados: " + row["TotalCancelados"].ToString();
                        lblAnulados.Text = "Anulados: " + row["TotalAnulados"].ToString();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar los totales : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
