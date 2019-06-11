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
      var tries = 0;
      double nextGuess = Math.Round(Math.Log(max) / Math.Log(2));
      var input = "";
      while (input != "Yes")
      {
        var guess = (lower + upper) / 2;
        Console.WriteLine($"Is {guess} your number?");
        input = Console.ReadLine();
        if (input == "no")
        {
          Console.WriteLine("Is it higher or lower?");
          input = Console.ReadLine();

          if (input == "higher")
          {
            lower = guess + 1;
            tries++;
            Console.Write($"Is {guess} your number?");
          }
          if (input == "lower")
          {
            upper = guess - 1;
            tries++;
          }

        }

      }
    }
  }
}
