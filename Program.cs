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
      int lower = min;
      int upper = max;
      double nextGuess = Math.Round(Math.Log(max) / Math.Log(2));


    }
  }
}
