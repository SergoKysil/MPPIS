using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MPPIS.Domain.Entities
{
    public class User : IEntityBase
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public int RoleId { get; set; }

        public int UserLocationId { get; set; }

        public DateTime RegisteredDate { get; set; }

        public bool IsEmailConfirmed { get; set; }

        public virtual Role Role { get; set; }
        
        public virtual UserLocation UserLocation { get; set; }

        public virtual List<Data> Data { get; set; }



    }
}
