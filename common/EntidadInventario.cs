using System;

namespace SistemaPolleria.Common.Inventario
{
    public class EntidadInventario
    {
        public int InventarioID { get; set; }
        public int IngredienteID { get; set; }
        public string NombreIngrediente { get; set; }
        public decimal CantidadActual { get; set; }
        public string UnidadMedida { get; set; }

        // Constructor vacío
        public EntidadInventario() { }

        // Constructor con todos los campos excepto InventarioID (por ser autonumérico)
        public EntidadInventario(int ingredienteID, string nombreIngrediente, decimal cantidadActual, string unidadMedida)
        {
            IngredienteID = ingredienteID;
            NombreIngrediente = nombreIngrediente;
            CantidadActual = cantidadActual;
            UnidadMedida = unidadMedida;
        }

        // Constructor con todos los campos
        public EntidadInventario(int inventarioID, int ingredienteID, string nombreIngrediente, decimal cantidadActual, string unidadMedida)
        {
            InventarioID = inventarioID;
            IngredienteID = ingredienteID;
            NombreIngrediente = nombreIngrediente;
            CantidadActual = cantidadActual;
            UnidadMedida = unidadMedida;
        }

        // Constructor
        public EntidadInventario(int ingredienteID, decimal cantidadActual)
        {
            IngredienteID = ingredienteID;
            CantidadActual = cantidadActual;
        }
    }
}
