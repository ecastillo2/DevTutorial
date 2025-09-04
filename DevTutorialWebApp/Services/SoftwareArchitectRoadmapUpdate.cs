using System.Collections.Generic;
using System.Linq;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Services
{
    public partial class RoadmapService
    {
        private void UpdateSoftwareArchitectRoadmap(List<Roadmap> roadmaps)
        {
            var architectRoadmap = roadmaps.FirstOrDefault(r => r.Id == 10);
            if (architectRoadmap != null)
            {
                // Update the Software Architect roadmap with comprehensive structure
                architectRoadmap.Title = "Software Architect";
                architectRoadmap.Description = "Master the art and science of designing scalable, maintainable, and secure software systems";
                architectRoadmap.Duration = "12-24 months";
                architectRoadmap.Difficulty = "Advanced to Expert";
                architectRoadmap.Context = "Software Architecture is about making fundamental structural choices that are costly to change once implemented. This comprehensive path covers architecture principles, patterns, styles, and modern practices for designing systems that meet both functional and non-functional requirements.";
                
                architectRoadmap.Prerequisites = new List<string>
                {
                    "5+ years of software development experience",
                    "Strong understanding of multiple programming paradigms",
                    "Experience with system design and distributed systems",
                    "Knowledge of various technology stacks and frameworks"
                };
                
                architectRoadmap.CareerPaths = new List<string>
                {
                    "Software Architect ($130K-$200K)",
                    "Solutions Architect ($140K-$220K)",
                    "Enterprise Architect ($150K-$250K)",
                    "Principal Engineer ($150K-$280K)",
                    "Chief Technology Officer ($180K-$350K)"
                };

                // Replace existing steps with comprehensive 16-category structure
                architectRoadmap.Steps = new List<RoadmapStep>
                {
                    // 1. Foundations of Software Architecture
                    new RoadmapStep
                    {
                        Id = 1001,
                        RoadmapId = 10,
                        Title = "Foundations of Software Architecture",
                        Duration = "2-3 weeks",
                        Content = "Understand the fundamental concepts and role of software architecture",
                        KeyConcepts = new List<string> 
                        { 
                            "Architecture vs Design vs Implementation",
                            "Architecture Decision Records",
                            "4+1 View Model",
                            "IEEE/ISO Standards",
                            "Architectural Perspectives"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 10011, StepId = 1001, Description = "Define software architecture and architect roles" },
                            new LearningObjective { Id = 10012, StepId = 1001, Description = "Create and use Architecture Decision Records" },
                            new LearningObjective { Id = 10013, StepId = 1001, Description = "Apply 4+1 view model to system design" },
                            new LearningObjective { Id = 10014, StepId = 1001, Description = "Understand ISO 42010 standards" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 10011, StepId = 1001, Title = "Software Architecture in Practice", Type = "Book", Url = "https://www.amazon.com/Software-Architecture-Practice-3rd-Engineering/dp/0321815734" },
                            new Resource { Id = 10012, StepId = 1001, Title = "Architecture Decision Records", Type = "Article", Url = "https://adr.github.io/" }
                        }
                    },

                    // 2. Architecture Principles
                    new RoadmapStep
                    {
                        Id = 1002,
                        RoadmapId = 10,
                        Title = "Architecture Principles",
                        Duration = "3-4 weeks",
                        Content = "Master fundamental principles that guide architectural decisions",
                        KeyConcepts = new List<string>
                        {
                            "SOLID Principles",
                            "DRY, KISS, YAGNI",
                            "Separation of Concerns",
                            "Cohesion & Coupling",
                            "Dependency Inversion"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 10021, StepId = 1002, Description = "Apply SOLID principles in architecture" },
                            new LearningObjective { Id = 10022, StepId = 1002, Description = "Balance cohesion and coupling in design" },
                            new LearningObjective { Id = 10023, StepId = 1002, Description = "Implement separation of concerns" },
                            new LearningObjective { Id = 10024, StepId = 1002, Description = "Use dependency inversion effectively" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 10021, StepId = 1002, Title = "Clean Architecture", Type = "Book", Url = "https://www.amazon.com/Clean-Architecture-Craftsmans-Software-Structure/dp/0134494164" },
                            new Resource { Id = 10022, StepId = 1002, Title = "Architecture Principles", Type = "Course", Url = "https://www.pluralsight.com/courses/software-architecture-fundamentals" }
                        }
                    },

                    // 3. Architecture Styles
                    new RoadmapStep
                    {
                        Id = 1003,
                        RoadmapId = 10,
                        Title = "Architecture Styles",
                        Duration = "4-5 weeks",
                        Content = "Explore various architectural styles and their trade-offs",
                        KeyConcepts = new List<string>
                        {
                            "Monolithic vs Microservices",
                            "Event-Driven Architecture",
                            "Serverless & Cloud-Native",
                            "Service-Oriented (SOA)",
                            "Reactive Architecture"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 10031, StepId = 1003, Description = "Compare monolithic and microservices architectures" },
                            new LearningObjective { Id = 10032, StepId = 1003, Description = "Design event-driven systems" },
                            new LearningObjective { Id = 10033, StepId = 1003, Description = "Implement serverless architectures" },
                            new LearningObjective { Id = 10034, StepId = 1003, Description = "Choose appropriate architecture styles" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 10031, StepId = 1003, Title = "Building Microservices", Type = "Book", Url = "https://www.oreilly.com/library/view/building-microservices-2nd/9781492034018/" },
                            new Resource { Id = 10032, StepId = 1003, Title = "Event-Driven Architecture", Type = "Article", Url = "https://martinfowler.com/articles/201701-event-driven.html" }
                        }
                    },

                    // 4. Enterprise Architecture Frameworks
                    new RoadmapStep
                    {
                        Id = 1004,
                        RoadmapId = 10,
                        Title = "Enterprise Architecture Frameworks",
                        Duration = "3-4 weeks",
                        Content = "Learn enterprise-level architecture frameworks and methodologies",
                        KeyConcepts = new List<string>
                        {
                            "TOGAF Framework",
                            "Zachman Framework",
                            "ArchiMate Notation",
                            "FEAF",
                            "Gartner EA"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 10041, StepId = 1004, Description = "Apply TOGAF methodology" },
                            new LearningObjective { Id = 10042, StepId = 1004, Description = "Use ArchiMate for modeling" },
                            new LearningObjective { Id = 10043, StepId = 1004, Description = "Understand Zachman Framework" },
                            new LearningObjective { Id = 10044, StepId = 1004, Description = "Compare EA frameworks" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 10041, StepId = 1004, Title = "TOGAF Documentation", Type = "Documentation", Url = "https://www.opengroup.org/togaf" },
                            new Resource { Id = 10042, StepId = 1004, Title = "ArchiMate Guide", Type = "Guide", Url = "https://www.opengroup.org/archimate" }
                        }
                    },

                    // 5. Domain-Driven Design (DDD)
                    new RoadmapStep
                    {
                        Id = 1005,
                        RoadmapId = 10,
                        Title = "Domain-Driven Design (DDD)",
                        Duration = "4-5 weeks",
                        Content = "Master DDD principles for complex domain modeling",
                        KeyConcepts = new List<string>
                        {
                            "Bounded Contexts",
                            "Aggregates & Entities",
                            "Domain Events",
                            "Ubiquitous Language",
                            "Strategic Design"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 10051, StepId = 1005, Description = "Define bounded contexts effectively" },
                            new LearningObjective { Id = 10052, StepId = 1005, Description = "Design aggregates and entities" },
                            new LearningObjective { Id = 10053, StepId = 1005, Description = "Implement domain events" },
                            new LearningObjective { Id = 10054, StepId = 1005, Description = "Apply strategic DDD patterns" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 10051, StepId = 1005, Title = "Domain-Driven Design", Type = "Book", Url = "https://www.amazon.com/Domain-Driven-Design-Tackling-Complexity-Software/dp/0321125215" },
                            new Resource { Id = 10052, StepId = 1005, Title = "Implementing DDD", Type = "Book", Url = "https://www.amazon.com/Implementing-Domain-Driven-Design-Vaughn-Vernon/dp/0321834577" }
                        }
                    },

                    // 6. Architectural Patterns
                    new RoadmapStep
                    {
                        Id = 1006,
                        RoadmapId = 10,
                        Title = "Architectural Patterns",
                        Duration = "5-6 weeks",
                        Content = "Learn essential architectural and design patterns",
                        KeyConcepts = new List<string>
                        {
                            "Gang of Four Patterns",
                            "Enterprise Patterns",
                            "CQRS & Event Sourcing",
                            "Saga Pattern",
                            "Circuit Breaker"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 10061, StepId = 1006, Description = "Implement creational, structural, and behavioral patterns" },
                            new LearningObjective { Id = 10062, StepId = 1006, Description = "Apply CQRS and Event Sourcing" },
                            new LearningObjective { Id = 10063, StepId = 1006, Description = "Use distributed patterns (Saga, Circuit Breaker)" },
                            new LearningObjective { Id = 10064, StepId = 1006, Description = "Choose appropriate patterns for problems" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 10061, StepId = 1006, Title = "Design Patterns", Type = "Book", Url = "https://www.amazon.com/Design-Patterns-Elements-Reusable-Object-Oriented/dp/0201633612" },
                            new Resource { Id = 10062, StepId = 1006, Title = "Enterprise Integration Patterns", Type = "Book", Url = "https://www.enterpriseintegrationpatterns.com/" }
                        }
                    },

                    // 7. Cloud & Distributed Systems
                    new RoadmapStep
                    {
                        Id = 1007,
                        RoadmapId = 10,
                        Title = "Cloud & Distributed Systems",
                        Duration = "5-6 weeks",
                        Content = "Design for cloud-native and distributed environments",
                        KeyConcepts = new List<string>
                        {
                            "Cloud Service Models",
                            "Containerization & K8s",
                            "Service Mesh",
                            "CAP Theorem",
                            "Message Brokers"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 10071, StepId = 1007, Description = "Design multi-cloud architectures" },
                            new LearningObjective { Id = 10072, StepId = 1007, Description = "Implement containerized solutions" },
                            new LearningObjective { Id = 10073, StepId = 1007, Description = "Handle distributed transactions" },
                            new LearningObjective { Id = 10074, StepId = 1007, Description = "Apply CAP theorem in design" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 10071, StepId = 1007, Title = "Cloud Architecture Patterns", Type = "Book", Url = "https://docs.microsoft.com/azure/architecture/patterns/" },
                            new Resource { Id = 10072, StepId = 1007, Title = "Designing Distributed Systems", Type = "Book", Url = "https://www.oreilly.com/library/view/designing-distributed-systems/9781491983638/" }
                        }
                    },

                    // 8. Non-Functional Requirements (NFRs)
                    new RoadmapStep
                    {
                        Id = 1008,
                        RoadmapId = 10,
                        Title = "Non-Functional Requirements (NFRs)",
                        Duration = "4-5 weeks",
                        Content = "Design systems that meet quality attributes",
                        KeyConcepts = new List<string>
                        {
                            "Performance & Scalability",
                            "Availability & Reliability",
                            "Security Requirements",
                            "Maintainability",
                            "Observability"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 10081, StepId = 1008, Description = "Define and measure NFRs" },
                            new LearningObjective { Id = 10082, StepId = 1008, Description = "Design for high availability" },
                            new LearningObjective { Id = 10083, StepId = 1008, Description = "Implement observability" },
                            new LearningObjective { Id = 10084, StepId = 1008, Description = "Balance competing NFRs" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 10081, StepId = 1008, Title = "Site Reliability Engineering", Type = "Book", Url = "https://sre.google/books/" },
                            new Resource { Id = 10082, StepId = 1008, Title = "Release It!", Type = "Book", Url = "https://pragprog.com/titles/mnee2/release-it-second-edition/" }
                        }
                    },

                    // 9. Integration & Interoperability
                    new RoadmapStep
                    {
                        Id = 1009,
                        RoadmapId = 10,
                        Title = "Integration & Interoperability",
                        Duration = "3-4 weeks",
                        Content = "Design systems that integrate effectively with others",
                        KeyConcepts = new List<string>
                        {
                            "REST API Design",
                            "GraphQL & gRPC",
                            "Event-Driven Integration",
                            "API Gateways",
                            "Data Integration"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 10091, StepId = 1009, Description = "Design RESTful APIs" },
                            new LearningObjective { Id = 10092, StepId = 1009, Description = "Implement GraphQL schemas" },
                            new LearningObjective { Id = 10093, StepId = 1009, Description = "Use event-driven integration" },
                            new LearningObjective { Id = 10094, StepId = 1009, Description = "Design API gateway strategies" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 10091, StepId = 1009, Title = "RESTful Web APIs", Type = "Book", Url = "https://www.oreilly.com/library/view/restful-web-apis/9781449359713/" },
                            new Resource { Id = 10092, StepId = 1009, Title = "API Design Patterns", Type = "Book", Url = "https://www.manning.com/books/api-design-patterns" }
                        }
                    },

                    // 10. Security Architecture
                    new RoadmapStep
                    {
                        Id = 1010,
                        RoadmapId = 10,
                        Title = "Security Architecture",
                        Duration = "4-5 weeks",
                        Content = "Design secure systems from the ground up",
                        KeyConcepts = new List<string>
                        {
                            "Zero Trust Architecture",
                            "Identity & Access Management",
                            "OAuth2/OIDC",
                            "Threat Modeling",
                            "OWASP Top 10"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 10101, StepId = 1010, Description = "Implement Zero Trust principles" },
                            new LearningObjective { Id = 10102, StepId = 1010, Description = "Design IAM solutions" },
                            new LearningObjective { Id = 10103, StepId = 1010, Description = "Perform threat modeling" },
                            new LearningObjective { Id = 10104, StepId = 1010, Description = "Address OWASP vulnerabilities" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 10101, StepId = 1010, Title = "Threat Modeling", Type = "Book", Url = "https://www.amazon.com/Threat-Modeling-Designing-Adam-Shostack/dp/1118809998" },
                            new Resource { Id = 10102, StepId = 1010, Title = "Zero Trust Networks", Type = "Book", Url = "https://www.oreilly.com/library/view/zero-trust-networks/9781491962183/" }
                        }
                    },

                    // 11. Data & Storage Architecture
                    new RoadmapStep
                    {
                        Id = 1011,
                        RoadmapId = 10,
                        Title = "Data & Storage Architecture",
                        Duration = "4-5 weeks",
                        Content = "Design data architectures for various use cases",
                        KeyConcepts = new List<string>
                        {
                            "OLTP vs OLAP",
                            "Data Lakes & Warehouses",
                            "Polyglot Persistence",
                            "Database Sharding",
                            "Caching Strategies"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 10111, StepId = 1011, Description = "Choose appropriate data stores" },
                            new LearningObjective { Id = 10112, StepId = 1011, Description = "Design data lakes and warehouses" },
                            new LearningObjective { Id = 10113, StepId = 1011, Description = "Implement polyglot persistence" },
                            new LearningObjective { Id = 10114, StepId = 1011, Description = "Design caching layers" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 10111, StepId = 1011, Title = "Designing Data-Intensive Applications", Type = "Book", Url = "https://dataintensive.net/" },
                            new Resource { Id = 10112, StepId = 1011, Title = "NoSQL Distilled", Type = "Book", Url = "https://martinfowler.com/books/nosql.html" }
                        }
                    },

                    // 12. DevOps & Architecture
                    new RoadmapStep
                    {
                        Id = 1012,
                        RoadmapId = 10,
                        Title = "DevOps & Architecture",
                        Duration = "3-4 weeks",
                        Content = "Align architecture with DevOps practices",
                        KeyConcepts = new List<string>
                        {
                            "CI/CD Pipelines",
                            "Infrastructure as Code",
                            "GitOps",
                            "Deployment Strategies",
                            "Observability Stack"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 10121, StepId = 1012, Description = "Design for continuous delivery" },
                            new LearningObjective { Id = 10122, StepId = 1012, Description = "Implement IaC practices" },
                            new LearningObjective { Id = 10123, StepId = 1012, Description = "Design deployment pipelines" },
                            new LearningObjective { Id = 10124, StepId = 1012, Description = "Build observability solutions" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 10121, StepId = 1012, Title = "Continuous Delivery", Type = "Book", Url = "https://continuousdelivery.com/" },
                            new Resource { Id = 10122, StepId = 1012, Title = "Infrastructure as Code", Type = "Book", Url = "https://www.oreilly.com/library/view/infrastructure-as-code/9781491924334/" }
                        }
                    },

                    // 13. Modern Architectural Practices
                    new RoadmapStep
                    {
                        Id = 1013,
                        RoadmapId = 10,
                        Title = "Modern Architectural Practices",
                        Duration = "4-5 weeks",
                        Content = "Apply modern architectural approaches and methodologies",
                        KeyConcepts = new List<string>
                        {
                            "Clean Architecture",
                            "Hexagonal Architecture",
                            "Event-Driven Microservices",
                            "Serverless-First",
                            "AI/ML Architecture"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 10131, StepId = 1013, Description = "Implement Clean Architecture" },
                            new LearningObjective { Id = 10132, StepId = 1013, Description = "Apply Hexagonal Architecture" },
                            new LearningObjective { Id = 10133, StepId = 1013, Description = "Design event-driven microservices" },
                            new LearningObjective { Id = 10134, StepId = 1013, Description = "Architect AI/ML systems" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 10131, StepId = 1013, Title = "Get Your Hands Dirty on Clean Architecture", Type = "Book", Url = "https://reflectoring.io/book/" },
                            new Resource { Id = 10132, StepId = 1013, Title = "Building Event-Driven Microservices", Type = "Book", Url = "https://www.oreilly.com/library/view/building-event-driven-microservices/9781492057888/" }
                        }
                    },

                    // 14. Performance & Optimization
                    new RoadmapStep
                    {
                        Id = 1014,
                        RoadmapId = 10,
                        Title = "Performance & Optimization",
                        Duration = "3-4 weeks",
                        Content = "Design and optimize for performance at scale",
                        KeyConcepts = new List<string>
                        {
                            "Load Balancing Strategies",
                            "CDN Architecture",
                            "Query Optimization",
                            "Distributed Caching",
                            "Performance Testing"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 10141, StepId = 1014, Description = "Design load balancing solutions" },
                            new LearningObjective { Id = 10142, StepId = 1014, Description = "Implement CDN strategies" },
                            new LearningObjective { Id = 10143, StepId = 1014, Description = "Optimize database performance" },
                            new LearningObjective { Id = 10144, StepId = 1014, Description = "Design for horizontal scaling" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 10141, StepId = 1014, Title = "High Performance Browser Networking", Type = "Book", Url = "https://hpbn.co/" },
                            new Resource { Id = 10142, StepId = 1014, Title = "Systems Performance", Type = "Book", Url = "https://www.brendangregg.com/systems-performance-2nd-edition-book.html" }
                        }
                    },

                    // 15. Documentation & Modeling
                    new RoadmapStep
                    {
                        Id = 1015,
                        RoadmapId = 10,
                        Title = "Documentation & Modeling",
                        Duration = "2-3 weeks",
                        Content = "Communicate architecture effectively through documentation",
                        KeyConcepts = new List<string>
                        {
                            "C4 Model",
                            "UML Diagrams",
                            "ADRs",
                            "System Context Diagrams",
                            "Architecture Katas"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 10151, StepId = 1015, Description = "Create C4 model diagrams" },
                            new LearningObjective { Id = 10152, StepId = 1015, Description = "Document architectural decisions" },
                            new LearningObjective { Id = 10153, StepId = 1015, Description = "Use appropriate UML diagrams" },
                            new LearningObjective { Id = 10154, StepId = 1015, Description = "Communicate architecture to stakeholders" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 10151, StepId = 1015, Title = "C4 Model", Type = "Documentation", Url = "https://c4model.com/" },
                            new Resource { Id = 10152, StepId = 1015, Title = "Documenting Software Architecture", Type = "Article", Url = "https://www.viewpoints-and-perspectives.info/" }
                        }
                    },

                    // 16. Emerging & Specialized Areas
                    new RoadmapStep
                    {
                        Id = 1016,
                        RoadmapId = 10,
                        Title = "Emerging & Specialized Areas",
                        Duration = "3-4 weeks",
                        Content = "Explore cutting-edge architectural trends and technologies",
                        KeyConcepts = new List<string>
                        {
                            "Quantum Computing Architecture",
                            "Blockchain Architecture",
                            "Edge Computing",
                            "Green Software",
                            "Chaos Engineering"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 10161, StepId = 1016, Description = "Design for edge computing scenarios" },
                            new LearningObjective { Id = 10162, StepId = 1016, Description = "Apply chaos engineering principles" },
                            new LearningObjective { Id = 10163, StepId = 1016, Description = "Consider sustainability in architecture" },
                            new LearningObjective { Id = 10164, StepId = 1016, Description = "Explore quantum and blockchain architectures" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 10161, StepId = 1016, Title = "Chaos Engineering", Type = "Book", Url = "https://www.oreilly.com/library/view/chaos-engineering/9781492043850/" },
                            new Resource { Id = 10162, StepId = 1016, Title = "Building Green Software", Type = "Book", Url = "https://www.oreilly.com/library/view/building-green-software/9781098150617/" }
                        }
                    }
                };

                // Add practical exercises for each step
                foreach (var step in architectRoadmap.Steps)
                {
                    step.PracticalExercises = GetArchitectPracticalExercisesForStep(step.Id);
                }
            }
        }

        private List<string> GetArchitectPracticalExercisesForStep(int stepId)
        {
            return stepId switch
            {
                1001 => new List<string>
                {
                    "Create architecture views for an e-commerce system using 4+1 model",
                    "Write ADRs for technology choices in a project",
                    "Document quality attributes for a banking system",
                    "Analyze and diagram an existing system's architecture"
                },
                1002 => new List<string>
                {
                    "Refactor a monolithic application applying SOLID principles",
                    "Identify and reduce coupling in a legacy system",
                    "Apply dependency inversion to a tightly coupled design",
                    "Design a system with proper separation of concerns"
                },
                1003 => new List<string>
                {
                    "Convert a monolith to microservices architecture",
                    "Design an event-driven order processing system",
                    "Create a serverless architecture for image processing",
                    "Compare architecture styles for a given scenario"
                },
                1004 => new List<string>
                {
                    "Apply TOGAF to an enterprise transformation project",
                    "Create ArchiMate diagrams for business processes",
                    "Map IT landscape using Zachman Framework",
                    "Develop an EA roadmap for digital transformation"
                },
                1005 => new List<string>
                {
                    "Define bounded contexts for an e-commerce platform",
                    "Design aggregates for a banking domain",
                    "Implement domain events in an order system",
                    "Create context maps for multiple domains"
                },
                1006 => new List<string>
                {
                    "Implement CQRS in a read-heavy application",
                    "Design event sourcing for audit requirements",
                    "Apply Saga pattern for distributed transactions",
                    "Implement Circuit Breaker for resilience"
                },
                1007 => new List<string>
                {
                    "Design a multi-cloud disaster recovery solution",
                    "Containerize and orchestrate microservices with K8s",
                    "Implement service mesh for microservices",
                    "Handle eventual consistency in distributed systems"
                },
                1008 => new List<string>
                {
                    "Define SLAs and SLOs for a critical system",
                    "Design for 99.99% availability",
                    "Implement comprehensive observability",
                    "Create performance testing strategy"
                },
                1009 => new List<string>
                {
                    "Design RESTful API with versioning strategy",
                    "Implement GraphQL federation",
                    "Create event-driven integration architecture",
                    "Design API gateway with rate limiting"
                },
                1010 => new List<string>
                {
                    "Perform threat modeling using STRIDE",
                    "Design Zero Trust network architecture",
                    "Implement OAuth2/OIDC for microservices",
                    "Create security architecture for PCI compliance"
                },
                1011 => new List<string>
                {
                    "Design data lake architecture for analytics",
                    "Implement polyglot persistence strategy",
                    "Create sharding strategy for scalability",
                    "Design multi-layer caching architecture"
                },
                1012 => new List<string>
                {
                    "Design CI/CD pipeline for microservices",
                    "Implement GitOps with ArgoCD",
                    "Create IaC templates for entire infrastructure",
                    "Design observability stack with distributed tracing"
                },
                1013 => new List<string>
                {
                    "Implement Clean Architecture for a web application",
                    "Apply Hexagonal Architecture principles",
                    "Design event-driven microservices system",
                    "Create ML pipeline architecture"
                },
                1014 => new List<string>
                {
                    "Design global load balancing strategy",
                    "Implement CDN for static and dynamic content",
                    "Optimize database queries and indexes",
                    "Create performance benchmarking suite"
                },
                1015 => new List<string>
                {
                    "Create complete C4 model for a system",
                    "Document architecture using ADRs",
                    "Generate architecture diagrams as code",
                    "Present architecture to stakeholders"
                },
                1016 => new List<string>
                {
                    "Design edge computing architecture for IoT",
                    "Implement chaos experiments in production",
                    "Calculate and optimize carbon footprint",
                    "Explore quantum-resistant cryptography"
                },
                _ => new List<string>()
            };
        }
    }
}