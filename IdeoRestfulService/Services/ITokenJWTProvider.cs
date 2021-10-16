using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdeoRestfulService.Services
{
    public interface ITokenJWTProvider
    {
        string Authenticate(string Username, string Password);
    }
}
