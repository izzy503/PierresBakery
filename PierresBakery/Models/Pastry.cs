namespace PierresBakery.Models
{
    public class Party
    {
        public int GuestCount { get; private set; }
        public string Theme { get; private set; }

        public Party(int guestCount, string theme)
        {
            GuestCount = guestCount;
            Theme = theme;
        }

        public void SetGuestCount(int guestCount)
        {
            GuestCount = guestCount;
        }

        public void SetTheme(string theme)
        {
            Theme = theme;
        }
    }
}
