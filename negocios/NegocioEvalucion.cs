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
    internal class NegocioEvalucion
    {
        private DatosEvalucion _datosEvaluacion = new DatosEvalucion();

        // Obtener todas las evaluaciones
        public DataTable ObtenerTodasEvaluacionesN()
        {
            return _datosEvaluacion.ObtenerTodasEvaluaciones();
        }

        // Insertar nueva evaluación
        public int InsertarEvaluacionN(EntidadEvaluacion evaluacion)
        {
            // Validaciones
            if (evaluacion.Fecha == DateTime.MinValue)
            {
                MessageBox.Show("La fecha es inválida.");
                return 0;
            }

            if (evaluacion.Calificacion < 0 || evaluacion.Calificacion > 10)
            {
                MessageBox.Show("La calificación debe estar entre 0 y 10.");
                return 0;
            }

            if (string.IsNullOrWhiteSpace(evaluacion.Comentario))
            {
                MessageBox.Show("El comentario no puede estar vacío.");
                return 0;
            }

            return _datosEvaluacion.InsertarEvaluacion(evaluacion);
        }

        // Editar evaluación
        public int EditarEvaluacionN(EntidadEvaluacion evaluacion)
        {
            // Validaciones
            if (evaluacion.Fecha == DateTime.MinValue)
            {
                MessageBox.Show("La fecha es inválida.");
                return 0;
            }

            if (evaluacion.Calificacion < 0 || evaluacion.Calificacion > 10)
            {
                MessageBox.Show("La calificación debe estar entre 0 y 10.");
                return 0;
            }

            if (string.IsNullOrWhiteSpace(evaluacion.Comentario))
            {
                MessageBox.Show("El comentario no puede estar vacío.");
                return 0;
            }

            return _datosEvaluacion.EditarEvaluacion(evaluacion);
        }

        // Eliminar evaluación
        public int EliminarEvaluacionN(int idEvaluacion)
        {
            return _datosEvaluacion.EliminarEvaluacion(idEvaluacion);
        }

        // Buscar evaluaciones por nombre
        public DataTable ObtenerEvaluacionesPorNombreN(string nombreEmpleado)
        {
            return _datosEvaluacion.ObtenerEvaluacionesPorNombre(nombreEmpleado);
        }
    }
}
