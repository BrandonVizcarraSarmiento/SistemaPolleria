using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.common
{
    public class EntidadPagos
    {
        public int PagoID { get; set; }
        public int PedidoID { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string MetodoPago { get; set; }
        // Constructor vacío 
        public EntidadPagos() { }
        // Constructor con todos los campos excepto HorarioID
        public EntidadPagos(int pedidoID, decimal monto, DateTime fechaPago, string metodoPago)
        {
            PedidoID = pedidoID;
            Monto = monto;
            FechaPago = fechaPago;
            MetodoPago = metodoPago;
        }
        // Constructor con todos los campos
        public EntidadPagos(int pagoID, int pedidoID, decimal monto, DateTime fechaPago, string metodoPago)
        {
            PagoID = pagoID;
            PedidoID = pedidoID;
            Monto = monto;
            FechaPago = fechaPago;
            MetodoPago = metodoPago;
        }
    }
}