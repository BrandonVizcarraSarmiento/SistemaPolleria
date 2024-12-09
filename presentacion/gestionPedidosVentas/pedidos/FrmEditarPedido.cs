using SistemaPolleria.common;
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

namespace SistemaPolleria.presentacion.gestionPedidosVentas.pedidos
{
    public partial class FrmEditarPedido : Form
    {
        private NegociosPedidos _negocioPedidos = new NegociosPedidos();
        private NegocioMetodoPago _negocioMetodosPago = new NegocioMetodoPago();

        private int pedidoID;
        private int metodoPagoID;

        public FrmEditarPedido(int pedidoID, string cliente, int metodoPagoID, DateTime fechaPedido, decimal montoTotal)
        {
            InitializeComponent();
            this.pedidoID = pedidoID;
            this.metodoPagoID = metodoPagoID;

            // Inicializar los valores de los controles
            txtCliente.Text = cliente;
            dtpFechaPedido.Value = fechaPedido;
            txtMontoTotal.Text = montoTotal.ToString("F2");
        }
        private void CargarMetodosPago()
        {
            try
            {
                // Obtenemos los métodos de pago desde la capa de negocio
                DataTable metodosPago = _negocioMetodosPago.ObtenerTodosMetodosPagoN();

                if (metodosPago != null && metodosPago.Rows.Count > 0)
                {
                    cboMetodoPago.DisplayMember = "Nombre"; // Nombre a mostrar en el ComboBox
                    cboMetodoPago.ValueMember = "MetodoPagoID"; // Valor asociado (ID)
                    cboMetodoPago.DataSource = metodosPago;

                    // Seleccionar el método de pago actual
                    cboMetodoPago.SelectedValue = metodoPagoID;
                }
                else
                {
                    MessageBox.Show("No se encontraron métodos de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar métodos de pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmEditarPedido_Load(object sender, EventArgs e)
        {
            CargarMetodosPago();
        }

        private void btnEditarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos los datos del formulario
                string cliente = txtCliente.Text; // Cliente (nombre o identificador)
                int metodoPago = Convert.ToInt32(cboMetodoPago.SelectedValue); // Método de pago
                DateTime fechaPedido = dtpFechaPedido.Value; // Fecha del pedido
                decimal montoTotal = Convert.ToDecimal(txtMontoTotal.Text); // Monto total del pedido

                // Creamos la instancia de la entidad Pedido con los datos del formulario
                EntidadPedidos pedido = new EntidadPedidos
                {
                    PedidoID = pedidoID,
                    Cliente = cliente,
                    MetodoPagoID = metodoPago,
                    FechaPedido = fechaPedido,
                    MontoTotal = montoTotal
                };

                // Llamamos al método de negocio para actualizar el pedido
                int resultado = _negocioPedidos.EditarPedidosN(pedido);

                if (resultado > 0)
                {
                    MessageBox.Show("Pedido actualizado correctamente.");
                    this.Close(); // Cerramos el formulario
                }
                else
                {
                    MessageBox.Show("Error al actualizar el pedido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el pedido: " + ex.Message);
            }
        }
    }
}
