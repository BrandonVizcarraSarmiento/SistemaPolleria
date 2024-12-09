using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPolleria.Common.IngredientesPorPlato;
using SistemaPolleria.Negocio.IngredientesPorPlato;
using SistemaPolleria.negocios;
using SistemaPolleria.Negocios.Ingredientes;
using SistemaPolleria.Negocios.Platos;


namespace SistemaPolleria.presentacion.gestionPlatosCocina.ingredientesporplato
{
    public partial class FrmEditarIngredientePorPlato : Form
    {
        private NegocioIngredientesPorPlato _negociosIngredientePorPlato = new NegocioIngredientesPorPlato();
        private NegocioPlatos _negociosPlato = new NegocioPlatos();
        private NegocioIngredientes _negociosIngrediente = new NegocioIngredientes();

        private int platoID;
        private int ingredienteID;
        private int ingredientePlatoID;


        public FrmEditarIngredientePorPlato(int ingredientePlatoID, int platoID, int ingredienteID, decimal cantidadNecesaria)
        {
            InitializeComponent();

            this.platoID = platoID;
            this.ingredienteID = ingredienteID;
            this.ingredientePlatoID = ingredientePlatoID; // Asignar el ID

            // Establecer la cantidad en el control NumericUpDown
            nudCantidad.Value = cantidadNecesaria;
        }

        private void CargarPlatos()
        {
            try
            {
                // Obtener lista de platos desde la capa de negocio
                DataTable platos = _negociosPlato.ObtenerTodosPlatosN();

                if (platos != null && platos.Rows.Count > 0)
                {
                    cboPlatoID.DisplayMember = "Nombre";
                    cboPlatoID.ValueMember = "PlatoID";
                    cboPlatoID.DataSource = platos;

                    // Establecer el valor seleccionado por defecto
                    cboPlatoID.SelectedValue = platoID;
                }
                else
                {
                    MessageBox.Show("No se encontraron platos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los platos: " + ex.Message);
            }
        }

        private void CargarIngredientes()
        {
            try
            {
                // Obtener lista de ingredientes desde la capa de negocio
                DataTable ingredientes = _negociosIngrediente.ObtenerTodosIngredientesN();

                if (ingredientes != null && ingredientes.Rows.Count > 0)
                {
                    cboIngredienteID.DisplayMember = "Nombre";
                    cboIngredienteID.ValueMember = "IngredienteID";
                    cboIngredienteID.DataSource = ingredientes;

                    // Establecer el valor seleccionado por defecto
                    cboIngredienteID.SelectedValue = ingredienteID;
                }
                else
                {
                    MessageBox.Show("No se encontraron ingredientes.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ingredientes: " + ex.Message);
            }
        }

        private void FrmEditarIngredientePorPlato_Load(object sender, EventArgs e)
        {

            CargarPlatos();
            CargarIngredientes();
        }

        private void btnGuardarIngredienteporPlato_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturar datos del formulario
                int nuevoPlatoID = Convert.ToInt32(cboPlatoID.SelectedValue);
                int nuevoIngredienteID = Convert.ToInt32(cboIngredienteID.SelectedValue);
                decimal nuevaCantidadNecesaria = nudCantidad.Value;

                // Crear la entidad con los datos editados
                EntidadIngredientesPorPlato ingredientePorPlato = new EntidadIngredientesPorPlato
                {
                    IngredientePlatoID = ingredientePlatoID,
                    PlatoID = nuevoPlatoID,
                    IngredienteID = nuevoIngredienteID,
                    CantidadNecesaria = nuevaCantidadNecesaria
                };

                // Llamar al método de negocio para actualizar
                int resultado = _negociosIngredientePorPlato.EditarIngredientePorPlatoN(ingredientePorPlato);

                if (resultado > 0)
                {
                    MessageBox.Show("Ingrediente por plato actualizado correctamente.");
                    this.Close(); // Cerrar el formulario
                }
                else
                {
                    MessageBox.Show("Error al actualizar el ingrediente por plato.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message);
            }
        }
    }
}

