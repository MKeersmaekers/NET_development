namespace AutoApp.Models
{
    public class Merk
    {
        public int ID { get; set; }
        public string Name { get; set; }

        //AUTO

        public List<Auto> Autos { get; set; }
    }
}
