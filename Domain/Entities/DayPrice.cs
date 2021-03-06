﻿using System;
using System.Collections.Generic;

namespace MPPIS.Domain.Entities
{
    public class DayPrice : IEntityBase
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public DateTime Date { get; set; }

        public virtual List<StorageData> StorageData { get; set; }

    }
}
