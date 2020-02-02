using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [TestCase("foo", 0, 0, "foo, -1, 0")]
        [TestCase("Aged Brie", 0, 0, "Aged Brie, -1, 2")]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 0, 0, "Backstage passes to a TAFKAL80ETC concert, -1, 0")]
        [TestCase("Sulfuras, Hand of Ragnaros", 0, 0, "Sulfuras, Hand of Ragnaros, 0, 0")]
        [TestCase("foo", 0, 25, "foo, -1, 23")]
        [TestCase("Aged Brie", 0, 25, "Aged Brie, -1, 27")]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 0, 25, "Backstage passes to a TAFKAL80ETC concert, -1, 0")]
        [TestCase("Sulfuras, Hand of Ragnaros", 0, 25, "Sulfuras, Hand of Ragnaros, 0, 25")]
        [TestCase("foo", 0, 60, "foo, -1, 58")]
        [TestCase("Aged Brie", 0, 60, "Aged Brie, -1, 60")]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 0, 60, "Backstage passes to a TAFKAL80ETC concert, -1, 0")]
        [TestCase("Sulfuras, Hand of Ragnaros", 0, 60, "Sulfuras, Hand of Ragnaros, 0, 60")]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 5, 25, "Backstage passes to a TAFKAL80ETC concert, 4, 28")]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 10, 25, "Backstage passes to a TAFKAL80ETC concert, 9, 27")]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 15, 25, "Backstage passes to a TAFKAL80ETC concert, 14, 26")]
        public void Foo(string name, int sellIn, int quality, string expectedOutput)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality } };
            Items = ItemFactory.CreateChildItems(Items);
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(expectedOutput, Items[0].ToString());
        }
    }
}
