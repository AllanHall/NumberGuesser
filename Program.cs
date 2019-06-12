using System;

namespace NumberGuesser
{
  class Program
  {
    static void Main(string[] args)
    {
      var playing = true;
      while (playing)
      {
        Console.WriteLine("Welcome! Pick a number between 1 and 100 and I will figure it out...");
        const int min = 1;
        const int max = 100;
        var lower = min;
        var upper = max;
        var tries = 0;
        double nextGuess = Math.Round(Math.Log(max) / Math.Log(2));
        var input = "";

        while (input != "yes")
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
            }
            if (input == "lower")
            {
              upper = guess - 1;
              tries++;
            }

          }

        }
        // play again logic
        Console.WriteLine("I knew I'd get it! Press 'y' to play again, and any other key to exit");


        if (Console.ReadLine() != "y")
        {
          //toggle the playing
          playing = false;

        }
      }
    }
  }
}
