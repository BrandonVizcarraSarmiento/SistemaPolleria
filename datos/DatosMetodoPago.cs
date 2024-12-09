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
    public class DatosMetodoPago
    {
        public DataTable ObtenerTodosMetodosPago()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodosMetodosPago", ConnectionString.Singleton.SqlConnectionFactory))
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

        public int InsertarMetodoPago(EntidadMetodoPago metodoPago)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarMetodoPago", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", metodoPago.Nombre);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int EditarMetodoPago(EntidadMetodoPago metodoPago)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarMetodoPago", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MetodoPagoID", metodoPago.MetodoPagoID);
                    cmd.Parameters.AddWithValue("@Nombre", metodoPago.Nombre);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int EliminarMetodoPago(int metodoPagoID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarMetodoPago", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MetodoPagoID", metodoPagoID);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public DataTable ObtenerMetodoPagoPorNombre(string nombre)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerMetodoPagoPorNombre", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);

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
