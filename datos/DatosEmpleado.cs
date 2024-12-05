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
    internal class DatosEmpleado
    {
        // Método para obtener todos los empleados
        public DataTable ObtenerTodosEmpleados()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodosEmpleados", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    DataTable dtData = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter sqlSda = new SqlDataAdapter(cmd);
                    sqlSda.Fill(dtData);

                    return dtData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        // Método para insertar un nuevo empleado
        public int InsertarEmpleado(EntidadEmpleado empleado)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarEmpleado", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                    cmd.Parameters.AddWithValue("@DNI", empleado.DNI);
                    cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", empleado.Direccion);
                    cmd.Parameters.AddWithValue("@FechaContratacion", empleado.FechaContratacion);
                    cmd.Parameters.AddWithValue("@Salario", empleado.Salario);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Método para editar un empleado existente
        public int EditarEmpleado(EntidadEmpleado empleado)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarEmpleado", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmpleadoID", empleado.EmpleadoID);
                    cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                    cmd.Parameters.AddWithValue("@DNI", empleado.DNI);
                    cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", empleado.Direccion);
                    cmd.Parameters.AddWithValue("@FechaContratacion", empleado.FechaContratacion);
                    cmd.Parameters.AddWithValue("@Salario", empleado.Salario);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Método para eliminar un empleado por su ID
        public int EliminarEmpleado(int empleadoID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarEmpleado", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public DataTable ObtenerEmpleadoPorNombre(string nombre)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerEmpleadoPorNombre", ConnectionString.Singleton.SqlConnectionFactory))
                {
                    DataTable dtData = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Añadir el parámetro para el nombre del empleado
                    cmd.Parameters.AddWithValue("@Nombre", nombre);

                    SqlDataAdapter sqlSda = new SqlDataAdapter(cmd);
                    sqlSda.Fill(dtData);

                    return dtData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
