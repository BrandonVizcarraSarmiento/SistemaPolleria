using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.common
{
    public class EntidadEvaluacion
    {
        public int EvaluacionID { get; set; }
        public int EmpleadoID { get; set; }
        public DateTime Fecha { get; set; }
        public int Calificacion { get; set; }
        public string Comentario { get; set; }

        // Constructor vacío
        public EntidadEvaluacion() { }

        // Constructor con todos los campos excepto EvaluacionID (por ser autonumérico)
        public EntidadEvaluacion(int empleadoID, DateTime fecha, int calificacion, string comentario)
        {
            EmpleadoID = empleadoID;
            Fecha = fecha;
            Calificacion = calificacion;
            Comentario = comentario;
        }

        // Constructor con todos los campos
        public EntidadEvaluacion(int evaluacionID, int empleadoID, DateTime fecha, int calificacion, string comentario)
        {
            EvaluacionID = evaluacionID;
            EmpleadoID = empleadoID;
            Fecha = fecha;
            Calificacion = calificacion;
            Comentario = comentario;
        }
    }
}
