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
    internal class DatosHorario
    {
        public DataTable ObtenerTodosHorarios()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodosHorarios", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dtData = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dtData);
                    return dtData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public int InsertarHorario(EntidadHorario horario)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarHorario", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmpleadoID", horario.EmpleadoID);
                    cmd.Parameters.AddWithValue("@HoraInicio", horario.HoraInicio);
                    cmd.Parameters.AddWithValue("@HoraFin", horario.HoraFin);
                    cmd.Parameters.AddWithValue("@DiaSemana", horario.DiaSemana);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int EditarHorario(EntidadHorario horario)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarHorario", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@HorarioID", horario.HorarioID);
                    cmd.Parameters.AddWithValue("@EmpleadoID", horario.EmpleadoID);
                    cmd.Parameters.AddWithValue("@HoraInicio", horario.HoraInicio);
                    cmd.Parameters.AddWithValue("@HoraFin", horario.HoraFin);
                    cmd.Parameters.AddWithValue("@DiaSemana", horario.DiaSemana);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int EliminarHorario(int horarioID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarHorario", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@HorarioID", horarioID);
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
    }
}
