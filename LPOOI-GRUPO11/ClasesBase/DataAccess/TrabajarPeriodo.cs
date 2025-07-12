using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ClasesBase.Utils;

namespace ClasesBase.DataAccess
{
    public class TrabajarPeriodo
    {
        public static DataTable ListarPeriodos()
        {
            SqlConnection cn = Conexion.CrearConexion();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Periodo", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void AgregarPeriodo(Periodo p)
        {
            using (SqlConnection cn = Conexion.CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Periodo (PER_Descripcion) VALUES (@desc)", cn);
                cmd.Parameters.AddWithValue("@desc", p.PER_Descripcion);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void ModificarPeriodo(Periodo p)
        {
            using (SqlConnection cn = Conexion.CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Periodo SET PER_Descripcion = @desc WHERE PER_Codigo = @cod", cn);
                cmd.Parameters.AddWithValue("@desc", p.PER_Descripcion);
                cmd.Parameters.AddWithValue("@cod", p.PER_Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void EliminarPeriodo(int cod)
        {
            using (SqlConnection cn = Conexion.CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Periodo WHERE PER_Codigo = @cod", cn);
                cmd.Parameters.AddWithValue("@cod", cod);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

