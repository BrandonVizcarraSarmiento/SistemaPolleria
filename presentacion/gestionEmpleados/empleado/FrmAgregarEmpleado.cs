using SistemaPolleria.common;
using SistemaPolleria.negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPolleria.presentacion.gestion_empleados.empleado
{
    public partial class FrmAgregarEmpleado : Form
    {
        private NegociosEmpleado _negocioEmpleado = new NegociosEmpleado();

        public FrmAgregarEmpleado()
        {
            InitializeComponent();
        }

        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            // Validar los campos para asegurarse de que no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text))
            {
                MessageBox.Show("Todos los campos deben ser completados.");
                return;
            }

            // Validar el formato del DNI (suponiendo que debe ser un número de 8 dígitos)
            if (txtDNI.Text.Length != 8 || !txtDNI.Text.All(char.IsDigit))
            {
                MessageBox.Show("El DNI debe tener 8 dígitos y solo contener números.");
                return;
            }

            // Validar el formato del teléfono (por ejemplo, debe ser numérico y con longitud estándar)
            if (txtTelefono.Text.Length < 7 || !txtTelefono.Text.All(char.IsDigit))
            {
                MessageBox.Show("El número de teléfono no es válido.");
                return;
            }

            // Crear una nueva instancia de la entidad de empleado
            var empleado = new EntidadEmpleado(
                0, // El EmpleadoID lo generará la base de datos
                txtNombres.Text,
                txtApellidos.Text,
                txtDNI.Text,
                txtTelefono.Text,
                txtDireccion.Text,
                dtpFechaContrato.Value,
                Convert.ToDecimal(txtSalario.Text)
            );

            // Intentar guardar el nuevo empleado
            int resultado = _negocioEmpleado.InsertarEmpleadoN(empleado);

            if (resultado > 0)
            {
                MessageBox.Show("Empleado agregado con éxito.");
                this.Close(); // Cerrar el formulario si la inserción fue exitosa
            }
            else
            {
                MessageBox.Show("Hubo un error al agregar el empleado.");
            }
        }
    }
}
