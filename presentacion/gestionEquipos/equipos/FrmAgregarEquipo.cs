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
    public partial class FrmAgregarEquipo : Form
    {
        private NegociosEquipos _negocioEquipos = new NegociosEquipos();
        public FrmAgregarEquipo()
        {
            InitializeComponent();
        }

        private void btnGuardarEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturamos los valores desde el formulario
                string nombreEquipo = txtNombreEquipo.Text.Trim();
                DateTime fechaCompra = dtpFechaCompra.Value;
                DateTime fechaMantenimiento = dtpFechaMantenimiento.Value;

                // Redondeamos las fechas para eliminar posibles horas, minutos y segundos (opcional)
                fechaCompra = fechaCompra.Date; // Solo la fecha, sin la hora
                fechaMantenimiento = fechaMantenimiento.Date; // Solo la fecha, sin la hora

                // Creamos la entidad de equipo
                EntidadEquipos nuevoEquipo = new EntidadEquipos()
                {
                    Nombre = nombreEquipo,
                    FechaCompra = fechaCompra,
                    FechaMantenimiento = fechaMantenimiento
                };

                // Insertamos el equipo a través de la capa de negocio
                int resultado = _negocioEquipos.InsertarEquiposN(nuevoEquipo);

                // Verificamos el resultado
                if (resultado > 0)
                {
                    MessageBox.Show("Equipo agregado correctamente.");
                    this.Close(); // Cerramos el formulario después de agregar el equipo
                }
                else
                {
                    MessageBox.Show("Hubo un problema al agregar el equipo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
