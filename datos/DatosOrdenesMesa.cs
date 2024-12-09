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
    internal class DatosOrdenesMesa
    {
        // Método para obtener todos los mesas
        public DataTable ObtenerTodosOrdenesMesa()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodosOrdenesMesa", ConnectionString.Singleton.SqlConnectionFactory))
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
        // Método para insertar nuevos OrdenesMesa
        public int InsertarOrdenesMesa(EntidadOrdenesMesa ordenesMesa)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarOrdenesMesa", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MesaID", ordenesMesa.MesaID);
                    cmd.Parameters.AddWithValue("@PedidoID", ordenesMesa.PedidoID);
                    cmd.Parameters.AddWithValue("@FechaOrden", ordenesMesa.FechaOrden);
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        // Método para editar un OrdenesMesa existente
        public int EditarOrdenesMesa(EntidadOrdenesMesa ordenesMesa)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarOrdenesMesa", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@OrdenID", ordenesMesa.OrdenID);
                    cmd.Parameters.AddWithValue("@MesaID", ordenesMesa.MesaID);
                    cmd.Parameters.AddWithValue("@PedidoID", ordenesMesa.PedidoID);
                    cmd.Parameters.AddWithValue("@FechaOrden", ordenesMesa.FechaOrden);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Método para eliminar OrdenesMesa por su ID
        public int EliminarOrdenesMesa(int OrdenID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarOrdenesMesa", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@OrdenID", OrdenID);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public DataTable ObtenerOrdenesMesaPorFechaOrden(DateTime fechaOrden)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerOrdenesMesaPorFechaOrden", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    DataTable dtData = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Añadir el parámetro para el nombre del empleado
                    cmd.Parameters.AddWithValue("@FechaOrden", fechaOrden);
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