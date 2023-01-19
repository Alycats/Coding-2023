namespace learngcsharp1;
class Program
{
    static void Main(string[] args)
    {
string username;

string response;

        Console.WriteLine("Hello, World!");
        Console.WriteLine("Please Enter Your Name");
        username = Console.ReadLine();
        Console.WriteLine("How Are You?");
        response = Console.ReadLine();
        Console.WriteLine($"{response}?");
        Console.WriteLine($"Goodbye, {username}!");
        Console.ReadKey(true);
    }
}
