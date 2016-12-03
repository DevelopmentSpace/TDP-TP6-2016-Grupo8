using System;

namespace EJ2.Domain
{
    /// <summary>
    /// Modela un documento
    /// </summary>
    public class Document
    {
        /// <summary>
        /// Tipo de documento
        /// </summary>
        public DocumentType Type { get; set; }

        /// <summary>
        /// Numero de documento
        /// </summary>
        public String Number { get; set; }

    }

    /// <summary>
    /// Modela un tipo de documento
    /// </summary>
    public enum DocumentType
    {

        DNI,

        CUIL,

        LC,

        LE

    }
}