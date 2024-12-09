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
    internal class DatosMesas
    {
        // Método para obtener todos los mesas
        public DataTable ObtenerTodosMesas()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodosMesas", ConnectionString.Singleton.SqlConnectionFactory))
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
        // Método para insertar un nuevo mesas
        public int InsertarMesas(EntidadMesas mesas)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarMesas", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NumeroMesa", mesas.NumeroMesa);
                    cmd.Parameters.AddWithValue("@Capacidad", mesas.Capacidad);
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        // Método para editar un empleado existente
        public int EditarMesas(EntidadMesas mesas)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarMesas", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MesaID", mesas.MesaID);
                    cmd.Parameters.AddWithValue("@NumeroMesa", mesas.NumeroMesa);
                    cmd.Parameters.AddWithValue("@Capacidad", mesas.Capacidad);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Método para eliminar un mesas por su ID
        public int EliminarMesas(int MesaID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarMesas", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MesaID", MesaID);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public DataTable ObtenerMesasPorNumeroMesa(int numeroMesa)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerMesasPorNumeroMesa", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    DataTable dtData = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Añadir el parámetro para el nombre del empleado
                    cmd.Parameters.AddWithValue("@NumeroMesa", numeroMesa);
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