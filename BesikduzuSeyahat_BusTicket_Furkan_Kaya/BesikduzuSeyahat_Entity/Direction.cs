using System.Collections.Generic;

namespace BesikduzuSeyahat.Entity
{
    public class Direction
    {

        public int DirectionId { get; set; }
        public string Start { get; set; }
        public string direction1 { get; set; }
        public string direction2 { get; set; }
        public string direction3 { get; set; }
        public string Finish { get; set; }

        public string Date { get; set; }
        public string Time { get; set; }

        public double Price { get; set; }
        public List<Ticket> Tickets { get; set; }

    }
}
