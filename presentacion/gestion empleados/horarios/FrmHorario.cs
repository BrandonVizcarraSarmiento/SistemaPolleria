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

namespace SistemaPolleria.presentacion.gestion_empleados.horarios
{
    public partial class FrmHorario : Form
    {
        private NegocioHorario _negocioHorario = new NegocioHorario();
        public FrmHorario()
        {
            InitializeComponent();
        }
        private void CargarHorarios()
        {
            // Llamamos al método para obtener todas los horarios
            DataTable horarios = _negocioHorario.ObtenerTodosHorariosN();

            // Verificamos que no haya error o que el DataTable no esté vacío
            if (horarios != null && horarios.Rows.Count > 0)
            {
                // Vinculamos el DataTable al DataGridView
                dgvHorario.DataSource = horarios;
            }
            else
            {
                MessageBox.Show("No se encontraron horarios.");
            }
        }
        private void FrmHorario_Load(object sender, EventArgs e)
        {
            CargarHorarios();
        }

        private void btnNuevoHorario_Click(object sender, EventArgs e)
        {
            FrmAgregarHorario agregarHorarioForm = new FrmAgregarHorario();
            agregarHorarioForm.ShowDialog();
            CargarHorarios(); // Refresca los datos al volver
        }

        private void btnEditarHorario_Click(object sender, EventArgs e)
        {
            if (dgvHorario.SelectedRows.Count > 0)
            {
                // Obtenemos la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvHorario.SelectedRows[0];

                // Extraemos los valores del horario
                int horarioID = Convert.ToInt32(filaSeleccionada.Cells["HorarioID"].Value);
                int empleadoID = Convert.ToInt32(filaSeleccionada.Cells["EmpleadoID"].Value);
                string diaSemana = filaSeleccionada.Cells["DiaSemana"].Value.ToString();
                TimeSpan horaInicio = (TimeSpan)filaSeleccionada.Cells["HoraInicio"].Value;
                TimeSpan horaFin = (TimeSpan)filaSeleccionada.Cells["HoraFin"].Value;

                // Abrimos el formulario de edición con los datos del horario
                FrmEditarHorario editarHorarioForm = new FrmEditarHorario(horarioID, empleadoID, diaSemana, horaInicio, horaFin);
                editarHorarioForm.ShowDialog();

                // Refresca los datos al cerrar el formulario
                CargarHorarios();
            }
            else
            {
                MessageBox.Show("Seleccione un horario para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificamos si se ha seleccionado una fila en el DataGridView
                if (dgvHorario.SelectedRows.Count > 0)
                {
                    // Obtenemos el ID del horario seleccionado
                    int horarioID = Convert.ToInt32(dgvHorario.SelectedRows[0].Cells["HorarioID"].Value);

                    // Confirmamos con el usuario si realmente quiere eliminar el horario
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este horario?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        // Llamamos al método del negocio para eliminar el horario
                        int resultado = _negocioHorario.EliminarHorarioN(horarioID);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Horario eliminado correctamente.");
                            CargarHorarios(); // Refrescamos los datos
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el horario.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un horario para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el horario: " + ex.Message);
            }
        }

        private void btnBuscarHorario_Click(object sender, EventArgs e)
        {

        }
    }
}
