using Microsoft.AspNetCore.Mvc;
using FancyQuoteApp.Services;

namespace FancyQuoteApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQuoteService _quoteService;

        public HomeController(IQuoteService quoteService)
        {
            _quoteService = quoteService;
        }

        public IActionResult Index()
        {
            var quote = _quoteService.GetRandomQuote();
            return View(quote);
        }

        [HttpGet]
        public IActionResult GetRandomQuote()
        {
            var quote = _quoteService.GetRandomQuote();
            return Json(quote);
        }
    }
}