namespace PierresBakery.Models
{
    public class Pastry
    {
        public int Quantity { get; private set; }
        private const int SinglePastryPrice = 2;

        public Pastry(int quantity)
        {
            Quantity = quantity;
        }

        public int CalculateTotalCost()
        {
            int fullPricePastries = Quantity - (Quantity / 4);
            return fullPricePastries * SinglePastryPrice;
        }

        public int GetFreePastries()
        {
            return Quantity / 4;
        }

        public double GetEffectivePricePerPastry()
        {
            return (double)CalculateTotalCost() / Quantity;
        }

        public bool IsEligibleForDiscount()
        {
            return Quantity >= 4;
        }

        public int GetDiscountedPastryCount()
        {
            return Quantity / 4;
        }

        public void UpdatePricePerPastry(int newPrice)
        {
            SinglePastryPrice = newPrice;
        }

        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }
    }
}
