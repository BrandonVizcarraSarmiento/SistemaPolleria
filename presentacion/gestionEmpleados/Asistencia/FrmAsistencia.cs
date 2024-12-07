using SistemaPolleria.negocio.asistencia;
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
using SistemaPolleria.presentacion.gestion_empleados.Asistencia;


namespace SistemaPolleria.presentacion.gestion_empleados.carpetas
{
    public partial class FrmAsistencia : Form
    {
        private NegocioAsistencia _negocioAsistencia = new NegocioAsistencia();
        public FrmAsistencia()
        {
            InitializeComponent();
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
        
        private void FrmAsistencia_Load(object sender, EventArgs e)
        {
            CargarAsistencias();
        }

        private void btnNuevoAsistencia_Click(object sender, EventArgs e)
        {
            FrmAgregarAsistencia agregarForm = new FrmAgregarAsistencia();
            agregarForm.ShowDialog();
            CargarAsistencias();
        }

        private void btnEditarAsistencia_Click(object sender, EventArgs e)
        {
            if (dgvAsistencia.SelectedRows.Count > 0)
            {
                // Obtén el ID de la asistencia de la fila seleccionada
                int asistenciaID = Convert.ToInt32(dgvAsistencia.SelectedRows[0].Cells["AsistenciaID"].Value);
                int empleadoID = Convert.ToInt32(dgvAsistencia.SelectedRows[0].Cells["EmpleadoID"].Value);
                DateTime fecha = Convert.ToDateTime(dgvAsistencia.SelectedRows[0].Cells["Fecha"].Value);

                // Cambiar a TimeSpan para las horas
                TimeSpan horaEntrada = (TimeSpan)dgvAsistencia.SelectedRows[0].Cells["HoraEntrada"].Value;
                TimeSpan horaSalida = (TimeSpan)dgvAsistencia.SelectedRows[0].Cells["HoraSalida"].Value;

                // Abre el formulario para editar la asistencia
                FrmEditarAsistencia editarForm = new FrmEditarAsistencia(asistenciaID, empleadoID, fecha, horaEntrada, horaSalida);
                editarForm.ShowDialog();

                // Recarga los datos después de editar la asistencia
                CargarAsistencias();
            }
            else
            {
                MessageBox.Show("Seleccione un registro para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarAsistencia_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dgvAsistencia.SelectedRows.Count > 0)
            {
                // Pregunta al usuario si realmente desea eliminar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar esta asistencia?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    // Obtiene el id de la asistencia seleccionada
                    int asistenciaID = Convert.ToInt32(dgvAsistencia.SelectedRows[0].Cells["AsistenciaID"].Value);

                    // Llama al método para eliminar la asistencia
                    NegocioAsistencia negocioAsistencia = new NegocioAsistencia();
                    negocioAsistencia.EliminarAsistenciaN(asistenciaID);

                    // Vuelve a cargar los datos en el DataGridView
                    CargarAsistencias();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una asistencia para eliminar.");
            }
        }

        private void btnBuscarAsistencias_Click(object sender, EventArgs e)
        {
            string nombreEmpleado = txtBuscarAsistencias.Text.Trim();

            if (!string.IsNullOrEmpty(nombreEmpleado))
            {
                DataTable asistencias = _negocioAsistencia.ObtenerAsistenciaPorNombreN(nombreEmpleado);

                if (asistencias != null && asistencias.Rows.Count > 0)
                {
                    dgvAsistencia.DataSource = asistencias;
                }
                else
                {
                    MessageBox.Show("No se encontraron asistencias para el empleado ingresado.");
                }
            }
            else
            {
                // Cargar todas las asistencias si el campo de búsqueda está vacío
                DataTable todasAsistencias = _negocioAsistencia.ObtenerTodasAsistenciasN();

                if (todasAsistencias != null && todasAsistencias.Rows.Count > 0)
                {
                    dgvAsistencia.DataSource = todasAsistencias;
                }
                else
                {
                    MessageBox.Show("No hay asistencias registradas.");
                }
            }
        }
    }
}
