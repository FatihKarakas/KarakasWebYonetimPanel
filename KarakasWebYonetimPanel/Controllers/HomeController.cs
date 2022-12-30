using KarakasWebYonetimPanel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KarakasWebYonetimPanel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly fatihkarakaswebContext _fatihkarakasweb;

        public HomeController(ILogger<HomeController> logger, fatihkarakaswebContext fatihkarakasweb)
        {
            _logger = logger;
            _fatihkarakasweb = fatihkarakasweb;
        }

        public IActionResult Index()
        {
            List<Post> posts = _fatihkarakasweb.Post.Where(i => i.IsActive).ToList();

            return View(posts);
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
