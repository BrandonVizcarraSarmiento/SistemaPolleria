using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaPolleria.Common;
using SistemaPolleria.Common.IngredientesPorPlato;

namespace SistemaPolleria.Data.IngredientesPorPlato
{
    internal class DatosIngredientesPorPlato
    {
        public DataTable ObtenerTodosIngredientesPorPlato()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodosIngredientesPorPlato", ConnectionString.Singleton.SqlConnectionFactory))
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

        public int InsertarIngredientePorPlato(EntidadIngredientesPorPlato ingredientePlato)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarIngredientePorPlato", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PlatoID", ingredientePlato.PlatoID);
                    cmd.Parameters.AddWithValue("@IngredienteID", ingredientePlato.IngredienteID);
                    cmd.Parameters.AddWithValue("@CantidadNecesaria", ingredientePlato.CantidadNecesaria);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int EditarIngredientePorPlato(EntidadIngredientesPorPlato ingredientePlato)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarIngredientePorPlato", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IngredientePlatoID", ingredientePlato.IngredientePlatoID);
                    cmd.Parameters.AddWithValue("@PlatoID", ingredientePlato.PlatoID);
                    cmd.Parameters.AddWithValue("@IngredienteID", ingredientePlato.IngredienteID);
                    cmd.Parameters.AddWithValue("@CantidadNecesaria", ingredientePlato.CantidadNecesaria);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int EliminarIngredientePorPlato(int ingredientePlatoID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarIngredientePorPlato", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IngredientePlatoID", ingredientePlatoID);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public DataTable ObtenerIngredientesPorPlato(int platoID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerIngredientesPorPlato", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PlatoID", platoID);

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
