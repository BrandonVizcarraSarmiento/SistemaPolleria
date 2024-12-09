using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPolleria.Negocios.Ingredientes;
using SistemaPolleria.presentacion.gestionPlatosCocina;

namespace SistemaPolleria.presentacion.gestionPlatosCocina.ingredientes
{
    public partial class FrmIngredientes : Form
    {
        private NegocioIngredientes _negocioIngredientes = new NegocioIngredientes();
        public FrmIngredientes()
        {
            InitializeComponent();
        }

        private void CargarIngredientes()
        {
            // Llamamos al método para obtener todos los ingredientes
            DataTable ingredientes = _negocioIngredientes.ObtenerTodosIngredientesN();

            // Verificamos que no haya error o que el DataTable no esté vacío
            if (ingredientes != null && ingredientes.Rows.Count > 0)
            {
                // Vinculamos el DataTable al DataGridView
                dgvIngredientes.DataSource = ingredientes;
            }
            else
            {
                MessageBox.Show("No se encontraron ingredientes.");
            }
        }

        private void FrmIngredientes_Load(object sender, EventArgs e)
        {
            CargarIngredientes();
        }

        private void btnNuevoIngredientes_Click(object sender, EventArgs e)
        {
            FrmAgregarIngrediente agregarForm = new FrmAgregarIngrediente();
            agregarForm.ShowDialog();
            CargarIngredientes();
        }

        private void btnEliminarIngredientes_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dgvIngredientes.SelectedRows.Count > 0)
            {
                // Pregunta al usuario si realmente desea eliminar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este ingrediente?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    // Obtiene el ID del ingrediente seleccionado
                    int ingredienteID = Convert.ToInt32(dgvIngredientes.SelectedRows[0].Cells["IngredienteID"].Value);

                    // Llama al método para eliminar el ingrediente
                    _negocioIngredientes.EliminarIngredienteN(ingredienteID);

                    // Vuelve a cargar los datos en el DataGridView
                    CargarIngredientes();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un ingrediente para eliminar.");
            }
        }

        private void btnEditarIngredientes_Click(object sender, EventArgs e)
        {
            if (dgvIngredientes.SelectedRows.Count > 0)
            {
                // Obtenemos los valores de la fila seleccionada
                int ingredienteID = Convert.ToInt32(dgvIngredientes.SelectedRows[0].Cells["IngredienteID"].Value);
                string nombre = dgvIngredientes.SelectedRows[0].Cells["Nombre"].Value.ToString();
                string unidadMedida = dgvIngredientes.SelectedRows[0].Cells["UnidadMedida"].Value.ToString();

                // Abrimos el formulario de edición
                FrmEditarIngrediente editarIngredienteForm = new FrmEditarIngrediente(ingredienteID, nombre, unidadMedida);
                editarIngredienteForm.ShowDialog();

                // Recargar los datos después de editar
                CargarIngredientes();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un ingrediente para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarIngredientes_Click(object sender, EventArgs e)
        {
            string nombreIngrediente = txtBuscarIngredientes.Text.Trim();

            if (!string.IsNullOrEmpty(nombreIngrediente))
            {
                DataTable ingredientes = _negocioIngredientes.ObtenerIngredientesPorNombreN(nombreIngrediente);

                if (ingredientes != null && ingredientes.Rows.Count > 0)
                {
                    dgvIngredientes.DataSource = ingredientes;
                }
                else
                {
                    MessageBox.Show("No se encontraron ingredientes con el nombre ingresado.");
                }
            }
            else
            {
                // Cargar todos los ingredientes si el campo de búsqueda está vacío
                DataTable todosIngredientes = _negocioIngredientes.ObtenerTodosIngredientesN();

                if (todosIngredientes != null && todosIngredientes.Rows.Count > 0)
                {
                    dgvIngredientes.DataSource = todosIngredientes;
                }
                else
                {
                    MessageBox.Show("No hay ingredientes registrados.");
                }
            }
        }
    
    }
}
