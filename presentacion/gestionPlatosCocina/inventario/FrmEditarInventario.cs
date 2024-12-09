using SistemaPolleria.Common.Inventario;
using SistemaPolleria.Negocio.Inventario;
using SistemaPolleria.Negocios.Ingredientes;
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
    public partial class FrmEditarInventario : Form
    {
        private NegocioInventario _negocioInventario = new NegocioInventario();
        private NegocioIngredientes _negocioIngrediente = new NegocioIngredientes();
        private int _inventarioID; // ID del inventario a editar
        public FrmEditarInventario(int inventarioID, int ingredienteID, string nombreIngrediente, decimal cantidadActual, string unidadMedida)
        {
            InitializeComponent();
            _inventarioID = inventarioID;

            // Establece los valores iniciales en el formulario
            cboIngredienteID.SelectedValue = ingredienteID;
            nudCantidad.Value = cantidadActual;
            txtNombreIngrediente.Text = nombreIngrediente;
            txtUnidadMedida.Text = unidadMedida;
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
                    cboIngredienteID.DisplayMember = "IngredienteID";  // Mostrar el nombre del ingrediente
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

        private void CargarDatosInventario()
        {
            try
            {
                DataTable inventarioData = _negocioInventario.ObtenerInventarioPorIngredienteN(_inventarioID);
                if (inventarioData != null && inventarioData.Rows.Count > 0)
                {
                    DataRow row = inventarioData.Rows[0];
                    cboIngredienteID.SelectedValue = row["IngredienteID"];
                    nudCantidad.Value = Convert.ToDecimal(row["CantidadActual"]);
                    txtNombreIngrediente.Text = row["NombreIngrediente"].ToString();
                    txtUnidadMedida.Text = row["UnidadMedida"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontraron datos del inventario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del inventario: " + ex.Message);
            }
        }


        private void FrmEditarInventario_Load(object sender, EventArgs e)
        {

            CargarIngredientes();
            CargarDatosInventario();
        }

        private void btnGuardarInventario_Click(object sender, EventArgs e)
        {
            try
            {
                int ingredienteID = Convert.ToInt32(cboIngredienteID.SelectedValue);
                decimal cantidadActual = nudCantidad.Value;
                string nombreIngrediente = txtNombreIngrediente.Text;
                string unidadMedida = txtUnidadMedida.Text;

                // Creamos la entidad de Inventario
                EntidadInventario inventarioActualizado = new EntidadInventario(_inventarioID, ingredienteID, nombreIngrediente, cantidadActual, unidadMedida);

                // Actualizamos el registro usando el negocio
                int resultado = _negocioInventario.EditarIngredienteEnInventarioN(inventarioActualizado);

                // Verificamos el resultado
                if (resultado > 0)
                {
                    MessageBox.Show("Ingrediente editado en el inventario correctamente.");
                    this.Close(); // Cerramos el formulario
                }
                else
                {
                    MessageBox.Show("Hubo un problema al editar el ingrediente en el inventario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cboIngredienteID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar que haya un elemento seleccionado
            if (cboIngredienteID.SelectedValue != null)
            {
                // Obtener el ID del ingrediente seleccionado
                int ingredienteID = Convert.ToInt32(cboIngredienteID.SelectedValue);

                // Obtener el ingrediente seleccionado desde la capa de negocio
                DataRow ingrediente = _negocioIngrediente.ObtenerIngredientePorID(ingredienteID);
                if (ingrediente != null)
                {
                    // Actualizar el TextBox del nombre y la unidad de medida
                    txtNombreIngrediente.Text = ingrediente["Nombre"].ToString(); // Asumiendo que la columna se llama "Nombre"
                    txtUnidadMedida.Text = ingrediente["UnidadMedida"].ToString(); // Asumiendo que la columna se llama "UnidadMedida"
                }
            }
        }
    }
}

