using System.Collections.Generic;
using System.Linq;
using EPortal.Models; // Assuming User model is defined in Models namespace

namespace EPortal.Services
{
    public class UserService
    {
        private readonly List<User> _users = new List<User>();

        public bool RegisterUser(User user)
        {
            if (_users.Any(u => u.Username == user.Username))
                return false;

            _users.Add(user);
            return true;
        }

        public User GetUserByUsername(string username)
        {
            return _users.FirstOrDefault(u => u.Username == username);
        }
    }
}
