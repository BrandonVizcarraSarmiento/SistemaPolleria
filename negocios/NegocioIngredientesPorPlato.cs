using System;
using System.Data;
using System.Windows.Forms;
using SistemaPolleria.Common.IngredientesPorPlato;
using SistemaPolleria.Data.IngredientesPorPlato;

namespace SistemaPolleria.Negocio.IngredientesPorPlato
{
    public class NegocioIngredientesPorPlato
    {
        private DatosIngredientesPorPlato _datosIngredientesPorPlato = new DatosIngredientesPorPlato();

        // Obtener todos los ingredientes por plato
        public DataTable ObtenerTodosIngredientesPorPlatoN()
        {
            return _datosIngredientesPorPlato.ObtenerTodosIngredientesPorPlato();
        }

        // Insertar un nuevo ingrediente por plato
        public int InsertarIngredientePorPlatoN(EntidadIngredientesPorPlato ingredientePlato)
        {
            // Validaciones
            if (ingredientePlato.PlatoID <= 0)
            {
                MessageBox.Show("El ID del plato es inválido.");
                return 0;
            }

            if (ingredientePlato.IngredienteID <= 0)
            {
                MessageBox.Show("El ID del ingrediente es inválido.");
                return 0;
            }

            if (ingredientePlato.CantidadNecesaria <= 0)
            {
                MessageBox.Show("La cantidad necesaria debe ser mayor a cero.");
                return 0;
            }

            // Insertar en la base de datos
            return _datosIngredientesPorPlato.InsertarIngredientePorPlato(ingredientePlato);
        }

        // Editar un ingrediente por plato
        public int EditarIngredientePorPlatoN(EntidadIngredientesPorPlato ingredientePlato)
        {
            // Validaciones
            if (ingredientePlato.IngredientePlatoID <= 0)
            {
                MessageBox.Show("El ID del ingrediente por plato es inválido.");
                return 0;
            }

            if (ingredientePlato.PlatoID <= 0)
            {
                MessageBox.Show("El ID del plato es inválido.");
                return 0;
            }

            if (ingredientePlato.IngredienteID <= 0)
            {
                MessageBox.Show("El ID del ingrediente es inválido.");
                return 0;
            }

            if (ingredientePlato.CantidadNecesaria <= 0)
            {
                MessageBox.Show("La cantidad necesaria debe ser mayor a cero.");
                return 0;
            }

            return _datosIngredientesPorPlato.EditarIngredientePorPlato(ingredientePlato);
        }

        // Eliminar un ingrediente por plato
        public int EliminarIngredientePorPlatoN(int ingredientePlatoID)
        {
            if (ingredientePlatoID <= 0)
            {
                MessageBox.Show("El ID del ingrediente por plato es inválido.");
                return 0;
            }

            return _datosIngredientesPorPlato.EliminarIngredientePorPlato(ingredientePlatoID);
        }

        // Obtener ingredientes por plato
        public DataTable ObtenerIngredientesPorPlatoN(int platoID)
        {
            if (platoID <= 0)
            {
                MessageBox.Show("El ID del plato es inválido.");
                return null;
            }

            return _datosIngredientesPorPlato.ObtenerIngredientesPorPlato(platoID);
        }
    }
}
