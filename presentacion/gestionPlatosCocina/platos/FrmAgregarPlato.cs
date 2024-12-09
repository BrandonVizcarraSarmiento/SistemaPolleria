using SistemaPolleria.Common.Platos;
using SistemaPolleria.Negocios.Platos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPolleria.presentacion.gestionPlatosCocina.platos
{
    public partial class FrmAgregarPlato : Form
    {
        private NegocioPlatos _negocioPlatos = new NegocioPlatos();
        public FrmAgregarPlato()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarPlato_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones previas
                if (string.IsNullOrWhiteSpace(txtNombrePlato.Text))
                {
                    MessageBox.Show("El nombre del plato no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDescripcionPlato.Text))
                {
                    MessageBox.Show("La descripción del plato no puede estar vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPrecioPlato.Text, out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("Ingrese un precio válido mayor a cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Capturamos los valores del formulario
                string nombre = txtNombrePlato.Text.Trim();
                string descripcion = txtDescripcionPlato.Text.Trim();

                // Creamos la entidad de plato
                EntidadPlato nuevoPlato = new EntidadPlato
                {
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Precio = precio
                };

                // Insertamos el plato usando el negocio
                int resultado = _negocioPlatos.InsertarPlatoN(nuevoPlato);
                MessageBox.Show("Resultado: " + resultado);

                // Verificamos el resultado
                if (resultado > 0)
                {
                    MessageBox.Show("Plato registrado correctamente.");
                    this.Close(); // Cerramos el formulario
                }
                else
                {
                    MessageBox.Show("Hubo un problema al registrar el plato.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
            txtNombrePlato.Text = string.Empty;
            txtDescripcionPlato.Text = string.Empty;
            txtPrecioPlato.Text = string.Empty;

            // Si necesitas restablecer el foco al primer campo
            txtNombrePlato.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecioPlato_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcionPlato_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombrePlato_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
