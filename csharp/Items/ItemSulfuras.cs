namespace csharp.Items
{
    public class ItemSulfuras : Item
    {
        public ItemSulfuras(Item item) : base(item) {}

        public override void UpdateQuality()
        {
            // Do nothing for this item type
            return;
        }
    }
}
