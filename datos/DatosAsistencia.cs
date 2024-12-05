using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaPolleria.Common;
using SistemaPolleria.Common.Asistencia;

namespace SistemaPolleria.Data.Asistencia
{
    internal class DatosAsistencia
    {
        public DataTable ObtenerTodasAsistencias()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodasAsistencias", ConnectionString.Singleton.SqlConnectionFactory))
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
        public int InsertarAsistencia(EntidadAsistencia asistencia)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarAsistencia", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmpleadoID", asistencia.EmpleadoID);
                    cmd.Parameters.AddWithValue("@Fecha", asistencia.Fecha);
                    cmd.Parameters.AddWithValue("@HoraEntrada", asistencia.HoraEntrada);
                    cmd.Parameters.AddWithValue("@HoraSalida", asistencia.HoraSalida);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int EditarAsistencia(EntidadAsistencia asistencia)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarAsistencia", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AsistenciaID", asistencia.AsistenciaID);
                    cmd.Parameters.AddWithValue("@EmpleadoID", asistencia.EmpleadoID);
                    cmd.Parameters.AddWithValue("@Fecha", asistencia.Fecha);
                    cmd.Parameters.AddWithValue("@HoraEntrada", asistencia.HoraEntrada);
                    cmd.Parameters.AddWithValue("@HoraSalida", asistencia.HoraSalida);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int EliminarAsistencia(int asistenciaID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarAsistencia", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AsistenciaID", asistenciaID);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public DataTable ObtenerAsistenciaPorNombre(string nombreEmpleado)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerAsistenciaPorNombre", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreEmpleado", nombreEmpleado);

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
