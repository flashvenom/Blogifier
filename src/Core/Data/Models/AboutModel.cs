using System.ComponentModel.DataAnnotations;

namespace Core.Data.Models
{
    public class AboutPage
    {
        public BlogItem Blog { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Categories { get; set; }
        public string Cover { get; set; }
        public int PostViews { get; set; }
        public double Rating { get; set; }
    }
    
}