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
            StepOne(item);
            UpdateSellIn(item);
            FinalStep(item);
        }

        private void StepOne(Item item)
        {
            item.UpdateQuality();
        }

        private void UpdateSellIn(Item item)
        {
            if (item.Name != ItemConstants.Sulfuras)
            {
                item.DecrementSellIn();
            }
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
