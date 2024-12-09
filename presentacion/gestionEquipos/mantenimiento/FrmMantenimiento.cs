using SistemaPolleria.negocio.asistencia;
using SistemaPolleria.negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPolleria.presentacion.gestionEquipos.mantenimiento
{
    public partial class FrmMantenimiento : Form
    {
        private NegociosMantenimientos _negociosMantenimientos = new NegociosMantenimientos();
        public FrmMantenimiento()
        {
            InitializeComponent();
        }
        private void CargarMantenimiento()
        {
            // Llamamos al método para obtener todos los mantenimientos
            DataTable mantenimientos = _negociosMantenimientos.ObtenerTodosMantenimientosN();

            // Verificamos que no haya error o que el DataTable no esté vacío
            if (mantenimientos != null && mantenimientos.Rows.Count > 0)
            {
                // Vinculamos el DataTable al DataGridView
                dgvMantenimiento.DataSource = mantenimientos;
            }
            else
            {
                MessageBox.Show("No se encontraron mantenimientos.");
            }
        }
        private void FrmMantenimiento_Load(object sender, EventArgs e)
        {
            CargarMantenimiento();
        }
    }
}
