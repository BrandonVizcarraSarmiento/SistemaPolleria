using SistemaPolleria.common;
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
    public partial class FrmEditarTurno : Form
    {
        private NegocioTurno _negocioTurno = new NegocioTurno();
        private int _turnoID;
        public FrmEditarTurno(int turnoID, string nombreTurno, TimeSpan horaInicio, TimeSpan horaFin)
        {
            InitializeComponent();
            _turnoID = turnoID;

            // Cargar los controles con los datos pasados
            cboNombreTurno.SelectedItem = nombreTurno;
            dtpHoraInicioTurno.Value = DateTime.Today.Add(horaInicio); // Añadir solo el TimeSpan
            dtpHoraFinTurno.Value = DateTime.Today.Add(horaFin);
        }

        private void btnEditarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos los datos del formulario
                string nombreTurno = cboNombreTurno.SelectedItem.ToString();
                TimeSpan horaInicio = dtpHoraInicioTurno.Value.TimeOfDay;
                TimeSpan horaFin = dtpHoraFinTurno.Value.TimeOfDay;

                // Validamos que la hora de inicio sea menor que la hora de fin
                if (horaInicio >= horaFin)
                {
                    MessageBox.Show("La hora de inicio debe ser menor que la hora de fin.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Creamos la instancia de la entidad Turno con los datos del formulario
                EntidadTurno turnoEditado = new EntidadTurno
                {
                    TurnoID = _turnoID,
                    NombreTurno = nombreTurno,
                    HoraInicio = horaInicio,
                    HoraFin = horaFin
                };

                // Llamamos al método de negocio para actualizar el turno
                int resultado = _negocioTurno.EditarTurnoN(turnoEditado);

                if (resultado > 0)
                {
                    MessageBox.Show("Turno actualizado correctamente.");
                    this.Close(); // Cerramos el formulario
                }
                else
                {
                    MessageBox.Show("Error al actualizar el turno.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el turno: " + ex.Message);
            }
        }
    }
}
