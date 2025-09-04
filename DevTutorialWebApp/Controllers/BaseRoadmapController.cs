using Microsoft.AspNetCore.Mvc;
using DevTutorialWebApp.Services;
using System.Linq;

namespace DevTutorialWebApp.Controllers
{
    public abstract class BaseRoadmapController : Controller
    {
        protected readonly IRoadmapService _roadmapService;

        protected BaseRoadmapController(IRoadmapService roadmapService)
        {
            _roadmapService = roadmapService;
        }

        public virtual IActionResult TopicDetail(int roadmapId, int stepId)
        {
            var roadmap = _roadmapService.GetRoadmapById(roadmapId);
            if (roadmap == null)
                return NotFound();

            var step = roadmap.Steps.FirstOrDefault(s => s.Id == stepId);
            if (step == null)
                return NotFound();

            ViewBag.RoadmapTitle = roadmap.Title;
            ViewBag.RoadmapId = roadmap.Id;
            ViewBag.ControllerName = roadmap.ControllerName;
            ViewBag.ActionName = roadmap.ActionName;
            return View("TopicDetail", step);
        }

        public virtual IActionResult SubTopicDetail(int roadmapId, int stepId, int subtopicId)
        {
            var roadmap = _roadmapService.GetRoadmapById(roadmapId);
            if (roadmap == null)
                return NotFound();

            var step = roadmap.Steps.FirstOrDefault(s => s.Id == stepId);
            if (step == null)
                return NotFound();

            var subtopic = step.SubTopics.FirstOrDefault(st => st.Id == subtopicId);
            if (subtopic == null)
                return NotFound();

            ViewBag.RoadmapTitle = roadmap.Title;
            ViewBag.RoadmapId = roadmap.Id;
            ViewBag.StepId = step.Id;
            ViewBag.StepTitle = step.Title;
            ViewBag.ControllerName = roadmap.ControllerName;
            ViewBag.ActionName = roadmap.ActionName;
            return View("SubTopicDetail", subtopic);
        }
    }
}