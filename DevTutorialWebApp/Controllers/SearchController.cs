using Microsoft.AspNetCore.Mvc;
using DevTutorialWebApp.Services;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Controllers
{
    public class SearchController : Controller
    {
        private readonly IRoadmapService _roadmapService;
        private readonly IInterviewService _interviewService;
        private readonly IChallengeService _challengeService;
        private readonly IResourceService _resourceService;

        public SearchController(
            IRoadmapService roadmapService,
            IInterviewService interviewService,
            IChallengeService challengeService,
            IResourceService resourceService)
        {
            _roadmapService = roadmapService;
            _interviewService = interviewService;
            _challengeService = challengeService;
            _resourceService = resourceService;
        }

        public IActionResult Index(string q)
        {
            if (string.IsNullOrWhiteSpace(q))
            {
                return View(new SearchResultsViewModel { Query = "", Results = new List<SearchResult>() });
            }

            var results = new List<SearchResult>();
            var query = q.ToLower().Trim();

            // Search in Roadmaps
            var roadmaps = _roadmapService.GetAllRoadmaps();
            foreach (var roadmap in roadmaps)
            {
                if (ContainsQuery(roadmap.Title, query) || 
                    ContainsQuery(roadmap.Description, query) ||
                    ContainsQuery(roadmap.Context, query))
                {
                    results.Add(new SearchResult
                    {
                        Title = roadmap.Title,
                        Description = roadmap.Description,
                        Type = "Learning Path",
                        Url = Url.Action(roadmap.ActionName, roadmap.ControllerName),
                        Icon = roadmap.Icon,
                        Relevance = CalculateRelevance(roadmap.Title + " " + roadmap.Description, query)
                    });
                }

                // Search in Steps and SubTopics
                foreach (var step in roadmap.Steps)
                {
                    if (ContainsQuery(step.Title, query) || ContainsQuery(step.Content, query))
                    {
                        results.Add(new SearchResult
                        {
                            Title = step.Title,
                            Description = step.Content,
                            Type = "Topic",
                            Url = Url.Action("TopicDetail", roadmap.ControllerName, new { roadmapId = roadmap.Id, stepId = step.Id }),
                            Icon = "📚",
                            Relevance = CalculateRelevance(step.Title + " " + step.Content, query)
                        });
                    }

                    foreach (var subTopic in step.SubTopics)
                    {
                        if (ContainsQuery(subTopic.Title, query) || 
                            ContainsQuery(subTopic.Description, query) ||
                            ContainsQuery(subTopic.Content, query) ||
                            (subTopic.KeyPoints?.Any(kp => ContainsQuery(kp, query)) == true))
                        {
                            results.Add(new SearchResult
                            {
                                Title = subTopic.Title,
                                Description = subTopic.Description,
                                Type = "Subtopic",
                                Url = Url.Action("SubTopicDetail", roadmap.ControllerName, 
                                    new { roadmapId = roadmap.Id, stepId = step.Id, subtopicId = subTopic.Id }),
                                Icon = "🔍",
                                Relevance = CalculateRelevance(subTopic.Title + " " + subTopic.Description + " " + subTopic.Content, query)
                            });
                        }
                    }
                }
            }

            // Search in Interview Questions
            var interviewCategories = _interviewService.GetAllCategories();
            foreach (var category in interviewCategories)
            {
                foreach (var topic in category.Topics)
                {
                    if (ContainsQuery(topic.Title, query))
                    {
                        results.Add(new SearchResult
                        {
                            Title = topic.Title + " Interview Questions",
                            Description = $"{topic.Difficulty} level interview questions for {topic.Title}",
                            Type = "Interview Prep",
                            Url = Url.Action("Topic", "Interview", new { id = topic.Id }),
                            Icon = "❓",
                            Relevance = CalculateRelevance(topic.Title, query)
                        });
                    }

                    foreach (var question in topic.Questions)
                    {
                        if (ContainsQuery(question.Question, query) || ContainsQuery(question.Answer, query))
                        {
                            results.Add(new SearchResult
                            {
                                Title = TruncateText(question.Question, 60),
                                Description = TruncateText(question.Answer, 150),
                                Type = "Interview Question",
                                Url = Url.Action("Topic", "Interview", new { id = topic.Id }) + $"#question-{question.Id}",
                                Icon = "💡",
                                Relevance = CalculateRelevance(question.Question + " " + question.Answer, query)
                            });
                        }
                    }
                }
            }

            // Search in Challenges
            var challenges = _challengeService.GetAllChallenges();
            foreach (var challenge in challenges)
            {
                if (ContainsQuery(challenge.Title, query) || ContainsQuery(challenge.Scenario, query))
                {
                    results.Add(new SearchResult
                    {
                        Title = challenge.Title,
                        Description = challenge.Scenario,
                        Type = "Challenge",
                        Url = Url.Action("Challenge", "Challenges", new { id = challenge.Id }),
                        Icon = "🎯",
                        Relevance = CalculateRelevance(challenge.Title + " " + challenge.Scenario, query)
                    });
                }
            }

            // Search in Resources
            var resources = _resourceService.GetAllResources();
            foreach (var resource in resources)
            {
                if (ContainsQuery(resource.Title, query) || ContainsQuery(resource.Description, query))
                {
                    results.Add(new SearchResult
                    {
                        Title = resource.Title,
                        Description = resource.Description,
                        Type = "Resource",
                        Url = resource.Url,
                        Icon = "📖",
                        Relevance = CalculateRelevance(resource.Title + " " + resource.Description, query)
                    });
                }
            }

            // Sort by relevance and remove duplicates
            var sortedResults = results
                .GroupBy(r => r.Title)
                .Select(g => g.OrderByDescending(r => r.Relevance).First())
                .OrderByDescending(r => r.Relevance)
                .ThenBy(r => r.Title)
                .Take(50)
                .ToList();

            var viewModel = new SearchResultsViewModel
            {
                Query = q,
                Results = sortedResults,
                ResultCount = sortedResults.Count
            };

            return View(viewModel);
        }

        private bool ContainsQuery(string text, string query)
        {
            if (string.IsNullOrWhiteSpace(text) || string.IsNullOrWhiteSpace(query))
                return false;

            return text.ToLower().Contains(query);
        }

        private int CalculateRelevance(string text, string query)
        {
            if (string.IsNullOrWhiteSpace(text) || string.IsNullOrWhiteSpace(query))
                return 0;

            text = text.ToLower();
            query = query.ToLower();

            int score = 0;
            
            // Exact phrase match gets highest score
            if (text.Contains(query))
            {
                score += 100;
            }

            // Individual word matches
            var queryWords = query.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in queryWords)
            {
                if (text.Contains(word))
                {
                    score += 25;
                }
            }

            return score;
        }

        private string TruncateText(string text, int maxLength)
        {
            if (string.IsNullOrWhiteSpace(text) || text.Length <= maxLength)
                return text;

            return text.Substring(0, maxLength) + "...";
        }
    }
}

// View Models
public class SearchResultsViewModel
{
    public string Query { get; set; } = "";
    public List<SearchResult> Results { get; set; } = new();
    public int ResultCount { get; set; }
}

public class SearchResult
{
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string Type { get; set; } = "";
    public string Url { get; set; } = "";
    public string Icon { get; set; } = "";
    public int Relevance { get; set; }
}