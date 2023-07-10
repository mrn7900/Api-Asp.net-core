using Microsoft.AspNetCore.Mvc;
using test2.Models.Article;

namespace test2.Repository.Article
{
    public class InMemArticleTblRep:IArticle
    {
        private List<ArticleTbl> _articles;

        public InMemArticleTblRep()
        {
           _articles = new() { new ArticleTbl() { Id = 1 , Description = "Loerm ipsom" , Title = "the first post"} };
        }
        
        public void CreateArticleTbl(ArticleTbl article)
        {
            _articles.Add(article);
        }
        
        public void DeleteArticleTbl(int id)
        {
            var article = _articles.FindIndex(x => x.Id == id);
            if(article > -1)
            {
                _articles.RemoveAt(article);
            }
        }
        public ArticleTbl GetArticleTbl(int id)
        {
            var Article = _articles.Where(x => x.Id == id).FirstOrDefault();
            return Article;
        }
        public IEnumerable<ArticleTbl> GetArticleTbls()
        {
            return _articles;
        }
        public void UpdateArticleTbl(int id , ArticleTbl article )
        {
            var ArticleId = _articles.FindIndex(x=>x.Id == id);
            if(ArticleId > -1)
            {
                _articles[ArticleId] = article;
            }
        }
    }
}
