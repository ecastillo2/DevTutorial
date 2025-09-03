using Microsoft.AspNetCore.Mvc;
using DevTutorialWebApp.Services;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Controllers
{
    public class MobileController : Controller
    {
        private readonly IRoadmapService _roadmapService;

        public MobileController(IRoadmapService roadmapService)
        {
            _roadmapService = roadmapService;
        }

        public IActionResult Index()
        {
            var roadmaps = _roadmapService.GetRoadmapsByCategory(CategoryConstants.Mobile);
            return View(roadmaps);
        }

        public IActionResult AppDeveloper()
        {
            var roadmap = _roadmapService.GetRoadmapById(3); // Mobile App Developer
            if (roadmap == null)
                return NotFound();
            
            return View(roadmap);
        }
    }
}