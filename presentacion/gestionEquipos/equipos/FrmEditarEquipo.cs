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

namespace SistemaPolleria.presentacion.gestionEquipos.equipos
{
    public partial class FrmEditarEquipo : Form
    {
        private NegociosEquipos _negocioEquipos = new NegociosEquipos();

        private int equipoID;
        public FrmEditarEquipo(int equipoID, string nombreEquipo, DateTime fechaCompra, DateTime fechaMantenimiento)
        {
            InitializeComponent();
            this.equipoID = equipoID;
            txtNombreEquipo.Text = nombreEquipo;
            dtpFechaCompra.Value = fechaCompra;
            dtpFechaMantenimiento.Value = fechaMantenimiento;
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreEquipo = txtNombreEquipo.Text.Trim();
                DateTime fechaCompra = dtpFechaCompra.Value;
                DateTime fechaMantenimiento = dtpFechaMantenimiento.Value;

                // Crear una instancia del objeto equipo con los datos del formulario
                EntidadEquipos equipo = new EntidadEquipos
                {
                    EquipoID = equipoID,
                    Nombre = nombreEquipo,
                    FechaCompra = fechaCompra,
                    FechaMantenimiento = fechaMantenimiento
                };

                // Llamar al método para actualizar el equipo
                int resultado = _negocioEquipos.EditarEquiposN(equipo);

                if (resultado > 0)
                {
                    MessageBox.Show("Equipo actualizado correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el equipo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el equipo: " + ex.Message);
            }
        }
    }
}
