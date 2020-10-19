using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      Console.WriteLine("Type in your message");
      string input = Console.ReadLine();
      char[] secretMessage = input.ToCharArray();
      
      char[] encryptedMessage = new char[secretMessage.Length];
      char [] decryptedMessage = new char[secretMessage.Length];
      for(int i = 0; i < secretMessage.Length; i++)
      {
        char cypherLetter = secretMessage[i];
        
        int cypherPosition = Array.IndexOf( alphabet, cypherLetter);
        int newcypherPosition = (cypherPosition + 3) % 26;
        char letterEncoded = alphabet[newcypherPosition];
       
       encryptedMessage[i] = letterEncoded;

      }
      string inComingMessage = String.Join("", encryptedMessage);
        Console.WriteLine(inComingMessage);
    
    for(int i = 0; i < inComingMessage.Length; i++)
      {
        char decypherLetter = inComingMessage[i];
        
        int decypherPosition = Array.IndexOf( alphabet, decypherLetter);
        int newDecypherPosition = (decypherPosition - 3) % 26;
        char decypherLetterEncoded = alphabet[newDecypherPosition];
       
       decryptedMessage[i] = decypherLetterEncoded;

      }

      string decypherMessage = String.Join("", decryptedMessage);
        Console.WriteLine(decypherMessage);
    }

  }
}