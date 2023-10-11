namespace GreetingService;

public class GreetingService
{
    public static string GetGreeting(string username)
    {
        string currentTime = DateTime.Now.ToString("HH:mm:ss");
        return $"{currentTime} Hello, {username}!";
    }
}

