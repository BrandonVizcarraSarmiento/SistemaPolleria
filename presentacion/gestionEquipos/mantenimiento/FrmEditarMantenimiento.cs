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
    public partial class FrmEditarMantenimiento : Form
    {
        private NegociosEquipos _negociosEquipos = new NegociosEquipos();
        private NegociosMantenimientos _negociosMantenimientos = new NegociosMantenimientos();

        private int mantenimientoID;
        private int equipoID;
        public FrmEditarMantenimiento(int mantenimientoID, int equipoID, DateTime fechaMantenimiento, string descripcion)
        {
            InitializeComponent();

            this.mantenimientoID = mantenimientoID;
            this.equipoID = equipoID;

            // Carga inicial de valores
            cboIdEquipo.SelectedValue = equipoID;
            dtpFechaMantenimiento.Value = fechaMantenimiento;
            txtDescripcion.Text = descripcion;
        }
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

                    // Establece el equipo seleccionado por defecto
                    cboIdEquipo.SelectedValue = equipoID;
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
        private void FrmEditarMantenimiento_Load(object sender, EventArgs e)
        {
            CargarEquipos();
        }

        private void btnEditarMantenimiento_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener valores del formulario
                int equipoID = Convert.ToInt32(cboIdEquipo.SelectedValue);
                DateTime fechaMantenimiento = dtpFechaMantenimiento.Value;
                string descripcion = txtDescripcion.Text.Trim();

                // Crear la entidad con los datos
                EntidadMantenimientos mantenimiento = new EntidadMantenimientos
                {
                    MantenimientoID = mantenimientoID,
                    EquipoID = equipoID,
                    FechaMantenimiento = fechaMantenimiento,
                    Descripcion = descripcion
                };

                // Llamar al método de negocio para editar
                int resultado = _negociosMantenimientos.EditarMantenimientosN(mantenimiento);

                if (resultado > 0)
                {
                    MessageBox.Show("Mantenimiento actualizado correctamente.");
                    this.Close(); // Cerrar formulario
                }
                else
                {
                    MessageBox.Show("Error al actualizar el mantenimiento.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el mantenimiento: " + ex.Message);
            }
        }
    }
}
