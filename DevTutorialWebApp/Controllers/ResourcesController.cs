using Microsoft.AspNetCore.Mvc;
using DevTutorialWebApp.Services;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Controllers
{
    public class ResourcesController : Controller
    {
        private readonly IResourceService _resourceService;

        public ResourcesController(IResourceService resourceService)
        {
            _resourceService = resourceService;
        }

        public IActionResult Index()
        {
            var resources = _resourceService.GetAllResources();
            return View(resources);
        }

        public IActionResult Books()
        {
            var books = _resourceService.GetResourcesByType(ResourceType.Book);
            ViewBag.Title = "Books";
            ViewBag.Type = ResourceType.Book;
            return View("ByType", books);
        }

        public IActionResult Videos()
        {
            var videos = _resourceService.GetResourcesByType(ResourceType.Video);
            ViewBag.Title = "Videos & Courses";
            ViewBag.Type = ResourceType.Video;
            return View("ByType", videos);
        }

        public IActionResult Courses()
        {
            var courses = _resourceService.GetResourcesByType(ResourceType.Course);
            ViewBag.Title = "Online Courses";
            ViewBag.Type = ResourceType.Course;
            return View("ByType", courses);
        }

        public IActionResult Websites()
        {
            var websites = _resourceService.GetResourcesByType(ResourceType.Website);
            ViewBag.Title = "Websites & Tools";
            ViewBag.Type = ResourceType.Website;
            return View("ByType", websites);
        }

        public IActionResult Category(string category)
        {
            var resources = _resourceService.GetResourcesByCategory(category);
            ViewBag.CategoryName = category;
            return View(resources);
        }

        public IActionResult Details(int id)
        {
            var resource = _resourceService.GetResourceById(id);
            if (resource == null)
                return NotFound();
            
            return View(resource);
        }
    }
}