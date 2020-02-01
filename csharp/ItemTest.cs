using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class ItemTest
    {
        [Test]
        public void toString()
        {
            var item = new Item { Name = "name", Quality = 10, SellIn = 20 };

            var expectedOutput = "name, 20, 10";

            Assert.AreEqual(expectedOutput, item.ToString());
        }
    }
}
