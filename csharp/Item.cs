﻿using System;

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

        public void UpdateQuality()
        {
            switch(Name)
            {
                case ItemConstants.AgedBrie:
                    UpdateQualityAgedBrie();
                    break;
                case ItemConstants.BackstagePasses:
                    UpdateQualityBackstagePasses();
                    break;
                default:
                    UpdateQualityDefault();
                    break;
            }
        }

        private void UpdateQualityDefault()
        {
            if (Quality > 0)
            {
                if (Name != ItemConstants.Sulfuras)
                {
                    DecrementQuality();
                }
            }
        }

        private void UpdateQualityBackstagePasses()
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
        }

        private void UpdateQualityAgedBrie()
        {
            if (Quality < 50)
            {
                IncrementQuality();
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
