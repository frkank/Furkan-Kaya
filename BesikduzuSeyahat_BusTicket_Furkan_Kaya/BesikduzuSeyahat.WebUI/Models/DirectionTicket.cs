using BesikduzuSeyahat.Entity;
using System.Collections.Generic;

namespace BesikduzuSeyahat.WebUI.Models
{
    public class DirectionTicket
    {
        public List<Ticket> Tickets { get; set; }
        public List<Direction> Directions { get; set; }
        public List<City> Cities { get; set; }
        public Direction NewDirection { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public Ticket Ticket { get; set; }
    }
}
