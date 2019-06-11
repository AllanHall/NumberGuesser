﻿using System;

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
      var guess = (lower + upper) / 2;

      Console.WriteLine($"Is {guess} your number?");
      var input = Console.ReadLine();
      while (input != "Yes")
      {
        Console.WriteLine("Is it higher or lower?");
        if (input == "higher")
        {
          lower = guess + 1;
          tries++;
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
