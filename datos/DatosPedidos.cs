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
    internal class DatosPedidos
    {
        // Método para obtener todos los pedidos
        public DataTable ObtenerTodosPedidos()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodosPedidos", ConnectionString.Singleton.SqlConnectionFactory))
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
        // Método para insertar un nuevo pedidos
        public int InsertarPedidos(EntidadPedidos pedidos)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarPedidos", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Cliente", pedidos.Cliente);
                    cmd.Parameters.AddWithValue("@MetodoPagoID", pedidos.MetodoPagoID);
                    cmd.Parameters.AddWithValue("@FechaPedido", pedidos.FechaPedido);
                    cmd.Parameters.AddWithValue("@MontoTotal", pedidos.MontoTotal);
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
        public int EditarPedidos(EntidadPedidos pedidos)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarPedidos", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PedidoID", pedidos.PedidoID);
                    cmd.Parameters.AddWithValue("@Cliente", pedidos.Cliente);
                    cmd.Parameters.AddWithValue("@MetodoPagoID", pedidos.MetodoPagoID);
                    cmd.Parameters.AddWithValue("@FechaPedido", pedidos.FechaPedido);
                    cmd.Parameters.AddWithValue("@MontoTotal", pedidos.MontoTotal);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Método para eliminar un empleado por su ID
        public int EliminarPedidos(int pedidoID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarPedidos", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PedidoID", pedidoID);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public DataTable ObtenerPedidosPorCliente(string cliente)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerPedidosPorCliente", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    DataTable dtData = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Añadir el parámetro para el nombre del empleado
                    cmd.Parameters.AddWithValue("@Cliente", cliente);

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