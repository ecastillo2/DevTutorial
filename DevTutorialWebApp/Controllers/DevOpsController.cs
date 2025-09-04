using Microsoft.AspNetCore.Mvc;
using DevTutorialWebApp.Services;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Controllers
{
    public class DevOpsController : BaseRoadmapController
    {
        public DevOpsController(IRoadmapService roadmapService) : base(roadmapService)
        {
        }

        public IActionResult Index()
        {
            var roadmaps = _roadmapService.GetRoadmapsByCategory(CategoryConstants.DevOps);
            return View(roadmaps);
        }

        public IActionResult DevOpsEngineer()
        {
            var roadmap = _roadmapService.GetRoadmapById(6); // DevOps Engineer
            if (roadmap == null)
                return NotFound();
            
            return View(roadmap);
        }

        public IActionResult CloudSolutionsArchitect()
        {
            var roadmap = _roadmapService.GetRoadmapById(7); // Cloud Solutions Architect
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }

        public IActionResult AzureCloudDeveloper()
        {
            var roadmap = _roadmapService.GetRoadmapById(24); // Azure Developer
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }
        
        public IActionResult AzureDeveloper()
        {
            var roadmap = _roadmapService.GetRoadmapById(24); // Azure Developer
            if (roadmap == null)
                return NotFound();
            
            return View(roadmap);
        }

        public IActionResult GitCICD()
        {
            var roadmap = _roadmapService.GetRoadmapById(22); // Azure DevOps & Git CI/CD
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }
    }
}