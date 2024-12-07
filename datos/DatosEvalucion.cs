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
    public class DatosEvalucion
    {
        // Obtener todas las evaluaciones
        public DataTable ObtenerTodasEvaluaciones()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodasEvaluaciones", ConnectionString.Singleton.SqlConnectionFactory))
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

        // Insertar una nueva evaluación
        public int InsertarEvaluacion(EntidadEvaluacion evaluacion)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarEvaluacion", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmpleadoID", evaluacion.EmpleadoID);
                    cmd.Parameters.AddWithValue("@Fecha", evaluacion.Fecha);
                    cmd.Parameters.AddWithValue("@Calificacion", evaluacion.Calificacion);
                    cmd.Parameters.AddWithValue("@Comentario", evaluacion.Comentario);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Editar una evaluación existente
        public int EditarEvaluacion(EntidadEvaluacion evaluacion)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarEvaluacion", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EvaluacionID", evaluacion.EvaluacionID);
                    cmd.Parameters.AddWithValue("@EmpleadoID", evaluacion.EmpleadoID);
                    cmd.Parameters.AddWithValue("@Fecha", evaluacion.Fecha);
                    cmd.Parameters.AddWithValue("@Calificacion", evaluacion.Calificacion);
                    cmd.Parameters.AddWithValue("@Comentario", evaluacion.Comentario);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Eliminar una evaluación
        public int EliminarEvaluacion(int evaluacionID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarEvaluacion", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EvaluacionID", evaluacionID);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Obtener evaluaciones por nombre del empleado
        public DataTable ObtenerEvaluacionesPorNombre(string nombreEmpleado)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerEvaluacionesPorNombre", ConnectionString.Singleton.SqlConnectionFactory))
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
