using System;

namespace NumberGuesser
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      const int min = 1;
      const int max = 100;
      var lower = min;
      var upper = max;
      int tries = 0;
      double nextGuess = Math.Round(Math.Log(max) / Math.Log(2));
      var guess = (lower + upper) / 2;
      var correctGuess = 33;

      Console.WriteLine(nextGuess);
      while (correctGuess != nextGuess)
      {
        if (nextGuess > correctGuess)
        {
          return (lower = guess + 1) && tries++;
        }
        if (nextGuess < correctGuess)
        {
          return (upper = guess - 1) && tries++;

        }

      }
    }
  }
}
