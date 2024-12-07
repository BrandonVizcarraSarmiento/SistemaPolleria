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

namespace SistemaPolleria.presentacion.cajaPagos.caja
{
    public partial class FrmCaja : Form
    {
        private NegocioCaja _negocioCaja = new NegocioCaja();
        public FrmCaja()
        {
            InitializeComponent();
        }
        private void CargarCaja()
        {
            // Llamamos al método para obtener todas las cajas
            DataTable caja = _negocioCaja.ObtenerTodasCajasN();

            // Verificamos que no haya error o que el DataTable no esté vacío
            if (caja != null && caja.Rows.Count > 0)
            {
                // Vinculamos el DataTable al DataGridView
                dgvCaja.DataSource = caja;
            }
            else
            {
                MessageBox.Show("No se encontraron evaluaciones.");
            }
        }
        private void FrmCaja_Load(object sender, EventArgs e)
        {
            CargarCaja();
        }

        private void btnNuevoCaja_Click(object sender, EventArgs e)
        {
            FrmAgregarCaja agregarForm = new FrmAgregarCaja();
            agregarForm.ShowDialog();
            CargarCaja();
        }

        private void btnEditarCaja_Click(object sender, EventArgs e)
        {
            if (dgvCaja.SelectedRows.Count > 0)
            {
                // Obtén el ID de la caja de la fila seleccionada
                int cajaID = Convert.ToInt32(dgvCaja.SelectedRows[0].Cells["CajaID"].Value);
                DateTime fecha = Convert.ToDateTime(dgvCaja.SelectedRows[0].Cells["Fecha"].Value);
                decimal total = Convert.ToDecimal(dgvCaja.SelectedRows[0].Cells["Total"].Value);

                // Abre el formulario para editar la caja
                FrmEditarCaja editarForm = new FrmEditarCaja(cajaID, fecha, total);
                editarForm.ShowDialog();

                // Recarga los datos después de editar la caja
                CargarCaja();
            }
            else
            {
                MessageBox.Show("Seleccione un registro para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarCaja_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dgvCaja.SelectedRows.Count > 0)
            {
                // Pregunta al usuario si realmente desea eliminar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar esta caja?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Obtiene el ID de la caja seleccionada
                        int cajaID = Convert.ToInt32(dgvCaja.SelectedRows[0].Cells["CajaID"].Value);

                        // Llama al método para eliminar la caja
                        NegocioCaja negocioCaja = new NegocioCaja();
                        negocioCaja.EliminarCajaN(cajaID);

                        // Vuelve a cargar los datos en el DataGridView
                        CargarCaja();
                        MessageBox.Show("Caja eliminada correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la caja: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una caja para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarCaja_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date; // Toma la fecha de inicio seleccionada
            DateTime fechaFin = dtpFechaFin.Value.Date; // Toma la fecha de fin seleccionada

            // Verifica si las fechas son válidas
            if (fechaInicio <= fechaFin)
            {
                // Llama al método para obtener las cajas dentro del rango de fechas
                DataTable cajas = _negocioCaja.ObtenerCajasPorFechaN(fechaInicio, fechaFin);

                if (cajas != null && cajas.Rows.Count > 0)
                {
                    // Si encuentra resultados, los muestra en el DataGridView
                    dgvCaja.DataSource = cajas;
                }
                else
                {
                    MessageBox.Show("No se encontraron cajas dentro del rango de fechas.");
                }
            }
            else
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Restablecer los valores de los DateTimePicker a las fechas actuales
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;

            // Volver a cargar todas las cajas en el DataGridView
            CargarCaja();
        }
    }
}
