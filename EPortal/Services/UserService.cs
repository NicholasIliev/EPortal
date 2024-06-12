using System;
using EPortal.Models;

namespace EPortal.Services
{
    public class UserService : IUserService
    {
        public virtual bool RegisterUser(User user)
        {
            try
            {
                if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
                {
                    throw new ArgumentException("Username and password are required.");
                }

                if (UserExists(user.Username))
                {
                    throw new InvalidOperationException("Username already exists.");
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error registering user: {ex.Message}");
                return false;
            }
        }

        public virtual bool UserExists(string username)
        {
            // TODO

            return false;
        }

        private void saveUserToDatabase(User user)
        {
            // TODO
        }
    }
}
