using System.Data.SqlClient;

namespace ClasesBase.Utils
{
    public static class Conexion
    {
        public static SqlConnection CrearConexion()
        {
            string cs = ClasesBase.Properties.Settings.Default.prestamosConnectionString;
            return new SqlConnection(cs);
        }
    }
}
