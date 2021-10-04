using Ideo.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ideo.Backend.Extensions
{
    public interface IIdeoService
    {
        IEnumerable<User> GetAll();
        Task Create(User user);
    }
}
