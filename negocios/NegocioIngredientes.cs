using SistemaPolleria.Common.Ingredientes;
using SistemaPolleria.Data.Ingredientes;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaPolleria.Negocios.Ingredientes
{
    internal class NegocioIngredientes
    {
        private DatosIngredientes _datosIngredientes = new DatosIngredientes();

        // Obtener todos los ingredientes
        public DataTable ObtenerTodosIngredientesN()
        {
            return _datosIngredientes.ObtenerTodosIngredientes();
        }

        // Insertar nuevo ingrediente
        public int InsertarIngredienteN(EntidadIngrediente ingrediente)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(ingrediente.Nombre))
            {
                MessageBox.Show("El nombre del ingrediente no puede estar vacío.");
                return 0;
            }

            if (string.IsNullOrWhiteSpace(ingrediente.UnidadMedida))
            {
                MessageBox.Show("La unidad de medida del ingrediente no puede estar vacía.");
                return 0;
            }

            return _datosIngredientes.InsertarIngrediente(ingrediente);
        }

        // Editar ingrediente
        public int EditarIngredienteN(EntidadIngrediente ingrediente)
        {
            // Validaciones
            if (ingrediente.IngredienteID <= 0)
            {
                MessageBox.Show("El ID del ingrediente es inválido.");
                return 0;
            }

            if (string.IsNullOrWhiteSpace(ingrediente.Nombre))
            {
                MessageBox.Show("El nombre del ingrediente no puede estar vacío.");
                return 0;
            }

            if (string.IsNullOrWhiteSpace(ingrediente.UnidadMedida))
            {
                MessageBox.Show("La unidad de medida del ingrediente no puede estar vacía.");
                return 0;
            }

            return _datosIngredientes.EditarIngrediente(ingrediente);
        }

        // Eliminar ingrediente
        public int EliminarIngredienteN(int ingredienteID)
        {
            if (ingredienteID <= 0)
            {
                MessageBox.Show("El ID del ingrediente es inválido.");
                return 0;
            }

            return _datosIngredientes.EliminarIngrediente(ingredienteID);
        }

        // Buscar ingredientes por nombre
        public DataTable ObtenerIngredientesPorNombreN(string nombreIngrediente)
        {
            if (string.IsNullOrWhiteSpace(nombreIngrediente))
            {
                MessageBox.Show("El nombre del ingrediente no puede estar vacío.");
                return null;
            }

            return _datosIngredientes.ObtenerIngredientePorNombre(nombreIngrediente);
        }
        public DataRow ObtenerIngredientePorID(int ingredienteID)
        {
            // Aquí deberías realizar la lógica para obtener el ingrediente desde la base de datos
            // Esto puede ser una llamada a un método en tu capa de datos que devuelva un DataTable
            DataTable ingredientes = ObtenerTodosIngredientesN(); // Suponiendo que este método retorna todos los ingredientes

            // Filtramos el DataTable para obtener el ingrediente específico
            DataRow[] rows = ingredientes.Select($"IngredienteID = {ingredienteID}");

            return rows.Length > 0 ? rows[0] : null; // Retornamos la primera fila que coincida o null si no se encontró
        }
    }
}
