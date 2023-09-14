namespace PierresBakery.Models
{
    public class Bread
    {
        public int Quantity { get; private set; }
        public int Price { get; private set; }

        public Bread(int quantity, int price)
        {
            Quantity = quantity;
            Price = price;
        }

        public int CalculateTotalCost()
        {
            return Quantity * Price;
        }

        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }
    }
}
