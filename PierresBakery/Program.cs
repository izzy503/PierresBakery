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

      Pastry newBread = new Pastry(PastryQuantity,);
      Console.WriteLine($"The total cost for pastry is: {newPastry.CalculateTotalCost()}");

      Console.Write("Enter the number of pastries you want to buy: ");
      int pastryQuantity = int.Parse(Console.ReadLine());

      Console.Write("Enter the price per pastry: ");
      int breadPrice = int.Parse(Console.ReadLine());

      Pastry newPastry = new Pastry(pastryQuantity,);
      Console.WriteLine($"The total cost for pastry is: {newPastry.CalculateTotalCost()}");
    }
  }
}
