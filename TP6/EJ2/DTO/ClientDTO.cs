using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJ2.Domain;

namespace EJ2.DTO
{
    public class ClientDTO
    {
            public int Id { get; set; }

            public int TypeDocument { get; set; }

            public String NumberDocument { get; set; }

            public String FirstName { get; set; }

            public String LastName { get; set; }
    }
}
