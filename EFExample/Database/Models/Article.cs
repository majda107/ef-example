using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EFExample.Database.Models
{
    public class Article
    {
        [Key] public int Id { get; set; }

        public string Text { get; set; }

        public List<ArticleComment> Comment { get; set; }
    }


    public class MyArticle : Article
    {
        public string MyText { get; set; }
    }
}