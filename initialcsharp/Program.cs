using System;

namespace initialcsharp
{
  using System.IO;
  class Program
  {
    static void Main(string[] args)
    {
      string[] lines = { "Testing", "It work! You know it", "You know it!" };
      File.WriteAllLines("csharptest.txt", lines);
      Console.WriteLine("Hello World!!!!!!!!\nAloha Engineering");

      string[] fileContents = File.ReadAllLines("csharptest.txt");
      Console.WriteLine(fileContents);
    }
  }
}
