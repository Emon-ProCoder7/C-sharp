using System;

namespace CaesarCipher
{
  class Program
  {
  
  
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
      
      
      Console.WriteLine("Please Drop your Message\n");
      string msg = Console.ReadLine();
      
      
      char[] secretMessage = msg.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];


      for(int i= 0; i<secretMessage.Length; i++){
        char letter = secretMessage[i];
        int pos = Array.IndexOf(alphabet, letter);
        int cpos = (pos + 3) % alphabet.Length;
        encryptedMessage[i] = alphabet[cpos];
      }
      
      
      String.Join("", encryptedMessage);
      Console.WriteLine(encryptedMessage);
    }
    
    
    
  }
}
