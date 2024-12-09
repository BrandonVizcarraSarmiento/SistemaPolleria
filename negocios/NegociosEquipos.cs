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
    public class NegociosEquipos
    {
        private DatosEquipos _datosEquipos = new DatosEquipos();

        // Obtener todos los Equipos
        public DataTable ObtenerTodosEquiposN()
        {
            return _datosEquipos.ObtenerTodosEquipos();
        }
        // Insertar nuevo Equipo
        public int InsertarEquiposN(EntidadEquipos equipos)
        {
            // Validaciones
            if (string.IsNullOrEmpty(equipos.Nombre)) // Verifica si el nombre del equipo es válido
            {
                MessageBox.Show("El nombre del equipo es obligatorio.");
                return 0;
            }
            if (equipos.FechaCompra == DateTime.MinValue) // Verifica si la fecha de compra es válida
            {
                MessageBox.Show("La fecha de compra es obligatoria.");
                return 0;
            }
            if (equipos.FechaMantenimiento == DateTime.MinValue) // Verifica si la fecha de mantenimiento es válida
            {
                MessageBox.Show("La fecha de mantenimiento es obligatoria.");
                return 0;
            }

            // Insertar en la base de datos
            int numRes = _datosEquipos.InsertarEquipos(equipos);
            return numRes;
        }
        // Editar Equipo
        public int EditarEquiposN(EntidadEquipos equipos)
        {
            // Validaciones
            if (equipos.EquipoID <= 0) // Verifica si el ID del equipo es válido
            {
                MessageBox.Show("El ID del equipo debe ser mayor que cero.");
                return 0;
            }
            if (string.IsNullOrEmpty(equipos.Nombre)) // Verifica si el nombre del equipo es válido
            {
                MessageBox.Show("El nombre del equipo es obligatorio.");
                return 0;
            }
            if (equipos.FechaCompra == DateTime.MinValue) // Verifica si la fecha de compra es válida
            {
                MessageBox.Show("La fecha de compra es obligatoria.");
                return 0;
            }
            if (equipos.FechaMantenimiento == DateTime.MinValue) // Verifica si la fecha de mantenimiento es válida
            {
                MessageBox.Show("La fecha de mantenimiento es obligatoria.");
                return 0;
            }

            return _datosEquipos.EditarEquipos(equipos);
        }
        // Eliminar Equipo
        public int EliminarEquiposN(int equipoID)
        {
            return _datosEquipos.EliminarEquipos(equipoID);
        }

        // Obtener Equipos por nombre
        public DataTable ObtenerEquiposPorNombreN(string nombre)
        {
            return _datosEquipos.ObtenerEquiposPorNombre(nombre);
        }
    }
}