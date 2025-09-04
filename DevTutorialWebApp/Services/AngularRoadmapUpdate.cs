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
                            "Angular Architecture: Component-based architecture with hierarchical component tree. Application structure includes modules, components, services, and directives working together through dependency injection system.",
                            "Modules (NgModule): Containers for cohesive blocks of code dedicated to specific application domain or workflow. Root module bootstraps application, feature modules organize functionality by business domain.",
                            "Components & Templates: Components control views (templates) and contain application logic. Templates use Angular's declarative syntax with interpolation, property binding, and event binding for dynamic UIs.",
                            "Directives (Structural & Attribute): Classes that add behavior to elements. Structural directives (*ngIf, *ngFor) change DOM structure, attribute directives modify element appearance or behavior.",
                            "Data Binding Types: Four types - interpolation {{}}, property binding [], event binding (), and two-way binding [()]. Enable communication between component class and template for reactive UIs.",
                            "Dependency Injection: Design pattern where dependencies are provided to components rather than created internally. Angular's DI system manages service instances and promotes testable, modular code."
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
                            "Types & Interfaces: Static type system for JavaScript enabling type safety at compile time. Interfaces define contracts for object shapes, types provide compile-time guarantees reducing runtime errors.",
                            "Classes & Inheritance: Object-oriented programming features with class syntax, inheritance, and access modifiers. TypeScript classes compile to JavaScript functions with prototype-based inheritance.",
                            "Decorators & Metadata: Special declarations that modify classes, methods, or properties. Angular extensively uses decorators (@Component, @Injectable, @Input) for metadata-driven development.",
                            "Generics & Type Guards: Generics enable type-safe reusable components. Type guards are runtime checks that narrow types, enabling safe access to type-specific properties and methods.",
                            "Modules & Namespaces: Code organization features enabling modularity and scope management. ES6 modules with import/export provide standard module system for TypeScript applications.",
                            "Access Modifiers: Keywords (public, private, protected) controlling member accessibility in classes. Enable encapsulation and information hiding for better object-oriented design."
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
                            "Project Setup & Configuration: Angular CLI commands for creating projects with customizable options. Configuration includes TypeScript settings, linting rules, and build optimization parameters.",
                            "Schematics & Code Generation: Templates for generating and modifying code. Built-in schematics create components, services, modules while custom schematics automate project-specific patterns.",
                            "Angular Workspace Structure: Organizational structure with angular.json configuration, src folder containing app code, and projects folder for multiple applications and libraries.",
                            "Configuration Files: Key files including angular.json (workspace config), tsconfig.json (TypeScript config), package.json (dependencies), and environment files for different deployment targets.",
                            "Building & Serving Apps: Development server with live reload, production builds with optimization (minification, tree-shaking, bundling), and deployment preparation with different build configurations.",
                            "Environment Management: Configuration for different deployment environments (development, staging, production) with environment-specific settings and feature flags."
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
                            "Component Lifecycle Hooks: Eight lifecycle hooks that Angular calls in sequence from component creation to destruction. Includes ngOnInit for initialization logic, ngOnChanges for input property changes, ngOnDestroy for cleanup. Essential for proper resource management and performance optimization.",
                            "@Input & @Output Properties: Decorators enabling parent-child component communication. @Input allows parent to pass data down to child components, @Output enables child to emit events up to parent. Foundation of Angular's unidirectional data flow architecture.",
                            "ViewChild & ContentChild: Template query decorators for accessing child components, directives, or DOM elements. ViewChild queries view children (template), ContentChild queries projected content. Critical for component interaction and DOM manipulation.",
                            "Change Detection Strategies: Mechanisms controlling when Angular checks for changes. Default strategy checks entire component tree, OnPush strategy only checks when inputs change or events occur. Key to optimizing performance in large applications.",
                            "Smart vs Dumb Components: Architectural pattern separating components by responsibility. Smart components handle data and logic, dumb components only display data and emit events. Promotes reusability, testability, and maintainable code structure.",
                            "Dynamic Component Loading: Programmatically creating and inserting components at runtime using ComponentFactoryResolver and ViewContainerRef. Enables flexible UIs like modals, tabs, and dynamic forms based on runtime conditions."
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
                            "Template Syntax & Expressions: Angular's declarative template language for defining component views. Includes interpolation {{}}, property/event binding, structural directives, and template expressions. Enables reactive UI development with TypeScript integration.",
                            "Template Reference Variables: Variables declared in templates using # syntax to reference DOM elements or component instances. Provides direct access to elements for form handling, focus management, and component interaction within templates.",
                            "View Encapsulation Modes: Strategies for scoping component styles - Emulated (default) uses attribute shimming, None applies styles globally, ShadowDom uses native shadow DOM. Critical for preventing style conflicts and creating reusable components.",
                            "CSS/SCSS in Angular: Styling approaches including component styles, global styles, and preprocessor support. Features include :host and ::ng-deep selectors, CSS variables integration, and dynamic style binding for theme systems.",
                            "Angular Animations API: Programmatic animation system built on Web Animations API. Enables complex state-based animations, route transitions, and staggered animations using triggers, states, and transitions with TypeScript control.",
                            "Responsive Design Patterns: Strategies for building adaptive UIs including Angular Flex Layout, CDK Layout utilities, and responsive directives. Combines media queries, viewport units, and dynamic component loading for optimal mobile experiences."
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
                            "Router Configuration: Declarative route definitions mapping URLs to components. Includes path matching strategies, wildcards, redirects, and route ordering. Forms the navigation backbone of single-page applications with deep linking support.",
                            "Route Guards (CanActivate, etc.): Interfaces controlling navigation flow - CanActivate for access control, CanDeactivate for unsaved changes, Resolve for data preloading, CanLoad for lazy-loaded modules. Essential for authentication, authorization, and data integrity.",
                            "Route Parameters & Query Params: Mechanisms for passing data through URLs. Route parameters are required path segments, query parameters are optional key-value pairs. Enable stateful navigation and shareable URLs with data context.",
                            "Lazy Loading Modules: Loading feature modules on-demand to reduce initial bundle size. Uses dynamic imports with loadChildren property, splitting code into separate chunks loaded when routes are accessed. Critical for performance in large applications.",
                            "Preloading Strategies: Techniques for loading lazy modules in background after initial load. Includes PreloadAllModules, custom strategies based on user behavior or network conditions. Balances performance with resource optimization.",
                            "Nested Routes & Aux Routes: Hierarchical route structures with child routes and multiple router outlets. Auxiliary routes enable independent navigation areas like sidebars or modals. Supports complex layouts with multiple simultaneous views."
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
                            "Template-driven Forms: Declarative approach using directives in templates. Two-way binding with ngModel, validation through HTML5 attributes and directives. Simple for basic forms but limited for complex scenarios requiring dynamic behavior.",
                            "Reactive Forms & FormBuilder: Programmatic form creation with explicit state management in component class. FormBuilder service provides convenient API for creating form controls, groups, and arrays. Enables complex validation, dynamic forms, and better testability.",
                            "FormControl & FormGroup: Building blocks of reactive forms. FormControl represents single input value with validation state, FormGroup contains multiple controls as object structure. Provides fine-grained control over form state, validation, and value changes.",
                            "FormArray for Dynamic Forms: Managing variable-length collections of form controls. Enables adding/removing form fields at runtime like dynamic questionnaires, shopping carts, or multi-step wizards. Essential for user-driven form structures.",
                            "Custom Validators & Async Validators: Creating reusable validation logic beyond built-in validators. Synchronous validators for immediate checks, async validators for server-side validation like username availability. Supports complex business rules and real-time validation feedback.",
                            "Cross-field Validation: Validation logic spanning multiple form fields like password confirmation or date ranges. Implemented at FormGroup level comparing multiple control values. Critical for maintaining data integrity across related fields."
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
                            "Observables & Subjects: Core RxJS primitives for handling asynchronous data streams. Observables are lazy push collections, Subjects are multicast observables acting as both observer and observable. Foundation for reactive programming in Angular applications.",
                            "Creation & Transformation Operators: Functions creating observables from various sources (of, from, interval) and transforming emitted values (map, scan, reduce). Enable declarative data manipulation and stream composition for complex async workflows.",
                            "Filtering & Combination Operators: Operators controlling which values pass through (filter, take, skip) and combining multiple streams (merge, concat, combineLatest, forkJoin). Essential for coordinating multiple async operations and user interactions.",
                            "Error Handling & Retry Logic: Strategies for graceful error recovery using catchError, retry, retryWhen operators. Implements resilient applications with automatic retry policies, fallback values, and error transformation for better user experience.",
                            "Higher-order Observables: Observables emitting other observables, flattened using mergeMap, switchMap, concatMap, exhaustMap. Critical for handling nested async operations like sequential API calls or user-triggered searches with cancellation.",
                            "Hot vs Cold Observables: Cold observables create new execution for each subscriber (like HTTP requests), hot observables share single execution among subscribers (like mouse events). Understanding difference prevents bugs in state management and resource usage."
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
                            "HttpClient & HTTP Methods: Angular's service for making HTTP requests supporting all REST methods (GET, POST, PUT, DELETE). Returns observables for reactive handling, includes typed responses, and integrates with RxJS operators for powerful data manipulation.",
                            "HTTP Interceptors: Middleware mechanism for intercepting and transforming HTTP requests/responses globally. Used for authentication tokens, logging, error handling, loading indicators, and request/response transformation. Central point for cross-cutting HTTP concerns.",
                            "Request/Response Transformation: Modifying HTTP data using interceptors and RxJS operators. Request transformation adds headers or modifies body, response transformation maps API data to application models. Enables clean separation between API and application layers.",
                            "Error Handling & Retry: Implementing resilient HTTP communication with automatic retry on failure. Uses RxJS retry operators with exponential backoff, circuit breaker patterns, and graceful degradation. Critical for handling network instability and server errors.",
                            "Caching Strategies: Techniques for storing HTTP responses to reduce server load and improve performance. Includes in-memory caching, localStorage persistence, cache invalidation strategies, and conditional requests. Essential for offline functionality and performance optimization.",
                            "File Upload/Download: Handling binary data transfers with progress tracking. Supports multipart uploads, streaming downloads, progress events, and cancellation. Includes resumable uploads and proper error handling for large file operations."
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
                            "Component State Management: Local state management within components using properties and lifecycle hooks. Simple approach for UI state like form values, loading flags, and view modes. Suitable for isolated components with minimal state sharing needs.",
                            "Service-based State: Centralized state using Angular services with BehaviorSubject or custom state containers. Enables state sharing between components through dependency injection. Good balance between simplicity and functionality for medium-complexity applications.",
                            "NgRx Store & Actions: Redux-inspired state container providing single source of truth for application state. Store holds immutable state tree, actions describe state changes as plain objects. Enables predictable state updates, time-travel debugging, and DevTools integration.",
                            "Reducers & Effects: Pure functions (reducers) handling synchronous state transitions based on actions. Effects handle side effects like API calls, returning new actions. Clear separation of concerns between state calculation and async operations.",
                            "Selectors & Memoization: Functions deriving data from store state with automatic memoization for performance. Compose complex queries from simple selectors, prevent unnecessary recalculations. Critical for efficient state consumption in large applications.",
                            "Entity Management: Patterns and utilities for managing collections of entities in normalized state. NgRx Entity provides adapter API for CRUD operations, sorting, and filtering. Reduces boilerplate for common data manipulation patterns."
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
                            "Jasmine & Karma Setup: Default testing framework (Jasmine) providing BDD-style syntax with describe/it blocks and matchers. Karma test runner executes tests in real browsers, watches file changes, and generates reports. Foundation for Angular's testing infrastructure.",
                            "TestBed & ComponentFixture: Angular's testing utilities for creating component test environments. TestBed configures testing module with dependencies, ComponentFixture provides wrapper for component instance and DOM access. Enables isolated component testing with mocked dependencies.",
                            "Service & Pipe Testing: Testing strategies for Angular services and pipes as pure units. Services tested with dependency injection mocking, pipes tested as pure functions. Focuses on business logic validation without UI complexity.",
                            "HTTP Testing & Mocking: Testing HTTP-dependent code using HttpClientTestingModule and HttpTestingController. Mock backend responses, verify request parameters, test error scenarios. Ensures reliable API integration testing without real network calls.",
                            "E2E with Cypress/Playwright: Modern end-to-end testing frameworks replacing Protractor. Test real user workflows across multiple pages, interact with actual DOM, verify integration between all application layers. Essential for confidence in production deployments.",
                            "Code Coverage: Metrics measuring percentage of code executed during tests. Karma coverage reports identify untested code paths, enforce minimum thresholds in CI/CD. Guides testing efforts but not sole measure of test quality."
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
                            "Lazy Loading & Code Splitting: Loading features only when needed, splitting application into separate JavaScript chunks. Reduces initial bundle size, improves time-to-interactive. Implemented through router configuration with dynamic imports for scalable applications.",
                            "OnPush Change Detection: Optimization strategy checking component only when inputs change or events occur. Bypasses default change detection cycle, dramatically improves performance in complex component trees. Requires immutable data patterns for reliability.",
                            "Tree Shaking & Bundle Size: Build optimization removing unused code from final bundles. Webpack eliminates dead code, Angular CLI optimizes imports. Combined with lazy loading and proper imports reduces application size significantly.",
                            "TrackBy Functions: Custom tracking for ngFor loops preventing unnecessary DOM manipulation. Returns unique identifier for list items, enabling Angular to reuse DOM elements when data changes. Critical for performance with large lists or frequent updates.",
                            "Virtual Scrolling: Rendering only visible items in large lists using CDK Virtual Scrolling. Maintains constant DOM element count regardless of data size. Enables smooth scrolling through thousands of items without performance degradation.",
                            "Web Workers Integration: Offloading heavy computations to background threads preventing UI blocking. Angular CLI supports Web Workers for data processing, image manipulation, or complex calculations. Maintains 60fps interactions during intensive operations."
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
                            "Service Worker Setup: Implementing offline functionality using Angular's service worker module. Automatically generated configuration handles caching, updates, and offline fallbacks. Transforms regular web apps into reliable offline-capable applications.",
                            "App Manifest Configuration: Web app manifest defining PWA metadata like name, icons, display mode, and theme colors. Enables add-to-homescreen functionality, fullscreen mode, and native-like appearance. Critical for mobile user experience and app discovery.",
                            "Offline Caching Strategies: Techniques for storing resources and data offline - cache-first for static assets, network-first for dynamic content, stale-while-revalidate for balance. Ensures app functionality without network connection.",
                            "Push Notifications: Engaging users with timely updates using Push API and service workers. Requires notification permissions, server-side infrastructure for sending messages. Increases user engagement and retention through relevant alerts.",
                            "Background Sync: Deferring actions until stable network connection available. Queues failed requests, retries when online, ensures data integrity. Critical for form submissions, file uploads in unreliable network conditions.",
                            "App Shell Architecture: Minimal HTML, CSS, and JavaScript powering user interface cached for instant loading. Separates static UI shell from dynamic content, provides immediate visual feedback. Foundation for perceived performance in PWAs."
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
                            "Angular i18n Tools: Built-in internationalization framework for extracting, translating, and loading locale-specific content. Uses i18n attributes in templates, xi18n extraction tool, and locale-specific builds. Enables applications to support multiple languages efficiently.",
                            "Translation Management: Workflow for managing translatable content including extraction, translation, and integration. Supports XLIFF, XMB, and JSON formats, integration with translation management systems. Critical for maintaining consistency across language versions.",
                            "Locale-specific Formatting: Formatting dates, numbers, and currencies according to locale rules using Angular pipes. Automatic locale detection, custom locale data registration. Ensures culturally appropriate data presentation for global users.",
                            "RTL Support: Right-to-left language support for Arabic, Hebrew, and other RTL scripts. Requires direction-aware CSS, layout adjustments, and bidirectional text handling. Essential for true global application accessibility.",
                            "ARIA Attributes: Accessibility attributes making applications usable with assistive technologies. Includes roles, states, and properties for semantic meaning. Required for WCAG compliance and inclusive user experience for disabled users.",
                            "Keyboard Navigation: Ensuring all functionality accessible via keyboard without mouse. Includes focus management, tab order, keyboard shortcuts, and skip links. Critical for power users and accessibility compliance."
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
                            "XSS Prevention: Angular's built-in protection against Cross-Site Scripting attacks through automatic sanitization of values in templates. Treats all values as untrusted by default, escapes dangerous content. Critical first line of defense against injection attacks.",
                            "CSRF Protection: Cross-Site Request Forgery prevention using token-based validation. Angular's HttpClient reads XSRF token from cookie, adds to HTTP headers. Prevents unauthorized actions using authenticated user's credentials.",
                            "Content Security Policy: HTTP headers restricting resources browser can load, preventing XSS and data injection. Requires careful configuration with Angular's inline styles and scripts. Essential security layer for production applications.",
                            "DomSanitizer Usage: Service for bypassing Angular's sanitization when trusted content required. Methods like bypassSecurityTrustHtml for rendering user content. Must be used carefully only with validated, trusted sources to maintain security.",
                            "JWT Authentication: JSON Web Token implementation for stateless authentication. Includes secure storage, automatic token refresh, interceptor integration for API requests. Standard approach for modern SPA authentication with backend APIs.",
                            "Route Guards & RBAC: Implementing role-based access control through Angular's route guard system. CanActivate guards check permissions, redirect unauthorized users. Combines with JWT claims for fine-grained authorization throughout application."
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
                            "REST API Integration: Building robust RESTful API clients using HttpClient with proper error handling, retry logic, and response transformation. Includes pagination handling, query parameter building, and standardized error responses. Foundation for most web applications.",
                            "GraphQL with Apollo: Implementing GraphQL clients using Apollo Angular for flexible data fetching. Features include query batching, caching, optimistic updates, and subscription support. Reduces over-fetching and enables precise data requirements.",
                            "WebSockets & SignalR: Real-time bidirectional communication for live updates, chat, and collaboration features. SignalR provides fallback transports, automatic reconnection, and hub-based architecture. Essential for interactive, real-time applications.",
                            "gRPC Web Clients: High-performance RPC framework using Protocol Buffers for efficient serialization. Enables strongly-typed service contracts, streaming support, and better performance than JSON/REST. Ideal for microservices communication.",
                            "Firebase Integration: Backend-as-a-Service integration providing authentication, real-time database, cloud storage, and hosting. AngularFire library offers Observable-based APIs matching Angular patterns. Rapid development solution for modern applications.",
                            "API Versioning: Strategies for handling multiple API versions including URL versioning, header-based versioning, and content negotiation. Ensures backward compatibility while enabling API evolution. Critical for maintaining stable client-server contracts."
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
                            "Build Configurations: Custom build settings for different environments using angular.json configurations. Includes optimization levels, source maps, budgets, and file replacements. Enables consistent builds across development, staging, and production environments.",
                            "AOT Compilation: Ahead-of-Time compilation converting Angular templates to JavaScript during build. Smaller bundles, faster rendering, early error detection, better tree-shaking. Default for production builds, critical for performance.",
                            "Differential Loading: Generating separate bundles for modern and legacy browsers automatically. Modern browsers receive smaller ES2015+ bundles, older browsers get larger ES5 bundles. Optimizes performance while maintaining compatibility.",
                            "Docker Containerization: Packaging Angular applications with web servers in Docker containers. Includes multi-stage builds for optimization, nginx configuration, environment variable injection. Ensures consistent deployment across environments.",
                            "CI/CD Pipelines: Automated build, test, and deployment workflows using GitHub Actions, Jenkins, or Azure DevOps. Includes linting, testing, building, and deploying to various environments. Essential for maintaining code quality and rapid delivery.",
                            "CDN Deployment: Distributing static assets globally through Content Delivery Networks. Includes cache busting strategies, compression, custom headers, and geographic distribution. Dramatically improves loading performance for global users."
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
                            "Angular Material & CDK: Google's Material Design components for Angular with Component Dev Kit. Provides production-ready UI components, theming system, accessibility features, and low-level CDK primitives for building custom components.",
                            "PrimeNG Components: Comprehensive UI component suite with 80+ components including data tables, charts, and form controls. Features built-in themes, responsive design, and enterprise-focused components like organization charts and terminals.",
                            "NG Bootstrap: Native Angular directives for Bootstrap components without jQuery dependency. Provides type safety, Angular integration, and accessibility improvements over vanilla Bootstrap. Ideal for teams familiar with Bootstrap ecosystem.",
                            "TailwindCSS Integration: Utility-first CSS framework integration with Angular's build system. Enables rapid UI development with atomic classes, PurgeCSS integration for production optimization. Popular for custom designs without writing CSS.",
                            "Custom Component Libraries: Building reusable component libraries for organization-wide consistency. Includes Angular workspace setup, npm publishing, versioning strategies, and documentation. Essential for large teams and design system implementation.",
                            "Storybook for Angular: Interactive component development and documentation environment. Enables isolated component development, visual testing, and living documentation. Critical tool for maintaining component libraries and design systems."
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
                            "Monorepo with Nx: Managing multiple Angular applications and libraries in single repository using Nx workspace. Provides code sharing, consistent tooling, dependency graph visualization, and affected commands. Essential for enterprise-scale development.",
                            "Clean Architecture: Organizing code into layers with clear separation of concerns - presentation, business logic, and data access. Domain-driven design principles, dependency inversion, and testability. Creates maintainable, scalable applications.",
                            "Feature Modules Pattern: Organizing functionality into self-contained feature modules with clear boundaries. Includes lazy loading, module dependencies, and shared modules. Promotes code organization, reusability, and team collaboration.",
                            "Facade Pattern: Service layer abstracting complex state management and business logic from components. Simplifies component code, centralizes logic, improves testability. Acts as API boundary between smart components and application core.",
                            "Scalable Folder Structure: Organizing files by feature rather than file type, with consistent naming conventions. Includes barrels for exports, shared utilities placement, and growth accommodation. Critical for long-term maintainability.",
                            "Code Style & Linting: Enforcing consistent code standards using ESLint, Prettier, and Angular style guide. Includes custom rules, pre-commit hooks, and CI integration. Ensures code quality and reduces review friction across teams."
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
                            "Standalone Components: New Angular architecture eliminating NgModules requirement. Components declare their dependencies directly, enabling better tree-shaking, simpler mental model, and easier migration paths. Future of Angular development.",
                            "Angular Signals: Reactive primitive for managing state with automatic dependency tracking. Fine-grained reactivity system improving performance over zone.js change detection. Enables more predictable, efficient state management patterns.",
                            "SSR with Angular Universal: Server-side rendering for improved SEO, faster initial load, and better performance scores. Includes hydration, transfer state, and platform-specific code handling. Critical for public-facing, content-heavy applications.",
                            "Module Federation: Webpack 5 feature enabling runtime code sharing between separately deployed applications. Supports micro-frontend architecture, independent deployments, and dynamic remote loading. Solution for large-scale distributed applications.",
                            "WebAssembly Integration: Running high-performance code written in languages like C++ or Rust within Angular applications. Enables compute-intensive operations, legacy code integration, and near-native performance for specific tasks.",
                            "AI/ML Integration: Incorporating machine learning models using TensorFlow.js, ONNX Runtime, or cloud APIs. Enables intelligent features like image recognition, natural language processing, and predictive analytics directly in Angular applications."
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