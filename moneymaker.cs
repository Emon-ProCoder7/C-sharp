using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!\n\n");
      Console.WriteLine($"Gold Coins = 10 cent");
      Console.WriteLine($"Silver Coins = 5 cents");
      Console.WriteLine($"Bronze Coins = 1 cent\n");
      Console.WriteLine("Enter an amount to convert to coins:");
string totalAsString = Console.ReadLine();
       double total = Convert.ToDouble(totalAsString);
       Console.WriteLine($"{total} cents is equal to...\n");
       int silverValue = 5;
       int goldValue = 10;
       double goldCoins = Math.Floor(total/goldValue);

       double remains = total % goldValue;

       double silverCoins = Math.Floor(remains / silverValue);
       remains = remains % silverValue;

      Console.WriteLine($"Gold Coins: {goldCoins}");
      Console.WriteLine($"Silver Coins: {silverCoins}");
      Console.WriteLine($"Bronze Coins: {remains}");
      
    }
  }
}
