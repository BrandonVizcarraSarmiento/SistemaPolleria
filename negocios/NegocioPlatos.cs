using SistemaPolleria.Common.Platos;
using SistemaPolleria.Data.Platos;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaPolleria.Negocios.Platos
{
    internal class NegocioPlatos
    {
        private DatosPlatos _datosPlatos = new DatosPlatos();

        // Obtener todos los platos
        public DataTable ObtenerTodosPlatosN()
        {
            return _datosPlatos.ObtenerTodosPlatos();
        }

        // Insertar nuevo plato
        public int InsertarPlatoN(EntidadPlato plato)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(plato.Nombre))
            {
                MessageBox.Show("El nombre del plato no puede estar vacío.");
                return 0;
            }

            if (string.IsNullOrWhiteSpace(plato.Descripcion))
            {
                MessageBox.Show("La descripción del plato no puede estar vacía.");
                return 0;
            }

            if (plato.Precio <= 0)
            {
                MessageBox.Show("El precio del plato debe ser mayor a cero.");
                return 0;
            }

            return _datosPlatos.InsertarPlato(plato);
        }

        // Editar plato
        public int EditarPlatoN(EntidadPlato plato)
        {
            // Validaciones
            if (plato.PlatoID <= 0)
            {
                MessageBox.Show("El ID del plato es inválido.");
                return 0;
            }

            if (string.IsNullOrWhiteSpace(plato.Nombre))
            {
                MessageBox.Show("El nombre del plato no puede estar vacío.");
                return 0;
            }

            if (string.IsNullOrWhiteSpace(plato.Descripcion))
            {
                MessageBox.Show("La descripción del plato no puede estar vacía.");
                return 0;
            }

            if (plato.Precio <= 0)
            {
                MessageBox.Show("El precio del plato debe ser mayor a cero.");
                return 0;
            }

            return _datosPlatos.EditarPlato(plato);
        }

        // Eliminar plato
        public int EliminarPlatoN(int platoID)
        {
            if (platoID <= 0)
            {
                MessageBox.Show("El ID del plato es inválido.");
                return 0;
            }

            return _datosPlatos.EliminarPlato(platoID);
        }

        // Buscar platos por nombre
        public DataTable ObtenerPlatosPorNombreN(string nombrePlato)
        {
            if (string.IsNullOrWhiteSpace(nombrePlato))
            {
                MessageBox.Show("El nombre del plato no puede estar vacío.");
                return null;
            }

            return _datosPlatos.ObtenerPlatoPorNombre(nombrePlato);
        }
    }
}
