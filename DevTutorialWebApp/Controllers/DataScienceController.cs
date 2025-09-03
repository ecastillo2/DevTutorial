using Microsoft.AspNetCore.Mvc;
using DevTutorialWebApp.Services;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Controllers
{
    public class DataScienceController : Controller
    {
        private readonly IRoadmapService _roadmapService;

        public DataScienceController(IRoadmapService roadmapService)
        {
            _roadmapService = roadmapService;
        }

        public IActionResult Index()
        {
            var roadmaps = _roadmapService.GetRoadmapsByCategory(CategoryConstants.DataScience);
            return View(roadmaps);
        }

        public IActionResult DataScientist()
        {
            var roadmap = _roadmapService.GetRoadmapById(4); // Data Scientist
            if (roadmap == null)
                return NotFound();
            
            return View(roadmap);
        }

        public IActionResult AIEngineer()
        {
            var roadmap = _roadmapService.GetRoadmapById(5); // AI/ML Engineer
            if (roadmap == null)
                return NotFound();
            
            return View(roadmap);
        }
    }
}