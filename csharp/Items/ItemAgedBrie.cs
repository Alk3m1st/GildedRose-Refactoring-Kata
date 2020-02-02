namespace csharp.Items
{
    public class ItemAgedBrie : Item
    {
        public ItemAgedBrie(Item item) : base(item) { }

        public override void UpdateQuality()
        {
            IncrementQuality();

            DecrementSellIn();

            if (SellIn >= 0)
                return;

            IncrementQuality();
        }

        public override void IncrementQuality()
        {
            if (Quality < 50)
            {
                Quality++;
            }
        }
    }
}
