namespace AutoApp.Models
{
    public class Auto
    {
        public int ID { get; set; } //PK
        public string Nickname { get; set; }
        public string Chassisnr { get; set; }

        //MERK

        public Merk Merk { get; set; }

    }
}
