public class User
{
    List<User>users = new List<User>();
    public string FirstName { get; set;}
    public string LastName { get; set;}
    public string Email { get; set;}
    public string DateOfBirth { get; set;}
    public char  Gender { get; set;}
    
    public string Country { get; set;}
    public string StateOfOrigin { get; set;}
    public string Password { get; set;}


    public void Register()
    {
        System.Console.WriteLine("Enter your firstname");
        string FirstName = Console.ReadLine();
        System.Console.WriteLine("Enter your last name");
        string LastName = Console.ReadLine();
        System.Console.WriteLine("Enter your email address");
        string Email = Console.ReadLine();
        System.Console.WriteLine("Enter your password");
       string Password = Console.ReadLine();
        System.Console.WriteLine("Enter your date of birth");
        string DateOfBirth = Console.ReadLine();
        System.Console.WriteLine("Enter your gender m/f");
        char Gender =char.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your state of origin");
        string StateOfOrigin = Console.ReadLine();
        System.Console.WriteLine("Enter your country");
        string Country = Console.ReadLine();
       

        User user= new User();
        user.FirstName = FirstName;
        user.LastName = LastName;
        user.Email = Email;
        user.StateOfOrigin = StateOfOrigin;
        user.Country = Country;
        user.Password = Password;
        user.Gender = Gender;
        user.DateOfBirth = DateOfBirth;

        users.Add(user);
        System.Console.WriteLine($"{user.FirstName} {user.LastName} You have been registered sucessfully");
        Console.ReadKey();
    }
        public User Login()
        {
                
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        foreach (var user in users)
        {
            if (user.Email == email && user.Password == password)
            {
                Console.WriteLine($"Welcome, {user.FirstName} {user.LastName}");
                return user;
            }
        }
             Console.WriteLine("Invalid login credentials. Try again");
          return null ;             
    }
}