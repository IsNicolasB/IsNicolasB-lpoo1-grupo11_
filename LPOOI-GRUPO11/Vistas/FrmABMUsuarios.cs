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
    public partial class FrmABMUsuarios : Form
    {
        public FrmABMUsuarios()
        {
            InitializeComponent();
        }

        private void FrmABMUsuarios_Load(object sender, EventArgs e)
        {
            CargarIDUsuarios();
            CargarRoles();
        }

        private void CargarIDUsuarios()
        {
            DataTable dt = TrabajarUsuario.getUsuarios();

            cmbEliminarID.DisplayMember = "USU_ID";
            cmbEliminarID.ValueMember = "USU_ID";
            cmbEliminarID.DataSource = dt;

            cmbModificarID.DisplayMember = "USU_ID";
            cmbModificarID.ValueMember = "USU_ID";
            cmbModificarID.DataSource = dt;
        }


        private void CargarRoles()
        {
            DataTable dt = TrabajarUsuario.getRoles();
            cmbRol.DisplayMember = "ROL_Descripcion";
            cmbRol.ValueMember = "ROL_Codigo";
            cmbRol.DataSource = dt;

            cmbRolMod.DisplayMember = "ROL_Descripcion";
            cmbRolMod.ValueMember = "ROL_Codigo";
            cmbRolMod.DataSource = dt;
        }

        private void CargarUsuarios()
        {
            DataTable dt = TrabajarUsuario.getUsuarios();
        }

        private bool HayAlMenosUnAdministrador()
        {
            DataTable usuarios = TrabajarUsuario.getUsuarios();
            int count = usuarios.AsEnumerable().Count(row => row.Field<string>("ROL_Descripcion") == "Administrador");
            return count > 1;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Usuario oUsuario = new Usuario();
                oUsuario.USU_NombreUsuario = txtNombreUsuario.Text;
                oUsuario.USU_Contraseña = txtPassword.Text;
                oUsuario.USU_ApellidoNombre = txtApellidoNombre.Text;
                oUsuario.ROL_Codigo = cmbRol.SelectedValue.ToString();

                
            TrabajarUsuario.insertarUsuario(oUsuario);
            MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNombreUsuario.Clear();
            txtPassword.Clear();
            txtApellidoNombre.Clear();
            CargarIDUsuarios();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea guardar los cambios realizados?", "Confirmar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    Usuario oUsuario = new Usuario();

                    oUsuario.USU_ID = Convert.ToInt32(cmbModificarID.SelectedValue);

                    oUsuario.USU_NombreUsuario = txtNombreUsuarioMod.Text;
                    oUsuario.USU_Contraseña = txtPasswordMod.Text;
                    oUsuario.USU_ApellidoNombre = txtApellidoNombreMod.Text;
                    oUsuario.ROL_Codigo = cmbRolMod.SelectedItem.ToString();
                    

                    TrabajarUsuario.modificarUsuario(oUsuario);

                    MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreUsuario.Clear();
                    txtPassword.Clear();
                    txtApellidoNombre.Clear();
                    CargarIDUsuarios();
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       
        private void EliminarUsuario_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbEliminarID.SelectedValue);

            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar al usuario con ID: " + id + "?", "Confirmar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                TrabajarUsuario.eliminarUsuario(id);

                txtNombreUsuario.Clear();
                txtPassword.Clear();
                txtApellidoNombre.Clear();
                CargarIDUsuarios();
            }

        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {

          

            string apellidonombre = txtBuscarApellidoNombre.Text;
            txtBuscarApellidoNombre.Clear();
            dgvUsuarios.DataSource = TrabajarUsuario.buscarUsuariosPorNombreApellido(apellidonombre);

        }

        private void radioButtonUsername_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonApellido_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnListarUsuariosOrdenados_Click(object sender, EventArgs e)
        {
            string criterio = radioButtonUsername.Checked ? "username" : "apellido";
            DataTable dt = TrabajarUsuario.TraerUsuariosOrdenados(criterio);
            dgvUsuarios.DataSource = dt;
        }



    }
}