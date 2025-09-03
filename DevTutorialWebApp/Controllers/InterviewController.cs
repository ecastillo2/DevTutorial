using Microsoft.AspNetCore.Mvc;
using DevTutorialWebApp.Services;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Controllers
{
    public class InterviewController : Controller
    {
        private readonly IInterviewService _interviewService;

        public InterviewController(IInterviewService interviewService)
        {
            _interviewService = interviewService;
        }

        public IActionResult Index()
        {
            var categories = _interviewService.GetAllCategories();
            return View(categories);
        }

        public IActionResult Category(int id)
        {
            var category = _interviewService.GetCategoryById(id);
            if (category == null)
                return NotFound();
            
            return View(category);
        }

        public IActionResult Topic(int id)
        {
            var questions = _interviewService.GetQuestionsByTopic(id);
            if (!questions.Any())
                return NotFound();

            // Find the topic details
            InterviewTopic topic = null;
            foreach (var category in _interviewService.GetAllCategories())
            {
                topic = category.Topics.FirstOrDefault(t => t.Id == id);
                if (topic != null)
                {
                    ViewBag.CategoryName = category.Name;
                    ViewBag.CategoryId = category.Id;
                    break;
                }
            }
            
            if (topic == null)
                return NotFound();

            ViewBag.TopicTitle = topic.Title;
            ViewBag.TopicDifficulty = topic.Difficulty;
            return View(questions);
        }
    }
}