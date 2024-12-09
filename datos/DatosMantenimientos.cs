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
    internal class DatosMantenimientos
    {
        // Método para obtener todos los mantenimientos
        public DataTable ObtenerTodosMantenimientos()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodosMantenimientos", ConnectionString.Singleton.SqlConnectionFactory))
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

        // Método para insertar un nuevo mantenimiento
        public int InsertarMantenimientos(EntidadMantenimientos mantenimiento)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarMantenimiento", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EquipoID", mantenimiento.EquipoID);
                    cmd.Parameters.AddWithValue("@FechaMantenimiento", mantenimiento.FechaMantenimiento);
                    cmd.Parameters.AddWithValue("@Descripcion", mantenimiento.Descripcion);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Método para editar un mantenimiento existente
        public int EditarMantenimientos(EntidadMantenimientos mantenimiento)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarMantenimiento", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MantenimientoID", mantenimiento.MantenimientoID);
                    cmd.Parameters.AddWithValue("@EquipoID", mantenimiento.EquipoID);
                    cmd.Parameters.AddWithValue("@FechaMantenimiento", mantenimiento.FechaMantenimiento);
                    cmd.Parameters.AddWithValue("@Descripcion", mantenimiento.Descripcion);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Método para eliminar un mantenimiento por su ID
        public int EliminarMantenimiento(int mantenimientoID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarMantenimiento", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MantenimientoID", mantenimientoID);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Método para obtener los mantenimientos por el equipo ID
        public DataTable ObtenerMantenimientosPorEquipoID(int equipoID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerMantenimientosPorEquipoID", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    DataTable dtData = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EquipoID", equipoID);

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