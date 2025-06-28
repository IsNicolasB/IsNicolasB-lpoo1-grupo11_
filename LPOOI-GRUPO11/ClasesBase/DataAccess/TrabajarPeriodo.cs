using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase.DataAccess
{
    public class TrabajarPeriodo
    {
        public static DataTable ListarPeriodos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Periodo", cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
