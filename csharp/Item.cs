using System;

namespace csharp
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public Item(Item item)
        {
            Name = item.Name;
            Quality = item.Quality;
            SellIn = item.SellIn;
        }

        public Item() { }

        public override string ToString()
        {
            return Name + ", " + SellIn + ", " + Quality;
        }

        public virtual void UpdateQuality()
        {
            // Base method
            if (Quality > 0)
            {
                DecrementQuality();
            }

            DecrementSellIn();

            if (SellIn >= 0)
                return;

            if (Quality > 0)
            {
                DecrementQuality();
            }
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
