using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach(var item in Items)
            {
                UpdateItemQuality(item);
            }
        }

        private void UpdateItemQuality(Item item)
        {
            item.UpdateQuality();
            FinalStep(item);
        }

        private void FinalStep(Item item)
        {
            if (item.SellIn >= 0)
                return;

            if (item.Name == ItemConstants.AgedBrie)
            {
                if (item.Quality < 50)
                {
                    item.IncrementQuality();
                }
            }
            else if (item.Name == ItemConstants.BackstagePasses)
            {
                item.ResetQuality();
            }
            else if (item.Name != ItemConstants.Sulfuras && item.Quality > 0)
            {
                item.DecrementQuality();
            }
        }
    }
}
