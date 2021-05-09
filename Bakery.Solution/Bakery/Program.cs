using System;
using Pastry.Models;
using Bread.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello! Welcome to Pierres, what would you like to order? loaves are 1 for 5 dollars and buy 2 get 1 free, and pastries and 2 dollars each with a 3 for 5 deal. Enter 'b' for bread and/or 'p' for pastry!");
      String Pob = Console.ReadLine().ToLower();
      if (Pob == "bp" || Pob == "pb")
      {
        Console.WriteLine("How many loaves of bread would you like? Enter a number");
        string strBread = Console.ReadLine();
        int Bread = int.Parse(strBread);

        Console.WriteLine("How many pastries would you like?");
        //int Pastry = int.Parse(Console.ReadLine());
        Console.WriteLine("Thank you, your order total is below!");
        //int PastryTotal = Pastry.PriceCalc(Pastry);
        BreadOrder newBreadOrder = new BreadOrder(Bread);
        int BreadTotal = BreadOrder.PriceCalc(newBreadOrder.BreadAmount);
        Console.WriteLine(BreadTotal);
      }
      // else if (Pob == "p")
      // {
      //   Console.WriteLine("How many pastries would you like?");
      //   int Pastry = int.Parse(Console.ReadLine());
      //   Console.WriteLine("Thank you, your order total is below!");
      //   int PastryTotal = Pastry.PriceCalc(Pastry);
      //   Console.WriteLine(PastryTotal);
      // }
      // else if (Pob == "b")
      // {
      //   Console.WriteLine("How many loaves of bread would you like? Enter a number");
      //   int Bread = int.Parse(Console.ReadLine());
      //   Console.WriteLine("Thank you, your order total is below!");
      //   int BreadTotal = Bread.PriceCalc(Bread);
      //   Console.WriteLine(BreadTotal);
      // } 
      // else 
      // {
      //   Console.WriteLine("We're sorry, something went wrong. Please try again with the response 'p' and/or 'b'. Thank you!");
      //   Main();
      // }

      
    }
  }
}
