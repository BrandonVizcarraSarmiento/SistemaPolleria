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
    public partial class FrmEditarHorario : Form
    {
        private NegocioHorario _negocioHorario = new NegocioHorario();
        private NegociosEmpleado _negocioEmpleado = new NegociosEmpleado();
        private int _horarioID;
        public FrmEditarHorario(int horarioID, int empleadoID, string diaSemana, TimeSpan horaInicio, TimeSpan horaFin)
        {
            InitializeComponent();
            _horarioID = horarioID;

            // Cargar los controles con los datos pasados
            cboDiaSemana.SelectedItem = diaSemana;
            dtpHoraInicioHorario.Value = DateTime.Today.Add(horaInicio);  // Añadir solo el TimeSpan
            dtpHoraFinHorario.Value = DateTime.Today.Add(horaFin);
            CargarEmpleados(empleadoID);
        }
        private void CargarEmpleados(int empleadoID)
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

                    // Establecemos el valor seleccionado por defecto (el empleado de la asistencia que estamos editando)
                    cboEmpleado.SelectedValue = empleadoID;
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

        private void btnEditarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos los datos del formulario
                int empleadoID = Convert.ToInt32(cboEmpleado.SelectedValue);
                string diaSemana = cboDiaSemana.SelectedItem.ToString();

                // Cambiar a TimeSpan para las horas
                TimeSpan horaInicio = dtpHoraInicioHorario.Value.TimeOfDay;
                TimeSpan horaFin = dtpHoraFinHorario.Value.TimeOfDay;

                // Creamos la instancia de la entidad Horario con los datos del formulario
                EntidadHorario horarioEditado = new EntidadHorario
                {
                    HorarioID = _horarioID,
                    EmpleadoID = empleadoID,
                    DiaSemana = diaSemana,
                    HoraInicio = horaInicio,
                    HoraFin = horaFin
                };

                // Llamamos al método de negocio para actualizar el horario
                int resultado = _negocioHorario.EditarHorarioN(horarioEditado);

                if (resultado > 0)
                {
                    MessageBox.Show("Horario actualizado correctamente.");
                    this.Close(); // Cerramos el formulario
                }
                else
                {
                    MessageBox.Show("Error al actualizar el horario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el horario: " + ex.Message);
            }
        }
    }
}
