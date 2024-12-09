using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaPolleria.Common;
using SistemaPolleria.Common.Platos;

namespace SistemaPolleria.Data.Platos
{
    internal class DatosPlatos
    {
        public DataTable ObtenerTodosPlatos()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodosPlatos", ConnectionString.Singleton.SqlConnectionFactory))
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

        public int InsertarPlato(EntidadPlato plato)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarPlato", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", plato.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", plato.Descripcion);
                    cmd.Parameters.AddWithValue("@Precio", plato.Precio);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int EditarPlato(EntidadPlato plato)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarPlato", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PlatoID", plato.PlatoID);
                    cmd.Parameters.AddWithValue("@Nombre", plato.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", plato.Descripcion);
                    cmd.Parameters.AddWithValue("@Precio", plato.Precio);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int EliminarPlato(int platoID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarPlato", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PlatoID", platoID);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public DataTable ObtenerPlatoPorNombre(string nombrePlato)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerPlatoPorNombre", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombrePlato", nombrePlato);

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
