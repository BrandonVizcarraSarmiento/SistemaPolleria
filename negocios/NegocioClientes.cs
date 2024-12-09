using SistemaPolleria.Common.Clientes;
using SistemaPolleria.Data.Clientes;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaPolleria.Negocios.Clientes
{
    internal class NegocioClientes
    {
        private DatosClientes _datosClientes = new DatosClientes();

        // Obtener todos los clientes
        public DataTable ObtenerTodosClientesN()
        {
            return _datosClientes.ObtenerTodosClientes();
        }

        // Insertar nuevo cliente
        public int InsertarClienteN(EntidadCliente cliente)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                MessageBox.Show("El nombre del cliente no puede estar vacío.");
                return 0;
            }

            if (string.IsNullOrWhiteSpace(cliente.Apellido))
            {
                MessageBox.Show("El apellido del cliente no puede estar vacío.");
                return 0;
            }

            if (string.IsNullOrWhiteSpace(cliente.Telefono))
            {
                MessageBox.Show("El teléfono del cliente no puede estar vacío.");
                return 0;
            }

            if (string.IsNullOrWhiteSpace(cliente.Direccion))
            {
                MessageBox.Show("La dirección del cliente no puede estar vacía.");
                return 0;
            }

            return _datosClientes.InsertarCliente(cliente);
        }

        // Editar cliente
        public int EditarClienteN(EntidadCliente cliente)
        {
            // Validaciones
            if (cliente.ClienteID <= 0)
            {
                MessageBox.Show("El ID del cliente es inválido.");
                return 0;
            }

            if (string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                MessageBox.Show("El nombre del cliente no puede estar vacío.");
                return 0;
            }

            if (string.IsNullOrWhiteSpace(cliente.Apellido))
            {
                MessageBox.Show("El apellido del cliente no puede estar vacío.");
                return 0;
            }

            if (string.IsNullOrWhiteSpace(cliente.Telefono))
            {
                MessageBox.Show("El teléfono del cliente no puede estar vacío.");
                return 0;
            }

            if (string.IsNullOrWhiteSpace(cliente.Direccion))
            {
                MessageBox.Show("La dirección del cliente no puede estar vacía.");
                return 0;
            }

            return _datosClientes.EditarCliente(cliente);
        }

        // Eliminar cliente
        public int EliminarClienteN(int clienteID)
        {
            if (clienteID <= 0)
            {
                MessageBox.Show("El ID del cliente es inválido.");
                return 0;
            }

            return _datosClientes.EliminarCliente(clienteID);
        }

        // Buscar clientes por nombre
        public DataTable ObtenerClientesPorNombreN(string nombreCliente)
        {
            if (string.IsNullOrWhiteSpace(nombreCliente))
            {
                MessageBox.Show("El nombre del cliente no puede estar vacío.");
                return null;
            }

            return _datosClientes.ObtenerClientePorNombre(nombreCliente);
        }
    }
}
