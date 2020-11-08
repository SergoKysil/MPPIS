using System.Collections.Generic;

namespace MPPIS.Domain.Entities
{
    public class Location : IEntityBase
    {
        public int Id { get; set; }

        public string City { get; set; }

        public string Village { get; set; }

        public string Street { get; set; }

        public virtual List<UserLocation> UserLocation { get; set; }


    }
}
