using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.common
{
    public class EntidadPedidos
    {
        public int PedidoID { get; set; }
        public string Cliente { get; set; }
        public int MetodoPagoID { get; set; }
        public DateTime FechaPedido { get; set; }
        public decimal MontoTotal { get; set; }

        // Constructor vacío
        public EntidadPedidos() { }

        // Constructor con todos los campos excepto HorarioID
        public EntidadPedidos(string cliente, int metodoPagoID, DateTime fechaPedido, decimal montoTotal)
        {
            Cliente = cliente;
            MetodoPagoID = metodoPagoID;
            FechaPedido = fechaPedido;
            MontoTotal = montoTotal;
        }

        // Constructor con todos los campos
        public EntidadPedidos(int pedidoID, string cliente, int metodoPagoID, DateTime fechaPedido, decimal montoTotal)
        {
            PedidoID = pedidoID;
            Cliente = cliente;
            MetodoPagoID = metodoPagoID;
            FechaPedido = fechaPedido;
            MontoTotal = montoTotal;
        }
    }
}
