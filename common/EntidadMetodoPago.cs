using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.common
{
    public class EntidadMetodoPago
    {
        public int MetodoPagoID { get; set; }
        public string Nombre { get; set; }

        // Constructor vacío
        public EntidadMetodoPago() { }

        // Constructor con todos los campos excepto MetodoPagoID (por ser autonumérico)
        public EntidadMetodoPago(string nombre)
        {
            Nombre = nombre;
        }

        // Constructor con todos los campos
        public EntidadMetodoPago(int metodoPagoID, string nombre)
        {
            MetodoPagoID = metodoPagoID;
            Nombre = nombre;
        }
    }
}
