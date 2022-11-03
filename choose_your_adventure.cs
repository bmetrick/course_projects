using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
      Console.Write("Type YES or NO: ");
      string noiseChoice = Console.ReadLine();
      string noiseChoiceUpper = noiseChoice.ToUpper();

      if (noiseChoiceUpper == "NO")
      {
        Console.WriteLine("Not much of an adventure if we don't leave our room!");
        Console.WriteLine("THE END");
      }

      else if (noiseChoiceUpper == "YES")
      {
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it.");
        Console.WriteLine("Do you open in or knock?");
        Console.Write("Type OPEN or KNOCK: ");
        string doorChoice = Console.ReadLine();
        string doorChoiceUpper = doorChoice.ToUpper();
        Console.WriteLine(doorChoiceUpper);

        if (doorChoiceUpper == "KNOCK")
      {
        Console.WriteLine("A voice from behind the door speaks. It says,");
        Console.WriteLine("\"Answer this riddle\".");
        Console.WriteLine("\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
        Console.Write("Type your answer: ");
        string riddleAnswer = Console.ReadLine();
        string riddleAnswerUpper = riddleAnswer.ToUpper();
        if (riddleAnswerUpper == "NOTHING")
        {
          Console.WriteLine("The door opens and NOTHING is there. You turn off the light and run back to your room and lock the door.");
          Console.WriteLine("THE END");
        }

          else
          {
            Console.WriteLine("You answered incorrectly. The door doesn't open");
            Console.WriteLine("THE END");
          }
      }
      else if (doorChoiceUpper == "OPEN")
      {
        Console.WriteLine("The door is locked See if one of your three keys will open it.");
        Console.Write("Enter a number (1-3): ");
        string keyChoice = Console.ReadLine();
        string keyChoiceUpper = keyChoice.ToUpper();

        switch (keyChoiceUpper)
      {
        case "1":
        Console.WriteLine("You choose the first key. Lucky choice!");
        Console.WriteLine("The door opens and NOTHING is there.");
        Console.WriteLine("THE END");
        break;
        case "2":
        Console.WriteLine("You choose the second key. The door doesn't open.");
        Console.WriteLine("THE END");
        break;
        case "3":
        Console.WriteLine("You choose the third key. The door doesn't open.");
        Console.WriteLine("THE END");
        break;
      }
      }
  }
    }
  }
}
