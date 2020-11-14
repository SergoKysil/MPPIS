using System;

namespace MPPIS.Dto
{
    public class AddDayPriceDto
    {
        public int? Id { get; set; }

        public decimal Price { get; set; }

        public DateTime Date { get; set; }

    }
}
