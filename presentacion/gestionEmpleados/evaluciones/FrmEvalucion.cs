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

        private void btnEditarEvalucion_Click(object sender, EventArgs e)
        {
            if (dgvEvalucion.SelectedRows.Count > 0)
            {
                // Obtén los valores de la fila seleccionada
                int evalucionID = Convert.ToInt32(dgvEvalucion.SelectedRows[0].Cells["EvaluacionID"].Value);
                int empleadoID = Convert.ToInt32(dgvEvalucion.SelectedRows[0].Cells["EmpleadoID"].Value);
                DateTime fecha = Convert.ToDateTime(dgvEvalucion.SelectedRows[0].Cells["Fecha"].Value);
                string calificacion = dgvEvalucion.SelectedRows[0].Cells["Calificacion"].Value.ToString();
                string comentario = dgvEvalucion.SelectedRows[0].Cells["Comentario"].Value.ToString();

                // Abre el formulario de edición pasando los valores seleccionados
                FrmEditarEvalucion editarForm = new FrmEditarEvalucion(evalucionID, empleadoID, fecha, calificacion, comentario);
                editarForm.ShowDialog();

                // Recarga las evaluaciones después de editar
                CargarEvalucion();
            }
            else
            {
                MessageBox.Show("Seleccione una evaluación para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarEvalucion_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dgvEvalucion.SelectedRows.Count > 0)
            {
                // Pregunta al usuario si realmente desea eliminar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar esta evaluación?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Obtiene el ID de la evaluación seleccionada
                        int evalucionID = Convert.ToInt32(dgvEvalucion.SelectedRows[0].Cells["EvaluacionID"].Value);

                        // Llama al método para eliminar la evaluación
                        NegocioEvalucion negocioEvalucion = new NegocioEvalucion();
                        negocioEvalucion.EliminarEvaluacionN(evalucionID);

                        // Vuelve a cargar los datos en el DataGridView
                        CargarEvalucion();
                        MessageBox.Show("Evaluación eliminada correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la evaluación: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una evaluación para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarEvalucion_Click(object sender, EventArgs e)
        {
            string criterioBusqueda = txtBuscarEvalucion.Text.Trim(); // Toma el criterio ingresado

            if (!string.IsNullOrEmpty(criterioBusqueda))
            {
                // Busca las evaluaciones según el criterio ingresado
                DataTable evaluaciones = _negocioEvalucion.ObtenerEvaluacionesPorNombreN(criterioBusqueda);

                if (evaluaciones != null && evaluaciones.Rows.Count > 0)
                {
                    // Si encuentra resultados, los muestra en el DataGridView
                    dgvEvalucion.DataSource = evaluaciones;
                }
                else
                {
                    MessageBox.Show("No se encontraron evaluaciones para el criterio ingresado.");
                }
            }
            else
            {
                // Si no se ingresó criterio, se cargan todas las evaluaciones
                DataTable todasEvaluaciones = _negocioEvalucion.ObtenerTodasEvaluacionesN();

                if (todasEvaluaciones != null && todasEvaluaciones.Rows.Count > 0)
                {
                    dgvEvalucion.DataSource = todasEvaluaciones;
                }
                else
                {
                    MessageBox.Show("No hay evaluaciones registradas.");
                }
            }
        }
    }
}
