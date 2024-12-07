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

namespace SistemaPolleria.presentacion.cajaPagos.caja
{
    public partial class FrmAgregarCaja : Form
    {
        private NegocioCaja _negocioCaja = new NegocioCaja();
        public FrmAgregarCaja()
        {
            InitializeComponent();
        }

        private void btnGuardarCaja_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturamos los valores del formulario
                DateTime fecha = dtpFecha.Value.Date; // Fecha seleccionada
                decimal total = Convert.ToDecimal(txtTotal.Text); // Total ingresado

                // Validamos que el total sea mayor o igual a cero
                if (total < 0)
                {
                    MessageBox.Show("El total no puede ser negativo.");
                    return;
                }

                // Creamos la entidad de caja
                EntidadCaja nuevaCaja = new EntidadCaja(fecha, total);

                // Insertamos la caja usando el negocio
                int resultado = _negocioCaja.InsertarCajaN(nuevaCaja);

                // Verificamos el resultado
                if (resultado > 0)
                {
                    MessageBox.Show("Caja registrada correctamente.");
                    this.Close(); // Cerramos el formulario después de guardar
                }
                else
                {
                    MessageBox.Show("Hubo un problema al registrar la caja.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
