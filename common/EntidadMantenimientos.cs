using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.common
{
    public class EntidadMantenimientos
    {
        public int MantenimientoID { get; set; }
        public int EquipoID { get; set; }
        public DateTime FechaMantenimiento { get; set; }
        public string Descripcion { get; set; }

        // Constructor vacío 
        public EntidadMantenimientos() { }
        // Constructor con todos los campos excepto HorarioID
        public EntidadMantenimientos(int equipoID, DateTime fechaMantenimiento, string descripcion)
        {
            EquipoID = equipoID;
            FechaMantenimiento = fechaMantenimiento;
            Descripcion = descripcion;
        }
        // Constructor con todos los campos
        public EntidadMantenimientos(int mantenimientoID, int equipoID, DateTime fechaMantenimiento, string descripcion)
        {
            MantenimientoID = mantenimientoID;
            EquipoID = equipoID;
            FechaMantenimiento = fechaMantenimiento;
            Descripcion = descripcion;
        }
    }
}
