using IdeoRestfulService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdeoRestfulService.Services
{
    public interface ITokenJWTProvider
    {
        string Authenticate(User user);
    }
}
