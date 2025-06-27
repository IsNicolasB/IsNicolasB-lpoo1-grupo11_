using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace ClasesBase.DataAccess
{
    public class TrabajarPago
    {

        public static void insertPago(Pago oPago)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("insertar_pago", cn);
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
            using (SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("registrar_pago_cuota", cn);
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
    }
}
