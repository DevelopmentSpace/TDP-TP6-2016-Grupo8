using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2.DTO
{
    public class AccountDTO
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public double OverdraftLimit { get; set; }

        public virtual int ClientId { get; set; }

    }
}
