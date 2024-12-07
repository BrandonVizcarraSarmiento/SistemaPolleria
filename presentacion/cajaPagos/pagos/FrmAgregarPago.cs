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
    public partial class FrmAgregarPago : Form
    {
        private NegociosPedidos _negocioPedidos = new NegociosPedidos();
        private NegociosPagos _negocioPagos = new NegociosPagos();
        public FrmAgregarPago()
        {
            InitializeComponent();
        }
        // Método para cargar los pedidos en el ComboBox
        private void CargarPedidos()
        {
            try
            {
                // Obtenemos los pedidos desde la capa de negocio
                DataTable pedidos = _negocioPedidos.ObtenerTodosPedidosN();

                if (pedidos != null && pedidos.Rows.Count > 0)
                {
                    cboPedido.DisplayMember = "PedidoID";  // Lo que se mostrará en el ComboBox
                    cboPedido.ValueMember = "PedidoID";   // Lo que se seleccionará como valor
                    cboPedido.DataSource = pedidos;       // Asignamos la fuente de datos
                }
                else
                {
                    MessageBox.Show("No se encontraron pedidos disponibles.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pedidos: " + ex.Message);
            }
        }
        private void FrmAgregarPago_Load(object sender, EventArgs e)
        {
            CargarPedidos();
        }

        private void btnGuardarPago_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que todos los campos tengan datos
                if (cboPedido.SelectedValue == null || string.IsNullOrEmpty(txtMonto.Text) || string.IsNullOrEmpty(txtMetodoPago.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                // Capturamos los valores del formulario
                int pedidoID = Convert.ToInt32(cboPedido.SelectedValue);
                decimal monto = Convert.ToDecimal(txtMonto.Text);
                DateTime fechaPago = dtpFecha.Value;
                string metodoPago = txtMetodoPago.Text.Trim();

                // Creamos la entidad de pagos
                EntidadPagos nuevoPago = new EntidadPagos
                {
                    PedidoID = pedidoID,
                    Monto = monto,
                    FechaPago = fechaPago,
                    MetodoPago = metodoPago
                };

                // Insertamos el pago usando la capa de negocio
                int resultado = _negocioPagos.InsertarPagosN(nuevoPago);

                if (resultado > 0)
                {
                    MessageBox.Show("Pago registrado correctamente.");
                    this.Close(); // Cerramos el formulario después de guardar
                }
                else
                {
                    MessageBox.Show("Ocurrió un problema al registrar el pago.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
