using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPolleria.common
{
    public class EntidadUsuario
    {
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }

        // Constructor vacío
        public EntidadUsuario() { }

        // Constructor con todos los campos
        public EntidadUsuario(int usuarioID, string nombreUsuario, string contraseña, string rol)
        {
            UsuarioID = usuarioID;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Rol = rol;
        }

        // Constructor sin UsuarioID (para insertar)
        public EntidadUsuario(string nombreUsuario, string contraseña, string rol)
        {
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Rol = rol;
        }
    }
}
