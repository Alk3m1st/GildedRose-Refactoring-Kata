namespace csharp
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override string ToString()
        {
            return Name + ", " + SellIn + ", " + Quality;
        }

        public void IncrementQuality()
        {
            Quality++;
        }

        public void DecrementQuality()
        {
            Quality--;
        }

        public void DecrementSellIn()
        {
            SellIn--;
        }

        public void ResetQuality()
        {
            Quality = 0;
        }
    }
}
