using System;
using Third_Program;

namespace Second_Program
{
  class Second_Class
  {
    public void Second(string message)
    {
      Console.WriteLine("2nd class is connected and is this is the message: {0}", message);
      Second_Program.Second_Class test_import = new Second_Class();
      test_import.Second("yes!");
    }
  }
}