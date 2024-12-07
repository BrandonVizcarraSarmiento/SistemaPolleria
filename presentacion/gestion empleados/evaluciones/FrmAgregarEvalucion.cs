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
    }
}
