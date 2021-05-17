using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      // A Short test run.
      Console.WriteLine(Rect(4, 5));
      Console.WriteLine(Circ(4));
      Console.WriteLine(Tri(10, 9));
// -------------------------ends here.


      double Rectangle = Rect(1500, 2500);

      double Radius = 375 / 2;
      double Circle = Circ(Radius);
      double Triangle = Tri(750, 500);

      double area = Rectangle + Circle + Triangle; 

/* 
Multiplying the total area by the cost of flooring material – 180 Mexican pesos 
 */

      double totalCost = area * 180;
      totalCost = Math.Round(totalCost, 2);
      Console.WriteLine($"My plan costs: {totalCost} pesos");
    }
    static double Rect(double length, double width){
      double area = length * width;
       return area;
    }
    static double Circ(double radius){
       double area = Math.PI * Math.Pow(radius, 2);
       return area;
    }
    static double Tri(double bottom, double height){
       double area = 0.5 * bottom * height;
       return area;
    }
  }
}
