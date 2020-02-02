namespace csharp.Items
{
    public class ItemBackstagePasses : Item
    {
        public ItemBackstagePasses(Item item) : base(item) { }

        public override void UpdateQuality()
        {
            if (Quality < 50)
            {
                IncrementQuality();

                if (SellIn < 11 && Quality < 50)
                {
                    IncrementQuality();
                }

                if (SellIn < 6 && Quality < 50)
                {
                    IncrementQuality();
                }
            }

            DecrementSellIn();

            if (SellIn >= 0)
                return;

            ResetQuality();
        }
    }
}
