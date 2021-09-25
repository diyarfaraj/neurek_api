using neurek.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
