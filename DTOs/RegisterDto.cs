﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.DTOs
{
    public class RegisterDto
    {
        [Required]
        //[EmailAddress] should be added for production
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
