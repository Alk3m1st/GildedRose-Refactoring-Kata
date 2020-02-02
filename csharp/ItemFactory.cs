using csharp.Items;
using System.Collections.Generic;

namespace csharp
{
    public static class ItemFactory
    {
        public static IList<Item> CreateChildItems(IList<Item> items)
        {
            var inheritedItems = new List<Item>();

            foreach(var item in items)
            {
                inheritedItems.Add(CreateItem(item));
            }

            return inheritedItems;
        }

        private static Item CreateItem(Item item)
        {
            switch(item.Name)
            {
                case ItemConstants.AgedBrie:
                    return new ItemAgedBrie(item);
                case ItemConstants.BackstagePasses:
                    return new ItemBackstagePasses(item);
                case ItemConstants.Sulfuras:
                    return new ItemSulfuras(item);
                default:
                    return item;
            }
        }
    }
}
