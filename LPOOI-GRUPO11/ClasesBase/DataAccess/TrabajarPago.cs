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
            DataTable dt = new DataTable();
            using (SqlConnection cn = Conexion.CrearConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ListarPagosFiltrados", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetro para el DNI del cliente
                    if (!string.IsNullOrEmpty(dniCliente))
                    {
                        cmd.Parameters.AddWithValue("@CLI_DNI", dniCliente);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@CLI_DNI", DBNull.Value);
                    }

                    // Parámetro para la fecha de inicio del rango
                    if (fechaDesde.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde.Value.Date); // Solo la fecha
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@FechaDesde", DBNull.Value);
                    }

                    // Parámetro para la fecha de fin del rango
                    if (fechaHasta.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta.Value.Date); // Solo la fecha
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@FechaHasta", DBNull.Value);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    try
                    {
                        cn.Open();
                        da.Fill(dt);
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error de SQL al listar pagos filtrados: " + ex.Message);
                        // Considera un mejor manejo de errores o logging
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error general al listar pagos filtrados: " + ex.Message);
                    }
                }
            }
            return dt;
        }
    }
}
