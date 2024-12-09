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
    public partial class FrmAgregarIngrediente : Form
    {
        private NegocioIngredientes _negocioIngredientes = new NegocioIngredientes();
        public FrmAgregarIngrediente()
        {
            InitializeComponent();
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

                // Capturamos los valores del formulario
                string nombre = txtNombreIngrediente.Text.Trim();
                string unidadMedida = txtUnidadMedida.Text.Trim();

                // Creamos la entidad de ingrediente
                EntidadIngrediente nuevoIngrediente = new EntidadIngrediente
                {
                    Nombre = nombre,
                    UnidadMedida = unidadMedida
                };

                // Insertamos el ingrediente usando el negocio
                int resultado = _negocioIngredientes.InsertarIngredienteN(nuevoIngrediente);

                // Verificamos el resultado
                if (resultado > 0)
                {
                    MessageBox.Show("Ingrediente registrado correctamente.");
                    this.Close(); // Cerramos el formulario
                }
                else
                {
                    MessageBox.Show("Hubo un problema al registrar el ingrediente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
        private void btnCancelarPlato_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
