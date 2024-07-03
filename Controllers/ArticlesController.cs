using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class ArticlesController : Controller
{
    private readonly ArticleService _articleService;

    public ArticlesController(ArticleService articleService)
    {
        _articleService = articleService;
    }

    public IActionResult Index()
    {
        var articles = _articleService.GetAllArticles();
        return View(articles);
    }

    public IActionResult Details(int id)
    {
        var article = _articleService.GetArticleById(id);
        if (article == null)
        {
            return NotFound();
        }
        return View(article);
    }
}
