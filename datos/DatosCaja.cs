using SistemaPolleria.common;
using SistemaPolleria.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPolleria.datos
{
    public class DatosCaja
    {
        // Obtener todas las cajas
        public DataTable ObtenerTodasCajas()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodasCajas", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    DataTable dtData = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter sqlSda = new SqlDataAdapter(cmd);
                    sqlSda.Fill(dtData);

                    return dtData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // Insertar una nueva caja
        public int InsertarCaja(EntidadCaja caja)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarCaja", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Fecha", caja.Fecha);
                    cmd.Parameters.AddWithValue("@Total", caja.Total);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Editar una caja existente
        public int EditarCaja(EntidadCaja caja)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarCaja", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CajaID", caja.CajaID);
                    cmd.Parameters.AddWithValue("@Fecha", caja.Fecha);
                    cmd.Parameters.AddWithValue("@Total", caja.Total);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Eliminar una caja
        public int EliminarCaja(int cajaID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarCaja", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CajaID", cajaID);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Obtener cajas por fecha
        public DataTable ObtenerCajasPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerCajasPorFecha", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin);

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
