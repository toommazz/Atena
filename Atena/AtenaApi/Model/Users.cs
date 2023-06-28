namespace AtenaApi.Model
{
    public class Users
    {
        public static List<User> User = new List<User>()
        {
            new User() { Username = "tomazini", EmailAddress = "rogerio.tomazini@gmail.com",
            Password = "rtomazini", FirstName = "Rogério", LastName = "Tomazini", Role="Admin" },
            new User() { Username = "sueli", EmailAddress = "sueli.passsareli@gmail.com",
            Password = "spassareli", FirstName = "Sueli", LastName = "Passareli", Role="Master"}
        };
    }
}
