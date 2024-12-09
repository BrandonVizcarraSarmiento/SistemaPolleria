using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.common
{
    public class EntidadReservas
    {
        public int ReservaID { get; set; }
        public int MesaID { get; set; }
        public int ClienteID { get; set; }
        public DateTime FechaReserva { get; set; }

        // Constructor vacío 
        public EntidadReservas() { }
        // Constructor con todos los campos excepto HorarioID
        public EntidadReservas(int mesaID, int clienteID, DateTime fechaReserva)
        {
            MesaID = mesaID;
            ClienteID = clienteID;
            FechaReserva = fechaReserva;
        }
        // Constructor con todos los campos
        public EntidadReservas(int reservaID, int mesaID, int clienteID, DateTime fechaReserva)
        {
            ReservaID = reservaID;
            MesaID = mesaID;
            ClienteID = clienteID;
            FechaReserva = fechaReserva;
        }
    }
}
