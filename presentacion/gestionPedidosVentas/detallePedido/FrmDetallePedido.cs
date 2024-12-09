using SistemaPolleria.negocio.asistencia;
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

namespace SistemaPolleria.presentacion.gestionPedidosVentas.detallePedido
{
    public partial class FrmDetallePedido : Form
    {
        private NegociosDetallesPedido _negociosDetallesPedido = new NegociosDetallesPedido();
        public FrmDetallePedido()
        {
            InitializeComponent();
        }
        private void CargarDetallePedido()
        {
            // Llamamos al método para obtener todos los detalle pedido
            DataTable detallePedido = _negociosDetallesPedido.ObtenerTodosDetallesPedidoN();

            // Verificamos que no haya error o que el DataTable no esté vacío
            if (detallePedido != null && detallePedido.Rows.Count > 0)
            {
                // Vinculamos el DataTable al DataGridView
                dgvDetallePedido.DataSource = detallePedido;
            }
            else
            {
                MessageBox.Show("No se encontraron los detalle pedido.");
            }
        }
        private void FrmDetallePedido_Load(object sender, EventArgs e)
        {
            CargarDetallePedido();
        }

        private void btnNuevoDetallePedido_Click(object sender, EventArgs e)
        {
            FrmAgregarDetallePedido agregarForm = new FrmAgregarDetallePedido();
            agregarForm.ShowDialog();
            CargarDetallePedido();
        }

        private void btnEditarDetallePedido_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dgvDetallePedido.SelectedRows.Count > 0)
            {
                // Obtener los valores de las celdas de la fila seleccionada
                int detallePedidoID = Convert.ToInt32(dgvDetallePedido.SelectedRows[0].Cells["DetallePedidoID"].Value);
                int pedidoID = Convert.ToInt32(dgvDetallePedido.SelectedRows[0].Cells["PedidoID"].Value);
                int platoID = Convert.ToInt32(dgvDetallePedido.SelectedRows[0].Cells["PlatoID"].Value);
                int cantidad = Convert.ToInt32(dgvDetallePedido.SelectedRows[0].Cells["Cantidad"].Value);
                decimal precio = Convert.ToDecimal(dgvDetallePedido.SelectedRows[0].Cells["PrecioUnitario"].Value);
                decimal subtotal = Convert.ToDecimal(dgvDetallePedido.SelectedRows[0].Cells["Subtotal"].Value);  // Aquí es decimal, no DateTime

                // Crear una instancia del formulario de edición, pasándole los datos
                FrmEditarDetallePedido editarForm = new FrmEditarDetallePedido(detallePedidoID, pedidoID, platoID, cantidad, precio, subtotal);

                // Mostrar el formulario de edición como un cuadro de diálogo
                editarForm.ShowDialog();

                // Recargar los datos después de la edición
                CargarDetallePedido();
            }
            else
            {
                // Si no se selecciona ninguna fila, mostrar un mensaje de advertencia
                MessageBox.Show("Seleccione un registro para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarDetallePedido_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dgvDetallePedido.SelectedRows.Count > 0)
            {
                // Pregunta al usuario si realmente desea eliminar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este detalle de pedido?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    // Obtiene el id del detalle de pedido seleccionado
                    int detallePedidoID = Convert.ToInt32(dgvDetallePedido.SelectedRows[0].Cells["DetallePedidoID"].Value);

                    // Llama al método para eliminar el detalle de pedido
                    NegociosDetallesPedido negocioDetallePedido = new NegociosDetallesPedido();
                    negocioDetallePedido.EliminarDetallesPedidoN(detallePedidoID);

                    // Vuelve a cargar los datos en el DataGridView
                    CargarDetallePedido();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un detalle de pedido para eliminar.");
            }
        }

        private void btnBuscarDetallePedido_Click(object sender, EventArgs e)
        {
            // Obtener el ID del pedido desde el campo de búsqueda (suponiendo que es un TextBox)
            string pedidoIDTexto = txtBuscarDetallePedido.Text.Trim();

            if (!string.IsNullOrEmpty(pedidoIDTexto))
            {
                // Verifica si el texto ingresado es un número válido
                if (int.TryParse(pedidoIDTexto, out int pedidoID))
                {
                    // Llama al método para obtener los detalles del pedido por el PedidoID
                    DataTable detallesPedido = _negociosDetallesPedido.ObtenerDetallesPedidoPorPedidoIDN(pedidoID);

                    if (detallesPedido != null && detallesPedido.Rows.Count > 0)
                    {
                        // Si se encuentran detalles, los muestra en el DataGridView
                        dgvDetallePedido.DataSource = detallesPedido;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron detalles para el pedido con el ID ingresado.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un ID de pedido válido.");
                }
            }
            else
            {
                // Si el campo de búsqueda está vacío, puedes cargar todos los detalles de pedidos
                DataTable todosLosDetalles = _negociosDetallesPedido.ObtenerTodosDetallesPedidoN();

                if (todosLosDetalles != null && todosLosDetalles.Rows.Count > 0)
                {
                    dgvDetallePedido.DataSource = todosLosDetalles;
                }
                else
                {
                    MessageBox.Show("No hay detalles de pedidos registrados.");
                }
            }
        }
    }
}
