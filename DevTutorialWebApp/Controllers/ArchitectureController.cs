using Microsoft.AspNetCore.Mvc;
using DevTutorialWebApp.Services;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Controllers
{
    public class ArchitectureController : Controller
    {
        private readonly IRoadmapService _roadmapService;

        public ArchitectureController(IRoadmapService roadmapService)
        {
            _roadmapService = roadmapService;
        }

        public IActionResult Index()
        {
            var roadmaps = _roadmapService.GetRoadmapsByCategory(CategoryConstants.Architecture);
            return View(roadmaps);
        }

        public IActionResult SoftwareArchitecturePatterns()
        {
            var roadmap = _roadmapService.GetRoadmapById(22);
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }

        public IActionResult MicroservicesArchitecture()
        {
            var roadmap = _roadmapService.GetRoadmapById(23);
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }

        public IActionResult DomainDrivenDesign()
        {
            var roadmap = _roadmapService.GetRoadmapById(24);
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }
    }
}