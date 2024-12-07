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
    internal class DatosPagos
    {
        // Método para obtener todos los Pagos
        public DataTable ObtenerTodosPagos()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodosPagos", ConnectionString.Singleton.SqlConnectionFactory))
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
        // Método para insertar un nuevo Pagos
        public int InsertarPagos(EntidadPagos pagos)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarPagos", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PedidoID ", pagos.PedidoID);
                    cmd.Parameters.AddWithValue("@Monto ", pagos.Monto);
                    cmd.Parameters.AddWithValue("@FechaPago ", pagos.FechaPago);
                    cmd.Parameters.AddWithValue("@MetodoPago ", pagos.MetodoPago);
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
        public int EditarPagos(EntidadPagos pagos)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarPagos", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PagoID ", pagos.PagoID);
                    cmd.Parameters.AddWithValue("@PedidoID ", pagos.PedidoID);
                    cmd.Parameters.AddWithValue("@Monto ", pagos.Monto);
                    cmd.Parameters.AddWithValue("@FechaPago ", pagos.FechaPago);
                    cmd.Parameters.AddWithValue("@MetodoPago ", pagos.MetodoPago);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        // Método para eliminar un Pagos por su ID
        public int EliminarPagos(int pagoID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarPagos", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PagoID", pagoID);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public DataTable ObtenerPagosPorPedidoID(int pedidoID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerPagosPorPedidoID", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    DataTable dtData = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Añadir el parámetro para PedidoID
                    cmd.Parameters.AddWithValue("@PedidoID", pedidoID);
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