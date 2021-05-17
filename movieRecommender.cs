using System;

namespace SwitchStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Movie Recommender Engine. Choose a Genre:\n1. Drama\n2. Comedy\n3. Adventure\n4. Horror\n5. Science Fiction.\n\n");
      string genre = Console.ReadLine();
      switch(genre){
        case "Drama":
          Console.WriteLine("Citizen Kane");
          break;
        case "Comedy":
          Console.WriteLine("Duck Soup");
          break;
        case "Adventure":
          Console.WriteLine("King Kong");
          break;
        case "Horror":
          Console.WriteLine("Psycho");
          break;
        case "Science Fiction":
          Console.WriteLine("2001: A Space Odyssey");
          break;
        default:
          Console.WriteLine("No movie found");
          break;    

      }

    }
  }
}
