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
    public partial class FrmPedidos : Form
    {
        private NegociosPedidos _negociosPedidos = new NegociosPedidos();
        public FrmPedidos()
        {
            InitializeComponent();
        }
        private void CargarPedidos()
        {
            // Llamamos al método para obtener todos los pedidos
            DataTable pedidos = _negociosPedidos.ObtenerTodosPedidosN();

            // Verificamos que no haya error o que el DataTable no esté vacío
            if (pedidos != null && pedidos.Rows.Count > 0)
            {
                // Vinculamos el DataTable al DataGridView
                dgvPedido.DataSource = pedidos;
            }
            else
            {
                MessageBox.Show("No se encontraron pedidos.");
            }
        }
        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            CargarPedidos();
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            FrmAgregarPedido agregarForm = new FrmAgregarPedido();
            agregarForm.ShowDialog();
            CargarPedidos();
        }

        private void btnEditarPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedido.SelectedRows.Count > 0)
            {
                // Obtener los datos del pedido seleccionado
                int pedidoID = Convert.ToInt32(dgvPedido.SelectedRows[0].Cells["PedidoID"].Value);
                string cliente = dgvPedido.SelectedRows[0].Cells["Cliente"].Value.ToString();
                int metodoPagoID = Convert.ToInt32(dgvPedido.SelectedRows[0].Cells["MetodoPagoID"].Value);
                DateTime fechaPedido = Convert.ToDateTime(dgvPedido.SelectedRows[0].Cells["FechaPedido"].Value);
                decimal montoTotal = Convert.ToDecimal(dgvPedido.SelectedRows[0].Cells["MontoTotal"].Value);

                // Abrir el formulario de edición con los datos
                FrmEditarPedido editarForm = new FrmEditarPedido(pedidoID, cliente, metodoPagoID, fechaPedido, montoTotal);
                editarForm.ShowDialog();

                // Recargar los pedidos después de la edición
                CargarPedidos();
            }
            else
            {
                MessageBox.Show("Seleccione un pedido para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dgvPedido.SelectedRows.Count > 0)
            {
                // Pregunta al usuario si realmente desea eliminar el pedido
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este pedido?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Obtiene el id del pedido seleccionado
                        int pedidoID = Convert.ToInt32(dgvPedido.SelectedRows[0].Cells["PedidoID"].Value);

                        // Llama al método para eliminar el pedido
                        NegociosPedidos negocioPedido = new NegociosPedidos();
                        negocioPedido.EliminarPedidosN(pedidoID);

                        // Vuelve a cargar los datos en el DataGridView
                        CargarPedidos();

                        MessageBox.Show("Pedido eliminado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el pedido: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un pedido para eliminar.");
            }
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            string clienteNombre = txtBuscarPedido.Text.Trim(); // Suponiendo que txtBuscarPedido es el cuadro de texto para la búsqueda

            if (!string.IsNullOrEmpty(clienteNombre))
            {
                // Llama al método para obtener pedidos por nombre de cliente
                DataTable pedidos = _negociosPedidos.ObtenerPedidosPorClienteN(clienteNombre);

                if (pedidos != null && pedidos.Rows.Count > 0)
                {
                    // Muestra los resultados en el DataGridView
                    dgvPedido.DataSource = pedidos;
                }
                else
                {
                    MessageBox.Show("No se encontraron pedidos para el cliente ingresado.");
                }
            }
            else
            {
                // Si el campo de búsqueda está vacío, carga todos los pedidos
                DataTable todosPedidos = _negociosPedidos.ObtenerTodosPedidosN();

                if (todosPedidos != null && todosPedidos.Rows.Count > 0)
                {
                    // Muestra todos los pedidos en el DataGridView
                    dgvPedido.DataSource = todosPedidos;
                }
                else
                {
                    MessageBox.Show("No hay pedidos registrados.");
                }
            }
        }
    }
}
