using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace EJ1_
{
    /// <summary>
    /// Clase que contiene el contexto de la agenda.
    /// </summary>
    class AgendaContext : DbContext
    {
        /// <summary>
        /// Conjunto de personas.
        /// </summary>
        public DbSet<Persona> Personas { get; set; }

        /// <summary>
        /// Conjunto de telefonos.
        /// </summary>
        public DbSet<Telefono> Telefonos { get; set; }

    }
}
