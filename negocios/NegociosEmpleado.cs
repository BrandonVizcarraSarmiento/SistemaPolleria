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
    public class NegociosEmpleado
    {
        private DatosEmpleado _datosEmpleado = new DatosEmpleado();

        // Obtener todos los empleados
        public DataTable ObtenerTodosEmpleadosN()
        {
            return _datosEmpleado.ObtenerTodosEmpleados();
        }
        // Insertar nuevo empleado
        public int InsertarEmpleadoN(EntidadEmpleado empleado)
        {
            // Validaciones
            if (string.IsNullOrEmpty(empleado.Nombre))
            {
                MessageBox.Show("El nombre del empleado es obligatorio.");
                return 0;
            }

            // Insertar en la base de datos
            int numRes = _datosEmpleado.InsertarEmpleado(empleado);
            return numRes;
        }
        // Editar empleado
        public int EditarEmpleadoN(EntidadEmpleado empleado)
        {
            // Validaciones
            if (string.IsNullOrEmpty(empleado.Nombre))
            {
                MessageBox.Show("El nombre del empleado es obligatorio.");
                return 0;
            }

            return _datosEmpleado.EditarEmpleado(empleado);
        }

        // Eliminar empleado
        public int EliminarEmpleadoN(int empleadoID)
        {
            return _datosEmpleado.EliminarEmpleado(empleadoID);
        }
        public DataTable ObtenerEmpleadoPorNombreN(string nombre)
        {
            return _datosEmpleado.ObtenerEmpleadoPorNombre(nombre);
        }
    }
}
