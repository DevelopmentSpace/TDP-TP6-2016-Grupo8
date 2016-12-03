using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2.DTO
{
    /// <summary>
    /// DTO de una cuenta usado para la comunicacion con la vista
    /// </summary>
    public class AccountDTO
    {
        /// <summary>
        /// Identificador unico de la cuenta
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de la cuenta
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Limite de descubierto de la cuenta
        /// </summary>
        public double OverdraftLimit { get; set; }

        /// <summary>
        /// Id del cliente de la cuenta
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Apellido y nombre del cliente de la cuenta
        /// </summary>
        public string ClientName { get; set; }

    }
}
