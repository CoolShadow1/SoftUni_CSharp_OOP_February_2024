﻿namespace Stealer;

public class StartUp
{
    public static void Main()
    {
        Spy spy = new();
        Console.WriteLine(spy.AnalyzeAccessModifiers("Stealer.Hacker"));
    }
}