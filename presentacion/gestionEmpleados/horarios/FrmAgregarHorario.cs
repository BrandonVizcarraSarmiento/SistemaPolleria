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

namespace SistemaPolleria.presentacion.gestion_empleados.horarios
{
    public partial class FrmAgregarHorario : Form
    {
        private NegocioHorario _negocioHorario = new NegocioHorario();
        private NegociosEmpleado _negocioEmpleado = new NegociosEmpleado();
        public FrmAgregarHorario()
        {
            InitializeComponent();
        }
        private void CargarEmpleados()
        {
            try
            {
                // Obtenemos la lista de empleados desde la capa de negocio
                DataTable empleados = _negocioEmpleado.ObtenerTodosEmpleadosN();

                // Verificamos que no esté vacío
                if (empleados != null && empleados.Rows.Count > 0)
                {
                    // Concatenar el nombre y apellido de los empleados si deseas mostrar el nombre completo
                    foreach (DataRow row in empleados.Rows)
                    {
                        string nombreCompleto = row["Nombre"].ToString() + " " + row["Apellido"].ToString();
                        row["Nombre"] = nombreCompleto; // Agregar una nueva columna de nombre completo
                    }

                    // Asignamos al ComboBox los empleados
                    cboEmpleado.DisplayMember = "Nombre";  // Mostrar nombre completo
                    cboEmpleado.ValueMember = "EmpleadoID"; // Guardar el ID del empleado
                    cboEmpleado.DataSource = empleados;    // Asignamos el DataTable al ComboBox
                }
                else
                {
                    MessageBox.Show("No se encontraron empleados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message);
            }
        }
        private void FrmAgregarHorario_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }
        private void btnGuardarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturamos los valores del formulario
                int empleadoID = Convert.ToInt32(cboEmpleado.SelectedValue); // Obtenemos el ID del empleado seleccionado
                string diaSemana = cboDiaSemana.SelectedItem.ToString(); // Obtenemos el día de la semana seleccionado

                // Obtenemos la hora de inicio y fin redondeadas
                TimeSpan horaInicio = dtpHoraInicioHorario.Value.TimeOfDay;
                TimeSpan horaFin = dtpHoraFinHorario.Value.TimeOfDay;

                // Redondeamos la hora de inicio y fin para evitar los milisegundos
                horaInicio = new TimeSpan(horaInicio.Hours, horaInicio.Minutes, horaInicio.Seconds);
                horaFin = new TimeSpan(horaFin.Hours, horaFin.Minutes, horaFin.Seconds);

                // Validamos que la hora de inicio sea menor que la hora de fin
                if (horaInicio >= horaFin)
                {
                    MessageBox.Show("La hora de inicio debe ser menor que la hora de fin.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Creamos la entidad de horario
                EntidadHorario nuevoHorario = new EntidadHorario
                {
                    EmpleadoID = empleadoID,
                    DiaSemana = diaSemana,
                    HoraInicio = horaInicio,
                    HoraFin = horaFin
                };

                // Insertamos el horario usando la capa de negocio
                int resultado = _negocioHorario.InsertarHorarioN(nuevoHorario);

                // Verificamos el resultado
                if (resultado > 0)
                {
                    MessageBox.Show("Horario registrado correctamente.");
                    this.Close(); // Cerramos el formulario
                }
                else
                {
                    MessageBox.Show("Hubo un problema al registrar el horario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
