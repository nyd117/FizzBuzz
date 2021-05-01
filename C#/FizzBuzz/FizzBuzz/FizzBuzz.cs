using System;

// Using Top-Level statements feature in c# 9.

for(int i = 1; i<=100; i++)
{
    string a = null;
    if (i % 3 == 0) a = "Fizz";
    if (i % 5 == 0) a += "Buzz";
    Console.WriteLine(a ?? $"{i}");
}


