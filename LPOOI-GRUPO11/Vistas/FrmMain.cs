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
            this.IsMdiContainer = true;
            usuarioLogueado = user;
            ConfigurarAccesosSegunRol();
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

        private void altaPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

 
       //ABM DE USUARIOS
       private void aBMUsuarioToolStripMenuItem2_Click(object sender, EventArgs e)
       {
           FrmABMUsuarios frmUsuario = new FrmABMUsuarios();
           frmUsuario.MdiParent = this;
           frmUsuario.WindowState = FormWindowState.Maximized;
           frmUsuario.Show();
       }

       //ABM DE DESTINOS

       private void altaDestinoToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           FrmAltaDestino frmAltaDestino = new FrmAltaDestino();
           frmAltaDestino.MdiParent = this;
           frmAltaDestino.WindowState = FormWindowState.Maximized;
           frmAltaDestino.Show();
       }

       private void modificarDestinoToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           FrmDestinoModificar frmModDestino = new FrmDestinoModificar();
           frmModDestino.MdiParent = this;
           frmModDestino.WindowState = FormWindowState.Maximized;
           frmModDestino.Show();
       }

       private void eliminarDestinoToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           FrmEliminarDestino frmEliminarDestino = new FrmEliminarDestino();
           frmEliminarDestino.MdiParent = this;
           frmEliminarDestino.WindowState = FormWindowState.Maximized;
           frmEliminarDestino.Show();
       }

       //ABM CLIENTES

       private void altaClienteToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           FrmAltaCliente frmAltaCliente = new FrmAltaCliente();
           frmAltaCliente.MdiParent = this;
           frmAltaCliente.WindowState = FormWindowState.Maximized;
           frmAltaCliente.Show();
       }

       private void aBMClienteToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           FrmABMClientes frmABMClientes = new FrmABMClientes();
           frmABMClientes.MdiParent = this;
           frmABMClientes.WindowState = FormWindowState.Maximized;
           frmABMClientes.Show();
       }


       //METODOS PARA LA GESTION DE PAGOS
 
       private void realizarPagoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           FrmGestionPagos frmGestionPagos = new FrmGestionPagos();
           frmGestionPagos.MdiParent = this;
           frmGestionPagos.WindowState = FormWindowState.Maximized;
           frmGestionPagos.Show();
       }

       private void listarPagosPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
       {
           FrmPagosPorCliente frmPagosporCliente = new FrmPagosPorCliente();
           frmPagosporCliente.MdiParent = this;
           frmPagosporCliente.WindowState = FormWindowState.Maximized;
           frmPagosporCliente.Show();
       }


       // METODOS PARA LA GESTION DE PRESTAMOS

       private void altaPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           FrmAltaPrestamo frmAltaPrestamo = new FrmAltaPrestamo();
           frmAltaPrestamo.MdiParent = this;
           frmAltaPrestamo.WindowState = FormWindowState.Maximized;
           frmAltaPrestamo.Show();
       }

       private void listarPrestamosToolStripMenuItem_Click(object sender, EventArgs e)
       {
           FrmListadoPrestamo frmListadoPrestamos = new FrmListadoPrestamo();
           frmListadoPrestamos.MdiParent = this;
           frmListadoPrestamos.WindowState = FormWindowState.Maximized;
           frmListadoPrestamos.Show();
       }

       private void listarPrestamosPorDestinoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           FrmListadoPrestamoPorDestino frmListadoPrestamos = new FrmListadoPrestamoPorDestino();
           frmListadoPrestamos.MdiParent = this;
           frmListadoPrestamos.WindowState = FormWindowState.Maximized;
           frmListadoPrestamos.Show();
       }

       private void listarPrestamosPorFechasToolStripMenuItem_Click(object sender, EventArgs e)
       {
           FrmPorFechas frmPorFechas = new FrmPorFechas();
           frmPorFechas.MdiParent = this;
           frmPorFechas.WindowState = FormWindowState.Maximized;
           frmPorFechas.Show();
       }

       // GESTION DE CUOTAS

       private void cuotasPorClientesYPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           frmCuotaCliente frmCuotasClientes = new frmCuotaCliente();
           frmCuotasClientes.MdiParent = this;
           frmCuotasClientes.WindowState = FormWindowState.Maximized;
           frmCuotasClientes.Show();
       }

       // OTROS EVENTOS

       private void label2_Click(object sender, EventArgs e)
       {

       }

       private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
       {

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

       private void listarPagosPorClienteYFechasToolStripMenuItem_Click(object sender, EventArgs e)
       {

       }



    }
}
