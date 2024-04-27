namespace Domain
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int DurationMinutes { get; set; }
    }
}