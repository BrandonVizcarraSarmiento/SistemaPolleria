using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.common
{
    public class EntidadEquipos
    {
        public int EquipoID { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaMantenimiento { get; set; }

        // Constructor vacío 
        public EntidadEquipos() { }
        // Constructor con todos los campos excepto HorarioID
        public EntidadEquipos(string nombre, DateTime fechaCompra, DateTime fechaMantenimiento)
        {
            Nombre = nombre;
            FechaCompra = fechaCompra;
            FechaMantenimiento = fechaMantenimiento;
        }
        // Constructor con todos los campos
        public EntidadEquipos(int equipoID, string nombre, DateTime fechaCompra, DateTime fechaMantenimiento)
        {
            EquipoID = equipoID;
            Nombre = nombre;
            FechaCompra = fechaCompra;
            FechaMantenimiento = fechaMantenimiento;
        }
    }
}