namespace sarel.Models
{
    // Example Article class definition
    public class Article
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public DateTime Date { get; set; }
        public required string Text { get; set; }
        public string? ImageUrl { get; set; }
    }

}
