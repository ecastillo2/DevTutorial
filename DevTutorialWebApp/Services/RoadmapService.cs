using System.Collections.Generic;
using System.Linq;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Services
{
    public interface IRoadmapService
    {
        List<Roadmap> GetAllRoadmaps();
        List<Roadmap> GetRoadmapsByCategory(string category);
        Roadmap GetRoadmapById(int id);
    }

    public class RoadmapService : IRoadmapService
    {
        private readonly List<Roadmap> _roadmaps;

        public RoadmapService()
        {
            _roadmaps = InitializeRoadmaps();
        }

        public List<Roadmap> GetAllRoadmaps() => _roadmaps;

        public List<Roadmap> GetRoadmapsByCategory(string category) => 
            _roadmaps.Where(r => r.Category == category).ToList();

        public Roadmap GetRoadmapById(int id) => 
            _roadmaps.FirstOrDefault(r => r.Id == id);

        private List<Roadmap> InitializeRoadmaps()
        {
            return new List<Roadmap>
            {
                // Web Development
                new Roadmap
                {
                    Id = 1,
                    Title = "Frontend Developer",
                    Description = "Master modern web development with HTML, CSS, JavaScript, and React",
                    Icon = "🎨",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "6-8 months",
                    Difficulty = "Beginner to Advanced",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 1,
                            RoadmapId = 1,
                            Title = "HTML & CSS Fundamentals",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 1, StepId = 1, Description = "Understand HTML structure and semantic tags" },
                                new LearningObjective { Id = 2, StepId = 1, Description = "Master CSS selectors and properties" },
                                new LearningObjective { Id = 3, StepId = 1, Description = "Learn responsive design with Flexbox and Grid" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 1, StepId = 1, Title = "MDN Web Docs - HTML", Url = "https://developer.mozilla.org/en-US/docs/Web/HTML", Type = "article" },
                                new Resource { Id = 2, StepId = 1, Title = "CSS Tricks", Url = "https://css-tricks.com/", Type = "website" },
                                new Resource { Id = 3, StepId = 1, Title = "Flexbox Froggy", Url = "https://flexboxfroggy.com/", Type = "interactive" },
                                new Resource { Id = 4, StepId = 1, Title = "CSS Grid Garden", Url = "https://cssgridgarden.com/", Type = "interactive" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 2,
                            RoadmapId = 1,
                            Title = "JavaScript Programming",
                            Duration = "4-6 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 4, StepId = 2, Description = "Master JavaScript fundamentals and ES6+" },
                                new LearningObjective { Id = 5, StepId = 2, Description = "Understand DOM manipulation and events" },
                                new LearningObjective { Id = 6, StepId = 2, Description = "Learn asynchronous programming with Promises and async/await" },
                                new LearningObjective { Id = 7, StepId = 2, Description = "Work with APIs and JSON data" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 5, StepId = 2, Title = "JavaScript.info", Url = "https://javascript.info/", Type = "website" },
                                new Resource { Id = 6, StepId = 2, Title = "Eloquent JavaScript", Url = "https://eloquentjavascript.net/", Type = "book" },
                                new Resource { Id = 7, StepId = 2, Title = "JavaScript 30", Url = "https://javascript30.com/", Type = "course" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 3,
                            RoadmapId = 1,
                            Title = "Version Control with Git",
                            Duration = "1-2 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 8, StepId = 3, Description = "Master Git commands and workflows" },
                                new LearningObjective { Id = 9, StepId = 3, Description = "Collaborate using GitHub/GitLab" },
                                new LearningObjective { Id = 10, StepId = 3, Description = "Understand branching strategies and pull requests" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 8, StepId = 3, Title = "Pro Git Book", Url = "https://git-scm.com/book", Type = "book" },
                                new Resource { Id = 9, StepId = 3, Title = "GitHub Learning Lab", Url = "https://lab.github.com/", Type = "interactive" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 4,
                            RoadmapId = 1,
                            Title = "React Framework",
                            Duration = "4-6 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 11, StepId = 4, Description = "Understand React components and props" },
                                new LearningObjective { Id = 12, StepId = 4, Description = "Master state management with hooks" },
                                new LearningObjective { Id = 13, StepId = 4, Description = "Learn React Router and context API" },
                                new LearningObjective { Id = 14, StepId = 4, Description = "Build reusable component libraries" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 10, StepId = 4, Title = "React Official Docs", Url = "https://react.dev/", Type = "documentation" },
                                new Resource { Id = 11, StepId = 4, Title = "React Tutorial", Url = "https://react.dev/learn/tutorial-tic-tac-toe", Type = "tutorial" },
                                new Resource { Id = 12, StepId = 4, Title = "Epic React by Kent C. Dodds", Url = "https://epicreact.dev/", Type = "course" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 5,
                            RoadmapId = 1,
                            Title = "State Management & Advanced Patterns",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 15, StepId = 5, Description = "Master Redux Toolkit for global state" },
                                new LearningObjective { Id = 16, StepId = 5, Description = "Learn Zustand, Jotai, or Valtio as alternatives" },
                                new LearningObjective { Id = 17, StepId = 5, Description = "Implement advanced React patterns (HOCs, Render Props)" },
                                new LearningObjective { Id = 18, StepId = 5, Description = "Optimize performance with React.memo and useMemo" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 13, StepId = 5, Title = "Redux Toolkit Docs", Url = "https://redux-toolkit.js.org/", Type = "documentation" },
                                new Resource { Id = 14, StepId = 5, Title = "Patterns.dev", Url = "https://patterns.dev/", Type = "website" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 6,
                            RoadmapId = 1,
                            Title = "Modern Tooling & Build Systems",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 19, StepId = 6, Description = "Master Vite, Webpack, or Next.js" },
                                new LearningObjective { Id = 20, StepId = 6, Description = "Configure ESLint, Prettier, and Husky" },
                                new LearningObjective { Id = 21, StepId = 6, Description = "Set up TypeScript for type safety" },
                                new LearningObjective { Id = 22, StepId = 6, Description = "Implement CI/CD pipelines" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 15, StepId = 6, Title = "Vite Documentation", Url = "https://vitejs.dev/", Type = "documentation" },
                                new Resource { Id = 16, StepId = 6, Title = "TypeScript Handbook", Url = "https://www.typescriptlang.org/docs/", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 7,
                            RoadmapId = 1,
                            Title = "Testing & Quality Assurance",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 23, StepId = 7, Description = "Write unit tests with Jest and React Testing Library" },
                                new LearningObjective { Id = 24, StepId = 7, Description = "Implement integration and E2E tests with Cypress" },
                                new LearningObjective { Id = 25, StepId = 7, Description = "Set up automated testing in CI/CD" },
                                new LearningObjective { Id = 26, StepId = 7, Description = "Learn test-driven development (TDD)" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 17, StepId = 7, Title = "Testing JavaScript", Url = "https://testingjavascript.com/", Type = "course" },
                                new Resource { Id = 18, StepId = 7, Title = "React Testing Library Docs", Url = "https://testing-library.com/docs/react-testing-library/intro/", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 8,
                            RoadmapId = 1,
                            Title = "Full-Stack Integration & Deployment",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 27, StepId = 8, Description = "Connect to REST and GraphQL APIs" },
                                new LearningObjective { Id = 28, StepId = 8, Description = "Implement authentication and authorization" },
                                new LearningObjective { Id = 29, StepId = 8, Description = "Deploy to Vercel, Netlify, or AWS" },
                                new LearningObjective { Id = 30, StepId = 8, Description = "Monitor performance and errors in production" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 19, StepId = 8, Title = "Next.js Deployment", Url = "https://nextjs.org/docs/deployment", Type = "documentation" },
                                new Resource { Id = 20, StepId = 8, Title = "Web Performance Optimization", Url = "https://web.dev/fast/", Type = "guide" }
                            }
                        }
                    }
                },
                new Roadmap
                {
                    Id = 2,
                    Title = "Backend Developer",
                    Description = "Build robust server-side applications and APIs",
                    Icon = "⚙️",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "6-8 months",
                    Difficulty = "Intermediate to Advanced",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 4,
                            RoadmapId = 2,
                            Title = "Programming Language (C#/.NET)",
                            Duration = "4-6 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 31, StepId = 4, Description = "Master C# language fundamentals and syntax" },
                                new LearningObjective { Id = 32, StepId = 4, Description = "Understand .NET 8 framework features" },
                                new LearningObjective { Id = 33, StepId = 4, Description = "Learn object-oriented and functional programming" },
                                new LearningObjective { Id = 34, StepId = 4, Description = "Master LINQ and collections" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 21, StepId = 4, Title = "C# Documentation", Url = "https://docs.microsoft.com/en-us/dotnet/csharp/", Type = "documentation" },
                                new Resource { Id = 22, StepId = 4, Title = "C# in Depth by Jon Skeet", Url = "https://csharpindepth.com/", Type = "book" },
                                new Resource { Id = 23, StepId = 4, Title = "Pluralsight C# Path", Url = "https://www.pluralsight.com/paths/csharp", Type = "course" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 5,
                            RoadmapId = 2,
                            Title = "Database & SQL Mastery",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 35, StepId = 5, Description = "Design normalized relational database schemas" },
                                new LearningObjective { Id = 36, StepId = 5, Description = "Write complex SQL queries with JOINs and CTEs" },
                                new LearningObjective { Id = 37, StepId = 5, Description = "Implement indexes and query optimization" },
                                new LearningObjective { Id = 38, StepId = 5, Description = "Work with stored procedures and triggers" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 24, StepId = 5, Title = "SQL Performance Explained", Url = "https://use-the-index-luke.com/", Type = "website" },
                                new Resource { Id = 25, StepId = 5, Title = "PostgreSQL Tutorial", Url = "https://www.postgresqltutorial.com/", Type = "tutorial" },
                                new Resource { Id = 26, StepId = 5, Title = "SQL Zoo", Url = "https://sqlzoo.net/", Type = "interactive" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 6,
                            RoadmapId = 2,
                            Title = "ASP.NET Core & Web APIs",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 39, StepId = 6, Description = "Build RESTful APIs with ASP.NET Core" },
                                new LearningObjective { Id = 40, StepId = 6, Description = "Implement dependency injection and middleware" },
                                new LearningObjective { Id = 41, StepId = 6, Description = "Master Entity Framework Core ORM" },
                                new LearningObjective { Id = 42, StepId = 6, Description = "Create minimal APIs and gRPC services" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 27, StepId = 6, Title = "ASP.NET Core Docs", Url = "https://docs.microsoft.com/en-us/aspnet/core/", Type = "documentation" },
                                new Resource { Id = 28, StepId = 6, Title = "Building Web APIs with ASP.NET Core", Url = "https://www.manning.com/books/asp-net-core-in-action", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 7,
                            RoadmapId = 2,
                            Title = "Authentication & Security",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 43, StepId = 7, Description = "Implement JWT authentication" },
                                new LearningObjective { Id = 44, StepId = 7, Description = "Master OAuth 2.0 and OpenID Connect" },
                                new LearningObjective { Id = 45, StepId = 7, Description = "Secure APIs against common vulnerabilities" },
                                new LearningObjective { Id = 46, StepId = 7, Description = "Implement role-based authorization" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 29, StepId = 7, Title = "OWASP Top 10", Url = "https://owasp.org/www-project-top-ten/", Type = "guide" },
                                new Resource { Id = 30, StepId = 7, Title = "Identity Server Documentation", Url = "https://identityserver4.readthedocs.io/", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 8,
                            RoadmapId = 2,
                            Title = "Caching & Performance",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 47, StepId = 8, Description = "Implement Redis for distributed caching" },
                                new LearningObjective { Id = 48, StepId = 8, Description = "Use memory caching strategies" },
                                new LearningObjective { Id = 49, StepId = 8, Description = "Optimize database queries and connections" },
                                new LearningObjective { Id = 50, StepId = 8, Description = "Profile and benchmark API performance" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 31, StepId = 8, Title = "Redis University", Url = "https://university.redis.com/", Type = "course" },
                                new Resource { Id = 32, StepId = 8, Title = "High Performance .NET", Url = "https://www.stevejgordon.co.uk/", Type = "blog" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 9,
                            RoadmapId = 2,
                            Title = "Message Queues & Microservices",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 51, StepId = 9, Description = "Implement RabbitMQ or Azure Service Bus" },
                                new LearningObjective { Id = 52, StepId = 9, Description = "Design microservices architecture" },
                                new LearningObjective { Id = 53, StepId = 9, Description = "Master event-driven patterns" },
                                new LearningObjective { Id = 54, StepId = 9, Description = "Implement saga pattern for transactions" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 33, StepId = 9, Title = "Microservices.io", Url = "https://microservices.io/", Type = "website" },
                                new Resource { Id = 34, StepId = 9, Title = "Building Microservices", Url = "https://samnewman.io/books/building_microservices_2nd_edition/", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 10,
                            RoadmapId = 2,
                            Title = "Testing & Quality Assurance",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 55, StepId = 10, Description = "Write unit tests with xUnit/NUnit" },
                                new LearningObjective { Id = 56, StepId = 10, Description = "Implement integration testing" },
                                new LearningObjective { Id = 57, StepId = 10, Description = "Use test doubles and mocking" },
                                new LearningObjective { Id = 58, StepId = 10, Description = "Set up automated testing pipelines" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 35, StepId = 10, Title = "Unit Testing Principles", Url = "https://www.manning.com/books/unit-testing", Type = "book" },
                                new Resource { Id = 36, StepId = 10, Title = "xUnit Documentation", Url = "https://xunit.net/", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 11,
                            RoadmapId = 2,
                            Title = "Cloud & DevOps Integration",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 59, StepId = 11, Description = "Deploy to Azure App Service or AWS" },
                                new LearningObjective { Id = 60, StepId = 11, Description = "Containerize apps with Docker" },
                                new LearningObjective { Id = 61, StepId = 11, Description = "Orchestrate with Kubernetes" },
                                new LearningObjective { Id = 62, StepId = 11, Description = "Implement monitoring and logging" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 37, StepId = 11, Title = "Docker for .NET Developers", Url = "https://docs.docker.com/language/dotnet/", Type = "guide" },
                                new Resource { Id = 38, StepId = 11, Title = "Azure for .NET Developers", Url = "https://docs.microsoft.com/en-us/dotnet/azure/", Type = "documentation" }
                            }
                        }
                    }
                },
                // Mobile Development
                new Roadmap
                {
                    Id = 3,
                    Title = "Mobile App Developer",
                    Description = "Create native and cross-platform mobile applications",
                    Icon = "📱",
                    Category = CategoryConstants.Mobile,
                    Duration = "6-9 months",
                    Difficulty = "Intermediate",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 12,
                            RoadmapId = 3,
                            Title = "Mobile Development Fundamentals",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 63, StepId = 12, Description = "Understand mobile app architecture patterns (MVC, MVVM, MVP)" },
                                new LearningObjective { Id = 64, StepId = 12, Description = "Learn mobile UI/UX principles and guidelines" },
                                new LearningObjective { Id = 65, StepId = 12, Description = "Master responsive layouts and adaptive design" },
                                new LearningObjective { Id = 66, StepId = 12, Description = "Understand app lifecycle and state management" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 39, StepId = 12, Title = "Mobile Design Patterns", Url = "https://www.uxpin.com/studio/blog/mobile-design-patterns/", Type = "article" },
                                new Resource { Id = 40, StepId = 12, Title = "Material Design", Url = "https://material.io/design", Type = "guide" },
                                new Resource { Id = 41, StepId = 12, Title = "Human Interface Guidelines", Url = "https://developer.apple.com/design/human-interface-guidelines/", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 13,
                            RoadmapId = 3,
                            Title = "Native iOS Development (Swift)",
                            Duration = "6-8 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 67, StepId = 13, Description = "Master Swift programming language" },
                                new LearningObjective { Id = 68, StepId = 13, Description = "Build apps with SwiftUI and UIKit" },
                                new LearningObjective { Id = 69, StepId = 13, Description = "Implement Core Data for persistence" },
                                new LearningObjective { Id = 70, StepId = 13, Description = "Use Xcode and Interface Builder effectively" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 42, StepId = 13, Title = "Swift Programming Language", Url = "https://docs.swift.org/swift-book/", Type = "book" },
                                new Resource { Id = 43, StepId = 13, Title = "100 Days of SwiftUI", Url = "https://www.hackingwithswift.com/100/swiftui", Type = "course" },
                                new Resource { Id = 44, StepId = 13, Title = "Ray Wenderlich iOS", Url = "https://www.raywenderlich.com/ios", Type = "tutorial" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 14,
                            RoadmapId = 3,
                            Title = "Native Android Development (Kotlin)",
                            Duration = "6-8 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 71, StepId = 14, Description = "Master Kotlin programming language" },
                                new LearningObjective { Id = 72, StepId = 14, Description = "Build apps with Jetpack Compose" },
                                new LearningObjective { Id = 73, StepId = 14, Description = "Implement Room database and DataStore" },
                                new LearningObjective { Id = 74, StepId = 14, Description = "Use Android Studio and Gradle effectively" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 45, StepId = 14, Title = "Android Developer Docs", Url = "https://developer.android.com/", Type = "documentation" },
                                new Resource { Id = 46, StepId = 14, Title = "Kotlin Bootcamp", Url = "https://developer.android.com/courses/kotlin-bootcamp/overview", Type = "course" },
                                new Resource { Id = 47, StepId = 14, Title = "Jetpack Compose Tutorial", Url = "https://developer.android.com/jetpack/compose/tutorial", Type = "tutorial" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 15,
                            RoadmapId = 3,
                            Title = "Cross-Platform Development",
                            Duration = "4-6 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 75, StepId = 15, Description = "Master React Native or Flutter framework" },
                                new LearningObjective { Id = 76, StepId = 15, Description = "Build once, deploy everywhere apps" },
                                new LearningObjective { Id = 77, StepId = 15, Description = "Handle platform-specific features" },
                                new LearningObjective { Id = 78, StepId = 15, Description = "Optimize performance across platforms" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 48, StepId = 15, Title = "React Native Docs", Url = "https://reactnative.dev/", Type = "documentation" },
                                new Resource { Id = 49, StepId = 15, Title = "Flutter Complete Guide", Url = "https://flutter.dev/docs", Type = "documentation" },
                                new Resource { Id = 50, StepId = 15, Title = ".NET MAUI", Url = "https://docs.microsoft.com/en-us/dotnet/maui/", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 16,
                            RoadmapId = 3,
                            Title = "Mobile Backend & APIs",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 79, StepId = 16, Description = "Integrate RESTful APIs and GraphQL" },
                                new LearningObjective { Id = 80, StepId = 16, Description = "Implement offline-first architecture" },
                                new LearningObjective { Id = 81, StepId = 16, Description = "Handle authentication and authorization" },
                                new LearningObjective { Id = 82, StepId = 16, Description = "Use Firebase or AWS Amplify" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 51, StepId = 16, Title = "Firebase Documentation", Url = "https://firebase.google.com/docs", Type = "documentation" },
                                new Resource { Id = 52, StepId = 16, Title = "AWS Amplify", Url = "https://docs.amplify.aws/", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 17,
                            RoadmapId = 3,
                            Title = "Push Notifications & Background Tasks",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 83, StepId = 17, Description = "Implement push notifications (FCM/APNs)" },
                                new LearningObjective { Id = 84, StepId = 17, Description = "Handle background tasks and services" },
                                new LearningObjective { Id = 85, StepId = 17, Description = "Manage local notifications" },
                                new LearningObjective { Id = 86, StepId = 17, Description = "Optimize battery usage" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 53, StepId = 17, Title = "FCM Documentation", Url = "https://firebase.google.com/docs/cloud-messaging", Type = "documentation" },
                                new Resource { Id = 54, StepId = 17, Title = "iOS Background Tasks", Url = "https://developer.apple.com/documentation/backgroundtasks", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 18,
                            RoadmapId = 3,
                            Title = "App Store Deployment",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 87, StepId = 18, Description = "Prepare apps for App Store/Google Play" },
                                new LearningObjective { Id = 88, StepId = 18, Description = "Handle app signing and certificates" },
                                new LearningObjective { Id = 89, StepId = 18, Description = "Implement analytics and crash reporting" },
                                new LearningObjective { Id = 90, StepId = 18, Description = "Master ASO (App Store Optimization)" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 55, StepId = 18, Title = "App Store Guidelines", Url = "https://developer.apple.com/app-store/review/guidelines/", Type = "guide" },
                                new Resource { Id = 56, StepId = 18, Title = "Google Play Console", Url = "https://play.google.com/console/about/", Type = "documentation" }
                            }
                        }
                    }
                },
                // Data Science & AI
                new Roadmap
                {
                    Id = 4,
                    Title = "Data Scientist",
                    Description = "Analyze data and build predictive models",
                    Icon = "📊",
                    Category = CategoryConstants.DataScience,
                    Duration = "8-12 months",
                    Difficulty = "Intermediate to Advanced",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 19,
                            RoadmapId = 4,
                            Title = "Statistics & Mathematics Foundation",
                            Duration = "4-6 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 91, StepId = 19, Description = "Master descriptive and inferential statistics" },
                                new LearningObjective { Id = 92, StepId = 19, Description = "Learn probability theory and distributions" },
                                new LearningObjective { Id = 93, StepId = 19, Description = "Understand linear algebra and calculus basics" },
                                new LearningObjective { Id = 94, StepId = 19, Description = "Apply hypothesis testing and A/B testing" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 57, StepId = 19, Title = "Khan Academy Statistics", Url = "https://www.khanacademy.org/math/statistics-probability", Type = "course" },
                                new Resource { Id = 58, StepId = 19, Title = "Think Stats", Url = "https://greenteapress.com/thinkstats/", Type = "book" },
                                new Resource { Id = 59, StepId = 19, Title = "3Blue1Brown Linear Algebra", Url = "https://www.3blue1brown.com/topics/linear-algebra", Type = "video" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 20,
                            RoadmapId = 4,
                            Title = "Python for Data Science",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 95, StepId = 20, Description = "Master Python programming fundamentals" },
                                new LearningObjective { Id = 96, StepId = 20, Description = "Work with NumPy for numerical computing" },
                                new LearningObjective { Id = 97, StepId = 20, Description = "Analyze data with Pandas DataFrames" },
                                new LearningObjective { Id = 98, StepId = 20, Description = "Create visualizations with Matplotlib and Seaborn" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 60, StepId = 20, Title = "Python for Data Analysis", Url = "https://wesmckinney.com/book/", Type = "book" },
                                new Resource { Id = 61, StepId = 20, Title = "Kaggle Learn", Url = "https://www.kaggle.com/learn", Type = "tutorial" },
                                new Resource { Id = 62, StepId = 20, Title = "Real Python Data Science", Url = "https://realpython.com/tutorials/data-science/", Type = "tutorial" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 21,
                            RoadmapId = 4,
                            Title = "Data Wrangling & EDA",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 99, StepId = 21, Description = "Clean and preprocess messy datasets" },
                                new LearningObjective { Id = 100, StepId = 21, Description = "Handle missing data and outliers" },
                                new LearningObjective { Id = 101, StepId = 21, Description = "Perform exploratory data analysis (EDA)" },
                                new LearningObjective { Id = 102, StepId = 21, Description = "Feature engineering and selection" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 63, StepId = 21, Title = "Data Cleaning Tutorial", Url = "https://www.kaggle.com/learn/data-cleaning", Type = "tutorial" },
                                new Resource { Id = 64, StepId = 21, Title = "EDA Guide", Url = "https://www.kaggle.com/learn/data-visualization", Type = "tutorial" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 22,
                            RoadmapId = 4,
                            Title = "Machine Learning Foundations",
                            Duration = "6-8 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 103, StepId = 22, Description = "Understand supervised vs unsupervised learning" },
                                new LearningObjective { Id = 104, StepId = 22, Description = "Implement classification and regression models" },
                                new LearningObjective { Id = 105, StepId = 22, Description = "Master scikit-learn library" },
                                new LearningObjective { Id = 106, StepId = 22, Description = "Evaluate models and avoid overfitting" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 65, StepId = 22, Title = "Andrew Ng's ML Course", Url = "https://www.coursera.org/learn/machine-learning", Type = "course" },
                                new Resource { Id = 66, StepId = 22, Title = "Hands-On ML Book", Url = "https://www.oreilly.com/library/view/hands-on-machine-learning/9781492032632/", Type = "book" },
                                new Resource { Id = 67, StepId = 22, Title = "Fast.ai Practical Deep Learning", Url = "https://course.fast.ai/", Type = "course" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 23,
                            RoadmapId = 4,
                            Title = "SQL & Database Skills",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 107, StepId = 23, Description = "Write complex SQL queries for analysis" },
                                new LearningObjective { Id = 108, StepId = 23, Description = "Work with data warehouses" },
                                new LearningObjective { Id = 109, StepId = 23, Description = "Understand NoSQL databases" },
                                new LearningObjective { Id = 110, StepId = 23, Description = "Connect databases to Python" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 68, StepId = 23, Title = "SQL for Data Scientists", Url = "https://www.datacamp.com/courses/intro-to-sql-for-data-science", Type = "course" },
                                new Resource { Id = 69, StepId = 23, Title = "Mode SQL Tutorial", Url = "https://mode.com/sql-tutorial/", Type = "tutorial" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 24,
                            RoadmapId = 4,
                            Title = "Big Data & Cloud Computing",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 111, StepId = 24, Description = "Work with Apache Spark for big data" },
                                new LearningObjective { Id = 112, StepId = 24, Description = "Use cloud platforms (AWS, GCP, Azure)" },
                                new LearningObjective { Id = 113, StepId = 24, Description = "Implement data pipelines" },
                                new LearningObjective { Id = 114, StepId = 24, Description = "Deploy models to production" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 70, StepId = 24, Title = "PySpark Tutorial", Url = "https://spark.apache.org/docs/latest/api/python/", Type = "documentation" },
                                new Resource { Id = 71, StepId = 24, Title = "AWS Data Analytics", Url = "https://aws.amazon.com/training/learn-about/data-analytics/", Type = "course" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 25,
                            RoadmapId = 4,
                            Title = "Business Intelligence & Visualization",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 115, StepId = 25, Description = "Create dashboards with Tableau/Power BI" },
                                new LearningObjective { Id = 116, StepId = 25, Description = "Tell stories with data" },
                                new LearningObjective { Id = 117, StepId = 25, Description = "Present insights to stakeholders" },
                                new LearningObjective { Id = 118, StepId = 25, Description = "Build interactive visualizations" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 72, StepId = 25, Title = "Tableau Learning", Url = "https://www.tableau.com/learn", Type = "tutorial" },
                                new Resource { Id = 73, StepId = 25, Title = "Storytelling with Data", Url = "https://www.storytellingwithdata.com/", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 26,
                            RoadmapId = 4,
                            Title = "Real-World Projects & Portfolio",
                            Duration = "4-6 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 119, StepId = 26, Description = "Complete end-to-end data science projects" },
                                new LearningObjective { Id = 120, StepId = 26, Description = "Participate in Kaggle competitions" },
                                new LearningObjective { Id = 121, StepId = 26, Description = "Build a GitHub portfolio" },
                                new LearningObjective { Id = 122, StepId = 26, Description = "Write technical blog posts" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 74, StepId = 26, Title = "Kaggle Competitions", Url = "https://www.kaggle.com/competitions", Type = "website" },
                                new Resource { Id = 75, StepId = 26, Title = "DataCamp Projects", Url = "https://www.datacamp.com/projects", Type = "interactive" }
                            }
                        }
                    }
                },
                new Roadmap
                {
                    Id = 5,
                    Title = "AI/ML Engineer",
                    Description = "Build intelligent systems using machine learning",
                    Icon = "🤖",
                    Category = CategoryConstants.DataScience,
                    Duration = "10-14 months",
                    Difficulty = "Advanced",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 27,
                            RoadmapId = 5,
                            Title = "Mathematics & Python Foundation",
                            Duration = "4-6 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 123, StepId = 27, Description = "Master linear algebra, calculus, and statistics" },
                                new LearningObjective { Id = 124, StepId = 27, Description = "Advanced Python programming and OOP" },
                                new LearningObjective { Id = 125, StepId = 27, Description = "NumPy, Pandas, and scientific computing" },
                                new LearningObjective { Id = 126, StepId = 27, Description = "Jupyter notebooks and development environments" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 76, StepId = 27, Title = "Mathematics for ML", Url = "https://mml-book.github.io/", Type = "book" },
                                new Resource { Id = 77, StepId = 27, Title = "Deep Learning Book", Url = "https://www.deeplearningbook.org/", Type = "book" },
                                new Resource { Id = 78, StepId = 27, Title = "Python ML Ecosystem", Url = "https://jakevdp.github.io/PythonDataScienceHandbook/", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 28,
                            RoadmapId = 5,
                            Title = "Classical Machine Learning",
                            Duration = "5-6 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 127, StepId = 28, Description = "Master supervised learning algorithms" },
                                new LearningObjective { Id = 128, StepId = 28, Description = "Implement unsupervised learning techniques" },
                                new LearningObjective { Id = 129, StepId = 28, Description = "Feature engineering and selection" },
                                new LearningObjective { Id = 130, StepId = 28, Description = "Model evaluation and cross-validation" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 79, StepId = 28, Title = "Pattern Recognition and ML", Url = "https://www.microsoft.com/en-us/research/publication/pattern-recognition-machine-learning/", Type = "book" },
                                new Resource { Id = 80, StepId = 28, Title = "Scikit-learn Documentation", Url = "https://scikit-learn.org/stable/", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 29,
                            RoadmapId = 5,
                            Title = "Deep Learning Fundamentals",
                            Duration = "6-8 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 131, StepId = 29, Description = "Understand neural networks and backpropagation" },
                                new LearningObjective { Id = 132, StepId = 29, Description = "Master PyTorch or TensorFlow" },
                                new LearningObjective { Id = 133, StepId = 29, Description = "Build CNNs for computer vision" },
                                new LearningObjective { Id = 134, StepId = 29, Description = "Implement RNNs and LSTMs for sequences" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 81, StepId = 29, Title = "PyTorch Tutorials", Url = "https://pytorch.org/tutorials/", Type = "tutorial" },
                                new Resource { Id = 82, StepId = 29, Title = "Deep Learning Specialization", Url = "https://www.coursera.org/specializations/deep-learning", Type = "course" },
                                new Resource { Id = 83, StepId = 29, Title = "Papers with Code", Url = "https://paperswithcode.com/", Type = "website" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 30,
                            RoadmapId = 5,
                            Title = "Natural Language Processing",
                            Duration = "4-6 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 135, StepId = 30, Description = "Text preprocessing and tokenization" },
                                new LearningObjective { Id = 136, StepId = 30, Description = "Word embeddings and transformers" },
                                new LearningObjective { Id = 137, StepId = 30, Description = "Fine-tune BERT, GPT models" },
                                new LearningObjective { Id = 138, StepId = 30, Description = "Build chatbots and text classifiers" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 84, StepId = 30, Title = "Hugging Face Course", Url = "https://huggingface.co/course", Type = "course" },
                                new Resource { Id = 85, StepId = 30, Title = "NLP with Transformers", Url = "https://www.oreilly.com/library/view/natural-language-processing/9781098103231/", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 31,
                            RoadmapId = 5,
                            Title = "Computer Vision & GANs",
                            Duration = "4-6 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 139, StepId = 31, Description = "Object detection and segmentation" },
                                new LearningObjective { Id = 140, StepId = 31, Description = "Transfer learning and fine-tuning" },
                                new LearningObjective { Id = 141, StepId = 31, Description = "Generative Adversarial Networks" },
                                new LearningObjective { Id = 142, StepId = 31, Description = "Work with OpenCV and image processing" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 86, StepId = 31, Title = "CS231n Stanford Course", Url = "http://cs231n.stanford.edu/", Type = "course" },
                                new Resource { Id = 87, StepId = 31, Title = "PyImageSearch", Url = "https://pyimagesearch.com/", Type = "website" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 32,
                            RoadmapId = 5,
                            Title = "MLOps & Production Deployment",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 143, StepId = 32, Description = "Model versioning with MLflow/DVC" },
                                new LearningObjective { Id = 144, StepId = 32, Description = "Deploy models with Docker and Kubernetes" },
                                new LearningObjective { Id = 145, StepId = 32, Description = "Build REST APIs for ML models" },
                                new LearningObjective { Id = 146, StepId = 32, Description = "Monitor model performance in production" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 88, StepId = 32, Title = "MLOps Course", Url = "https://www.coursera.org/specializations/machine-learning-engineering-for-production-mlops", Type = "course" },
                                new Resource { Id = 89, StepId = 32, Title = "Made With ML", Url = "https://madewithml.com/", Type = "website" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 33,
                            RoadmapId = 5,
                            Title = "Advanced Topics & Research",
                            Duration = "6-8 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 147, StepId = 33, Description = "Reinforcement learning and deep RL" },
                                new LearningObjective { Id = 148, StepId = 33, Description = "Explainable AI and interpretability" },
                                new LearningObjective { Id = 149, StepId = 33, Description = "Federated learning and privacy" },
                                new LearningObjective { Id = 150, StepId = 33, Description = "Read and implement research papers" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 90, StepId = 33, Title = "Spinning Up in Deep RL", Url = "https://spinningup.openai.com/", Type = "guide" },
                                new Resource { Id = 91, StepId = 33, Title = "arXiv ML Papers", Url = "https://arxiv.org/list/cs.LG/recent", Type = "website" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 34,
                            RoadmapId = 5,
                            Title = "Industry Projects & Specialization",
                            Duration = "4-6 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 151, StepId = 34, Description = "Build end-to-end ML projects" },
                                new LearningObjective { Id = 152, StepId = 34, Description = "Contribute to open source ML projects" },
                                new LearningObjective { Id = 153, StepId = 34, Description = "Specialize in a domain (healthcare, finance, etc.)" },
                                new LearningObjective { Id = 154, StepId = 34, Description = "Create ML blog and portfolio" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 92, StepId = 34, Title = "Google AI Projects", Url = "https://ai.google/education/", Type = "website" },
                                new Resource { Id = 93, StepId = 34, Title = "Fast.ai Projects", Url = "https://www.fast.ai/projects/", Type = "website" }
                            }
                        }
                    }
                },
                // DevOps & Cloud
                new Roadmap
                {
                    Id = 6,
                    Title = "DevOps Engineer",
                    Description = "Automate deployment and manage infrastructure",
                    Icon = "🔧",
                    Category = CategoryConstants.DevOps,
                    Duration = "6-9 months",
                    Difficulty = "Intermediate to Advanced",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 35,
                            RoadmapId = 6,
                            Title = "Linux & Scripting Fundamentals",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 155, StepId = 35, Description = "Master Linux command line and system administration" },
                                new LearningObjective { Id = 156, StepId = 35, Description = "Write Bash scripts for automation" },
                                new LearningObjective { Id = 157, StepId = 35, Description = "Learn Python for DevOps tasks" },
                                new LearningObjective { Id = 158, StepId = 35, Description = "Understand networking and protocols" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 94, StepId = 35, Title = "Linux Command Line", Url = "https://linuxcommand.org/", Type = "tutorial" },
                                new Resource { Id = 95, StepId = 35, Title = "Bash Scripting Tutorial", Url = "https://www.gnu.org/software/bash/manual/", Type = "documentation" },
                                new Resource { Id = 96, StepId = 35, Title = "Python for DevOps", Url = "https://www.oreilly.com/library/view/python-for-devops/9781492057680/", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 36,
                            RoadmapId = 6,
                            Title = "Version Control & Git Workflows",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 159, StepId = 36, Description = "Master advanced Git commands and workflows" },
                                new LearningObjective { Id = 160, StepId = 36, Description = "Implement Git branching strategies (GitFlow, GitHub Flow)" },
                                new LearningObjective { Id = 161, StepId = 36, Description = "Set up Git hooks and automation" },
                                new LearningObjective { Id = 162, StepId = 36, Description = "Manage monorepos and submodules" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 97, StepId = 36, Title = "Pro Git Book", Url = "https://git-scm.com/book", Type = "book" },
                                new Resource { Id = 98, StepId = 36, Title = "Git Branching Strategies", Url = "https://www.atlassian.com/git/tutorials/comparing-workflows", Type = "guide" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 37,
                            RoadmapId = 6,
                            Title = "CI/CD Pipeline Implementation",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 163, StepId = 37, Description = "Set up CI/CD with Jenkins, GitHub Actions, or GitLab CI" },
                                new LearningObjective { Id = 164, StepId = 37, Description = "Implement automated testing strategies" },
                                new LearningObjective { Id = 165, StepId = 37, Description = "Configure build automation and artifact management" },
                                new LearningObjective { Id = 166, StepId = 37, Description = "Deploy with blue-green and canary strategies" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 99, StepId = 37, Title = "GitHub Actions Docs", Url = "https://docs.github.com/en/actions", Type = "documentation" },
                                new Resource { Id = 100, StepId = 37, Title = "Jenkins User Handbook", Url = "https://www.jenkins.io/doc/book/", Type = "documentation" },
                                new Resource { Id = 101, StepId = 37, Title = "CI/CD Best Practices", Url = "https://www.redhat.com/en/topics/devops/what-is-ci-cd", Type = "guide" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 38,
                            RoadmapId = 6,
                            Title = "Containerization with Docker",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 167, StepId = 38, Description = "Master Docker fundamentals and architecture" },
                                new LearningObjective { Id = 168, StepId = 38, Description = "Write efficient Dockerfiles and multi-stage builds" },
                                new LearningObjective { Id = 169, StepId = 38, Description = "Use Docker Compose for multi-container apps" },
                                new LearningObjective { Id = 170, StepId = 38, Description = "Implement Docker security best practices" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 102, StepId = 38, Title = "Docker Documentation", Url = "https://docs.docker.com/", Type = "documentation" },
                                new Resource { Id = 103, StepId = 38, Title = "Docker Deep Dive", Url = "https://www.pluralsight.com/courses/docker-deep-dive-update", Type = "course" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 39,
                            RoadmapId = 6,
                            Title = "Kubernetes & Container Orchestration",
                            Duration = "5-6 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 171, StepId = 39, Description = "Deploy and manage Kubernetes clusters" },
                                new LearningObjective { Id = 172, StepId = 39, Description = "Create Kubernetes manifests and Helm charts" },
                                new LearningObjective { Id = 173, StepId = 39, Description = "Implement service mesh with Istio" },
                                new LearningObjective { Id = 174, StepId = 39, Description = "Set up GitOps with ArgoCD or Flux" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 104, StepId = 39, Title = "Kubernetes Documentation", Url = "https://kubernetes.io/docs/", Type = "documentation" },
                                new Resource { Id = 105, StepId = 39, Title = "CKA Certification Guide", Url = "https://www.cncf.io/certification/cka/", Type = "guide" },
                                new Resource { Id = 106, StepId = 39, Title = "Kubernetes the Hard Way", Url = "https://github.com/kelseyhightower/kubernetes-the-hard-way", Type = "tutorial" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 40,
                            RoadmapId = 6,
                            Title = "Infrastructure as Code",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 175, StepId = 40, Description = "Master Terraform for infrastructure provisioning" },
                                new LearningObjective { Id = 176, StepId = 40, Description = "Use Ansible for configuration management" },
                                new LearningObjective { Id = 177, StepId = 40, Description = "Implement Pulumi or CloudFormation" },
                                new LearningObjective { Id = 178, StepId = 40, Description = "Version control infrastructure code" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 107, StepId = 40, Title = "Terraform Documentation", Url = "https://www.terraform.io/docs", Type = "documentation" },
                                new Resource { Id = 108, StepId = 40, Title = "Ansible for DevOps", Url = "https://www.ansiblefordevops.com/", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 41,
                            RoadmapId = 6,
                            Title = "Monitoring & Observability",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 179, StepId = 41, Description = "Implement Prometheus and Grafana monitoring" },
                                new LearningObjective { Id = 180, StepId = 41, Description = "Set up ELK stack for log management" },
                                new LearningObjective { Id = 181, StepId = 41, Description = "Configure distributed tracing with Jaeger" },
                                new LearningObjective { Id = 182, StepId = 41, Description = "Create alerts and incident response" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 109, StepId = 41, Title = "Prometheus Up & Running", Url = "https://www.oreilly.com/library/view/prometheus-up/9781492034131/", Type = "book" },
                                new Resource { Id = 110, StepId = 41, Title = "Elastic Stack Guide", Url = "https://www.elastic.co/guide/", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 42,
                            RoadmapId = 6,
                            Title = "Security & Compliance",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 183, StepId = 42, Description = "Implement DevSecOps practices" },
                                new LearningObjective { Id = 184, StepId = 42, Description = "Scan for vulnerabilities in CI/CD" },
                                new LearningObjective { Id = 185, StepId = 42, Description = "Manage secrets with Vault or AWS Secrets Manager" },
                                new LearningObjective { Id = 186, StepId = 42, Description = "Ensure compliance (GDPR, HIPAA, SOC2)" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 111, StepId = 42, Title = "DevSecOps Hub", Url = "https://www.devsecops.org/", Type = "website" },
                                new Resource { Id = 112, StepId = 42, Title = "HashiCorp Vault Docs", Url = "https://www.vaultproject.io/docs", Type = "documentation" }
                            }
                        }
                    }
                },
                new Roadmap
                {
                    Id = 7,
                    Title = "Cloud Solutions Architect",
                    Description = "Design scalable cloud infrastructure",
                    Icon = "☁️",
                    Category = CategoryConstants.DevOps,
                    Duration = "8-12 months",
                    Difficulty = "Advanced",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 43,
                            RoadmapId = 7,
                            Title = "Cloud Computing Fundamentals",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 187, StepId = 43, Description = "Understand cloud service models (IaaS, PaaS, SaaS)" },
                                new LearningObjective { Id = 188, StepId = 43, Description = "Learn cloud deployment models and concepts" },
                                new LearningObjective { Id = 189, StepId = 43, Description = "Master virtualization and containerization" },
                                new LearningObjective { Id = 190, StepId = 43, Description = "Compare major cloud providers (AWS, Azure, GCP)" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 113, StepId = 43, Title = "Cloud Computing Concepts", Url = "https://aws.amazon.com/what-is-cloud-computing/", Type = "guide" },
                                new Resource { Id = 114, StepId = 43, Title = "Cloud Architecture Patterns", Url = "https://docs.microsoft.com/en-us/azure/architecture/patterns/", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 44,
                            RoadmapId = 7,
                            Title = "AWS Core Services Mastery",
                            Duration = "5-6 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 191, StepId = 44, Description = "Master EC2, VPC, and networking" },
                                new LearningObjective { Id = 192, StepId = 44, Description = "Implement S3, EBS, and storage solutions" },
                                new LearningObjective { Id = 193, StepId = 44, Description = "Configure RDS, DynamoDB, and databases" },
                                new LearningObjective { Id = 194, StepId = 44, Description = "Use Lambda and serverless computing" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 115, StepId = 44, Title = "AWS Documentation", Url = "https://docs.aws.amazon.com/", Type = "documentation" },
                                new Resource { Id = 116, StepId = 44, Title = "AWS Solutions Architect Associate", Url = "https://aws.amazon.com/certification/certified-solutions-architect-associate/", Type = "certification" },
                                new Resource { Id = 117, StepId = 44, Title = "AWS Well-Architected Framework", Url = "https://aws.amazon.com/architecture/well-architected/", Type = "guide" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 45,
                            RoadmapId = 7,
                            Title = "Multi-Cloud & Hybrid Architecture",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 195, StepId = 45, Description = "Design multi-cloud strategies" },
                                new LearningObjective { Id = 196, StepId = 45, Description = "Implement hybrid cloud solutions" },
                                new LearningObjective { Id = 197, StepId = 45, Description = "Master Azure and GCP services" },
                                new LearningObjective { Id = 198, StepId = 45, Description = "Use cloud-agnostic tools (Terraform, Kubernetes)" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 118, StepId = 45, Title = "Azure Architecture Center", Url = "https://docs.microsoft.com/en-us/azure/architecture/", Type = "documentation" },
                                new Resource { Id = 119, StepId = 45, Title = "Google Cloud Architecture", Url = "https://cloud.google.com/architecture", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 46,
                            RoadmapId = 7,
                            Title = "High Availability & Disaster Recovery",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 199, StepId = 46, Description = "Design for 99.99% availability" },
                                new LearningObjective { Id = 200, StepId = 46, Description = "Implement auto-scaling and load balancing" },
                                new LearningObjective { Id = 201, StepId = 46, Description = "Create disaster recovery plans" },
                                new LearningObjective { Id = 202, StepId = 46, Description = "Set up multi-region deployments" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 120, StepId = 46, Title = "AWS Disaster Recovery", Url = "https://aws.amazon.com/disaster-recovery/", Type = "guide" },
                                new Resource { Id = 121, StepId = 46, Title = "High Availability Architecture", Url = "https://www.nginx.com/blog/microservices-reference-architecture-nginx-high-availability/", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 47,
                            RoadmapId = 7,
                            Title = "Security & Compliance Architecture",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 203, StepId = 47, Description = "Implement zero-trust security model" },
                                new LearningObjective { Id = 204, StepId = 47, Description = "Design identity and access management" },
                                new LearningObjective { Id = 205, StepId = 47, Description = "Ensure data encryption and privacy" },
                                new LearningObjective { Id = 206, StepId = 47, Description = "Meet compliance requirements (GDPR, HIPAA)" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 122, StepId = 47, Title = "AWS Security Best Practices", Url = "https://aws.amazon.com/architecture/security-identity-compliance/", Type = "guide" },
                                new Resource { Id = 123, StepId = 47, Title = "Cloud Security Alliance", Url = "https://cloudsecurityalliance.org/", Type = "website" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 48,
                            RoadmapId = 7,
                            Title = "Cost Optimization & FinOps",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 207, StepId = 48, Description = "Optimize cloud costs and resource usage" },
                                new LearningObjective { Id = 208, StepId = 48, Description = "Implement cost allocation and tagging" },
                                new LearningObjective { Id = 209, StepId = 48, Description = "Use reserved instances and savings plans" },
                                new LearningObjective { Id = 210, StepId = 48, Description = "Create cost monitoring dashboards" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 124, StepId = 48, Title = "FinOps Foundation", Url = "https://www.finops.org/", Type = "website" },
                                new Resource { Id = 125, StepId = 48, Title = "AWS Cost Optimization", Url = "https://aws.amazon.com/aws-cost-management/", Type = "guide" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 49,
                            RoadmapId = 7,
                            Title = "Microservices & Event-Driven Architecture",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 211, StepId = 49, Description = "Design microservices architectures" },
                                new LearningObjective { Id = 212, StepId = 49, Description = "Implement event-driven patterns" },
                                new LearningObjective { Id = 213, StepId = 49, Description = "Use message queues and event streams" },
                                new LearningObjective { Id = 214, StepId = 49, Description = "Handle distributed transactions" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 126, StepId = 49, Title = "Microservices Patterns", Url = "https://microservices.io/patterns/", Type = "website" },
                                new Resource { Id = 127, StepId = 49, Title = "Event-Driven Architecture", Url = "https://aws.amazon.com/event-driven-architecture/", Type = "guide" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 50,
                            RoadmapId = 7,
                            Title = "Enterprise Architecture & Migration",
                            Duration = "4-6 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 215, StepId = 50, Description = "Plan large-scale cloud migrations" },
                                new LearningObjective { Id = 216, StepId = 50, Description = "Use cloud adoption frameworks" },
                                new LearningObjective { Id = 217, StepId = 50, Description = "Design enterprise-grade solutions" },
                                new LearningObjective { Id = 218, StepId = 50, Description = "Lead architectural reviews and decisions" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 128, StepId = 50, Title = "AWS Migration Hub", Url = "https://aws.amazon.com/migration-hub/", Type = "documentation" },
                                new Resource { Id = 129, StepId = 50, Title = "Cloud Adoption Framework", Url = "https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/", Type = "guide" }
                            }
                        }
                    }
                },
                // Specialized
                new Roadmap
                {
                    Id = 8,
                    Title = "Cybersecurity Specialist",
                    Description = "Protect systems and data from security threats",
                    Icon = "🔒",
                    Category = CategoryConstants.Specialized,
                    Duration = "8-12 months",
                    Difficulty = "Advanced",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 51,
                            RoadmapId = 8,
                            Title = "Security Fundamentals & Networking",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 219, StepId = 51, Description = "Master CIA triad and security principles" },
                                new LearningObjective { Id = 220, StepId = 51, Description = "Understand OSI model and TCP/IP stack" },
                                new LearningObjective { Id = 221, StepId = 51, Description = "Learn network protocols and vulnerabilities" },
                                new LearningObjective { Id = 222, StepId = 51, Description = "Configure firewalls and network segmentation" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 130, StepId = 51, Title = "CompTIA Security+", Url = "https://www.comptia.org/certifications/security", Type = "certification" },
                                new Resource { Id = 131, StepId = 51, Title = "Cybrary Security Fundamentals", Url = "https://www.cybrary.it/", Type = "course" },
                                new Resource { Id = 132, StepId = 51, Title = "NIST Cybersecurity Framework", Url = "https://www.nist.gov/cyberframework", Type = "guide" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 52,
                            RoadmapId = 8,
                            Title = "Ethical Hacking & Penetration Testing",
                            Duration = "6-8 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 223, StepId = 52, Description = "Master Kali Linux and security tools" },
                                new LearningObjective { Id = 224, StepId = 52, Description = "Perform vulnerability assessments" },
                                new LearningObjective { Id = 225, StepId = 52, Description = "Conduct penetration testing methodologies" },
                                new LearningObjective { Id = 226, StepId = 52, Description = "Write professional security reports" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 133, StepId = 52, Title = "OSCP Certification", Url = "https://www.offensive-security.com/pwk-oscp/", Type = "certification" },
                                new Resource { Id = 134, StepId = 52, Title = "HackTheBox", Url = "https://www.hackthebox.com/", Type = "interactive" },
                                new Resource { Id = 135, StepId = 52, Title = "TryHackMe", Url = "https://tryhackme.com/", Type = "interactive" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 53,
                            RoadmapId = 8,
                            Title = "Web Application Security",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 227, StepId = 53, Description = "Master OWASP Top 10 vulnerabilities" },
                                new LearningObjective { Id = 228, StepId = 53, Description = "Perform SQL injection and XSS attacks" },
                                new LearningObjective { Id = 229, StepId = 53, Description = "Secure APIs and authentication" },
                                new LearningObjective { Id = 230, StepId = 53, Description = "Use Burp Suite and OWASP ZAP" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 136, StepId = 53, Title = "OWASP WebGoat", Url = "https://owasp.org/www-project-webgoat/", Type = "interactive" },
                                new Resource { Id = 137, StepId = 53, Title = "PortSwigger Web Security", Url = "https://portswigger.net/web-security", Type = "tutorial" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 54,
                            RoadmapId = 8,
                            Title = "Cryptography & PKI",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 231, StepId = 54, Description = "Understand encryption algorithms (AES, RSA)" },
                                new LearningObjective { Id = 232, StepId = 54, Description = "Implement SSL/TLS and certificates" },
                                new LearningObjective { Id = 233, StepId = 54, Description = "Master hashing and digital signatures" },
                                new LearningObjective { Id = 234, StepId = 54, Description = "Design public key infrastructure" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 138, StepId = 54, Title = "Cryptography I", Url = "https://www.coursera.org/learn/crypto", Type = "course" },
                                new Resource { Id = 139, StepId = 54, Title = "Applied Cryptography", Url = "https://www.schneier.com/books/applied-cryptography/", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 55,
                            RoadmapId = 8,
                            Title = "Incident Response & Forensics",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 235, StepId = 55, Description = "Create incident response plans" },
                                new LearningObjective { Id = 236, StepId = 55, Description = "Perform digital forensics analysis" },
                                new LearningObjective { Id = 237, StepId = 55, Description = "Use SIEM tools (Splunk, ELK)" },
                                new LearningObjective { Id = 238, StepId = 55, Description = "Conduct threat hunting" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 140, StepId = 55, Title = "SANS Incident Response", Url = "https://www.sans.org/cyber-security-courses/incident-handler/", Type = "course" },
                                new Resource { Id = 141, StepId = 55, Title = "Digital Forensics with Autopsy", Url = "https://www.autopsy.com/", Type = "tool" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 56,
                            RoadmapId = 8,
                            Title = "Cloud Security & DevSecOps",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 239, StepId = 56, Description = "Secure cloud infrastructure (AWS, Azure)" },
                                new LearningObjective { Id = 240, StepId = 56, Description = "Implement container security" },
                                new LearningObjective { Id = 241, StepId = 56, Description = "Integrate security in CI/CD pipelines" },
                                new LearningObjective { Id = 242, StepId = 56, Description = "Use infrastructure as code security" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 142, StepId = 56, Title = "AWS Security Specialty", Url = "https://aws.amazon.com/certification/certified-security-specialty/", Type = "certification" },
                                new Resource { Id = 143, StepId = 56, Title = "DevSecOps Manifesto", Url = "https://www.devsecops.org/", Type = "website" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 57,
                            RoadmapId = 8,
                            Title = "Compliance & Risk Management",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 243, StepId = 57, Description = "Understand compliance frameworks (ISO 27001, SOC2)" },
                                new LearningObjective { Id = 244, StepId = 57, Description = "Perform risk assessments" },
                                new LearningObjective { Id = 245, StepId = 57, Description = "Create security policies and procedures" },
                                new LearningObjective { Id = 246, StepId = 57, Description = "Conduct security audits" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 144, StepId = 57, Title = "CISA Certification", Url = "https://www.isaca.org/credentialing/cisa", Type = "certification" },
                                new Resource { Id = 145, StepId = 57, Title = "NIST Risk Management", Url = "https://www.nist.gov/risk-management", Type = "guide" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 58,
                            RoadmapId = 8,
                            Title = "Advanced Threats & Red Teaming",
                            Duration = "4-6 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 247, StepId = 58, Description = "Analyze advanced persistent threats (APTs)" },
                                new LearningObjective { Id = 248, StepId = 58, Description = "Conduct red team exercises" },
                                new LearningObjective { Id = 249, StepId = 58, Description = "Implement threat intelligence" },
                                new LearningObjective { Id = 250, StepId = 58, Description = "Master exploit development" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 146, StepId = 58, Title = "MITRE ATT&CK Framework", Url = "https://attack.mitre.org/", Type = "framework" },
                                new Resource { Id = 147, StepId = 58, Title = "Red Team Field Manual", Url = "https://www.amazon.com/Rtfm-Red-Team-Field-Manual/dp/1494295504", Type = "book" }
                            }
                        }
                    }
                },
                new Roadmap
                {
                    Id = 9,
                    Title = "UX/UI Designer",
                    Description = "Create beautiful and intuitive user experiences",
                    Icon = "🎯",
                    Category = CategoryConstants.Specialized,
                    Duration = "6-8 months",
                    Difficulty = "Beginner to Intermediate",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 59,
                            RoadmapId = 9,
                            Title = "Design Fundamentals & Theory",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 251, StepId = 59, Description = "Master color theory, typography, and composition" },
                                new LearningObjective { Id = 252, StepId = 59, Description = "Understand Gestalt principles and visual hierarchy" },
                                new LearningObjective { Id = 253, StepId = 59, Description = "Learn design history and movements" },
                                new LearningObjective { Id = 254, StepId = 59, Description = "Apply grid systems and spacing" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 148, StepId = 59, Title = "Design Principles Course", Url = "https://www.coursera.org/learn/design-principles", Type = "course" },
                                new Resource { Id = 149, StepId = 59, Title = "The Design of Everyday Things", Url = "https://www.nngroup.com/books/design-everyday-things-revised/", Type = "book" },
                                new Resource { Id = 150, StepId = 59, Title = "Refactoring UI", Url = "https://www.refactoringui.com/", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 60,
                            RoadmapId = 9,
                            Title = "User Research & Psychology",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 255, StepId = 60, Description = "Conduct user interviews and surveys" },
                                new LearningObjective { Id = 256, StepId = 60, Description = "Create user personas and journey maps" },
                                new LearningObjective { Id = 257, StepId = 60, Description = "Understand cognitive psychology in design" },
                                new LearningObjective { Id = 258, StepId = 60, Description = "Apply behavioral design principles" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 151, StepId = 60, Title = "UX Research Methods", Url = "https://www.nngroup.com/articles/which-ux-research-methods/", Type = "article" },
                                new Resource { Id = 152, StepId = 60, Title = "Don't Make Me Think", Url = "https://sensible.com/dont-make-me-think/", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 61,
                            RoadmapId = 9,
                            Title = "Design Tools Mastery",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 259, StepId = 61, Description = "Master Figma for UI design and prototyping" },
                                new LearningObjective { Id = 260, StepId = 61, Description = "Learn Adobe XD or Sketch" },
                                new LearningObjective { Id = 261, StepId = 61, Description = "Use design systems and component libraries" },
                                new LearningObjective { Id = 262, StepId = 61, Description = "Create interactive prototypes" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 153, StepId = 61, Title = "Figma Academy", Url = "https://www.figma.com/resources/learn-design/", Type = "tutorial" },
                                new Resource { Id = 154, StepId = 61, Title = "Design+Code", Url = "https://designcode.io/", Type = "course" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 62,
                            RoadmapId = 9,
                            Title = "Information Architecture & Wireframing",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 263, StepId = 62, Description = "Structure information hierarchies" },
                                new LearningObjective { Id = 264, StepId = 62, Description = "Create sitemaps and user flows" },
                                new LearningObjective { Id = 265, StepId = 62, Description = "Design low and high-fidelity wireframes" },
                                new LearningObjective { Id = 266, StepId = 62, Description = "Conduct card sorting exercises" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 155, StepId = 62, Title = "Information Architecture", Url = "https://www.oreilly.com/library/view/information-architecture-4th/9781491913529/", Type = "book" },
                                new Resource { Id = 156, StepId = 62, Title = "Wireframing Guide", Url = "https://www.usability.gov/how-to-and-tools/methods/wireframing.html", Type = "guide" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 63,
                            RoadmapId = 9,
                            Title = "Visual & Interaction Design",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 267, StepId = 63, Description = "Design beautiful and consistent interfaces" },
                                new LearningObjective { Id = 268, StepId = 63, Description = "Create micro-interactions and animations" },
                                new LearningObjective { Id = 269, StepId = 63, Description = "Implement responsive design principles" },
                                new LearningObjective { Id = 270, StepId = 63, Description = "Design for accessibility (WCAG guidelines)" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 157, StepId = 63, Title = "Material Design", Url = "https://material.io/design", Type = "guide" },
                                new Resource { Id = 158, StepId = 63, Title = "Interaction Design Foundation", Url = "https://www.interaction-design.org/", Type = "course" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 64,
                            RoadmapId = 9,
                            Title = "Design Systems & Style Guides",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 271, StepId = 64, Description = "Build scalable design systems" },
                                new LearningObjective { Id = 272, StepId = 64, Description = "Create component libraries" },
                                new LearningObjective { Id = 273, StepId = 64, Description = "Document design patterns" },
                                new LearningObjective { Id = 274, StepId = 64, Description = "Maintain brand consistency" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 159, StepId = 64, Title = "Design Systems Handbook", Url = "https://www.designsystems.com/", Type = "book" },
                                new Resource { Id = 160, StepId = 64, Title = "Atomic Design", Url = "https://atomicdesign.bradfrost.com/", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 65,
                            RoadmapId = 9,
                            Title = "Usability Testing & Iteration",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 275, StepId = 65, Description = "Plan and conduct usability tests" },
                                new LearningObjective { Id = 276, StepId = 65, Description = "Analyze user feedback and metrics" },
                                new LearningObjective { Id = 277, StepId = 65, Description = "Iterate designs based on insights" },
                                new LearningObjective { Id = 278, StepId = 65, Description = "A/B test design variations" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 161, StepId = 65, Title = "Rocket Surgery Made Easy", Url = "https://sensible.com/rocket-surgery-made-easy/", Type = "book" },
                                new Resource { Id = 162, StepId = 65, Title = "UsabilityHub", Url = "https://usabilityhub.com/", Type = "tool" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 66,
                            RoadmapId = 9,
                            Title = "Portfolio & Career Development",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 279, StepId = 66, Description = "Build a compelling design portfolio" },
                                new LearningObjective { Id = 280, StepId = 66, Description = "Present case studies effectively" },
                                new LearningObjective { Id = 281, StepId = 66, Description = "Network with design community" },
                                new LearningObjective { Id = 282, StepId = 66, Description = "Prepare for design interviews" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 163, StepId = 66, Title = "Behance", Url = "https://www.behance.net/", Type = "website" },
                                new Resource { Id = 164, StepId = 66, Title = "UX Portfolio Formula", Url = "https://uxdesign.cc/ux-portfolio-formula-7d5ba2c7c4d2", Type = "article" }
                            }
                        }
                    }
                },
                new Roadmap
                {
                    Id = 10,
                    Title = "Product Manager",
                    Description = "Lead product strategy and development",
                    Icon = "💼",
                    Category = CategoryConstants.Specialized,
                    Duration = "6-9 months",
                    Difficulty = "Intermediate",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 67,
                            RoadmapId = 10,
                            Title = "Product Management Fundamentals",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 283, StepId = 67, Description = "Understand the product manager role and responsibilities" },
                                new LearningObjective { Id = 284, StepId = 67, Description = "Learn product development lifecycle" },
                                new LearningObjective { Id = 285, StepId = 67, Description = "Master agile and scrum methodologies" },
                                new LearningObjective { Id = 286, StepId = 67, Description = "Develop product thinking mindset" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 165, StepId = 67, Title = "Inspired by Marty Cagan", Url = "https://www.svpg.com/inspired-how-to-create-products-customers-love/", Type = "book" },
                                new Resource { Id = 166, StepId = 67, Title = "Product School", Url = "https://productschool.com/", Type = "course" },
                                new Resource { Id = 167, StepId = 67, Title = "The Lean Startup", Url = "http://theleanstartup.com/", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 68,
                            RoadmapId = 10,
                            Title = "Market Research & Analysis",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 287, StepId = 68, Description = "Conduct competitive analysis" },
                                new LearningObjective { Id = 288, StepId = 68, Description = "Identify market opportunities" },
                                new LearningObjective { Id = 289, StepId = 68, Description = "Analyze industry trends" },
                                new LearningObjective { Id = 290, StepId = 68, Description = "Define target customer segments" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 168, StepId = 68, Title = "Competitive Strategy", Url = "https://www.hbs.edu/faculty/Pages/item.aspx?num=195", Type = "book" },
                                new Resource { Id = 169, StepId = 68, Title = "Market Research Guide", Url = "https://www.hubspot.com/market-research", Type = "guide" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 69,
                            RoadmapId = 10,
                            Title = "User Research & Customer Development",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 291, StepId = 69, Description = "Conduct customer interviews and surveys" },
                                new LearningObjective { Id = 292, StepId = 69, Description = "Create user personas and jobs-to-be-done" },
                                new LearningObjective { Id = 293, StepId = 69, Description = "Map customer journeys" },
                                new LearningObjective { Id = 294, StepId = 69, Description = "Validate problem-solution fit" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 170, StepId = 69, Title = "The Mom Test", Url = "http://momtestbook.com/", Type = "book" },
                                new Resource { Id = 171, StepId = 69, Title = "Jobs to be Done", Url = "https://jobs-to-be-done.com/", Type = "framework" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 70,
                            RoadmapId = 10,
                            Title = "Product Strategy & Vision",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 295, StepId = 70, Description = "Define product vision and mission" },
                                new LearningObjective { Id = 296, StepId = 70, Description = "Create product strategy and positioning" },
                                new LearningObjective { Id = 297, StepId = 70, Description = "Develop value propositions" },
                                new LearningObjective { Id = 298, StepId = 70, Description = "Build strategic roadmaps" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 172, StepId = 70, Title = "Good Strategy Bad Strategy", Url = "https://www.amazon.com/Good-Strategy-Bad-Difference-Matters/dp/0307886239", Type = "book" },
                                new Resource { Id = 173, StepId = 70, Title = "Product Strategy Stack", Url = "https://www.reforge.com/product-strategy", Type = "course" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 71,
                            RoadmapId = 10,
                            Title = "Data Analytics & Metrics",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 299, StepId = 71, Description = "Define KPIs and success metrics" },
                                new LearningObjective { Id = 300, StepId = 71, Description = "Master analytics tools (Google Analytics, Mixpanel)" },
                                new LearningObjective { Id = 301, StepId = 71, Description = "Conduct A/B testing and experiments" },
                                new LearningObjective { Id = 302, StepId = 71, Description = "Create data-driven insights" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 174, StepId = 71, Title = "Lean Analytics", Url = "https://leananalyticsbook.com/", Type = "book" },
                                new Resource { Id = 175, StepId = 71, Title = "Google Analytics Academy", Url = "https://analytics.google.com/analytics/academy/", Type = "course" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 72,
                            RoadmapId = 10,
                            Title = "Prioritization & Roadmapping",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 303, StepId = 72, Description = "Master prioritization frameworks (RICE, Value vs Effort)" },
                                new LearningObjective { Id = 304, StepId = 72, Description = "Build and maintain product roadmaps" },
                                new LearningObjective { Id = 305, StepId = 72, Description = "Manage feature backlogs" },
                                new LearningObjective { Id = 306, StepId = 72, Description = "Balance stakeholder needs" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 176, StepId = 72, Title = "Roadmapping Tools", Url = "https://www.productplan.com/", Type = "tool" },
                                new Resource { Id = 177, StepId = 72, Title = "Prioritization Techniques", Url = "https://www.productplan.com/learn/product-prioritization-techniques/", Type = "guide" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 73,
                            RoadmapId = 10,
                            Title = "Stakeholder Management",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 307, StepId = 73, Description = "Collaborate with engineering and design teams" },
                                new LearningObjective { Id = 308, StepId = 73, Description = "Manage executive expectations" },
                                new LearningObjective { Id = 309, StepId = 73, Description = "Work with sales and marketing" },
                                new LearningObjective { Id = 310, StepId = 73, Description = "Communicate product decisions effectively" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 178, StepId = 73, Title = "Crucial Conversations", Url = "https://cruciallearning.com/crucial-conversations-book/", Type = "book" },
                                new Resource { Id = 179, StepId = 73, Title = "Stakeholder Management", Url = "https://www.mindtools.com/pages/article/newPPM_08.htm", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 74,
                            RoadmapId = 10,
                            Title = "Go-to-Market & Growth",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 311, StepId = 74, Description = "Develop go-to-market strategies" },
                                new LearningObjective { Id = 312, StepId = 74, Description = "Create pricing models" },
                                new LearningObjective { Id = 313, StepId = 74, Description = "Plan product launches" },
                                new LearningObjective { Id = 314, StepId = 74, Description = "Implement growth hacking techniques" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 180, StepId = 74, Title = "Crossing the Chasm", Url = "https://www.amazon.com/Crossing-Chasm-Marketing-High-Tech-Mainstream/dp/0062292988", Type = "book" },
                                new Resource { Id = 181, StepId = 74, Title = "Growth Hacking Course", Url = "https://www.udemy.com/course/growth-hacking/", Type = "course" }
                            }
                        }
                    }
                },
                
                // C# Fundamentals
                new Roadmap
                {
                    Id = 11,
                    Title = "C# Developer",
                    Description = "Master C# programming language from basics to advanced concepts",
                    Icon = "🔷",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "4-6 months",
                    Difficulty = "Beginner to Advanced",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 75,
                            RoadmapId = 11,
                            Title = "C# Language Basics",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 315, StepId = 75, Description = "Understand C# syntax and basic constructs" },
                                new LearningObjective { Id = 316, StepId = 75, Description = "Master data types, variables, and operators" },
                                new LearningObjective { Id = 317, StepId = 75, Description = "Learn control flow and loops" },
                                new LearningObjective { Id = 318, StepId = 75, Description = "Work with arrays and collections" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 182, StepId = 75, Title = "Microsoft C# Documentation", Url = "https://docs.microsoft.com/en-us/dotnet/csharp/", Type = "article" },
                                new Resource { Id = 183, StepId = 75, Title = "C# Fundamentals by Scott Allen", Url = "https://www.pluralsight.com/courses/csharp-fundamentals-dev", Type = "course" },
                                new Resource { Id = 184, StepId = 75, Title = "C# Yellow Book", Url = "http://www.csharpcourse.com/", Type = "book" },
                                new Resource { Id = 185, StepId = 75, Title = "C# Interactive Tutorial", Url = "https://dotnet.microsoft.com/en-us/learn/csharp", Type = "interactive" },
                                new Resource { Id = 186, StepId = 75, Title = "C# Programming Guide", Url = "https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 76,
                            RoadmapId = 11,
                            Title = "Object-Oriented Programming in C#",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 319, StepId = 76, Description = "Master classes, objects, and constructors" },
                                new LearningObjective { Id = 320, StepId = 76, Description = "Understand inheritance and polymorphism" },
                                new LearningObjective { Id = 321, StepId = 76, Description = "Learn interfaces and abstract classes" },
                                new LearningObjective { Id = 322, StepId = 76, Description = "Apply encapsulation and access modifiers" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 187, StepId = 76, Title = "OOP Concepts in C#", Url = "https://www.tutorialspoint.com/csharp/csharp_object_oriented.htm", Type = "article" },
                                new Resource { Id = 188, StepId = 76, Title = "Object-Oriented Programming in C# (Video Series)", Url = "https://www.youtube.com/playlist?list=PLLWMQd6PeGY0bEMxObA6dtYXuJOGfxSPx", Type = "video" },
                                new Resource { Id = 189, StepId = 76, Title = "Head First C#", Url = "https://www.oreilly.com/library/view/head-first-c/9781491976692/", Type = "book" },
                                new Resource { Id = 190, StepId = 76, Title = "C# OOP Exercises", Url = "https://www.w3resource.com/csharp-exercises/oop/index.php", Type = "interactive" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 77,
                            RoadmapId = 11,
                            Title = "Advanced C# Features",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 323, StepId = 77, Description = "Master LINQ and lambda expressions" },
                                new LearningObjective { Id = 324, StepId = 77, Description = "Understand delegates and events" },
                                new LearningObjective { Id = 325, StepId = 77, Description = "Learn async/await programming" },
                                new LearningObjective { Id = 326, StepId = 77, Description = "Work with generics and attributes" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 191, StepId = 77, Title = "LINQ Tutorial", Url = "https://www.tutorialsteacher.com/linq", Type = "article" },
                                new Resource { Id = 192, StepId = 77, Title = "Async Programming in C#", Url = "https://docs.microsoft.com/en-us/dotnet/csharp/async", Type = "documentation" },
                                new Resource { Id = 193, StepId = 77, Title = "C# Advanced Features Course", Url = "https://www.udemy.com/course/csharp-advanced/", Type = "course" },
                                new Resource { Id = 194, StepId = 77, Title = "Functional Programming in C#", Url = "https://www.manning.com/books/functional-programming-in-c-sharp", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 78,
                            RoadmapId = 11,
                            Title = "C# Best Practices",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 327, StepId = 78, Description = "Apply coding standards and naming conventions" },
                                new LearningObjective { Id = 328, StepId = 78, Description = "Handle exceptions properly" },
                                new LearningObjective { Id = 329, StepId = 78, Description = "Implement memory management best practices" },
                                new LearningObjective { Id = 330, StepId = 78, Description = "Write clean and maintainable code" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 195, StepId = 78, Title = "C# Coding Standards and Naming Conventions", Url = "https://www.dofactory.com/csharp-coding-standards", Type = "article" },
                                new Resource { Id = 196, StepId = 78, Title = "Clean Code in C#", Url = "https://github.com/thangchung/clean-code-dotnet", Type = "website" },
                                new Resource { Id = 197, StepId = 78, Title = "Effective C# by Bill Wagner", Url = "https://www.oreilly.com/library/view/effective-c-covers/9780134579290/", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 101,
                            RoadmapId = 11,
                            Title = ".NET Framework and Core",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 419, StepId = 101, Description = "Understand .NET architecture and CLR" },
                                new LearningObjective { Id = 420, StepId = 101, Description = "Master .NET Core vs .NET Framework differences" },
                                new LearningObjective { Id = 421, StepId = 101, Description = "Work with NuGet packages and dependencies" },
                                new LearningObjective { Id = 422, StepId = 101, Description = "Learn cross-platform development" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 198, StepId = 101, Title = ".NET Documentation", Url = "https://docs.microsoft.com/en-us/dotnet/", Type = "documentation" },
                                new Resource { Id = 199, StepId = 101, Title = "Pro .NET 5", Url = "https://www.apress.com/gp/book/9781484263006", Type = "book" },
                                new Resource { Id = 200, StepId = 101, Title = ".NET Core in Action", Url = "https://www.manning.com/books/dotnet-core-in-action", Type = "book" },
                                new Resource { Id = 201, StepId = 101, Title = ".NET Core Tutorials", Url = "https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial", Type = "interactive" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 102,
                            RoadmapId = 11,
                            Title = "C# Performance and Optimization",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 423, StepId = 102, Description = "Profile and benchmark C# applications" },
                                new LearningObjective { Id = 424, StepId = 102, Description = "Optimize memory usage and garbage collection" },
                                new LearningObjective { Id = 425, StepId = 102, Description = "Improve algorithm efficiency" },
                                new LearningObjective { Id = 426, StepId = 102, Description = "Use parallel and concurrent programming" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 202, StepId = 102, Title = "Writing High-Performance .NET Code", Url = "https://www.writinghighperf.net/", Type = "book" },
                                new Resource { Id = 203, StepId = 102, Title = "BenchmarkDotNet", Url = "https://benchmarkdotnet.org/", Type = "website" },
                                new Resource { Id = 204, StepId = 102, Title = "Pro .NET Memory Management", Url = "https://prodotnetmemory.com/", Type = "book" },
                                new Resource { Id = 205, StepId = 102, Title = "C# Performance Tips", Url = "https://docs.microsoft.com/en-us/dotnet/csharp/write-safe-efficient-code", Type = "article" }
                            }
                        }
                    }
                },
                
                // OOP Concepts
                new Roadmap
                {
                    Id = 12,
                    Title = "Object-Oriented Programming",
                    Description = "Master OOP concepts and principles for better software design",
                    Icon = "🔸",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 79,
                            RoadmapId = 12,
                            Title = "OOP Fundamentals",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 331, StepId = 79, Description = "Understand classes and objects" },
                                new LearningObjective { Id = 332, StepId = 79, Description = "Master encapsulation principle" },
                                new LearningObjective { Id = 333, StepId = 79, Description = "Learn constructors and destructors" },
                                new LearningObjective { Id = 334, StepId = 79, Description = "Apply access modifiers effectively" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 206, StepId = 79, Title = "Object-Oriented Programming Concepts", Url = "https://www.geeksforgeeks.org/object-oriented-programming-oops-concept-in-java/", Type = "article" },
                                new Resource { Id = 207, StepId = 79, Title = "OOP Fundamentals Course", Url = "https://www.coursera.org/learn/object-oriented-programming", Type = "course" },
                                new Resource { Id = 208, StepId = 79, Title = "Head First Object-Oriented Analysis and Design", Url = "https://www.oreilly.com/library/view/head-first-object-oriented/0596008678/", Type = "book" },
                                new Resource { Id = 209, StepId = 79, Title = "OOP Interactive Tutorial", Url = "https://www.codecademy.com/learn/learn-object-oriented-programming", Type = "interactive" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 80,
                            RoadmapId = 12,
                            Title = "Inheritance & Polymorphism",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 335, StepId = 80, Description = "Master inheritance hierarchies" },
                                new LearningObjective { Id = 336, StepId = 80, Description = "Understand method overriding and overloading" },
                                new LearningObjective { Id = 337, StepId = 80, Description = "Apply polymorphism in real scenarios" },
                                new LearningObjective { Id = 338, StepId = 80, Description = "Learn abstract classes and interfaces" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 210, StepId = 80, Title = "Understanding Inheritance and Polymorphism", Url = "https://www.tutorialspoint.com/cplusplus/cpp_inheritance.htm", Type = "article" },
                                new Resource { Id = 211, StepId = 80, Title = "Polymorphism in OOP", Url = "https://www.youtube.com/watch?v=AmdgJ-HhilE", Type = "video" },
                                new Resource { Id = 212, StepId = 80, Title = "Design Patterns: Elements of Reusable Object-Oriented Software", Url = "https://www.amazon.com/Design-Patterns-Elements-Reusable-Object-Oriented/dp/0201633612", Type = "book" },
                                new Resource { Id = 213, StepId = 80, Title = "Inheritance vs Composition", Url = "https://www.thoughtworks.com/insights/blog/composition-vs-inheritance-how-choose", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 81,
                            RoadmapId = 12,
                            Title = "Advanced OOP Concepts",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 339, StepId = 81, Description = "Master composition over inheritance" },
                                new LearningObjective { Id = 340, StepId = 81, Description = "Understand dependency injection" },
                                new LearningObjective { Id = 341, StepId = 81, Description = "Apply SOLID principles" },
                                new LearningObjective { Id = 342, StepId = 81, Description = "Learn design patterns basics" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 214, StepId = 81, Title = "Composition over Inheritance", Url = "https://medium.com/humans-create-software/composition-over-inheritance-cb6f88070205", Type = "article" },
                                new Resource { Id = 215, StepId = 81, Title = "Dependency Injection Explained", Url = "https://www.freecodecamp.org/news/a-quick-intro-to-dependency-injection-what-it-is-and-when-to-use-it-7578c84fa88f/", Type = "article" },
                                new Resource { Id = 216, StepId = 81, Title = "Clean Architecture", Url = "https://www.amazon.com/Clean-Architecture-Craftsmans-Software-Structure/dp/0134494164", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 103,
                            RoadmapId = 12,
                            Title = "Abstraction and Interfaces",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 427, StepId = 103, Description = "Design effective abstractions" },
                                new LearningObjective { Id = 428, StepId = 103, Description = "Create and implement interfaces" },
                                new LearningObjective { Id = 429, StepId = 103, Description = "Understand interface segregation" },
                                new LearningObjective { Id = 430, StepId = 103, Description = "Apply abstraction in real-world scenarios" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 217, StepId = 103, Title = "Abstraction in OOP", Url = "https://stackify.com/oop-concept-abstraction/", Type = "article" },
                                new Resource { Id = 218, StepId = 103, Title = "Interface Design Principles", Url = "https://www.oodesign.com/interface-segregation-principle.html", Type = "article" },
                                new Resource { Id = 219, StepId = 103, Title = "Programming to Interfaces", Url = "https://www.youtube.com/watch?v=GKQY0r8hGJg", Type = "video" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 104,
                            RoadmapId = 12,
                            Title = "OOP in Different Languages",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 431, StepId = 104, Description = "Compare OOP in C#, Java, and Python" },
                                new LearningObjective { Id = 432, StepId = 104, Description = "Understand language-specific OOP features" },
                                new LearningObjective { Id = 433, StepId = 104, Description = "Learn prototype-based vs class-based OOP" },
                                new LearningObjective { Id = 434, StepId = 104, Description = "Apply OOP patterns across languages" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 220, StepId = 104, Title = "OOP in Different Languages", Url = "https://www.geeksforgeeks.org/comparison-of-object-oriented-programming-languages/", Type = "article" },
                                new Resource { Id = 221, StepId = 104, Title = "JavaScript OOP vs Classical OOP", Url = "https://developer.mozilla.org/en-US/docs/Learn/JavaScript/Objects/Object-oriented_programming", Type = "article" },
                                new Resource { Id = 222, StepId = 104, Title = "Python OOP Tutorial", Url = "https://realpython.com/python3-object-oriented-programming/", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 105,
                            RoadmapId = 12,
                            Title = "OOP Best Practices and Anti-patterns",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 435, StepId = 105, Description = "Identify and avoid common OOP anti-patterns" },
                                new LearningObjective { Id = 436, StepId = 105, Description = "Apply OOP best practices" },
                                new LearningObjective { Id = 437, StepId = 105, Description = "Refactor code to improve OOP design" },
                                new LearningObjective { Id = 438, StepId = 105, Description = "Balance OOP with functional programming" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 223, StepId = 105, Title = "OOP Anti-patterns", Url = "https://sourcemaking.com/antipatterns", Type = "website" },
                                new Resource { Id = 224, StepId = 105, Title = "Refactoring: Improving the Design of Existing Code", Url = "https://martinfowler.com/books/refactoring.html", Type = "book" },
                                new Resource { Id = 225, StepId = 105, Title = "OOP Best Practices", Url = "https://www.educative.io/blog/object-oriented-programming-best-practices", Type = "article" }
                            }
                        }
                    }
                },
                
                // SOLID Principles
                new Roadmap
                {
                    Id = 13,
                    Title = "SOLID Principles",
                    Description = "Master SOLID principles for creating maintainable and scalable code",
                    Icon = "📐",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "2-3 months",
                    Difficulty = "Intermediate to Advanced",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 82,
                            RoadmapId = 13,
                            Title = "Single Responsibility Principle",
                            Duration = "2 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 343, StepId = 82, Description = "Understand SRP concept and benefits" },
                                new LearningObjective { Id = 344, StepId = 82, Description = "Identify SRP violations in code" },
                                new LearningObjective { Id = 345, StepId = 82, Description = "Refactor code to follow SRP" },
                                new LearningObjective { Id = 346, StepId = 82, Description = "Apply SRP in real projects" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 226, StepId = 82, Title = "Single Responsibility Principle Explained", Url = "https://www.digitalocean.com/community/conceptual_articles/s-o-l-i-d-the-first-five-principles-of-object-oriented-design#single-responsibility-principle", Type = "article" },
                                new Resource { Id = 227, StepId = 82, Title = "SRP in Practice", Url = "https://www.youtube.com/watch?v=AEnePs2Evg0", Type = "video" },
                                new Resource { Id = 228, StepId = 82, Title = "Clean Code Chapter 10: Classes", Url = "https://www.amazon.com/Clean-Code-Handbook-Software-Craftsmanship/dp/0132350882", Type = "book" },
                                new Resource { Id = 229, StepId = 82, Title = "SRP Code Examples", Url = "https://github.com/mikeknep/SOLID", Type = "website" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 83,
                            RoadmapId = 13,
                            Title = "Open/Closed Principle",
                            Duration = "2 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 347, StepId = 83, Description = "Master OCP fundamentals" },
                                new LearningObjective { Id = 348, StepId = 83, Description = "Use abstraction and inheritance for OCP" },
                                new LearningObjective { Id = 349, StepId = 83, Description = "Apply strategy pattern for extensibility" },
                                new LearningObjective { Id = 350, StepId = 83, Description = "Design extensible systems" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 230, StepId = 83, Title = "Open/Closed Principle in Depth", Url = "https://stackify.com/solid-design-open-closed-principle/", Type = "article" },
                                new Resource { Id = 231, StepId = 83, Title = "OCP and Strategy Pattern", Url = "https://www.youtube.com/watch?v=-xMaMREgkm4", Type = "video" },
                                new Resource { Id = 232, StepId = 83, Title = "Agile Software Development, Principles, Patterns, and Practices", Url = "https://www.amazon.com/Software-Development-Principles-Patterns-Practices/dp/0135974445", Type = "book" },
                                new Resource { Id = 233, StepId = 83, Title = "OCP Examples and Exercises", Url = "https://www.baeldung.com/solid-principles#o", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 84,
                            RoadmapId = 13,
                            Title = "Liskov Substitution & Interface Segregation",
                            Duration = "2 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 351, StepId = 84, Description = "Understand LSP and its importance" },
                                new LearningObjective { Id = 352, StepId = 84, Description = "Design proper inheritance hierarchies" },
                                new LearningObjective { Id = 353, StepId = 84, Description = "Master ISP and interface design" },
                                new LearningObjective { Id = 354, StepId = 84, Description = "Create focused interfaces" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 234, StepId = 84, Title = "Liskov Substitution Principle Explained", Url = "https://www.tomdalling.com/blog/software-design/solid-class-design-the-liskov-substitution-principle/", Type = "article" },
                                new Resource { Id = 235, StepId = 84, Title = "Interface Segregation Principle", Url = "https://www.youtube.com/watch?v=JVWZR23B_iE", Type = "video" },
                                new Resource { Id = 236, StepId = 84, Title = "LSP and ISP in Practice", Url = "https://www.pluralsight.com/courses/principles-oo-design", Type = "course" },
                                new Resource { Id = 237, StepId = 84, Title = "SOLID Principles Interactive Examples", Url = "https://www.codeproject.com/Articles/1210833/SOLID-Principles-with-Csharp-NET-Core", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 85,
                            RoadmapId = 13,
                            Title = "Dependency Inversion Principle",
                            Duration = "2 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 355, StepId = 85, Description = "Master DIP concepts" },
                                new LearningObjective { Id = 356, StepId = 85, Description = "Implement dependency injection" },
                                new LearningObjective { Id = 357, StepId = 85, Description = "Use IoC containers effectively" },
                                new LearningObjective { Id = 358, StepId = 85, Description = "Design loosely coupled systems" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 238, StepId = 85, Title = "Dependency Inversion Principle", Url = "https://www.tutorialsteacher.com/ioc/dependency-inversion-principle", Type = "article" },
                                new Resource { Id = 239, StepId = 85, Title = "DI and IoC Explained", Url = "https://www.youtube.com/watch?v=EPv9-cHEmQw", Type = "video" },
                                new Resource { Id = 240, StepId = 85, Title = "Dependency Injection in .NET", Url = "https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection", Type = "documentation" },
                                new Resource { Id = 241, StepId = 85, Title = "IoC Container Comparison", Url = "https://www.claudiobernasconi.ch/2019/01/24/the-ultimate-list-of-net-dependency-injection-frameworks/", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 106,
                            RoadmapId = 13,
                            Title = "SOLID in Practice",
                            Duration = "3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 439, StepId = 106, Description = "Apply all SOLID principles together" },
                                new LearningObjective { Id = 440, StepId = 106, Description = "Refactor legacy code using SOLID" },
                                new LearningObjective { Id = 441, StepId = 106, Description = "Design new systems with SOLID in mind" },
                                new LearningObjective { Id = 442, StepId = 106, Description = "Balance SOLID with pragmatism" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 242, StepId = 106, Title = "SOLID Principles Applied", Url = "https://www.pluralsight.com/courses/csharp-solid-principles", Type = "course" },
                                new Resource { Id = 243, StepId = 106, Title = "Refactoring to SOLID Code", Url = "https://github.com/ardalis/SolidSample", Type = "website" },
                                new Resource { Id = 244, StepId = 106, Title = "SOLID Case Studies", Url = "https://www.codeproject.com/Articles/1244275/SOLID-Principles-in-Csharp-Single-Responsibility", Type = "article" },
                                new Resource { Id = 245, StepId = 106, Title = "Working Effectively with Legacy Code", Url = "https://www.amazon.com/Working-Effectively-Legacy-Michael-Feathers/dp/0131177052", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 107,
                            RoadmapId = 13,
                            Title = "SOLID and Modern Architectures",
                            Duration = "2 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 443, StepId = 107, Description = "Apply SOLID in microservices" },
                                new LearningObjective { Id = 444, StepId = 107, Description = "Use SOLID with Domain-Driven Design" },
                                new LearningObjective { Id = 445, StepId = 107, Description = "Implement SOLID in serverless architectures" },
                                new LearningObjective { Id = 446, StepId = 107, Description = "Balance SOLID with functional programming" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 246, StepId = 107, Title = "SOLID in Microservices", Url = "https://www.infoq.com/articles/solid-principles-microservices/", Type = "article" },
                                new Resource { Id = 247, StepId = 107, Title = "Clean Architecture", Url = "https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html", Type = "article" },
                                new Resource { Id = 248, StepId = 107, Title = "SOLID and DDD", Url = "https://www.youtube.com/watch?v=dnUFEg68ESM", Type = "video" },
                                new Resource { Id = 249, StepId = 107, Title = "Functional and Object-Oriented Programming", Url = "https://www.manning.com/books/functional-programming-in-c-sharp-second-edition", Type = "book" }
                            }
                        }
                    }
                },
                
                // Design Patterns
                new Roadmap
                {
                    Id = 14,
                    Title = "Design Patterns",
                    Description = "Learn essential design patterns for solving common programming problems",
                    Icon = "🎯",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 86,
                            RoadmapId = 14,
                            Title = "Creational Patterns",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 359, StepId = 86, Description = "Master Singleton and Factory patterns" },
                                new LearningObjective { Id = 360, StepId = 86, Description = "Learn Abstract Factory and Builder" },
                                new LearningObjective { Id = 361, StepId = 86, Description = "Understand Prototype pattern" },
                                new LearningObjective { Id = 362, StepId = 86, Description = "Apply patterns in real scenarios" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 250, StepId = 86, Title = "Creational Design Patterns", Url = "https://refactoring.guru/design-patterns/creational-patterns", Type = "website" },
                                new Resource { Id = 251, StepId = 86, Title = "Factory Pattern Explained", Url = "https://www.youtube.com/watch?v=EcFVTgRHJLM", Type = "video" },
                                new Resource { Id = 252, StepId = 86, Title = "Design Patterns: Elements of Reusable Object-Oriented Software", Url = "https://www.amazon.com/Design-Patterns-Elements-Reusable-Object-Oriented/dp/0201633612", Type = "book" },
                                new Resource { Id = 253, StepId = 86, Title = "Interactive Design Patterns", Url = "https://www.patterns.dev/", Type = "interactive" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 87,
                            RoadmapId = 14,
                            Title = "Structural Patterns",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 363, StepId = 87, Description = "Master Adapter and Bridge patterns" },
                                new LearningObjective { Id = 364, StepId = 87, Description = "Learn Composite and Decorator" },
                                new LearningObjective { Id = 365, StepId = 87, Description = "Understand Facade and Proxy" },
                                new LearningObjective { Id = 366, StepId = 87, Description = "Apply Flyweight pattern" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 254, StepId = 87, Title = "Structural Design Patterns", Url = "https://refactoring.guru/design-patterns/structural-patterns", Type = "website" },
                                new Resource { Id = 255, StepId = 87, Title = "Decorator Pattern Tutorial", Url = "https://www.youtube.com/watch?v=GCraGHx6gso", Type = "video" },
                                new Resource { Id = 256, StepId = 87, Title = "Head First Design Patterns", Url = "https://www.oreilly.com/library/view/head-first-design/0596007124/", Type = "book" },
                                new Resource { Id = 257, StepId = 87, Title = "Structural Patterns in C#", Url = "https://www.dofactory.com/net/design-patterns#structural", Type = "website" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 88,
                            RoadmapId = 14,
                            Title = "Behavioral Patterns",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 367, StepId = 88, Description = "Master Observer and Strategy patterns" },
                                new LearningObjective { Id = 368, StepId = 88, Description = "Learn Command and Iterator" },
                                new LearningObjective { Id = 369, StepId = 88, Description = "Understand Template Method and Visitor" },
                                new LearningObjective { Id = 370, StepId = 88, Description = "Apply Chain of Responsibility" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 258, StepId = 88, Title = "Behavioral Design Patterns", Url = "https://refactoring.guru/design-patterns/behavioral-patterns", Type = "website" },
                                new Resource { Id = 259, StepId = 88, Title = "Observer Pattern Explained", Url = "https://www.youtube.com/watch?v=_BpmfnqjgzQ", Type = "video" },
                                new Resource { Id = 260, StepId = 88, Title = "Game Programming Patterns", Url = "https://gameprogrammingpatterns.com/", Type = "book" },
                                new Resource { Id = 261, StepId = 88, Title = "Strategy Pattern in Practice", Url = "https://www.baeldung.com/java-strategy-pattern", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 108,
                            RoadmapId = 14,
                            Title = "Modern Patterns and Anti-patterns",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 447, StepId = 108, Description = "Learn MVC, MVP, and MVVM patterns" },
                                new LearningObjective { Id = 448, StepId = 108, Description = "Understand Repository and Unit of Work" },
                                new LearningObjective { Id = 449, StepId = 108, Description = "Identify and avoid anti-patterns" },
                                new LearningObjective { Id = 450, StepId = 108, Description = "Apply patterns in modern frameworks" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 262, StepId = 108, Title = "MVC, MVP, MVVM Comparison", Url = "https://www.raywenderlich.com/34-design-patterns-by-tutorials-mvvm", Type = "article" },
                                new Resource { Id = 263, StepId = 108, Title = "Repository Pattern", Url = "https://www.youtube.com/watch?v=rtXpYpZdOzM", Type = "video" },
                                new Resource { Id = 264, StepId = 108, Title = "AntiPatterns", Url = "https://sourcemaking.com/antipatterns", Type = "website" },
                                new Resource { Id = 265, StepId = 108, Title = "Patterns of Enterprise Application Architecture", Url = "https://www.amazon.com/Patterns-Enterprise-Application-Architecture-Martin/dp/0321127420", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 109,
                            RoadmapId = 14,
                            Title = "Concurrent and Parallel Patterns",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 451, StepId = 109, Description = "Master Producer-Consumer pattern" },
                                new LearningObjective { Id = 452, StepId = 109, Description = "Learn Thread Pool and Future patterns" },
                                new LearningObjective { Id = 453, StepId = 109, Description = "Understand Actor model" },
                                new LearningObjective { Id = 454, StepId = 109, Description = "Apply async patterns effectively" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 266, StepId = 109, Title = "Concurrent Programming Patterns", Url = "https://www.dre.vanderbilt.edu/~schmidt/PDF/POSA2-concurrency-patterns.pdf", Type = "article" },
                                new Resource { Id = 267, StepId = 109, Title = "Async/Await Pattern", Url = "https://docs.microsoft.com/en-us/dotnet/standard/asynchronous-programming-patterns/", Type = "documentation" },
                                new Resource { Id = 268, StepId = 109, Title = "Java Concurrency in Practice", Url = "https://www.amazon.com/Java-Concurrency-Practice-Brian-Goetz/dp/0321349601", Type = "book" },
                                new Resource { Id = 269, StepId = 109, Title = "Actor Model Explained", Url = "https://www.youtube.com/watch?v=ELwEdb_pD0k", Type = "video" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 110,
                            RoadmapId = 14,
                            Title = "Architectural Patterns",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 455, StepId = 110, Description = "Master Layered and Hexagonal architectures" },
                                new LearningObjective { Id = 456, StepId = 110, Description = "Learn Event-Driven and CQRS patterns" },
                                new LearningObjective { Id = 457, StepId = 110, Description = "Understand Microservices patterns" },
                                new LearningObjective { Id = 458, StepId = 110, Description = "Apply Domain-Driven Design patterns" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 270, StepId = 110, Title = "Software Architecture Patterns", Url = "https://www.oreilly.com/content/software-architecture-patterns/", Type = "article" },
                                new Resource { Id = 271, StepId = 110, Title = "CQRS Pattern", Url = "https://martinfowler.com/bliki/CQRS.html", Type = "article" },
                                new Resource { Id = 272, StepId = 110, Title = "Microservices Patterns", Url = "https://microservices.io/patterns/", Type = "website" },
                                new Resource { Id = 273, StepId = 110, Title = "Domain-Driven Design", Url = "https://www.amazon.com/Domain-Driven-Design-Tackling-Complexity-Software/dp/0321125215", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 111,
                            RoadmapId = 14,
                            Title = "Patterns in Practice",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 459, StepId = 111, Description = "Combine multiple patterns effectively" },
                                new LearningObjective { Id = 460, StepId = 111, Description = "Refactor existing code using patterns" },
                                new LearningObjective { Id = 461, StepId = 111, Description = "Know when NOT to use patterns" },
                                new LearningObjective { Id = 462, StepId = 111, Description = "Document patterns in your codebase" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 274, StepId = 111, Title = "Design Patterns in the Real World", Url = "https://www.pluralsight.com/courses/design-patterns-on-ramp", Type = "course" },
                                new Resource { Id = 275, StepId = 111, Title = "Refactoring to Patterns", Url = "https://www.amazon.com/Refactoring-Patterns-Joshua-Kerievsky/dp/0321213351", Type = "book" },
                                new Resource { Id = 276, StepId = 111, Title = "Pattern-Oriented Software Architecture", Url = "https://www.amazon.com/Pattern-Oriented-Software-Architecture-System-Patterns/dp/0471958697", Type = "book" },
                                new Resource { Id = 277, StepId = 111, Title = "Real World Design Patterns", Url = "https://github.com/kamranahmedse/design-patterns-for-humans", Type = "website" }
                            }
                        }
                    }
                },
                
                // SQL & Databases
                new Roadmap
                {
                    Id = 15,
                    Title = "SQL & Database Development",
                    Description = "Master SQL and database design for efficient data management",
                    Icon = "🗄️",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "3-4 months",
                    Difficulty = "Beginner to Advanced",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 89,
                            RoadmapId = 15,
                            Title = "SQL Fundamentals",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 371, StepId = 89, Description = "Master SELECT, INSERT, UPDATE, DELETE" },
                                new LearningObjective { Id = 372, StepId = 89, Description = "Learn JOINs and subqueries" },
                                new LearningObjective { Id = 373, StepId = 89, Description = "Understand GROUP BY and aggregations" },
                                new LearningObjective { Id = 374, StepId = 89, Description = "Work with functions and expressions" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 90,
                            RoadmapId = 15,
                            Title = "Database Design",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 375, StepId = 90, Description = "Master normalization (1NF to BCNF)" },
                                new LearningObjective { Id = 376, StepId = 90, Description = "Design ER diagrams and schemas" },
                                new LearningObjective { Id = 377, StepId = 90, Description = "Implement primary and foreign keys" },
                                new LearningObjective { Id = 378, StepId = 90, Description = "Apply indexes and constraints" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 91,
                            RoadmapId = 15,
                            Title = "Advanced SQL & Performance",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 379, StepId = 91, Description = "Master stored procedures and functions" },
                                new LearningObjective { Id = 380, StepId = 91, Description = "Optimize queries and execution plans" },
                                new LearningObjective { Id = 381, StepId = 91, Description = "Implement transactions and ACID" },
                                new LearningObjective { Id = 382, StepId = 91, Description = "Use CTEs and window functions" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 92,
                            RoadmapId = 15,
                            Title = "NoSQL & Modern Databases",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 383, StepId = 92, Description = "Understand NoSQL concepts" },
                                new LearningObjective { Id = 384, StepId = 92, Description = "Work with MongoDB and document stores" },
                                new LearningObjective { Id = 385, StepId = 92, Description = "Learn Redis for caching" },
                                new LearningObjective { Id = 386, StepId = 92, Description = "Choose the right database for your needs" }
                            }
                        }
                    }
                },
                
                // .NET Core
                new Roadmap
                {
                    Id = 16,
                    Title = ".NET Core Developer",
                    Description = "Build modern cross-platform applications with .NET Core/.NET 6+",
                    Icon = "⚡",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "4-6 months",
                    Difficulty = "Intermediate to Advanced",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 93,
                            RoadmapId = 16,
                            Title = ".NET Core Fundamentals",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 387, StepId = 93, Description = "Understand .NET Core architecture" },
                                new LearningObjective { Id = 388, StepId = 93, Description = "Master CLI tools and project structure" },
                                new LearningObjective { Id = 389, StepId = 93, Description = "Learn dependency injection in .NET Core" },
                                new LearningObjective { Id = 390, StepId = 93, Description = "Work with configuration and environments" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 94,
                            RoadmapId = 16,
                            Title = "ASP.NET Core Web Development",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 391, StepId = 94, Description = "Build MVC applications" },
                                new LearningObjective { Id = 392, StepId = 94, Description = "Create RESTful Web APIs" },
                                new LearningObjective { Id = 393, StepId = 94, Description = "Implement authentication and authorization" },
                                new LearningObjective { Id = 394, StepId = 94, Description = "Master middleware and filters" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 95,
                            RoadmapId = 16,
                            Title = "Entity Framework Core",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 395, StepId = 95, Description = "Master Code First and migrations" },
                                new LearningObjective { Id = 396, StepId = 95, Description = "Implement repository pattern" },
                                new LearningObjective { Id = 397, StepId = 95, Description = "Optimize queries and performance" },
                                new LearningObjective { Id = 398, StepId = 95, Description = "Handle relationships and complex mappings" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 96,
                            RoadmapId = 16,
                            Title = "Microservices & Cloud-Ready Apps",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 399, StepId = 96, Description = "Build microservices architecture" },
                                new LearningObjective { Id = 400, StepId = 96, Description = "Implement gRPC and message queues" },
                                new LearningObjective { Id = 401, StepId = 96, Description = "Containerize with Docker" },
                                new LearningObjective { Id = 402, StepId = 96, Description = "Deploy to cloud platforms" }
                            }
                        }
                    }
                },
                
                // Git & Version Control
                new Roadmap
                {
                    Id = 25,
                    Title = "Git & Version Control",
                    Description = "Master version control systems and collaborative development workflows",
                    Icon = "🌿",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "2-3 months",
                    Difficulty = "Beginner to Advanced",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 166,
                            RoadmapId = 25,
                            Title = "Git Fundamentals",
                            Duration = "1-2 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 679, StepId = 166, Description = "Understand version control concepts and Git architecture" },
                                new LearningObjective { Id = 680, StepId = 166, Description = "Master basic Git commands: init, add, commit, status, log" },
                                new LearningObjective { Id = 681, StepId = 166, Description = "Configure Git settings and understand .gitignore" },
                                new LearningObjective { Id = 682, StepId = 166, Description = "Work with remote repositories: clone, push, pull, fetch" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 494, StepId = 166, Title = "Pro Git Book", Url = "https://git-scm.com/book", Type = "book" },
                                new Resource { Id = 495, StepId = 166, Title = "Git Tutorial by Atlassian", Url = "https://www.atlassian.com/git/tutorials", Type = "tutorial" },
                                new Resource { Id = 496, StepId = 166, Title = "Learn Git Branching", Url = "https://learngitbranching.js.org/", Type = "interactive" },
                                new Resource { Id = 497, StepId = 166, Title = "GitHub Skills", Url = "https://skills.github.com/", Type = "course" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 167,
                            RoadmapId = 25,
                            Title = "Branching and Merging Strategies",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 683, StepId = 167, Description = "Master branching commands: branch, checkout, merge" },
                                new LearningObjective { Id = 684, StepId = 167, Description = "Understand different branching strategies: Git Flow, GitHub Flow, GitLab Flow" },
                                new LearningObjective { Id = 685, StepId = 167, Description = "Resolve merge conflicts effectively" },
                                new LearningObjective { Id = 686, StepId = 167, Description = "Learn rebasing vs merging and when to use each" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 498, StepId = 167, Title = "Git Branching Strategies", Url = "https://www.flagship.io/git-branching-strategies/", Type = "article" },
                                new Resource { Id = 499, StepId = 167, Title = "Understanding Git Flow", Url = "https://www.youtube.com/watch?v=1SXpE08hvGs", Type = "video" },
                                new Resource { Id = 500, StepId = 167, Title = "Merge vs Rebase", Url = "https://www.atlassian.com/git/tutorials/merging-vs-rebasing", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 168,
                            RoadmapId = 25,
                            Title = "Collaborative Development Workflows",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 687, StepId = 168, Description = "Master pull requests and code review processes" },
                                new LearningObjective { Id = 688, StepId = 168, Description = "Understand forking workflow and contributing to open source" },
                                new LearningObjective { Id = 689, StepId = 168, Description = "Work with issues, project boards, and milestones" },
                                new LearningObjective { Id = 690, StepId = 168, Description = "Implement continuous integration with Git hooks" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 501, StepId = 168, Title = "GitHub Guides", Url = "https://guides.github.com/", Type = "documentation" },
                                new Resource { Id = 502, StepId = 168, Title = "Contributing to Open Source", Url = "https://opensource.guide/how-to-contribute/", Type = "guide" },
                                new Resource { Id = 503, StepId = 168, Title = "Code Review Best Practices", Url = "https://github.blog/2015-01-21-how-to-write-the-perfect-pull-request/", Type = "article" },
                                new Resource { Id = 504, StepId = 168, Title = "Git Hooks Tutorial", Url = "https://www.atlassian.com/git/tutorials/git-hooks", Type = "tutorial" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 169,
                            RoadmapId = 25,
                            Title = "Advanced Git Techniques",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 691, StepId = 169, Description = "Master interactive rebase and history rewriting" },
                                new LearningObjective { Id = 692, StepId = 169, Description = "Use cherry-pick, stash, and reflog effectively" },
                                new LearningObjective { Id = 693, StepId = 169, Description = "Understand Git internals: objects, refs, and packfiles" },
                                new LearningObjective { Id = 694, StepId = 169, Description = "Debug with bisect and blame" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 505, StepId = 169, Title = "Git Internals", Url = "https://git-scm.com/book/en/v2/Git-Internals-Plumbing-and-Porcelain", Type = "book" },
                                new Resource { Id = 506, StepId = 169, Title = "Advanced Git Tutorial", Url = "https://www.youtube.com/watch?v=qsTthZi23VE", Type = "video" },
                                new Resource { Id = 507, StepId = 169, Title = "Git Tips and Tricks", Url = "https://github.com/git-tips/tips", Type = "repository" },
                                new Resource { Id = 508, StepId = 169, Title = "Interactive Rebase Guide", Url = "https://thoughtbot.com/blog/git-interactive-rebase-squash-amend-rewriting-history", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 170,
                            RoadmapId = 25,
                            Title = "Git Best Practices and Workflows",
                            Duration = "1-2 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 695, StepId = 170, Description = "Write effective commit messages and maintain clean history" },
                                new LearningObjective { Id = 696, StepId = 170, Description = "Implement semantic versioning and release management" },
                                new LearningObjective { Id = 697, StepId = 170, Description = "Set up Git aliases and productivity tools" },
                                new LearningObjective { Id = 698, StepId = 170, Description = "Handle large files with Git LFS" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 509, StepId = 170, Title = "Conventional Commits", Url = "https://www.conventionalcommits.org/", Type = "specification" },
                                new Resource { Id = 510, StepId = 170, Title = "Git Best Practices", Url = "https://sethrobertson.github.io/GitBestPractices/", Type = "guide" },
                                new Resource { Id = 511, StepId = 170, Title = "Git LFS Tutorial", Url = "https://www.atlassian.com/git/tutorials/git-lfs", Type = "tutorial" },
                                new Resource { Id = 512, StepId = 170, Title = "Semantic Versioning", Url = "https://semver.org/", Type = "specification" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 171,
                            RoadmapId = 25,
                            Title = "Version Control for Teams",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 699, StepId = 171, Description = "Set up team workflows and branch protection rules" },
                                new LearningObjective { Id = 700, StepId = 171, Description = "Implement CI/CD integration with version control" },
                                new LearningObjective { Id = 701, StepId = 171, Description = "Manage mono-repos vs multi-repos strategies" },
                                new LearningObjective { Id = 702, StepId = 171, Description = "Handle security and access control" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 513, StepId = 171, Title = "GitHub Actions", Url = "https://docs.github.com/en/actions", Type = "documentation" },
                                new Resource { Id = 514, StepId = 171, Title = "GitLab CI/CD", Url = "https://docs.gitlab.com/ee/ci/", Type = "documentation" },
                                new Resource { Id = 515, StepId = 171, Title = "Monorepo vs Polyrepo", Url = "https://www.toptal.com/front-end/guide-to-monorepos", Type = "article" },
                                new Resource { Id = 516, StepId = 171, Title = "Git Security Best Practices", Url = "https://owasp.org/www-community/Source_Code_Analysis_Tools", Type = "guide" }
                            }
                        }
                    }
                },
                
                // Azure
                new Roadmap
                {
                    Id = 17,
                    Title = "Azure Cloud Developer",
                    Description = "Master Microsoft Azure for building scalable cloud solutions",
                    Icon = "☁️",
                    Category = CategoryConstants.DevOps,
                    Duration = "5-6 months",
                    Difficulty = "Intermediate to Advanced",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 97,
                            RoadmapId = 17,
                            Title = "Azure Fundamentals",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 403, StepId = 97, Description = "Understand Azure architecture and regions" },
                                new LearningObjective { Id = 404, StepId = 97, Description = "Master Azure Portal and CLI" },
                                new LearningObjective { Id = 405, StepId = 97, Description = "Learn resource groups and subscriptions" },
                                new LearningObjective { Id = 406, StepId = 97, Description = "Implement Azure Active Directory" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 98,
                            RoadmapId = 17,
                            Title = "Azure Compute Services",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 407, StepId = 98, Description = "Deploy and manage Virtual Machines" },
                                new LearningObjective { Id = 408, StepId = 98, Description = "Master App Services and Web Apps" },
                                new LearningObjective { Id = 409, StepId = 98, Description = "Implement Azure Functions" },
                                new LearningObjective { Id = 410, StepId = 98, Description = "Use Container Instances and AKS" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 99,
                            RoadmapId = 17,
                            Title = "Azure Data Services",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 411, StepId = 99, Description = "Master Azure SQL Database" },
                                new LearningObjective { Id = 412, StepId = 99, Description = "Implement Cosmos DB" },
                                new LearningObjective { Id = 413, StepId = 99, Description = "Use Azure Storage services" },
                                new LearningObjective { Id = 414, StepId = 99, Description = "Build data pipelines with Data Factory" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 100,
                            RoadmapId = 17,
                            Title = "Azure DevOps & Security",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 415, StepId = 100, Description = "Implement CI/CD with Azure DevOps" },
                                new LearningObjective { Id = 416, StepId = 100, Description = "Master Azure Key Vault" },
                                new LearningObjective { Id = 417, StepId = 100, Description = "Apply Azure Security Center" },
                                new LearningObjective { Id = 418, StepId = 100, Description = "Monitor with Application Insights" }
                            }
                        }
                    }
                },
                
                // Algorithms & Data Structures
                new Roadmap
                {
                    Id = 18,
                    Title = "Algorithms & Data Structures",
                    Description = "Master fundamental algorithms and data structures for efficient problem solving",
                    Icon = "🔢",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "4-6 months",
                    Difficulty = "Intermediate to Advanced",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 112,
                            RoadmapId = 18,
                            Title = "Basic Data Structures",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 463, StepId = 112, Description = "Master arrays, linked lists, and strings" },
                                new LearningObjective { Id = 464, StepId = 112, Description = "Implement stacks and queues" },
                                new LearningObjective { Id = 465, StepId = 112, Description = "Understand hash tables and sets" },
                                new LearningObjective { Id = 466, StepId = 112, Description = "Apply data structures to real problems" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 278, StepId = 112, Title = "Data Structures Visualization", Url = "https://visualgo.net/en", Type = "interactive" },
                                new Resource { Id = 279, StepId = 112, Title = "Introduction to Algorithms", Url = "https://mitpress.mit.edu/9780262046305/introduction-to-algorithms/", Type = "book" },
                                new Resource { Id = 280, StepId = 112, Title = "Data Structures Course", Url = "https://www.coursera.org/learn/data-structures", Type = "course" },
                                new Resource { Id = 281, StepId = 112, Title = "GeeksforGeeks Data Structures", Url = "https://www.geeksforgeeks.org/data-structures/", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 113,
                            RoadmapId = 18,
                            Title = "Trees and Graphs",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 467, StepId = 113, Description = "Master binary trees and BSTs" },
                                new LearningObjective { Id = 468, StepId = 113, Description = "Implement balanced trees (AVL, Red-Black)" },
                                new LearningObjective { Id = 469, StepId = 113, Description = "Understand graph representations and traversals" },
                                new LearningObjective { Id = 470, StepId = 113, Description = "Learn tries and segment trees" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 282, StepId = 113, Title = "Binary Tree Bootcamp", Url = "https://www.youtube.com/watch?v=fAAZixBzIAI", Type = "video" },
                                new Resource { Id = 283, StepId = 113, Title = "Graph Theory Tutorial", Url = "https://www.hackerearth.com/practice/algorithms/graphs/", Type = "website" },
                                new Resource { Id = 284, StepId = 113, Title = "Tree and Graph Algorithms", Url = "https://www.topcoder.com/thrive/articles/trees-and-graphs", Type = "article" },
                                new Resource { Id = 285, StepId = 113, Title = "Interactive Graph Algorithms", Url = "https://www.cs.usfca.edu/~galles/visualization/Algorithms.html", Type = "interactive" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 114,
                            RoadmapId = 18,
                            Title = "Sorting and Searching",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 471, StepId = 114, Description = "Master comparison-based sorting algorithms" },
                                new LearningObjective { Id = 472, StepId = 114, Description = "Learn non-comparison sorting (counting, radix)" },
                                new LearningObjective { Id = 473, StepId = 114, Description = "Implement binary search variations" },
                                new LearningObjective { Id = 474, StepId = 114, Description = "Understand algorithm complexity and stability" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 286, StepId = 114, Title = "Sorting Algorithms Visualized", Url = "https://www.toptal.com/developers/sorting-algorithms", Type = "interactive" },
                                new Resource { Id = 287, StepId = 114, Title = "Binary Search Deep Dive", Url = "https://www.topcoder.com/thrive/articles/Binary%20Search", Type = "article" },
                                new Resource { Id = 288, StepId = 114, Title = "Algorithms Part I", Url = "https://www.coursera.org/learn/algorithms-part1", Type = "course" },
                                new Resource { Id = 289, StepId = 114, Title = "The Algorithm Design Manual", Url = "https://www.algorist.com/", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 115,
                            RoadmapId = 18,
                            Title = "Dynamic Programming",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 475, StepId = 115, Description = "Understand memoization and tabulation" },
                                new LearningObjective { Id = 476, StepId = 115, Description = "Solve classic DP problems" },
                                new LearningObjective { Id = 477, StepId = 115, Description = "Master state space reduction" },
                                new LearningObjective { Id = 478, StepId = 115, Description = "Apply DP to optimization problems" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 290, StepId = 115, Title = "Dynamic Programming Patterns", Url = "https://leetcode.com/discuss/study-guide/458695/dynamic-programming-patterns", Type = "article" },
                                new Resource { Id = 291, StepId = 115, Title = "DP Video Series", Url = "https://www.youtube.com/playlist?list=PLVrpF4r7WIhTT1hJqZmjP10nxsmrbRvlf", Type = "video" },
                                new Resource { Id = 292, StepId = 115, Title = "Competitive Programming 3", Url = "https://cpbook.net/", Type = "book" },
                                new Resource { Id = 293, StepId = 115, Title = "DP Practice Problems", Url = "https://atcoder.jp/contests/dp/tasks", Type = "interactive" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 116,
                            RoadmapId = 18,
                            Title = "Graph Algorithms",
                            Duration = "4-5 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 479, StepId = 116, Description = "Master shortest path algorithms (Dijkstra, Bellman-Ford)" },
                                new LearningObjective { Id = 480, StepId = 116, Description = "Learn minimum spanning tree algorithms" },
                                new LearningObjective { Id = 481, StepId = 116, Description = "Implement network flow algorithms" },
                                new LearningObjective { Id = 482, StepId = 116, Description = "Understand topological sorting and SCCs" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 294, StepId = 116, Title = "Graph Algorithms Visualization", Url = "https://www.cs.usfca.edu/~galles/visualization/Dijkstra.html", Type = "interactive" },
                                new Resource { Id = 295, StepId = 116, Title = "Network Flows", Url = "https://www.topcoder.com/thrive/articles/maximum-flow-section-1", Type = "article" },
                                new Resource { Id = 296, StepId = 116, Title = "Algorithms on Graphs", Url = "https://www.coursera.org/learn/algorithms-graphs-data-structures", Type = "course" },
                                new Resource { Id = 297, StepId = 116, Title = "CLRS Graph Algorithms", Url = "https://mitpress.mit.edu/9780262046305/introduction-to-algorithms/", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 117,
                            RoadmapId = 18,
                            Title = "Advanced Data Structures",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 483, StepId = 117, Description = "Master heaps and priority queues" },
                                new LearningObjective { Id = 484, StepId = 117, Description = "Implement disjoint set union (DSU)" },
                                new LearningObjective { Id = 485, StepId = 117, Description = "Learn Fenwick trees and segment trees" },
                                new LearningObjective { Id = 486, StepId = 117, Description = "Understand persistent data structures" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 298, StepId = 117, Title = "Advanced Data Structures", Url = "https://courses.csail.mit.edu/6.851/fall17/", Type = "course" },
                                new Resource { Id = 299, StepId = 117, Title = "Fenwick Tree Tutorial", Url = "https://www.topcoder.com/thrive/articles/Binary%20Indexed%20Trees", Type = "article" },
                                new Resource { Id = 300, StepId = 117, Title = "CP Algorithms", Url = "https://cp-algorithms.com/", Type = "website" },
                                new Resource { Id = 301, StepId = 117, Title = "Data Structures for Competitive Programming", Url = "https://www.youtube.com/playlist?list=PLUl4u3cNGP63EdVPNLG3ToM6LaEUuStEY", Type = "video" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 118,
                            RoadmapId = 18,
                            Title = "String Algorithms",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 487, StepId = 118, Description = "Master pattern matching algorithms (KMP, Rabin-Karp)" },
                                new LearningObjective { Id = 488, StepId = 118, Description = "Learn suffix arrays and suffix trees" },
                                new LearningObjective { Id = 489, StepId = 118, Description = "Implement string hashing techniques" },
                                new LearningObjective { Id = 490, StepId = 118, Description = "Solve advanced string problems" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 302, StepId = 118, Title = "String Algorithms", Url = "https://www.geeksforgeeks.org/string-data-structure/", Type = "article" },
                                new Resource { Id = 303, StepId = 118, Title = "KMP Algorithm Explained", Url = "https://www.youtube.com/watch?v=V5-7GzOfADQ", Type = "video" },
                                new Resource { Id = 304, StepId = 118, Title = "Suffix Arrays Tutorial", Url = "https://www.hackerrank.com/topics/suffix-array", Type = "article" },
                                new Resource { Id = 305, StepId = 118, Title = "Algorithms on Strings", Url = "https://www.coursera.org/learn/algorithms-on-strings", Type = "course" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 119,
                            RoadmapId = 18,
                            Title = "Computational Geometry",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 491, StepId = 119, Description = "Understand geometric primitives" },
                                new LearningObjective { Id = 492, StepId = 119, Description = "Implement convex hull algorithms" },
                                new LearningObjective { Id = 493, StepId = 119, Description = "Learn line intersection and sweep line" },
                                new LearningObjective { Id = 494, StepId = 119, Description = "Solve computational geometry problems" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 306, StepId = 119, Title = "Computational Geometry", Url = "https://www.cs.princeton.edu/~rs/AlgsDS07/", Type = "course" },
                                new Resource { Id = 307, StepId = 119, Title = "Convex Hull Visualization", Url = "https://algorithmtutor.com/Computational-Geometry/Convex-Hull-Algorithms-Jarvis-s-March/", Type = "interactive" },
                                new Resource { Id = 308, StepId = 119, Title = "Geometry for Competitive Programming", Url = "https://vlecomte.github.io/cp-geo.pdf", Type = "article" },
                                new Resource { Id = 309, StepId = 119, Title = "Computational Geometry in C++", Url = "https://www.amazon.com/Computational-Geometry-Applications-Joseph-ORourke/dp/0521649765", Type = "book" }
                            }
                        }
                    }
                },
                
                // Problem Solving & Coding Interviews
                new Roadmap
                {
                    Id = 19,
                    Title = "Problem Solving & Coding Interviews",
                    Description = "Master problem-solving techniques and ace technical interviews",
                    Icon = "💡",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate to Advanced",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 120,
                            RoadmapId = 19,
                            Title = "Problem-Solving Fundamentals",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 495, StepId = 120, Description = "Master problem analysis and understanding" },
                                new LearningObjective { Id = 496, StepId = 120, Description = "Learn to break down complex problems" },
                                new LearningObjective { Id = 497, StepId = 120, Description = "Develop algorithmic thinking" },
                                new LearningObjective { Id = 498, StepId = 120, Description = "Practice time and space complexity analysis" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 310, StepId = 120, Title = "How to Solve It", Url = "https://www.amazon.com/How-Solve-Mathematical-Princeton-Science/dp/069116407X", Type = "book" },
                                new Resource { Id = 311, StepId = 120, Title = "Problem Solving Techniques", Url = "https://www.coursera.org/learn/algorithmic-thinking-1", Type = "course" },
                                new Resource { Id = 312, StepId = 120, Title = "Big O Notation", Url = "https://www.youtube.com/watch?v=v4cd1O4zkGw", Type = "video" },
                                new Resource { Id = 313, StepId = 120, Title = "Competitive Programming Handbook", Url = "https://cses.fi/book/book.pdf", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 121,
                            RoadmapId = 19,
                            Title = "Interview Problem Patterns",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 499, StepId = 121, Description = "Master two-pointer and sliding window" },
                                new LearningObjective { Id = 500, StepId = 121, Description = "Learn fast and slow pointer patterns" },
                                new LearningObjective { Id = 501, StepId = 121, Description = "Understand merge intervals pattern" },
                                new LearningObjective { Id = 502, StepId = 121, Description = "Apply pattern recognition to new problems" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 314, StepId = 121, Title = "14 Patterns to Ace Any Coding Interview", Url = "https://hackernoon.com/14-patterns-to-ace-any-coding-interview-question-c5bb3357f6ed", Type = "article" },
                                new Resource { Id = 315, StepId = 121, Title = "Grokking the Coding Interview", Url = "https://www.educative.io/courses/grokking-the-coding-interview", Type = "course" },
                                new Resource { Id = 316, StepId = 121, Title = "LeetCode Patterns", Url = "https://github.com/seanprashad/leetcode-patterns", Type = "website" },
                                new Resource { Id = 317, StepId = 121, Title = "Coding Interview Patterns", Url = "https://www.youtube.com/playlist?list=PLot-Xpze53leU0Ec0VkBhnf4npMRFiNcB", Type = "video" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 122,
                            RoadmapId = 19,
                            Title = "Data Structure Problems",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 503, StepId = 122, Description = "Solve array and string manipulation problems" },
                                new LearningObjective { Id = 504, StepId = 122, Description = "Master linked list problems" },
                                new LearningObjective { Id = 505, StepId = 122, Description = "Practice tree and graph problems" },
                                new LearningObjective { Id = 506, StepId = 122, Description = "Tackle stack and queue challenges" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 318, StepId = 122, Title = "LeetCode Top Interview Questions", Url = "https://leetcode.com/problem-list/top-interview-questions/", Type = "interactive" },
                                new Resource { Id = 319, StepId = 122, Title = "Cracking the Coding Interview", Url = "https://www.crackingthecodinginterview.com/", Type = "book" },
                                new Resource { Id = 320, StepId = 122, Title = "Elements of Programming Interviews", Url = "https://elementsofprogramminginterviews.com/", Type = "book" },
                                new Resource { Id = 321, StepId = 122, Title = "Data Structure Interview Questions", Url = "https://www.interviewbit.com/data-structure-interview-questions/", Type = "website" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 123,
                            RoadmapId = 19,
                            Title = "Algorithm Problems",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 507, StepId = 123, Description = "Solve sorting and searching problems" },
                                new LearningObjective { Id = 508, StepId = 123, Description = "Master recursion and backtracking" },
                                new LearningObjective { Id = 509, StepId = 123, Description = "Practice dynamic programming problems" },
                                new LearningObjective { Id = 510, StepId = 123, Description = "Tackle greedy algorithm challenges" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 322, StepId = 123, Title = "Algorithm Interview Questions", Url = "https://www.techinterviewhandbook.org/algorithms/introduction/", Type = "article" },
                                new Resource { Id = 323, StepId = 123, Title = "Back to Back SWE", Url = "https://backtobackswe.com/", Type = "video" },
                                new Resource { Id = 324, StepId = 123, Title = "AlgoExpert", Url = "https://www.algoexpert.io/", Type = "interactive" },
                                new Resource { Id = 325, StepId = 123, Title = "Daily Coding Problem", Url = "https://www.dailycodingproblem.com/", Type = "website" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 124,
                            RoadmapId = 19,
                            Title = "System Design Basics",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 511, StepId = 124, Description = "Understand scalability concepts" },
                                new LearningObjective { Id = 512, StepId = 124, Description = "Learn about load balancing and caching" },
                                new LearningObjective { Id = 513, StepId = 124, Description = "Master database design basics" },
                                new LearningObjective { Id = 514, StepId = 124, Description = "Practice designing simple systems" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 326, StepId = 124, Title = "System Design Primer", Url = "https://github.com/donnemartin/system-design-primer", Type = "website" },
                                new Resource { Id = 327, StepId = 124, Title = "Grokking the System Design Interview", Url = "https://www.educative.io/courses/grokking-the-system-design-interview", Type = "course" },
                                new Resource { Id = 328, StepId = 124, Title = "System Design Interview", Url = "https://www.youtube.com/c/SystemDesignInterview", Type = "video" },
                                new Resource { Id = 329, StepId = 124, Title = "Designing Data-Intensive Applications", Url = "https://dataintensive.net/", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 125,
                            RoadmapId = 19,
                            Title = "Behavioral Interview Preparation",
                            Duration = "2 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 515, StepId = 125, Description = "Master the STAR method" },
                                new LearningObjective { Id = 516, StepId = 125, Description = "Prepare compelling project stories" },
                                new LearningObjective { Id = 517, StepId = 125, Description = "Practice common behavioral questions" },
                                new LearningObjective { Id = 518, StepId = 125, Description = "Develop strong communication skills" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 330, StepId = 125, Title = "Behavioral Interview Guide", Url = "https://www.techinterviewhandbook.org/behavioral-interview/", Type = "article" },
                                new Resource { Id = 331, StepId = 125, Title = "STAR Method Explained", Url = "https://www.youtube.com/watch?v=0nN7Q7DrI6Q", Type = "video" },
                                new Resource { Id = 332, StepId = 125, Title = "Decode and Conquer", Url = "https://www.lewis-lin.com/decode-and-conquer", Type = "book" },
                                new Resource { Id = 333, StepId = 125, Title = "Pramp - Mock Interviews", Url = "https://www.pramp.com/", Type = "interactive" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 126,
                            RoadmapId = 19,
                            Title = "Mock Interviews & Practice",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 519, StepId = 126, Description = "Complete timed coding challenges" },
                                new LearningObjective { Id = 520, StepId = 126, Description = "Practice whiteboard coding" },
                                new LearningObjective { Id = 521, StepId = 126, Description = "Do mock interviews with peers" },
                                new LearningObjective { Id = 522, StepId = 126, Description = "Review and learn from mistakes" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 334, StepId = 126, Title = "Interviewing.io", Url = "https://interviewing.io/", Type = "interactive" },
                                new Resource { Id = 335, StepId = 126, Title = "LeetCode Contests", Url = "https://leetcode.com/contest/", Type = "interactive" },
                                new Resource { Id = 336, StepId = 126, Title = "CodeSignal", Url = "https://codesignal.com/", Type = "website" },
                                new Resource { Id = 337, StepId = 126, Title = "Interview Cake", Url = "https://www.interviewcake.com/", Type = "course" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 127,
                            RoadmapId = 19,
                            Title = "Interview Day Strategy",
                            Duration = "1 week",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 523, StepId = 127, Description = "Develop interview day routine" },
                                new LearningObjective { Id = 524, StepId = 127, Description = "Master problem clarification techniques" },
                                new LearningObjective { Id = 525, StepId = 127, Description = "Learn to think aloud effectively" },
                                new LearningObjective { Id = 526, StepId = 127, Description = "Handle pressure and mistakes gracefully" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 338, StepId = 127, Title = "Interview Tips and Tricks", Url = "https://www.techinterviewhandbook.org/during-interview/", Type = "article" },
                                new Resource { Id = 339, StepId = 127, Title = "How to Ace the Coding Interview", Url = "https://www.youtube.com/watch?v=SVvr3ZjtjI8", Type = "video" },
                                new Resource { Id = 340, StepId = 127, Title = "Programming Interviews Exposed", Url = "https://www.wiley.com/en-us/Programming+Interviews+Exposed%3A+Coding+Your+Way+Through+the+Interview%2C+4th+Edition-p-9781119418474", Type = "book" },
                                new Resource { Id = 341, StepId = 127, Title = "Interview Success Checklist", Url = "https://www.teamblind.com/post/Interview-Success-Checklist-4wY6Z8vK", Type = "article" }
                            }
                        }
                    }
                },
                
                // Unit Testing & TDD
                new Roadmap
                {
                    Id = 20,
                    Title = "Unit Testing & TDD",
                    Description = "Master unit testing and test-driven development for robust software",
                    Icon = "🧪",
                    Category = CategoryConstants.Testing,
                    Duration = "2-3 months",
                    Difficulty = "Intermediate",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 128,
                            RoadmapId = 20,
                            Title = "Unit Testing Fundamentals",
                            Duration = "2 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 527, StepId = 128, Description = "Understand unit testing principles" },
                                new LearningObjective { Id = 528, StepId = 128, Description = "Learn test structure (AAA pattern)" },
                                new LearningObjective { Id = 529, StepId = 128, Description = "Write your first unit tests" },
                                new LearningObjective { Id = 530, StepId = 128, Description = "Understand test isolation and independence" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 342, StepId = 128, Title = "Unit Testing Principles", Url = "https://www.amazon.com/Unit-Testing-Principles-Practices-Patterns/dp/1617296279", Type = "book" },
                                new Resource { Id = 343, StepId = 128, Title = "Introduction to Unit Testing", Url = "https://www.youtube.com/watch?v=--OJtTWkKuE", Type = "video" },
                                new Resource { Id = 344, StepId = 128, Title = "Unit Testing Best Practices", Url = "https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices", Type = "article" },
                                new Resource { Id = 345, StepId = 128, Title = "xUnit Tutorial", Url = "https://xunit.net/docs/getting-started/netcore/cmdline", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 129,
                            RoadmapId = 20,
                            Title = "Testing Frameworks and Tools",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 531, StepId = 129, Description = "Master popular testing frameworks (xUnit, NUnit, MSTest)" },
                                new LearningObjective { Id = 532, StepId = 129, Description = "Learn assertion libraries and matchers" },
                                new LearningObjective { Id = 533, StepId = 129, Description = "Use test runners and explorers" },
                                new LearningObjective { Id = 534, StepId = 129, Description = "Configure continuous testing" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 346, StepId = 129, Title = "xUnit vs NUnit vs MSTest", Url = "https://www.lambdatest.com/blog/nunit-vs-xunit-vs-mstest/", Type = "article" },
                                new Resource { Id = 347, StepId = 129, Title = "Fluent Assertions", Url = "https://fluentassertions.com/", Type = "documentation" },
                                new Resource { Id = 348, StepId = 129, Title = "Testing Framework Comparison", Url = "https://www.youtube.com/watch?v=t6Uw8THJWR0", Type = "video" },
                                new Resource { Id = 349, StepId = 129, Title = "NCrunch for Continuous Testing", Url = "https://www.ncrunch.net/", Type = "website" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 130,
                            RoadmapId = 20,
                            Title = "Test-Driven Development (TDD)",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 535, StepId = 130, Description = "Master the Red-Green-Refactor cycle" },
                                new LearningObjective { Id = 536, StepId = 130, Description = "Write tests before implementation" },
                                new LearningObjective { Id = 537, StepId = 130, Description = "Practice TDD katas" },
                                new LearningObjective { Id = 538, StepId = 130, Description = "Apply TDD to real projects" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 350, StepId = 130, Title = "Test Driven Development: By Example", Url = "https://www.amazon.com/Test-Driven-Development-Kent-Beck/dp/0321146530", Type = "book" },
                                new Resource { Id = 351, StepId = 130, Title = "TDD Course", Url = "https://www.pluralsight.com/courses/test-driven-development-big-picture", Type = "course" },
                                new Resource { Id = 352, StepId = 130, Title = "TDD Kata Exercises", Url = "https://kata-log.rocks/", Type = "interactive" },
                                new Resource { Id = 353, StepId = 130, Title = "TDD in Practice", Url = "https://www.youtube.com/watch?v=qkblc5WRn-U", Type = "video" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 131,
                            RoadmapId = 20,
                            Title = "Mocking and Test Doubles",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 539, StepId = 131, Description = "Understand test doubles (mocks, stubs, fakes)" },
                                new LearningObjective { Id = 540, StepId = 131, Description = "Master mocking frameworks (Moq, NSubstitute)" },
                                new LearningObjective { Id = 541, StepId = 131, Description = "Mock external dependencies" },
                                new LearningObjective { Id = 542, StepId = 131, Description = "Verify interactions and behaviors" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 354, StepId = 131, Title = "Mocks Aren't Stubs", Url = "https://martinfowler.com/articles/mocksArentStubs.html", Type = "article" },
                                new Resource { Id = 355, StepId = 131, Title = "Moq Quick Start", Url = "https://github.com/moq/moq4/wiki/Quickstart", Type = "documentation" },
                                new Resource { Id = 356, StepId = 131, Title = "Mocking Explained", Url = "https://www.youtube.com/watch?v=DJDsEH2JaLw", Type = "video" },
                                new Resource { Id = 357, StepId = 131, Title = "Art of Unit Testing", Url = "https://www.manning.com/books/the-art-of-unit-testing-second-edition", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 132,
                            RoadmapId = 20,
                            Title = "Code Coverage and Quality Metrics",
                            Duration = "1-2 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 543, StepId = 132, Description = "Understand code coverage metrics" },
                                new LearningObjective { Id = 544, StepId = 132, Description = "Use coverage tools effectively" },
                                new LearningObjective { Id = 545, StepId = 132, Description = "Balance coverage with test quality" },
                                new LearningObjective { Id = 546, StepId = 132, Description = "Implement mutation testing" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 358, StepId = 132, Title = "Code Coverage Best Practices", Url = "https://www.atlassian.com/continuous-delivery/software-testing/code-coverage", Type = "article" },
                                new Resource { Id = 359, StepId = 132, Title = "Coverlet for .NET", Url = "https://github.com/coverlet-coverage/coverlet", Type = "documentation" },
                                new Resource { Id = 360, StepId = 132, Title = "Mutation Testing", Url = "https://stryker-mutator.io/", Type = "website" },
                                new Resource { Id = 361, StepId = 132, Title = "Test Coverage Myths", Url = "https://www.youtube.com/watch?v=HzvQl5bGH8k", Type = "video" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 133,
                            RoadmapId = 20,
                            Title = "Testing Best Practices",
                            Duration = "2 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 547, StepId = 133, Description = "Write maintainable test code" },
                                new LearningObjective { Id = 548, StepId = 133, Description = "Apply test naming conventions" },
                                new LearningObjective { Id = 549, StepId = 133, Description = "Organize test projects effectively" },
                                new LearningObjective { Id = 550, StepId = 133, Description = "Handle test data and fixtures" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 362, StepId = 133, Title = "Unit Testing Guidelines", Url = "https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices", Type = "article" },
                                new Resource { Id = 363, StepId = 133, Title = "Test Naming Conventions", Url = "https://osherove.com/blog/2005/4/3/naming-standards-for-unit-tests.html", Type = "article" },
                                new Resource { Id = 364, StepId = 133, Title = "Clean Unit Tests", Url = "https://www.youtube.com/watch?v=ub5bWY9F3YE", Type = "video" },
                                new Resource { Id = 365, StepId = 133, Title = "Growing Object-Oriented Software", Url = "http://www.growing-object-oriented-software.com/", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 134,
                            RoadmapId = 20,
                            Title = "Advanced Testing Techniques",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 551, StepId = 134, Description = "Implement parameterized tests" },
                                new LearningObjective { Id = 552, StepId = 134, Description = "Use theory-based testing" },
                                new LearningObjective { Id = 553, StepId = 134, Description = "Apply property-based testing" },
                                new LearningObjective { Id = 554, StepId = 134, Description = "Test async and concurrent code" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 366, StepId = 134, Title = "Parameterized Tests in xUnit", Url = "https://andrewlock.net/creating-parameterised-tests-in-xunit-with-inlinedata-classdata-and-memberdata/", Type = "article" },
                                new Resource { Id = 367, StepId = 134, Title = "Property-Based Testing", Url = "https://fscheck.github.io/FsCheck/", Type = "documentation" },
                                new Resource { Id = 368, StepId = 134, Title = "Testing Async Code", Url = "https://www.youtube.com/watch?v=Krex8aAgNHw", Type = "video" },
                                new Resource { Id = 369, StepId = 134, Title = "Advanced Unit Testing", Url = "https://www.pluralsight.com/courses/advanced-unit-testing", Type = "course" }
                            }
                        }
                    }
                },
                
                // Integration & API Testing
                new Roadmap
                {
                    Id = 21,
                    Title = "Integration & API Testing",
                    Description = "Master integration testing and API testing strategies",
                    Icon = "🔗",
                    Category = CategoryConstants.Testing,
                    Duration = "2-3 months",
                    Difficulty = "Intermediate to Advanced",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 135,
                            RoadmapId = 21,
                            Title = "Integration Testing Fundamentals",
                            Duration = "2 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 555, StepId = 135, Description = "Understand integration testing concepts" },
                                new LearningObjective { Id = 556, StepId = 135, Description = "Differentiate from unit testing" },
                                new LearningObjective { Id = 557, StepId = 135, Description = "Design integration test strategies" },
                                new LearningObjective { Id = 558, StepId = 135, Description = "Set up test environments" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 370, StepId = 135, Title = "Integration Testing Guide", Url = "https://martinfowler.com/bliki/IntegrationTest.html", Type = "article" },
                                new Resource { Id = 371, StepId = 135, Title = "Integration vs Unit Testing", Url = "https://www.youtube.com/watch?v=0GypdsJulKE", Type = "video" },
                                new Resource { Id = 372, StepId = 135, Title = "ASP.NET Core Integration Tests", Url = "https://docs.microsoft.com/en-us/aspnet/core/test/integration-tests", Type = "documentation" },
                                new Resource { Id = 373, StepId = 135, Title = "Testing Microservices", Url = "https://www.oreilly.com/library/view/testing-microservices/9781492073543/", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 136,
                            RoadmapId = 21,
                            Title = "API Testing Basics",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 559, StepId = 136, Description = "Master REST API testing" },
                                new LearningObjective { Id = 560, StepId = 136, Description = "Use Postman and similar tools" },
                                new LearningObjective { Id = 561, StepId = 136, Description = "Test HTTP methods and status codes" },
                                new LearningObjective { Id = 562, StepId = 136, Description = "Validate request/response structures" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 374, StepId = 136, Title = "REST API Testing", Url = "https://restfulapi.net/rest-api-test-tools/", Type = "article" },
                                new Resource { Id = 375, StepId = 136, Title = "Postman Tutorial", Url = "https://www.postman.com/postman/workspace/postman-answers/documentation/9115166-c7b2c162-1bf5-47a4-b792-be2038dc5f2e", Type = "documentation" },
                                new Resource { Id = 376, StepId = 136, Title = "API Testing Course", Url = "https://www.udemy.com/course/rest-api-testing-automation/", Type = "course" },
                                new Resource { Id = 377, StepId = 136, Title = "Newman CLI", Url = "https://learning.postman.com/docs/running-collections/using-newman-cli/command-line-integration-with-newman/", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 137,
                            RoadmapId = 21,
                            Title = "Test Automation Frameworks",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 563, StepId = 137, Description = "Implement REST Assured or RestSharp" },
                                new LearningObjective { Id = 564, StepId = 137, Description = "Build automated API test suites" },
                                new LearningObjective { Id = 565, StepId = 137, Description = "Create data-driven tests" },
                                new LearningObjective { Id = 566, StepId = 137, Description = "Integrate with CI/CD pipelines" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 378, StepId = 137, Title = "RestSharp Documentation", Url = "https://restsharp.dev/", Type = "documentation" },
                                new Resource { Id = 379, StepId = 137, Title = "API Test Automation", Url = "https://www.youtube.com/watch?v=7lQC_q67dAc", Type = "video" },
                                new Resource { Id = 380, StepId = 137, Title = "REST API Testing with C#", Url = "https://www.toolsqa.com/rest-assured/rest-api-test-using-rest-assured/", Type = "article" },
                                new Resource { Id = 381, StepId = 137, Title = "Karate Framework", Url = "https://karatelabs.github.io/karate/", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 138,
                            RoadmapId = 21,
                            Title = "Database Integration Testing",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 567, StepId = 138, Description = "Test database operations" },
                                new LearningObjective { Id = 568, StepId = 138, Description = "Use in-memory databases" },
                                new LearningObjective { Id = 569, StepId = 138, Description = "Implement test data management" },
                                new LearningObjective { Id = 570, StepId = 138, Description = "Handle transaction rollbacks" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 382, StepId = 138, Title = "EF Core Testing", Url = "https://docs.microsoft.com/en-us/ef/core/testing/", Type = "documentation" },
                                new Resource { Id = 383, StepId = 138, Title = "Database Testing Strategies", Url = "https://www.youtube.com/watch?v=9_x6OkiOm7E", Type = "video" },
                                new Resource { Id = 384, StepId = 138, Title = "Testcontainers", Url = "https://www.testcontainers.org/", Type = "website" },
                                new Resource { Id = 385, StepId = 138, Title = "Respawn", Url = "https://github.com/jbogard/Respawn", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 139,
                            RoadmapId = 21,
                            Title = "Contract Testing",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 571, StepId = 139, Description = "Understand consumer-driven contracts" },
                                new LearningObjective { Id = 572, StepId = 139, Description = "Implement Pact testing" },
                                new LearningObjective { Id = 573, StepId = 139, Description = "Test API versioning" },
                                new LearningObjective { Id = 574, StepId = 139, Description = "Validate schema compliance" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 386, StepId = 139, Title = "Consumer-Driven Contracts", Url = "https://martinfowler.com/articles/consumerDrivenContracts.html", Type = "article" },
                                new Resource { Id = 387, StepId = 139, Title = "Pact Documentation", Url = "https://docs.pact.io/", Type = "documentation" },
                                new Resource { Id = 388, StepId = 139, Title = "Contract Testing Explained", Url = "https://www.youtube.com/watch?v=h-79QmIV824", Type = "video" },
                                new Resource { Id = 389, StepId = 139, Title = "API Schema Validation", Url = "https://json-schema.org/learn/getting-started-step-by-step", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 140,
                            RoadmapId = 21,
                            Title = "Performance and Load Testing",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 575, StepId = 140, Description = "Design performance test scenarios" },
                                new LearningObjective { Id = 576, StepId = 140, Description = "Use JMeter or K6" },
                                new LearningObjective { Id = 577, StepId = 140, Description = "Analyze performance metrics" },
                                new LearningObjective { Id = 578, StepId = 140, Description = "Identify bottlenecks" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 390, StepId = 140, Title = "K6 Documentation", Url = "https://k6.io/docs/", Type = "documentation" },
                                new Resource { Id = 391, StepId = 140, Title = "JMeter Tutorial", Url = "https://jmeter.apache.org/usermanual/get-started.html", Type = "documentation" },
                                new Resource { Id = 392, StepId = 140, Title = "Load Testing Best Practices", Url = "https://www.youtube.com/watch?v=r-Jte8Y8zag", Type = "video" },
                                new Resource { Id = 393, StepId = 140, Title = "NBomber", Url = "https://nbomber.com/", Type = "website" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 141,
                            RoadmapId = 21,
                            Title = "Security Testing",
                            Duration = "2 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 579, StepId = 141, Description = "Test authentication and authorization" },
                                new LearningObjective { Id = 580, StepId = 141, Description = "Validate input sanitization" },
                                new LearningObjective { Id = 581, StepId = 141, Description = "Check for common vulnerabilities" },
                                new LearningObjective { Id = 582, StepId = 141, Description = "Implement OWASP guidelines" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 394, StepId = 141, Title = "OWASP Testing Guide", Url = "https://owasp.org/www-project-web-security-testing-guide/", Type = "documentation" },
                                new Resource { Id = 395, StepId = 141, Title = "API Security Testing", Url = "https://www.youtube.com/watch?v=Pi2KxMW8ELo", Type = "video" },
                                new Resource { Id = 396, StepId = 141, Title = "ZAP Security Scanner", Url = "https://www.zaproxy.org/", Type = "website" },
                                new Resource { Id = 397, StepId = 141, Title = "Burp Suite", Url = "https://portswigger.net/burp", Type = "website" }
                            }
                        }
                    }
                },
                
                // Software Architecture Patterns
                new Roadmap
                {
                    Id = 22,
                    Title = "Software Architecture Patterns",
                    Description = "Master architectural patterns for building scalable and maintainable systems",
                    Icon = "🏛️",
                    Category = CategoryConstants.Architecture,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 142,
                            RoadmapId = 22,
                            Title = "Architecture Fundamentals",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 583, StepId = 142, Description = "Understand architectural thinking" },
                                new LearningObjective { Id = 584, StepId = 142, Description = "Learn quality attributes" },
                                new LearningObjective { Id = 585, StepId = 142, Description = "Master architectural trade-offs" },
                                new LearningObjective { Id = 586, StepId = 142, Description = "Create architectural diagrams" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 398, StepId = 142, Title = "Software Architecture in Practice", Url = "https://www.amazon.com/Software-Architecture-Practice-3rd-Engineering/dp/0321815734", Type = "book" },
                                new Resource { Id = 399, StepId = 142, Title = "Architecture Documentation", Url = "https://c4model.com/", Type = "website" },
                                new Resource { Id = 400, StepId = 142, Title = "Architectural Thinking", Url = "https://www.youtube.com/watch?v=rrJlOCaFiDg", Type = "video" },
                                new Resource { Id = 401, StepId = 142, Title = "Quality Attributes", Url = "https://www.sei.cmu.edu/our-work/quality-attributes/", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 143,
                            RoadmapId = 22,
                            Title = "Layered Architecture",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 587, StepId = 143, Description = "Master N-tier architecture" },
                                new LearningObjective { Id = 588, StepId = 143, Description = "Implement presentation, business, and data layers" },
                                new LearningObjective { Id = 589, StepId = 143, Description = "Handle cross-cutting concerns" },
                                new LearningObjective { Id = 590, StepId = 143, Description = "Apply layering best practices" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 402, StepId = 143, Title = "Layered Architecture Pattern", Url = "https://www.oreilly.com/library/view/software-architecture-patterns/9781491971437/ch01.html", Type = "article" },
                                new Resource { Id = 403, StepId = 143, Title = "N-Tier Architecture", Url = "https://docs.microsoft.com/en-us/azure/architecture/guide/architecture-styles/n-tier", Type = "documentation" },
                                new Resource { Id = 404, StepId = 143, Title = "Layered Architecture Example", Url = "https://github.com/ardalis/CleanArchitecture", Type = "website" },
                                new Resource { Id = 405, StepId = 143, Title = "Cross-Cutting Concerns", Url = "https://www.youtube.com/watch?v=psrp3TtaYYI", Type = "video" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 144,
                            RoadmapId = 22,
                            Title = "Hexagonal Architecture",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 591, StepId = 144, Description = "Understand Ports and Adapters pattern" },
                                new LearningObjective { Id = 592, StepId = 144, Description = "Implement domain-centric design" },
                                new LearningObjective { Id = 593, StepId = 144, Description = "Create testable architectures" },
                                new LearningObjective { Id = 594, StepId = 144, Description = "Apply dependency inversion" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 406, StepId = 144, Title = "Hexagonal Architecture", Url = "https://alistair.cockburn.us/hexagonal-architecture/", Type = "article" },
                                new Resource { Id = 407, StepId = 144, Title = "Ports and Adapters Example", Url = "https://github.com/Sairyss/domain-driven-hexagon", Type = "website" },
                                new Resource { Id = 408, StepId = 144, Title = "Hexagonal Architecture in .NET", Url = "https://www.youtube.com/watch?v=diTiw5yw3T8", Type = "video" },
                                new Resource { Id = 409, StepId = 144, Title = "Get Your Hands Dirty on Clean Architecture", Url = "https://reflectoring.io/book/", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 145,
                            RoadmapId = 22,
                            Title = "Event-Driven Architecture",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 595, StepId = 145, Description = "Master event-driven patterns" },
                                new LearningObjective { Id = 596, StepId = 145, Description = "Implement event sourcing" },
                                new LearningObjective { Id = 597, StepId = 145, Description = "Use message brokers effectively" },
                                new LearningObjective { Id = 598, StepId = 145, Description = "Handle eventual consistency" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 410, StepId = 145, Title = "Event-Driven Architecture", Url = "https://martinfowler.com/articles/201701-event-driven.html", Type = "article" },
                                new Resource { Id = 411, StepId = 145, Title = "Event Sourcing", Url = "https://eventstore.com/event-sourcing/", Type = "website" },
                                new Resource { Id = 412, StepId = 145, Title = "Building Event-Driven Microservices", Url = "https://www.oreilly.com/library/view/building-event-driven-microservices/9781492057888/", Type = "book" },
                                new Resource { Id = 413, StepId = 145, Title = "Apache Kafka", Url = "https://kafka.apache.org/intro", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 146,
                            RoadmapId = 22,
                            Title = "CQRS Pattern",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 599, StepId = 146, Description = "Separate commands and queries" },
                                new LearningObjective { Id = 600, StepId = 146, Description = "Implement read and write models" },
                                new LearningObjective { Id = 601, StepId = 146, Description = "Apply CQRS with Event Sourcing" },
                                new LearningObjective { Id = 602, StepId = 146, Description = "Handle data synchronization" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 414, StepId = 146, Title = "CQRS Pattern", Url = "https://martinfowler.com/bliki/CQRS.html", Type = "article" },
                                new Resource { Id = 415, StepId = 146, Title = "CQRS Journey", Url = "https://docs.microsoft.com/en-us/previous-versions/msp-n-p/jj554200(v=pandp.10)", Type = "documentation" },
                                new Resource { Id = 416, StepId = 146, Title = "Implementing CQRS", Url = "https://www.youtube.com/watch?v=B1-6R1_Vm2s", Type = "video" },
                                new Resource { Id = 417, StepId = 146, Title = "MediatR", Url = "https://github.com/jbogard/MediatR", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 147,
                            RoadmapId = 22,
                            Title = "Service-Oriented Architecture",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 603, StepId = 147, Description = "Understand SOA principles" },
                                new LearningObjective { Id = 604, StepId = 147, Description = "Design service contracts" },
                                new LearningObjective { Id = 605, StepId = 147, Description = "Implement service orchestration" },
                                new LearningObjective { Id = 606, StepId = 147, Description = "Apply SOA governance" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 418, StepId = 147, Title = "SOA Principles", Url = "https://www.ibm.com/cloud/learn/soa", Type = "article" },
                                new Resource { Id = 419, StepId = 147, Title = "Service-Oriented Architecture", Url = "https://www.amazon.com/Service-Oriented-Architecture-Thomas-Erl/dp/0132344823", Type = "book" },
                                new Resource { Id = 420, StepId = 147, Title = "REST vs SOAP", Url = "https://www.youtube.com/watch?v=bPNfu0IZhoE", Type = "video" },
                                new Resource { Id = 421, StepId = 147, Title = "WCF Documentation", Url = "https://docs.microsoft.com/en-us/dotnet/framework/wcf/", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 148,
                            RoadmapId = 22,
                            Title = "Serverless Architecture",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 607, StepId = 148, Description = "Understand Function-as-a-Service" },
                                new LearningObjective { Id = 608, StepId = 148, Description = "Design stateless functions" },
                                new LearningObjective { Id = 609, StepId = 148, Description = "Handle serverless orchestration" },
                                new LearningObjective { Id = 610, StepId = 148, Description = "Manage cold starts and performance" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 422, StepId = 148, Title = "Serverless Architectures", Url = "https://martinfowler.com/articles/serverless.html", Type = "article" },
                                new Resource { Id = 423, StepId = 148, Title = "AWS Lambda", Url = "https://aws.amazon.com/lambda/", Type = "documentation" },
                                new Resource { Id = 424, StepId = 148, Title = "Azure Functions", Url = "https://docs.microsoft.com/en-us/azure/azure-functions/", Type = "documentation" },
                                new Resource { Id = 425, StepId = 148, Title = "Serverless Framework", Url = "https://www.serverless.com/", Type = "website" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 149,
                            RoadmapId = 22,
                            Title = "Architecture Documentation & ADRs",
                            Duration = "2 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 611, StepId = 149, Description = "Create architecture decision records" },
                                new LearningObjective { Id = 612, StepId = 149, Description = "Document architectural views" },
                                new LearningObjective { Id = 613, StepId = 149, Description = "Use modeling tools effectively" },
                                new LearningObjective { Id = 614, StepId = 149, Description = "Communicate architecture effectively" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 426, StepId = 149, Title = "Architecture Decision Records", Url = "https://adr.github.io/", Type = "website" },
                                new Resource { Id = 427, StepId = 149, Title = "C4 Model", Url = "https://c4model.com/", Type = "website" },
                                new Resource { Id = 428, StepId = 149, Title = "Documenting Software Architecture", Url = "https://www.amazon.com/Documenting-Software-Architectures-Views-Beyond/dp/0321552687", Type = "book" },
                                new Resource { Id = 429, StepId = 149, Title = "PlantUML", Url = "https://plantuml.com/", Type = "website" }
                            }
                        }
                    }
                },
                
                // Microservices Architecture
                new Roadmap
                {
                    Id = 23,
                    Title = "Microservices Architecture",
                    Description = "Design and build distributed systems using microservices patterns",
                    Icon = "🔷",
                    Category = CategoryConstants.Architecture,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 150,
                            RoadmapId = 23,
                            Title = "Microservices Fundamentals",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 615, StepId = 150, Description = "Understand microservices principles" },
                                new LearningObjective { Id = 616, StepId = 150, Description = "Compare with monolithic architecture" },
                                new LearningObjective { Id = 617, StepId = 150, Description = "Learn bounded contexts" },
                                new LearningObjective { Id = 618, StepId = 150, Description = "Design service boundaries" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 430, StepId = 150, Title = "Building Microservices", Url = "https://www.oreilly.com/library/view/building-microservices-2nd/9781492089025/", Type = "book" },
                                new Resource { Id = 431, StepId = 150, Title = "Microservices.io", Url = "https://microservices.io/", Type = "website" },
                                new Resource { Id = 432, StepId = 150, Title = "Martin Fowler on Microservices", Url = "https://martinfowler.com/articles/microservices.html", Type = "article" },
                                new Resource { Id = 433, StepId = 150, Title = "Microservices Architecture Course", Url = "https://www.udemy.com/course/microservices-software-architecture-patterns-and-techniques/", Type = "course" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 151,
                            RoadmapId = 23,
                            Title = "Service Communication",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 619, StepId = 151, Description = "Implement synchronous communication (REST, gRPC)" },
                                new LearningObjective { Id = 620, StepId = 151, Description = "Master asynchronous messaging" },
                                new LearningObjective { Id = 621, StepId = 151, Description = "Handle service discovery" },
                                new LearningObjective { Id = 622, StepId = 151, Description = "Implement API gateways" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 434, StepId = 151, Title = "gRPC Documentation", Url = "https://grpc.io/docs/", Type = "documentation" },
                                new Resource { Id = 435, StepId = 151, Title = "RabbitMQ Tutorials", Url = "https://www.rabbitmq.com/getstarted.html", Type = "documentation" },
                                new Resource { Id = 436, StepId = 151, Title = "API Gateway Pattern", Url = "https://microservices.io/patterns/apigateway.html", Type = "article" },
                                new Resource { Id = 437, StepId = 151, Title = "Service Mesh with Istio", Url = "https://istio.io/latest/docs/", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 152,
                            RoadmapId = 23,
                            Title = "Data Management",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 623, StepId = 152, Description = "Implement database per service" },
                                new LearningObjective { Id = 624, StepId = 152, Description = "Handle distributed transactions" },
                                new LearningObjective { Id = 625, StepId = 152, Description = "Apply Saga pattern" },
                                new LearningObjective { Id = 626, StepId = 152, Description = "Manage data consistency" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 438, StepId = 152, Title = "Data Management in Microservices", Url = "https://microservices.io/patterns/data/database-per-service.html", Type = "article" },
                                new Resource { Id = 439, StepId = 152, Title = "Saga Pattern", Url = "https://microservices.io/patterns/data/saga.html", Type = "article" },
                                new Resource { Id = 440, StepId = 152, Title = "Distributed Transactions", Url = "https://www.youtube.com/watch?v=YPbGW3Fnmbc", Type = "video" },
                                new Resource { Id = 441, StepId = 152, Title = "Event Sourcing", Url = "https://docs.microsoft.com/en-us/azure/architecture/patterns/event-sourcing", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 153,
                            RoadmapId = 23,
                            Title = "Resilience and Fault Tolerance",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 627, StepId = 153, Description = "Implement circuit breaker pattern" },
                                new LearningObjective { Id = 628, StepId = 153, Description = "Apply retry and timeout strategies" },
                                new LearningObjective { Id = 629, StepId = 153, Description = "Handle cascading failures" },
                                new LearningObjective { Id = 630, StepId = 153, Description = "Implement bulkhead pattern" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 442, StepId = 153, Title = "Polly Resilience Library", Url = "https://github.com/App-vNext/Polly", Type = "documentation" },
                                new Resource { Id = 443, StepId = 153, Title = "Circuit Breaker Pattern", Url = "https://martinfowler.com/bliki/CircuitBreaker.html", Type = "article" },
                                new Resource { Id = 444, StepId = 153, Title = "Hystrix", Url = "https://github.com/Netflix/Hystrix", Type = "documentation" },
                                new Resource { Id = 445, StepId = 153, Title = "Resilience Patterns", Url = "https://www.youtube.com/watch?v=7kX3dyscZpg", Type = "video" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 154,
                            RoadmapId = 23,
                            Title = "Security in Microservices",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 631, StepId = 154, Description = "Implement OAuth 2.0 and JWT" },
                                new LearningObjective { Id = 632, StepId = 154, Description = "Secure service-to-service communication" },
                                new LearningObjective { Id = 633, StepId = 154, Description = "Apply zero-trust security" },
                                new LearningObjective { Id = 634, StepId = 154, Description = "Handle API security" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 446, StepId = 154, Title = "OAuth 2.0", Url = "https://oauth.net/2/", Type = "documentation" },
                                new Resource { Id = 447, StepId = 154, Title = "JWT.io", Url = "https://jwt.io/", Type = "website" },
                                new Resource { Id = 448, StepId = 154, Title = "Microservices Security", Url = "https://www.oreilly.com/library/view/microservices-security-in/9781492027638/", Type = "book" },
                                new Resource { Id = 449, StepId = 154, Title = "IdentityServer", Url = "https://identityserver.io/", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 155,
                            RoadmapId = 23,
                            Title = "Monitoring and Observability",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 635, StepId = 155, Description = "Implement distributed tracing" },
                                new LearningObjective { Id = 636, StepId = 155, Description = "Set up centralized logging" },
                                new LearningObjective { Id = 637, StepId = 155, Description = "Monitor service health" },
                                new LearningObjective { Id = 638, StepId = 155, Description = "Create dashboards and alerts" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 450, StepId = 155, Title = "OpenTelemetry", Url = "https://opentelemetry.io/", Type = "documentation" },
                                new Resource { Id = 451, StepId = 155, Title = "ELK Stack", Url = "https://www.elastic.co/what-is/elk-stack", Type = "article" },
                                new Resource { Id = 452, StepId = 155, Title = "Prometheus and Grafana", Url = "https://prometheus.io/docs/visualization/grafana/", Type = "documentation" },
                                new Resource { Id = 453, StepId = 155, Title = "Distributed Tracing", Url = "https://www.youtube.com/watch?v=EJV_CgiqlOE", Type = "video" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 156,
                            RoadmapId = 23,
                            Title = "Deployment and Orchestration",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 639, StepId = 156, Description = "Containerize microservices with Docker" },
                                new LearningObjective { Id = 640, StepId = 156, Description = "Orchestrate with Kubernetes" },
                                new LearningObjective { Id = 641, StepId = 156, Description = "Implement CI/CD pipelines" },
                                new LearningObjective { Id = 642, StepId = 156, Description = "Apply deployment strategies" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 454, StepId = 156, Title = "Docker Documentation", Url = "https://docs.docker.com/", Type = "documentation" },
                                new Resource { Id = 455, StepId = 156, Title = "Kubernetes Documentation", Url = "https://kubernetes.io/docs/", Type = "documentation" },
                                new Resource { Id = 456, StepId = 156, Title = "Helm Charts", Url = "https://helm.sh/", Type = "documentation" },
                                new Resource { Id = 457, StepId = 156, Title = "GitOps with ArgoCD", Url = "https://argo-cd.readthedocs.io/", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 157,
                            RoadmapId = 23,
                            Title = "Microservices Testing",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 643, StepId = 157, Description = "Implement unit and integration tests" },
                                new LearningObjective { Id = 644, StepId = 157, Description = "Create contract tests" },
                                new LearningObjective { Id = 645, StepId = 157, Description = "Perform end-to-end testing" },
                                new LearningObjective { Id = 646, StepId = 157, Description = "Test in production safely" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 458, StepId = 157, Title = "Testing Microservices", Url = "https://martinfowler.com/articles/microservice-testing/", Type = "article" },
                                new Resource { Id = 459, StepId = 157, Title = "Pact Contract Testing", Url = "https://pact.io/", Type = "documentation" },
                                new Resource { Id = 460, StepId = 157, Title = "Chaos Engineering", Url = "https://principlesofchaos.org/", Type = "website" },
                                new Resource { Id = 461, StepId = 157, Title = "TestContainers", Url = "https://www.testcontainers.org/", Type = "documentation" }
                            }
                        }
                    }
                },
                
                // Domain-Driven Design
                new Roadmap
                {
                    Id = 24,
                    Title = "Domain-Driven Design",
                    Description = "Master DDD principles for complex business domain modeling",
                    Icon = "🎯",
                    Category = CategoryConstants.Architecture,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 158,
                            RoadmapId = 24,
                            Title = "DDD Fundamentals",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 647, StepId = 158, Description = "Understand DDD philosophy and principles" },
                                new LearningObjective { Id = 648, StepId = 158, Description = "Learn ubiquitous language" },
                                new LearningObjective { Id = 649, StepId = 158, Description = "Identify domain and subdomains" },
                                new LearningObjective { Id = 650, StepId = 158, Description = "Differentiate core, supporting, and generic domains" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 462, StepId = 158, Title = "Domain-Driven Design (Blue Book)", Url = "https://www.amazon.com/Domain-Driven-Design-Tackling-Complexity-Software/dp/0321125215", Type = "book" },
                                new Resource { Id = 463, StepId = 158, Title = "DDD Quickly", Url = "https://www.infoq.com/minibooks/domain-driven-design-quickly/", Type = "book" },
                                new Resource { Id = 464, StepId = 158, Title = "DDD Introduction", Url = "https://www.youtube.com/watch?v=pMuiVlnGqjk", Type = "video" },
                                new Resource { Id = 465, StepId = 158, Title = "DDD Community", Url = "https://dddcommunity.org/", Type = "website" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 159,
                            RoadmapId = 24,
                            Title = "Strategic Design",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 651, StepId = 159, Description = "Master bounded contexts" },
                                new LearningObjective { Id = 652, StepId = 159, Description = "Create context maps" },
                                new LearningObjective { Id = 653, StepId = 159, Description = "Apply context integration patterns" },
                                new LearningObjective { Id = 654, StepId = 159, Description = "Design strategic boundaries" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 466, StepId = 159, Title = "Bounded Context", Url = "https://martinfowler.com/bliki/BoundedContext.html", Type = "article" },
                                new Resource { Id = 467, StepId = 159, Title = "Context Mapping", Url = "https://www.infoq.com/articles/ddd-contextmapping/", Type = "article" },
                                new Resource { Id = 468, StepId = 159, Title = "Strategic DDD", Url = "https://www.youtube.com/watch?v=oMPnv1QfBjg", Type = "video" },
                                new Resource { Id = 469, StepId = 159, Title = "DDD Distilled", Url = "https://www.amazon.com/Domain-Driven-Design-Distilled-Vaughn-Vernon/dp/0134434420", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 160,
                            RoadmapId = 24,
                            Title = "Tactical Design - Entities and Value Objects",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 655, StepId = 160, Description = "Design entities with identity" },
                                new LearningObjective { Id = 656, StepId = 160, Description = "Create immutable value objects" },
                                new LearningObjective { Id = 657, StepId = 160, Description = "Implement equality and validation" },
                                new LearningObjective { Id = 658, StepId = 160, Description = "Apply domain logic properly" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 470, StepId = 160, Title = "Entities vs Value Objects", Url = "https://enterprisecraftsmanship.com/posts/entity-vs-value-object-the-ultimate-list-of-differences/", Type = "article" },
                                new Resource { Id = 471, StepId = 160, Title = "Value Objects", Url = "https://martinfowler.com/bliki/ValueObject.html", Type = "article" },
                                new Resource { Id = 472, StepId = 160, Title = "DDD Building Blocks", Url = "https://www.youtube.com/watch?v=_dCpbBl8FCM", Type = "video" },
                                new Resource { Id = 473, StepId = 160, Title = "Implementing DDD", Url = "https://www.amazon.com/Implementing-Domain-Driven-Design-Vaughn-Vernon/dp/0321834577", Type = "book" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 161,
                            RoadmapId = 24,
                            Title = "Aggregates and Domain Services",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 659, StepId = 161, Description = "Design aggregate boundaries" },
                                new LearningObjective { Id = 660, StepId = 161, Description = "Implement aggregate roots" },
                                new LearningObjective { Id = 661, StepId = 161, Description = "Create domain services" },
                                new LearningObjective { Id = 662, StepId = 161, Description = "Handle cross-aggregate transactions" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 474, StepId = 161, Title = "Aggregate Design", Url = "https://www.dddcommunity.org/wp-content/uploads/files/pdf_articles/Vernon_2011_2.pdf", Type = "article" },
                                new Resource { Id = 475, StepId = 161, Title = "Domain Services", Url = "https://enterprisecraftsmanship.com/posts/domain-services-vs-application-services/", Type = "article" },
                                new Resource { Id = 476, StepId = 161, Title = "Aggregate Pattern", Url = "https://www.youtube.com/watch?v=r3qsjB_B-Lc", Type = "video" },
                                new Resource { Id = 477, StepId = 161, Title = "DDD Sample Application", Url = "https://github.com/citerus/dddsample-core", Type = "website" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 162,
                            RoadmapId = 24,
                            Title = "Domain Events",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 663, StepId = 162, Description = "Model domain events" },
                                new LearningObjective { Id = 664, StepId = 162, Description = "Implement event publishing" },
                                new LearningObjective { Id = 665, StepId = 162, Description = "Handle event ordering" },
                                new LearningObjective { Id = 666, StepId = 162, Description = "Apply event sourcing" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 478, StepId = 162, Title = "Domain Events", Url = "https://martinfowler.com/eaaDev/DomainEvent.html", Type = "article" },
                                new Resource { Id = 479, StepId = 162, Title = "Event Storming", Url = "https://www.eventstorming.com/", Type = "website" },
                                new Resource { Id = 480, StepId = 162, Title = "Domain Events in Practice", Url = "https://www.youtube.com/watch?v=yZUJJPSdSNc", Type = "video" },
                                new Resource { Id = 481, StepId = 162, Title = "Event Sourcing", Url = "https://eventstore.com/blog/what-is-event-sourcing/", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 163,
                            RoadmapId = 24,
                            Title = "Repositories and Specifications",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 667, StepId = 163, Description = "Implement repository pattern" },
                                new LearningObjective { Id = 668, StepId = 163, Description = "Create specification pattern" },
                                new LearningObjective { Id = 669, StepId = 163, Description = "Handle persistence ignorance" },
                                new LearningObjective { Id = 670, StepId = 163, Description = "Design query objects" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 482, StepId = 163, Title = "Repository Pattern", Url = "https://martinfowler.com/eaaCatalog/repository.html", Type = "article" },
                                new Resource { Id = 483, StepId = 163, Title = "Specification Pattern", Url = "https://enterprisecraftsmanship.com/posts/specification-pattern-c-implementation/", Type = "article" },
                                new Resource { Id = 484, StepId = 163, Title = "DDD Repository", Url = "https://www.youtube.com/watch?v=dfLhvwQ_qCw", Type = "video" },
                                new Resource { Id = 485, StepId = 163, Title = "Ardalis.Specification", Url = "https://github.com/ardalis/Specification", Type = "website" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 164,
                            RoadmapId = 24,
                            Title = "Application Services and CQRS",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 671, StepId = 164, Description = "Design application services" },
                                new LearningObjective { Id = 672, StepId = 164, Description = "Implement use cases" },
                                new LearningObjective { Id = 673, StepId = 164, Description = "Apply CQRS with DDD" },
                                new LearningObjective { Id = 674, StepId = 164, Description = "Handle cross-cutting concerns" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 486, StepId = 164, Title = "Application Services", Url = "https://enterprisecraftsmanship.com/posts/domain-vs-application-services/", Type = "article" },
                                new Resource { Id = 487, StepId = 164, Title = "CQRS and DDD", Url = "https://www.youtube.com/watch?v=QZiY0JYoTHg", Type = "video" },
                                new Resource { Id = 488, StepId = 164, Title = "Clean Architecture", Url = "https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html", Type = "article" },
                                new Resource { Id = 489, StepId = 164, Title = "MediatR with DDD", Url = "https://github.com/jbogard/MediatR", Type = "documentation" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 165,
                            RoadmapId = 24,
                            Title = "DDD in Practice",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 675, StepId = 165, Description = "Apply DDD to real projects" },
                                new LearningObjective { Id = 676, StepId = 165, Description = "Handle legacy system integration" },
                                new LearningObjective { Id = 677, StepId = 165, Description = "Balance DDD complexity" },
                                new LearningObjective { Id = 678, StepId = 165, Description = "Evolve domain models" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 490, StepId = 165, Title = "DDD Case Studies", Url = "https://github.com/ddd-crew/welcome-to-ddd", Type = "website" },
                                new Resource { Id = 491, StepId = 165, Title = "Refactoring to DDD", Url = "https://www.youtube.com/watch?v=_f25QMJY9bY", Type = "video" },
                                new Resource { Id = 492, StepId = 165, Title = "DDD Anti-patterns", Url = "https://www.infoq.com/articles/ddd-anti-patterns-mistakes/", Type = "article" },
                                new Resource { Id = 493, StepId = 165, Title = "Learning Domain-Driven Design", Url = "https://www.oreilly.com/library/view/learning-domain-driven-design/9781098100124/", Type = "book" }
                            }
                        }
                    }
                },
                
                // Soft Skills
                new Roadmap
                {
                    Id = 26,
                    Title = "Soft Skills for Developers",
                    Description = "Develop essential soft skills for career growth and team collaboration",
                    Icon = "🤝",
                    Category = CategoryConstants.Specialized,
                    Duration = "3-4 months",
                    Difficulty = "All Levels",
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 166,
                            RoadmapId = 26,
                            Title = "Communication Skills",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 679, StepId = 166, Description = "Master written communication for technical documentation" },
                                new LearningObjective { Id = 680, StepId = 166, Description = "Develop effective verbal communication with stakeholders" },
                                new LearningObjective { Id = 681, StepId = 166, Description = "Practice active listening and asking clarifying questions" },
                                new LearningObjective { Id = 682, StepId = 166, Description = "Learn to explain complex technical concepts simply" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 494, StepId = 166, Title = "The Pyramid Principle", Url = "https://www.amazon.com/Pyramid-Principle-Logic-Writing-Thinking/dp/0273710516", Type = "book" },
                                new Resource { Id = 495, StepId = 166, Title = "Technical Writing Course", Url = "https://developers.google.com/tech-writing", Type = "course" },
                                new Resource { Id = 496, StepId = 166, Title = "Communication for Engineers", Url = "https://www.youtube.com/watch?v=YgBs_lbdCYg", Type = "video" },
                                new Resource { Id = 497, StepId = 166, Title = "How to Explain Anything", Url = "https://blog.usejournal.com/how-to-explain-anything-to-anyone-4df233142cbf", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 167,
                            RoadmapId = 26,
                            Title = "Teamwork and Collaboration",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 683, StepId = 167, Description = "Build effective working relationships with team members" },
                                new LearningObjective { Id = 684, StepId = 167, Description = "Navigate conflicts and disagreements constructively" },
                                new LearningObjective { Id = 685, StepId = 167, Description = "Collaborate effectively in diverse and remote teams" },
                                new LearningObjective { Id = 686, StepId = 167, Description = "Give and receive constructive feedback" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 498, StepId = 167, Title = "The Five Dysfunctions of a Team", Url = "https://www.amazon.com/Five-Dysfunctions-Team-Leadership-Fable/dp/0787960756", Type = "book" },
                                new Resource { Id = 499, StepId = 167, Title = "Collaboration Skills Course", Url = "https://www.coursera.org/learn/collaboration-skills", Type = "course" },
                                new Resource { Id = 500, StepId = 167, Title = "Remote Team Collaboration", Url = "https://www.youtube.com/watch?v=F2QN_ue2L2w", Type = "video" },
                                new Resource { Id = 501, StepId = 167, Title = "Giving Effective Feedback", Url = "https://hbr.org/2019/03/the-feedback-fallacy", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 168,
                            RoadmapId = 26,
                            Title = "Problem Solving and Critical Thinking",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 687, StepId = 168, Description = "Apply structured problem-solving methodologies" },
                                new LearningObjective { Id = 688, StepId = 168, Description = "Develop analytical thinking and root cause analysis skills" },
                                new LearningObjective { Id = 689, StepId = 168, Description = "Make decisions under uncertainty and constraints" },
                                new LearningObjective { Id = 690, StepId = 168, Description = "Think creatively and generate innovative solutions" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 502, StepId = 168, Title = "Thinking, Fast and Slow", Url = "https://www.amazon.com/Thinking-Fast-Slow-Daniel-Kahneman/dp/0374533555", Type = "book" },
                                new Resource { Id = 503, StepId = 168, Title = "Critical Thinking Course", Url = "https://www.edx.org/course/introduction-to-critical-thinking", Type = "course" },
                                new Resource { Id = 504, StepId = 168, Title = "Problem Solving Techniques", Url = "https://www.youtube.com/watch?v=bI3dFeEpOGc", Type = "video" },
                                new Resource { Id = 505, StepId = 168, Title = "Root Cause Analysis", Url = "https://blog.hubspot.com/service/what-is-root-cause-analysis", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 169,
                            RoadmapId = 26,
                            Title = "Time Management and Productivity",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 691, StepId = 169, Description = "Master prioritization frameworks and techniques" },
                                new LearningObjective { Id = 692, StepId = 169, Description = "Develop focus and minimize distractions" },
                                new LearningObjective { Id = 693, StepId = 169, Description = "Create sustainable work habits and routines" },
                                new LearningObjective { Id = 694, StepId = 169, Description = "Balance multiple projects and deadlines effectively" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 506, StepId = 169, Title = "Getting Things Done", Url = "https://www.amazon.com/Getting-Things-Done-Stress-Free-Productivity/dp/0142000280", Type = "book" },
                                new Resource { Id = 507, StepId = 169, Title = "Time Management Fundamentals", Url = "https://www.linkedin.com/learning/time-management-fundamentals", Type = "course" },
                                new Resource { Id = 508, StepId = 169, Title = "Deep Work", Url = "https://www.youtube.com/watch?v=b6xQpoVgN68", Type = "video" },
                                new Resource { Id = 509, StepId = 169, Title = "Eisenhower Matrix", Url = "https://todoist.com/productivity-methods/eisenhower-matrix", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 170,
                            RoadmapId = 26,
                            Title = "Leadership and Mentoring",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 695, StepId = 170, Description = "Develop leadership presence and influence without authority" },
                                new LearningObjective { Id = 696, StepId = 170, Description = "Learn to mentor junior developers and peers" },
                                new LearningObjective { Id = 697, StepId = 170, Description = "Build and lead high-performing teams" },
                                new LearningObjective { Id = 698, StepId = 170, Description = "Navigate organizational dynamics and politics" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 510, StepId = 170, Title = "The Manager's Path", Url = "https://www.amazon.com/Managers-Path-Leaders-Navigating-Growth/dp/1491973897", Type = "book" },
                                new Resource { Id = 511, StepId = 170, Title = "Leadership for Engineers", Url = "https://www.pluralsight.com/courses/leadership-for-engineers", Type = "course" },
                                new Resource { Id = 512, StepId = 170, Title = "Technical Leadership", Url = "https://www.youtube.com/watch?v=MotQObb8YSA", Type = "video" },
                                new Resource { Id = 513, StepId = 170, Title = "Mentoring Developers", Url = "https://medium.com/@codepo8/mentoring-developers-some-thoughts-ef2ae30b27e6", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 171,
                            RoadmapId = 26,
                            Title = "Presentation and Public Speaking",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 699, StepId = 171, Description = "Prepare and deliver compelling technical presentations" },
                                new LearningObjective { Id = 700, StepId = 171, Description = "Engage audiences and handle questions confidently" },
                                new LearningObjective { Id = 701, StepId = 171, Description = "Create effective visual aids and slides" },
                                new LearningObjective { Id = 702, StepId = 171, Description = "Present to different audiences: technical and non-technical" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 514, StepId = 171, Title = "Made to Stick", Url = "https://www.amazon.com/Made-Stick-Ideas-Survive-Others/dp/1400064287", Type = "book" },
                                new Resource { Id = 515, StepId = 171, Title = "Public Speaking for Engineers", Url = "https://www.udemy.com/course/public-speaking-for-engineers/", Type = "course" },
                                new Resource { Id = 516, StepId = 171, Title = "How to Give a Great Tech Talk", Url = "https://www.youtube.com/watch?v=yE67bo7dmbY", Type = "video" },
                                new Resource { Id = 517, StepId = 171, Title = "Presentation Design Tips", Url = "https://blog.hubspot.com/marketing/easy-presentation-design-tricks-ht", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 172,
                            RoadmapId = 26,
                            Title = "Emotional Intelligence",
                            Duration = "2-3 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 703, StepId = 172, Description = "Develop self-awareness and emotional regulation" },
                                new LearningObjective { Id = 704, StepId = 172, Description = "Improve empathy and social awareness" },
                                new LearningObjective { Id = 705, StepId = 172, Description = "Handle stress and pressure effectively" },
                                new LearningObjective { Id = 706, StepId = 172, Description = "Build resilience and adaptability" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 518, StepId = 172, Title = "Emotional Intelligence 2.0", Url = "https://www.amazon.com/Emotional-Intelligence-2-0-Travis-Bradberry/dp/0974320625", Type = "book" },
                                new Resource { Id = 519, StepId = 172, Title = "Emotional Intelligence Course", Url = "https://www.coursera.org/learn/emotional-intelligence-introduction", Type = "course" },
                                new Resource { Id = 520, StepId = 172, Title = "EQ in the Workplace", Url = "https://www.youtube.com/watch?v=Y7m9eNoB3NU", Type = "video" },
                                new Resource { Id = 521, StepId = 172, Title = "Building Resilience", Url = "https://hbr.org/2016/06/building-resilience-i", Type = "article" }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 173,
                            RoadmapId = 26,
                            Title = "Career Development and Networking",
                            Duration = "3-4 weeks",
                            Objectives = new List<LearningObjective>
                            {
                                new LearningObjective { Id = 707, StepId = 173, Description = "Create a strategic career development plan" },
                                new LearningObjective { Id = 708, StepId = 173, Description = "Build and maintain professional networks" },
                                new LearningObjective { Id = 709, StepId = 173, Description = "Develop personal branding and online presence" },
                                new LearningObjective { Id = 710, StepId = 173, Description = "Master job interviews and salary negotiations" }
                            },
                            Resources = new List<Resource>
                            {
                                new Resource { Id = 522, StepId = 173, Title = "The Coding Career Handbook", Url = "https://www.learninpublic.org/", Type = "book" },
                                new Resource { Id = 523, StepId = 173, Title = "Developer Career Masterclass", Url = "https://www.udemy.com/course/the-complete-junior-to-senior-web-developer-roadmap/", Type = "course" },
                                new Resource { Id = 524, StepId = 173, Title = "Building Your Developer Brand", Url = "https://www.youtube.com/watch?v=QaBXkjGP8gE", Type = "video" },
                                new Resource { Id = 525, StepId = 173, Title = "Networking for Developers", Url = "https://simpleprogrammer.com/networking-software-developers/", Type = "article" }
                            }
                        }
                    }
                }
            };
        }
    }
}