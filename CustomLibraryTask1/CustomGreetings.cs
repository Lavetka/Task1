using System;

namespace CustomLibraryTask1
{
    public static class CustomGreetings
    {
        public static string GetGreeting(string username)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            return $"{currentTime} Hello, {username}!";
        }
    }
}

