using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace ClasesBase.DataAccess
{
    public class TrabajarCliente
    {
        public static DataTable getClientes(){
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("sp_ObtenerClientes", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void insertCliente(Cliente oCliente)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);

            string query = @"INSERT INTO Cliente (CLI_DNI, CLI_Nombre, CLI_Apellido, CLI_Sexo, CLI_FechaNacimiento, CLI_Ingresos, CLI_Direccion, CLI_Telefono) 
                     VALUES (@dni, @nombre, @apellido, @sexo, @fechaNac, @ingresos, @direccion, @telefono)";

            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@dni", oCliente.CLI_DNI);
            cmd.Parameters.AddWithValue("@nombre", oCliente.CLI_Nombre);
            cmd.Parameters.AddWithValue("@apellido", oCliente.CLI_Apellido);
            cmd.Parameters.AddWithValue("@sexo", oCliente.CLI_Sexo);
            cmd.Parameters.AddWithValue("@fechaNac", oCliente.CLI_FechaNacimiento);
            cmd.Parameters.AddWithValue("@ingresos", oCliente.CLI_Ingresos);
            cmd.Parameters.AddWithValue("@direccion", oCliente.CLI_Direccion);
            cmd.Parameters.AddWithValue("@telefono", oCliente.CLI_Telefono);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void updateCliente(Cliente oCliente)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("UPDATE Cliente SET CLI_Nombre = @nombre, CLI_Apellido = @apellido, CLI_Sexo = @sexo, CLI_FechaNacimiento = @fecha, CLI_Ingresos = @ingresos, CLI_Direccion = @direccion, CLI_Telefono = @telefono WHERE CLI_DNI = @dni", cn);

            cmd.Parameters.AddWithValue("@nombre", oCliente.CLI_Nombre);
            cmd.Parameters.AddWithValue("@apellido", oCliente.CLI_Apellido);
            cmd.Parameters.AddWithValue("@sexo", oCliente.CLI_Sexo);
            cmd.Parameters.AddWithValue("@fecha", oCliente.CLI_FechaNacimiento);
            cmd.Parameters.AddWithValue("@ingresos", oCliente.CLI_Ingresos);
            cmd.Parameters.AddWithValue("@direccion", oCliente.CLI_Direccion);
            cmd.Parameters.AddWithValue("@telefono", oCliente.CLI_Telefono);
            cmd.Parameters.AddWithValue("@dni", oCliente.CLI_DNI);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }


        public static void deleteCliente(string dni)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("DELETE FROM Cliente WHERE CLI_DNI = @dni", cn);
            cmd.Parameters.AddWithValue("@dni", dni);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static DataTable buscarClientes(string nombre, string apellido)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente WHERE CLI_Nombre LIKE @nombre AND CLI_Apellido LIKE @apellido", cn);
            cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
            cmd.Parameters.AddWithValue("@apellido", "%" + apellido + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable getClientesDNI()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT CLI_DNI FROM Cliente", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static Cliente buscarClientePorDNI(string dni)
        {
            Cliente cli = null;

            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString))
            {
                string query = "SELECT * FROM Cliente WHERE CLI_DNI = @dni";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@dni", dni);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    cli = new Cliente
                    {
                        CLI_DNI = dr["CLI_DNI"].ToString(),
                        CLI_Nombre = dr["CLI_Nombre"].ToString(),
                        CLI_Apellido = dr["CLI_Apellido"].ToString(),
                        CLI_Sexo = dr["CLI_Sexo"].ToString(),
                        CLI_FechaNacimiento = Convert.ToDateTime(dr["CLI_FechaNacimiento"]),
                        CLI_Ingresos = Convert.ToDecimal(dr["CLI_Ingresos"]),
                        CLI_Direccion = dr["CLI_Direccion"].ToString(),
                        CLI_Telefono = dr["CLI_Telefono"].ToString()
                    };
                }

                dr.Close();
            }

            return cli;
        }

        public static DataTable getClientesOrdenadosPorApellido()
        {
            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ClientesOrdenadosPorApellido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }




        
    }
}
