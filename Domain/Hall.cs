namespace Domain
{
    public class Hall : BaseEntity
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<MovieShowTime> Showtimes { get; set; }
    }
}