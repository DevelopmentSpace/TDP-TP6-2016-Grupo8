using System;

namespace EJ2.Domain
{
    /// <summary>
    /// Modela un movimiento de una cuenta
    /// </summary>
    public class AccountMovement
    {
        /// <summary>
        /// Identificador unico del movimiento
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Fecha en que se realizo el movimiento
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Descripcion del movimiento
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// Monto del movimiento
        /// </summary>
        public double Amount { get; set; }

    }
}
