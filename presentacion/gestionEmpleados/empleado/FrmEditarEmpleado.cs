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
    public partial class FrmEditarEmpleado : Form
    {
        private EntidadEmpleado _empleado;
        private NegociosEmpleado _negociosEmpleado = new NegociosEmpleado();
        public FrmEditarEmpleado(EntidadEmpleado empleado)
        {
            InitializeComponent();
            _empleado = empleado;
        }
        private void FrmEditarEmpleado_Load(object sender, EventArgs e)
        {
            // Cargar datos del empleado en los campos del formulario
            txtNombres.Text = _empleado.Nombre;
            txtApellidos.Text = _empleado.Apellido;
            txtDNI.Text = _empleado.DNI;
            txtTelefono.Text = _empleado.Telefono;
            txtDireccion.Text = _empleado.Direccion;
            dtpFechaContrato.Value = _empleado.FechaContratacion;
            txtSalario.Text = _empleado.Salario.ToString("F2");
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            // Validar y actualizar datos del empleado
            _empleado.Nombre = txtNombres.Text.Trim();
            _empleado.Apellido = txtApellidos.Text.Trim();
            _empleado.DNI = txtDNI.Text.Trim();
            _empleado.Telefono = txtTelefono.Text.Trim();
            _empleado.Direccion = txtDireccion.Text.Trim();
            _empleado.FechaContratacion = dtpFechaContrato.Value;
            _empleado.Salario = decimal.Parse(txtSalario.Text.Trim());

            int resultado = _negociosEmpleado.EditarEmpleadoN(_empleado);

            if (resultado > 0)
            {
                MessageBox.Show("Empleado actualizado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar el empleado.");
            }
        }
    }
}
