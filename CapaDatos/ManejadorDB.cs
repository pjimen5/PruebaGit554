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
            
        public void abrir_conexion() { }
        // Metodo para cerrar la conexión
        public void cerrar_conexion() { }

        // Metodo para ejecutar procedures
        // Metodo para hacer consultas
    }

}
