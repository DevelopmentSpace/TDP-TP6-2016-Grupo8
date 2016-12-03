using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1_
{
    /// <summary>
    /// Clase de la entidad telefono.
    /// </summary>
    class Telefono
    {
        /// <summary>
        /// Obtiene o modifica la id de un telefono.
        /// </summary>
        public int TelefonoId { get; set; }

        /// <summary>
        /// Obtiene o modifica el numero de un telefono.
        /// </summary>
        public string Numero { get; set; }

        /// <summary>
        /// Obtiene o modifica el tipo de telefono.
        /// </summary>
        public string Tipo { get; set; }

    }
}
