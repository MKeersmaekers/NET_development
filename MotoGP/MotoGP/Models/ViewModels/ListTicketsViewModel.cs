using Microsoft.AspNetCore.Mvc.Rendering;

namespace MotoGP.Models.ViewModels
{
    public class ListTicketsViewModel
    {
        public List<Ticket> Tickets;
        public List<Country> Countries;
        public SelectList Races { get; set; }
        public int ticketID { get; set; }
    }
}
