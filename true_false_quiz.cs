using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below

      string[] questions = {"Peanuts are NOT nuts?", "The Mona Lisa was stolen from the Louvre in 1911?", "The Great Wall of China is visible from space", "There are more ancient pyramids in Sudan than Egypt?"};

      bool[] answers = {true, true, false, true};
      bool[] responses = new bool [questions.Length];

      if (questions.Length != answers.Length)
      {
        Console.WriteLine("The number of questions and answers does not match.");
      }

      int askingIndex = 0;
      foreach(string question in questions)
      {
        string input;
        bool isBool;
        bool inputBool;
        Console.WriteLine(question);
        Console.WriteLine("True or False? ");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);

        while (!isBool)
        {
          Console.WriteLine("Please respond with 'true' or 'false'");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);
        }

        responses[askingIndex] = inputBool;
          askingIndex++;
      }

      int scoringIndex = 0;
      int score = 0;
      foreach (bool answer in answers)
      {
        bool response = responses[scoringIndex];
        Console.Write(scoringIndex  + 1 + ".");
        Console.WriteLine($"Input: {response} | Answer: {answer}");

        if (response == answer)
        {
          score++;
        }

        scoringIndex++;
      }

      Console.WriteLine($"You got {score} out of {questions.Length} correct!");
}
}
}
