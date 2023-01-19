namespace learngcsharp1;
class Program
{
    static void Main(string[] args)
    {
string username;

        Console.WriteLine("Hello, World!");
        Console.WriteLine("Please Enter Your Name");
        username = Console.ReadLine();
        Console.WriteLine($"Goodbye, {username}!");
        Console.WriteLine("How Are You?");
        Console.ReadKey(true);
    }
}
