using System;

public class Logger
{
    private static readonly Logger _instance = new Logger();

    private Logger()
    {
        Console.WriteLine("Logger instance created.");
    }
    public static Logger GetInstance()
    {
        return _instance;
    }
    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}
