using System.Data;
using System.Data.SqlClient;
using System; 
namespace ClasesBase
{
    public class TrabajarDestino
    {
        // LISTAR destinos usando stored procedure
        public static DataTable ListarDestinos()
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ListarDestinos", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // INSERTAR destino usando stored procedure
        public static void InsertarDestino(Destino dest)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_InsertarDestino", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Descripcion", dest.DES_Descripcion);

                    cnn.Open(); // Acá es donde ocurre usualmente el problema
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Muestra el error en tiempo de ejecución
                    throw new Exception("Error al insertar destino: " + ex.Message);
                }
                finally
                {
                    if (cnn.State == ConnectionState.Open)
                        cnn.Close();
                }
            }
        }


        // MODIFICAR destino usando stored procedure
        public static void ModificarDestino(Destino dest)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ModificarDestino", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Codigo", dest.DES_Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", dest.DES_Descripcion);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        // ELIMINAR destino usando stored procedure
        public static void EliminarDestino(int codigo)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarDestino", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Codigo", codigo);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
    }
}
