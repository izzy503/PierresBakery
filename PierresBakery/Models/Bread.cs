namespace PierresBakery.Models
{
    public class Bread
    {
        public int Quantity { get; private set; }
        public int SingleLoafPrice { get; set; } = 5;

        public Bread(int quantity)
        {
            Quantity = quantity;
        }

        public int CalculateTotalCost()
        {
            int fullPriceLoaves = Quantity - GetFreeLoaves();
            return fullPriceLoaves * SingleLoafPrice;
        }

        public int GetFreeLoaves()
        {
            return Quantity / 3;
        }

        public double GetEffectivePricePerLoaf()
        {
            return (double)CalculateTotalCost() / Quantity;
        }

        public bool IsEligibleForDiscount()
        {
            return Quantity >= 3;
        }

        public int GetDiscountedLoafCount()
        {
            return Quantity / 3;
        }

        public void UpdatePricePerLoaf(int newPrice)
        {
            SingleLoafPrice = newPrice;
        }

        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }
    }
}
