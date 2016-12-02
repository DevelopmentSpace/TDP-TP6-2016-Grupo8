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

            public string TypeDocument { get; set; }

            public string NumberDocument { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }
    }
}
