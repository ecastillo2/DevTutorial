using System.Collections.Generic;
using System.Linq;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Services
{
    public partial class RoadmapService
    {
        private void UpdateCSharpDeveloperRoadmap(List<Roadmap> roadmaps)
        {
            var csharpDev = roadmaps.FirstOrDefault(r => r.Id == 11);
            if (csharpDev != null)
            {
                // Update the C# Developer roadmap with comprehensive structure
                csharpDev.Title = "C# Developer / Programmer";
                csharpDev.Description = "Master C# programming from fundamentals to advanced features, including .NET platform, web development, and modern software architecture";
                csharpDev.Duration = "8-12 months";
                csharpDev.Difficulty = "Beginner to Expert";
                csharpDev.Context = "C# is a modern, versatile programming language developed by Microsoft. It's used for web development, desktop applications, game development, cloud services, and more. This comprehensive path covers all aspects of C# development from language fundamentals to advanced architectural patterns.";
                
                csharpDev.Prerequisites = new List<string>
                {
                    "Basic computer literacy",
                    "Logical thinking and problem-solving skills",
                    "Willingness to learn programming concepts",
                    "Basic understanding of how software works"
                };
                
                csharpDev.CareerPaths = new List<string>
                {
                    "Junior C# Developer ($50K-$80K)",
                    ".NET Developer ($65K-$120K)",
                    "Senior Software Engineer ($100K-$160K)",
                    "Solutions Architect ($120K-$180K)",
                    "Technical Lead ($110K-$170K)"
                };

                // Replace existing steps with comprehensive 20-category structure
                csharpDev.Steps = new List<RoadmapStep>
                {
                    // 1. C# Language Fundamentals
                    new RoadmapStep
                    {
                        Id = 1101,
                        RoadmapId = 11,
                        Title = "C# Language Fundamentals",
                        Duration = "3-4 weeks",
                        Content = "Master the core building blocks of C# programming language",
                        KeyConcepts = new List<string> 
                        { 
                            "Variables & Data Types",
                            "Control Flow Structures",
                            "Arrays & Collections",
                            "Methods & Parameters",
                            "Strings & StringBuilder"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 11011, StepId = 1101, Description = "Understand value types vs reference types" },
                            new LearningObjective { Id = 11012, StepId = 1101, Description = "Master control flow: if/else, switch, loops" },
                            new LearningObjective { Id = 11013, StepId = 1101, Description = "Work with arrays and collections effectively" },
                            new LearningObjective { Id = 11014, StepId = 1101, Description = "Handle nullable types and null safety" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 11011, StepId = 1101, Title = "C# Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/dotnet/csharp/" },
                            new Resource { Id = 11012, StepId = 1101, Title = "C# Fundamentals Course", Type = "Course", Url = "https://docs.microsoft.com/learn/paths/csharp-first-steps/" }
                        }
                    },

                    // 2. Object-Oriented Programming
                    new RoadmapStep
                    {
                        Id = 1102,
                        RoadmapId = 11,
                        Title = "Object-Oriented Programming (OOP)",
                        Duration = "4-5 weeks",
                        Content = "Master OOP principles and their implementation in C#",
                        KeyConcepts = new List<string>
                        {
                            "Classes & Objects",
                            "Inheritance & Polymorphism",
                            "Interfaces & Abstraction",
                            "Encapsulation",
                            "SOLID Principles"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 11021, StepId = 1102, Description = "Design classes with proper encapsulation" },
                            new LearningObjective { Id = 11022, StepId = 1102, Description = "Implement inheritance and polymorphism" },
                            new LearningObjective { Id = 11023, StepId = 1102, Description = "Create and use interfaces effectively" },
                            new LearningObjective { Id = 11024, StepId = 1102, Description = "Apply SOLID principles in design" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 11021, StepId = 1102, Title = "OOP in C# Guide", Type = "Documentation", Url = "https://docs.microsoft.com/dotnet/csharp/programming-guide/concepts/object-oriented-programming" },
                            new Resource { Id = 11022, StepId = 1102, Title = "SOLID Principles", Type = "Article", Url = "https://www.digitalocean.com/community/conceptual_articles/s-o-l-i-d-the-first-five-principles-of-object-oriented-design" }
                        }
                    },

                    // 3. Advanced C# Features
                    new RoadmapStep
                    {
                        Id = 1103,
                        RoadmapId = 11,
                        Title = "Advanced C# Features",
                        Duration = "4-5 weeks",
                        Content = "Explore advanced language features and modern C# capabilities",
                        KeyConcepts = new List<string>
                        {
                            "Delegates & Events",
                            "Generics & Constraints",
                            "LINQ & Lambda Expressions",
                            "Pattern Matching",
                            "Records & Tuples"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 11031, StepId = 1103, Description = "Implement delegates and event handlers" },
                            new LearningObjective { Id = 11032, StepId = 1103, Description = "Create generic classes and methods" },
                            new LearningObjective { Id = 11033, StepId = 1103, Description = "Master LINQ for data manipulation" },
                            new LearningObjective { Id = 11034, StepId = 1103, Description = "Use pattern matching and records (C# 9+)" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 11031, StepId = 1103, Title = "Advanced C# Features", Type = "Course", Url = "https://docs.microsoft.com/learn/paths/csharp-logic/" },
                            new Resource { Id = 11032, StepId = 1103, Title = "LINQ Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/dotnet/csharp/programming-guide/concepts/linq/" }
                        }
                    },

                    // 4. Memory & Resource Management
                    new RoadmapStep
                    {
                        Id = 1104,
                        RoadmapId = 11,
                        Title = "Memory & Resource Management",
                        Duration = "2-3 weeks",
                        Content = "Understand .NET memory management and resource handling",
                        KeyConcepts = new List<string>
                        {
                            "Garbage Collection",
                            "IDisposable Pattern",
                            "Memory Leaks",
                            "Span<T> & Memory<T>",
                            "Weak References"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 11041, StepId = 1104, Description = "Understand how garbage collection works" },
                            new LearningObjective { Id = 11042, StepId = 1104, Description = "Implement IDisposable correctly" },
                            new LearningObjective { Id = 11043, StepId = 1104, Description = "Use Span<T> for performance" },
                            new LearningObjective { Id = 11044, StepId = 1104, Description = "Identify and fix memory leaks" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 11041, StepId = 1104, Title = ".NET Memory Management", Type = "Documentation", Url = "https://docs.microsoft.com/dotnet/standard/garbage-collection/" },
                            new Resource { Id = 11042, StepId = 1104, Title = "Memory Performance Guide", Type = "Guide", Url = "https://docs.microsoft.com/dotnet/standard/memory-and-spans/" }
                        }
                    },

                    // 5. Exception Handling
                    new RoadmapStep
                    {
                        Id = 1105,
                        RoadmapId = 11,
                        Title = "Exception Handling",
                        Duration = "1-2 weeks",
                        Content = "Master exception handling and error management strategies",
                        KeyConcepts = new List<string>
                        {
                            "try/catch/finally",
                            "Custom Exceptions",
                            "Exception Filters",
                            "Global Exception Handling",
                            "Best Practices"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 11051, StepId = 1105, Description = "Implement proper exception handling" },
                            new LearningObjective { Id = 11052, StepId = 1105, Description = "Create custom exception types" },
                            new LearningObjective { Id = 11053, StepId = 1105, Description = "Use exception filters effectively" },
                            new LearningObjective { Id = 11054, StepId = 1105, Description = "Design error handling strategies" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 11051, StepId = 1105, Title = "Exception Handling Guide", Type = "Documentation", Url = "https://docs.microsoft.com/dotnet/csharp/programming-guide/exceptions/" },
                            new Resource { Id = 11052, StepId = 1105, Title = "Best Practices", Type = "Article", Url = "https://docs.microsoft.com/dotnet/standard/exceptions/best-practices-for-exceptions" }
                        }
                    },

                    // 6. Asynchronous & Parallel Programming
                    new RoadmapStep
                    {
                        Id = 1106,
                        RoadmapId = 11,
                        Title = "Asynchronous & Parallel Programming",
                        Duration = "4-5 weeks",
                        Content = "Master async/await and parallel programming patterns",
                        KeyConcepts = new List<string>
                        {
                            "async/await",
                            "Task & ValueTask",
                            "Parallel Programming",
                            "Threading",
                            "Channels & Pipelines"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 11061, StepId = 1106, Description = "Write efficient async/await code" },
                            new LearningObjective { Id = 11062, StepId = 1106, Description = "Use Task Parallel Library (TPL)" },
                            new LearningObjective { Id = 11063, StepId = 1106, Description = "Handle cancellation and timeouts" },
                            new LearningObjective { Id = 11064, StepId = 1106, Description = "Avoid deadlocks and race conditions" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 11061, StepId = 1106, Title = "Async Programming", Type = "Documentation", Url = "https://docs.microsoft.com/dotnet/csharp/programming-guide/concepts/async/" },
                            new Resource { Id = 11062, StepId = 1106, Title = "Parallel Programming", Type = "Guide", Url = "https://docs.microsoft.com/dotnet/standard/parallel-programming/" }
                        }
                    },

                    // 7. LINQ (Language Integrated Query)
                    new RoadmapStep
                    {
                        Id = 1107,
                        RoadmapId = 11,
                        Title = "LINQ (Language Integrated Query)",
                        Duration = "2-3 weeks",
                        Content = "Master LINQ for powerful data querying and manipulation",
                        KeyConcepts = new List<string>
                        {
                            "Query Syntax vs Method Syntax",
                            "Deferred Execution",
                            "Standard Query Operators",
                            "Expression Trees",
                            "LINQ Providers"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 11071, StepId = 1107, Description = "Write complex LINQ queries" },
                            new LearningObjective { Id = 11072, StepId = 1107, Description = "Understand deferred execution" },
                            new LearningObjective { Id = 11073, StepId = 1107, Description = "Use projection and grouping" },
                            new LearningObjective { Id = 11074, StepId = 1107, Description = "Optimize LINQ performance" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 11071, StepId = 1107, Title = "LINQ Tutorial", Type = "Tutorial", Url = "https://docs.microsoft.com/dotnet/csharp/tutorials/working-with-linq" },
                            new Resource { Id = 11072, StepId = 1107, Title = "101 LINQ Samples", Type = "Examples", Url = "https://docs.microsoft.com/samples/dotnet/try-samples/101-linq-samples/" }
                        }
                    },

                    // 8. Data Access
                    new RoadmapStep
                    {
                        Id = 1108,
                        RoadmapId = 11,
                        Title = "Data Access Technologies",
                        Duration = "3-4 weeks",
                        Content = "Learn various data access patterns and technologies in .NET",
                        KeyConcepts = new List<string>
                        {
                            "ADO.NET Fundamentals",
                            "Entity Framework Core",
                            "Dapper & Micro-ORMs",
                            "Repository Pattern",
                            "Database Migrations"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 11081, StepId = 1108, Description = "Use ADO.NET for database access" },
                            new LearningObjective { Id = 11082, StepId = 1108, Description = "Implement Entity Framework Core" },
                            new LearningObjective { Id = 11083, StepId = 1108, Description = "Work with Dapper for performance" },
                            new LearningObjective { Id = 11084, StepId = 1108, Description = "Handle database transactions" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 11081, StepId = 1108, Title = "EF Core Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/ef/core/" },
                            new Resource { Id = 11082, StepId = 1108, Title = "Dapper Tutorial", Type = "Tutorial", Url = "https://dapper-tutorial.net/" }
                        }
                    },

                    // 9. .NET Platform & Runtime
                    new RoadmapStep
                    {
                        Id = 1109,
                        RoadmapId = 11,
                        Title = ".NET Platform & Runtime",
                        Duration = "2-3 weeks",
                        Content = "Understand the .NET ecosystem and runtime environment",
                        KeyConcepts = new List<string>
                        {
                            "CLR & JIT Compilation",
                            ".NET 6/7/8 Features",
                            "Cross-Platform Development",
                            "Assemblies & Namespaces",
                            "NuGet Package Management"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 11091, StepId = 1109, Description = "Understand CLR and compilation process" },
                            new LearningObjective { Id = 11092, StepId = 1109, Description = "Use latest .NET features effectively" },
                            new LearningObjective { Id = 11093, StepId = 1109, Description = "Create and publish NuGet packages" },
                            new LearningObjective { Id = 11094, StepId = 1109, Description = "Build cross-platform applications" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 11091, StepId = 1109, Title = ".NET Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/dotnet/" },
                            new Resource { Id = 11092, StepId = 1109, Title = "What's New in .NET", Type = "Article", Url = "https://docs.microsoft.com/dotnet/core/whats-new/" }
                        }
                    },

                    // 10. Testing & Debugging
                    new RoadmapStep
                    {
                        Id = 1110,
                        RoadmapId = 11,
                        Title = "Testing & Debugging",
                        Duration = "3-4 weeks",
                        Content = "Master testing strategies and debugging techniques",
                        KeyConcepts = new List<string>
                        {
                            "Unit Testing (xUnit, NUnit)",
                            "Mocking Frameworks",
                            "Integration Testing",
                            "TDD & BDD",
                            "Debugging Tools"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 11101, StepId = 1110, Description = "Write comprehensive unit tests" },
                            new LearningObjective { Id = 11102, StepId = 1110, Description = "Use mocking frameworks effectively" },
                            new LearningObjective { Id = 11103, StepId = 1110, Description = "Implement test-driven development" },
                            new LearningObjective { Id = 11104, StepId = 1110, Description = "Master debugging tools in VS" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 11101, StepId = 1110, Title = "Unit Testing in .NET", Type = "Documentation", Url = "https://docs.microsoft.com/dotnet/core/testing/" },
                            new Resource { Id = 11102, StepId = 1110, Title = "xUnit Tutorial", Type = "Tutorial", Url = "https://xunit.net/docs/getting-started/netcore/cmdline" }
                        }
                    },

                    // 11. Web Development with C#
                    new RoadmapStep
                    {
                        Id = 1111,
                        RoadmapId = 11,
                        Title = "Web Development with C#",
                        Duration = "5-6 weeks",
                        Content = "Build modern web applications with ASP.NET Core",
                        KeyConcepts = new List<string>
                        {
                            "ASP.NET Core MVC",
                            "Web APIs & REST",
                            "Blazor",
                            "SignalR",
                            "Authentication & Authorization"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 11111, StepId = 1111, Description = "Build MVC web applications" },
                            new LearningObjective { Id = 11112, StepId = 1111, Description = "Create RESTful APIs" },
                            new LearningObjective { Id = 11113, StepId = 1111, Description = "Develop Blazor applications" },
                            new LearningObjective { Id = 11114, StepId = 1111, Description = "Implement real-time features with SignalR" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 11111, StepId = 1111, Title = "ASP.NET Core Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/aspnet/core/" },
                            new Resource { Id = 11112, StepId = 1111, Title = "Blazor Tutorial", Type = "Tutorial", Url = "https://dotnet.microsoft.com/learn/aspnet/blazor-tutorial/" }
                        }
                    },

                    // 12. Desktop & Cross-Platform Development
                    new RoadmapStep
                    {
                        Id = 1112,
                        RoadmapId = 11,
                        Title = "Desktop & Cross-Platform Development",
                        Duration = "3-4 weeks",
                        Content = "Create desktop and cross-platform applications",
                        KeyConcepts = new List<string>
                        {
                            "Windows Forms",
                            "WPF & XAML",
                            ".NET MAUI",
                            "Avalonia UI",
                            "Console Applications"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 11121, StepId = 1112, Description = "Build WPF desktop applications" },
                            new LearningObjective { Id = 11122, StepId = 1112, Description = "Create cross-platform apps with MAUI" },
                            new LearningObjective { Id = 11123, StepId = 1112, Description = "Design MVVM architectures" },
                            new LearningObjective { Id = 11124, StepId = 1112, Description = "Build console applications" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 11121, StepId = 1112, Title = "WPF Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/dotnet/desktop/wpf/" },
                            new Resource { Id = 11122, StepId = 1112, Title = ".NET MAUI Guide", Type = "Guide", Url = "https://docs.microsoft.com/dotnet/maui/" }
                        }
                    },

                    // 13. Cloud & Distributed Systems
                    new RoadmapStep
                    {
                        Id = 1113,
                        RoadmapId = 11,
                        Title = "Cloud & Distributed Systems",
                        Duration = "4-5 weeks",
                        Content = "Build cloud-native applications and distributed systems",
                        KeyConcepts = new List<string>
                        {
                            "Azure SDK for .NET",
                            "Microservices Architecture",
                            "Message Queues",
                            "Service Discovery",
                            "Event-Driven Systems"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 11131, StepId = 1113, Description = "Use Azure services from .NET" },
                            new LearningObjective { Id = 11132, StepId = 1113, Description = "Design microservices architecture" },
                            new LearningObjective { Id = 11133, StepId = 1113, Description = "Implement message-based communication" },
                            new LearningObjective { Id = 11134, StepId = 1113, Description = "Build resilient distributed systems" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 11131, StepId = 1113, Title = "Azure for .NET Developers", Type = "Documentation", Url = "https://docs.microsoft.com/azure/developer/dotnet/" },
                            new Resource { Id = 11132, StepId = 1113, Title = "Microservices Guide", Type = "Guide", Url = "https://docs.microsoft.com/azure/architecture/guide/architecture-styles/microservices" }
                        }
                    },

                    // 14. Security in C#
                    new RoadmapStep
                    {
                        Id = 1114,
                        RoadmapId = 11,
                        Title = "Security in C#",
                        Duration = "3-4 weeks",
                        Content = "Implement security best practices in C# applications",
                        KeyConcepts = new List<string>
                        {
                            "Cryptography & Hashing",
                            "Authentication & Authorization",
                            "JWT & OAuth2",
                            "Input Validation",
                            "Security Best Practices"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 11141, StepId = 1114, Description = "Implement secure authentication" },
                            new LearningObjective { Id = 11142, StepId = 1114, Description = "Use cryptography APIs correctly" },
                            new LearningObjective { Id = 11143, StepId = 1114, Description = "Prevent common vulnerabilities" },
                            new LearningObjective { Id = 11144, StepId = 1114, Description = "Implement data protection" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 11141, StepId = 1114, Title = ".NET Security", Type = "Documentation", Url = "https://docs.microsoft.com/dotnet/standard/security/" },
                            new Resource { Id = 11142, StepId = 1114, Title = "OWASP for .NET", Type = "Guide", Url = "https://cheatsheetseries.owasp.org/cheatsheets/DotNet_Security_Cheat_Sheet.html" }
                        }
                    },

                    // 15. Design Patterns
                    new RoadmapStep
                    {
                        Id = 1115,
                        RoadmapId = 11,
                        Title = "Design Patterns",
                        Duration = "3-4 weeks",
                        Content = "Master common design patterns and their C# implementations",
                        KeyConcepts = new List<string>
                        {
                            "Creational Patterns",
                            "Structural Patterns",
                            "Behavioral Patterns",
                            "Dependency Injection",
                            "Repository & Unit of Work"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 11151, StepId = 1115, Description = "Implement GoF design patterns" },
                            new LearningObjective { Id = 11152, StepId = 1115, Description = "Use dependency injection effectively" },
                            new LearningObjective { Id = 11153, StepId = 1115, Description = "Apply patterns appropriately" },
                            new LearningObjective { Id = 11154, StepId = 1115, Description = "Recognize anti-patterns" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 11151, StepId = 1115, Title = "Design Patterns in C#", Type = "Course", Url = "https://refactoring.guru/design-patterns/csharp" },
                            new Resource { Id = 11152, StepId = 1115, Title = "Dependency Injection", Type = "Documentation", Url = "https://docs.microsoft.com/dotnet/core/extensions/dependency-injection" }
                        }
                    },

                    // 16. Software Architecture
                    new RoadmapStep
                    {
                        Id = 1116,
                        RoadmapId = 11,
                        Title = "Software Architecture",
                        Duration = "4-5 weeks",
                        Content = "Design scalable and maintainable software architectures",
                        KeyConcepts = new List<string>
                        {
                            "Clean Architecture",
                            "Domain-Driven Design",
                            "CQRS & Event Sourcing",
                            "API-First Design",
                            "SOLID Principles"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 11161, StepId = 1116, Description = "Apply SOLID principles consistently" },
                            new LearningObjective { Id = 11162, StepId = 1116, Description = "Implement Clean Architecture" },
                            new LearningObjective { Id = 11163, StepId = 1116, Description = "Design with DDD principles" },
                            new LearningObjective { Id = 11164, StepId = 1116, Description = "Build event-driven systems" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 11161, StepId = 1116, Title = "Clean Architecture", Type = "Book", Url = "https://www.amazon.com/Clean-Architecture-Craftsmans-Software-Structure/dp/0134494164" },
                            new Resource { Id = 11162, StepId = 1116, Title = "DDD in C#", Type = "Article", Url = "https://docs.microsoft.com/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/" }
                        }
                    },

                    // 17. Performance & Optimization
                    new RoadmapStep
                    {
                        Id = 1117,
                        RoadmapId = 11,
                        Title = "Performance & Optimization",
                        Duration = "3-4 weeks",
                        Content = "Optimize C# applications for maximum performance",
                        KeyConcepts = new List<string>
                        {
                            "Performance Profiling",
                            "Memory Optimization",
                            "Caching Strategies",
                            "Benchmarking",
                            "Span<T> & ValueTask"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 11171, StepId = 1117, Description = "Profile and identify bottlenecks" },
                            new LearningObjective { Id = 11172, StepId = 1117, Description = "Optimize memory usage" },
                            new LearningObjective { Id = 11173, StepId = 1117, Description = "Implement effective caching" },
                            new LearningObjective { Id = 11174, StepId = 1117, Description = "Use BenchmarkDotNet for measurements" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 11171, StepId = 1117, Title = "Performance Best Practices", Type = "Documentation", Url = "https://docs.microsoft.com/dotnet/framework/performance/performance-tips" },
                            new Resource { Id = 11172, StepId = 1117, Title = "BenchmarkDotNet", Type = "Documentation", Url = "https://benchmarkdotnet.org/articles/guides/getting-started.html" }
                        }
                    },

                    // 18. DevOps & Deployment
                    new RoadmapStep
                    {
                        Id = 1118,
                        RoadmapId = 11,
                        Title = "DevOps & Deployment",
                        Duration = "3-4 weeks",
                        Content = "Implement CI/CD pipelines and deployment strategies",
                        KeyConcepts = new List<string>
                        {
                            "CI/CD Pipelines",
                            "Docker & Containers",
                            "Kubernetes",
                            "Application Monitoring",
                            "Feature Flags"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 11181, StepId = 1118, Description = "Create GitHub Actions pipelines" },
                            new LearningObjective { Id = 11182, StepId = 1118, Description = "Containerize .NET applications" },
                            new LearningObjective { Id = 11183, StepId = 1118, Description = "Deploy to Kubernetes" },
                            new LearningObjective { Id = 11184, StepId = 1118, Description = "Implement logging and monitoring" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 11181, StepId = 1118, Title = ".NET DevOps", Type = "Documentation", Url = "https://docs.microsoft.com/azure/devops/pipelines/ecosystems/dotnet-core" },
                            new Resource { Id = 11182, StepId = 1118, Title = "Docker for .NET", Type = "Tutorial", Url = "https://docs.microsoft.com/dotnet/core/docker/introduction" }
                        }
                    },

                    // 19. Tools & Ecosystem
                    new RoadmapStep
                    {
                        Id = 1119,
                        RoadmapId = 11,
                        Title = "Tools & Ecosystem",
                        Duration = "2-3 weeks",
                        Content = "Master development tools and the .NET ecosystem",
                        KeyConcepts = new List<string>
                        {
                            "Visual Studio & VS Code",
                            "NuGet Package Management",
                            "Roslyn Compiler APIs",
                            "Code Analyzers",
                            "Git Integration"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 11191, StepId = 1119, Description = "Master Visual Studio productivity features" },
                            new LearningObjective { Id = 11192, StepId = 1119, Description = "Create and publish NuGet packages" },
                            new LearningObjective { Id = 11193, StepId = 1119, Description = "Use code analyzers effectively" },
                            new LearningObjective { Id = 11194, StepId = 1119, Description = "Work with Roslyn APIs" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 11191, StepId = 1119, Title = "Visual Studio Tips", Type = "Documentation", Url = "https://docs.microsoft.com/visualstudio/ide/productivity-features" },
                            new Resource { Id = 11192, StepId = 1119, Title = "NuGet Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/nuget/" }
                        }
                    },

                    // 20. Emerging & Specialized Topics
                    new RoadmapStep
                    {
                        Id = 1120,
                        RoadmapId = 11,
                        Title = "Emerging & Specialized Topics",
                        Duration = "3-4 weeks",
                        Content = "Explore cutting-edge C# features and specialized domains",
                        KeyConcepts = new List<string>
                        {
                            "Source Generators",
                            "Native AOT",
                            "ML.NET",
                            "WebAssembly with Blazor",
                            "Game Development with Unity"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 11201, StepId = 1120, Description = "Create C# source generators" },
                            new LearningObjective { Id = 11202, StepId = 1120, Description = "Build Native AOT applications" },
                            new LearningObjective { Id = 11203, StepId = 1120, Description = "Implement ML models with ML.NET" },
                            new LearningObjective { Id = 11204, StepId = 1120, Description = "Develop games with Unity and C#" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 11201, StepId = 1120, Title = "Source Generators", Type = "Documentation", Url = "https://docs.microsoft.com/dotnet/csharp/roslyn-sdk/source-generators-overview" },
                            new Resource { Id = 11202, StepId = 1120, Title = "ML.NET Tutorial", Type = "Tutorial", Url = "https://dotnet.microsoft.com/learn/ml-dotnet" }
                        }
                    }
                };

                // Add practical exercises for each step
                foreach (var step in csharpDev.Steps)
                {
                    step.PracticalExercises = GetCSharpPracticalExercisesForStep(step.Id);
                }
            }
        }

        private List<string> GetCSharpPracticalExercisesForStep(int stepId)
        {
            return stepId switch
            {
                1101 => new List<string>
                {
                    "Build a console calculator with error handling",
                    "Create a student grade management system",
                    "Implement a simple text-based game",
                    "Work with file I/O and data parsing"
                },
                1102 => new List<string>
                {
                    "Design a banking system with inheritance",
                    "Create a shape hierarchy with polymorphism",
                    "Build an employee management system",
                    "Implement SOLID principles in a real project"
                },
                1103 => new List<string>
                {
                    "Create a generic data structure (Stack/Queue)",
                    "Build a LINQ-based data analysis tool",
                    "Implement event-driven notification system",
                    "Use pattern matching for data validation"
                },
                1104 => new List<string>
                {
                    "Profile and optimize a memory-intensive app",
                    "Implement custom dispose patterns",
                    "Use Span<T> for string manipulation",
                    "Create a resource pool with weak references"
                },
                1105 => new List<string>
                {
                    "Build a robust error handling framework",
                    "Create custom exception types with context",
                    "Implement retry logic with Polly",
                    "Design a global exception handler"
                },
                1106 => new List<string>
                {
                    "Build an async web scraper",
                    "Create a parallel image processor",
                    "Implement producer-consumer pattern",
                    "Build a real-time chat application"
                },
                1107 => new List<string>
                {
                    "Create a LINQ provider for custom data",
                    "Build a data analysis dashboard",
                    "Implement complex joins and grouping",
                    "Optimize LINQ query performance"
                },
                1108 => new List<string>
                {
                    "Build a repository pattern implementation",
                    "Create database migrations system",
                    "Implement Unit of Work pattern",
                    "Build a multi-tenant data access layer"
                },
                1109 => new List<string>
                {
                    "Create a plugin system using assemblies",
                    "Build a cross-platform CLI tool",
                    "Publish a NuGet package",
                    "Implement platform-specific features"
                },
                1110 => new List<string>
                {
                    "Write comprehensive unit test suite",
                    "Implement integration tests with Docker",
                    "Create custom test attributes",
                    "Build a test data generator"
                },
                1111 => new List<string>
                {
                    "Build a complete REST API with auth",
                    "Create a Blazor SPA application",
                    "Implement real-time notifications",
                    "Build a microservices gateway"
                },
                1112 => new List<string>
                {
                    "Create a WPF MVVM application",
                    "Build a cross-platform app with MAUI",
                    "Implement custom controls",
                    "Create a system tray application"
                },
                1113 => new List<string>
                {
                    "Build a cloud-native microservice",
                    "Implement service-to-service communication",
                    "Create an event-driven architecture",
                    "Build a distributed cache system"
                },
                1114 => new List<string>
                {
                    "Implement JWT authentication system",
                    "Build a secure API with rate limiting",
                    "Create encryption/decryption utilities",
                    "Implement OAuth2 flow"
                },
                1115 => new List<string>
                {
                    "Implement Factory and Builder patterns",
                    "Create Observer pattern for events",
                    "Build a DI container from scratch",
                    "Implement Strategy pattern for algorithms"
                },
                1116 => new List<string>
                {
                    "Design a Clean Architecture solution",
                    "Implement CQRS with MediatR",
                    "Build a DDD aggregate root",
                    "Create an event sourcing system"
                },
                1117 => new List<string>
                {
                    "Profile and optimize a slow application",
                    "Implement distributed caching",
                    "Create performance benchmarks",
                    "Optimize database query performance"
                },
                1118 => new List<string>
                {
                    "Set up CI/CD pipeline for .NET app",
                    "Dockerize a microservices solution",
                    "Deploy to Kubernetes with Helm",
                    "Implement blue-green deployment"
                },
                1119 => new List<string>
                {
                    "Create a Visual Studio extension",
                    "Build a code analyzer with fixes",
                    "Automate development workflow",
                    "Create custom project templates"
                },
                1120 => new List<string>
                {
                    "Build a source generator for DTOs",
                    "Create a Native AOT application",
                    "Implement ML model with ML.NET",
                    "Build a simple Unity game with C#"
                },
                _ => new List<string>()
            };
        }
    }
}