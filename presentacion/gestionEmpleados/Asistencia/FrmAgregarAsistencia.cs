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
    public partial class FrmAgregarAsistencia : Form
    {
        private NegocioAsistencia _negocioAsistencia = new NegocioAsistencia();
        private NegociosEmpleado _negocioEmpleado = new NegociosEmpleado();
        public FrmAgregarAsistencia()
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

        private void FrmAgregarAsistencia_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }
        private void btnGuardarAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturamos los valores del formulario
                int empleadoID = Convert.ToInt32(cboEmpleado.SelectedValue); // Obtenemos el ID del empleado seleccionado
                DateTime fecha = dtpFecha.Value; // Fecha seleccionada

                // Tomamos solo la hora, minutos y segundos (sin fracciones de segundo)
                TimeSpan horaEntrada = dtpHoraInicioAsistencia.Value.TimeOfDay;
                TimeSpan horaSalida = dtpHoraFinAsistencia.Value.TimeOfDay;

                // Redondeamos la hora de entrada y salida para evitar los milisegundos
                horaEntrada = new TimeSpan(horaEntrada.Hours, horaEntrada.Minutes, horaEntrada.Seconds);
                horaSalida = new TimeSpan(horaSalida.Hours, horaSalida.Minutes, horaSalida.Seconds);

                // Creamos la entidad de asistencia
                EntidadAsistencia nuevaAsistencia = new EntidadAsistencia(empleadoID, fecha, horaEntrada, horaSalida);

                // Insertamos la asistencia usando el negocio
                int resultado = _negocioAsistencia.InsertarAsistenciaN(nuevaAsistencia);

                // Verificamos el resultado
                if (resultado > 0)
                {
                    MessageBox.Show("Asistencia registrada correctamente.");
                    this.Close(); // Cerramos el formulario
                }
                else
                {
                    MessageBox.Show("Hubo un problema al registrar la asistencia.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
