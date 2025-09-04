using Microsoft.AspNetCore.Mvc;
using DevTutorialWebApp.Services;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Controllers
{
    public class MobileController : BaseRoadmapController
    {
        public MobileController(IRoadmapService roadmapService) : base(roadmapService)
        {
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

        public IActionResult NETMAUIDeveloper()
        {
            var roadmap = _roadmapService.GetRoadmapById(17); // .NET MAUI Developer
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }

        public IActionResult IOSDeveloper()
        {
            var roadmap = _roadmapService.GetRoadmapById(13); // iOS Developer
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }

        public IActionResult AndroidDeveloper()
        {
            var roadmap = _roadmapService.GetRoadmapById(14); // Android Developer
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }
    }
}