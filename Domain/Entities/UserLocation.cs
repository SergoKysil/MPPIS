using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPPIS.Domain.Entities
{
    public class UserLocation : IEntityBase
    {
        public int Id { get; set; }

        public int  LocationId { get; set; }

        public string HouseNumber { get; set; }

        public virtual Location Location { get; set; }


    }
}
