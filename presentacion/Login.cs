using SistemaPolleria.common;
using SistemaPolleria.negocios;
using SistemaPolleria.presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPolleria
{
    public partial class Login : Form
    {
        private NegociosUsuarios _negociosUsuarios = new NegociosUsuarios();
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EntidadUsuario usuarioLogueado = _negociosUsuarios.ValidarUsuarioN(usuario, contraseña);

            if (usuarioLogueado != null)
            {
                MessageBox.Show($"Bienvenido {usuarioLogueado.NombreUsuario}, Rol: {usuarioLogueado.Rol}");

                // Pasar el rol al formulario Inicio
                Inicio formInicio = new Inicio(usuarioLogueado.Rol);
                formInicio.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
