using System.Collections.Generic;

namespace DevTutorialWebApp.Models
{
    public class Challenge
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Scenario { get; set; }
        public string Difficulty { get; set; }
        public string Category { get; set; }
        public string Duration { get; set; }
        public List<string> Requirements { get; set; } = new List<string>();
        public List<string> Constraints { get; set; } = new List<string>();
        public ChallengeSolution Solution { get; set; }
    }

    public class ChallengeSolution
    {
        public int Id { get; set; }
        public int ChallengeId { get; set; }
        public string Overview { get; set; }
        public string Architecture { get; set; }
        public List<ArchitectureComponent> Components { get; set; } = new List<ArchitectureComponent>();
        public List<string> ImplementationSteps { get; set; } = new List<string>();
        public List<string> BestPractices { get; set; } = new List<string>();
        public string CodeExample { get; set; }
    }

    public class ArchitectureComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Purpose { get; set; }
        public string Technology { get; set; }
        public string Justification { get; set; }
    }

    public static class ChallengeDifficulty
    {
        public const string Beginner = "Beginner";
        public const string Intermediate = "Intermediate";
        public const string Advanced = "Advanced";
        public const string Expert = "Expert";
    }

    public static class ChallengeCategory
    {
        public const string SystemDesign = "System Design";
        public const string Architecture = "Architecture";
        public const string Performance = "Performance";
        public const string Security = "Security";
        public const string CloudDesign = "Cloud Design";
        public const string Microservices = "Microservices";
    }
}