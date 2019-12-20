using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DAOCapa
{
    public class ManejadorDB
    {
        // Se escribe la variable de conexión.
        // Metodo para abrir la conexión
         protected SqlConnection Conexion = new SqlConnection("Server=.;Database=NOMBRE_DE_BD;Integrated Security=True");
    //   protected SqlConnection Conexion = new SqlConnection("server=localhost;user id = root; database=itir554");
     
        //Servidor: 1-17-6-FCEC3-00\SQLEXPRESS 

        // Metodo para abrir la conexión
        public void AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
        }
        // Metodo para cerrar la conexión
        public void CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
        }

        // Metodo para ejecutar procedures - Insert, Delete, Update
        public void EjecutarProcedimiento(String _nombreproc, List<ParametrosDB> _lstParametros)
        {
            SqlCommand sqlcmd;
            try
            {
                AbrirConexion();
                sqlcmd = new SqlCommand(_nombreproc, Conexion);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                if (_lstParametros != null)
                {
                    //Asigna los parametros necesarios para la ejecución del procedimiento
                    for (int i = 0; i < _lstParametros.Count; i++)
                    {

                        if (_lstParametros[i].parDBdirection == ParameterDirection.Input)
                            sqlcmd.Parameters.AddWithValue(_lstParametros[i].nombre, _lstParametros[i].valor);

                        if (_lstParametros[i].parDBdirection == ParameterDirection.Output)
                            sqlcmd.Parameters.Add(_lstParametros[i].nombre, _lstParametros[i].tipoDato, _lstParametros[i].tamano).Direction = ParameterDirection.Output;

                    }
                    sqlcmd.ExecuteNonQuery();
                    // Recupera parametros de salida
                    for (int i = 0; i < _lstParametros.Count; i++)
                    {
                        if (_lstParametros[i].parDBdirection == ParameterDirection.Output)
                            _lstParametros[i].valor = sqlcmd.Parameters[i].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            CerrarConexion();
        }


        // Metodo para hacer consultas
        public DataTable registros(String _nombreproc, List<ParametrosDB> _lstParametros)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlda;

            try {

                sqlda = new SqlDataAdapter(_nombreproc, Conexion);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;

                if (_lstParametros != null) {
                    for (int i = 0; i < _lstParametros.Count; i++)
                    {
                        sqlda.SelectCommand.Parameters.AddWithValue(_lstParametros[i].nombre, _lstParametros[i].valor);

                    }
                }
                sqlda.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }

    }
}
