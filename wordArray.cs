using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;
            
            //your code goes here
            foreach(string x in words){
                if(x.Contains(letter)){
                    Console.WriteLine(x);
                    count++;
                } else if (count == 0 && x == words[words.Length - 1]){
                    Console.WriteLine("No match");
                }
            }
            
        }
    }
}
