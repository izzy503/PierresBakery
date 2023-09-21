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


      Bread newBread = new bread(breadQuantity);
      Console.WriteLine($"The total cost for bread is: {newBread.CalculateTotalCost()}");

      Console.Write("Enter the number of pastry you want to buy: ");
      int pastryQuantity = int.Parse(Console.ReadLine());

      Pastry newPastry = new Pastry(pastryQuantity);
      Console.WriteLine($"The total cost for pastry is: {newPastry.CalculateTotalCost()}");
    }
  }
}
