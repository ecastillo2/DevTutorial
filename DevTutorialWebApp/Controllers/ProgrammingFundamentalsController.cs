using Microsoft.AspNetCore.Mvc;
using DevTutorialWebApp.Services;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Controllers
{
    public class ProgrammingFundamentalsController : BaseRoadmapController
    {
        public ProgrammingFundamentalsController(IRoadmapService roadmapService) : base(roadmapService)
        {
        }

        public IActionResult Index()
        {
            var roadmaps = _roadmapService.GetRoadmapsByCategory(CategoryConstants.ProgrammingFundamentals);
            return View(roadmaps);
        }

        public IActionResult AlgorithmsDataStructures()
        {
            var roadmap = _roadmapService.GetRoadmapById(18);
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }

        public IActionResult ProblemSolvingCodingInterviews()
        {
            var roadmap = _roadmapService.GetRoadmapById(19);
            if (roadmap == null)
                return NotFound();
            
            return View("RoadmapDetail", roadmap);
        }
    }
}