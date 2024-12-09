using SistemaPolleria.Negocios.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPolleria.presentacion.gestionclientes.clientes
{
    public partial class FrmClientes : Form
    {
        private NegocioClientes _negocioClientes = new NegocioClientes();

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void CargarClientes()
        {
            // Llamamos al método para obtener todos los clientes
            DataTable clientes = _negocioClientes.ObtenerTodosClientesN();

            // Verificamos que no haya error o que el DataTable no esté vacío
            if (clientes != null && clientes.Rows.Count > 0)
            {
                // Vinculamos el DataTable al DataGridView
                dgvCliente.DataSource = clientes;
            }
            else
            {
                MessageBox.Show("No se encontraron clientes.");
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();

        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmAgregarClientes agregarForm = new FrmAgregarClientes();
            agregarForm.ShowDialog();
            CargarClientes();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dgvCliente.SelectedRows.Count > 0)
            {
                // Pregunta al usuario si realmente desea eliminar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    // Obtiene el ID del cliente seleccionado
                    int clienteID = Convert.ToInt32(dgvCliente.SelectedRows[0].Cells["ClienteID"].Value);

                    // Llama al método para eliminar el cliente
                    _negocioClientes.EliminarClienteN(clienteID);

                    // Vuelve a cargar los datos en el DataGridView
                    CargarClientes();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                // Obtenemos los valores de la fila seleccionada
                int clienteID = Convert.ToInt32(dgvCliente.SelectedRows[0].Cells["ClienteID"].Value);
                string nombre = dgvCliente.SelectedRows[0].Cells["Nombre"].Value.ToString();
                string apellido = dgvCliente.SelectedRows[0].Cells["Apellido"].Value.ToString();
                string telefono = dgvCliente.SelectedRows[0].Cells["Telefono"].Value.ToString();
                string direccion = dgvCliente.SelectedRows[0].Cells["Direccion"].Value.ToString();

                // Abrimos el formulario de edición
                FrmEditarClientes editarClienteForm = new FrmEditarClientes(clienteID, nombre, apellido, telefono, direccion);
                editarClienteForm.ShowDialog();

                // Recargar los datos después de editar
                CargarClientes();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string nombreCliente = txtBuscarCliente.Text.Trim();

            if (!string.IsNullOrEmpty(nombreCliente))
            {
                DataTable clientes = _negocioClientes.ObtenerClientesPorNombreN(nombreCliente);

                if (clientes != null && clientes.Rows.Count > 0)
                {
                    dgvCliente.DataSource = clientes;
                }
                else
                {
                    MessageBox.Show("No se encontraron clientes con el nombre ingresado.");
                }
            }
            else
            {
                // Cargar todos los clientes si el campo de búsqueda está vacío
                CargarClientes();
            }
        }
    }
}
