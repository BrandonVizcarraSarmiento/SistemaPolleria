using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPolleria.Common.Asistencia;
 // Aquí debes tener el espacio de nombres de la clase de la entidad Asistencia


using SistemaPolleria.Data.Asistencia;

namespace SenatiPractica.negocio.asistencia
{
    public class NegocioAsistencia
    {
        private DatosAsistencia _datosAsistencia = new DatosAsistencia();

        // Insertar nueva asistencia
        public int InsertarAsistenciaN(EntidadAsistencia asistencia)
        {
            // Validaciones
            if (asistencia.Fecha == DateTime.MinValue)
            {
                MessageBox.Show("La fecha es inválida.");
                return 0;
            }

            if (asistencia.HoraEntrada == TimeSpan.Zero || asistencia.HoraSalida == TimeSpan.Zero)
            {
                MessageBox.Show("Las horas de entrada y salida no pueden ser cero.");
                return 0;
            }

            // Insertar en la base de datos
            int numRes = _datosAsistencia.InsertarAsistencia(asistencia);
            return numRes;
        }

        // Obtener todas las asistencias
        public DataTable ObtenerTodasAsistenciasN()
        {
            return _datosAsistencia.ObtenerTodasAsistencias();
        }



        // Editar asistencia
        public int EditarAsistenciaN(EntidadAsistencia asistencia)
        {
            // Validaciones
            if (asistencia.Fecha == DateTime.MinValue)
            {
                MessageBox.Show("La fecha es inválida.");
                return 0;
            }

            if (asistencia.HoraEntrada == TimeSpan.Zero || asistencia.HoraSalida == TimeSpan.Zero)
            {
                MessageBox.Show("Las horas de entrada y salida no pueden ser cero.");
                return 0;
            }

            return _datosAsistencia.EditarAsistencia(asistencia);
        }

        // Eliminar asistencia
        public int EliminarAsistenciaN(int idAsistencia)
        {
            return _datosAsistencia.EliminarAsistencia(idAsistencia);
        }
    }
}
