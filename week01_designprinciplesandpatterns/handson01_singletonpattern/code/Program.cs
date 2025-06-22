using System;

class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        logger1.Log("First log message");
        logger2.Log("Second log message");

        // Test if both instances are the same
        if (object.ReferenceEquals(logger1, logger2))
        {
            Console.WriteLine("Both logger instances are the same (singleton works).");
        }
        else
        {
            Console.WriteLine("Different logger instances exist (singleton failed).");
        }
    }
}
