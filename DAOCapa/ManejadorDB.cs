using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAOCapa
{
    public class ManejadorDB
    {
        // Se escribe la variable de conexión.
        // Metodo para abrir la conexión
      protected SqlConnection Conexion = new SqlConnection("Server=1-17-6-FCEC3-00\\SQLEXPRESS;Database=itir554;Integrated Security=True");
      protected MySqlConnection mConexion = new MySqlConnection("server=localhost;uid = root; pwd=dba554;database=itir554");

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

        public void AbrirConexionMySQL()
        {
            if (mConexion.State == ConnectionState.Closed)
                mConexion.Open();
        }
        // Metodo para cerrar la conexión
        public void CerrarConexionMySQL()
        {
            if (mConexion.State == ConnectionState.Open)
                mConexion.Close();
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

        public void EjecutarProcedimientoMySQL(String _nombreproc, List<ParametrosDB> _lstParametros)
        {
            MySqlCommand mysqlcmd;
            try
            {
                AbrirConexionMySQL();
                mysqlcmd = new MySqlCommand(_nombreproc, mConexion);
                mysqlcmd.CommandType = CommandType.StoredProcedure;

                if (_lstParametros != null)
                {
                    //Asigna los parametros necesarios para la ejecución del procedimiento
                    for (int i = 0; i < _lstParametros.Count; i++)
                    {

                        if (_lstParametros[i].parDBdirection == ParameterDirection.Input)
                              mysqlcmd.Parameters.Add(new MySqlParameter(_lstParametros[i].nombre, _lstParametros[i].valor));

                        if (_lstParametros[i].parDBdirection == ParameterDirection.Output)
                            mysqlcmd.Parameters.Add(_lstParametros[i].nombre, _lstParametros[i].tipoDato2, _lstParametros[i].tamano).Direction = ParameterDirection.Output;

                    }
                    mysqlcmd.ExecuteNonQuery();
                    // Recupera parametros de salida
                    for (int i = 0; i < _lstParametros.Count; i++)
                    {
                        if (_lstParametros[i].parDBdirection == ParameterDirection.Output)
                            _lstParametros[i].valor = mysqlcmd.Parameters[i].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            CerrarConexionMySQL();
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

        public DataTable registrosMySQL(String _nombreproc, List<ParametrosDB> _lstParametros)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter sqlda;

            try
            {

                sqlda = new MySqlDataAdapter(_nombreproc, mConexion);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;

                if (_lstParametros != null)
                {
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

        public void listarPersonas()
        {
            SqlCommand sqlcmd;
            String sqlstr="select * from Persona";

            try
            {
                AbrirConexion();
                sqlcmd = new SqlCommand(sqlstr,Conexion);

                using (SqlDataReader reader = sqlcmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //Se obtienen los datos que se reciben de la base de datos
                        Console.WriteLine(String.Format("{0}, {1}",
                  reader[0], reader[1]));
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

        public void listarPersonas2()
        {
            SqlCommand sqlcmd;
            String sqlstr = "select * from Persona";

            try
            {
                AbrirConexion();
                sqlcmd = new SqlCommand(sqlstr, Conexion);

                using (SqlDataReader reader = sqlcmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //Se obtienen los datos que se reciben de la base de datos
                        Console.WriteLine(String.Format("{0}, {1}",
                  reader[0], reader[1]));
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

        public void CrearPersona()
        {
            SqlCommand sqlcmd;
            String sqlstr = "select * from Persona";

            try
            {
                AbrirConexion();
                sqlcmd = new SqlCommand(sqlstr, Conexion);

                using (SqlDataReader reader = sqlcmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //Se obtienen los datos que se reciben de la base de datos
                        Console.WriteLine(String.Format("{0}, {1}",
                  reader[0], reader[1]));
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
    }
}
