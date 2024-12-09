using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaPolleria.Common;
using SistemaPolleria.Common.Ingredientes;

namespace SistemaPolleria.Data.Ingredientes
{
    internal class DatosIngredientes
    {
        public DataTable ObtenerTodosIngredientes()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodosIngredientes", ConnectionString.Singleton.SqlConnectionFactory))
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

        public int InsertarIngrediente(EntidadIngrediente ingrediente)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarIngrediente", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", ingrediente.Nombre);
                    cmd.Parameters.AddWithValue("@UnidadMedida", ingrediente.UnidadMedida);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int EditarIngrediente(EntidadIngrediente ingrediente)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarIngrediente", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IngredienteID", ingrediente.IngredienteID);
                    cmd.Parameters.AddWithValue("@Nombre", ingrediente.Nombre);
                    cmd.Parameters.AddWithValue("@UnidadMedida", ingrediente.UnidadMedida);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int EliminarIngrediente(int ingredienteID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarIngrediente", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IngredienteID", ingredienteID);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public DataTable ObtenerIngredientePorNombre(string nombreIngrediente)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerIngredientePorNombre", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreIngrediente", nombreIngrediente);

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
