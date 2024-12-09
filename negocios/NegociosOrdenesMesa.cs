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
    public class NegociosOrdenesMesa
    {
        private DatosOrdenesMesa _datosOrdenesMesa = new DatosOrdenesMesa();
        // Obtener todos los OrdenesMesa
        public DataTable ObtenerTodosOrdenesMesaN()
        {
            return _datosOrdenesMesa.ObtenerTodosOrdenesMesa();
        }
        // Insertar nuevo OrdenesMesa
        public int InsertarOrdenesMesaN(EntidadOrdenesMesa ordenesMesa)
        {
            // Validaciones
            if (ordenesMesa.FechaOrden == DateTime.MinValue)
            {
                MessageBox.Show("El número de la mesa debe ser mayor que cero.");
                return 0;
            }
            // Insertar en la base de datos
            int numRes = _datosOrdenesMesa.InsertarOrdenesMesa(ordenesMesa);
            return numRes;
        }

        // Editar OrdenesMesa
        public int EditarOrdenesMesaN(EntidadOrdenesMesa ordenesMesa)
        {
            // Validaciones
            if (ordenesMesa.FechaOrden == DateTime.MinValue) // Validar si el número de mesa es válido
            {
                MessageBox.Show("El número de la mesa debe ser mayor que cero.");
                return 0;
            }

            return _datosOrdenesMesa.EditarOrdenesMesa(ordenesMesa);
        }
        // Eliminar OrdenesMesa
        public int EliminarOrdenesMesaN(int OrdenID)
        {
            return _datosOrdenesMesa.EliminarOrdenesMesa(OrdenID);
        }
        public DataTable ObtenerOrdenesMesaPorFechaOrdenN(DateTime fechaOrden)
        {
            return _datosOrdenesMesa.ObtenerOrdenesMesaPorFechaOrden(fechaOrden);
        }
    }
}
