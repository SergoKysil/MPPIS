using System.Collections.Generic;

namespace MPPIS.Dto
{
    public class UserProfileDto
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public LocationDto LocationDto { get; set; }

        public List<StorageDataDto> StorageDataDto { get; set; }
    }
}
