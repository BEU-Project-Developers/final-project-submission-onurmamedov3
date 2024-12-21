namespace LoginFormExample
{
    public class User
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }

        public User(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }
}
