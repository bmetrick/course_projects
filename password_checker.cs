using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 10;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz" ;
      string digits = "0123456789" ;
      string specialChars = "!@#$%^&*()";

      Console.WriteLine("Enter a password");
      string password = Console.ReadLine();
      int score = 0;
      int length = password.Length;

      if (length >= minLength)
      {
        score++;
      }

      if (Tools.Contains(password, uppercase))
      {
        score++;
      }

      if (Tools.Contains(password, lowercase))
      {
        score++;
      }

      if (Tools.Contains(password,digits))
      {
        score++;
      }

      if (Tools.Contains(password,specialChars))
      {
        score++;
      }
      Console.WriteLine(score);

switch (score)
{
  case 5:
  case 4:
  Console.WriteLine("Password is extremely strong");
  break;
  case 3:
  Console.WriteLine("Password is strong");
  break;
  case 2:
  Console.WriteLine("Password is medium");
  break;
  case 1:
  Console.WriteLine("Password is weak");
  break;
  default:
  Console.WriteLine("Password does not meet any standards");
  break;
}
    }
  }
}
