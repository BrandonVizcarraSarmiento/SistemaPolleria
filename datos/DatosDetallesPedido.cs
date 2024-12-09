using SistemaPolleria.common;
using SistemaPolleria.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPolleria.datos
{
    internal class DatosDetallesPedido
    {
        // Método para obtener todos los DetallesPedido
        public DataTable ObtenerTodosDetallesPedido()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodosDetallesPedido", ConnectionString.Singleton.SqlConnectionFactory))
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
        // Método para insertar un nuevo DetallesPedido
        public int InsertarDetallesPedido(EntidadDetallesPedido detallesPedido)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarDetallesPedido", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PedidoID ", detallesPedido.PedidoID);
                    cmd.Parameters.AddWithValue("@PlatoID ", detallesPedido.PlatoID);
                    cmd.Parameters.AddWithValue("@Cantidad ", detallesPedido.Cantidad);
                    cmd.Parameters.AddWithValue("@PrecioUnitario  ", detallesPedido.PrecioUnitario);
                    cmd.Parameters.AddWithValue("@Subtotal  ", detallesPedido.Subtotal);
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Método para editar un DetallesPedido existente
        public int EditarDetallesPedido(EntidadDetallesPedido detallesPedido)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarDetallesPedido", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DetallePedidoID ", detallesPedido.DetallePedidoID);
                    cmd.Parameters.AddWithValue("@PedidoID ", detallesPedido.PedidoID);
                    cmd.Parameters.AddWithValue("@PlatoID ", detallesPedido.PlatoID);
                    cmd.Parameters.AddWithValue("@Cantidad ", detallesPedido.Cantidad);
                    cmd.Parameters.AddWithValue("@PrecioUnitario  ", detallesPedido.PrecioUnitario);
                    cmd.Parameters.AddWithValue("@Subtotal  ", detallesPedido.Subtotal);
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
        public int EliminarDetallesPedido(int detallePedidoID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarDetallesPedido", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DetallePedidoID", detallePedidoID);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public DataTable ObtenerDetallesPedidoPorPedidoID(int pedidoID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerDetallesPedidoPorPedidoID", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    DataTable dtData = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Añadir el parámetro para el nombre del empleado
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