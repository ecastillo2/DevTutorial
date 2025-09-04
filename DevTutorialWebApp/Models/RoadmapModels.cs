using System;
using System.Collections.Generic;

namespace DevTutorialWebApp.Models
{
    public class Roadmap
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Category { get; set; }
        public string Duration { get; set; }
        public string Difficulty { get; set; }
        public string Context { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public List<string> Prerequisites { get; set; } = new List<string>();
        public List<string> CareerPaths { get; set; } = new List<string>();
        public List<RoadmapStep> Steps { get; set; } = new List<RoadmapStep>();
    }

    public class RoadmapStep
    {
        public int Id { get; set; }
        public int RoadmapId { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public string Content { get; set; }
        public List<string> KeyConcepts { get; set; } = new List<string>();
        public List<string> PracticalExercises { get; set; } = new List<string>();
        public bool IsCompleted { get; set; }
        public List<LearningObjective> Objectives { get; set; } = new List<LearningObjective>();
        public List<Resource> Resources { get; set; } = new List<Resource>();
        public List<SubTopic> SubTopics { get; set; } = new List<SubTopic>();
    }

    public class LearningObjective
    {
        public int Id { get; set; }
        public int StepId { get; set; }
        public string Description { get; set; }
    }

    public class Resource
    {
        public int Id { get; set; }
        public int StepId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Type { get; set; } // "article", "video", "course", etc.
    }

    public class SubTopic
    {
        public int Id { get; set; }
        public int StepId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public List<string> KeyPoints { get; set; } = new List<string>();
        public string CodeExample { get; set; }
        public List<Resource> Resources { get; set; } = new List<Resource>();
    }

    public class UserProgress
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int RoadmapId { get; set; }
        public int CompletedSteps { get; set; }
        public DateTime LastUpdated { get; set; }
    }

    public static class CategoryConstants
    {
        public const string WebDevelopment = "Web Development";
        public const string Mobile = "Mobile";
        public const string DataScience = "Data & AI";
        public const string DevOps = "DevOps & Cloud";
        public const string Specialized = "Specialized";
        public const string ProgrammingFundamentals = "Programming Fundamentals";
        public const string Testing = "Testing & Quality Assurance";
        public const string Architecture = "Architecture & System Design";
    }
}