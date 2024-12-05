using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.common
{
    public class EntidadHorario
    {
        public int HorarioID { get; set; }
        public int EmpleadoID { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public string DiaSemana { get; set; }

        // Constructor vacío
        public EntidadHorario() { }

        // Constructor con todos los campos excepto HorarioID
        public EntidadHorario(int empleadoID, TimeSpan horaInicio, TimeSpan horaFin, string diaSemana)
        {
            EmpleadoID = empleadoID;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
            DiaSemana = diaSemana;
        }

        // Constructor con todos los campos
        public EntidadHorario(int horarioID, int empleadoID, TimeSpan horaInicio, TimeSpan horaFin, string diaSemana)
        {
            HorarioID = horarioID;
            EmpleadoID = empleadoID;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
            DiaSemana = diaSemana;
        }
    }
}
