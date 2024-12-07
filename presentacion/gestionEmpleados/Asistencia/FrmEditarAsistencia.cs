using SistemaPolleria.Common.Asistencia;
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

namespace SistemaPolleria.presentacion.gestion_empleados.Asistencia
{
    public partial class FrmEditarAsistencia : Form
    {
        private NegocioAsistencia _negocioAsistencia = new NegocioAsistencia();
        private NegociosEmpleado _negocioEmpleado = new NegociosEmpleado();

        private int asistenciaID;
        private int empleadoID;

        public FrmEditarAsistencia(int asistenciaID, int empleadoID, DateTime fecha, TimeSpan horaEntrada, TimeSpan horaSalida)
        {
            InitializeComponent();
            this.asistenciaID = asistenciaID;
            this.empleadoID = empleadoID;

            dtpFecha.Value = fecha;
            dtpHoraInicioAsistencia.Value = DateTime.Today.Add(horaEntrada);  // Añadir solo el TimeSpan
            dtpHoraFinAsistencia.Value = DateTime.Today.Add(horaSalida);

        }
        // Método para cargar los empleados en el ComboBox
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
        private void FrmEditarAsistencia_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void btnEditarAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos los datos del formulario
                int empleadoID = Convert.ToInt32(cboEmpleado.SelectedValue);
                DateTime fecha = dtpFecha.Value;

                // Cambiar a TimeSpan para las horas
                TimeSpan horaEntrada = dtpHoraInicioAsistencia.Value.TimeOfDay;
                TimeSpan horaSalida = dtpHoraFinAsistencia.Value.TimeOfDay;

                // Creamos la instancia de la entidad Asistencia con los datos del formulario
                EntidadAsistencia asistencia = new EntidadAsistencia
                {
                    AsistenciaID = asistenciaID,
                    EmpleadoID = empleadoID,
                    Fecha = fecha,
                    HoraEntrada = horaEntrada,
                    HoraSalida = horaSalida
                };

                // Llamamos al método de negocio para actualizar la asistencia
                int resultado = _negocioAsistencia.EditarAsistenciaN(asistencia);

                if (resultado > 0)
                {
                    MessageBox.Show("Asistencia actualizada correctamente.");
                    this.Close(); // Cerramos el formulario
                }
                else
                {
                    MessageBox.Show("Error al actualizar la asistencia.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar la asistencia: " + ex.Message);
            }
        }
    }
}
