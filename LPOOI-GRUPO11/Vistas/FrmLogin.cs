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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user = TrabajarUsuario.Login(txtUserName.Text, txtPassword.Text);

            if (user != null)
            {
                MessageBox.Show("Bienvenido: " + txtUserName.Text);
                FrmMain oFrMain = new FrmMain();
                oFrMain.FrmMainMenu(user);
                oFrMain.Show();
                this.Hide(); // oculta el login
            }
            else
            {
                MessageBox.Show("Datos de Acceso Incorrectos");
            }

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            // Cambia el color del boton
            
            button1.ForeColor = System.Drawing.Color.DarkBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            // Restaura color original
            button1.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

     
    }
}
