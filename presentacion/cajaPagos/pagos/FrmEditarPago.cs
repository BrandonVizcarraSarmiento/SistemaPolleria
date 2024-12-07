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

namespace SistemaPolleria.presentacion.cajaPagos.pagos
{
    public partial class FrmEditarPago : Form
    {
        private NegociosPagos _negociosPagos = new NegociosPagos();
        private int pagoID;
        private int pedidoID;
        public FrmEditarPago(int pagoID, int pedidoID, decimal monto, DateTime fecha, string metodoPago)
        {
            InitializeComponent();
            this.pagoID = pagoID;
            this.pedidoID = pedidoID;

            // Pre-cargar valores en los controles
            txtMonto.Text = monto.ToString("F2");
            dtpFecha.Value = fecha;
            txtMetodoPago.Text = metodoPago;
        }
        private void CargarPedidos()
        {
            try
            {
                // Simula obtener la lista de pedidos desde la base de datos
                DataTable pedidos = new NegociosPedidos().ObtenerTodosPedidosN();

                if (pedidos != null && pedidos.Rows.Count > 0)
                {
                    cboPedido.DisplayMember = "PedidoID"; // Mostrar el ID del pedido
                    cboPedido.ValueMember = "PedidoID"; // Valor almacenado
                    cboPedido.DataSource = pedidos;

                    // Seleccionar el valor correspondiente
                    cboPedido.SelectedValue = pedidoID; // Usar el campo privado
                }
                else
                {
                    MessageBox.Show("No se encontraron pedidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pedidos: " + ex.Message);
            }
        }
        private void FrmEditarPago_Load(object sender, EventArgs e)
        {
            CargarPedidos();
        }

        private void btnEditarPago_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar datos ingresados
                if (string.IsNullOrEmpty(txtMetodoPago.Text) || string.IsNullOrEmpty(txtMonto.Text))
                {
                    MessageBox.Show("Complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear entidad de pagos
                EntidadPagos pago = new EntidadPagos
                {
                    PagoID = this.pagoID,
                    PedidoID = Convert.ToInt32(cboPedido.SelectedValue),
                    Monto = Convert.ToDecimal(txtMonto.Text),
                    FechaPago = dtpFecha.Value,
                    MetodoPago = txtMetodoPago.Text
                };

                // Actualizar pago
                int resultado = _negociosPagos.EditarPagosN(pago);

                if (resultado > 0)
                {
                    MessageBox.Show("Pago actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
