using Ideo.Backend.Data;
using Ideo.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ideo.Backend.Extensions
{
    public class IdeoService:IIdeoService
    {
        private readonly ApplicationDbContext _Context;

        public IdeoService(ApplicationDbContext context)
        {
            _Context = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _Context.Set<User>();
        }

        public Task Create(User user)
        {
            user.Id = Guid.NewGuid().ToString();
            _Context.Set<User>().AddAsync(user);
            return _Context.SaveChangesAsync();
        }
    }
}
