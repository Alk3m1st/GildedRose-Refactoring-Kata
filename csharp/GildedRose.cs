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
            if (item.Name != ItemConstants.AgedBrie && item.Name != ItemConstants.BackstagePasses)
            {
                if (item.Quality > 0)
                {
                    if (item.Name != ItemConstants.Sulfuras)
                    {
                        item.DecrementQuality();
                    }
                }
            }
            else
            {
                if (item.Quality < 50)
                {
                    item.IncrementQuality();

                    if (item.Name == ItemConstants.BackstagePasses)
                    {
                        if (item.SellIn < 11)
                        {
                            if (item.Quality < 50)
                            {
                                item.IncrementQuality();
                            }
                        }

                        if (item.SellIn < 6)
                        {
                            if (item.Quality < 50)
                            {
                                item.IncrementQuality();
                            }
                        }
                    }
                }
            }

            if (item.Name != ItemConstants.Sulfuras)
            {
                item.DecrementSellIn();
            }

            if (item.SellIn < 0)
            {
                if (item.Name != ItemConstants.AgedBrie)
                {
                    if (item.Name != ItemConstants.BackstagePasses)
                    {
                        if (item.Quality > 0)
                        {
                            if (item.Name != ItemConstants.Sulfuras)
                            {
                                item.DecrementQuality();
                            }
                        }
                    }
                    else
                    {
                        item.ResetQuality();
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.IncrementQuality();
                    }
                }
            }
        }
    }
}
