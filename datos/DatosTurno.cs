using SistemaPolleria.common;
using SistemaPolleria.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.datos
{
    public class DatosTurno
    {
        // Obtener todos los turnos
        public DataTable ObtenerTodosLosTurnos()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodosTurnos", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    DataTable dtData = new DataTable();
                    SqlDataAdapter sqlSda = new SqlDataAdapter(cmd);
                    sqlSda.Fill(dtData);

                    return dtData;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener turnos: " + ex.Message);
            }
        }

        // Insertar un turno
        public int InsertarTurno(EntidadTurno turno)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarTurno", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreTurno", turno.NombreTurno);
                    cmd.Parameters.AddWithValue("@HoraInicio", turno.HoraInicio);
                    cmd.Parameters.AddWithValue("@HoraFin", turno.HoraFin);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar turno: " + ex.Message);
            }
        }

        // Editar un turno
        public int EditarTurno(EntidadTurno turno)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarTurno", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TurnoID", turno.TurnoID);
                    cmd.Parameters.AddWithValue("@NombreTurno", turno.NombreTurno);
                    cmd.Parameters.AddWithValue("@HoraInicio", turno.HoraInicio);
                    cmd.Parameters.AddWithValue("@HoraFin", turno.HoraFin);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar turno: " + ex.Message);
            }
        }

        // Eliminar un turno
        public int EliminarTurno(int turnoID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarTurno", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TurnoID", turnoID);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar turno: " + ex.Message);
            }
        }
        // Obtener turnos por nombre (filtro)
        public DataTable ObtenerTurnoPorNombre(string nombreTurno)
        {
            try
            {
                // Creamos el comando para llamar al Stored Procedure
                using (SqlCommand cmd = new SqlCommand("obtenerTurnoPorNombre", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Añadimos el parámetro al Stored Procedure
                    cmd.Parameters.AddWithValue("@NombreTurno", nombreTurno);

                    // Ejecutamos el comando y obtenemos los resultados
                    DataTable dtData = new DataTable();
                    SqlDataAdapter sqlSda = new SqlDataAdapter(cmd);
                    sqlSda.Fill(dtData);

                    return dtData;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener turno por nombre: " + ex.Message);
            }
        }
    }
}
