using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.DTOs
{
    //this object is returned when user logs in
    public class UserDto
    {
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
