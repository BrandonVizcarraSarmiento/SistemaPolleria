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
    public partial class FrmAgregarTurno : Form
    {
        private NegocioTurno _negocioTurno = new NegocioTurno();
        public FrmAgregarTurno()
        {
            InitializeComponent();
        }

        private void btnGuardarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturamos los valores del formulario
                string nombreTurno = cboNombreTurno.Text.Trim();
                TimeSpan horaInicioTurno = dtpHoraInicioTurno.Value.TimeOfDay;
                TimeSpan horaFinTurno = dtpHoraFinTurno.Value.TimeOfDay;

                // Redondeamos la hora de entrada y salida para evitar los milisegundos
                horaInicioTurno = new TimeSpan(horaInicioTurno.Hours, horaInicioTurno.Minutes, horaInicioTurno.Seconds);
                horaFinTurno = new TimeSpan(horaFinTurno.Hours, horaFinTurno.Minutes, horaFinTurno.Seconds);

                // Creamos la entidad de turno
                EntidadTurno nuevaTurno = new EntidadTurno(nombreTurno, horaInicioTurno, horaFinTurno);

                // Validamos que la hora de inicio sea menor que la hora de fin
                if (horaInicioTurno >= horaFinTurno)
                {
                    MessageBox.Show("La hora de inicio debe ser menor que la hora de fin.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insertamos la turno usando el negocio
                int resultado = _negocioTurno.InsertarTurnoN(nuevaTurno);

                // Verificamos el resultado
                if (resultado > 0)
                {
                    MessageBox.Show("Turno registrado correctamente.");
                    this.Close(); // Cerramos el formulario
                }
                else
                {
                    MessageBox.Show("Hubo un problema al registrar el turno.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
