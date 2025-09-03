using System.Collections.Generic;

namespace DevTutorialWebApp.Models
{
    public class LearningResource
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Type { get; set; } // Book, Video, Course, Article, Website, Tool
        public string Category { get; set; }
        public string Difficulty { get; set; }
        public string Author { get; set; }
        public decimal? Price { get; set; }
        public bool IsFree { get; set; }
        public string Duration { get; set; } // For videos/courses
        public float? Rating { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        public string ImageUrl { get; set; }
    }

    public static class ResourceType
    {
        public const string Book = "Book";
        public const string Video = "Video";
        public const string Course = "Course";
        public const string Article = "Article";
        public const string Website = "Website";
        public const string Tool = "Tool";
        public const string Documentation = "Documentation";
        public const string Tutorial = "Tutorial";
        public const string Podcast = "Podcast";
        public const string Blog = "Blog";
    }

    public static class ResourceCategory
    {
        public const string CSharp = "C#";
        public const string DotNetCore = ".NET Core";
        public const string WebDevelopment = "Web Development";
        public const string Azure = "Azure";
        public const string Algorithms = "Algorithms";
        public const string SystemDesign = "System Design";
        public const string DevOps = "DevOps";
        public const string SoftSkills = "Soft Skills";
        public const string Career = "Career";
        public const string Interview = "Interview Prep";
    }
}