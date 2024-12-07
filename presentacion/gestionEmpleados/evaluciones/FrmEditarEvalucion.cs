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
    public partial class FrmEditarEvalucion : Form
    {
        private NegocioEvalucion _negocioEvalucion = new NegocioEvalucion();
        private NegociosEmpleado _negocioEmpleado = new NegociosEmpleado();

        private int evalucionID;
        private int empleadoID;
        public FrmEditarEvalucion(int evalucionID, int empleadoID, DateTime fecha, string calificacion, string comentario)
        {
            InitializeComponent();
            this.evalucionID = evalucionID;
            this.empleadoID = empleadoID;

            dtpFecha.Value = fecha.Date; // Solo la fecha
            cboCalificacion.SelectedItem = calificacion; // Selecciona la calificación
            txtComentario.Text = comentario; // Establece el comentario
        }
        private void CargarEmpleados()
        {
            try
            {
                // Obtenemos la lista de empleados desde la capa de negocio
                DataTable empleados = _negocioEmpleado.ObtenerTodosEmpleadosN();

                if (empleados != null && empleados.Rows.Count > 0)
                {
                    foreach (DataRow row in empleados.Rows)
                    {
                        string nombreCompleto = row["Nombre"].ToString() + " " + row["Apellido"].ToString();
                        row["Nombre"] = nombreCompleto; // Agregar una nueva columna de nombre completo
                    }

                    cboEmpleado.DisplayMember = "Nombre";  // Mostrar nombre completo
                    cboEmpleado.ValueMember = "EmpleadoID"; // Guardar el ID del empleado
                    cboEmpleado.DataSource = empleados;    // Asignamos el DataTable al ComboBox

                    // Selecciona el empleado actual
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
        private void FrmEditarEvalucion_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void btnEditarEvalucion_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos los datos del formulario
                int empleadoID = Convert.ToInt32(cboEmpleado.SelectedValue);
                DateTime fecha = dtpFecha.Value.Date; // Solo la fecha
                int calificacion = Convert.ToInt32(cboCalificacion.SelectedItem);
                string comentario = txtComentario.Text.Trim();

                // Creamos la entidad de evaluación
                EntidadEvaluacion evalucion = new EntidadEvaluacion
                {
                    EvaluacionID = evalucionID,
                    EmpleadoID = empleadoID,
                    Fecha = fecha,
                    Calificacion = calificacion,
                    Comentario = comentario
                };

                // Llamamos al método de negocio para actualizar la evaluación
                int resultado = _negocioEvalucion.EditarEvaluacionN(evalucion);

                if (resultado > 0)
                {
                    MessageBox.Show("Evaluación actualizada correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la evaluación.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar la evaluación: " + ex.Message);
            }
        }
    }
}
