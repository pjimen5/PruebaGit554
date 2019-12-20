using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ManejadorDB
    {
        // Se escribe la variable de conexión.
        // Metodo para abrir la conexión
        protected sqlConnection conexion = new SqlConnection("Server=NOMBRE_DEL_SERVIDOR;Database=NOMBRE_DE_BD;Integrated Security=true");
            
        public SqlConnection AbrirConexion() {
             if (Conexion.State == ConnectionState.Closed)
                 Conexion.Open();
            return Conexion
        }
        // Metodo para cerrar la conexión
        public void CerrarConexion() { 
          if (Conexion.State == ConnectionState.Open)
                 Conexion.Close();
            return Conexion
        }

        // Metodo para ejecutar procedures
        // Metodo para hacer consultas
    }

}
