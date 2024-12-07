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

namespace SistemaPolleria.presentacion.gestion_empleados.evaluciones
{
    public partial class FrmEvalucion : Form
    {
        private NegocioEvalucion _negocioEvalucion = new NegocioEvalucion();
        public FrmEvalucion()
        {
            InitializeComponent();
        }
        private void CargarEvalucion()
        {
            // Llamamos al método para obtener todas las evaluaciones
            DataTable evaluacion = _negocioEvalucion.ObtenerTodasEvaluacionesN();

            // Verificamos que no haya error o que el DataTable no esté vacío
            if (evaluacion != null && evaluacion.Rows.Count > 0)
            {
                // Vinculamos el DataTable al DataGridView
                dgvEvalucion.DataSource = evaluacion;
            }
            else
            {
                MessageBox.Show("No se encontraron evaluaciones.");
            }
        }
        private void FrmEvalucion_Load(object sender, EventArgs e)
        {
            CargarEvalucion();
        }

        private void btnNuevoEvalucion_Click(object sender, EventArgs e)
        {
            FrmAgregarEvalucion agregarForm = new FrmAgregarEvalucion();
            agregarForm.ShowDialog();
            CargarEvalucion();
        }
    }
}
