using Microsoft.AspNetCore.Mvc;
using DevTutorialWebApp.Services;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Controllers
{
    public class TestingController : Controller
    {
        private readonly IRoadmapService _roadmapService;

        public TestingController(IRoadmapService roadmapService)
        {
            _roadmapService = roadmapService;
        }

        public IActionResult Index()
        {
            var roadmaps = _roadmapService.GetRoadmapsByCategory(CategoryConstants.Testing);
            return View(roadmaps);
        }

        public IActionResult UnitTestingTDD()
        {
            var roadmap = _roadmapService.GetRoadmapById(20);
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }

        public IActionResult IntegrationAPITesting()
        {
            var roadmap = _roadmapService.GetRoadmapById(21);
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }
    }
}