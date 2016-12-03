using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2.DTO
{
    /// <summary>
    /// DTO de un movimiento de una cuenta usado para la comunicacion con la vista
    /// </summary>
    public class AccountMovementDTO
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
        public string Description { get; set; }

        /// <summary>
        /// Monto del movimiento
        /// </summary>
        public double Amount { get; set; }

    }
}
