namespace BakeryApp.Models
{
  public class Bread
  {
    public int Quantity { get; set; }

    public Bread(int quantity)
    {
      Quantity = quantity;
    }

    public int GetCost()
    {
      // The business logic for calculating the cost of bread will be implemented here.
      return 0; // Placeholder return value
    }
  }
}
