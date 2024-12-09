using SistemaPolleria.common;
using SistemaPolleria.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPolleria.datos
{
    public class DatosUsuarios
    {
        public EntidadUsuario ValidarUsuario(string nombreUsuario, string contraseña)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT UsuarioID, NombreUsuario, Rol FROM Usuarios WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new EntidadUsuario
                            {
                                UsuarioID = reader.GetInt32(0),
                                NombreUsuario = reader.GetString(1),
                                Rol = reader.GetString(2)
                            };
                        }
                    }
                }
                return null; // Si no hay coincidencia
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar el usuario: " + ex.Message);
                return null;
            }
        }
    }
}
