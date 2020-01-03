using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAOCapa
{
    public class Personas
    {
        String per_nombre;
        String per_lugarNac;

        public string Per_nombre { get => per_nombre; set => per_nombre = value; }
        public string Per_lugarNac { get => per_lugarNac; set => per_lugarNac = value; }


        /*
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
