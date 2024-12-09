using SistemaPolleria.common;
using SistemaPolleria.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.negocios
{
    public class NegociosUsuarios
    {
        private DatosUsuarios _datosUsuarios = new DatosUsuarios();

        public EntidadUsuario ValidarUsuarioN(string nombreUsuario, string contraseña)
        {
            return _datosUsuarios.ValidarUsuario(nombreUsuario, contraseña);
        }
    }
}
