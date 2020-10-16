using System.Linq;
using EFExample.Database;
using EFExample.Database.Models;

namespace EFExample.Services
{
    public class ArticleService
    {
        private readonly DatabaseContext _db;

        public ArticleService(DatabaseContext db)
        {
            this._db = db;
        }


        public void Test()
        {
            this._db.Articles.Where(t => t.Id > 5);
        }

        public void New(string text)
        {
            this._db.Articles.Add(new Article() {Text = text});
            this._db.SaveChanges();
        }
    }
}