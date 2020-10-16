using System.ComponentModel.DataAnnotations;

namespace EFExample.Database.Models
{
    public class ArticleComment
    {
        [Key] public int Id { get; set; }

        public string Text { get; set; }
        public string Author { get; set; }
    }
}