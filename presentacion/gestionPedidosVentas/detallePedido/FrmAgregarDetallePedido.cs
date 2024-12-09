using SistemaPolleria.common;
using SistemaPolleria.negocios;
using SistemaPolleria.Negocios.Platos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPolleria.presentacion.gestionPedidosVentas.detallePedido
{
    public partial class FrmAgregarDetallePedido : Form
    {
        private NegociosDetallesPedido _detallesPedido = new NegociosDetallesPedido();
        private NegocioPlatos _negocioPlatos = new NegocioPlatos();
        private NegociosPedidos _negocioPedidos = new NegociosPedidos();
        public FrmAgregarDetallePedido()
        {
            InitializeComponent();
        }
        private void CargarPlatos()
        {
            try
            {
                // Obtenemos la lista de platos desde la capa de negocio
                DataTable platos = _negocioPlatos.ObtenerTodosPlatosN();

                // Verificamos que no esté vacío
                if (platos != null && platos.Rows.Count > 0)
                {
                    // Asignamos al ComboBox los platos
                    cboPlato.DisplayMember = "Nombre";  // Mostrar nombre del plato
                    cboPlato.ValueMember = "PlatoID";   // Guardar el ID del plato
                    cboPlato.DataSource = platos;       // Asignamos el DataTable al ComboBox
                }
                else
                {
                    MessageBox.Show("No se encontraron platos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar platos: " + ex.Message);
            }
        }
        private void CargarPedidos()
        {
            try
            {
                // Obtenemos la lista de pedidos desde la capa de negocio
                DataTable pedidos = _negocioPedidos.ObtenerTodosPedidosN();  // Suponiendo que tienes un método para obtener todos los pedidos

                // Verificamos que no esté vacío
                if (pedidos != null && pedidos.Rows.Count > 0)
                {
                    // Asignamos al ComboBox los pedidos
                    cboIdPedido.DisplayMember = "PedidoID";  // Mostrar ID del pedido
                    cboIdPedido.ValueMember = "PedidoID";    // Guardar el ID del pedido
                    cboIdPedido.DataSource = pedidos;        // Asignamos el DataTable al ComboBox
                }
                else
                {
                    MessageBox.Show("No se encontraron pedidos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pedidos: " + ex.Message);
            }
        }
        private void FrmAgregarDetallePedido_Load(object sender, EventArgs e)
        {
            CargarPlatos();
            CargarPedidos();
        }

        private void btnGuardarDetallePedido_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturamos los valores del formulario
                int idPedido = Convert.ToInt32(cboIdPedido.SelectedValue);  // Obtenemos el ID del pedido seleccionado
                int platoID = Convert.ToInt32(cboPlato.SelectedValue);      // Obtenemos el ID del plato seleccionado
                int cantidad = Convert.ToInt32(txtCantidad.Text);           // Obtenemos la cantidad
                decimal precioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);  // Obtenemos el precio unitario
                decimal subTotal = Convert.ToDecimal(txtSubTotal.Text);     // Obtenemos el subtotal

                // Creamos la entidad de detalle de pedido
                EntidadDetallesPedido detallePedido = new EntidadDetallesPedido(idPedido, platoID, cantidad, precioUnitario, subTotal);

                // Insertamos el detalle de pedido utilizando la capa de negocio
                int resultado = _detallesPedido.InsertarDetallesPedidoN(detallePedido);

                // Verificamos el resultado
                if (resultado > 0)
                {
                    MessageBox.Show("Detalle de pedido registrado correctamente.");
                    this.Close();  // Cerramos el formulario
                }
                else
                {
                    MessageBox.Show("Hubo un problema al registrar el detalle del pedido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el detalle del pedido: " + ex.Message);
            }
        }
    }
}
