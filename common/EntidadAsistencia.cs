using System;

namespace SistemaPolleria.Common.Asistencia
{
    public class EntidadAsistencia
    {
        public int AsistenciaID { get; set; }
        public int EmpleadoID { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }

        // Constructor vacío
        public EntidadAsistencia() { }

        // Constructor con todos los campos excepto AsistenciaID (por ser autonumérico)
        public EntidadAsistencia(int empleadoID, DateTime fecha, TimeSpan horaEntrada, TimeSpan horaSalida)
        {
            EmpleadoID = empleadoID;
            Fecha = fecha;
            HoraEntrada = horaEntrada;
            HoraSalida = horaSalida;
        }

        // Constructor con todos los campos
        public EntidadAsistencia(int asistenciaID, int empleadoID, DateTime fecha, TimeSpan horaEntrada, TimeSpan horaSalida)
        {
            AsistenciaID = asistenciaID;
            EmpleadoID = empleadoID;
            Fecha = fecha;
            HoraEntrada = horaEntrada;
            HoraSalida = horaSalida;
        }
    }
}
