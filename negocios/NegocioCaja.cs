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
    internal class NegocioCaja
    {
        private DatosCaja _datosCaja = new DatosCaja();

        // Obtener todas las cajas
        public DataTable ObtenerTodasCajasN()
        {
            return _datosCaja.ObtenerTodasCajas();
        }

        // Insertar nueva caja
        public int InsertarCajaN(EntidadCaja caja)
        {
            // Validaciones
            if (caja.Fecha == DateTime.MinValue)
            {
                MessageBox.Show("La fecha es inválida.");
                return 0;
            }

            if (caja.Total < 0)
            {
                MessageBox.Show("El total no puede ser negativo.");
                return 0;
            }

            return _datosCaja.InsertarCaja(caja);
        }

        // Editar caja
        public int EditarCajaN(EntidadCaja caja)
        {
            // Validaciones
            if (caja.Fecha == DateTime.MinValue)
            {
                MessageBox.Show("La fecha es inválida.");
                return 0;
            }

            if (caja.Total < 0)
            {
                MessageBox.Show("El total no puede ser negativo.");
                return 0;
            }

            return _datosCaja.EditarCaja(caja);
        }

        // Eliminar caja
        public int EliminarCajaN(int cajaID)
        {
            return _datosCaja.EliminarCaja(cajaID);
        }

        // Buscar cajas por fecha
        public DataTable ObtenerCajasPorFechaN(DateTime fechaInicio, DateTime fechaFin)
        {
            return _datosCaja.ObtenerCajasPorFecha(fechaInicio, fechaFin);
        }
    }
}
