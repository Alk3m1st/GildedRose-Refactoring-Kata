namespace csharp.Items
{
    public class ItemBackstagePasses : Item
    {
        public ItemBackstagePasses(Item item) : base(item) { }

        public override void UpdateQuality()
        {
            IncrementQuality();

            DecrementSellIn();

            if (SellIn >= 0)
                return;

            ResetQuality();
        }

        public override void IncrementQuality()
        {
            if (Quality < 50)
            {
                Quality++;

                if (SellIn < 11 && Quality < 50)
                {
                    Quality++;
                }

                if (SellIn < 6 && Quality < 50)
                {
                    Quality++;
                }
            }
        }
    }
}
