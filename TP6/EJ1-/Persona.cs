using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1_
{
    /// <summary>
    /// Clase de la entidad persona.
    /// </summary>
    class Persona
    {
        /// <summary>
        /// Obtiene o modifica el ID de una persona
        /// </summary>
        public int PersonaId { get; set; }

        /// <summary>
        /// Obtiene o modifica el nombre de una persona
        /// </summary>
        public string Nombre { get; set; }
    
        /// <summary>
        /// Obtiene o modifica el apellido de una persona
        /// </summary>
        public string Apellido { get; set; }

        /// <summary>
        /// Obtiene o modifica la lista de telefonos de una persona
        /// </summary>
        public IList<Telefono> Telefonos { get; set; }
    }
}
