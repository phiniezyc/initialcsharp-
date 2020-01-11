using System;
using Test;
namespace initialcsharp
{
  using System.IO;
  class Program
  {
    static void Main(string[] args)
    {
      string[] lines = { "This is a test", "It work!", "Yep!" };
      File.WriteAllLines("csharptest.txt", lines);
      Console.WriteLine("Hello World!\nAloha Engineering");

      string[] fileContents = File.ReadAllLines("csharptest.txt");
      Console.WriteLine(fileContents);

      Test.Second_Program test_import = new Second_Program();
      test_import.Second("yes!");
    }
  }
}
