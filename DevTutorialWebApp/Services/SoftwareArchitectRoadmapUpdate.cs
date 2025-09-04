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
                            "Architecture vs Design vs Implementation - Architecture focuses on high-level structure and system-wide concerns that are difficult to change, while design addresses mid-level patterns and component interactions, and implementation handles the actual coding details. Understanding these distinctions helps architects work at the appropriate level of abstraction and make decisions with the right scope and impact.",
                            "Architecture Decision Records (ADRs) - Lightweight documents that capture important architectural decisions along with their context, rationale, and consequences. ADRs serve as a decision log that helps teams understand why certain choices were made, evaluate alternatives that were considered, and maintain architectural knowledge over time as team members change.",
                            "4+1 View Model - A framework for describing software architecture using five concurrent views: Logical View (functionality), Process View (runtime behavior), Physical View (deployment), Development View (implementation), and Use Case View (scenarios). This model ensures comprehensive architectural documentation that addresses concerns of different stakeholders from developers to operations teams.",
                            "IEEE/ISO 42010 Standards - International standards that define architecture description frameworks, establishing common vocabulary and conceptual foundations for architecture documentation. These standards provide guidelines for creating architecture descriptions that are consistent, complete, and address stakeholder concerns systematically across different domains and industries.",
                            "Architectural Perspectives - Different viewpoints for examining and evaluating architecture including business, data, application, technology, security, and operational perspectives. Each perspective addresses specific stakeholder concerns and quality attributes, ensuring the architecture is evaluated comprehensively from multiple angles to identify potential gaps or conflicts."
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
                            "SOLID Principles - Five fundamental design principles (Single Responsibility, Open/Closed, Liskov Substitution, Interface Segregation, Dependency Inversion) that guide the creation of maintainable and extensible software architectures. These principles help reduce technical debt, improve code quality, and make systems easier to modify and test over time.",
                            "DRY, KISS, YAGNI - Core principles that promote simplicity and pragmatism: Don't Repeat Yourself (DRY) eliminates redundancy, Keep It Simple Stupid (KISS) favors straightforward solutions over complex ones, and You Aren't Gonna Need It (YAGNI) prevents over-engineering by focusing only on current requirements rather than speculative future needs.",
                            "Separation of Concerns - The practice of organizing software into distinct sections where each addresses a separate concern or functionality, reducing interdependencies and improving modularity. This principle enables parallel development, easier testing, better maintainability, and the ability to modify one aspect of the system without affecting others.",
                            "Cohesion & Coupling - Cohesion measures how closely related and focused the responsibilities of a module are (high cohesion is desirable), while coupling measures the degree of interdependence between modules (low coupling is desirable). Balancing these creates systems that are modular, maintainable, and resilient to change.",
                            "Dependency Inversion - A principle stating that high-level modules should not depend on low-level modules; both should depend on abstractions. This inverts the traditional dependency hierarchy, allowing for flexible architectures where business logic is isolated from infrastructure concerns and implementations can be swapped without affecting core functionality."
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
                            "Monolithic vs Microservices - Monolithic architecture packages all functionality into a single deployable unit, offering simplicity and ease of development but potentially limiting scalability and team autonomy. Microservices decompose applications into small, independent services that can be developed, deployed, and scaled independently, enabling agility and resilience but introducing complexity in service coordination and data consistency.",
                            "Event-Driven Architecture - An architectural pattern where system components communicate through events (significant state changes), enabling loose coupling and real-time responsiveness. This approach supports scalability, flexibility, and complex event processing scenarios, making it ideal for systems that need to react to multiple asynchronous inputs or integrate diverse systems.",
                            "Serverless & Cloud-Native - Serverless architecture abstracts away infrastructure management, allowing developers to focus purely on business logic with automatic scaling and pay-per-use pricing. Cloud-native architectures leverage cloud services, containerization, and DevOps practices to build resilient, manageable, and scalable applications optimized for cloud environments.",
                            "Service-Oriented Architecture (SOA) - An architectural style that structures applications as a collection of loosely coupled services that communicate through well-defined interfaces. SOA promotes reusability, modularity, and platform independence, enabling organizations to build flexible systems that can evolve independently and integrate with various technologies.",
                            "Reactive Architecture - A design approach for building responsive, resilient, elastic, and message-driven systems that can handle varying loads and failures gracefully. Reactive systems use asynchronous message passing, non-blocking operations, and back-pressure mechanisms to maintain responsiveness under stress and scale efficiently."
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
                            "TOGAF Framework - The Open Group Architecture Framework provides a comprehensive approach to enterprise architecture development, including methodology (Architecture Development Method), content framework, and governance structure. TOGAF helps organizations align IT strategy with business goals through systematic planning, design, and implementation of enterprise-wide architectural changes.",
                            "Zachman Framework - A fundamental structure for enterprise architecture that provides a formal and structured way of viewing and defining an enterprise using a 6x6 matrix of perspectives (planner, owner, designer, builder, implementer, worker) and aspects (what, how, where, who, when, why). This framework ensures comprehensive coverage of all architectural concerns across the organization.",
                            "ArchiMate Notation - A visual modeling language specifically designed for enterprise architecture that provides integrated views of business, application, and technology layers. ArchiMate enables architects to describe, analyze, and visualize relationships between business domains, making complex enterprise architectures understandable to diverse stakeholders.",
                            "Federal Enterprise Architecture Framework (FEAF) - A framework designed for US federal agencies that provides a common approach for integrating strategic, business, and technology management as part of organization-wide improvement. FEAF includes reference models, guidance, and best practices for developing and maintaining enterprise architectures in government contexts.",
                            "Gartner Enterprise Architecture - A business-centric approach that focuses on creating actionable, outcome-driven architectures aligned with business strategy. Gartner's methodology emphasizes value realization, business capability modeling, and pragmatic governance to ensure architecture initiatives deliver measurable business results rather than just technical documentation."
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
                            "Bounded Contexts - Explicit boundaries within which a domain model is defined and applicable, ensuring that terms and concepts have specific, unambiguous meanings within that context. Bounded contexts prevent model pollution, enable team autonomy, and allow different parts of a system to evolve independently while maintaining clear integration points.",
                            "Aggregates & Entities - Aggregates are clusters of domain objects treated as a single unit for data changes, with one entity serving as the aggregate root that controls access to the aggregate. Entities have unique identities that persist through state changes, while value objects are immutable and defined by their attributes, together forming the building blocks of rich domain models.",
                            "Domain Events - Significant business occurrences captured as immutable facts that trigger reactions across the system, enabling loose coupling between bounded contexts. Domain events create an audit trail, support event sourcing, enable complex workflows, and allow systems to react to business changes in real-time while maintaining consistency.",
                            "Ubiquitous Language - A common, rigorous language developed collaboratively by developers and domain experts that is used consistently in code, discussions, and documentation. This shared vocabulary reduces misunderstandings, improves communication, and ensures that the software model accurately reflects the business domain's concepts and rules.",
                            "Strategic Design - High-level DDD patterns and principles that deal with large-scale structure, including context mapping, partnership patterns, and integration strategies between bounded contexts. Strategic design helps manage complexity in large systems by defining clear boundaries, relationships, and communication patterns between different parts of the domain."
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
                            "Gang of Four Patterns - The 23 classic design patterns (Creational, Structural, and Behavioral) that provide reusable solutions to common object-oriented design problems. These patterns form a shared vocabulary for developers, promote best practices, and help create flexible, maintainable code by addressing recurring design challenges with proven solutions.",
                            "Enterprise Patterns - Higher-level patterns that address enterprise application concerns such as data access (Repository, Unit of Work), distribution (Remote Facade, Data Transfer Object), and integration (Message Channel, Message Router). These patterns help manage complexity in large-scale business applications and provide blueprints for common enterprise scenarios.",
                            "CQRS & Event Sourcing - Command Query Responsibility Segregation separates read and write operations into different models, optimizing each for its specific purpose. Event Sourcing stores all state changes as a sequence of events, providing complete audit trails, enabling temporal queries, and supporting complex event-driven architectures with eventual consistency.",
                            "Saga Pattern - A pattern for managing distributed transactions across multiple services by breaking them into a series of local transactions coordinated through events or orchestration. Sagas maintain data consistency in microservices architectures without distributed locks, handling failures through compensating transactions that undo previous steps.",
                            "Circuit Breaker - A fault tolerance pattern that prevents cascading failures by monitoring for failures and temporarily blocking requests to failing services. Like electrical circuit breakers, it has three states (closed, open, half-open) and protects systems from repeated failures, allowing time for recovery while providing fallback responses."
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
                            "Cloud Service Models - The three primary cloud computing models: Infrastructure as a Service (IaaS) provides virtualized computing resources, Platform as a Service (PaaS) offers development platforms without infrastructure management, and Software as a Service (SaaS) delivers complete applications. Understanding these models helps architects choose the right abstraction level for different components.",
                            "Containerization & Kubernetes - Containerization packages applications with their dependencies into portable units that run consistently across environments. Kubernetes (K8s) orchestrates containers at scale, handling deployment, scaling, networking, and self-healing, enabling architects to design resilient, scalable systems that abstract away infrastructure complexities.",
                            "Service Mesh - Infrastructure layer that handles service-to-service communication in microservices architectures, providing features like load balancing, service discovery, encryption, authentication, and observability without changing application code. Service meshes like Istio or Linkerd enable sophisticated traffic management and security policies across distributed systems.",
                            "CAP Theorem - States that distributed systems can guarantee at most two of three properties: Consistency (all nodes see the same data), Availability (system remains operational), and Partition tolerance (system continues despite network failures). Understanding CAP helps architects make informed trade-offs when designing distributed systems based on business requirements.",
                            "Message Brokers - Middleware systems that enable asynchronous communication between applications by receiving, storing, and forwarding messages. Popular brokers like Kafka, RabbitMQ, and AWS SQS provide different guarantees around delivery, ordering, and persistence, enabling architects to build decoupled, scalable systems that handle varying loads and failures gracefully."
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
                            "Performance & Scalability - Performance ensures systems respond quickly under normal load through optimization, caching, and efficient algorithms. Scalability enables systems to handle increased load through vertical scaling (bigger machines) or horizontal scaling (more machines), requiring architectural decisions around state management, data partitioning, and load distribution.",
                            "Availability & Reliability - Availability measures the percentage of time a system is operational and accessible (e.g., 99.9% = 43 minutes downtime/month). Reliability ensures the system performs correctly and consistently over time. Achieving high availability requires redundancy, failover mechanisms, and careful elimination of single points of failure.",
                            "Security Requirements - Non-functional requirements that protect systems from threats including confidentiality (data privacy), integrity (data accuracy), availability (service uptime), authentication (identity verification), authorization (access control), and non-repudiation (action accountability). Security must be designed in from the start, not added as an afterthought.",
                            "Maintainability - The ease with which a system can be modified to fix defects, improve performance, or adapt to changing requirements. Maintainable architectures use clear structure, comprehensive documentation, automated testing, and modular design to reduce the time and risk associated with changes over the system's lifetime.",
                            "Observability - The ability to understand a system's internal state from its external outputs through metrics, logs, and traces. Observable systems provide rich telemetry data that enables quick problem diagnosis, performance optimization, and proactive issue detection, essential for operating complex distributed systems effectively."
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
                            "REST API Design - Architectural style for building web services using HTTP methods (GET, POST, PUT, DELETE) with resources identified by URIs. RESTful APIs emphasize statelessness, uniform interfaces, and standard HTTP semantics, making them widely compatible and easy to understand, though they may require multiple requests for complex data needs.",
                            "GraphQL & gRPC - GraphQL provides a query language allowing clients to request exactly the data they need in a single request, reducing over-fetching and under-fetching. gRPC uses Protocol Buffers for efficient binary serialization and supports streaming, making it ideal for internal microservice communication where performance is critical.",
                            "Event-Driven Integration - Integration pattern where systems communicate by producing and consuming events, enabling loose coupling and real-time data flow. This approach supports complex workflows, scales naturally, and allows systems to evolve independently, though it requires careful handling of eventual consistency and event ordering.",
                            "API Gateways - Single entry points that sit between clients and backend services, handling cross-cutting concerns like authentication, rate limiting, request routing, protocol translation, and response aggregation. API gateways simplify client interactions, enforce policies consistently, and provide a facade over complex microservice architectures.",
                            "Data Integration - Strategies and patterns for combining data from different sources including ETL (Extract, Transform, Load), ELT, real-time streaming, and API-based integration. Effective data integration requires handling format differences, ensuring data quality, managing latency requirements, and maintaining consistency across systems."
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
                            "Zero Trust Architecture - Security model that assumes no trust and requires verification for every transaction, regardless of whether it originates inside or outside the network perimeter. Zero Trust implements least-privilege access, micro-segmentation, and continuous verification, providing defense in depth against modern threats that bypass traditional perimeter security.",
                            "Identity & Access Management (IAM) - Comprehensive framework for managing digital identities and controlling access to resources through authentication (verifying identity) and authorization (granting permissions). IAM systems handle user lifecycle management, single sign-on, multi-factor authentication, and privileged access management across distributed environments.",
                            "OAuth2/OIDC - OAuth 2.0 provides delegated authorization allowing users to grant limited access to their resources without sharing credentials. OpenID Connect (OIDC) adds an identity layer on top of OAuth 2.0 for authentication. Together they enable secure, standardized authentication and authorization for modern applications and APIs.",
                            "Threat Modeling - Systematic approach to identifying, evaluating, and addressing security threats during design phase using methodologies like STRIDE (Spoofing, Tampering, Repudiation, Information disclosure, Denial of service, Elevation of privilege). Threat modeling helps prioritize security efforts and build defenses against the most likely and damaging attacks.",
                            "OWASP Top 10 - The Open Web Application Security Project's list of the most critical web application security risks, updated periodically based on data from security organizations worldwide. Understanding these risks (like injection, broken authentication, and XSS) helps architects design defenses against the most common and impactful vulnerabilities."
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
                            "OLTP vs OLAP - Online Transaction Processing (OLTP) systems handle real-time transactional data with normalized schemas optimized for fast inserts/updates. Online Analytical Processing (OLAP) systems support complex analytical queries on historical data using denormalized schemas. Understanding these paradigms helps architects choose appropriate data stores for different workloads.",
                            "Data Lakes & Warehouses - Data warehouses store structured, processed data optimized for analytics with predefined schemas. Data lakes store raw data in native formats, supporting diverse data types and enabling flexible analysis. Modern architectures often combine both in a lakehouse pattern, balancing structure with flexibility.",
                            "Polyglot Persistence - Using different data storage technologies for different parts of an application based on specific requirements (relational for transactions, document stores for catalogs, graph databases for relationships, key-value for sessions). This approach optimizes each use case but requires managing complexity and ensuring data consistency.",
                            "Database Sharding - Horizontal partitioning technique that distributes data across multiple database instances based on a shard key. Sharding enables linear scalability for large datasets but introduces complexity in queries that span shards, requiring careful shard key selection and handling of cross-shard transactions.",
                            "Caching Strategies - Techniques for storing frequently accessed data in fast storage layers including cache-aside (lazy loading), write-through (sync writes), write-behind (async writes), and refresh-ahead (proactive loading). Effective caching dramatically improves performance but requires careful invalidation strategies and consistency management."
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
                            "CI/CD Pipelines - Continuous Integration automatically builds and tests code changes, while Continuous Delivery/Deployment automates release processes. Well-designed pipelines include stages for building, testing, security scanning, and deployment, enabling rapid, reliable software delivery with reduced risk and faster feedback cycles.",
                            "Infrastructure as Code (IaC) - Managing and provisioning infrastructure through machine-readable definition files rather than manual configuration. IaC tools like Terraform, CloudFormation, and Ansible enable version control, repeatability, and consistency across environments, treating infrastructure with the same rigor as application code.",
                            "GitOps - Operational model that uses Git as the single source of truth for declarative infrastructure and applications. Changes are made through pull requests, with automated processes ensuring the running system matches the Git repository state, providing auditability, rollback capabilities, and improved security.",
                            "Deployment Strategies - Techniques for releasing new versions including blue-green (instant switchover), canary (gradual rollout), rolling (incremental updates), and feature flags (toggle functionality). Each strategy offers different trade-offs between risk, complexity, and rollback speed, enabling safe experimentation and progressive delivery.",
                            "Observability Stack - Integrated tools for monitoring, logging, and tracing that provide comprehensive visibility into system behavior. Modern stacks combine metrics (Prometheus), logs (ELK stack), and distributed tracing (Jaeger) with dashboards and alerting, enabling teams to quickly understand and debug complex distributed systems."
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
                            "Clean Architecture - Architectural pattern that organizes code in concentric layers with dependencies pointing inward, isolating business logic from frameworks, databases, and external systems. This approach creates systems that are testable, maintainable, and independent of implementation details, allowing core business rules to evolve without infrastructure constraints.",
                            "Hexagonal Architecture - Also called Ports and Adapters, this pattern isolates core business logic from external concerns through well-defined interfaces (ports) and implementations (adapters). This creates symmetry between inputs and outputs, making systems equally testable from UI, API, or automated tests while supporting easy technology swaps.",
                            "Event-Driven Microservices - Architecture combining microservices with event-driven communication, where services publish events about state changes that other services consume. This pattern enables high scalability, loose coupling, and real-time processing but requires careful handling of eventual consistency and distributed transaction patterns.",
                            "Serverless-First - Design approach that prioritizes serverless technologies (Functions as a Service, managed services) for new applications, falling back to servers only when necessary. This strategy minimizes operational overhead, provides automatic scaling, and optimizes costs, though it requires rethinking traditional architectures.",
                            "AI/ML Architecture - Specialized architectures for machine learning systems including data pipelines, model training infrastructure, model serving, and monitoring. These architectures must handle unique concerns like data versioning, model drift, A/B testing of models, and integration between experimental and production environments."
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
                            "Load Balancing Strategies - Techniques for distributing traffic across multiple servers including round-robin, least connections, weighted distribution, and geographic routing. Advanced strategies consider server health, response times, and session affinity, ensuring optimal resource utilization and preventing any single server from becoming overwhelmed.",
                            "CDN Architecture - Content Delivery Networks cache and serve content from edge locations close to users, reducing latency and origin server load. Modern CDNs handle static assets, dynamic content, API responses, and even compute at the edge, requiring architects to design cache strategies, invalidation policies, and origin failover mechanisms.",
                            "Query Optimization - Techniques for improving database query performance including proper indexing, query plan analysis, denormalization, and query rewriting. Optimization requires understanding execution plans, statistics, and access patterns, balancing read performance with write overhead and storage costs.",
                            "Distributed Caching - Caching across multiple nodes using systems like Redis Cluster or Hazelcast, providing scalability and fault tolerance. Distributed caches require strategies for data partitioning, replication, consistency, and cache warming, significantly improving performance for read-heavy workloads while managing complexity.",
                            "Performance Testing - Systematic approach to measuring and improving system performance through load testing, stress testing, spike testing, and endurance testing. Effective performance testing identifies bottlenecks, validates scalability, and ensures systems meet performance requirements under various conditions before production deployment."
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
                            "C4 Model - Hierarchical approach to software architecture diagramming with four levels: Context (system in environment), Container (high-level technology choices), Component (logical components), and Code (optional class diagrams). C4 provides a consistent, scalable way to communicate architecture to different audiences with appropriate detail levels.",
                            "UML Diagrams - Unified Modeling Language provides standardized notations for visualizing system design including class diagrams (structure), sequence diagrams (interactions), activity diagrams (workflows), and deployment diagrams (infrastructure). While comprehensive, architects must choose diagrams that effectively communicate specific architectural concerns.",
                            "Architecture Decision Records (ADRs) - Lightweight documents capturing significant design decisions with their context, alternatives considered, decision rationale, and consequences. ADRs create an audit trail of architectural evolution, helping future maintainers understand why specific approaches were chosen and what trade-offs were accepted.",
                            "System Context Diagrams - High-level diagrams showing the system as a black box with its external dependencies, users, and integrations. These diagrams establish scope boundaries, identify external interfaces, and provide stakeholders with an understanding of how the system fits into the larger ecosystem.",
                            "Architecture Katas - Practice exercises where architects solve real-world design problems under time constraints, similar to coding katas. These exercises develop architectural thinking, decision-making skills, and the ability to communicate design choices effectively, often using scenarios from actual business domains."
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
                            "Quantum Computing Architecture - Emerging field addressing how classical and quantum systems interact, including quantum algorithm design, error correction, and hybrid architectures. Architects must understand quantum computing's potential for specific problems (cryptography, optimization, simulation) and design systems that can leverage quantum advantages when available.",
                            "Blockchain Architecture - Distributed ledger technology enabling trustless transactions through consensus mechanisms, smart contracts, and cryptographic verification. Architectural considerations include consensus algorithm choice, scalability solutions (layer 2, sharding), integration patterns, and determining when blockchain's guarantees justify its complexity.",
                            "Edge Computing - Architecture pattern that processes data near its source rather than in centralized clouds, reducing latency and bandwidth usage. Edge architectures must handle intermittent connectivity, resource constraints, distributed state management, and orchestration across heterogeneous devices from IoT sensors to edge servers.",
                            "Green Software - Architectural practices that minimize environmental impact through efficient resource usage, carbon-aware computing, and sustainable design patterns. This includes optimizing algorithms, choosing efficient languages and frameworks, designing for idle states, and leveraging renewable energy sources in deployment strategies.",
                            "Chaos Engineering - Discipline of experimenting on distributed systems to build confidence in their capability to withstand turbulent conditions. Architects design systems with failure injection points, implement game days, and use tools like Chaos Monkey to proactively discover weaknesses before they cause outages."
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