using System;

namespace EJ2.Domain
{
    public class Document
    {

        public DocumentType Type { get; set; }

        public String Number { get; set; }

    }

    public enum DocumentType
    {

        DNI,

        CUIL,

        LC,

        LE

    }
}