namespace BackendBlogPostSite.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ImagePath { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
    }
}
