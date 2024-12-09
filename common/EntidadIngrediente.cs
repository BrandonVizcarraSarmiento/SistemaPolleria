using System;

namespace SistemaPolleria.Common.Ingredientes
{
    public class EntidadIngrediente
    {
        public int IngredienteID { get; set; }
        public string Nombre { get; set; }
        public string UnidadMedida { get; set; }

        // Constructor vacío
        public EntidadIngrediente() { }

        // Constructor con todos los campos excepto IngredienteID (por ser autonumérico)
        public EntidadIngrediente(string nombre, string unidadMedida)
        {
            Nombre = nombre;
            UnidadMedida = unidadMedida;
        }

        // Constructor con todos los campos
        public EntidadIngrediente(int ingredienteID, string nombre, string unidadMedida)
        {
            IngredienteID = ingredienteID;
            Nombre = nombre;
            UnidadMedida = unidadMedida;
        }
    }
}
