using System;

namespace Palindromes
{
  public class Palindrome
  {
    static public string PalindromeCheck(string inputWord)
    {

      char[] letters = inputWord.ToCharArray();

      // Console.WriteLine("[{0}]", string.Join("", letters));
      Array.Reverse(letters);
      //Console.WriteLine("[{0}]", string.Join("", letters));

      string reverseWord = String.Join("", letters);
      //Console.WriteLine(inputWord);

      if (reverseWord == inputWord)
      {
        return "Is a Palindrome";
      }
      else
      {
        return "Not a Palindrome";
      }
    }

    static public string alternatePalindromeCheck(string inputWords)
    {
      for (int i = 0, j = inputWords.Length - 1; i < inputWords.Length / 2; i++, j--)
      {
        if (inputWords[i] != inputWords[j])
        {
          return "Not a Palindrome";
        }
      }
      return "Is a Palindrome";
    }
  }

}