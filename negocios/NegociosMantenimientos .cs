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
    public class NegociosMantenimientos
    {
        private DatosMantenimientos _datosMantenimientos = new DatosMantenimientos();

        // Obtener todos los mantenimientos
        public DataTable ObtenerTodosMantenimientosN()
        {
            return _datosMantenimientos.ObtenerTodosMantenimientos();
        }

        // Insertar un nuevo mantenimiento
        public int InsertarMantenimientosN(EntidadMantenimientos mantenimiento)
        {
            // Validaciones
            if (mantenimiento.EquipoID <= 0) // Verifica si el ID del equipo es válido
            {
                MessageBox.Show("El ID del equipo es obligatorio.");
                return 0;
            }
            if (mantenimiento.FechaMantenimiento == DateTime.MinValue) // Verifica si la fecha de mantenimiento es válida
            {
                MessageBox.Show("La fecha de mantenimiento es obligatoria.");
                return 0;
            }
            if (string.IsNullOrEmpty(mantenimiento.Descripcion)) // Verifica si la descripción es válida
            {
                MessageBox.Show("La descripción del mantenimiento es obligatoria.");
                return 0;
            }

            // Insertar en la base de datos
            int numRes = _datosMantenimientos.InsertarMantenimientos(mantenimiento);
            return numRes;
        }

        // Editar un mantenimiento
        public int EditarMantenimientosN(EntidadMantenimientos mantenimiento)
        {
            // Validaciones
            if (mantenimiento.MantenimientoID <= 0) // Verifica si el ID del mantenimiento es válido
            {
                MessageBox.Show("El ID del mantenimiento debe ser mayor que cero.");
                return 0;
            }
            if (mantenimiento.EquipoID <= 0) // Verifica si el ID del equipo es válido
            {
                MessageBox.Show("El ID del equipo es obligatorio.");
                return 0;
            }
            if (mantenimiento.FechaMantenimiento == DateTime.MinValue) // Verifica si la fecha de mantenimiento es válida
            {
                MessageBox.Show("La fecha de mantenimiento es obligatoria.");
                return 0;
            }
            if (string.IsNullOrEmpty(mantenimiento.Descripcion)) // Verifica si la descripción es válida
            {
                MessageBox.Show("La descripción del mantenimiento es obligatoria.");
                return 0;
            }

            return _datosMantenimientos.EditarMantenimientos(mantenimiento);
        }

        // Eliminar un mantenimiento por su ID
        public int EliminarMantenimientoN(int mantenimientoID)
        {
            return _datosMantenimientos.EliminarMantenimiento(mantenimientoID);
        }

        // Obtener mantenimientos por el ID del equipo
        public DataTable ObtenerMantenimientosPorEquipoIDN(int equipoID)
        {
            return _datosMantenimientos.ObtenerMantenimientosPorEquipoID(equipoID);
        }
    }
}