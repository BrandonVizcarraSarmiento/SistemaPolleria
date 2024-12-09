using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.common
{
    public class EntidadMesas
    {
        public int MesaID { get; set; }
        public int NumeroMesa { get; set; }
        public int Capacidad { get; set; }
        // Constructor vacío 
        public EntidadMesas() { }
        // Constructor con todos los campos excepto HorarioID
        public EntidadMesas(int numeroMesa, int capacidad)
        {
            NumeroMesa = numeroMesa;
            Capacidad = capacidad;
        }
        // Constructor con todos los campos
        public EntidadMesas(int mesaID, int numeroMesa, int capacidad)
        {
            MesaID = mesaID;
            NumeroMesa = numeroMesa;
            Capacidad = capacidad;
        }
    }
}