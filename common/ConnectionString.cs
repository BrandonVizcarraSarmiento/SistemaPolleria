using System;
using System.Data.SqlClient;
using System.Configuration; // Para ConfigurationManager

namespace SistemaPolleria.Common
{
    public class ConnectionString
    {
        private static ConnectionString singleton;
        private SqlConnection sqlConnection;
        private string connectionString;

        // Propiedad para obtener la conexión SQL
        public SqlConnection SqlConnectionFactory
        {
            get
            {
                if (sqlConnection == null)
                    throw new InvalidOperationException("La cadena de conexión no está configurada.");

                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                    sqlConnection.Open();

                return sqlConnection;
            }
        }

        // Propiedad para establecer la cadena de conexión
        public string ConnectionStringValue
        {
            set
            {
                if (connectionString != value)
                {
                    connectionString = value;
                    sqlConnection = new SqlConnection(value);
                }
            }
        }

        // Constructor privado (Singleton)
        private ConnectionString() { }

        // Singleton
        public static ConnectionString Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = new ConnectionString();

                return singleton;
            }
        }

        // Método para inicializar desde app.config
        public void InitializeFromConfig(string connectionName)
        {
            connectionString = ConfigurationManager.ConnectionStrings[connectionName]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException($"No se encontró la cadena de conexión: {connectionName}");

            sqlConnection = new SqlConnection(connectionString);
        }
    }
}


