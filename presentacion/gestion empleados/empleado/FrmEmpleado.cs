using SistemaPolleria.common;
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

namespace SistemaPolleria.presentacion.gestion_empleados.empleado
{
    public partial class FrmEmpleado : Form
    {
        private NegociosEmpleado _negocioEmpleado = new NegociosEmpleado();
        public FrmEmpleado()
        {
            InitializeComponent();
        }
        private void CargarEmpleados()
        {
            // Llamamos al método para obtener todos los empleados
            DataTable empleados = _negocioEmpleado.ObtenerTodosEmpleadosN();

            // Verificamos que no haya error o que el DataTable no esté vacío
            if (empleados != null && empleados.Rows.Count > 0)
            {
                // Vinculamos el DataTable al DataGridView
                dgvEmpleado.DataSource = empleados;
            }
            else
            {
                MessageBox.Show("No se encontraron empleados.");
            }
        }
        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FrmAgregarEmpleado agregarForm = new FrmAgregarEmpleado();
            agregarForm.ShowDialog();
            CargarEmpleados();
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleado.SelectedRows.Count > 0)
            {
                // Obtener los datos del empleado seleccionado
                DataGridViewRow filaSeleccionada = dgvEmpleado.SelectedRows[0];
                EntidadEmpleado empleado = new EntidadEmpleado
                {
                    EmpleadoID = Convert.ToInt32(filaSeleccionada.Cells["EmpleadoID"].Value),
                    Nombre = filaSeleccionada.Cells["Nombre"].Value.ToString(),
                    Apellido = filaSeleccionada.Cells["Apellido"].Value.ToString(),
                    DNI = filaSeleccionada.Cells["DNI"].Value.ToString(),
                    Telefono = filaSeleccionada.Cells["Telefono"].Value.ToString(),
                    Direccion = filaSeleccionada.Cells["Direccion"].Value.ToString(),
                    FechaContratacion = Convert.ToDateTime(filaSeleccionada.Cells["FechaContratacion"].Value),
                    Salario = Convert.ToDecimal(filaSeleccionada.Cells["Salario"].Value)
                };

                // Abrir el formulario de edición con los datos del empleado
                FrmEditarEmpleado frmEditar = new FrmEditarEmpleado(empleado);
                frmEditar.ShowDialog();

                // Recargar empleados después de la edición
                CargarEmpleados();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado para editar.");
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleado.SelectedRows.Count > 0)
            {
                // Confirmar eliminación
                DialogResult confirmacion = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este empleado?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    // Obtener el ID del empleado seleccionado
                    int empleadoID = Convert.ToInt32(dgvEmpleado.SelectedRows[0].Cells["EmpleadoID"].Value);

                    // Llamar al método de negocios para eliminar el empleado
                    int resultado = _negocioEmpleado.EliminarEmpleadoN(empleadoID);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Empleado eliminado correctamente.");
                        CargarEmpleados(); // Recargar empleados después de la eliminación
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el empleado.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado para eliminar.");
            }
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarEmpleado.Text.Trim();

            if (!string.IsNullOrEmpty(nombre))
            {
                DataTable empleado = _negocioEmpleado.ObtenerEmpleadoPorNombreN(nombre);

                if (empleado != null && empleado.Rows.Count > 0)
                {
                    dgvEmpleado.DataSource = empleado;
                }
                else
                {
                    MessageBox.Show("No se encontraron el empleado ingresado.");
                }
            }
            else
            {
                // Cargar todos los empleados si el campo de búsqueda está vacío
                DataTable todosEmpleados = _negocioEmpleado.ObtenerTodosEmpleadosN();

                if (todosEmpleados != null && todosEmpleados.Rows.Count > 0)
                {
                    dgvEmpleado.DataSource = todosEmpleados;
                }
                else
                {
                    MessageBox.Show("No hay empleado registrado.");
                }
            }
        }
    }
}
