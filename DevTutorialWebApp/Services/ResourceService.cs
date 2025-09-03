using System.Collections.Generic;
using System.Linq;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Services
{
    public interface IResourceService
    {
        List<LearningResource> GetAllResources();
        List<LearningResource> GetResourcesByCategory(string category);
        List<LearningResource> GetResourcesByType(string type);
        LearningResource GetResourceById(int id);
    }

    public class ResourceService : IResourceService
    {
        private readonly List<LearningResource> _resources;

        public ResourceService()
        {
            _resources = InitializeResources();
        }

        public List<LearningResource> GetAllResources() => _resources;

        public List<LearningResource> GetResourcesByCategory(string category) => 
            _resources.Where(r => r.Category == category).ToList();

        public List<LearningResource> GetResourcesByType(string type) => 
            _resources.Where(r => r.Type == type).ToList();

        public LearningResource GetResourceById(int id) => 
            _resources.FirstOrDefault(r => r.Id == id);

        private List<LearningResource> InitializeResources()
        {
            return new List<LearningResource>
            {
                // C# Books
                new LearningResource
                {
                    Id = 1,
                    Title = "C# 10 in a Nutshell",
                    Description = "Comprehensive reference for C# 10 and .NET 6, covering language fundamentals to advanced topics",
                    Url = "https://www.oreilly.com/library/view/c-10-in/9781098121945/",
                    Type = ResourceType.Book,
                    Category = ResourceCategory.CSharp,
                    Difficulty = "Intermediate",
                    Author = "Joseph Albahari",
                    Price = 59.99m,
                    IsFree = false,
                    Rating = 4.6f,
                    Tags = new List<string> { "C#", ".NET 6", "Reference", "Comprehensive" }
                },
                new LearningResource
                {
                    Id = 2,
                    Title = "Clean Code: A Handbook of Agile Software Craftsmanship",
                    Description = "Essential principles for writing maintainable, readable code",
                    Url = "https://www.amazon.com/Clean-Code-Handbook-Software-Craftsmanship/dp/0132350882",
                    Type = ResourceType.Book,
                    Category = ResourceCategory.SoftSkills,
                    Difficulty = "Intermediate",
                    Author = "Robert C. Martin",
                    Price = 44.99m,
                    IsFree = false,
                    Rating = 4.4f,
                    Tags = new List<string> { "Clean Code", "Best Practices", "Software Engineering" }
                },

                // .NET Core Books
                new LearningResource
                {
                    Id = 3,
                    Title = "Pro ASP.NET Core 6",
                    Description = "Comprehensive guide to building modern web applications with ASP.NET Core 6",
                    Url = "https://www.apress.com/gp/book/9781484279564",
                    Type = ResourceType.Book,
                    Category = ResourceCategory.DotNetCore,
                    Difficulty = "Advanced",
                    Author = "Adam Freeman",
                    Price = 54.99m,
                    IsFree = false,
                    Rating = 4.5f,
                    Tags = new List<string> { "ASP.NET Core", "Web Development", "MVC" }
                },

                // Free Resources
                new LearningResource
                {
                    Id = 4,
                    Title = "Microsoft Learn - C# Documentation",
                    Description = "Official Microsoft documentation for C# programming language",
                    Url = "https://docs.microsoft.com/en-us/dotnet/csharp/",
                    Type = ResourceType.Documentation,
                    Category = ResourceCategory.CSharp,
                    Difficulty = "Beginner",
                    Author = "Microsoft",
                    IsFree = true,
                    Rating = 4.7f,
                    Tags = new List<string> { "Official", "Documentation", "Free" }
                },
                new LearningResource
                {
                    Id = 5,
                    Title = ".NET Application Architecture Guides",
                    Description = "Free e-books from Microsoft on .NET application architecture",
                    Url = "https://dotnet.microsoft.com/en-us/learn/dotnet/architecture-guides",
                    Type = ResourceType.Book,
                    Category = ResourceCategory.DotNetCore,
                    Difficulty = "Advanced",
                    Author = "Microsoft",
                    IsFree = true,
                    Rating = 4.6f,
                    Tags = new List<string> { "Architecture", "Microservices", "Free", "Microsoft" }
                },

                // Video Courses
                new LearningResource
                {
                    Id = 6,
                    Title = "The Complete C# Developer Course",
                    Description = "Comprehensive C# course from beginner to advanced with hands-on projects",
                    Url = "https://www.udemy.com/course/complete-csharp-masterclass/",
                    Type = ResourceType.Course,
                    Category = ResourceCategory.CSharp,
                    Difficulty = "Beginner",
                    Author = "Denis Panjuta",
                    Duration = "31 hours",
                    Price = 89.99m,
                    IsFree = false,
                    Rating = 4.4f,
                    Tags = new List<string> { "Beginner Friendly", "Projects", "Comprehensive" }
                },
                new LearningResource
                {
                    Id = 7,
                    Title = "ASP.NET Core Web API Development",
                    Description = "Learn to build scalable Web APIs with ASP.NET Core",
                    Url = "https://www.pluralsight.com/courses/asp-dot-net-core-web-api-building",
                    Type = ResourceType.Course,
                    Category = ResourceCategory.WebDevelopment,
                    Difficulty = "Intermediate",
                    Author = "Kevin Dockx",
                    Duration = "6h 15m",
                    Price = 29.00m,
                    IsFree = false,
                    Rating = 4.7f,
                    Tags = new List<string> { "Web API", "RESTful", "Authentication" }
                },

                // Azure Resources
                new LearningResource
                {
                    Id = 8,
                    Title = "Azure Fundamentals Certification Path",
                    Description = "Official Microsoft learning path for Azure AZ-900 certification",
                    Url = "https://docs.microsoft.com/en-us/learn/certifications/azure-fundamentals/",
                    Type = ResourceType.Course,
                    Category = ResourceCategory.Azure,
                    Difficulty = "Beginner",
                    Author = "Microsoft",
                    Duration = "10-15 hours",
                    IsFree = true,
                    Rating = 4.8f,
                    Tags = new List<string> { "Certification", "Cloud", "Free", "Official" }
                },
                new LearningResource
                {
                    Id = 9,
                    Title = "Azure Architecture Center",
                    Description = "Best practices and reference architectures for Azure solutions",
                    Url = "https://docs.microsoft.com/en-us/azure/architecture/",
                    Type = ResourceType.Documentation,
                    Category = ResourceCategory.Azure,
                    Difficulty = "Advanced",
                    Author = "Microsoft",
                    IsFree = true,
                    Rating = 4.7f,
                    Tags = new List<string> { "Architecture", "Best Practices", "Patterns" }
                },

                // System Design Resources
                new LearningResource
                {
                    Id = 10,
                    Title = "Designing Data-Intensive Applications",
                    Description = "Deep dive into the architecture of scalable, reliable, and maintainable systems",
                    Url = "https://www.oreilly.com/library/view/designing-data-intensive-applications/9781491903063/",
                    Type = ResourceType.Book,
                    Category = ResourceCategory.SystemDesign,
                    Difficulty = "Advanced",
                    Author = "Martin Kleppmann",
                    Price = 54.99m,
                    IsFree = false,
                    Rating = 4.8f,
                    Tags = new List<string> { "System Design", "Scalability", "Data Systems" }
                },
                new LearningResource
                {
                    Id = 11,
                    Title = "System Design Interview",
                    Description = "Comprehensive guide to system design interviews with real-world examples",
                    Url = "https://www.amazon.com/System-Design-Interview-insiders-Second/dp/B08CMF2CQF",
                    Type = ResourceType.Book,
                    Category = ResourceCategory.Interview,
                    Difficulty = "Intermediate",
                    Author = "Alex Xu",
                    Price = 39.99m,
                    IsFree = false,
                    Rating = 4.6f,
                    Tags = new List<string> { "Interview Prep", "System Design", "Examples" }
                },

                // Algorithm Resources
                new LearningResource
                {
                    Id = 12,
                    Title = "LeetCode",
                    Description = "Platform for practicing coding interview questions and algorithms",
                    Url = "https://leetcode.com/",
                    Type = ResourceType.Website,
                    Category = ResourceCategory.Algorithms,
                    Difficulty = "Intermediate",
                    IsFree = true,
                    Rating = 4.5f,
                    Tags = new List<string> { "Practice", "Interview Prep", "Algorithms", "Free" }
                },
                new LearningResource
                {
                    Id = 13,
                    Title = "Introduction to Algorithms (CLRS)",
                    Description = "Comprehensive textbook on algorithms and data structures",
                    Url = "https://mitpress.mit.edu/books/introduction-algorithms-fourth-edition",
                    Type = ResourceType.Book,
                    Category = ResourceCategory.Algorithms,
                    Difficulty = "Advanced",
                    Author = "Cormen, Leiserson, Rivest, Stein",
                    Price = 89.99m,
                    IsFree = false,
                    Rating = 4.4f,
                    Tags = new List<string> { "Comprehensive", "Academic", "Reference" }
                },

                // DevOps Resources
                new LearningResource
                {
                    Id = 14,
                    Title = "The Phoenix Project",
                    Description = "A novel about IT, DevOps, and helping your business win",
                    Url = "https://itrevolution.com/the-phoenix-project/",
                    Type = ResourceType.Book,
                    Category = ResourceCategory.DevOps,
                    Difficulty = "Beginner",
                    Author = "Gene Kim, Kevin Behr, George Spafford",
                    Price = 24.99m,
                    IsFree = false,
                    Rating = 4.5f,
                    Tags = new List<string> { "DevOps Culture", "Transformation", "Story" }
                },
                new LearningResource
                {
                    Id = 15,
                    Title = "Azure DevOps Learning Path",
                    Description = "Microsoft's official learning path for Azure DevOps",
                    Url = "https://docs.microsoft.com/en-us/learn/browse/?products=azure-devops",
                    Type = ResourceType.Course,
                    Category = ResourceCategory.DevOps,
                    Difficulty = "Intermediate",
                    Author = "Microsoft",
                    Duration = "8-12 hours",
                    IsFree = true,
                    Rating = 4.6f,
                    Tags = new List<string> { "Azure DevOps", "CI/CD", "Free" }
                },

                // Soft Skills Resources
                new LearningResource
                {
                    Id = 16,
                    Title = "The Pragmatic Programmer",
                    Description = "Essential book for software developers on coding practices and career development",
                    Url = "https://pragprog.com/titles/tpp20/the-pragmatic-programmer-20th-anniversary-edition/",
                    Type = ResourceType.Book,
                    Category = ResourceCategory.SoftSkills,
                    Difficulty = "Intermediate",
                    Author = "David Thomas, Andrew Hunt",
                    Price = 42.95m,
                    IsFree = false,
                    Rating = 4.7f,
                    Tags = new List<string> { "Career Development", "Best Practices", "Mindset" }
                },
                new LearningResource
                {
                    Id = 17,
                    Title = "Crucial Conversations",
                    Description = "Tools for talking when stakes are high",
                    Url = "https://www.amazon.com/Crucial-Conversations-Talking-Stakes-Second/dp/0071771328",
                    Type = ResourceType.Book,
                    Category = ResourceCategory.SoftSkills,
                    Difficulty = "Beginner",
                    Author = "Kerry Patterson, Joseph Grenny",
                    Price = 16.99m,
                    IsFree = false,
                    Rating = 4.4f,
                    Tags = new List<string> { "Communication", "Leadership", "Conflict Resolution" }
                },

                // Free Video Resources
                new LearningResource
                {
                    Id = 18,
                    Title = "C# Tutorial for Beginners",
                    Description = "Complete C# tutorial series for beginners by Programming with Mosh",
                    Url = "https://www.youtube.com/watch?v=gfkTfcpWqAY",
                    Type = ResourceType.Video,
                    Category = ResourceCategory.CSharp,
                    Difficulty = "Beginner",
                    Author = "Programming with Mosh",
                    Duration = "4h 31m",
                    IsFree = true,
                    Rating = 4.8f,
                    Tags = new List<string> { "Beginner", "Free", "YouTube", "Complete" }
                },
                new LearningResource
                {
                    Id = 19,
                    Title = "System Design Primer",
                    Description = "Learn how to design large-scale systems with this comprehensive GitHub repository",
                    Url = "https://github.com/donnemartin/system-design-primer",
                    Type = ResourceType.Tutorial,
                    Category = ResourceCategory.SystemDesign,
                    Difficulty = "Intermediate",
                    Author = "Donne Martin",
                    IsFree = true,
                    Rating = 4.9f,
                    Tags = new List<string> { "Open Source", "Comprehensive", "GitHub", "Free" }
                },
                new LearningResource
                {
                    Id = 20,
                    Title = "Interview Cake",
                    Description = "Programming interview questions and solutions with detailed explanations",
                    Url = "https://www.interviewcake.com/",
                    Type = ResourceType.Website,
                    Category = ResourceCategory.Interview,
                    Difficulty = "Intermediate",
                    Price = 149.00m,
                    IsFree = false,
                    Rating = 4.3f,
                    Tags = new List<string> { "Interview Prep", "Detailed Explanations", "Practice" }
                }
            };
        }
    }
}