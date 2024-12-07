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

namespace SistemaPolleria.presentacion.gestion_empleados.evaluciones
{
    public partial class FrmAgregarEvalucion : Form
    {
        private NegocioEvalucion _negocioEvalucion = new NegocioEvalucion();
        private NegociosEmpleado _negocioEmpleado = new NegociosEmpleado();
        public FrmAgregarEvalucion()
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
        private void FrmAgregarEvalucion_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void btnGuardarEvalucion_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturamos los valores del formulario
                int empleadoID = Convert.ToInt32(cboEmpleado.SelectedValue); // ID del empleado seleccionado
                DateTime fecha = dtpFecha.Value.Date; // Solo la fecha sin hora
                int calificacion = Convert.ToInt32(cboCalificacion.SelectedItem); // Calificación seleccionada
                string comentario = txtComentario.Text.Trim(); // Comentario ingresado

                // Creamos la entidad de evaluación
                EntidadEvaluacion nuevaEvaluacion = new EntidadEvaluacion(empleadoID, fecha, calificacion, comentario);

                // Insertamos la evaluación usando la capa de negocio
                int resultado = _negocioEvalucion.InsertarEvaluacionN(nuevaEvaluacion);

                // Verificamos el resultado
                if (resultado > 0)
                {
                    MessageBox.Show("Evaluación registrada correctamente.");
                    this.Close(); // Cerramos el formulario
                }
                else
                {
                    MessageBox.Show("Hubo un problema al registrar la evaluación.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
