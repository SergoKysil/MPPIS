using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPPIS.Domain.Entities
{
    public class DayPrice
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public int DataId { get; set; }

        public virtual Data Data { get; set; }

    }
}
