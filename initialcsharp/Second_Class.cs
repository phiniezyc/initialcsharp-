using System;
using Third_Program;

namespace Second_Program
{
  class Second_Class
  {
    public void Second(string message)
    {
      Console.WriteLine("2nd class is connected and is this is the message: {0}", message);
      Third_Program.Third_Class test_import = new Third_Class();
      test_import.Third("This is the 3rd class. You are connected!");
    }
  }
}