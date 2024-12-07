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
    public partial class FrmPago : Form
    {
        private NegociosPagos _negociosPagos = new NegociosPagos();
        public FrmPago()
        {
            InitializeComponent();
        }
        private void CargarPagos()
        {
            // Llamamos al método para obtener todos los pagos
            DataTable pagos = _negociosPagos.ObtenerTodosPagosN();

            // Verificamos que no haya error o que el DataTable no esté vacío
            if (pagos != null && pagos.Rows.Count > 0)
            {
                // Vinculamos el DataTable al DataGridView
                dgvPago.DataSource = pagos;
            }
            else
            {
                MessageBox.Show("No se encontraron pagos.");
            }
        }
        private void FrmPago_Load(object sender, EventArgs e)
        {
            CargarPagos();
        }

        private void btnNuevoPago_Click(object sender, EventArgs e)
        {
            FrmAgregarPago agregarForm = new FrmAgregarPago();
            agregarForm.ShowDialog();
            CargarPagos();
        }

        private void btnEditarPago_Click(object sender, EventArgs e)
        {
            if (dgvPago.SelectedRows.Count > 0)
            {
                // Obtén los valores seleccionados
                int pagoID = Convert.ToInt32(dgvPago.SelectedRows[0].Cells["PagoID"].Value);
                int pedidoID = Convert.ToInt32(dgvPago.SelectedRows[0].Cells["PedidoID"].Value);
                decimal monto = Convert.ToDecimal(dgvPago.SelectedRows[0].Cells["Monto"].Value);
                DateTime fecha = Convert.ToDateTime(dgvPago.SelectedRows[0].Cells["FechaPago"].Value);
                string metodoPago = dgvPago.SelectedRows[0].Cells["MetodoPago"].Value.ToString();

                // Abre el formulario de edición
                FrmEditarPago editarForm = new FrmEditarPago(pagoID, pedidoID, monto, fecha, metodoPago);
                editarForm.ShowDialog();

                // Recargar pagos
                CargarPagos();
            }
            else
            {
                MessageBox.Show("Seleccione un pago para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dgvPago.SelectedRows.Count > 0)
            {
                // Pregunta al usuario si realmente desea eliminar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este pago?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Obtiene el ID del pago seleccionado
                        int pagoID = Convert.ToInt32(dgvPago.SelectedRows[0].Cells["PagoID"].Value);

                        // Llama al método para eliminar el pago
                        NegociosPagos negocioPagos = new NegociosPagos();
                        int resultadoEliminacion = negocioPagos.EliminarPagosN(pagoID);

                        if (resultadoEliminacion > 0)
                        {
                            MessageBox.Show("Pago eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Vuelve a cargar los datos en el DataGridView
                            CargarPagos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el pago. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al intentar eliminar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un pago para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarPago_Click(object sender, EventArgs e)
        {
            // Obtiene el PedidoID ingresado en el campo de búsqueda
            string textoPedidoID = txtBuscarPago.Text.Trim();

            // Verifica si el campo de búsqueda no está vacío
            if (!string.IsNullOrEmpty(textoPedidoID))
            {
                // Convierte el texto a entero (PedidoID)
                if (int.TryParse(textoPedidoID, out int pedidoID))
                {
                    // Llama al método para obtener los pagos por PedidoID
                    DataTable pagos = _negociosPagos.ObtenerPagosPorPedidoIDN(pedidoID);

                    // Verifica si se encontraron pagos
                    if (pagos != null && pagos.Rows.Count > 0)
                    {
                        // Asigna los resultados al DataGridView
                        dgvPago.DataSource = pagos;
                    }
                    else
                    {
                        // Muestra mensaje si no se encontraron pagos
                        MessageBox.Show("No se encontraron pagos para el PedidoID ingresado.");
                    }
                }
                else
                {
                    // Muestra un mensaje si el PedidoID no es válido
                    MessageBox.Show("Por favor ingrese un PedidoID válido.");
                }
            }
            else
            {
                // Si el campo de búsqueda está vacío, carga todos los pagos
                DataTable todosPagos = _negociosPagos.ObtenerTodosPagosN();

                // Verifica si existen pagos
                if (todosPagos != null && todosPagos.Rows.Count > 0)
                {
                    // Asigna todos los pagos al DataGridView
                    dgvPago.DataSource = todosPagos;
                }
                else
                {
                    // Muestra mensaje si no hay pagos registrados
                    MessageBox.Show("No hay pagos registrados.");
                }
            }
        }
    }
}
