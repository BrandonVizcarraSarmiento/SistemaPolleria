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
    internal class DatosReservas
    {
        // Método para obtener todos los Reservas
        public DataTable ObtenerTodosReservas()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodosReservas", ConnectionString.Singleton.SqlConnectionFactory))
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
        // Método para insertar un nuevo Reservas
        public int InsertarReservas(EntidadReservas reservas)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarReservas", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MesaID", reservas.MesaID);
                    cmd.Parameters.AddWithValue("@ClienteID", reservas.ClienteID);
                    cmd.Parameters.AddWithValue("@FechaReserva", reservas.FechaReserva);
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        // Método para editar una Reservas existente
        public int EditarReservas(EntidadReservas reservas)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarReservas", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ReservaID", reservas.ReservaID);
                    cmd.Parameters.AddWithValue("@MesaID", reservas.MesaID);
                    cmd.Parameters.AddWithValue("@ClienteID", reservas.ClienteID);
                    cmd.Parameters.AddWithValue("@FechaReserva", reservas.FechaReserva);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Método para eliminar un Reservas por su ID
        public int EliminarReservas(int ReservaID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarReservas", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ReservaID", ReservaID);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public DataTable ObtenerReservasPorClienteID(int ClienteID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerReservasPorClienteID", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    DataTable dtData = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Añadir el parámetro para el nombre del empleado
                    cmd.Parameters.AddWithValue("@ClienteID", ClienteID);
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
