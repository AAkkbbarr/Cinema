namespace Domain
{
    public class Ticket : BaseEntity
    {
        public int SeatNumber { get; set; }
        public decimal Price { get; set; }
    }
}