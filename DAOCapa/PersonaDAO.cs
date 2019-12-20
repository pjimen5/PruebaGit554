using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAOCapa
{
    class PersonaDAO
    {/*
        private ManejadorDB conexion = new ManejadorDB();

        SqlDataReader leerRegistros;
        SqlCommand comando = new SqlCommand();

        //Metodos CRUD
        public List<Persona> VerRegistros(string _condicion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "VerRegistros";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Condicion", _condicion);
            leerRegistros = comando.ExecuteReader();
            List<PersonaDto> listaPersonas = new List<PersonaDto>();
            while (leerRegistros.Read())
            {
                listaPersonas.Add(new PersonaDto(nombre = leerRegistros.GetString(0), lugarNac = leerRegistros.GetString(1)));
            }
            leerRegistros.Close();
            Conexion.Close();
            return listaPersonas;
        }
        public void Insert() { }
        public void Edit() { }
        public void Delete() { }

    }*/

}
}
