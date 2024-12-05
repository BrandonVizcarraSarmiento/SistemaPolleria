using SistemaPolleria.common;
using SistemaPolleria.datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPolleria.negocios
{
    public class NegocioHorario
    {
        private DatosHorario _datosHorario = new DatosHorario();

        public DataTable ObtenerTodosHorariosN()
        {
            return _datosHorario.ObtenerTodosHorarios();
        }

        public int InsertarHorarioN(EntidadHorario horario)
        {
            if (string.IsNullOrEmpty(horario.DiaSemana))
            {
                MessageBox.Show("El día de la semana no puede estar vacío.");
                return 0;
            }

            if (horario.HoraInicio >= horario.HoraFin)
            {
                MessageBox.Show("La hora de inicio debe ser menor que la hora de fin.");
                return 0;
            }

            return _datosHorario.InsertarHorario(horario);
        }

        public int EditarHorarioN(EntidadHorario horario)
        {
            if (horario.HorarioID <= 0)
            {
                MessageBox.Show("ID de horario inválido.");
                return 0;
            }

            return _datosHorario.EditarHorario(horario);
        }

        public int EliminarHorarioN(int horarioID)
        {
            if (horarioID <= 0)
            {
                MessageBox.Show("ID de horario inválido.");
                return 0;
            }

            return _datosHorario.EliminarHorario(horarioID);
        }
    }
}
