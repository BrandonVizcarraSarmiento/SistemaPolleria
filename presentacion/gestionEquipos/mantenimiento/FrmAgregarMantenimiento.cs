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

namespace SistemaPolleria.presentacion.gestionEquipos.mantenimiento
{
    public partial class FrmAgregarMantenimiento : Form
    {
        private NegociosEquipos _negociosEquipos = new NegociosEquipos();
        private NegociosMantenimientos _negociosMantenimientos = new NegociosMantenimientos();
        public FrmAgregarMantenimiento()
        {
            InitializeComponent();
        }
        // Método para cargar los equipos en el ComboBox
        private void CargarEquipos()
        {
            try
            {
                // Obtenemos la lista de equipos desde la capa de negocio
                DataTable equipos = _negociosEquipos.ObtenerTodosEquiposN();

                // Verificamos que no esté vacío
                if (equipos != null && equipos.Rows.Count > 0)
                {
                    // Asignamos al ComboBox los equipos
                    cboIdEquipo.DisplayMember = "Nombre";  // Mostrar el nombre del equipo
                    cboIdEquipo.ValueMember = "EquipoID"; // Guardar el ID del equipo
                    cboIdEquipo.DataSource = equipos;     // Asignamos el DataTable al ComboBox
                }
                else
                {
                    MessageBox.Show("No se encontraron equipos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar equipos: " + ex.Message);
            }
        }
        private void FrmAgregarMantenimiento_Load(object sender, EventArgs e)
        {
            CargarEquipos();
        }
        private void btnGuardarMantenimiento_Click(object sender, EventArgs e)
        {
            try
            {
                // Validamos que haya un equipo seleccionado
                if (cboIdEquipo.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un equipo válido.");
                    return;
                }

                // Capturamos los valores del formulario
                int equipoID = Convert.ToInt32(cboIdEquipo.SelectedValue); // Obtenemos el ID del equipo seleccionado
                DateTime fechaMantenimiento = dtpFechaMantenimiento.Value.Date; // Fecha seleccionada
                string descripcion = txtDescripcion.Text.Trim(); // Descripción del mantenimiento

                // Creamos la entidad de mantenimiento
                EntidadMantenimientos nuevoMantenimiento = new EntidadMantenimientos
                {
                    EquipoID = equipoID,
                    FechaMantenimiento = fechaMantenimiento,
                    Descripcion = descripcion
                };

                // Insertamos el mantenimiento usando el negocio
                int resultado = _negociosMantenimientos.InsertarMantenimientosN(nuevoMantenimiento);

                // Verificamos el resultado
                if (resultado > 0)
                {
                    MessageBox.Show("Mantenimiento registrado correctamente.");
                    this.Close(); // Cerramos el formulario
                }
                else
                {
                    MessageBox.Show("Hubo un problema al registrar el mantenimiento.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
