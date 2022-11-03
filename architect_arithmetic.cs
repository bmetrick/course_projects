using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      double totalArea = Rect(2500, 1500) + Triangle(750,500) + 0.5 * Circle(375);
      double totalCost = totalArea * 180;
      Console.WriteLine($"My plan costs {Math.Round(totalCost, 2)} Pesos");
    }

    static double Rect(double length, double width)
    {
      return length * width;
    }

    static double Circle(double radius)
    {
      return Math.PI * Math.Pow(radius,2);
    }

    static double Triangle(double bottom, double height)
    {
      return 0.5 * bottom * height;
    }

  }
}
