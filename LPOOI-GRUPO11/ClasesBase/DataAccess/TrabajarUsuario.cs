using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase.DataAccess
{
    public class TrabajarUsuario
    {
        public static DataTable getUsuarios()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM usuario", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable getRoles()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM rol", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void insertarUsuario(Usuario user)
        {
            string query = "INSERT INTO Usuario (usu_nombreUsuario, usu_password, usu_apellidoNombre, rol_codigo) VALUES (@user, @pass, @nombre, @rol)";
            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@user", user.USU_NombreUsuario);
                cmd.Parameters.AddWithValue("@pass", user.USU_Contraseña);
                cmd.Parameters.AddWithValue("@nombre", user.USU_ApellidoNombre);
                cmd.Parameters.AddWithValue("@rol", user.ROL_Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static void modificarUsuario(Usuario user)
        {
            string query = "UPDATE Usuario SET usu_nombreUsuario = @user, usu_password = @pass, usu_apellidoNombre = @nombre, rol_codigo = @rol WHERE usu_id = @id";
            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", user.USU_ID);
                cmd.Parameters.AddWithValue("@user", user.USU_NombreUsuario);
                cmd.Parameters.AddWithValue("@pass", user.USU_Contraseña);
                cmd.Parameters.AddWithValue("@nombre", user.USU_ApellidoNombre);
                cmd.Parameters.AddWithValue("@rol", user.ROL_Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void eliminarUsuario(int id)
        {
            string query = "DELETE FROM Usuario WHERE usu_id = @id";
            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable buscarUsuariosPorNombreApellido(string filtro)
        {
            string query = "SELECT * FROM Usuario WHERE usu_apellidoNombre LIKE @filtro";
            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                da.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static Usuario Login(string username, string password)
        {
            string connectionString = ClasesBase.Properties.Settings.Default.prestamosConnectionString;

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM usuario WHERE usu_nombreUsuario = @username AND usu_password = @password";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    cn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Usuario user = new Usuario
                            {
                                USU_ID = reader.GetInt32(reader.GetOrdinal("usu_id")),  // ejemplo
                                USU_NombreUsuario = reader.GetString(reader.GetOrdinal("usu_nombreUsuario")),
                                USU_Contraseña = reader.GetString(reader.GetOrdinal("usu_password")),
                                USU_ApellidoNombre = reader.GetString(reader.GetOrdinal("usu_apellidoNombre")),
                                ROL_Codigo = reader.GetString(reader.GetOrdinal("rol_codigo")),
                               
                            };

                            return user;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

    }
}