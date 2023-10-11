
class Program
{
    static void Main()
    {
        string username;
     
        Console.WriteLine("Please provide a username as a command-line parameter.");
        username =  Console.ReadLine();
        Console.WriteLine($"Hello {username}!!!");

        Console.WriteLine("Please provide a username as a command-line parameter.");
        username = Console.ReadLine();

        string customGreeting = CustomLibraryTask1.CustomGreetings.GetGreeting(username);
       
        Console.WriteLine(customGreeting);
    }
}