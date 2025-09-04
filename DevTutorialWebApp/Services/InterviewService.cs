using System.Collections.Generic;
using System.Linq;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Services
{
    public interface IInterviewService
    {
        List<InterviewCategory> GetAllCategories();
        InterviewCategory GetCategoryById(int id);
        List<InterviewQuestion> GetQuestionsByTopic(int topicId);
    }

    public class InterviewService : IInterviewService
    {
        private readonly List<InterviewCategory> _categories;

        public InterviewService()
        {
            _categories = InitializeInterviewData();
        }

        public List<InterviewCategory> GetAllCategories() => _categories;

        public InterviewCategory GetCategoryById(int id) => 
            _categories.FirstOrDefault(c => c.Id == id);

        public List<InterviewQuestion> GetQuestionsByTopic(int topicId)
        {
            foreach (var category in _categories)
            {
                var topic = category.Topics.FirstOrDefault(t => t.Id == topicId);
                if (topic != null)
                    return topic.Questions;
            }
            return new List<InterviewQuestion>();
        }

        private List<InterviewCategory> InitializeInterviewData()
        {
            return new List<InterviewCategory>
            {
                // Core C# and .NET Fundamentals
                new InterviewCategory
                {
                    Id = 1,
                    Name = "Core C# & .NET",
                    Icon = "🔷",
                    Description = "Fundamental C# language and .NET runtime concepts",
                    Topics = new List<InterviewTopic>
                    {
                        new InterviewTopic
                        {
                            Id = 1,
                            CategoryId = 1,
                            Title = "C# Language Basics",
                            Questions = new List<InterviewQuestion>
                            {
                                new InterviewQuestion
                                {
                                    Id = 1,
                                    TopicId = 1,
                                    Question = "Explain the differences between IEnumerable, ICollection, IList, and IQueryable. When would you use each?",
                                    Answer = "IEnumerable: Basic iteration, read-only access. ICollection: Add/remove capabilities + count. IList: Indexed access + ordering. IQueryable: LINQ queries that can be translated to SQL or other query languages.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "IEnumerable is the base interface for iteration",
                                        "ICollection adds modification capabilities",
                                        "IList provides indexed access",
                                        "IQueryable enables query translation (e.g., to SQL)"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 2,
                                    TopicId = 1,
                                    Question = "What is the difference between struct and class in C#? When would you use a struct?",
                                    Answer = "Struct: Value type, stack allocation, no inheritance, copy by value. Class: Reference type, heap allocation, inheritance support, copy by reference. Use structs for small, immutable data types.",
                                    Difficulty = "Beginner",
                                    KeyPoints = new List<string>
                                    {
                                        "Structs are value types, classes are reference types",
                                        "Structs have no inheritance (except interfaces)",
                                        "Structs are copied by value",
                                        "Use structs for small, immutable data"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 3,
                                    TopicId = 1,
                                    Question = "What are value types vs reference types? How does memory allocation differ?",
                                    Answer = "Value types store actual data on stack/inline. Reference types store reference to heap memory. Value types: faster allocation/deallocation, automatic cleanup. Reference types: support inheritance, can be null.",
                                    Difficulty = "Beginner",
                                    KeyPoints = new List<string>
                                    {
                                        "Value types: stack/inline allocation",
                                        "Reference types: heap allocation with stack reference",
                                        "Value types copied by value",
                                        "Reference types copied by reference"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 4,
                                    TopicId = 1,
                                    Question = "What's the difference between ref, out, and in parameters?",
                                    Answer = "ref: Pass by reference, must be initialized before call. out: Pass by reference, must be assigned in method. in: Read-only reference parameter for performance (avoids copying large structs).",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "ref: bidirectional, requires initialization",
                                        "out: output parameter, must be assigned",
                                        "in: read-only reference for performance",
                                        "All avoid copying large value types"
                                    }
                                }
                            }
                        },
                        new InterviewTopic
                        {
                            Id = 2,
                            CategoryId = 1,
                            Title = "Advanced C# Features",
                            Questions = new List<InterviewQuestion>
                            {
                                new InterviewQuestion
                                {
                                    Id = 5,
                                    TopicId = 2,
                                    Question = "Explain covariance and contravariance in generics. Give an example.",
                                    Answer = "Covariance (out): Can assign more derived type to less derived. Contravariance (in): Can assign less derived to more derived. Example: IEnumerable<string> can be assigned to IEnumerable<object> (covariance).",
                                    Difficulty = "Advanced",
                                    KeyPoints = new List<string>
                                    {
                                        "Covariance: out keyword, more to less derived",
                                        "Contravariance: in keyword, less to more derived",
                                        "Only works with interfaces and delegates",
                                        "Enables flexible generic assignments"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 6,
                                    TopicId = 2,
                                    Question = "What are expression trees and how are they used in LINQ providers like Entity Framework?",
                                    Answer = "Expression trees represent code as data structures. LINQ providers like EF translate Expression<Func<T, bool>> to SQL by analyzing the tree structure rather than executing C# code directly.",
                                    Difficulty = "Advanced",
                                    KeyPoints = new List<string>
                                    {
                                        "Represent code as analyzable data structures",
                                        "Enable query translation to other languages",
                                        "Used extensively in LINQ providers",
                                        "Allow compile-time verification of query logic"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 7,
                                    TopicId = 2,
                                    Question = "How do you implement custom iterators using yield return?",
                                    Answer = "yield return creates an iterator that produces values on-demand. The compiler generates a state machine that maintains position between calls, enabling lazy evaluation and memory-efficient iteration.",
                                    Difficulty = "Advanced",
                                    KeyPoints = new List<string>
                                    {
                                        "Creates lazy evaluation iterators",
                                        "Compiler generates state machine",
                                        "Memory efficient for large datasets",
                                        "Can yield multiple values or yield break"
                                    }
                                }
                            }
                        }
                    }
                },

                // ASP.NET Core Category
                new InterviewCategory
                {
                    Id = 2,
                    Name = "ASP.NET Core",
                    Icon = "🌐",
                    Description = "Web development with ASP.NET Core framework",
                    Topics = new List<InterviewTopic>
                    {
                        new InterviewTopic
                        {
                            Id = 3,
                            CategoryId = 2,
                            Title = "Core Concepts",
                            Questions = new List<InterviewQuestion>
                            {
                                new InterviewQuestion
                                {
                                    Id = 8,
                                    TopicId = 3,
                                    Question = "What are the benefits of .NET Core?",
                                    Answer = "Cross-platform support, high performance, modular architecture, side-by-side deployment, open source, microservices-friendly, and better Docker integration.",
                                    Difficulty = "Beginner",
                                    KeyPoints = new List<string>
                                    {
                                        "Cross-platform (Windows, Linux, macOS)",
                                        "High performance and lightweight",
                                        "Modular and containerization-friendly",
                                        "Side-by-side deployment support"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 9,
                                    TopicId = 3,
                                    Question = "What is .NET Core?",
                                    Answer = ".NET Core is a cross-platform, open-source framework for building modern applications. It's the evolution of .NET Framework, designed for cloud-native and containerized applications.",
                                    Difficulty = "Beginner",
                                    KeyPoints = new List<string>
                                    {
                                        "Cross-platform .NET implementation",
                                        "Open source and community-driven",
                                        "Optimized for cloud and containers",
                                        "Unified platform for web, desktop, mobile"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 10,
                                    TopicId = 3,
                                    Question = "Difference between Middleware and Filters in ASP.NET Core.",
                                    Answer = "Middleware: Handles HTTP pipeline globally, executes for all requests. Filters: Execute at specific points in MVC pipeline (authorization, action, result, exception), more targeted control.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "Middleware: Global HTTP pipeline processing",
                                        "Filters: MVC-specific pipeline hooks",
                                        "Middleware runs before MVC",
                                        "Filters provide fine-grained control"
                                    }
                                }
                            }
                        },
                        new InterviewTopic
                        {
                            Id = 4,
                            CategoryId = 2,
                            Title = "Security & Performance",
                            Questions = new List<InterviewQuestion>
                            {
                                new InterviewQuestion
                                {
                                    Id = 11,
                                    TopicId = 4,
                                    Question = "How would you secure an ASP.NET Core Web API?",
                                    Answer = "Use HTTPS, implement JWT authentication, add authorization policies, validate input, use CORS properly, implement rate limiting, and store secrets in Key Vault.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "HTTPS and TLS configuration",
                                        "JWT/OAuth2 authentication",
                                        "Input validation and sanitization",
                                        "Rate limiting and throttling"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 12,
                                    TopicId = 4,
                                    Question = "How to increase performance of a web app?",
                                    Answer = "Enable response compression, use caching (memory, Redis), optimize database queries, implement CDN, use async/await, minimize HTTP requests, and optimize images.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "Implement caching strategies",
                                        "Optimize database queries",
                                        "Use CDN for static content",
                                        "Enable compression and minification"
                                    }
                                }
                            }
                        }
                    }
                },

                // Azure Cloud Category
                new InterviewCategory
                {
                    Id = 3,
                    Name = "Azure Cloud",
                    Icon = "☁️",
                    Description = "Microsoft Azure cloud services and architecture",
                    Topics = new List<InterviewTopic>
                    {
                        new InterviewTopic
                        {
                            Id = 5,
                            CategoryId = 3,
                            Title = "Azure Services",
                            Questions = new List<InterviewQuestion>
                            {
                                new InterviewQuestion
                                {
                                    Id = 13,
                                    TopicId = 5,
                                    Question = "How to secure an app in Azure?",
                                    Answer = "Use Azure AD for authentication, Key Vault for secrets, managed identities, private endpoints, network security groups, and enable monitoring with Security Center.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "Azure AD for identity management",
                                        "Key Vault for secure secret storage",
                                        "Managed identities over service principals",
                                        "Network isolation with private endpoints"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 14,
                                    TopicId = 5,
                                    Question = "What are data lakes in Azure?",
                                    Answer = "Azure Data Lake Storage is a scalable data repository that can store structured, semi-structured, and unstructured data at any scale for big data analytics and machine learning.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "Store data of any type and size",
                                        "Hierarchical namespace for organization",
                                        "Integrated with Azure Analytics services",
                                        "Cost-effective storage for big data"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 15,
                                    TopicId = 5,
                                    Question = "What is Azure Service Bus?",
                                    Answer = "Enterprise messaging service that provides reliable message queuing and pub/sub messaging between applications, supporting complex routing and transaction management.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "Enterprise-grade messaging service",
                                        "Supports queues and topics/subscriptions",
                                        "Guaranteed message delivery",
                                        "Advanced features like dead lettering"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 16,
                                    TopicId = 5,
                                    Question = "What is Azure CDN?",
                                    Answer = "Content Delivery Network that caches static content at edge locations worldwide to reduce latency and improve performance for global users.",
                                    Difficulty = "Beginner",
                                    KeyPoints = new List<string>
                                    {
                                        "Global edge locations for content caching",
                                        "Reduces latency for global users",
                                        "Supports dynamic site acceleration",
                                        "Integrates with Azure services"
                                    }
                                }
                            }
                        }
                    }
                },

                // DevOps & CI/CD Category
                new InterviewCategory
                {
                    Id = 4,
                    Name = "DevOps & CI/CD",
                    Icon = "🔧",
                    Description = "DevOps practices and continuous integration/deployment",
                    Topics = new List<InterviewTopic>
                    {
                        new InterviewTopic
                        {
                            Id = 6,
                            CategoryId = 4,
                            Title = "DevOps Fundamentals",
                            Questions = new List<InterviewQuestion>
                            {
                                new InterviewQuestion
                                {
                                    Id = 17,
                                    TopicId = 6,
                                    Question = "What is CI/CD?",
                                    Answer = "Continuous Integration: Automatically build and test code changes. Continuous Deployment: Automatically deploy tested code to production. Enables faster, more reliable software delivery.",
                                    Difficulty = "Beginner",
                                    KeyPoints = new List<string>
                                    {
                                        "CI: Automated build and testing",
                                        "CD: Automated deployment pipeline",
                                        "Reduces manual errors and deployment time",
                                        "Enables faster feedback and iteration"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 18,
                                    TopicId = 6,
                                    Question = "What is DevOps?",
                                    Answer = "Cultural and technical practice that combines development and operations teams to improve collaboration, automate processes, and deliver software faster and more reliably.",
                                    Difficulty = "Beginner",
                                    KeyPoints = new List<string>
                                    {
                                        "Culture of collaboration between Dev and Ops",
                                        "Automation of software delivery pipeline",
                                        "Continuous monitoring and feedback",
                                        "Infrastructure as Code practices"
                                    }
                                }
                            }
                        }
                    }
                },

                // Performance & Optimization Category
                new InterviewCategory
                {
                    Id = 5,
                    Name = "Performance & Optimization",
                    Icon = "⚡",
                    Description = "Application performance tuning and optimization techniques",
                    Topics = new List<InterviewTopic>
                    {
                        new InterviewTopic
                        {
                            Id = 7,
                            CategoryId = 5,
                            Title = "Memory & Performance",
                            Questions = new List<InterviewQuestion>
                            {
                                new InterviewQuestion
                                {
                                    Id = 19,
                                    TopicId = 7,
                                    Question = "How does garbage collection work in .NET? What are generations and the Large Object Heap (LOH)?",
                                    Answer = "GC automatically manages memory by collecting unreferenced objects. Generation 0 (short-lived), Generation 1 (medium), Generation 2 (long-lived). LOH stores objects >85KB directly in Gen 2.",
                                    Difficulty = "Advanced",
                                    KeyPoints = new List<string>
                                    {
                                        "Automatic memory management",
                                        "Three generations based on object lifetime",
                                        "LOH for large objects (>85KB)",
                                        "Mark and sweep collection algorithm"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 20,
                                    TopicId = 7,
                                    Question = "What is lazy loading?",
                                    Answer = "Design pattern that delays object initialization until it's actually needed. Improves performance by avoiding unnecessary resource allocation and loading.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "Defers object creation until needed",
                                        "Reduces initial memory footprint",
                                        "Common in ORMs like Entity Framework",
                                        "Can improve startup performance"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 21,
                                    TopicId = 7,
                                    Question = "What is Redis?",
                                    Answer = "In-memory data structure store used as cache, database, and message broker. Provides high performance for read/write operations and supports various data types.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "In-memory key-value store",
                                        "Used for caching and session storage",
                                        "Supports complex data structures",
                                        "High performance and scalability"
                                    }
                                }
                            }
                        }
                    }
                },

                // Legacy & Framework Comparison Category
                new InterviewCategory
                {
                    Id = 6,
                    Name = "Framework Knowledge",
                    Icon = "📚",
                    Description = "Understanding different .NET frameworks and technologies",
                    Topics = new List<InterviewTopic>
                    {
                        new InterviewTopic
                        {
                            Id = 8,
                            CategoryId = 6,
                            Title = "Framework Comparison",
                            Questions = new List<InterviewQuestion>
                            {
                                new InterviewQuestion
                                {
                                    Id = 22,
                                    TopicId = 8,
                                    Question = "What is WebForms?",
                                    Answer = "Legacy ASP.NET framework that provides event-driven, page-based web development model similar to desktop applications. Largely replaced by MVC and now ASP.NET Core.",
                                    Difficulty = "Beginner",
                                    KeyPoints = new List<string>
                                    {
                                        "Event-driven web development model",
                                        "Page lifecycle with ViewState",
                                        "Server controls and postback model",
                                        "Legacy technology, superseded by MVC/Core"
                                    }
                                }
                            }
                        }
                    }
                },

                // Multithreading & Concurrency Category
                new InterviewCategory
                {
                    Id = 7,
                    Name = "Multithreading & Concurrency",
                    Icon = "⚡",
                    Description = "Thread management, async programming, and concurrency patterns",
                    Topics = new List<InterviewTopic>
                    {
                        new InterviewTopic
                        {
                            Id = 9,
                            CategoryId = 7,
                            Title = "Async Programming",
                            Questions = new List<InterviewQuestion>
                            {
                                new InterviewQuestion
                                {
                                    Id = 23,
                                    TopicId = 9,
                                    Question = "What's the difference between async void, async Task, and async Task<T>?",
                                    Answer = "async void: For event handlers only, can't be awaited, exceptions crash app. async Task: For methods that don't return values, can be awaited. async Task<T>: Returns a value, can be awaited.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "async void should only be used for event handlers",
                                        "async Task is awaitable, async void is not",
                                        "Exceptions in async void can crash the application",
                                        "async Task<T> returns a value asynchronously"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 24,
                                    TopicId = 9,
                                    Question = "How does async/await impact thread usage in ASP.NET Core?",
                                    Answer = "async/await frees up threads while waiting for I/O operations. Instead of blocking a thread, it returns the thread to the pool. When the operation completes, any available thread can continue execution.",
                                    Difficulty = "Advanced",
                                    KeyPoints = new List<string>
                                    {
                                        "Frees up threads during I/O operations",
                                        "Improves scalability by reducing thread pool starvation",
                                        "Continuation can run on any available thread",
                                        "Essential for high-concurrency web applications"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 25,
                                    TopicId = 9,
                                    Question = "When should you use ConfigureAwait(false) in async programming?",
                                    Answer = "Use ConfigureAwait(false) in library code to avoid deadlocks and improve performance. It prevents the continuation from being scheduled on the original synchronization context.",
                                    Difficulty = "Advanced",
                                    KeyPoints = new List<string>
                                    {
                                        "Prevents deadlocks in library code",
                                        "Avoids capturing synchronization context",
                                        "Improves performance by avoiding context switches",
                                        "Not needed in ASP.NET Core (no sync context by default)"
                                    }
                                }
                            }
                        },
                        new InterviewTopic
                        {
                            Id = 10,
                            CategoryId = 7,
                            Title = "Thread Management",
                            Questions = new List<InterviewQuestion>
                            {
                                new InterviewQuestion
                                {
                                    Id = 26,
                                    TopicId = 10,
                                    Question = "Difference between Thread, Task, and ValueTask.",
                                    Answer = "Thread: OS-level thread, heavyweight. Task: Lightweight abstraction over threads, supports async/await. ValueTask: Value type version of Task, reduces allocations for synchronous completions.",
                                    Difficulty = "Advanced",
                                    KeyPoints = new List<string>
                                    {
                                        "Thread: Direct OS thread manipulation",
                                        "Task: High-level abstraction with async support",
                                        "ValueTask: Performance optimization for hot paths",
                                        "ValueTask reduces heap allocations"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 27,
                                    TopicId = 10,
                                    Question = "How does the lock statement work internally? What are potential pitfalls?",
                                    Answer = "lock uses Monitor.Enter/Exit internally. Pitfalls: locking on public objects, different lock objects, nested locks causing deadlocks, and performance issues with fine-grained locking.",
                                    Difficulty = "Advanced",
                                    KeyPoints = new List<string>
                                    {
                                        "Compiles to Monitor.Enter/Exit calls",
                                        "Don't lock on public objects or value types",
                                        "Beware of deadlocks with nested locks",
                                        "Consider using SemaphoreSlim for async scenarios"
                                    }
                                }
                            }
                        }
                    }
                },

                // LINQ & Entity Framework Category
                new InterviewCategory
                {
                    Id = 8,
                    Name = "LINQ & Entity Framework",
                    Icon = "🔗",
                    Description = "Language Integrated Query and Object-Relational Mapping",
                    Topics = new List<InterviewTopic>
                    {
                        new InterviewTopic
                        {
                            Id = 11,
                            CategoryId = 8,
                            Title = "LINQ Fundamentals",
                            Questions = new List<InterviewQuestion>
                            {
                                new InterviewQuestion
                                {
                                    Id = 28,
                                    TopicId = 11,
                                    Question = "Difference between Select, SelectMany, and GroupBy in LINQ.",
                                    Answer = "Select: One-to-one transformation. SelectMany: Flattens nested collections (one-to-many). GroupBy: Groups elements by a key into IGrouping<TKey, TElement>.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "Select: transforms each element",
                                        "SelectMany: flattens nested sequences",
                                        "GroupBy: creates groups based on key",
                                        "SelectMany is essential for working with nested collections"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 29,
                                    TopicId = 11,
                                    Question = "Explain deferred execution vs immediate execution in LINQ.",
                                    Answer = "Deferred: Query isn't executed until enumerated (foreach, ToList()). Immediate: Query executes immediately (ToList, Count, First). Deferred allows query composition and optimization.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "Deferred: Query executed on enumeration",
                                        "Immediate: Query executed immediately",
                                        "Deferred enables query composition",
                                        "Be aware of multiple enumeration issues"
                                    }
                                }
                            }
                        },
                        new InterviewTopic
                        {
                            Id = 12,
                            CategoryId = 8,
                            Title = "Entity Framework Core",
                            Questions = new List<InterviewQuestion>
                            {
                                new InterviewQuestion
                                {
                                    Id = 30,
                                    TopicId = 12,
                                    Question = "How do you prevent N+1 query problems in EF Core?",
                                    Answer = "Use Include() for eager loading, Load() for explicit loading, or enable lazy loading. Also consider projection with Select() to load only needed data.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "Use Include() for related data",
                                        "Consider Select() projection for specific fields",
                                        "Enable lazy loading with caution",
                                        "Use Split queries for multiple includes"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 31,
                                    TopicId = 12,
                                    Question = "When would you use AsNoTracking() in EF Core?",
                                    Answer = "Use for read-only scenarios where you don't need change tracking. Improves performance by skipping change detection and reduces memory usage for large datasets.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "Use for read-only queries",
                                        "Improves query performance",
                                        "Reduces memory usage",
                                        "Entities can't be updated directly"
                                    }
                                }
                            }
                        }
                    }
                },

                // Design Patterns & Architecture Category
                new InterviewCategory
                {
                    Id = 9,
                    Name = "Design Patterns & Architecture",
                    Icon = "🏗️",
                    Description = "Software design patterns and architectural principles",
                    Topics = new List<InterviewTopic>
                    {
                        new InterviewTopic
                        {
                            Id = 13,
                            CategoryId = 9,
                            Title = "Common Patterns",
                            Questions = new List<InterviewQuestion>
                            {
                                new InterviewQuestion
                                {
                                    Id = 32,
                                    TopicId = 13,
                                    Question = "How would you implement the Repository Pattern in C#? Pros and cons?",
                                    Answer = "Repository abstracts data access with interface. Pros: testability, separation of concerns. Cons: added complexity, potential over-abstraction, EF Core already implements Unit of Work.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "Abstracts data access behind interface",
                                        "Improves testability with mocking",
                                        "Can add unnecessary complexity with EF Core",
                                        "Consider generic vs specific repositories"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 33,
                                    TopicId = 13,
                                    Question = "Difference between Factory, Builder, and Strategy design patterns in C#.",
                                    Answer = "Factory: Creates objects without specifying exact class. Builder: Constructs complex objects step by step. Strategy: Defines family of algorithms, makes them interchangeable.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "Factory: Object creation abstraction",
                                        "Builder: Step-by-step object construction",
                                        "Strategy: Interchangeable algorithms",
                                        "Each solves different design problems"
                                    }
                                }
                            }
                        },
                        new InterviewTopic
                        {
                            Id = 14,
                            CategoryId = 9,
                            Title = "Architectural Patterns",
                            Questions = new List<InterviewQuestion>
                            {
                                new InterviewQuestion
                                {
                                    Id = 34,
                                    TopicId = 14,
                                    Question = "Explain CQRS (Command Query Responsibility Segregation) and how it can be implemented in .NET.",
                                    Answer = "CQRS separates read and write operations into different models. Commands modify state, queries read state. Can be implemented with MediatR, separate databases, or event sourcing.",
                                    Difficulty = "Advanced",
                                    KeyPoints = new List<string>
                                    {
                                        "Separates command and query responsibilities",
                                        "Allows independent scaling of reads/writes",
                                        "Often paired with event sourcing",
                                        "Adds complexity, use when needed"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 35,
                                    TopicId = 14,
                                    Question = "Explain dependency injection and how you would implement it without a framework.",
                                    Answer = "DI inverts control by injecting dependencies rather than creating them. Manual implementation: use constructor injection, maintain dependency graph, resolve dependencies recursively.",
                                    Difficulty = "Advanced",
                                    KeyPoints = new List<string>
                                    {
                                        "Inversion of Control principle",
                                        "Constructor injection is preferred",
                                        "Requires dependency resolution logic",
                                        "Built-in DI container in .NET Core"
                                    }
                                }
                            }
                        }
                    }
                },

                // Testing Category
                new InterviewCategory
                {
                    Id = 10,
                    Name = "Testing & Quality Assurance",
                    Icon = "🧪",
                    Description = "Unit testing, integration testing, and quality practices",
                    Topics = new List<InterviewTopic>
                    {
                        new InterviewTopic
                        {
                            Id = 15,
                            CategoryId = 10,
                            Title = "Testing Fundamentals",
                            Questions = new List<InterviewQuestion>
                            {
                                new InterviewQuestion
                                {
                                    Id = 36,
                                    TopicId = 15,
                                    Question = "How do you mock DbContext for unit testing?",
                                    Answer = "Use EF Core In-Memory provider for testing, or mock IDbContext interface. Consider using TestContainers for integration tests with real databases.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "In-Memory provider for unit tests",
                                        "Mock interfaces, not concrete DbContext",
                                        "Consider TestContainers for integration tests",
                                        "Separate unit tests from integration tests"
                                    }
                                },
                                new InterviewQuestion
                                {
                                    Id = 37,
                                    TopicId = 15,
                                    Question = "What's the difference between unit test, integration test, and functional test?",
                                    Answer = "Unit: Single component in isolation. Integration: Multiple components working together. Functional: End-to-end user scenarios. Each has different scope and purpose.",
                                    Difficulty = "Beginner",
                                    KeyPoints = new List<string>
                                    {
                                        "Unit: Single component, fast execution",
                                        "Integration: Component interactions",
                                        "Functional: End-to-end user scenarios",
                                        "Testing pyramid: more unit, fewer functional"
                                    }
                                }
                            }
                        }
                    }
                },

                // SQL & Database Category
                new InterviewCategory
                {
                    Id = 11,
                    Name = "SQL & Database",
                    Icon = "🗄️",
                    Description = "SQL queries, database design, and optimization",
                    Topics = new List<InterviewTopic>
                    {
                        new InterviewTopic
                        {
                            Id = 16,
                            CategoryId = 11,
                            Title = "SQL Fundamentals",
                            Questions = new List<InterviewQuestion>
                            {
                                new InterviewQuestion
                                {
                                    Id = 38,
                                    TopicId = 16,
                                    Question = "What is the difference between WHERE and HAVING clause?",
                                    Answer = "WHERE filters rows before grouping, HAVING filters groups after GROUP BY. WHERE can't use aggregate functions, HAVING can.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "WHERE: filters individual rows",
                                        "HAVING: filters grouped results",
                                        "WHERE: before GROUP BY",
                                        "HAVING: after GROUP BY with aggregates"
                                    },
                                    CodeExample = @"-- WHERE clause
SELECT DepartmentId, EmployeeName, Salary 
FROM Employees 
WHERE Salary > 50000;

-- HAVING clause with GROUP BY
SELECT DepartmentId, AVG(Salary) as AvgSalary 
FROM Employees 
GROUP BY DepartmentId 
HAVING AVG(Salary) > 60000;

-- Combined WHERE and HAVING
SELECT DepartmentId, COUNT(*) as EmployeeCount, AVG(Salary) as AvgSalary
FROM Employees 
WHERE IsActive = 1  -- Filter rows first
GROUP BY DepartmentId 
HAVING COUNT(*) > 5;  -- Filter groups"
                                },
                                new InterviewQuestion
                                {
                                    Id = 39,
                                    TopicId = 16,
                                    Question = "Explain different types of JOINs in SQL",
                                    Answer = "INNER JOIN returns matching records from both tables. LEFT JOIN returns all from left table. RIGHT JOIN returns all from right table. FULL OUTER JOIN returns all records when there's a match in either table.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "INNER JOIN: only matching records",
                                        "LEFT JOIN: all from left, matching from right",
                                        "RIGHT JOIN: all from right, matching from left",
                                        "FULL OUTER JOIN: all records from both"
                                    },
                                    CodeExample = @"-- INNER JOIN
SELECT e.Name, d.DepartmentName 
FROM Employees e 
INNER JOIN Departments d ON e.DeptId = d.Id;

-- LEFT JOIN
SELECT e.Name, d.DepartmentName 
FROM Employees e 
LEFT JOIN Departments d ON e.DeptId = d.Id;
-- Shows all employees even if no department

-- RIGHT JOIN  
SELECT e.Name, d.DepartmentName 
FROM Employees e 
RIGHT JOIN Departments d ON e.DeptId = d.Id;
-- Shows all departments even if no employees

-- FULL OUTER JOIN
SELECT e.Name, d.DepartmentName 
FROM Employees e 
FULL OUTER JOIN Departments d ON e.DeptId = d.Id;
-- Shows all employees and all departments"
                                },
                                new InterviewQuestion
                                {
                                    Id = 40,
                                    TopicId = 16,
                                    Question = "What is a Self Join? Give an example",
                                    Answer = "Self Join is when a table is joined with itself using aliases. Commonly used for hierarchical data like employee-manager relationships.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "Table joined with itself",
                                        "Requires table aliases",
                                        "Used for hierarchical data",
                                        "Finding relationships within same table"
                                    },
                                    CodeExample = @"-- Find employees and their managers
SELECT 
    e.EmployeeId,
    e.Name AS EmployeeName,
    m.Name AS ManagerName
FROM Employees e
LEFT JOIN Employees m ON e.ManagerId = m.EmployeeId;

-- Find colleagues (employees with same manager)
SELECT 
    e1.Name AS Employee1,
    e2.Name AS Employee2,
    m.Name AS SharedManager
FROM Employees e1
INNER JOIN Employees e2 
    ON e1.ManagerId = e2.ManagerId 
    AND e1.EmployeeId < e2.EmployeeId
INNER JOIN Employees m 
    ON e1.ManagerId = m.EmployeeId;"
                                },
                                new InterviewQuestion
                                {
                                    Id = 41,
                                    TopicId = 16,
                                    Question = "What is the difference between UNION and UNION ALL?",
                                    Answer = "UNION combines results from multiple queries and removes duplicates. UNION ALL combines results but keeps all rows including duplicates, making it faster.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "UNION: removes duplicate rows",
                                        "UNION ALL: keeps all rows",
                                        "UNION ALL is faster",
                                        "Both require same number of columns"
                                    },
                                    CodeExample = @"-- UNION (removes duplicates)
SELECT City FROM Customers
UNION
SELECT City FROM Suppliers
ORDER BY City;

-- UNION ALL (keeps duplicates)
SELECT ProductName, 'Customer' as Source FROM CustomerOrders
UNION ALL
SELECT ProductName, 'Supplier' as Source FROM SupplierOrders;

-- Practical example: Active and Inactive users
SELECT UserId, Name, 'Active' as Status 
FROM Users WHERE IsActive = 1
UNION ALL
SELECT UserId, Name, 'Inactive' as Status 
FROM Users WHERE IsActive = 0;"
                                }
                            }
                        },
                        new InterviewTopic
                        {
                            Id = 17,
                            CategoryId = 11,
                            Title = "Advanced SQL",
                            Questions = new List<InterviewQuestion>
                            {
                                new InterviewQuestion
                                {
                                    Id = 42,
                                    TopicId = 17,
                                    Question = "Explain Window Functions in SQL",
                                    Answer = "Window functions perform calculations across a set of rows related to the current row. Unlike GROUP BY, they don't collapse rows. Common functions: ROW_NUMBER(), RANK(), DENSE_RANK(), LAG(), LEAD().",
                                    Difficulty = "Advanced",
                                    KeyPoints = new List<string>
                                    {
                                        "Calculate over a set of rows",
                                        "Don't reduce number of rows",
                                        "OVER clause defines the window",
                                        "PARTITION BY and ORDER BY control behavior"
                                    },
                                    CodeExample = @"-- ROW_NUMBER() - Sequential numbering
SELECT 
    Name,
    Department,
    Salary,
    ROW_NUMBER() OVER (PARTITION BY Department ORDER BY Salary DESC) as RowNum
FROM Employees;

-- RANK() and DENSE_RANK()
SELECT 
    Name,
    Score,
    RANK() OVER (ORDER BY Score DESC) as Rank,
    DENSE_RANK() OVER (ORDER BY Score DESC) as DenseRank
FROM Students;
-- RANK: 1,2,2,4 (skips 3)
-- DENSE_RANK: 1,2,2,3 (no skip)

-- LAG() and LEAD() - Access previous/next rows
SELECT 
    OrderDate,
    OrderAmount,
    LAG(OrderAmount, 1) OVER (ORDER BY OrderDate) as PreviousOrder,
    LEAD(OrderAmount, 1) OVER (ORDER BY OrderDate) as NextOrder
FROM Orders;

-- Running total
SELECT 
    OrderDate,
    OrderAmount,
    SUM(OrderAmount) OVER (ORDER BY OrderDate) as RunningTotal
FROM Orders;"
                                },
                                new InterviewQuestion
                                {
                                    Id = 43,
                                    TopicId = 17,
                                    Question = "What are CTEs (Common Table Expressions)?",
                                    Answer = "CTEs are named temporary result sets defined within a SELECT, INSERT, UPDATE, or DELETE statement. They improve readability and can be referenced multiple times within a query.",
                                    Difficulty = "Advanced",
                                    KeyPoints = new List<string>
                                    {
                                        "Temporary named result set",
                                        "Defined using WITH clause",
                                        "More readable than subqueries",
                                        "Can be recursive for hierarchical data"
                                    },
                                    CodeExample = @"-- Simple CTE
WITH SalesSummary AS (
    SELECT 
        SalesPersonId,
        SUM(Amount) as TotalSales
    FROM Sales
    WHERE Year = 2023
    GROUP BY SalesPersonId
)
SELECT 
    e.Name,
    s.TotalSales
FROM Employees e
JOIN SalesSummary s ON e.Id = s.SalesPersonId
WHERE s.TotalSales > 100000;

-- Recursive CTE for hierarchy
WITH EmployeeHierarchy AS (
    -- Anchor: Top-level employees
    SELECT 
        EmployeeId, 
        Name, 
        ManagerId, 
        0 as Level
    FROM Employees
    WHERE ManagerId IS NULL
    
    UNION ALL
    
    -- Recursive: Employees under managers
    SELECT 
        e.EmployeeId,
        e.Name,
        e.ManagerId,
        h.Level + 1
    FROM Employees e
    INNER JOIN EmployeeHierarchy h ON e.ManagerId = h.EmployeeId
)
SELECT * FROM EmployeeHierarchy
ORDER BY Level, Name;"
                                },
                                new InterviewQuestion
                                {
                                    Id = 44,
                                    TopicId = 17,
                                    Question = "How do you find duplicate records in a table?",
                                    Answer = "Use GROUP BY with HAVING COUNT(*) > 1 to identify duplicates. Can also use window functions like ROW_NUMBER() to find and handle duplicates.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "GROUP BY with HAVING COUNT",
                                        "Window functions for detailed analysis",
                                        "Self join approach",
                                        "Consider what defines a duplicate"
                                    },
                                    CodeExample = @"-- Find duplicate emails
SELECT Email, COUNT(*) as DuplicateCount
FROM Users
GROUP BY Email
HAVING COUNT(*) > 1;

-- Find all duplicate records with details
WITH DuplicateEmails AS (
    SELECT Email
    FROM Users
    GROUP BY Email
    HAVING COUNT(*) > 1
)
SELECT u.*
FROM Users u
INNER JOIN DuplicateEmails d ON u.Email = d.Email
ORDER BY u.Email, u.UserId;

-- Using ROW_NUMBER() to identify duplicates
WITH RankedUsers AS (
    SELECT 
        *,
        ROW_NUMBER() OVER (PARTITION BY Email ORDER BY CreatedDate) as rn
    FROM Users
)
SELECT * FROM RankedUsers
WHERE rn > 1;  -- These are the duplicates

-- Delete duplicates keeping oldest
WITH RankedUsers AS (
    SELECT 
        UserId,
        ROW_NUMBER() OVER (PARTITION BY Email ORDER BY CreatedDate) as rn
    FROM Users
)
DELETE FROM Users
WHERE UserId IN (
    SELECT UserId FROM RankedUsers WHERE rn > 1
);"
                                },
                                new InterviewQuestion
                                {
                                    Id = 45,
                                    TopicId = 17,
                                    Question = "What are indexes and how do they improve performance?",
                                    Answer = "Indexes are database objects that improve query performance by providing quick access paths to data. Like a book index, they help locate data without scanning entire tables.",
                                    Difficulty = "Advanced",
                                    KeyPoints = new List<string>
                                    {
                                        "Speed up data retrieval",
                                        "Slow down inserts/updates",
                                        "Types: Clustered, Non-clustered, Unique",
                                        "Consider selectivity and usage patterns"
                                    },
                                    CodeExample = @"-- Create a simple index
CREATE INDEX IX_Employees_LastName 
ON Employees(LastName);

-- Composite index for multiple columns
CREATE INDEX IX_Orders_CustomerDate 
ON Orders(CustomerId, OrderDate DESC);

-- Unique index (enforces uniqueness)
CREATE UNIQUE INDEX IX_Users_Email 
ON Users(Email);

-- Filtered index (SQL Server)
CREATE INDEX IX_Orders_Recent 
ON Orders(OrderDate, CustomerId)
WHERE OrderDate >= '2023-01-01';

-- Include columns (covering index)
CREATE INDEX IX_Products_Category
ON Products(CategoryId)
INCLUDE (ProductName, Price);

-- Check index usage
SELECT 
    i.name AS IndexName,
    s.user_seeks + s.user_scans + s.user_lookups AS TotalUsage,
    s.user_updates AS Updates
FROM sys.dm_db_index_usage_stats s
INNER JOIN sys.indexes i ON i.object_id = s.object_id
WHERE database_id = DB_ID();"
                                }
                            }
                        },
                        new InterviewTopic
                        {
                            Id = 18,
                            CategoryId = 11,
                            Title = "Database Design & Optimization",
                            Questions = new List<InterviewQuestion>
                            {
                                new InterviewQuestion
                                {
                                    Id = 46,
                                    TopicId = 18,
                                    Question = "What is database normalization? Explain different normal forms",
                                    Answer = "Normalization organizes data to reduce redundancy and dependency. 1NF: Atomic values. 2NF: No partial dependencies. 3NF: No transitive dependencies. BCNF: Every determinant is a candidate key.",
                                    Difficulty = "Advanced",
                                    KeyPoints = new List<string>
                                    {
                                        "1NF: Eliminate repeating groups",
                                        "2NF: Remove partial dependencies",
                                        "3NF: Remove transitive dependencies",
                                        "Balance normalization with performance"
                                    },
                                    CodeExample = @"-- Unnormalized (0NF)
Orders: OrderId, Customer(Name, Address, Phone), Products(Item1, Price1, Item2, Price2)

-- 1NF: Atomic values, no repeating groups
Orders: OrderId, CustomerName, CustomerAddress, CustomerPhone
OrderItems: OrderId, ProductName, Price

-- 2NF: No partial dependencies (separate customer)
Customers: CustomerId, Name, Address, Phone
Orders: OrderId, CustomerId, OrderDate
OrderItems: OrderId, ProductId, Quantity, Price

-- 3NF: No transitive dependencies
Customers: CustomerId, Name
CustomerAddresses: CustomerId, Address, Phone
Products: ProductId, ProductName, CategoryId
Categories: CategoryId, CategoryName
Orders: OrderId, CustomerId, OrderDate
OrderItems: OrderId, ProductId, Quantity, UnitPrice

-- BCNF Example
-- If TeacherId determines Subject:
Classes: ClassId, TeacherId, RoomNumber
Teachers: TeacherId, TeacherName, Subject"
                                },
                                new InterviewQuestion
                                {
                                    Id = 47,
                                    TopicId = 18,
                                    Question = "Explain ACID properties in database transactions",
                                    Answer = "ACID ensures reliable database transactions. Atomicity: all or nothing. Consistency: data integrity maintained. Isolation: concurrent transactions don't interfere. Durability: committed changes persist.",
                                    Difficulty = "Intermediate",
                                    KeyPoints = new List<string>
                                    {
                                        "Atomicity: transaction completes fully or not at all",
                                        "Consistency: maintains data integrity rules",
                                        "Isolation: prevents concurrent transaction conflicts",
                                        "Durability: changes survive system failures"
                                    },
                                    CodeExample = @"-- Transaction demonstrating ACID
BEGIN TRANSACTION;

DECLARE @AccountFrom INT = 1001;
DECLARE @AccountTo INT = 1002;
DECLARE @Amount DECIMAL(10,2) = 500.00;

-- Atomicity: Both operations succeed or both fail
UPDATE Accounts 
SET Balance = Balance - @Amount 
WHERE AccountId = @AccountFrom;

UPDATE Accounts 
SET Balance = Balance + @Amount 
WHERE AccountId = @AccountTo;

-- Consistency: Check business rules
IF EXISTS (SELECT 1 FROM Accounts WHERE AccountId = @AccountFrom AND Balance < 0)
BEGIN
    ROLLBACK TRANSACTION;
    PRINT 'Insufficient funds';
    RETURN;
END

COMMIT TRANSACTION;

-- Isolation levels
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
-- READ UNCOMMITTED: Dirty reads allowed
-- READ COMMITTED: No dirty reads
-- REPEATABLE READ: No dirty/non-repeatable reads  
-- SERIALIZABLE: No dirty/non-repeatable/phantom reads

-- Durability: Use transaction log
CHECKPOINT; -- Forces log to disk"
                                },
                                new InterviewQuestion
                                {
                                    Id = 48,
                                    TopicId = 18,
                                    Question = "How do you optimize a slow SQL query?",
                                    Answer = "Analyze execution plan, add appropriate indexes, rewrite query logic, update statistics, consider denormalization, use query hints if needed.",
                                    Difficulty = "Advanced",
                                    KeyPoints = new List<string>
                                    {
                                        "Check execution plan for bottlenecks",
                                        "Add missing indexes",
                                        "Avoid SELECT *",
                                        "Use appropriate JOIN types",
                                        "Update table statistics"
                                    },
                                    CodeExample = @"-- 1. Check execution plan
SET STATISTICS IO ON;
SET STATISTICS TIME ON;

-- 2. Identify slow query
SELECT c.Name, COUNT(o.OrderId) as OrderCount
FROM Customers c
LEFT JOIN Orders o ON c.CustomerId = o.CustomerId
WHERE o.OrderDate >= '2023-01-01'
GROUP BY c.CustomerId, c.Name;

-- 3. Add index for WHERE clause
CREATE INDEX IX_Orders_OrderDate_CustomerId 
ON Orders(OrderDate, CustomerId);

-- 4. Rewrite using EXISTS (sometimes faster)
SELECT c.Name, 
    (SELECT COUNT(*) FROM Orders o 
     WHERE o.CustomerId = c.CustomerId 
     AND o.OrderDate >= '2023-01-01') as OrderCount
FROM Customers c
WHERE EXISTS (
    SELECT 1 FROM Orders o 
    WHERE o.CustomerId = c.CustomerId 
    AND o.OrderDate >= '2023-01-01'
);

-- 5. Use indexed view for complex aggregations
CREATE VIEW vw_CustomerOrderSummary
WITH SCHEMABINDING
AS
SELECT c.CustomerId, c.Name, COUNT_BIG(*) as OrderCount
FROM dbo.Customers c
INNER JOIN dbo.Orders o ON c.CustomerId = o.CustomerId
WHERE o.OrderDate >= '2023-01-01'
GROUP BY c.CustomerId, c.Name;

CREATE UNIQUE CLUSTERED INDEX IX_vw_CustomerOrderSummary 
ON vw_CustomerOrderSummary(CustomerId);

-- 6. Update statistics
UPDATE STATISTICS Orders WITH FULLSCAN;"
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}