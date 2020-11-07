using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPPIS.Domain.Entities
{
    public class Data : IEntityBase
    {
        public int Id { get; set; }

        public DateTime DateAdded { get; set; }

        public decimal CountProduction { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }


    }
}
