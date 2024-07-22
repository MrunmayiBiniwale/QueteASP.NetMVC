using Microsoft.AspNetCore.Mvc;
using QueteASP.NetMVC.Models;
using QueteASP.NetMVC.Repositories;
using System.Collections.Immutable;

namespace QueteASP.NetMVC.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult ListArticles()
        {
            List<Article> articles = ArticleRepository.GetAllArticles();
            return View(articles);
        }

        public IActionResult AddArticle()
        {
            return View();
        }

        public IActionResult SaveArticle(Article article)
        {
            if (!ModelState.IsValid)
            {
                return View("AddArticle", article);
            }
            ArticleRepository.SaveArticle(article);
            return RedirectToAction("ListArticles", "Article");
        }

        public IActionResult UpdateArticle(Article article)
        {
            if (!ModelState.IsValid)
            {
                return View("EditArticle", article);
            }
            ArticleRepository.SaveArticle(article);
            return RedirectToAction("ListArticles", "Article");
        }

        public IActionResult EditArticle(int id)
        {
            Article? article = ArticleRepository.GetArticleById(id);
            return View(article);
        }

        [HttpPost]
        public JsonResult DeleteArticle(int id)
        {
            ArticleRepository.DeleteArticleById(id);
            return Json(new { id = id });
        }
    }
}
