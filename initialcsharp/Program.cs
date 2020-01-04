using System;

namespace initialcsharp
{
    using System.IO;
    class Program
    {
        static void Main(string[] args)
        {
            string [] lines = { "This is a test", "It work!", "Yep!" };
            File.WriteAllLines("csharptest.txt", lines);
            Console.WriteLine("Hello World!!!\nAloha NCR");
        }
    }
}
