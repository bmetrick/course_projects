using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      Console.Write("Enter your secret message: ");
      string input = Console.ReadLine();
      string inputLower = input.ToLower();
      char[] secretMessage = inputLower.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];

     for (int i=0; i<secretMessage.Length; i++)

  {

    char letter = secretMessage[i];

    if (Array.IndexOf(alphabet,letter)!=-1)

    {

      int newLetterPos = ((Array.IndexOf(alphabet,letter))+3)%26;

      encryptedMessage [i] = alphabet[newLetterPos];

    }

    else

    {

      encryptedMessage [i] = secretMessage[i];

    }

  }
  string encodedString = String.Join("", encryptedMessage);
      Console.WriteLine($"Your encoded message is: {encodedString}");

    }
  }
}
