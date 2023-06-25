using Microsoft.AspNetCore.Mvc;
using WebApplicationMiniProjet.Services.Services;

namespace WebApplicationMiniProjet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISquareColorService _squareColorService;

        public HomeController(ISquareColorService squareColorService)
        {
            _squareColorService = squareColorService;
        }
        public IActionResult Index()
        {
            var squares = _squareColorService.CalculateSquareColors();
            ViewData["Squares"] = squares;
            return View();
        }
    }
}
