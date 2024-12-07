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

namespace SistemaPolleria.presentacion.gestion_empleados.turnos
{
    public partial class FrmTurno : Form
    {
        private NegocioTurno _negocioTurno = new NegocioTurno();
        public FrmTurno()
        {
            InitializeComponent();
        }
        private void CargarTurno()
        {
            // Llamamos al método para obtener todas las asistencias
            DataTable asistencias = _negocioTurno.ObtenerTodosLosTurnosN();

            // Verificamos que no haya error o que el DataTable no esté vacío
            if (asistencias != null && asistencias.Rows.Count > 0)
            {
                // Vinculamos el DataTable al DataGridView
                dgvTurno.DataSource = asistencias;
            }
            else
            {
                MessageBox.Show("No se encontraron asistencias.");
            }
        }

        private void FrmTurno_Load(object sender, EventArgs e)
        {
            CargarTurno();
        }

        private void btnNuevoTurno_Click(object sender, EventArgs e)
        {
            FrmAgregarTurno agregarForm = new FrmAgregarTurno();
            agregarForm.ShowDialog();
            CargarTurno();
        }

        private void btnEditarTurno_Click(object sender, EventArgs e)
        {
            if (dgvTurno.SelectedRows.Count > 0)
            {
                // Obtenemos la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvTurno.SelectedRows[0];

                // Extraemos los valores del turno
                int turnoID = Convert.ToInt32(filaSeleccionada.Cells["TurnoID"].Value);
                string nombreTurno = filaSeleccionada.Cells["NombreTurno"].Value.ToString();
                TimeSpan horaInicio = (TimeSpan)filaSeleccionada.Cells["HoraInicio"].Value;
                TimeSpan horaFin = (TimeSpan)filaSeleccionada.Cells["HoraFin"].Value;

                // Abrimos el formulario de edición con los datos del turno
                FrmEditarTurno editarTurnoForm = new FrmEditarTurno(turnoID, nombreTurno, horaInicio, horaFin);
                editarTurnoForm.ShowDialog();

                // Refresca los datos al cerrar el formulario
                CargarTurno();
            }
            else
            {
                MessageBox.Show("Seleccione un turno para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificamos si se ha seleccionado una fila en el DataGridView
                if (dgvTurno.SelectedRows.Count > 0)
                {
                    // Obtenemos el ID del turno seleccionado
                    int turnoID = Convert.ToInt32(dgvTurno.SelectedRows[0].Cells["TurnoID"].Value);

                    // Confirmamos con el usuario si realmente quiere eliminar el turno
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este turno?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        // Llamamos al método del negocio para eliminar el turno
                        int resultado = _negocioTurno.EliminarTurnoN(turnoID);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Turno eliminado correctamente.");
                            CargarTurno(); // Refrescamos los datos
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el turno.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un turno para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el turno: " + ex.Message);
            }
        }

        private void btnBuscarTurno_Click(object sender, EventArgs e)
        {
            string nombreTurno = txtBuscarTurno.Text.Trim(); // Obtenemos el texto del campo de búsqueda

            if (!string.IsNullOrEmpty(nombreTurno))
            {
                // Buscar turnos por nombre
                DataTable turnos = _negocioTurno.ObtenerTurnoPorNombreN(nombreTurno);

                if (turnos != null && turnos.Rows.Count > 0)
                {
                    // Mostrar los resultados en el DataGridView
                    dgvTurno.DataSource = turnos;
                }
                else
                {
                    MessageBox.Show("No se encontraron turnos con el nombre ingresado.");
                }
            }
            else
            {
                // Si el campo está vacío, cargar todos los turnos
                DataTable todosTurnos = _negocioTurno.ObtenerTodosLosTurnosN();

                if (todosTurnos != null && todosTurnos.Rows.Count > 0)
                {
                    // Mostrar todos los turnos en el DataGridView
                    dgvTurno.DataSource = todosTurnos;
                }
                else
                {
                    MessageBox.Show("No hay turnos registrados.");
                }
            }
        }
    }
}
