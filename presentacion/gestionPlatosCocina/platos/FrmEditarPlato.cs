using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPolleria.Common.Platos;
using SistemaPolleria.Negocios.Platos;

namespace SistemaPolleria.presentacion.gestionPlatosCocina.platos
{
    public partial class FrmEditarPlato : Form
    {
        private NegocioPlatos _negocioPlatos = new NegocioPlatos();
        private int platoID;
        public FrmEditarPlato(int platoID, string nombre, string descripcion, decimal precio)
        {
            InitializeComponent();
            this.platoID = platoID;

            // Cargar los datos iniciales en los campos
            txtNombrePlato.Text = nombre;
            txtDescripcionPlato.Text = descripcion;
            txtPrecioPlato.Text = precio.ToString("F2");
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

                // Capturamos los valores actualizados del formulario
                string nombre = txtNombrePlato.Text.Trim();
                string descripcion = txtDescripcionPlato.Text.Trim();

                // Creamos la entidad del plato con los datos editados
                EntidadPlato platoEditado = new EntidadPlato
                {
                    PlatoID = platoID,
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Precio = precio
                };

                // Llamamos al método de negocio para actualizar el plato
                int resultado = _negocioPlatos.EditarPlatoN(platoEditado);

                if (resultado > 0)
                {
                    MessageBox.Show("Plato actualizado correctamente.");
                    this.Close(); // Cerramos el formulario
                }
                else
                {
                    MessageBox.Show("Error al actualizar el plato.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el plato: " + ex.Message);
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

    }
}
