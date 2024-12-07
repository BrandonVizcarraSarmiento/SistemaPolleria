using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.common
{
    public class EntidadCaja
    {
        public int CajaID { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        // Constructor vacío
        public EntidadCaja() { }

        // Constructor con todos los campos excepto CajaID (por ser autonumérico)
        public EntidadCaja(DateTime fecha, decimal total)
        {
            Fecha = fecha;
            Total = total;
        }

        // Constructor con todos los campos
        public EntidadCaja(int cajaID, DateTime fecha, decimal total)
        {
            CajaID = cajaID;
            Fecha = fecha;
            Total = total;
        }
    }
}
