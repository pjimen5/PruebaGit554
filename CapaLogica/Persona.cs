using System;
using DAOCapa;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;

namespace CapaLogica
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

        public String registrarPersona2()
        {
            String msj = "";
            List<ParametrosDB> lstparametros = new List<ParametrosDB>();
            try
            {
                //parametros de entrada
                lstparametros.Add(new ParametrosDB("@nombre", nombre));
                lstparametros.Add(new ParametrosDB("@lugarNac", lugarNac));
                //parametros de salida
                lstparametros.Add(new ParametrosDB("@mensaje", MySqlDbType.VarChar, 100));

                mDB.EjecutarProcedimientoMySQL("RegistrarPersona", lstparametros);

                msj = lstparametros[0].valor.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return msj;
        }
        public DataTable listaPersonas() {
            return mDB.registros("ListadoPersonas", null);
        }
        public DataTable listaPersonas2()
        {
            return mDB.registrosMySQL("ListadoPersonas", null);
        }

        public void listaPersonas3()
        {
         /*   LinQToSQLDataContext context = new LinQToSQLDataContext();

            IEnumerable<DataRow> query = from per in context.Persona select per;
            return query.CopyToDataTable<DataRow>();
*/
        }
    }

   
    // Se agregan metodos que estaran en la capa de datos
    // Ejemplo: registro de persona.
  

}
