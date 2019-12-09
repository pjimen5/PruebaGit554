using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFPrototipo.Modelo;

namespace WFPrototipo.Datos
{
    public class Usuario
    {
        List<UsuarioModelo> lista = new List<UsuarioModelo>();
        /// <summary>
        /// Guarda los usuarios
        /// </summary>
        /// <param name="modelo">datos del usuario</param>
        public void Guardar(UsuarioModelo modelo)
        {
            lista.Add(modelo);
        }
        /// <summary>
        /// Consulta todos los usuarios
        /// </summary>
        /// <returns>datos de usuarios</returns>
        public List<UsuarioModelo> Consultar()
        {
            return lista;
        }
    }
}
