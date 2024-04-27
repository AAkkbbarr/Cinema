namespace Domain
{
    public class Cinema : BaseEntity
    {
        public string Name { get; set; }
        public List<Hall> Halls { get; set; }
    }
}