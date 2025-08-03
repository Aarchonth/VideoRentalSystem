class Movie
{
    public string Title { get; set; }
}
class VideoLibrary
{
    List<Movie> library { get; set; } = new List<Movie>();
}
class User
{
    public string Name { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; }
}
enum Role
{
    User,
    Admin
}
class UserInteraction
{
    //public UserManagment userManagment = new UserManagment();
    public static void HandleRegister(UserManagment userManagment)
    {
        Console.WriteLine("Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Password:");
        string password = Console.ReadLine();
        Console.WriteLine("Repeat Password:");
        string pwRepeat = Console.ReadLine();
        if (password != pwRepeat)
        {
            Console.WriteLine("Passwords do not match. Registration cancelled.");
            return;
        }
        userManagment.Register(name, password);
        Console.WriteLine($"Your Account {name} was Succesfully added");
    }
    public static void HandleLogIn(UserManagment userManagment)
    {
        Console.WriteLine("Please enter your username:");
        string enteredUsername = Console.ReadLine();

        Console.WriteLine("Please enter your password:");
        string enteredPassword = Console.ReadLine();

        User user = userManagment.LogIn(enteredUsername, enteredPassword);
        if(user == null)
        {
            Console.WriteLine("Login failed. Incorrect username or password.");
        }
        else
        {
            Console.WriteLine($"Welcome back, {user.Name}!");
        }


    }
}
class UserManagment
{
    public User LogIn(string username, string password) 
    {
        foreach (User acc in users) 
        {
            return acc;
        }
        return null;
    }
   
    public List<User> users { get; set; } = new List<User>();
    public void Register(string name, string password)
    {

        User user = new User
        {
            Name = name,
            Password = password,
            Role = Role.User
        };
        users.Add(user);
    }

    public void AdminManager()
    {
        User Admin = new User
        {
            Name = "Aaron",
            Password = "1234",
            Role = Role.Admin
        };
        users.Add(Admin);
    }
}

class Program
{
    public static void Main()
    {

    }
}