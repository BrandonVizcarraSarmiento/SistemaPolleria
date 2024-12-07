using SistemaPolleria.common;
using SistemaPolleria.datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.negocios
{
    public class NegocioTurno
    {
        private DatosTurno _datosTurnos = new DatosTurno();

        // Obtener todos los turnos
        public DataTable ObtenerTodosLosTurnosN()
        {
            return _datosTurnos.ObtenerTodosLosTurnos();
        }

        // Insertar turno
        public int InsertarTurnoN(EntidadTurno turno)
        {
            // Validaciones
            if (string.IsNullOrEmpty(turno.NombreTurno))
            {
                throw new Exception("El nombre del turno no puede estar vacío.");
            }

            if (turno.HoraInicio >= turno.HoraFin)
            {
                throw new Exception("La hora de inicio debe ser menor que la hora de fin.");
            }

            return _datosTurnos.InsertarTurno(turno);
        }

        // Editar turno
        public int EditarTurnoN(EntidadTurno turno)
        {
            // Validaciones
            if (turno.TurnoID <= 0)
            {
                throw new Exception("El ID del turno no es válido.");
            }

            if (string.IsNullOrEmpty(turno.NombreTurno))
            {
                throw new Exception("El nombre del turno no puede estar vacío.");
            }

            if (turno.HoraInicio >= turno.HoraFin)
            {
                throw new Exception("La hora de inicio debe ser menor que la hora de fin.");
            }

            return _datosTurnos.EditarTurno(turno);
        }

        // Eliminar turno
        public int EliminarTurnoN(int turnoID)
        {
            if (turnoID <= 0)
            {
                throw new Exception("El ID del turno no es válido.");
            }

            return _datosTurnos.EliminarTurno(turnoID);
        }
        // Obtener turnos por nombre (filtro)
        public DataTable ObtenerTurnoPorNombreN(string nombreTurno)
        {
            // Llamamos a la capa de datos para obtener los turnos filtrados por nombre
            return _datosTurnos.ObtenerTurnoPorNombre(nombreTurno);
        }
    }
}
