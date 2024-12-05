using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.common
{
    public class EntidadEmpleado
    {
        public int EmpleadoID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaContratacion { get; set; }
        public decimal Salario { get; set; }

        // Constructor vacío
        public EntidadEmpleado() { }

        // Constructor con parámetros para inicializar una nueva instancia
        public EntidadEmpleado(int empleadoID, string nombre, string apellido, string dni, string telefono, string direccion, DateTime fechaContratacion, decimal salario)
        {
            EmpleadoID = empleadoID;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Telefono = telefono;
            Direccion = direccion;
            FechaContratacion = fechaContratacion;
            Salario = salario;
        }
    }
}
