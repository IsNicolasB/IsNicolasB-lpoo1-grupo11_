using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ClasesBase.Utils;
namespace ClasesBase.DataAccess

{
    public class TrabajarPago
    {

        public static void insertPago(Pago oPago)
        {
            try
            {
                using (SqlConnection cn = Conexion.CrearConexion())
                {
                    SqlCommand cmd = new SqlCommand("sp_InsertarPago", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CUO_Codigo", oPago.CUO_Codigo);
                    cmd.Parameters.AddWithValue("@PAG_Fecha", oPago.PAG_Fecha);
                    cmd.Parameters.AddWithValue("@PAG_Importe", oPago.PAG_Importe);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Mostralo por consola, mensaje, o log
                Console.WriteLine("Error al insertar el pago: " + ex.Message);
            }
        }

        public static string insertPagoCuota(int cuotaId, int prestamoId, DateTime fechaPago, decimal importe)
        {
            using (SqlConnection cn = Conexion.CrearConexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarPagoCuota", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CUO_Codigo", cuotaId);
                    cmd.Parameters.AddWithValue("@PRE_Numero", prestamoId);
                    cmd.Parameters.AddWithValue("@PAG_Fecha", fechaPago);
                    cmd.Parameters.AddWithValue("@PAG_Importe", importe);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    string message = "Pago registrado correctamente.\n" +
                      "\n***DATOS DEL PAGO***" +
                     "\n- ID Cuota: " + cuotaId +
                     "\n- ID Préstamo: "+ prestamoId +
                     "\n- Fecha de Pago: " + fechaPago.ToShortDateString() +
                     "\n- Importe: " + importe;

                    return message;
                }
                catch (Exception ex)
                {
                    return "Error al registrar el pago: " + ex.Message;
                }
            }
        }
        public static DataTable ObtenerPagosPorCliente(string clienteDNI)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = Conexion.CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_PagosPorCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CLI_DNI", clienteDNI);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
                return dt;     
        }

        public static DataTable ObtenerPagosFiltrados(string dniCliente, DateTime? fechaDesde, DateTime? fechaHasta)
        {
            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ListarPagosFiltrados", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Manejo de parámetros: si son nulos, se pasa DBNull
                cmd.Parameters.AddWithValue("@CLI_DNI", string.IsNullOrEmpty(dniCliente) ? (object)DBNull.Value : dniCliente);
                cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde.HasValue ? (object)fechaDesde.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta.HasValue ? (object)fechaHasta.Value : DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

    }
}
