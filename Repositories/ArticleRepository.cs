using QueteASP.NetMVC.Models;

namespace QueteASP.NetMVC.Repositories
{
    public static class ArticleRepository
    {
        private static List<Article> _articles = new List<Article>() {
            new Article()
            {
                Id = 1,
                Title = "Title1",
                Content = "Content1",
            },
            new Article()
            {
                Id= 2,
                Title = "Title2",
                Content = "Content2",
            }
        };

        public static List<Article> AddArticle(Article article)
        {
            var newArticleId = _articles.Max(a => a.Id) + 1;
            article.Id = newArticleId;  
            _articles.Add(article);
            return _articles;
        }

        public static List<Article> GetAllArticles() => _articles;

        public static Article? GetArticleById(int idArticle) => _articles.Find(a => a.Id == idArticle);

        public static List<Article> UpdateArticle(Article article)
        {
            foreach (var a in _articles)
            {
                if (a.Id == article.Id)
                {
                    a.Title = article.Title;
                    a.Content = article.Content;
                    break;
                }
            }
            return _articles;
        }

        public static bool DeleteArticleById(int idArticle)
        {
            bool result = false;
            foreach (var article in _articles)
            {
                if (article.Id == idArticle)
                {
                    _articles.Remove(article);
                    result = true;
                    break;
                }
            }
            return result;
        }

        public static void SaveArticle(Article article)
        {
            var articleExists = _articles.Find(a => a.Id == article.Id);
            if (articleExists is null)
                AddArticle(article);
            else
                UpdateArticle(article);
        }
    }
}
