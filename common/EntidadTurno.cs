using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.common
{
    public class EntidadTurno
    {
        public int TurnoID { get; set; }
        public string NombreTurno { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }

        // Constructor vacío
        public EntidadTurno() { }

        // Constructor con todos los campos
        public EntidadTurno(int turnoID, string nombreTurno, TimeSpan horaInicio, TimeSpan horaFin)
        {
            TurnoID = turnoID;
            NombreTurno = nombreTurno;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }

        // Constructor sin TurnoID (para insertar)
        public EntidadTurno(string nombreTurno, TimeSpan horaInicio, TimeSpan horaFin)
        {
            NombreTurno = nombreTurno;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }
    }
}
