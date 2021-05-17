using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
This program does
Mad-libs.
 
Author: Emon-Procoder7
      */

      Console.WriteLine("Mad Libs is Starting.........\n\n");
      


      // Giving the Mad Lib a title:
      string title = "Poetic Thrill\n";

      Console.WriteLine(title);
      // Defining user input and variables:
      Console.WriteLine("Enter a name: ");
      string name = Console.ReadLine();

      Console.WriteLine("\nEnter Three Adjectives: ");
      string adj1 = Console.ReadLine();
      string adj2 = Console.ReadLine();
      string adj3 = Console.ReadLine();

      Console.WriteLine("\nEnter a verb: ");
      string verb = Console.ReadLine();

      Console.WriteLine("\nEnter Two Nouns: ");
      string noun1 = Console.ReadLine();
      string noun2 = Console.ReadLine();


      Console.WriteLine("\n\nInput one of each of the following:\nAn animal\nA food\nA fruit\nA superhero\nA country\nA dessert\nA year");
      string animal = Console.ReadLine();
      string food = Console.ReadLine();
      string fruit = Console.ReadLine();
      string superhero = Console.ReadLine();
      string country = Console.ReadLine();
      string dessert = Console.ReadLine();
      string year = Console.ReadLine();



      // The template for the story:

      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Printing the story:
      Console.WriteLine(story);
    }
  }
}
