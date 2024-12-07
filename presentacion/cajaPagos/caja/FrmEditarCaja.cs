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
    public partial class FrmEditarCaja : Form
    {
        private NegocioCaja _negocioCaja = new NegocioCaja();

        private int cajaID;
        public FrmEditarCaja(int cajaID, DateTime fecha, decimal total)
        {
            InitializeComponent();
            this.cajaID = cajaID;

            // Pre-cargar los valores en los controles
            dtpFecha.Value = fecha;
            txtTotal.Text = total.ToString();
        }

        private void btnEditarCaja_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturamos los valores del formulario
                DateTime fecha = dtpFecha.Value.Date; // Fecha seleccionada
                decimal total = Convert.ToDecimal(txtTotal.Text); // Total ingresado

                // Validamos que el total no sea negativo
                if (total < 0)
                {
                    MessageBox.Show("El total no puede ser negativo.");
                    return;
                }

                // Creamos la entidad de caja con los valores modificados
                EntidadCaja cajaEditada = new EntidadCaja
                {
                    CajaID = cajaID,
                    Fecha = fecha,
                    Total = total
                };

                // Llamamos al método del negocio para actualizar la caja
                int resultado = _negocioCaja.EditarCajaN(cajaEditada);

                // Verificamos el resultado
                if (resultado > 0)
                {
                    MessageBox.Show("Caja actualizada correctamente.");
                    this.Close(); // Cerramos el formulario después de guardar
                }
                else
                {
                    MessageBox.Show("Hubo un problema al actualizar la caja.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar la caja: " + ex.Message);
            }
        }
    }
}
