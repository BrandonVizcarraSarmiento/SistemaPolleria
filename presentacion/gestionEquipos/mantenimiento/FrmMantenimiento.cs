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

namespace SistemaPolleria.presentacion.gestionEquipos.mantenimiento
{
    public partial class FrmMantenimiento : Form
    {
        private NegociosMantenimientos _negociosMantenimientos = new NegociosMantenimientos();
        public FrmMantenimiento()
        {
            InitializeComponent();
        }
        private void CargarMantenimiento()
        {
            // Llamamos al método para obtener todos los mantenimientos
            DataTable mantenimientos = _negociosMantenimientos.ObtenerTodosMantenimientosN();

            // Verificamos que no haya error o que el DataTable no esté vacío
            if (mantenimientos != null && mantenimientos.Rows.Count > 0)
            {
                // Vinculamos el DataTable al DataGridView
                dgvMantenimiento.DataSource = mantenimientos;
            }
            else
            {
                MessageBox.Show("No se encontraron mantenimientos.");
            }
        }
        private void FrmMantenimiento_Load(object sender, EventArgs e)
        {
            CargarMantenimiento();
        }

        private void btnNuevoMantenimiento_Click(object sender, EventArgs e)
        {
            FrmAgregarMantenimiento agregarForm = new FrmAgregarMantenimiento(); 
            agregarForm.ShowDialog();
            CargarMantenimiento();
        }

        private void btnEditarMantenimiento_Click(object sender, EventArgs e)
        {
            if (dgvMantenimiento.SelectedRows.Count > 0)
            {
                // Obtén los datos de la fila seleccionada
                int mantenimientoID = Convert.ToInt32(dgvMantenimiento.SelectedRows[0].Cells["MantenimientoID"].Value);
                int equipoID = Convert.ToInt32(dgvMantenimiento.SelectedRows[0].Cells["EquipoID"].Value);
                DateTime fechaMantenimiento = Convert.ToDateTime(dgvMantenimiento.SelectedRows[0].Cells["FechaMantenimiento"].Value);
                string descripcion = dgvMantenimiento.SelectedRows[0].Cells["Descripcion"].Value.ToString();

                // Abre el formulario para editar el mantenimiento
                FrmEditarMantenimiento editarForm = new FrmEditarMantenimiento(mantenimientoID, equipoID, fechaMantenimiento, descripcion);
                editarForm.ShowDialog();

                // Recarga los datos después de editar el mantenimiento
                CargarMantenimiento();
            }
            else
            {
                MessageBox.Show("Seleccione un mantenimiento para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarMantenimiento_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dgvMantenimiento.SelectedRows.Count > 0)
            {
                // Pregunta al usuario si realmente desea eliminar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este mantenimiento?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    // Obtiene el ID del mantenimiento seleccionado
                    int mantenimientoID = Convert.ToInt32(dgvMantenimiento.SelectedRows[0].Cells["MantenimientoID"].Value);

                    try
                    {
                        // Llama al método para eliminar el mantenimiento
                        NegociosMantenimientos negocioMantenimientos = new NegociosMantenimientos();
                        int resultadoEliminacion = negocioMantenimientos.EliminarMantenimientoN(mantenimientoID);

                        if (resultadoEliminacion > 0)
                        {
                            MessageBox.Show("Mantenimiento eliminado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el mantenimiento. Verifique si el registro está asociado a otros datos.");
                        }

                        // Vuelve a cargar los datos en el DataGridView
                        CargarMantenimiento();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al intentar eliminar el mantenimiento: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un mantenimiento para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarMantenimiento_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscarMantenimiento.Text.Trim();

            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                // Verifica si el texto ingresado es un ID válido
                if (int.TryParse(textoBusqueda, out int equipoID))
                {
                    // Busca mantenimientos según el ID del equipo ingresado
                    DataTable mantenimientos = _negociosMantenimientos.ObtenerMantenimientosPorEquipoIDN(equipoID);

                    if (mantenimientos != null && mantenimientos.Rows.Count > 0)
                    {
                        dgvMantenimiento.DataSource = mantenimientos;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron mantenimientos para el ID del equipo ingresado.");
                    }
                }
                else
                {
                    MessageBox.Show("El ID del equipo debe ser un número válido.");
                }
            }
            else
            {
                // Cargar todos los mantenimientos si el campo de búsqueda está vacío
                DataTable todosMantenimientos = _negociosMantenimientos.ObtenerTodosMantenimientosN();

                if (todosMantenimientos != null && todosMantenimientos.Rows.Count > 0)
                {
                    dgvMantenimiento.DataSource = todosMantenimientos;
                }
                else
                {
                    MessageBox.Show("No hay mantenimientos registrados.");
                }
            }
        }
    }
}
