using System;
using System.Data;


namespace DAOCapa
{
    public class ManejadorDB
    {
        // Se escribe la variable de conexión.
        // Metodo para abrir la conexión
        protected SqlConnection conexion = new SqlConnection("Server=NOMBRE_DEL_SERVIDOR;Database=NOMBRE_DE_BD;Integrated Security=true");

        //Servidor: 1-17-6-FCEC3-00\SQLEXPRESS 


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
