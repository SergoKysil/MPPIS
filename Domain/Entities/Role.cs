using System.Collections.Generic;

namespace MPPIS.Domain.Entities
{
    public class Role : IEntityBase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<User> User { get; set; }
    }
}
