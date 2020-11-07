using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPPIS.Domain.Entities
{
    public class Location : IEntityBase
    {
        public int Id { get; set; }

        public string City { get; set; }

        public string Vilage { get; set; }

        public string Street { get; set; }

        public virtual List<User> Users { get; set; }


    }
}
