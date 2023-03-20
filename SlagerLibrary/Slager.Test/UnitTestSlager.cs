using SlagerLibrary;

namespace Slager.Test
{
    [TestClass]
    public class UnitTestSlager
    {
        [TestMethod]
        public void AddItem_OrderList_Count1()
        {
            //arange
            Order order = new Order();
            //List<Item> orderItemList = new List<Item>();
            Item item = new Item("hesp", 200);
            //act
            List<Item> items = order.AddItem(item);

            //assert
            Assert.AreEqual(1, items.Count);
        }
        [TestMethod]
        public void AddItem_OrderList_2items_Count1()
        {
            //arange
            Order order = new Order();
            //List<Item> orderItemList = new List<Item>();
            Item item = new Item("hesp", 200);
            Item item2 = new Item("kalkoenfilet", 400);
            //act
            order.AddItem(item);
            order.AddItem(item2);

            //assert
            Assert.AreEqual(2, order.OrderItems.Count);
        }
        [TestMethod]
        public void TotalPrice_OrderList_25()
        {
            //arange
            Order order = new Order();
            //act
            Item item = new Item("spek", 500, 50);

            order.AddItem(item);

            //assert
            Assert.AreEqual(25, order.CalculateTotal());
        }
        [TestMethod]
        public void TotalPrice_2Items_OrderList_25()
        {
            //arange
            Order order = new Order();
            //act
            Item item = new Item("spek", 500, 50);
            Item item2 = new Item("jpate", 100, 10);

            order.AddItem(item);
            order.AddItem(item2);

            //assert
            Assert.AreEqual(26, order.CalculateTotal());
        }
    }
}