namespace BesikduzuSeyahat.Entity
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string PassengerName { get; set; }
        public string PassengerSurname { get; set; }
        public string PassengerMail { get; set; }
        public string PassengerTel { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public int SeatNo { get; set; }
        public double Price { get; set; }
        public Direction direction { get; set; }
        public int DirectionId { get; set; }
    }
}
