using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{   
    class PersonaDAO: ManejadorDB
    {
       SqlDataReader leerRegistros;
       SqlCommand comando = new SqlCommand();
       
         //Metodos CRUD
       public List<PersonaDto> VerRegistros(string _condicion)
       {
           comando.Connection = Conexion;
           comando.CommandText = "VerRegistros";
           comando.CommandType = CommandType.StoredProcedure;
           comando.Parameters.AddWithValue("@Condicion",_condicion);
           Conexion.Open();
           leerRegistros = Comando.ExecuteReader();
           List<PersonaDto> listaPersonas = new List<PersonaDto>();
           while (leerRegistros.Read())
           {
              listaPersonas.Add(new PersonaDto(nombre=leerRegistros.GetString(0),lugarNac=leerRegistros.GetString(1)));
           }
           leerRegistros.Close();
           Conexion.Close();
           return listaPersonas;
       }
       public void Insert(){}
       public void Edit(){}
       public void Delete(){}
    }
     
}
