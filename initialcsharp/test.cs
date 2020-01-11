using System;

namespace test
{
  using System.IO;
  class Program
  {
    static void Second(string[] args)
    {
      Console.WriteLine("Hello World!!!!!!!!\nAloha Engineering");

      string[] fileContents = File.ReadAllLines("csharptest.txt");
      Console.WriteLine(fileContents);
    }
  }
}