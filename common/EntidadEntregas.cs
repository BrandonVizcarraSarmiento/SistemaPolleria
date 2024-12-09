using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.common
{
    public class EntidadEntregas
    {
        public int EntregaID { get; set; }
        public int PedidoID { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string DireccionEntrega { get; set; }
        public string EstadoEntrega { get; set; }

        // Constructor vacío
        public EntidadEntregas() { }

        // Constructor con todos los campos excepto HorarioID
        public EntidadEntregas(int pedidoID, DateTime fechaEntrega, string direccionEntrega, string estadoEntrega)
        {
            PedidoID = pedidoID;
            FechaEntrega = fechaEntrega;
            DireccionEntrega = direccionEntrega;
            EstadoEntrega = estadoEntrega;
        }

        // Constructor con todos los campos
        public EntidadEntregas(int entregaID, int pedidoID, DateTime fechaEntrega, string direccionEntrega, string estadoEntrega)
        {
            EntregaID = entregaID;
            PedidoID = pedidoID;
            FechaEntrega = fechaEntrega;
            DireccionEntrega = direccionEntrega;
            EstadoEntrega = estadoEntrega;
        }
    }
}