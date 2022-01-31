using Microsoft.AspNetCore.Mvc;
using Revise.web.Areas.Admin.Models;

namespace Revise.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ModeratorController : Controller
    {
        private readonly ILogger<ModeratorController> _logger;
        private readonly IConfiguration _configuration;

        public ModeratorController(ILogger<ModeratorController> logger, IConfiguration configuration)
        {
            
            _logger = logger;
            _configuration = configuration;
        }
        public IActionResult Add()
        {
            var model = new Add();
            model.Insert(_configuration.GetConnectionString("DefaultConnection"));
            
            return View(model);
        }
        public IActionResult Remove()
        {
            return View();
        }
    }
}
