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
    internal class DatosEquipos
    {
        // Método para obtener todos los equipos
        public DataTable ObtenerTodosEquipos()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodosEquipos", ConnectionString.Singleton.SqlConnectionFactory))
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

        // Método para insertar un nuevo equipo
        public int InsertarEquipos(EntidadEquipos equipo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarEquipos", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", equipo.Nombre);
                    cmd.Parameters.AddWithValue("@FechaCompra", equipo.FechaCompra);
                    cmd.Parameters.AddWithValue("@FechaMantenimiento", equipo.FechaMantenimiento);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Método para editar un equipo existente
        public int EditarEquipos(EntidadEquipos equipo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarEquipos", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EquipoID", equipo.EquipoID);
                    cmd.Parameters.AddWithValue("@Nombre", equipo.Nombre);
                    cmd.Parameters.AddWithValue("@FechaCompra", equipo.FechaCompra);
                    cmd.Parameters.AddWithValue("@FechaMantenimiento", equipo.FechaMantenimiento);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Método para eliminar un equipo por su ID
        public int EliminarEquipos(int equipoID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarEquipos", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EquipoID", equipoID);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Método para obtener un equipo por su nombre
        public DataTable ObtenerEquiposPorNombre(string nombre)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerEquiposPorNombre", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    DataTable dtData = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);

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
