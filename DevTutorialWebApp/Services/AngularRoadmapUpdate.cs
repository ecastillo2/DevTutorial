using System.Collections.Generic;
using System.Linq;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Services
{
    public partial class RoadmapService
    {
        private void UpdateAngularRoadmap(List<Roadmap> roadmaps)
        {
            var angularDev = roadmaps.FirstOrDefault(r => r.Id == 21);
            if (angularDev != null)
            {
                // Update the Angular roadmap with comprehensive structure
                angularDev.Title = "Angular Developer";
                angularDev.Description = "Master Angular framework for building enterprise-scale single-page applications";
                angularDev.Duration = "8-12 months";
                angularDev.Difficulty = "Intermediate to Expert";
                angularDev.Context = "Angular is a comprehensive framework for building scalable, maintainable single-page applications. This path covers everything from Angular fundamentals to advanced architecture patterns, state management, and enterprise development.";
                
                angularDev.Prerequisites = new List<string>
                {
                    "JavaScript ES6+ proficiency",
                    "TypeScript basics",
                    "HTML5 and CSS3",
                    "Object-oriented programming concepts",
                    "Basic understanding of web development"
                };
                
                angularDev.CareerPaths = new List<string>
                {
                    "Angular Developer ($75K-$145K)",
                    "Frontend Architect ($100K-$180K)",
                    "Full Stack Developer ($90K-$170K)",
                    "Senior Frontend Engineer ($110K-$190K)",
                    "Technical Lead ($120K-$200K)"
                };

                // Replace existing steps with comprehensive 20-category structure
                angularDev.Steps = new List<RoadmapStep>
                {
                    // 1. Core Angular Fundamentals
                    new RoadmapStep
                    {
                        Id = 2101,
                        RoadmapId = 21,
                        Title = "Core Angular Fundamentals",
                        Duration = "3-4 weeks",
                        Content = "Master the core concepts of Angular framework including architecture, modules, components, and data binding",
                        KeyConcepts = new List<string> 
                        { 
                            "Angular Architecture",
                            "Modules (NgModule)",
                            "Components & Templates",
                            "Directives (Structural & Attribute)",
                            "Data Binding Types",
                            "Dependency Injection"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 21011, StepId = 2101, Description = "Understand Angular's component-based architecture" },
                            new LearningObjective { Id = 21012, StepId = 2101, Description = "Create and configure NgModules" },
                            new LearningObjective { Id = 21013, StepId = 2101, Description = "Master all data binding techniques" },
                            new LearningObjective { Id = 21014, StepId = 2101, Description = "Implement dependency injection patterns" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 21011, StepId = 2101, Title = "Angular Official Documentation", Type = "Documentation", Url = "https://angular.io/docs" },
                            new Resource { Id = 21012, StepId = 2101, Title = "Angular Architecture Guide", Type = "Guide", Url = "https://angular.io/guide/architecture" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build a modular Angular application with multiple feature modules",
                            "Create custom structural and attribute directives",
                            "Implement all four types of data binding in a demo app"
                        }
                    },

                    // 2. TypeScript for Angular
                    new RoadmapStep
                    {
                        Id = 2102,
                        RoadmapId = 21,
                        Title = "TypeScript for Angular",
                        Duration = "2-3 weeks",
                        Content = "Master TypeScript features essential for Angular development including types, interfaces, decorators, and generics",
                        KeyConcepts = new List<string>
                        {
                            "Types & Interfaces",
                            "Classes & Inheritance",
                            "Decorators & Metadata",
                            "Generics & Type Guards",
                            "Modules & Namespaces",
                            "Access Modifiers"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 21021, StepId = 2102, Description = "Define and use complex types and interfaces" },
                            new LearningObjective { Id = 21022, StepId = 2102, Description = "Implement decorators for Angular components" },
                            new LearningObjective { Id = 21023, StepId = 2102, Description = "Use generics for type-safe code" },
                            new LearningObjective { Id = 21024, StepId = 2102, Description = "Apply access modifiers effectively" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 21021, StepId = 2102, Title = "TypeScript Handbook", Type = "Documentation", Url = "https://www.typescriptlang.org/docs/" },
                            new Resource { Id = 21022, StepId = 2102, Title = "TypeScript Deep Dive", Type = "Book", Url = "https://basarat.gitbook.io/typescript/" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Create strongly-typed models and services",
                            "Build custom decorators for Angular components",
                            "Implement generic services and utilities"
                        }
                    },

                    // 3. Angular CLI & Workspace
                    new RoadmapStep
                    {
                        Id = 2103,
                        RoadmapId = 21,
                        Title = "Angular CLI & Workspace",
                        Duration = "1-2 weeks",
                        Content = "Master Angular CLI for project setup, code generation, and workspace management",
                        KeyConcepts = new List<string>
                        {
                            "Project Setup & Configuration",
                            "Schematics & Code Generation",
                            "Angular Workspace Structure",
                            "Configuration Files",
                            "Building & Serving Apps",
                            "Environment Management"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 21031, StepId = 2103, Description = "Set up and configure Angular workspaces" },
                            new LearningObjective { Id = 21032, StepId = 2103, Description = "Use schematics for code generation" },
                            new LearningObjective { Id = 21033, StepId = 2103, Description = "Configure build optimizations" },
                            new LearningObjective { Id = 21034, StepId = 2103, Description = "Manage multiple projects in workspace" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 21031, StepId = 2103, Title = "Angular CLI Documentation", Type = "Documentation", Url = "https://angular.io/cli" },
                            new Resource { Id = 21032, StepId = 2103, Title = "Angular Workspace Guide", Type = "Guide", Url = "https://angular.io/guide/file-structure" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Create a multi-project Angular workspace",
                            "Build custom schematics for code generation",
                            "Configure different build environments"
                        }
                    },

                    // 4. Components & Communication
                    new RoadmapStep
                    {
                        Id = 2104,
                        RoadmapId = 21,
                        Title = "Components & Communication",
                        Duration = "3-4 weeks",
                        Content = "Master component lifecycle, communication patterns, and advanced component techniques",
                        KeyConcepts = new List<string>
                        {
                            "Component Lifecycle Hooks",
                            "@Input & @Output Properties",
                            "ViewChild & ContentChild",
                            "Change Detection Strategies",
                            "Smart vs Dumb Components",
                            "Dynamic Component Loading"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 21041, StepId = 2104, Description = "Implement all lifecycle hooks effectively" },
                            new LearningObjective { Id = 21042, StepId = 2104, Description = "Master parent-child communication patterns" },
                            new LearningObjective { Id = 21043, StepId = 2104, Description = "Optimize with change detection strategies" },
                            new LearningObjective { Id = 21044, StepId = 2104, Description = "Load components dynamically" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 21041, StepId = 2104, Title = "Component Interaction Guide", Type = "Guide", Url = "https://angular.io/guide/component-interaction" },
                            new Resource { Id = 21042, StepId = 2104, Title = "Lifecycle Hooks Documentation", Type = "Documentation", Url = "https://angular.io/guide/lifecycle-hooks" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build a component library with smart/dumb patterns",
                            "Implement custom change detection strategies",
                            "Create a dynamic form builder with component loading"
                        }
                    },

                    // 5. Templates & Styling
                    new RoadmapStep
                    {
                        Id = 2105,
                        RoadmapId = 21,
                        Title = "Templates & Styling",
                        Duration = "2-3 weeks",
                        Content = "Master Angular templates, styling techniques, and view encapsulation",
                        KeyConcepts = new List<string>
                        {
                            "Template Syntax & Expressions",
                            "Template Reference Variables",
                            "View Encapsulation Modes",
                            "CSS/SCSS in Angular",
                            "Angular Animations API",
                            "Responsive Design Patterns"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 21051, StepId = 2105, Description = "Master advanced template syntax" },
                            new LearningObjective { Id = 21052, StepId = 2105, Description = "Implement view encapsulation strategies" },
                            new LearningObjective { Id = 21053, StepId = 2105, Description = "Create complex animations" },
                            new LearningObjective { Id = 21054, StepId = 2105, Description = "Build responsive layouts" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 21051, StepId = 2105, Title = "Template Syntax Guide", Type = "Guide", Url = "https://angular.io/guide/template-syntax" },
                            new Resource { Id = 21052, StepId = 2105, Title = "Angular Animations Guide", Type = "Guide", Url = "https://angular.io/guide/animations" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Create a theme system with CSS variables",
                            "Build complex animations for route transitions",
                            "Implement responsive grid layouts"
                        }
                    },

                    // 6. Routing & Navigation
                    new RoadmapStep
                    {
                        Id = 2106,
                        RoadmapId = 21,
                        Title = "Routing & Navigation",
                        Duration = "3-4 weeks",
                        Content = "Master Angular Router for complex navigation scenarios and route protection",
                        KeyConcepts = new List<string>
                        {
                            "Router Configuration",
                            "Route Guards (CanActivate, etc.)",
                            "Route Parameters & Query Params",
                            "Lazy Loading Modules",
                            "Preloading Strategies",
                            "Nested Routes & Aux Routes"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 21061, StepId = 2106, Description = "Configure complex routing scenarios" },
                            new LearningObjective { Id = 21062, StepId = 2106, Description = "Implement all types of route guards" },
                            new LearningObjective { Id = 21063, StepId = 2106, Description = "Set up lazy loading with preloading" },
                            new LearningObjective { Id = 21064, StepId = 2106, Description = "Handle navigation events and errors" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 21061, StepId = 2106, Title = "Angular Router Documentation", Type = "Documentation", Url = "https://angular.io/guide/router" },
                            new Resource { Id = 21062, StepId = 2106, Title = "Route Guards Guide", Type = "Guide", Url = "https://angular.io/guide/router#route-guards" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build multi-level navigation with guards",
                            "Implement role-based route protection",
                            "Create custom preloading strategies"
                        }
                    },

                    // 7. Forms in Angular
                    new RoadmapStep
                    {
                        Id = 2107,
                        RoadmapId = 21,
                        Title = "Forms in Angular",
                        Duration = "4-5 weeks",
                        Content = "Master both template-driven and reactive forms with advanced validation",
                        KeyConcepts = new List<string>
                        {
                            "Template-driven Forms",
                            "Reactive Forms & FormBuilder",
                            "FormControl & FormGroup",
                            "FormArray for Dynamic Forms",
                            "Custom Validators & Async Validators",
                            "Cross-field Validation"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 21071, StepId = 2107, Description = "Build complex forms with FormBuilder" },
                            new LearningObjective { Id = 21072, StepId = 2107, Description = "Create custom sync and async validators" },
                            new LearningObjective { Id = 21073, StepId = 2107, Description = "Implement dynamic form generation" },
                            new LearningObjective { Id = 21074, StepId = 2107, Description = "Handle form state and errors effectively" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 21071, StepId = 2107, Title = "Reactive Forms Guide", Type = "Guide", Url = "https://angular.io/guide/reactive-forms" },
                            new Resource { Id = 21072, StepId = 2107, Title = "Form Validation Guide", Type = "Guide", Url = "https://angular.io/guide/form-validation" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build a dynamic form generator",
                            "Create reusable custom form controls",
                            "Implement complex validation scenarios"
                        }
                    },

                    // 8. RxJS & Reactive Programming
                    new RoadmapStep
                    {
                        Id = 2108,
                        RoadmapId = 21,
                        Title = "RxJS & Reactive Programming",
                        Duration = "4-5 weeks",
                        Content = "Master RxJS for reactive programming patterns in Angular applications",
                        KeyConcepts = new List<string>
                        {
                            "Observables & Subjects",
                            "Creation & Transformation Operators",
                            "Filtering & Combination Operators",
                            "Error Handling & Retry Logic",
                            "Higher-order Observables",
                            "Hot vs Cold Observables"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 21081, StepId = 2108, Description = "Master Observable creation and subscription" },
                            new LearningObjective { Id = 21082, StepId = 2108, Description = "Use operators effectively for data flow" },
                            new LearningObjective { Id = 21083, StepId = 2108, Description = "Implement error handling strategies" },
                            new LearningObjective { Id = 21084, StepId = 2108, Description = "Manage subscriptions and prevent leaks" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 21081, StepId = 2108, Title = "RxJS Documentation", Type = "Documentation", Url = "https://rxjs.dev/" },
                            new Resource { Id = 21082, StepId = 2108, Title = "Learn RxJS", Type = "Tutorial", Url = "https://www.learnrxjs.io/" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build a real-time search with debouncing",
                            "Implement complex data flow pipelines",
                            "Create custom RxJS operators"
                        }
                    },

                    // 9. HTTP & API Integration
                    new RoadmapStep
                    {
                        Id = 2109,
                        RoadmapId = 21,
                        Title = "HTTP & API Integration",
                        Duration = "3-4 weeks",
                        Content = "Master HTTP communication, interceptors, and API integration patterns",
                        KeyConcepts = new List<string>
                        {
                            "HttpClient & HTTP Methods",
                            "HTTP Interceptors",
                            "Request/Response Transformation",
                            "Error Handling & Retry",
                            "Caching Strategies",
                            "File Upload/Download"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 21091, StepId = 2109, Description = "Implement comprehensive HTTP services" },
                            new LearningObjective { Id = 21092, StepId = 2109, Description = "Create interceptors for auth and logging" },
                            new LearningObjective { Id = 21093, StepId = 2109, Description = "Handle errors and implement retry logic" },
                            new LearningObjective { Id = 21094, StepId = 2109, Description = "Build efficient caching mechanisms" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 21091, StepId = 2109, Title = "HttpClient Guide", Type = "Guide", Url = "https://angular.io/guide/http" },
                            new Resource { Id = 21092, StepId = 2109, Title = "HTTP Interceptors Guide", Type = "Guide", Url = "https://angular.io/guide/http#intercepting-requests-and-responses" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build a complete API service layer",
                            "Implement JWT authentication interceptor",
                            "Create offline-first caching system"
                        }
                    },

                    // 10. State Management
                    new RoadmapStep
                    {
                        Id = 2110,
                        RoadmapId = 21,
                        Title = "State Management",
                        Duration = "4-5 weeks",
                        Content = "Master state management patterns from simple to complex with NgRx",
                        KeyConcepts = new List<string>
                        {
                            "Component State Management",
                            "Service-based State",
                            "NgRx Store & Actions",
                            "Reducers & Effects",
                            "Selectors & Memoization",
                            "Entity Management"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 21101, StepId = 2110, Description = "Design effective state architecture" },
                            new LearningObjective { Id = 21102, StepId = 2110, Description = "Implement NgRx for complex state" },
                            new LearningObjective { Id = 21103, StepId = 2110, Description = "Create reusable selectors and effects" },
                            new LearningObjective { Id = 21104, StepId = 2110, Description = "Handle async operations with effects" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 21101, StepId = 2110, Title = "NgRx Documentation", Type = "Documentation", Url = "https://ngrx.io/docs" },
                            new Resource { Id = 21102, StepId = 2110, Title = "State Management Patterns", Type = "Guide", Url = "https://angular.io/guide/state-management" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Migrate app from services to NgRx",
                            "Implement complex async workflows",
                            "Build reusable state features"
                        }
                    },

                    // 11. Testing in Angular
                    new RoadmapStep
                    {
                        Id = 2111,
                        RoadmapId = 21,
                        Title = "Testing in Angular",
                        Duration = "4-5 weeks",
                        Content = "Master unit testing, integration testing, and E2E testing strategies",
                        KeyConcepts = new List<string>
                        {
                            "Jasmine & Karma Setup",
                            "TestBed & ComponentFixture",
                            "Service & Pipe Testing",
                            "HTTP Testing & Mocking",
                            "E2E with Cypress/Playwright",
                            "Code Coverage"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 21111, StepId = 2111, Description = "Write comprehensive unit tests" },
                            new LearningObjective { Id = 21112, StepId = 2111, Description = "Test complex component interactions" },
                            new LearningObjective { Id = 21113, StepId = 2111, Description = "Mock dependencies effectively" },
                            new LearningObjective { Id = 21114, StepId = 2111, Description = "Implement E2E test suites" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 21111, StepId = 2111, Title = "Angular Testing Guide", Type = "Guide", Url = "https://angular.io/guide/testing" },
                            new Resource { Id = 21112, StepId = 2111, Title = "Testing Best Practices", Type = "Article", Url = "https://angular.io/guide/testing-best-practices" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Achieve 90%+ code coverage",
                            "Test complex async operations",
                            "Build E2E test automation suite"
                        }
                    },

                    // 12. Performance Optimization
                    new RoadmapStep
                    {
                        Id = 2112,
                        RoadmapId = 21,
                        Title = "Performance Optimization",
                        Duration = "3-4 weeks",
                        Content = "Master techniques for building high-performance Angular applications",
                        KeyConcepts = new List<string>
                        {
                            "Lazy Loading & Code Splitting",
                            "OnPush Change Detection",
                            "Tree Shaking & Bundle Size",
                            "TrackBy Functions",
                            "Virtual Scrolling",
                            "Web Workers Integration"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 21121, StepId = 2112, Description = "Optimize bundle size and loading" },
                            new LearningObjective { Id = 21122, StepId = 2112, Description = "Implement efficient change detection" },
                            new LearningObjective { Id = 21123, StepId = 2112, Description = "Profile and fix performance issues" },
                            new LearningObjective { Id = 21124, StepId = 2112, Description = "Use Web Workers for heavy tasks" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 21121, StepId = 2112, Title = "Performance Optimization Guide", Type = "Guide", Url = "https://angular.io/guide/performance-optimizations" },
                            new Resource { Id = 21122, StepId = 2112, Title = "Bundle Size Optimization", Type = "Article", Url = "https://angular.io/guide/deployment#optimize-for-production" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Optimize large list rendering",
                            "Reduce initial bundle size by 50%",
                            "Implement virtual scrolling"
                        }
                    },

                    // 13. Progressive Web Apps (PWA)
                    new RoadmapStep
                    {
                        Id = 2113,
                        RoadmapId = 21,
                        Title = "Progressive Web Apps (PWA)",
                        Duration = "2-3 weeks",
                        Content = "Build offline-capable Progressive Web Apps with Angular",
                        KeyConcepts = new List<string>
                        {
                            "Service Worker Setup",
                            "App Manifest Configuration",
                            "Offline Caching Strategies",
                            "Push Notifications",
                            "Background Sync",
                            "App Shell Architecture"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 21131, StepId = 2113, Description = "Configure Angular service workers" },
                            new LearningObjective { Id = 21132, StepId = 2113, Description = "Implement offline functionality" },
                            new LearningObjective { Id = 21133, StepId = 2113, Description = "Add push notifications" },
                            new LearningObjective { Id = 21134, StepId = 2113, Description = "Optimize for mobile experience" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 21131, StepId = 2113, Title = "Angular PWA Guide", Type = "Guide", Url = "https://angular.io/guide/service-worker-intro" },
                            new Resource { Id = 21132, StepId = 2113, Title = "Web App Manifest", Type = "Documentation", Url = "https://web.dev/add-manifest/" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Convert existing app to PWA",
                            "Implement offline data sync",
                            "Add install prompts and notifications"
                        }
                    },

                    // 14. Internationalization & Accessibility
                    new RoadmapStep
                    {
                        Id = 2114,
                        RoadmapId = 21,
                        Title = "Internationalization (i18n) & Accessibility (a11y)",
                        Duration = "2-3 weeks",
                        Content = "Build globally accessible applications with internationalization support",
                        KeyConcepts = new List<string>
                        {
                            "Angular i18n Tools",
                            "Translation Management",
                            "Locale-specific Formatting",
                            "RTL Support",
                            "ARIA Attributes",
                            "Keyboard Navigation"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 21141, StepId = 2114, Description = "Set up multi-language support" },
                            new LearningObjective { Id = 21142, StepId = 2114, Description = "Extract and manage translations" },
                            new LearningObjective { Id = 21143, StepId = 2114, Description = "Implement WCAG compliance" },
                            new LearningObjective { Id = 21144, StepId = 2114, Description = "Test with screen readers" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 21141, StepId = 2114, Title = "Angular i18n Guide", Type = "Guide", Url = "https://angular.io/guide/i18n-overview" },
                            new Resource { Id = 21142, StepId = 2114, Title = "Accessibility Guide", Type = "Guide", Url = "https://angular.io/guide/accessibility" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Add multi-language support to app",
                            "Implement RTL layout switching",
                            "Achieve WCAG AA compliance"
                        }
                    },

                    // 15. Security in Angular
                    new RoadmapStep
                    {
                        Id = 2115,
                        RoadmapId = 21,
                        Title = "Security in Angular",
                        Duration = "2-3 weeks",
                        Content = "Implement security best practices and protect against common vulnerabilities",
                        KeyConcepts = new List<string>
                        {
                            "XSS Prevention",
                            "CSRF Protection",
                            "Content Security Policy",
                            "DomSanitizer Usage",
                            "JWT Authentication",
                            "Route Guards & RBAC"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 21151, StepId = 2115, Description = "Prevent XSS attacks effectively" },
                            new LearningObjective { Id = 21152, StepId = 2115, Description = "Implement secure authentication" },
                            new LearningObjective { Id = 21153, StepId = 2115, Description = "Configure CSP headers" },
                            new LearningObjective { Id = 21154, StepId = 2115, Description = "Build role-based access control" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 21151, StepId = 2115, Title = "Angular Security Guide", Type = "Guide", Url = "https://angular.io/guide/security" },
                            new Resource { Id = 21152, StepId = 2115, Title = "OWASP Security Checklist", Type = "Checklist", Url = "https://owasp.org/www-project-web-security-testing-guide/" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Implement JWT authentication flow",
                            "Add role-based route protection",
                            "Configure and test CSP policies"
                        }
                    },

                    // 16. Angular & Backend Integration
                    new RoadmapStep
                    {
                        Id = 2116,
                        RoadmapId = 21,
                        Title = "Angular & Backend Integration",
                        Duration = "3-4 weeks",
                        Content = "Master integration patterns with various backend technologies and real-time communication",
                        KeyConcepts = new List<string>
                        {
                            "REST API Integration",
                            "GraphQL with Apollo",
                            "WebSockets & SignalR",
                            "gRPC Web Clients",
                            "Firebase Integration",
                            "API Versioning"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 21161, StepId = 2116, Description = "Build robust REST API clients" },
                            new LearningObjective { Id = 21162, StepId = 2116, Description = "Implement GraphQL with Apollo" },
                            new LearningObjective { Id = 21163, StepId = 2116, Description = "Add real-time features with WebSockets" },
                            new LearningObjective { Id = 21164, StepId = 2116, Description = "Handle API versioning gracefully" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 21161, StepId = 2116, Title = "Apollo Angular Documentation", Type = "Documentation", Url = "https://apollo-angular.com/docs" },
                            new Resource { Id = 21162, StepId = 2116, Title = "SignalR with Angular", Type = "Tutorial", Url = "https://docs.microsoft.com/en-us/aspnet/core/signalr/javascript-client" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build GraphQL client with caching",
                            "Implement real-time chat with SignalR",
                            "Create offline-sync with Firebase"
                        }
                    },

                    // 17. Build & Deployment
                    new RoadmapStep
                    {
                        Id = 2117,
                        RoadmapId = 21,
                        Title = "Build & Deployment",
                        Duration = "2-3 weeks",
                        Content = "Master build optimization, deployment strategies, and CI/CD pipelines",
                        KeyConcepts = new List<string>
                        {
                            "Build Configurations",
                            "AOT Compilation",
                            "Differential Loading",
                            "Docker Containerization",
                            "CI/CD Pipelines",
                            "CDN Deployment"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 21171, StepId = 2117, Description = "Configure optimized production builds" },
                            new LearningObjective { Id = 21172, StepId = 2117, Description = "Containerize Angular applications" },
                            new LearningObjective { Id = 21173, StepId = 2117, Description = "Set up automated CI/CD" },
                            new LearningObjective { Id = 21174, StepId = 2117, Description = "Deploy to multiple environments" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 21171, StepId = 2117, Title = "Angular Deployment Guide", Type = "Guide", Url = "https://angular.io/guide/deployment" },
                            new Resource { Id = 21172, StepId = 2117, Title = "Docker for Angular", Type = "Tutorial", Url = "https://angular.io/guide/deployment#docker" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Dockerize and deploy to cloud",
                            "Set up GitHub Actions CI/CD",
                            "Configure CDN with cache busting"
                        }
                    },

                    // 18. UI Libraries & Ecosystem
                    new RoadmapStep
                    {
                        Id = 2118,
                        RoadmapId = 21,
                        Title = "UI Libraries & Ecosystem",
                        Duration = "3-4 weeks",
                        Content = "Master popular Angular UI libraries and component development patterns",
                        KeyConcepts = new List<string>
                        {
                            "Angular Material & CDK",
                            "PrimeNG Components",
                            "NG Bootstrap",
                            "TailwindCSS Integration",
                            "Custom Component Libraries",
                            "Storybook for Angular"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 21181, StepId = 2118, Description = "Master Angular Material components" },
                            new LearningObjective { Id = 21182, StepId = 2118, Description = "Build with Angular CDK" },
                            new LearningObjective { Id = 21183, StepId = 2118, Description = "Create reusable component libraries" },
                            new LearningObjective { Id = 21184, StepId = 2118, Description = "Document with Storybook" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 21181, StepId = 2118, Title = "Angular Material Documentation", Type = "Documentation", Url = "https://material.angular.io/" },
                            new Resource { Id = 21182, StepId = 2118, Title = "Angular CDK Guide", Type = "Guide", Url = "https://material.angular.io/cdk/categories" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build custom theme for Material",
                            "Create component library with CDK",
                            "Set up Storybook documentation"
                        }
                    },

                    // 19. Architecture & Best Practices
                    new RoadmapStep
                    {
                        Id = 2119,
                        RoadmapId = 21,
                        Title = "Architecture & Best Practices",
                        Duration = "3-4 weeks",
                        Content = "Master enterprise-scale architecture patterns and Angular best practices",
                        KeyConcepts = new List<string>
                        {
                            "Monorepo with Nx",
                            "Clean Architecture",
                            "Feature Modules Pattern",
                            "Facade Pattern",
                            "Scalable Folder Structure",
                            "Code Style & Linting"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 21191, StepId = 2119, Description = "Design scalable app architecture" },
                            new LearningObjective { Id = 21192, StepId = 2119, Description = "Implement clean architecture principles" },
                            new LearningObjective { Id = 21193, StepId = 2119, Description = "Set up Nx monorepo workspace" },
                            new LearningObjective { Id = 21194, StepId = 2119, Description = "Enforce coding standards" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 21191, StepId = 2119, Title = "Angular Style Guide", Type = "Guide", Url = "https://angular.io/guide/styleguide" },
                            new Resource { Id = 21192, StepId = 2119, Title = "Nx Documentation", Type = "Documentation", Url = "https://nx.dev/angular" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Refactor app to clean architecture",
                            "Set up Nx monorepo with libraries",
                            "Implement automated code quality checks"
                        }
                    },

                    // 20. Emerging & Advanced Topics
                    new RoadmapStep
                    {
                        Id = 2120,
                        RoadmapId = 21,
                        Title = "Emerging & Advanced Topics",
                        Duration = "4-5 weeks",
                        Content = "Explore cutting-edge Angular features and advanced integration patterns",
                        KeyConcepts = new List<string>
                        {
                            "Standalone Components",
                            "Angular Signals",
                            "SSR with Angular Universal",
                            "Module Federation",
                            "WebAssembly Integration",
                            "AI/ML Integration"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 21201, StepId = 2120, Description = "Migrate to standalone components" },
                            new LearningObjective { Id = 21202, StepId = 2120, Description = "Implement Angular Signals" },
                            new LearningObjective { Id = 21203, StepId = 2120, Description = "Add server-side rendering" },
                            new LearningObjective { Id = 21204, StepId = 2120, Description = "Build micro-frontends" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 21201, StepId = 2120, Title = "Standalone Components Guide", Type = "Guide", Url = "https://angular.io/guide/standalone-components" },
                            new Resource { Id = 21202, StepId = 2120, Title = "Angular Signals RFC", Type = "Documentation", Url = "https://github.com/angular/angular/discussions/49685" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Convert app to standalone components",
                            "Implement SSR with Universal",
                            "Create micro-frontend architecture"
                        }
                    }
                };
            }
        }
    }
}