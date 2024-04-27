namespace Domain
{
    public class User : BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Email { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}