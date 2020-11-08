namespace MPPIS.Domain.Entities
{
    public class UserLocation : IEntityBase
    {
        public int Id { get; set; }

        public string HouseNumber { get; set; }

        public int UserId { get; set; }

        public int LocationId { get; set; }

        public virtual Location Location { get; set; }

        public virtual User User { get; set; }


    }
}
