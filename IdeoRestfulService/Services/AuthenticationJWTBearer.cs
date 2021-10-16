using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdeoRestfulService.Services
{
    public class AuthenticationJWTBearer : ITokenJWTProvider
    {
        public string Authenticate(string Username, string Password)
        {
            return "";
        }
    }
}
