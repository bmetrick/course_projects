using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount to convert to coins:");
string totalAsString = Console.ReadLine();
double totalAsDouble = Convert.ToDouble(totalAsString);
double totalRoundedDown = Math.Floor(totalAsDouble);
Console.WriteLine($"{totalRoundedDown} is equal to...");

//coin variables
int goldValue = 10;
int silverValue = 5;

//do math
double goldCoins = Math.Floor(totalRoundedDown / goldValue);
double leftOver = totalRoundedDown % goldValue;
double silverCoins = Math.Floor(leftOver / silverValue);
leftOver = leftOver % silverValue;

//print values
Console.WriteLine($"Gold coins: {goldCoins}");
Console.WriteLine($"Silver coins: {silverCoins}");
Console.WriteLine($"Bronze coins: {leftOver}");
      
    }
  }
}
