using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;


namespace Vistas
{

    public partial class FrmMain : Form
    {
        private Usuario usuarioLogueado;

public void FrmMainMenu(Usuario user)
{
    InitializeComponent();
    usuarioLogueado = user;
    ConfigurarAccesosSegunRol();
}

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
            "¿Seguro que querés cerrar la aplicación?",
            "Salir",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void altaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaCliente frmAlta = new FrmAltaCliente();
            frmAlta.ShowDialog();
        }

        private void altaPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaPrestamo frmAltaPrestamo = new FrmAltaPrestamo();
            frmAltaPrestamo.ShowDialog();
        }

        private void listarPrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoPrestamo frmListadoPrestamos = new FrmListadoPrestamo();
            frmListadoPrestamos.ShowDialog();
        }

        private void altaDestinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaDestino frmDestino = new FrmAltaDestino();
            frmDestino.ShowDialog();
            FrmListadoPrestamo frmListadoPrestamos = new FrmListadoPrestamo();
            frmListadoPrestamos.ShowDialog();
            
        }

        private void altaPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoPrestamo frmListadoPrestamos = new FrmListadoPrestamo();
            frmListadoPrestamos.ShowDialog();
        }

        

        private void modificarDestinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDestinoModificar frmDestinoModificar = new FrmDestinoModificar();
            frmDestinoModificar.ShowDialog();

        }

        private void eliminarDestinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarDestino frmEliminarDestino = new FrmEliminarDestino();
            frmEliminarDestino.ShowDialog();
        }

       private void ConfigurarAccesosSegunRol()
        {

            string rol = usuarioLogueado.ROL_Codigo;
            //pensado en sentido de que los botones funcionen asi:
            //clienteToolStripMenuItem=== usuarios destinos y periodos
            //prestamosToolStripMenuItem ==== clientes prestamos y pagos
            switch (rol)
            {
                case "ADM":
                    // Solo habilita Usuarios, Destinos y Periodo

                    aBMClienteToolStripMenuItem.Enabled = false;
                    prestamosToolStripMenuItem.Enabled = false;
            
                    break;

                case "OPE":
                    // Solo habilita Clientes, Prestamos y Pagos
                    aBMUsuarioToolStripMenuItem1.Enabled = false;
                    aBMDestinoToolStripMenuItem.Enabled = false;
                    break;

                case "AUD":
                    break;
            }
        }

       private void aBMUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           FrmABMUsuarios frmUsuario = new FrmABMUsuarios();
           frmUsuario.Show();
       }

       private void altaDestinoToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           FrmAltaDestino frmAltaDestino = new FrmAltaDestino();
           frmAltaDestino.Show();
       }

       private void modificarDestinoToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           FrmDestinoModificar frmModDestino = new FrmDestinoModificar();
           frmModDestino.Show();
       }

       private void eliminarDestinoToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           FrmEliminarDestino frmEliminarDestino = new FrmEliminarDestino();
           frmEliminarDestino.Show();
       }

       private void altaClienteToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           FrmAltaCliente frmAltaCliente = new FrmAltaCliente();
           frmAltaCliente.Show();
       }

       private void aBMClienteToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           FrmABMClientes frmABMClientes = new FrmABMClientes();
           frmABMClientes.Show();
       }

       private void gestionarPagosToolStripMenuItem_Click(object sender, EventArgs e)
       {

       }

       private void gestionarPagosToolStripMenuItem_Click_1(object sender, EventArgs e)
       {
           FrmGestionPagos frmGestionPagos = new FrmGestionPagos();
           frmGestionPagos.Show();
       }
       private void pagosPorClienteToolStripMenuItem_Click_1(object sender, EventArgs e)
       {
           FrmPagosPorCliente frmPagosporCliente = new FrmPagosPorCliente();
           frmPagosporCliente.Show();
       }

    }
}
