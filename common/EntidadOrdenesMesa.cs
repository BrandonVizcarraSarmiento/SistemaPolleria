using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.common
{
    public class EntidadOrdenesMesa
    {
        public int OrdenID { get; set; }
        public int MesaID { get; set; }
        public int PedidoID { get; set; }
        public DateTime FechaOrden { get; set; }
        // Constructor vacío 
        public EntidadOrdenesMesa() { }
        // Constructor con todos los campos excepto OrdenID
        public EntidadOrdenesMesa(int mesaID, int pedidoID, DateTime fechaOrden)
        {
            MesaID = mesaID;
            PedidoID = pedidoID;
            FechaOrden = fechaOrden;
        }
        // Constructor con todos los campos
        public EntidadOrdenesMesa(int ordenID, int mesaID, int pedidoID, DateTime fechaOrden)
        {
            OrdenID = ordenID;
            MesaID = mesaID;
            PedidoID = pedidoID;
            FechaOrden = fechaOrden;
        }
    }
}