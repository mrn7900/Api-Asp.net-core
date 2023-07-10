using System.ComponentModel.DataAnnotations;

namespace test2.Models.Article
{
    public class ArticleTbl
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
