using SistemaPolleria.Common.IngredientesPorPlato;
using SistemaPolleria.Negocio.IngredientesPorPlato;
using SistemaPolleria.Negocios.Ingredientes;
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

namespace SistemaPolleria.presentacion.gestionPlatosCocina.ingredientesporplato
{
    public partial class FrmAgregarIngredientesporPlato : Form
    {
        private NegocioIngredientesPorPlato _negocioIngredientesPorPlato = new NegocioIngredientesPorPlato();
        private NegocioPlatos _negocioPlato = new NegocioPlatos();
        private NegocioIngredientes _negocioIngrediente = new NegocioIngredientes();
        public FrmAgregarIngredientesporPlato()
        {
            InitializeComponent();
        }

        private void CargarPlatos()
        {
            try
            {
                // Obtenemos la lista de platos desde la capa de negocio
                DataTable platos = _negocioPlato.ObtenerTodosPlatosN();

                // Verificamos que no esté vacío
                if (platos != null && platos.Rows.Count > 0)
                {
                    // Asignamos al ComboBox los platos
                    cboPlatoID.DisplayMember = "Nombre";  // Mostrar el nombre del plato
                    cboPlatoID.ValueMember = "PlatoID"; // Guardar el ID del plato
                    cboPlatoID.DataSource = platos;    // Asignamos el DataTable al ComboBox
                }
                else
                {
                    MessageBox.Show("No se encontraron platos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar platos: " + ex.Message);
            }
        }

        private void CargarIngredientes()
        {
            try
            {
                // Obtenemos la lista de ingredientes desde la capa de negocio
                DataTable ingredientes = _negocioIngrediente.ObtenerTodosIngredientesN();

                // Verificamos que no esté vacío
                if (ingredientes != null && ingredientes.Rows.Count > 0)
                {
                    // Asignamos al ComboBox los ingredientes
                    cboIngredienteID.DisplayMember = "Nombre";  // Mostrar el nombre del ingrediente
                    cboIngredienteID.ValueMember = "IngredienteID"; // Guardar el ID del ingrediente
                    cboIngredienteID.DataSource = ingredientes;    // Asignamos el DataTable al ComboBox
                }
                else
                {
                    MessageBox.Show("No se encontraron ingredientes.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ingredientes: " + ex.Message);
            }
        }

        private void FrmAgregarIngredientesporPlato_Load(object sender, EventArgs e)
        {
            CargarPlatos();
            CargarIngredientes();

        }

        private void btnGuardarIngredienteporPlato_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturamos los valores del formulario
                int platoID = Convert.ToInt32(cboPlatoID.SelectedValue); // Obtenemos el ID del plato seleccionado
                int ingredienteID = Convert.ToInt32(cboIngredienteID.SelectedValue); // Obtenemos el ID del ingrediente seleccionado
                decimal cantidadNecesaria = nudCantidad.Value; // Cantidad necesaria ingresada

                // Creamos la entidad de IngredientePorPlato
                EntidadIngredientesPorPlato nuevoIngredientePorPlato = new EntidadIngredientesPorPlato(platoID, ingredienteID, cantidadNecesaria);

                // Insertamos el registro usando el negocio
                int resultado = _negocioIngredientesPorPlato.InsertarIngredientePorPlatoN(nuevoIngredientePorPlato);

                // Verificamos el resultado
                if (resultado > 0)
                {
                    MessageBox.Show("Ingrediente por plato registrado correctamente.");
                    this.Close(); // Cerramos el formulario
                }
                else
                {
                    MessageBox.Show("Hubo un problema al registrar el ingrediente por plato.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}


