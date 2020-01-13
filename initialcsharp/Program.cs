using System;
using Second_Program;
namespace initialcsharp
{
  using System.IO;
  class Program
  {
    static void Main(string[] args)
    {
      string[] lines = { "This is a test", "It works!", "Yep!" };
      File.WriteAllLines("csharptest.txt", lines);
      Console.WriteLine("Hello World!\nAloha Engineering");

      string[] fileContents = File.ReadAllLines("csharptest.txt");
      Console.WriteLine(fileContents);

      Second_Program.Second_Class test_import = new Second_Class();
      test_import.Second("yes!");
    }
  }
}
