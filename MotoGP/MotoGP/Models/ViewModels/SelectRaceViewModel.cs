using Microsoft.AspNetCore.Mvc.Rendering;

namespace MotoGP.Models.ViewModels
{
    public class SelectRaceViewModel
    {
        public List<Race>? showraces { get; set; }
        public SelectList? Races { get; set; }
        public int raceID { get; set; }
    }
}
