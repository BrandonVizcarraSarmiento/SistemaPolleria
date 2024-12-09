using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPolleria.Negocios.Platos;
using SistemaPolleria.presentacion.gestionPlatosCocina;


namespace SistemaPolleria.presentacion.gestionPlatosCocina.platos
{
    public partial class FrmPlatos : Form
    {
        private NegocioPlatos _negocioPlatos = new NegocioPlatos();
        public FrmPlatos()
        {
            InitializeComponent();
            
        }
        private void CargarPlatos()
        {
            // Llamamos al método para obtener todos los platos
            DataTable platos = _negocioPlatos.ObtenerTodosPlatosN();

            // Verificamos que no haya error o que el DataTable no esté vacío
            if (platos != null && platos.Rows.Count > 0)
            {
                // Vinculamos el DataTable al DataGridView
                dgvPlatos.DataSource = platos;
            }
            else
            {
                MessageBox.Show("No se encontraron platos.");
            }
        }

        private void FrmPlatos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNuevoPlato_Click_1(object sender, EventArgs e)
        {
            FrmAgregarPlato agregarForm = new FrmAgregarPlato();
            agregarForm.ShowDialog();
            CargarPlatos();
        }

        private void btnEliminarPlatos_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dgvPlatos.SelectedRows.Count > 0)
            {
                // Pregunta al usuario si realmente desea eliminar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este plato?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    // Obtiene el ID del plato seleccionado
                    int platoID = Convert.ToInt32(dgvPlatos.SelectedRows[0].Cells["PlatoID"].Value);

                    // Llama al método para eliminar el plato
                    _negocioPlatos.EliminarPlatoN(platoID);

                    // Vuelve a cargar los datos en el DataGridView
                    CargarPlatos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un plato para eliminar.");
            }
        }

        private void btnEditarPlatos_Click(object sender, EventArgs e)
        {
            if (dgvPlatos.SelectedRows.Count > 0)
            {
                // Obtenemos los valores de la fila seleccionada
                int platoID = Convert.ToInt32(dgvPlatos.SelectedRows[0].Cells["PlatoID"].Value);
                string nombre = dgvPlatos.SelectedRows[0].Cells["Nombre"].Value.ToString();
                string descripcion = dgvPlatos.SelectedRows[0].Cells["Descripcion"].Value.ToString();
                decimal precio = Convert.ToDecimal(dgvPlatos.SelectedRows[0].Cells["Precio"].Value);

                // Abrimos el formulario de edición
                FrmEditarPlato editarPlatoForm = new FrmEditarPlato(platoID, nombre, descripcion, precio);
                editarPlatoForm.ShowDialog();

                // Recargar los datos después de editar
                CargarPlatos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un plato para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarPlatos_Click_1(object sender, EventArgs e)
        {
            string nombrePlato = txtBuscarPlatos.Text.Trim();

            if (!string.IsNullOrEmpty(nombrePlato))
            {
                DataTable platos = _negocioPlatos.ObtenerPlatosPorNombreN(nombrePlato);

                if (platos != null && platos.Rows.Count > 0)
                {
                    dgvPlatos.DataSource = platos;
                }
                else
                {
                    MessageBox.Show("No se encontraron platos con el nombre ingresado.");
                }
            }
            else
            {
                // Cargar todos los platos si el campo de búsqueda está vacío
                DataTable todosPlatos = _negocioPlatos.ObtenerTodosPlatosN();

                if (todosPlatos != null && todosPlatos.Rows.Count > 0)
                {
                    dgvPlatos.DataSource = todosPlatos;
                }
                else
                {
                    MessageBox.Show("No hay platos registrados.");
                }
            }
        }

        private void FrmPlatos_Load_1(object sender, EventArgs e)
        {
            CargarPlatos();
        }
    }
}
