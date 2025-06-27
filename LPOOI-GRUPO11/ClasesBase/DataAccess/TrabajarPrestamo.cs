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
            SqlCommand cmd = new SqlCommand("obtener_prestamos_pendientes_por_DNI", cn);
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
                SqlCommand cmd = new SqlCommand("es_prestamo_cancelado", cn);
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


        
    }
}
