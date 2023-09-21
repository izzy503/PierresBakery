using System;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.Write("Enter the number of breads you want to buy: ");
      int breadQuantity = int.Parse(Console.ReadLine());

      Console.Write("Enter the price per bread: ");
      int breadPrice = int.Parse(Console.ReadLine());

      Bread newBread = new Bread(breadQuantity, breadPrice);
      Console.WriteLine($"The total cost for bread is: {newBread.CalculateTotalCost()}");

      Console.Write("Enter the number of guests for the party: ");
      int guestCount = int.Parse(Console.ReadLine());

      Console.Write("Enter the theme of the party: ");
      string partyTheme = Console.ReadLine();

      Party newParty = new Party(guestCount, partyTheme);
      Console.WriteLine($"The party is set for {newParty.GuestCount} guests with the theme: {newParty.Theme}");
    }
  }
}
