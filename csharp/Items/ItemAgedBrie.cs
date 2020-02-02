namespace csharp.Items
{
    public class ItemAgedBrie : Item
    {
        public ItemAgedBrie(Item item) : base(item) { }

        public override void UpdateQuality()
        {
            if (Quality < 50)
            {
                IncrementQuality();
            }

            DecrementSellIn();

            if (SellIn >= 0)
                return;

            if (Quality < 50)
            {
                IncrementQuality();
            }
        }
    }
}
