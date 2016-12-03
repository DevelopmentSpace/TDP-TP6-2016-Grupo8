using System;
using System.Collections.Generic;

namespace EJ2.Domain
{
    /// <summary>
    /// Modela una cuenta
    /// </summary>
    public class Account
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
        /// Cliente de la cuenta
        /// </summary>
        public virtual Client Client { get; set; }

        /// <summary>
        /// Movimientos de la cuenta
        /// </summary>
        public virtual IList<AccountMovement> Movements { get; set; }

    }
}
