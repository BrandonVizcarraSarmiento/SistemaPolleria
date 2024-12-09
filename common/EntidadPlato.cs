using System;

namespace SistemaPolleria.Common.Platos
{
    public class EntidadPlato
    {
        public int PlatoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        // Constructor vacío
        public EntidadPlato() { }

        // Constructor con todos los campos excepto PlatoID (por ser autonumérico)
        public EntidadPlato(string nombre, string descripcion, decimal precio)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }

        // Constructor con todos los campos
        public EntidadPlato(int platoID, string nombre, string descripcion, decimal precio)
        {
            PlatoID = platoID;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }
    }
}
