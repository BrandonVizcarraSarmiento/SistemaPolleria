using SistemaPolleria.Common.Clientes;
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
    public partial class FrmEditarClientes : Form
    {
        private NegocioClientes _negocioClientes = new NegocioClientes();
        private int clienteID;
        public FrmEditarClientes(int clienteID, string nombre, string apellido, string telefono, string direccion)
        {
            InitializeComponent();

            this.clienteID = clienteID;

            // Cargar los datos iniciales en los campos
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtTelefono.Text = telefono;
            txtDireccion.Text = direccion;
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones previas
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre del cliente no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    MessageBox.Show("El apellido del cliente no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    MessageBox.Show("El teléfono del cliente no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDireccion.Text))
                {
                    MessageBox.Show("La dirección del cliente no puede estar vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Capturamos los valores actualizados del formulario
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string direccion = txtDireccion.Text.Trim();

                // Creamos la entidad del cliente con los datos editados
                EntidadCliente clienteEditado = new EntidadCliente
                {
                    ClienteID = clienteID,
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    Direccion = direccion
                };

                // Llamamos al método de negocio para actualizar el cliente
                int resultado = _negocioClientes.EditarClienteN(clienteEditado);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente actualizado correctamente.");
                    this.Close(); // Cerramos el formulario
                }
                else
                {
                    MessageBox.Show("Error al actualizar el cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el cliente: " + ex.Message);
            }
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            // Limpiar todos los campos del formulario
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;

            // Si necesitas restablecer el foco al primer campo
            txtNombre.Focus();
        }
    }
}
