using System;
using System.Collections.Generic;
using System.Linq;

// Using Top-Level statements feature in c# 9.

for(int i = 1; i<=100; i++)
{
    string a = null;
    if (i % 3 == 0) a = "Fizz";
    if (i % 5 == 0) a += "Buzz";
    Console.WriteLine(a ?? $"{i}");
}


// Single statement with string interpolation

Enumerable.Range(1, 100).ToList().ForEach(n => Console.WriteLine($"{($"{(n % 3 == 0 ? "Fizz" : null)}" + $"{(n % 5 == 0 ? "Buzz" : null)}" is { } res && res  != string.Empty ? res : n)}"));
