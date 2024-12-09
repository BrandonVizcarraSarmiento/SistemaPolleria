using SistemaPolleria.negocio.asistencia;
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

namespace SistemaPolleria.presentacion.gestionPedidosVentas.detallePedido
{
    public partial class FrmDetallePedido : Form
    {
        private NegociosDetallesPedido _negociosDetallesPedido = new NegociosDetallesPedido();
        public FrmDetallePedido()
        {
            InitializeComponent();
        }
        private void CargarDetallePedido()
        {
            // Llamamos al método para obtener todos los detalle pedido
            DataTable detallePedido = _negociosDetallesPedido.ObtenerTodosDetallesPedidoN();

            // Verificamos que no haya error o que el DataTable no esté vacío
            if (detallePedido != null && detallePedido.Rows.Count > 0)
            {
                // Vinculamos el DataTable al DataGridView
                dgvDetallePedido.DataSource = detallePedido;
            }
            else
            {
                MessageBox.Show("No se encontraron los detalle pedido.");
            }
        }
        private void FrmDetallePedido_Load(object sender, EventArgs e)
        {
            CargarDetallePedido();
        }
    }
}
