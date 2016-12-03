using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJ2.Domain;

namespace EJ2.DTO
{
    /// <summary>
    /// DTO de un cliente usado para la comunicacion con la vista
    /// </summary>
    public class ClientDTO
    {
        /// <summary>
        /// Identifcador unico del cliente
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tipo de documento del cliente
        /// </summary>
        public string TypeDocument { get; set; }

        /// <summary>
        /// Numero de documento del cliente
        /// </summary>
        public string NumberDocument { get; set; }

        /// <summary>
        /// Nombre del cliente
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Apellido del cliente
        /// </summary>
        public string LastName { get; set; }
    }
}
