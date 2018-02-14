
using System;
using System.Threading;
using System.Diagnostics;

public class TestPerfCounter
{
    static PerformanceCounter myCounter;

    public static void Main()
    {
        if (!PerformanceCounterCategory.Exists("Processor"))
        {
            Console.WriteLine("Object Processor does not exist!");
            return;
        }

        if (!PerformanceCounterCategory.CounterExists(@"% Processor Time", "Processor"))
        {
            Console.WriteLine(@"Counter % Processor Time does not exist!");
            return;
        }

        myCounter = new PerformanceCounter("Processor", @"% Processor Time", @"_Total");

        // The raw value of a counter can be set in your applications as shown below
        // if the object is not read-only
        try
        {
            myCounter.RawValue = 19;
        }

        catch
        {
            Console.WriteLine(@"Processor, % Processor Time, _Total instance is READONLY!");
        }

        Console.WriteLine(@"Press 'CTRL+C' to quit...");

        while (true)
        {
            Console.WriteLine("@");

            try
            {
                Console.WriteLine(@"Current value of Processor, %Processor Time, _Total= " + myCounter.NextValue().ToString());
            }

            catch
            {
                Console.WriteLine(@"_Total instance does not exist!");
                return;
            }

            Thread.Sleep(1000);
            Console.WriteLine(@"Press 'CTRL+C' to quit...");
        }
    }
}