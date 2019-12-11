using System;

namespace NumberGuesser
{
  class Program
  {
    static void PlayGame()
    {
      string response = "";
      int attempts = 1;
      int currentNumber = 50;
      int[] incrementBy = new int[] { 25, 12, 6, 3, 1, 1 };
      for (int i = 0; i < 8; i++)
      {
        Console.WriteLine(" ");
        Console.WriteLine($"This is attempt #{attempts}.");
        Console.WriteLine(" ");
        Console.WriteLine($"Is your number {currentNumber}.");
        Console.WriteLine(" ");
        Console.WriteLine("  Type 'y' for yes.");
        Console.WriteLine("  Type 'l' for lower.");
        Console.WriteLine("  Type 'h' for higher.");
        response = Console.ReadLine();
        if (response == "y")
        {
          Console.WriteLine(" ");
          Console.WriteLine($"We guessed your number in {attempts} attempts.");
          Console.WriteLine(" ");
          Console.WriteLine("Thank you for playing!");
          Console.WriteLine(" ");
          i = 8;
        }
        else if (response == "l")
        {
          currentNumber = currentNumber - incrementBy[i];
        }
        else if (response == "h")
        {
          currentNumber = currentNumber + incrementBy[i];
        }
        else if (i == 6)
        {
          Console.WriteLine(" ");
          Console.WriteLine($"That was attempt #{attempts}.");
          Console.WriteLine(" ");
          Console.WriteLine($"It is logically impossible for your number to not have been guessed.");
          Console.WriteLine(" ");
          Console.WriteLine($"You have been disqualified. Bye, Felecia!");
          Console.WriteLine(" ");
        }

        attempts++;
      }
    }
    static void Main(string[] args)
    {
      // Declare variables
      string response;

      // Ask user if it is OK to continue
      Console.WriteLine(" ");
      Console.WriteLine("Think of a number from 1 to 100.");
      Console.WriteLine(" ");
      Console.WriteLine("I will be able to guess in 7 tries or less.");
      Console.WriteLine(" ");
      Console.WriteLine("OK? Type 'y' for 'yes' .");

      // Get user's initial response
      response = Console.ReadLine();

      // If user entered 'y' continue the game, otherwise say 'bye' and exit application.
      if (response == "y")
      {
        PlayGame();
      }
      else
      {
        Console.WriteLine("Your response was '" + response + "' not 'y'. So bye, Felecia!");
      }
      Console.WriteLine("!!!!!EXITING GAME!!!!!");
    }
  }
}
