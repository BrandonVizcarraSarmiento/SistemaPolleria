using SistemaPolleria.Negocio.Inventario;
using SistemaPolleria.presentacion.gestionPlatosCocina.ingredientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPolleria.presentacion.gestionPlatosCocina.inventario
{
    public partial class FrmInventario : Form
    {
        private NegocioInventario _negocioInventario = new NegocioInventario();
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void CargarInventario()
        {
            // Llamamos al método para obtener todos los ingredientes en el inventario
            DataTable inventario = _negocioInventario.ObtenerTodosInventariosN();

            // Verificamos que no haya error o que el DataTable no esté vacío
            if (inventario != null && inventario.Rows.Count > 0)
            {
                // Vinculamos el DataTable al DataGridView
                dgvInventario.DataSource = inventario;
            }
            else
            {
                MessageBox.Show("No se encontraron ingredientes en el inventario.");
            }
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            CargarInventario();
        }

        private void btnNuevoInventario_Click(object sender, EventArgs e)
        {

            FrmAgregarIventario agregarForm = new FrmAgregarIventario();
            agregarForm.ShowDialog();
            CargarInventario();
        }

        private void btnEditarInventario_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count > 0)
            {
                // Obtén los valores de la fila seleccionada
                int inventarioID = Convert.ToInt32(dgvInventario.SelectedRows[0].Cells["InventarioID"].Value);
                int ingredienteID = Convert.ToInt32(dgvInventario.SelectedRows[0].Cells["IngredienteID"].Value);
                string nombreIngrediente = dgvInventario.SelectedRows[0].Cells["NombreIngrediente"].Value.ToString();
                decimal cantidadActual = Convert.ToDecimal(dgvInventario.SelectedRows[0].Cells["CantidadActual"].Value);
                string unidadMedida = dgvInventario.SelectedRows[0].Cells["UnidadMedida"].Value.ToString();

                // Abre el formulario para editar el ingrediente
                FrmEditarInventario editarForm = new FrmEditarInventario(inventarioID, ingredienteID, nombreIngrediente, cantidadActual, unidadMedida);
                editarForm.ShowDialog();

                // Recarga los datos después de editar el ingrediente
                CargarInventario();
            }
            else
            {
                MessageBox.Show("Seleccione un registro para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarInventario_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este ingrediente del inventario?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    int inventarioID = Convert.ToInt32(dgvInventario.SelectedRows[0].Cells["InventarioID"].Value);
                    _negocioInventario.EliminarIngredienteEnInventarioN(inventarioID);

                    CargarInventario();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
            }
        }

        private void btnBuscarInventario_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscarInventario.Text.Trim(), out int ingredienteID))
            {
                DataTable inventario = _negocioInventario.ObtenerInventarioPorIngredienteN(ingredienteID);

                if (inventario != null && inventario.Rows.Count > 0)
                {
                    dgvInventario.DataSource = inventario;
                }
                else
                {
                    MessageBox.Show("No se encontraron ingredientes para el ID ingresado.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID de ingrediente válido.");
            }
        }
    }
}

