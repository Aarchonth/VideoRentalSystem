using System.Reflection.Metadata;

class Movie
{
    public string Title {  get; set; }
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
class UserManagment 
{
    public List<User> users { get; set; } = new List<User>();
    public void Register()
    {
        Console.WriteLine("Name:");
        User user = new User 
        {
            Name = Console.ReadLine(),
            Role = Role.User
        };
        Console.WriteLine("Password:");
        string pw = Console.ReadLine();
        Console.WriteLine("Repeat Password ");
        string pwRepeat = Console.ReadLine();
        if (pw != pwRepeat)
        {
            Console.WriteLine("Passwords do not match. Registration cancelled.");
            return;
        }
        user.Password = pw;
        users.Add(user);
        Console.WriteLine($"Your Account {user.Name} was Succesfully added");
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