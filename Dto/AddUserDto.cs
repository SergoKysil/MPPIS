﻿namespace MPPIS.Dto
{
    public class AddUserDto
    {
        public int? Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public LocationDto LocationDto { get; set; }
    }
}
