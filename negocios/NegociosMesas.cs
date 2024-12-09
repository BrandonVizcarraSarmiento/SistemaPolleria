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
    public class NegociosMesas
    {
        private DatosMesas _datosMesas = new DatosMesas();
        // Obtener todos los Mesas
        public DataTable ObtenerTodosMesasN()
        {
            return _datosMesas.ObtenerTodosMesas();
        }
        // Insertar nuevo Mesas
        public int InsertarMesasN(EntidadMesas mesas)
        {
            // Validaciones
            if (mesas.NumeroMesa <= 0) // Verifica si el número de mesa es válido
            {
                MessageBox.Show("El número de la mesa debe ser mayor que cero.");
                return 0;
            }
            // Insertar en la base de datos
            int numRes = _datosMesas.InsertarMesas(mesas);
            return numRes;
        }
        // Editar Mesas
        public int EditarMesasN(EntidadMesas mesas)
        {
            // Validaciones
            if (mesas.NumeroMesa <= 0) // Validar si el número de mesa es válido
            {
                MessageBox.Show("El número de la mesa debe ser mayor que cero.");
                return 0;
            }

            return _datosMesas.EditarMesas(mesas);
        }
        // Eliminar Mesas
        public int EliminarMesasN(int MesaID)
        {
            return _datosMesas.EliminarMesas(MesaID);
        }
        public DataTable ObtenerMesasPorNumeroMesaN(int numeroMesa)
        {
            return _datosMesas.ObtenerMesasPorNumeroMesa(numeroMesa);
        }
    }
}
