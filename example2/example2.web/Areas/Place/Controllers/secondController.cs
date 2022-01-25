using Microsoft.AspNetCore.Mvc;

namespace example2.web.Areas.Place.Controllers
{
    [Area("Place")]
    public class secondController : Controller
    {
        private readonly ILogger<secondController> _logger;

        public secondController(ILogger<secondController> logger)
        {
            _logger = logger;
        }
        public IActionResult Add()
        {
            _logger.LogInformation("Add Action");
            return View();
        }
        public IActionResult Remove()
        {
            return View();
        }
    }
}
