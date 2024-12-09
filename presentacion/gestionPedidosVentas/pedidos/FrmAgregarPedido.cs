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
    public partial class FrmAgregarPedido : Form
    {
        private NegociosPedidos _negocioPedidos = new NegociosPedidos();
        private NegocioMetodoPago _negocioMetodosPago = new NegocioMetodoPago();
        public FrmAgregarPedido()
        {
            InitializeComponent();
        }
        private void CargarMetodosPago()
        {
            try
            {
                // Obtenemos los métodos de pago desde la capa de negocio
                DataTable metodosPago = _negocioMetodosPago.ObtenerTodosMetodosPagoN();

                if (metodosPago != null && metodosPago.Rows.Count > 0)
                {
                    cboMetodoPago.DisplayMember = "Nombre"; // Cambiar por el nombre de la columna
                    cboMetodoPago.ValueMember = "MetodoPagoID"; // Cambiar por el nombre del ID
                    cboMetodoPago.DataSource = metodosPago;
                }
                else
                {
                    MessageBox.Show("No se encontraron métodos de pago.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar métodos de pago: " + ex.Message);
            }
        }
        private void FrmAgregarPedido_Load(object sender, EventArgs e)
        {
            CargarMetodosPago();
        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(txtCliente.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre del cliente.");
                    return;
                }

                if (cboMetodoPago.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un método de pago.");
                    return;
                }

                if (!decimal.TryParse(txtMontoTotal.Text, out decimal montoTotal) || montoTotal <= 0)
                {
                    MessageBox.Show("Debe ingresar un monto total válido.");
                    return;
                }

                // Capturamos los valores del formulario
                string cliente = txtCliente.Text.Trim();
                int metodoPagoID = Convert.ToInt32(cboMetodoPago.SelectedValue);
                DateTime fechaPedido = dtpFechaPedido.Value;

                // Creamos la entidad de pedido
                EntidadPedidos nuevoPedido = new EntidadPedidos
                {
                    Cliente = cliente,
                    MetodoPagoID = metodoPagoID,
                    FechaPedido = fechaPedido,
                    MontoTotal = montoTotal
                };

                // Insertamos el pedido usando la capa de negocio
                int resultado = _negocioPedidos.InsertarPedidosN(nuevoPedido);

                if (resultado > 0)
                {
                    MessageBox.Show("Pedido registrado correctamente.");
                    this.Close(); // Cerramos el formulario
                }
                else
                {
                    MessageBox.Show("Hubo un problema al registrar el pedido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
