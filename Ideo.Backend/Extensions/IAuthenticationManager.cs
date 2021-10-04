using Ideo.Backend.Models;
using System.Threading.Tasks;

namespace Ideo.Backend.Extensions
{
    public interface IAuthenticationManager
    {
            Task<bool> ValidateCredentials(User credentials);
            Task<string> CreateToken();
    }
}