using Microsoft.AspNetCore.Mvc;
using DevTutorialWebApp.Services;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Controllers
{
    public class WebDevelopmentController : Controller
    {
        private readonly IRoadmapService _roadmapService;

        public WebDevelopmentController(IRoadmapService roadmapService)
        {
            _roadmapService = roadmapService;
        }

        public IActionResult Index()
        {
            var roadmaps = _roadmapService.GetRoadmapsByCategory(CategoryConstants.WebDevelopment);
            return View(roadmaps);
        }

        public IActionResult FrontendDeveloper()
        {
            var roadmap = _roadmapService.GetRoadmapById(1); // Frontend Developer
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }

        public IActionResult BackendDeveloper()
        {
            var roadmap = _roadmapService.GetRoadmapById(2); // Backend Developer
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }

        public IActionResult CSharpDeveloper()
        {
            var roadmap = _roadmapService.GetRoadmapById(11); // C# Developer
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }

        public IActionResult ObjectOrientedProgramming()
        {
            var roadmap = _roadmapService.GetRoadmapById(12); // OOP
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }

        public IActionResult SOLIDPrinciples()
        {
            var roadmap = _roadmapService.GetRoadmapById(13); // SOLID
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }

        public IActionResult DesignPatterns()
        {
            var roadmap = _roadmapService.GetRoadmapById(14); // Design Patterns
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }

        public IActionResult SQLDatabaseDevelopment()
        {
            var roadmap = _roadmapService.GetRoadmapById(15); // SQL
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }

        public IActionResult NETCoreDeveloper()
        {
            var roadmap = _roadmapService.GetRoadmapById(16); // .NET Core
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }

        public IActionResult GitVersionControl()
        {
            var roadmap = _roadmapService.GetRoadmapById(25); // Git & Version Control
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }
    }
}