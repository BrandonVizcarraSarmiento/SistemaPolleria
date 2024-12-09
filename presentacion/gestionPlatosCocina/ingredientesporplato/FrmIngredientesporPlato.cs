using SistemaPolleria.Negocio.IngredientesPorPlato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPolleria.presentacion.gestionPlatosCocina.ingredientesporplato
{
    public partial class FrmIngredientesporPlato : Form
    {
        private NegocioIngredientesPorPlato _negocioIngredientesPorPlato = new NegocioIngredientesPorPlato();


        public FrmIngredientesporPlato()
        {
            InitializeComponent();
        }
        private void CargarIngredientesPorPlato()
        {
            // Llamamos al método para obtener todos los ingredientes por plato
            DataTable ingredientesPorPlato = _negocioIngredientesPorPlato.ObtenerTodosIngredientesPorPlatoN();

            // Verificamos que no haya error o que el DataTable no esté vacío
            if (ingredientesPorPlato != null && ingredientesPorPlato.Rows.Count > 0)
            {
                // Vinculamos el DataTable al DataGridView
                dgvIngredientesporPlato.DataSource = ingredientesPorPlato;
            }
            else
            {
                MessageBox.Show("No se encontraron ingredientes por plato.");
            }
        }

        private void FrmIngredientesporPlato_Load(object sender, EventArgs e)
        {
            CargarIngredientesPorPlato();
        }

        private void btnNuevoIngredientesporPlato_Click(object sender, EventArgs e)
        {
            FrmAgregarIngredientesporPlato agregarForm = new FrmAgregarIngredientesporPlato();
            agregarForm.ShowDialog();
            CargarIngredientesPorPlato();
        }

        private void btnEditarIngredientesporPlato_Click(object sender, EventArgs e)
        {
            if (dgvIngredientesporPlato.SelectedRows.Count > 0)
            {
                // Obtén los valores de la fila seleccionada
                int ingredientePlatoID = Convert.ToInt32(dgvIngredientesporPlato.SelectedRows[0].Cells["IngredientePlatoID"].Value);
                int platoID = Convert.ToInt32(dgvIngredientesporPlato.SelectedRows[0].Cells["PlatoID"].Value);
                int ingredienteID = Convert.ToInt32(dgvIngredientesporPlato.SelectedRows[0].Cells["IngredienteID"].Value);
                decimal cantidadNecesaria = Convert.ToDecimal(dgvIngredientesporPlato.SelectedRows[0].Cells["CantidadNecesaria"].Value);

                // Abre el formulario para editar el ingrediente
                FrmEditarIngredientePorPlato editarForm = new FrmEditarIngredientePorPlato(ingredientePlatoID, platoID, ingredienteID, cantidadNecesaria);
                editarForm.ShowDialog();

                // Recarga los datos después de editar el ingrediente
                CargarIngredientesPorPlato();
            }
            else
            {
                MessageBox.Show("Seleccione un registro para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarIngredientesporPlato_Click(object sender, EventArgs e)
        {
            if (dgvIngredientesporPlato.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este ingrediente por plato?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    int ingredientePlatoID = Convert.ToInt32(dgvIngredientesporPlato.SelectedRows[0].Cells["IngredientePlatoID"].Value);
                    _negocioIngredientesPorPlato.EliminarIngredientePorPlatoN(ingredientePlatoID);

                    CargarIngredientesPorPlato();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
            }
        }

        private void btnBuscarIngredientesporPlato_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscarIngredientesporPlato.Text.Trim(), out int platoID))
            {
                DataTable ingredientes = _negocioIngredientesPorPlato.ObtenerIngredientesPorPlatoN(platoID);

                if (ingredientes != null && ingredientes.Rows.Count > 0)
                {
                    dgvIngredientesporPlato.DataSource = ingredientes;
                }
                else
                {
                    MessageBox.Show("No se encontraron ingredientes para el plato ingresado.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID de plato válido.");
            }
        }
    }
}
