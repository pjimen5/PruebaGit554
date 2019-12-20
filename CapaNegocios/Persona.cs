using System;
using DAOCapa;
using System.Data;
using System.Collections.Generic;

namespace CapaNegocios
{
    public class Persona
    {
        public String nombre { get; set; }
        public String lugarNac{ get; set; }

        ManejadorDB mDB = new ManejadorDB();

        public Persona(String nombre, String lugar) {
            this.nombre = nombre;
            lugarNac = lugar;
        }

        public Persona() { }

        public String ImprimirPersona()
        {
            return nombre + " de " + lugarNac;
        }

    

        public String registrarPersona()
        {
            String msj = "";
            List<ParametrosDB> lstparametros = new List<ParametrosDB>();
            try {
                //parametros de entrada
                lstparametros.Add(new ParametrosDB("@nombre",nombre));
                lstparametros.Add(new ParametrosDB("@lugarNac",lugarNac));
                //parametros de salida
                lstparametros.Add(new ParametrosDB("@mensaje",SqlDbType.VarChar,100));

                mDB.EjecutarProcedimiento("RegistrarPersona", lstparametros);

                msj = lstparametros[2].valor.ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return msj;
        }

        public DataTable listaPersonas() {
            return mDB.registros("ListadoPersonas", null);
        }
    }

   
    // Se agregan metodos que estaran en la capa de datos
    // Ejemplo: registro de persona.
  

}
