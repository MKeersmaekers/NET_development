namespace SlagerLibrary
{
    public class Item
    {
        public Item(string name, double weight, double price = 0)
        {
            Name = name;
            Weight = weight;
            Price = price;
        }

        public string Name { get; }
        public double Weight { get; }
        public double Price { get; } //per kilo
    }
}