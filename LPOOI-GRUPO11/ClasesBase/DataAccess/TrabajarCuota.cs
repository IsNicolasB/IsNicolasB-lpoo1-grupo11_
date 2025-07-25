﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase.DataAccess
{
    public class TrabajarCuota
    {
        public static DataTable getCuotasPendientes(int pre_numero)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("sp_ObtenerCuotasPendientesPorPrestamo", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PRE_Numero", pre_numero);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void insertCuota(Cuota oCuota)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);

            SqlCommand cmd = new SqlCommand("sp_InsertarCuota", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PRE_Numero", oCuota.PRE_Numero);
            cmd.Parameters.AddWithValue("@CUO_Numero", oCuota.CUO_Numero);
            cmd.Parameters.AddWithValue("@CUO_Vencimiento", oCuota.CUO_Vencimiento);
            cmd.Parameters.AddWithValue("@CUO_Importe", oCuota.CUO_Importe);
            cmd.Parameters.AddWithValue("@CUO_Estado", oCuota.CUO_Estado);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static DataTable getCuotasPorClienteYPrestamo(int dni, int nroPrestamo)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_CuotasPorClienteYPrestamo", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@nroPrestamo", nroPrestamo);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}
