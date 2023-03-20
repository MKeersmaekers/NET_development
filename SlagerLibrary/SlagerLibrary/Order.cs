namespace SlagerLibrary
{
    public class Order
    {
        public List<Item> OrderItems { get; set; } //NULL
        public Order()
        {
            OrderItems = new List<Item>(); //LEGE LIJST
        }
        public List<Item> AddItem(Item item)
        {
            OrderItems.Add(item);
            return OrderItems;
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (Item item in OrderItems)
            {
                total += item.Price * (item.Weight / 1000);
            }
            return total;
        }
    }
}