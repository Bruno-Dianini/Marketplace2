namespace AppEmpresa
{
 class User
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string UserType { get; private set; }

        public User(string username, string password, string userType)
        {
            Username = username;
            Password = password;
            UserType = userType;
        }

        public virtual void ShowWelcomeMessage()
        {
            Console.WriteLine($"Bem-vindo, {UserType} {Username}!");
        }
    }

    class Vendor : User
    {
        public Vendor(string username, string password) : base(username, password, "vendedor")
        {
        }

        public override void ShowWelcomeMessage()
        {
            Console.WriteLine("Você está logado como vendedor. Página de anúncio de produtos do vendedor.");
        }
    }

    class Customer : User
    {
        public Customer(string username, string password) : base(username, password, "cliente")
        {
        }

        public override void ShowWelcomeMessage()
        {
            Console.WriteLine("Você está logado como cliente. Página de compras do cliente.");
        }
    }
}