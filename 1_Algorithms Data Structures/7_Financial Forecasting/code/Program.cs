using System;

class FinancialForecast
{

    public static double Forecast(double principal, double rate, int years)
    {
        if (years == 0)
            return principal;

        return (1 + rate) * Forecast(principal, rate, years - 1);
    }

    static void Main(string[] args)
    {
        double principal = 10000;
        double growthRate = 0.08;
        int years = 5;

        double futureValue = Forecast(principal, growthRate, years);
        Console.WriteLine($"Future value after {years} years: {Math.Round(futureValue, 2)} Rupees.");
    }
}
