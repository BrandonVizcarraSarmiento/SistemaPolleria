using FontAwesome.Sharp;
using SistemaPolleria.presentacion.gestionPedidosVentas.detallePedido;
using SistemaPolleria.presentacion.gestionPedidosVentas.entregas;
using SistemaPolleria.presentacion.gestionPedidosVentas.pagos;
using SistemaPolleria.presentacion.gestionPedidosVentas.pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPolleria.presentacion
{
    public partial class Inicio : Form
    {
        private static IconButton MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio()
        {
            InitializeComponent();
            OcultarSubMenus();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ContraerMenu();
        }
        private void ContraerMenu()
        {
            if (this.pnlMenu.Width > 200) //Collapse menu
            {
                pnlMenu.Width = 100;
                imgLogo.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                OcultarSubMenus();
                foreach (Button menuButton in pnlMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expande el menu
                pnlMenu.Width = 230;
                imgLogo.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in pnlMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }
        private void OcultarSubMenus()
        {
            subMenuPedidosVentas.Visible = false;
            subMenuMesasReservas.Visible = false;
            subMenuEmpleados.Visible = false;
            subMenuPlatosCocina.Visible = false;
            subMenuClientes.Visible = false;
            subMenuComprasProveedores.Visible = false;
            subMenuPromocionesEventos.Visible = false;
            subMenuUsuarioAuditoria.Visible = false;
            subMenuCajaPagos.Visible = false;
        }
        private void AlternarSubMenu(Panel subMenu)
        {
            if (pnlMenu.Width <= 100)
            {
                subMenu.Visible = false;
                MessageBox.Show("Expande el menú principal para acceder al submenú.");
            }
            else
            {
                OcultarSubMenus();
                subMenu.Visible = !subMenu.Visible;
            }
        }

        private void btnPedidosVentas_Click(object sender, EventArgs e)
        {
            AlternarSubMenu(subMenuPedidosVentas);
        }

        private void btnMesasReservas_Click(object sender, EventArgs e)
        {
            AlternarSubMenu(subMenuMesasReservas);
        }

        private void btnGestionEmpleados_Click(object sender, EventArgs e)
        {
            AlternarSubMenu(subMenuEmpleados);
        }

        private void btnPlatosCocina_Click(object sender, EventArgs e)
        {
            AlternarSubMenu(subMenuPlatosCocina);
        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            AlternarSubMenu(subMenuClientes);
        }

        private void btnComprasProveedores_Click(object sender, EventArgs e)
        {
            AlternarSubMenu(subMenuComprasProveedores);
        }

        private void btnPromocionesEventos_Click(object sender, EventArgs e)
        {
            AlternarSubMenu(subMenuPromocionesEventos);
        }

        private void btnUsuarioAuditoria_Click(object sender, EventArgs e)
        {
            AlternarSubMenu(subMenuUsuarioAuditoria);
        }

        private void btnCajaPagos_Click(object sender, EventArgs e)
        {
            AlternarSubMenu(subMenuCajaPagos);
        }

        private void AbrirFormulario(IconButton menu, Form formulario)
        {
            lblhora.Visible = false;
            lblFecha.Visible = false;
            pcbLogoImagen.Visible = false;

            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.FromArgb(255, 217, 102); // Restaurar el color del botón anterior
                MenuActivo.ForeColor = Color.FromArgb(51, 51, 51); // Restaurar el color de texto del botón anterior
            }
            menu.BackColor = Color.FromArgb(250, 243, 224);
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            pnlContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmPedidos());
        }

        private void btnDetallePedido_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmDetallePedido());
        }

        private void btnEntregas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmEntregas());
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmPagos());
        }
    }
}
