using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empro7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int drinks = Convert.ToInt32(Console.ReadLine());
                int shelves = Convert.ToInt32(Console.ReadLine());

                
                Console.WriteLine(drinks/shelves);
            }
            /*
              1. DivideByZeroException => "At least 1 shelf"
              2. FormatException => "Please insert an integer"
            */
            catch (DivideByZeroException e)
            {
                Console.WriteLine("At least 1 shelf");
            }
            catch (FormatException f)
            {
                Console.WriteLine("Please insert an integer");
            }
        }
    }
}
