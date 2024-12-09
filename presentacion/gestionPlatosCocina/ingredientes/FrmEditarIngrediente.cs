using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPolleria.Common.Ingredientes; // Asegúrate de que la clase EntidadIngrediente esté en esta ubicación
using SistemaPolleria.Negocios.Ingredientes;

namespace SistemaPolleria.presentacion.gestionPlatosCocina.ingredientes
{
    public partial class FrmEditarIngrediente : Form
    {
        private NegocioIngredientes _negocioIngredientes = new NegocioIngredientes();
        private int ingredienteID;
        public FrmEditarIngrediente(int ingredienteID, string nombre, string unidadMedida)
        {
            InitializeComponent();
            this.ingredienteID = ingredienteID;

            // Cargar los datos iniciales en los campos
            txtNombreIngrediente.Text = nombre;
            txtUnidadMedida.Text = unidadMedida;
        }

        private void btnGuardarPlato_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones previas
                if (string.IsNullOrWhiteSpace(txtNombreIngrediente.Text))
                {
                    MessageBox.Show("El nombre del ingrediente no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtUnidadMedida.Text))
                {
                    MessageBox.Show("La unidad de medida no puede estar vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Capturamos los valores actualizados del formulario
                string nombre = txtNombreIngrediente.Text.Trim();
                string unidadMedida = txtUnidadMedida.Text.Trim();

                // Creamos la entidad del ingrediente con los datos editados
                EntidadIngrediente ingredienteEditado = new EntidadIngrediente
                {
                    IngredienteID = ingredienteID,
                    Nombre = nombre,
                    UnidadMedida = unidadMedida
                };

                // Llamamos al método de negocio para actualizar el ingrediente
                int resultado = _negocioIngredientes.EditarIngredienteN(ingredienteEditado);

                if (resultado > 0)
                {
                    MessageBox.Show("Ingrediente actualizado correctamente.");
                    this.Close(); // Cerramos el formulario
                }
                else
                {
                    MessageBox.Show("Error al actualizar el ingrediente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el ingrediente: " + ex.Message);
            }
        }

        private void btnCancelarPlato_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnLimpiarPlato_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            // Limpiar todos los campos del formulario
            txtNombreIngrediente.Text = string.Empty;
            txtUnidadMedida.Text = string.Empty;

            // Si necesitas restablecer el foco al primer campo
            txtNombreIngrediente.Focus();
        }
    }
}
