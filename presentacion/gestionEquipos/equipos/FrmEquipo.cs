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

namespace SistemaPolleria.presentacion.gestionEquipos.equipos
{
    public partial class FrmEquipo : Form
    {
        private NegociosEquipos _negocioEquipo = new NegociosEquipos();
        public FrmEquipo()
        {
            InitializeComponent();
        }
        private void CargarEquipo()
        {
            // Llamamos al método para obtener todos los equipos
            DataTable equipos = _negocioEquipo.ObtenerTodosEquiposN();

            // Verificamos que no haya error o que el DataTable no esté vacío
            if (equipos != null && equipos.Rows.Count > 0)
            {
                // Vinculamos el DataTable al DataGridView
                dgvEquipo.DataSource = equipos;
            }
            else
            {
                MessageBox.Show("No se encontraron equipos.");
            }
        }
        private void FrmEquipo_Load(object sender, EventArgs e)
        {
            CargarEquipo();
        }

        private void btnNuevoEquipo_Click(object sender, EventArgs e)
        {
            FrmAgregarEquipo agregarForm = new FrmAgregarEquipo(); 
            agregarForm.ShowDialog();
            CargarEquipo();
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            if (dgvEquipo.SelectedRows.Count > 0)
            {
                int equipoID = Convert.ToInt32(dgvEquipo.SelectedRows[0].Cells["EquipoID"].Value);
                string nombreEquipo = dgvEquipo.SelectedRows[0].Cells["Nombre"].Value.ToString();
                DateTime fechaCompra = Convert.ToDateTime(dgvEquipo.SelectedRows[0].Cells["FechaCompra"].Value);
                DateTime fechaMantenimiento = Convert.ToDateTime(dgvEquipo.SelectedRows[0].Cells["FechaMantenimiento"].Value);

                // Abre el formulario para editar el equipo
                FrmEditarEquipo editarForm = new FrmEditarEquipo(equipoID, nombreEquipo, fechaCompra, fechaMantenimiento);
                editarForm.ShowDialog();

                // Recarga los datos después de editar el equipo
                CargarEquipo();
            }
            else
            {
                MessageBox.Show("Seleccione un equipo para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dgvEquipo.SelectedRows.Count > 0)
            {
                // Pregunta al usuario si realmente desea eliminar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este equipo?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    // Obtiene el ID del equipo seleccionado
                    int equipoID = Convert.ToInt32(dgvEquipo.SelectedRows[0].Cells["EquipoID"].Value);

                    try
                    {
                        // Llama al método para eliminar el equipo
                        _negocioEquipo.EliminarEquiposN(equipoID);

                        // Muestra un mensaje de éxito
                        MessageBox.Show("Equipo eliminado correctamente.");

                        // Vuelve a cargar los datos en el DataGridView
                        CargarEquipo();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el equipo: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un equipo para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarEquipo_Click(object sender, EventArgs e)
        {
            string nombreEquipo = txtBuscarEquipo.Text.Trim();

            if (!string.IsNullOrEmpty(nombreEquipo))
            {
                // Buscar equipos por nombre
                DataTable equipos = _negocioEquipo.ObtenerEquiposPorNombreN(nombreEquipo);

                if (equipos != null && equipos.Rows.Count > 0)
                {
                    dgvEquipo.DataSource = equipos;
                }
                else
                {
                    MessageBox.Show("No se encontraron equipos con el nombre ingresado.");
                }
            }
            else
            {
                // Cargar todos los equipos si el campo de búsqueda está vacío
                DataTable todosEquipos = _negocioEquipo.ObtenerTodosEquiposN();

                if (todosEquipos != null && todosEquipos.Rows.Count > 0)
                {
                    dgvEquipo.DataSource = todosEquipos;
                }
                else
                {
                    MessageBox.Show("No hay equipos registrados.");
                }
            }
        }
    }
}
