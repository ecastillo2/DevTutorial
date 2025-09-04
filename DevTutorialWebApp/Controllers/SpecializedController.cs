using Microsoft.AspNetCore.Mvc;
using DevTutorialWebApp.Services;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Controllers
{
    public class SpecializedController : BaseRoadmapController
    {
        public SpecializedController(IRoadmapService roadmapService) : base(roadmapService)
        {
        }

        public IActionResult Index()
        {
            var roadmaps = _roadmapService.GetRoadmapsByCategory(CategoryConstants.Specialized);
            return View(roadmaps);
        }

        public IActionResult Cybersecurity()
        {
            var roadmap = _roadmapService.GetRoadmapById(8); // Cybersecurity Specialist
            if (roadmap == null)
                return NotFound();
            
            return View(roadmap);
        }

        public IActionResult UXUIDesigner()
        {
            var roadmap = _roadmapService.GetRoadmapById(9); // UX/UI Designer
            if (roadmap == null)
                return NotFound();
            
            return View(roadmap);
        }

        public IActionResult ProductManager()
        {
            var roadmap = _roadmapService.GetRoadmapById(10); // Product Manager
            if (roadmap == null)
                return NotFound();
            
            return View(roadmap);
        }
    }
}