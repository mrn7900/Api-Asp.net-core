using test2.Models.Article;

namespace test2.Repository.Article
{
    public interface IArticle
    {
        public IEnumerable<ArticleTbl> GetArticleTbls();
        public ArticleTbl GetArticleTbl(int id);
        public void CreateArticleTbl(ArticleTbl article);
        public void UpdateArticleTbl(int id,ArticleTbl article);
        public void DeleteArticleTbl(int id);

    }
}
