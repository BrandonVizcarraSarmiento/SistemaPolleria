using SenatiPractica.negocio.asistencia;
using SistemaPolleria.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace SistemaPolleria.presentacion.gestion_empleados.carpetas
{
    public partial class FrmAsistencia : Form
    {
        private NegocioAsistencia _negocioAsistencia = new NegocioAsistencia();
        public FrmAsistencia()
        {
            InitializeComponent();
            ConnectionString.Singleton.InitializeFromConfig("PolleriaDB");


        }

        private void CargarAsistencias()
        {
            // Llamamos al método para obtener todas las asistencias
            DataTable asistencias = _negocioAsistencia.ObtenerTodasAsistenciasN();

            // Verificamos que no haya error o que el DataTable no esté vacío
            if (asistencias != null && asistencias.Rows.Count > 0)
            {
                // Vinculamos el DataTable al DataGridView
                dgvAsistencia.DataSource = asistencias;
            }
            else
            {
                MessageBox.Show("No se encontraron asistencias.");
            }
        }

        private void dgvAsistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void FrmAsistencia_Load(object sender, EventArgs e)
        {
            CargarAsistencias();
        }
    }
}
