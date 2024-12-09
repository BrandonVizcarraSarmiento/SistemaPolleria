using System;

namespace SistemaPolleria.Common.IngredientesPorPlato
{
    public class EntidadIngredientesPorPlato
    {
        public int IngredientePlatoID { get; set; }
        public int PlatoID { get; set; }
        public int IngredienteID { get; set; }
        public decimal CantidadNecesaria { get; set; }

        // Constructor vacío
        public EntidadIngredientesPorPlato() { }

        // Constructor con todos los campos excepto IngredientePlatoID (por ser autonumérico)
        public EntidadIngredientesPorPlato(int platoID, int ingredienteID, decimal cantidadNecesaria)
        {
            PlatoID = platoID;
            IngredienteID = ingredienteID;
            CantidadNecesaria = cantidadNecesaria;
        }

        // Constructor con todos los campos
        public EntidadIngredientesPorPlato(int ingredientePlatoID, int platoID, int ingredienteID, decimal cantidadNecesaria)
        {
            IngredientePlatoID = ingredientePlatoID;
            PlatoID = platoID;
            IngredienteID = ingredienteID;
            CantidadNecesaria = cantidadNecesaria;
        }
    }
}
