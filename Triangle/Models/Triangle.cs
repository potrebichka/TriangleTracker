using System; 
using System.Collections.Generic;

namespace Tri
{

  public class TriangleTracker
  {
    static void Main()
    {
      Console.WriteLine("Enter side 1:");
      int Side1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter side 2:");
      int Side2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter side 3:");
      int Side3 = int.Parse(Console.ReadLine());
      Triangle currentTriangle = new Triangle (Side1, Side2, Side3);
      Console.WriteLine(currentTriangle.TriangleType());
    }
  }

  public class Triangle
  {
    public int Side1;
    public int Side2;
    public int Side3;

    public Triangle(int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }

    public string TriangleType()
    {
      if (Side1 > (Side2 + Side3) || Side2 > (Side1 + Side3) || Side3 > (Side2 + Side1))
      {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Red;
        return ("It's not a Triangle!");
      }
      else if (Side1 == Side2 && Side2 == Side3)
      {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Green;
        return ("It's an Equilateral Triangle!");
      }
      else if (Side1 == Side2 || Side2 == Side3 || Side1 == Side3)
      {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Blue;
        return ("It's an Isosceles Triangle!");
      }
      else 
      {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Yellow;
        return ("It's a Scalene Triangle!");
      }
    }
  }
    
}