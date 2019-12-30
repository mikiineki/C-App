using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Project1.Models;
using Project1.Helpers;

namespace Project1.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
        Task<IEnumerable<User>> GetAll();
    }

    public class UserService : IUserService
    {
        private List<User> _users = new List<User>
        {
            new User { Id = 1, Username = "test", Password = "test", Role = "Admin" }
        };

        public async Task<User> Authenticate(string username, string password)
        {
            var user = await Task.Run(() => _users.SingleOrDefault(x => x.Username == username && x.Password == password));

            if (user == null)
                return null;

            user.Password = null;
            return user;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await Task.Run(() => _users.Select(x => {
                x.Password = null;
                return x;
            }));
        }
    }
}