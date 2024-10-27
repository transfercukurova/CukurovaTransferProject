using Entity.Model;
using Microsoft.AspNetCore.Mvc;
using Services.Contract;

namespace AirportProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IServiceManager _manager;

        public CategoryController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error", "Home", ex.ToString());
            }
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            try
            {
                await Task.Run(() =>
                {
                    _manager.CategoryService.CreateOne(category);
                });
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error", "Home", ex.ToString());
            }
        }
    }
}
