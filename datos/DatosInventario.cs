using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaPolleria.Common;
using SistemaPolleria.Common.Inventario;

namespace SistemaPolleria.Data.Inventario
{
    internal class DatosInventario
    {
        public DataTable ObtenerTodosInventarios()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodosInventarios", ConnectionString.Singleton.SqlConnectionFactory))
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

        public int InsertarIngredienteEnInventario(EntidadInventario inventario)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarIngredienteEnInventario", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IngredienteID", inventario.IngredienteID);
                    cmd.Parameters.AddWithValue("@NombreIngrediente", inventario.NombreIngrediente);
                    cmd.Parameters.AddWithValue("@CantidadActual", inventario.CantidadActual);
                    cmd.Parameters.AddWithValue("@UnidadMedida", inventario.UnidadMedida);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int EditarIngredienteEnInventario(EntidadInventario inventario)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarIngredienteEnInventario", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InventarioID", inventario.InventarioID);
                    cmd.Parameters.AddWithValue("@IngredienteID", inventario.IngredienteID);
                    cmd.Parameters.AddWithValue("@NombreIngrediente", inventario.NombreIngrediente);
                    cmd.Parameters.AddWithValue("@CantidadActual", inventario.CantidadActual);
                    cmd.Parameters.AddWithValue("@UnidadMedida", inventario.UnidadMedida);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int EliminarIngredienteEnInventario(int inventarioID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarIngredienteEnInventario", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InventarioID", inventarioID);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public DataTable ObtenerInventarioPorIngrediente(int ingredienteID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerInventarioPorIngrediente", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IngredienteID", ingredienteID);

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
