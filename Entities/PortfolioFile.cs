namespace neurek.Entities
{
    public class PortfolioFile
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsCV { get; set; }
        public string PublicId { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}