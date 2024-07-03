using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sarel.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace sarel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ArticleService _articleService;

        public HomeController(ArticleService articleService)
        {
            _articleService = articleService;
        }

        public IActionResult Index()
        {
            var articles = _articleService.GetAllArticles();
            return View(articles);
        }
    


    public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
