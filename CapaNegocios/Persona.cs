using System;
using CapaDatos;

namespace CapaNegocios
{
    public class Persona
    {
        public String nombre { get; set; }
        public String lugarNac{ get; set; }

        public Persona(String nombre, String lugar) {
            this.nombre = nombre;
            lugarNac = lugar;
        }

        public String ImprimirPersona()
        {
            return nombre + " de " + lugarNac;
        }

        ManejadorDB mDB = new ManejadorDB();

        public void registrarPersona()
        {

        }
    }

   
    // Se agregan metodos que estaran en la capa de datos
    // Ejemplo: registro de persona.
  

}
