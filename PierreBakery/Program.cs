using System;
using PierreBakery.Models;

class Program
{

  public static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("Bread = $5 ------ Pastries = $2");
    Console.WriteLine("Today's specials:");
    Console.WriteLine("- Bread: buy 2 loaves of bread get 1 Free");
    Console.WriteLine("- Pastries: 3 for $5, 4 for $7, 5 for $9 or 6 for $10");
    Console.WriteLine("Would you like to order bread? (yes/no)");
    string userBread = Console.ReadLine().ToLower();
    if (userBread == "yes")
    {
      Console.WriteLine("How many loaves? (max: 3)");
      int userBreadAmount = int.Parse(Console.ReadLine());
    }
      else
      {
        Console.WriteLine("Would you like to order pastries? (yes/no)");
        string userPastry = Console.ReadLine().ToLower();
        if (userPastry == "yes")
        {
          Console.WriteLine("How many pastries? (max: 6)");
          int userPastryAmount = int.Parse(Console.ReadLine());
        }
          else
          {
            Console.WriteLine("Return to 'main menu' or 'exit'? (main/exit)");
            string userEnd = Console.ReadLine().ToLower();
            if (userEnd == "main")
            {
              Main();
            }
              else
              {
                Environment.Exit(0);
              }
          }
      }
    Main();
  }
}