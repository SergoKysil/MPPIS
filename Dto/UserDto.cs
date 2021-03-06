﻿using MPPIS.Domain.Entities;
using System;

namespace MPPIS.Dto
{
    public class UserDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime RegisteredDate { get; set; }

        public bool IsEmailConfirmed { get; set; }

        public Role Role { get; set; }

        public LocationDto Location { get; set; }
    }
}
