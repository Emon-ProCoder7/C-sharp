using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      BuildACreature("Ghost", "Monster", "Bug");
    }

    static void BuildACreature(string head, string body, string feet){
      switch (head){
        case "Ghost":
          GhostHead();
          break;
        case "Bug":
          BugHead();
          break;
        case "Monster":
          MonsterHead();
          break;
        default:
          Console.WriteLine("Invalid Selection");
          break;
      }
      switch (body){
        case "Ghost":
          GhostBody();
          break;
        case "Bug":
          BugBody();
          break;
        case "Monster":
          MonsterBody();
          break;
        default:
          Console.WriteLine("Invalid Selection");
          break;
      }
      switch (feet){
        case "Ghost":
          GhostFeet();
          break;
        case "Bug":
          BugFeet();
          break;
        case "Monster":
          MonsterFeet();
          break;
        default:
          Console.WriteLine("Invalid Selection");
          break;
      }
    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
