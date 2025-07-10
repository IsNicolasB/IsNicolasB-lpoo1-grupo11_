using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase.DataAccess
{
    public class TrabajarPrestamo
    {
        public static DataTable getPrestamos()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Prestamo", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable getPrestamosPendientes(string dni)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("sp_ObtenerPrestamosPendientesPorDNI", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CLI_DNI", dni);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static int insertPrestamo(Prestamo oPrestamo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString))
                {
                    string query = @"
            INSERT INTO Prestamo 
            (CLI_DNI, DES_Codigo, PER_Codigo, PRE_Fecha, PRE_Importe, PRE_TasaInteres, PRE_CantidadCuotas, PRE_Estado)
            VALUES 
            (@cli_dni, @des_codigo, @per_codigo, @pre_fecha, @importe, @tasa, @cantidad_cuotas, @estado);
            SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@cli_dni", oPrestamo.CLI_DNI);
                        cmd.Parameters.AddWithValue("@des_codigo", oPrestamo.DES_Codigo);
                        cmd.Parameters.AddWithValue("@per_codigo", oPrestamo.PER_Codigo);
                        cmd.Parameters.AddWithValue("@pre_fecha", oPrestamo.PRE_Fecha);
                        cmd.Parameters.AddWithValue("@importe", oPrestamo.PRE_Importe);
                        cmd.Parameters.AddWithValue("@tasa", oPrestamo.PRE_TasaInteres);
                        cmd.Parameters.AddWithValue("@cantidad_cuotas", oPrestamo.PRE_CantidadCuotas);
                        cmd.Parameters.AddWithValue("@estado", oPrestamo.PRE_Estado);

                        cn.Open();
                        object result = cmd.ExecuteScalar();
                        return Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostralo por consola, mensaje, o log
                Console.WriteLine("Error al insertar préstamo: " + ex.Message);
                return -1; // o lanzar de nuevo la excepción
            }
        }

        public static bool esPrestamoCancelado(int prestamoId)
        {
            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_EsPrestamoCancelado", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PRE_Numero", prestamoId);
                SqlParameter outputParam = new SqlParameter("@EsCancelado", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParam);

                cn.Open();
                cmd.ExecuteNonQuery();
                return Convert.ToBoolean(outputParam.Value);
            }
        }

        public static DataTable ObtenerPrestamosPorDestino(int destinoId)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_PrestamosPorDestino", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DestinoId", destinoId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static List<Prestamo> GetPrestamosPorFecha(DateTime desde, DateTime hasta)
        {
            DataTable dt = getPrestamos(); // getPrestamos devuelve DataTable
            List<Prestamo> prestamos = new List<Prestamo>();

            foreach (DataRow row in dt.Rows)
            {
                Prestamo p = new Prestamo
                {
                    PRE_Numero = Convert.ToInt32(row["PRE_Numero"]),
                    CLI_DNI = row["CLI_DNI"].ToString(),
                    DES_Codigo = Convert.ToInt32(row["DES_Codigo"]),
                    PER_Codigo = Convert.ToInt32(row["PER_Codigo"]),
                    PRE_Fecha = Convert.ToDateTime(row["PRE_Fecha"]),
                    PRE_Importe = Convert.ToDecimal(row["PRE_Importe"]),
                    PRE_TasaInteres = Convert.ToDouble(row["PRE_TasaInteres"]),
                    PRE_CantidadCuotas = Convert.ToInt32(row["PRE_CantidadCuotas"]),
                    PRE_Estado = row["PRE_Estado"].ToString()
                };
                prestamos.Add(p);
            }

            return prestamos.Where(p => p.PRE_Fecha >= desde && p.PRE_Fecha <= hasta).ToList();
        }


        // Verifica si un préstamo tiene cuotas pagadas
        public static bool TieneCuotasPagadas(int numeroPrestamo)
        {
            string query = "SELECT COUNT(*) FROM Cuota WHERE pre_numero = @pre_numero AND cuo_estado = 'PAGADA'";
            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@pre_numero", numeroPrestamo);
                cn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // Anula el préstamo (cambia el estado)
        public static void AnularPrestamo(int numeroPrestamo)
        {
            string query = "UPDATE Prestamo SET pre_estado = 'ANULADO' WHERE pre_numero = @pre_numero";
            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@pre_numero", numeroPrestamo);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Verifica si el préstamo existe
        public static bool PrestamoExiste(int numeroPrestamo)
        {
            string query = "SELECT COUNT(*) FROM Prestamo WHERE pre_numero = @pre_numero";
            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@pre_numero", numeroPrestamo);
                cn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        
    }
}
