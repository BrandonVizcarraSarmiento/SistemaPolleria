using SistemaPolleria.Negocios.Platos;
using SistemaPolleria.negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPolleria.common;

namespace SistemaPolleria.presentacion.gestionPedidosVentas.detallePedido
{
    public partial class FrmEditarDetallePedido : Form
    {
        private NegociosDetallesPedido _negociosDetallesPedido = new NegociosDetallesPedido();
        private NegocioPlatos _negocioPlatos = new NegocioPlatos();
        private NegociosPedidos _negocioPedidos = new NegociosPedidos();

        private int detallePedidoID;
        private int pedidoID;
        private int platoID;

        public FrmEditarDetallePedido(int detallePedidoID, int pedidoID, int platoID, int cantidad, decimal precio, decimal subtotal)
        {
            InitializeComponent();
            this.detallePedidoID = detallePedidoID;
            this.pedidoID = pedidoID;
            this.platoID = platoID;

            // Inicializar los controles con los datos existentes
            cboIdPedido.SelectedValue = pedidoID;
            cboPlato.SelectedValue = platoID;
            txtCantidad.Text = cantidad.ToString();
            txtPrecioUnitario.Text = precio.ToString("0.00");
            txtSubTotal.Text = subtotal.ToString("0.00");

        }
        // Cargar los pedidos en el ComboBox
        private void CargarPedidos()
        {
            try
            {
                // Obtener todos los pedidos
                DataTable pedidos = _negocioPedidos.ObtenerTodosPedidosN();

                if (pedidos != null && pedidos.Rows.Count > 0)
                {
                    cboIdPedido.DisplayMember = "PedidoID";  // Nombre del pedido
                    cboIdPedido.ValueMember = "PedidoID"; // ID del pedido
                    cboIdPedido.DataSource = pedidos;
                    cboIdPedido.SelectedValue = pedidoID;
                }
                else
                {
                    MessageBox.Show("No se encontraron pedidos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pedidos: " + ex.Message);
            }
        }
        // Cargar los platos en el ComboBox
        private void CargarPlatos()
        {
            try
            {
                // Obtener todos los platos
                DataTable platos = _negocioPlatos.ObtenerTodosPlatosN();

                if (platos != null && platos.Rows.Count > 0)
                {
                    cboPlato.DisplayMember = "Nombre";  // Nombre del plato
                    cboPlato.ValueMember = "PlatoID";  // ID del plato
                    cboPlato.DataSource = platos;
                    cboPlato.SelectedValue = platoID;
                }
                else
                {
                    MessageBox.Show("No se encontraron platos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los platos: " + ex.Message);
            }
        }

        private void FrmEditarDetallePedido_Load(object sender, EventArgs e)
        {
            CargarPedidos();
            CargarPlatos();
        }
        private void btnEditarDetallePedido_Click(object sender, EventArgs e)
        {
            try
            {
                int pedidoID = Convert.ToInt32(cboIdPedido.SelectedValue);
                int platoID = Convert.ToInt32(cboPlato.SelectedValue);
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                decimal precioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);
                decimal subtotal = Convert.ToDecimal(txtSubTotal.Text);

                // Crear el objeto para actualizar el detalle del pedido
                EntidadDetallesPedido detallePedido = new EntidadDetallesPedido
                {
                    DetallePedidoID = detallePedidoID,
                    PedidoID = pedidoID,
                    PlatoID = platoID,
                    Cantidad = cantidad,
                    PrecioUnitario = precioUnitario,
                    Subtotal = subtotal
                };

                // Llamamos al método para editar el detalle del pedido
                int resultado = _negociosDetallesPedido.EditarDetallesPedidoN(detallePedido);

                if (resultado > 0)
                {
                    MessageBox.Show("Detalle de pedido actualizado correctamente.");
                    this.Close(); // Cerrar el formulario después de la edición
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar el detalle de pedido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el detalle de pedido: " + ex.Message);
            }
        }
    }
}
