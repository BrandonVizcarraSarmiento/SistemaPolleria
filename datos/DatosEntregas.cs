using System;
using SistemaPolleria.common;
using SistemaPolleria.Common;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPolleria.datos
{
    internal class DatosEntregas
    {
        // Método para obtener todos los Entregas
        public DataTable ObtenerTodosEntregas()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodosEntregas", ConnectionString.Singleton.SqlConnectionFactory))
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
        // Método para insertar un nuevas Entregas
        public int InsertarEntregas(EntidadEntregas entregas)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarEntregas", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PedidoID", entregas.PedidoID);
                    cmd.Parameters.AddWithValue("@FechaEntrega", entregas.FechaEntrega);
                    cmd.Parameters.AddWithValue("@DireccionEntrega", entregas.DireccionEntrega);
                    cmd.Parameters.AddWithValue("@EstadoEntrega", entregas.EstadoEntrega);
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Método para editar un empleado existente
        public int EditarEntregas(EntidadEntregas entregas)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarEntregas", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EntregaID ", entregas.EntregaID);
                    cmd.Parameters.AddWithValue("@PedidoID", entregas.PedidoID);
                    cmd.Parameters.AddWithValue("@FechaEntrega", entregas.FechaEntrega);
                    cmd.Parameters.AddWithValue("@DireccionEntrega", entregas.DireccionEntrega);
                    cmd.Parameters.AddWithValue("@EstadoEntrega", entregas.EstadoEntrega);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Método para eliminar un Entregas por su ID
        public int EliminarEntregas(int EntregaID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarEntregas", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EntregaID", EntregaID);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public DataTable ObtenerEntregasPorfecha(DateTime fechaEntrega)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerEntregasPorfecha", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    DataTable dtData = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Añadir el parámetro para el nombre del empleado
                    cmd.Parameters.AddWithValue("@FechaEntrega", fechaEntrega);

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
    }
}