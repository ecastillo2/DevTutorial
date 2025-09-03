using Microsoft.AspNetCore.Mvc;
using DevTutorialWebApp.Services;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Controllers
{
    public class ChallengesController : Controller
    {
        private readonly IChallengeService _challengeService;

        public ChallengesController(IChallengeService challengeService)
        {
            _challengeService = challengeService;
        }

        public IActionResult Index()
        {
            var challenges = _challengeService.GetAllChallenges();
            return View(challenges);
        }

        public IActionResult Details(int id)
        {
            var challenge = _challengeService.GetChallengeById(id);
            if (challenge == null)
                return NotFound();
            
            return View(challenge);
        }

        public IActionResult Category(string category)
        {
            var challenges = _challengeService.GetChallengesByCategory(category);
            ViewBag.CategoryName = category;
            return View(challenges);
        }
    }
}