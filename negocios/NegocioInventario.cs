using System;
using System.Data;
using System.Windows.Forms;
using SistemaPolleria.Common.Inventario;
using SistemaPolleria.Data.Inventario;

namespace SistemaPolleria.Negocio.Inventario
{
    public class NegocioInventario
    {
        private DatosInventario _datosInventario = new DatosInventario();

        // Obtener todos los ingredientes en el inventario
        public DataTable ObtenerTodosInventariosN()
        {
            return _datosInventario.ObtenerTodosInventarios();
        }

        // Insertar un nuevo ingrediente en el inventario
        public int InsertarIngredienteEnInventarioN(EntidadInventario inventario)
        {
            // Validaciones
            if (inventario.IngredienteID <= 0)
            {
                MessageBox.Show("El ID del ingrediente es inválido.");
                return 0;
            }

            if (string.IsNullOrWhiteSpace(inventario.NombreIngrediente))
            {
                MessageBox.Show("El nombre del ingrediente no puede estar vacío.");
                return 0;
            }

            if (inventario.CantidadActual <= 0)
            {
                MessageBox.Show("La cantidad actual debe ser mayor a cero.");
                return 0;
            }

            if (string.IsNullOrWhiteSpace(inventario.UnidadMedida))
            {
                MessageBox.Show("La unidad de medida no puede estar vacía.");
                return 0;
            }

            // Insertar en la base de datos
            return _datosInventario.InsertarIngredienteEnInventario(inventario);
        }

        // Editar un ingrediente en el inventario
        public int EditarIngredienteEnInventarioN(EntidadInventario inventario)
        {
            // Validaciones
            if (inventario.InventarioID <= 0)
            {
                MessageBox.Show("El ID del inventario es inválido.");
                return 0;
            }

            if (inventario.IngredienteID <= 0)
            {
                MessageBox.Show("El ID del ingrediente es inválido.");
                return 0;
            }

            if (string.IsNullOrWhiteSpace(inventario.NombreIngrediente))
            {
                MessageBox.Show("El nombre del ingrediente no puede estar vacío.");
                return 0;
            }

            if (inventario.CantidadActual <= 0)
            {
                MessageBox.Show("La cantidad actual debe ser mayor a cero.");
                return 0;
            }

            if (string.IsNullOrWhiteSpace(inventario.UnidadMedida))
            {
                MessageBox.Show("La unidad de medida no puede estar vacía.");
                return 0;
            }

            return _datosInventario.EditarIngredienteEnInventario(inventario);
        }

        // Eliminar un ingrediente del inventario
        public int EliminarIngredienteEnInventarioN(int inventarioID)
        {
            if (inventarioID <= 0)
            {
                MessageBox.Show("El ID del inventario es inválido.");
                return 0;
            }

            return _datosInventario.EliminarIngredienteEnInventario(inventarioID);
        }

        // Obtener inventario por ingrediente
        public DataTable ObtenerInventarioPorIngredienteN(int ingredienteID)
        {
            if (ingredienteID <= 0)
            {
                MessageBox.Show("El ID del ingrediente es inválido.");
                return null;
            }

            return _datosInventario.ObtenerInventarioPorIngrediente(ingredienteID);
        }



    }
}
