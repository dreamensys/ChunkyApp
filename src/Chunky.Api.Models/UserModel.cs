﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chunky.Api.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
