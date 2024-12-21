using System;
using System.Collections.Generic;

namespace LoginFormExample
{
    public class AuthenticationService
    {
        private List<User> users;

        public AuthenticationService()
        {
            users = new List<User>
            {
                new User("admin", "admin123", "Admin"),
                new User("user1", "password1", "User"),
                new User("user2", "password2", "User")
            };
        }

        public bool ValidateUser(string username, string password)
        {
            foreach (var user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
