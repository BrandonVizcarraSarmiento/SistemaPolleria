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
    public partial class FrmAgregarIventario : Form
    {
        private NegocioInventario _negocioInventario = new NegocioInventario();
        private NegocioIngredientes _negocioIngrediente = new NegocioIngredientes();
        public FrmAgregarIventario()
        {
            InitializeComponent();
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

        private void FrmAgregarIventario_Load(object sender, EventArgs e)
        {
            CargarIngredientes();
        }

        private void btnGuardarInventario_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturamos los valores del formulario
                int ingredienteID = Convert.ToInt32(cboIngredienteID.SelectedValue); // Obtenemos el ID del ingrediente seleccionado
                decimal cantidadActual = nudCantidad.Value; // Cantidad actual ingresada

                // Creamos la entidad de Inventario
                EntidadInventario nuevoInventario = new EntidadInventario(ingredienteID, cantidadActual);

                // Insertamos el registro usando el negocio
                int resultado = _negocioInventario.InsertarIngredienteEnInventarioN(nuevoInventario);

                // Verificamos el resultado
                if (resultado > 0)
                {
                    MessageBox.Show("Ingrediente agregado al inventario correctamente.");
                    this.Close(); // Cerramos el formulario
                }
                else
                {
                    MessageBox.Show("Hubo un problema al agregar el ingrediente al inventario.");
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

