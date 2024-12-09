using System;

namespace SistemaPolleria.Common.Clientes
{
    public class EntidadCliente
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        // Constructor vacío
        public EntidadCliente() { }

        // Constructor con todos los campos excepto ClienteID (por ser autonumérico)
        public EntidadCliente(string nombre, string apellido, string telefono, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Direccion = direccion;
        }

        // Constructor con todos los campos
        public EntidadCliente(int clienteID, string nombre, string apellido, string telefono, string direccion)
        {
            ClienteID = clienteID;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Direccion = direccion;
        }
    }
}
