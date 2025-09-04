using System.Collections.Generic;
using System.Linq;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Services
{
    public partial class RoadmapService
    {
        private void UpdateJavaScriptRoadmap(List<Roadmap> roadmaps)
        {
            var jsDev = roadmaps.FirstOrDefault(r => r.Id == 19);
            if (jsDev != null)
            {
                // Update the JavaScript roadmap with comprehensive structure
                jsDev.Title = "JavaScript Developer";
                jsDev.Description = "Master JavaScript from fundamentals to advanced concepts and modern development practices";
                jsDev.Duration = "10-14 months";
                jsDev.Difficulty = "Beginner to Expert";
                jsDev.Context = "JavaScript is the programming language of the web and increasingly important for full-stack development. This comprehensive path covers everything from language fundamentals to advanced patterns, frameworks, and modern JavaScript ecosystem including Node.js, testing, and emerging technologies.";
                
                jsDev.Prerequisites = new List<string>
                {
                    "Basic computer literacy",
                    "HTML and CSS fundamentals",
                    "Logical thinking and problem-solving skills",
                    "Text editor or IDE familiarity"
                };
                
                jsDev.CareerPaths = new List<string>
                {
                    "JavaScript Developer ($65K-$130K)",
                    "Frontend Developer ($70K-$140K)",
                    "Full Stack Developer ($80K-$160K)",
                    "Node.js Developer ($75K-$145K)",
                    "Senior JavaScript Engineer ($100K-$180K)",
                    "Technical Lead ($110K-$190K)"
                };

                // Replace existing steps with comprehensive 21-category structure
                jsDev.Steps = new List<RoadmapStep>
                {
                    // 1. Core JavaScript Fundamentals
                    new RoadmapStep
                    {
                        Id = 1901,
                        RoadmapId = 19,
                        Title = "Core JavaScript Fundamentals",
                        Duration = "3-4 weeks",
                        Content = "Master the essential building blocks of JavaScript including syntax, data types, operators, and expressions",
                        KeyConcepts = new List<string> 
                        { 
                            "JavaScript History & Evolution",
                            "Variables & Constants (var, let, const)",
                            "Data Types (Primitives & Objects)",
                            "Type Conversion & Coercion",
                            "Operators & Expressions",
                            "Statements vs Expressions"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19011, StepId = 1901, Description = "Understand JavaScript's evolution and modern features" },
                            new LearningObjective { Id = 19012, StepId = 1901, Description = "Master variable declarations and scoping rules" },
                            new LearningObjective { Id = 19013, StepId = 1901, Description = "Work effectively with all JavaScript data types" },
                            new LearningObjective { Id = 19014, StepId = 1901, Description = "Handle type coercion and conversion properly" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19011, StepId = 1901, Title = "MDN JavaScript Guide", Type = "Documentation", Url = "https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide" },
                            new Resource { Id = 19012, StepId = 1901, Title = "JavaScript.info Tutorial", Type = "Tutorial", Url = "https://javascript.info/" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build a calculator with all data types",
                            "Create variable scoping examples demonstrating let/const/var differences",
                            "Implement type conversion utility functions"
                        }
                    },

                    // 2. Functions & Scope
                    new RoadmapStep
                    {
                        Id = 1902,
                        RoadmapId = 19,
                        Title = "Functions & Scope",
                        Duration = "3-4 weeks",
                        Content = "Master function concepts, scope chains, closures, and functional programming patterns",
                        KeyConcepts = new List<string>
                        {
                            "Function Declarations vs Expressions",
                            "Arrow Functions",
                            "Parameters & Arguments",
                            "Scope & Closures",
                            "Higher-Order Functions",
                            "Functional Programming Patterns"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19021, StepId = 1902, Description = "Master all function declaration styles" },
                            new LearningObjective { Id = 19022, StepId = 1902, Description = "Understand scope and closure mechanisms" },
                            new LearningObjective { Id = 19023, StepId = 1902, Description = "Implement higher-order functions effectively" },
                            new LearningObjective { Id = 19024, StepId = 1902, Description = "Apply functional programming concepts" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19021, StepId = 1902, Title = "Functions Deep Dive", Type = "Guide", Url = "https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Functions" },
                            new Resource { Id = 19022, StepId = 1902, Title = "You Don't Know JS: Scope & Closures", Type = "Book", Url = "https://github.com/getify/You-Dont-Know-JS" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build a function composition library",
                            "Create closure-based module pattern examples",
                            "Implement currying and partial application utilities"
                        }
                    },

                    // 3. Control Flow
                    new RoadmapStep
                    {
                        Id = 1903,
                        RoadmapId = 19,
                        Title = "Control Flow",
                        Duration = "2-3 weeks",
                        Content = "Master control structures, iteration patterns, and error handling mechanisms",
                        KeyConcepts = new List<string>
                        {
                            "Conditionals & Branching",
                            "Loops & Iteration",
                            "Iterators & Generators",
                            "Error Handling",
                            "Custom Error Types",
                            "Flow Control Best Practices"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19031, StepId = 1903, Description = "Implement efficient conditional logic" },
                            new LearningObjective { Id = 19032, StepId = 1903, Description = "Master all iteration patterns" },
                            new LearningObjective { Id = 19033, StepId = 1903, Description = "Handle errors gracefully and effectively" },
                            new LearningObjective { Id = 19034, StepId = 1903, Description = "Create custom iterators and generators" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19031, StepId = 1903, Title = "Control Flow and Error Handling", Type = "Guide", Url = "https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Control_flow_and_error_handling" },
                            new Resource { Id = 19032, StepId = 1903, Title = "Iterators and Generators", Type = "Tutorial", Url = "https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Iterators_and_Generators" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build a custom error handling system",
                            "Create generators for pagination and infinite scrolling",
                            "Implement complex control flow for game logic"
                        }
                    },

                    // 4. Objects & Prototypes
                    new RoadmapStep
                    {
                        Id = 1904,
                        RoadmapId = 19,
                        Title = "Objects & Prototypes",
                        Duration = "3-4 weeks",
                        Content = "Master object-oriented programming in JavaScript with prototypes, classes, and inheritance",
                        KeyConcepts = new List<string>
                        {
                            "Object Creation Patterns",
                            "Prototypal Inheritance",
                            "ES6 Classes",
                            "this Keyword Binding",
                            "Object Manipulation",
                            "Symbols & Metadata"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19041, StepId = 1904, Description = "Master prototype chain and inheritance" },
                            new LearningObjective { Id = 19042, StepId = 1904, Description = "Understand 'this' binding in all contexts" },
                            new LearningObjective { Id = 19043, StepId = 1904, Description = "Use ES6 classes effectively" },
                            new LearningObjective { Id = 19044, StepId = 1904, Description = "Implement design patterns with objects" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19041, StepId = 1904, Title = "Object-oriented JavaScript", Type = "Guide", Url = "https://developer.mozilla.org/en-US/docs/Learn/JavaScript/Objects" },
                            new Resource { Id = 19042, StepId = 1904, Title = "this & Object Prototypes", Type = "Book", Url = "https://github.com/getify/You-Dont-Know-JS" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build inheritance hierarchies with prototypes",
                            "Create factory and constructor patterns",
                            "Implement method chaining and fluent interfaces"
                        }
                    },

                    // 5. Arrays
                    new RoadmapStep
                    {
                        Id = 1905,
                        RoadmapId = 19,
                        Title = "Arrays & Data Manipulation",
                        Duration = "2-3 weeks",
                        Content = "Master array operations, functional array methods, and data transformation patterns",
                        KeyConcepts = new List<string>
                        {
                            "Array Creation & Access",
                            "Mutating vs Non-Mutating Methods",
                            "Functional Array Methods",
                            "Array Destructuring",
                            "Multi-dimensional Arrays",
                            "Typed Arrays"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19051, StepId = 1905, Description = "Master all array manipulation methods" },
                            new LearningObjective { Id = 19052, StepId = 1905, Description = "Apply functional programming with arrays" },
                            new LearningObjective { Id = 19053, StepId = 1905, Description = "Handle complex data transformations" },
                            new LearningObjective { Id = 19054, StepId = 1905, Description = "Work with typed arrays for performance" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19051, StepId = 1905, Title = "Array Methods Reference", Type = "Reference", Url = "https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array" },
                            new Resource { Id = 19052, StepId = 1905, Title = "Functional JavaScript", Type = "Tutorial", Url = "https://mostly-adequate.gitbook.io/mostly-adequate-guide/" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build data processing pipeline with array methods",
                            "Create utility library for array operations",
                            "Implement complex sorting and filtering algorithms"
                        }
                    },

                    // 6. Asynchronous JavaScript
                    new RoadmapStep
                    {
                        Id = 1906,
                        RoadmapId = 19,
                        Title = "Asynchronous JavaScript",
                        Duration = "4-5 weeks",
                        Content = "Master async programming with callbacks, promises, async/await, and event loop understanding",
                        KeyConcepts = new List<string>
                        {
                            "Callbacks & Callback Hell",
                            "Promises & Promise Chaining",
                            "Async/Await Patterns",
                            "Event Loop & Task Queue",
                            "Microtasks vs Macrotasks",
                            "Observable Patterns"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19061, StepId = 1906, Description = "Master promises and async/await patterns" },
                            new LearningObjective { Id = 19062, StepId = 1906, Description = "Understand event loop and task scheduling" },
                            new LearningObjective { Id = 19063, StepId = 1906, Description = "Handle async errors effectively" },
                            new LearningObjective { Id = 19064, StepId = 1906, Description = "Implement observable patterns" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19061, StepId = 1906, Title = "Asynchronous JavaScript", Type = "Guide", Url = "https://developer.mozilla.org/en-US/docs/Learn/JavaScript/Asynchronous" },
                            new Resource { Id = 19062, StepId = 1906, Title = "JavaScript Event Loop", Type = "Article", Url = "https://developer.mozilla.org/en-US/docs/Web/JavaScript/EventLoop" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build async data fetching library",
                            "Create Promise-based utility functions",
                            "Implement async iteration patterns"
                        }
                    },

                    // 7. Events & DOM
                    new RoadmapStep
                    {
                        Id = 1907,
                        RoadmapId = 19,
                        Title = "Events & DOM Manipulation",
                        Duration = "3-4 weeks",
                        Content = "Master DOM manipulation, event handling, and browser interaction patterns",
                        KeyConcepts = new List<string>
                        {
                            "DOM Selection & Manipulation",
                            "Event System & Delegation",
                            "Event Propagation",
                            "Custom Events",
                            "Form Handling",
                            "Touch & Pointer Events"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19071, StepId = 1907, Description = "Master efficient DOM manipulation" },
                            new LearningObjective { Id = 19072, StepId = 1907, Description = "Implement event delegation patterns" },
                            new LearningObjective { Id = 19073, StepId = 1907, Description = "Handle all types of user events" },
                            new LearningObjective { Id = 19074, StepId = 1907, Description = "Create custom event systems" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19071, StepId = 1907, Title = "DOM Manipulation Guide", Type = "Guide", Url = "https://developer.mozilla.org/en-US/docs/Web/API/Document_Object_Model" },
                            new Resource { Id = 19072, StepId = 1907, Title = "Event Handling Tutorial", Type = "Tutorial", Url = "https://developer.mozilla.org/en-US/docs/Learn/JavaScript/Building_blocks/Events" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build interactive web components",
                            "Create drag-and-drop interface",
                            "Implement custom event bus system"
                        }
                    },

                    // 8. Modules & Code Organization
                    new RoadmapStep
                    {
                        Id = 1908,
                        RoadmapId = 19,
                        Title = "Modules & Code Organization",
                        Duration = "2-3 weeks",
                        Content = "Master module systems, code organization patterns, and dependency management",
                        KeyConcepts = new List<string>
                        {
                            "ES6 Modules",
                            "CommonJS & Node.js Modules",
                            "Module Bundling",
                            "Namespaces & IIFE",
                            "Tree Shaking",
                            "Dynamic Imports"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19081, StepId = 1908, Description = "Master ES6 module system" },
                            new LearningObjective { Id = 19082, StepId = 1908, Description = "Organize code with effective module patterns" },
                            new LearningObjective { Id = 19083, StepId = 1908, Description = "Implement dynamic loading strategies" },
                            new LearningObjective { Id = 19084, StepId = 1908, Description = "Optimize bundles with tree shaking" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19081, StepId = 1908, Title = "JavaScript Modules", Type = "Guide", Url = "https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules" },
                            new Resource { Id = 19082, StepId = 1908, Title = "Module Patterns", Type = "Article", Url = "https://addyosmani.com/resources/essentialjsdesignpatterns/" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Create modular application architecture",
                            "Build custom module bundler",
                            "Implement lazy loading with dynamic imports"
                        }
                    },

                    // 9. Error Handling & Debugging
                    new RoadmapStep
                    {
                        Id = 1909,
                        RoadmapId = 19,
                        Title = "Error Handling & Debugging",
                        Duration = "2-3 weeks",
                        Content = "Master debugging techniques, error handling patterns, and development tools",
                        KeyConcepts = new List<string>
                        {
                            "Error Types & Debugging",
                            "Browser DevTools",
                            "Console API",
                            "Debugging Strategies",
                            "Linting & Code Quality",
                            "Performance Profiling"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19091, StepId = 1909, Description = "Debug complex JavaScript applications" },
                            new LearningObjective { Id = 19092, StepId = 1909, Description = "Implement robust error handling" },
                            new LearningObjective { Id = 19093, StepId = 1909, Description = "Use profiling tools for optimization" },
                            new LearningObjective { Id = 19094, StepId = 1909, Description = "Set up automated code quality checks" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19091, StepId = 1909, Title = "Chrome DevTools Guide", Type = "Tutorial", Url = "https://developers.google.com/web/tools/chrome-devtools" },
                            new Resource { Id = 19092, StepId = 1909, Title = "ESLint Configuration", Type = "Documentation", Url = "https://eslint.org/docs/user-guide/" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Debug complex async application",
                            "Set up comprehensive linting rules",
                            "Create error tracking and reporting system"
                        }
                    },

                    // 10. Browser APIs
                    new RoadmapStep
                    {
                        Id = 1910,
                        RoadmapId = 19,
                        Title = "Browser APIs & Web Platform",
                        Duration = "3-4 weeks",
                        Content = "Master browser APIs, storage solutions, and modern web capabilities",
                        KeyConcepts = new List<string>
                        {
                            "DOM & BOM APIs",
                            "Storage APIs",
                            "Fetch & Network APIs",
                            "Geolocation & Device APIs",
                            "Service Workers",
                            "WebRTC & Real-time Communication"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19101, StepId = 1910, Description = "Master essential browser APIs" },
                            new LearningObjective { Id = 19102, StepId = 1910, Description = "Implement offline-first applications" },
                            new LearningObjective { Id = 19103, StepId = 1910, Description = "Use device capabilities effectively" },
                            new LearningObjective { Id = 19104, StepId = 1910, Description = "Build real-time web applications" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19101, StepId = 1910, Title = "Web APIs Reference", Type = "Reference", Url = "https://developer.mozilla.org/en-US/docs/Web/API" },
                            new Resource { Id = 19102, StepId = 1910, Title = "Service Workers Guide", Type = "Guide", Url = "https://developers.google.com/web/fundamentals/primers/service-workers" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build Progressive Web App with offline capabilities",
                            "Create location-based web application",
                            "Implement real-time chat with WebRTC"
                        }
                    },

                    // 11. JavaScript in the Web
                    new RoadmapStep
                    {
                        Id = 1911,
                        RoadmapId = 19,
                        Title = "JavaScript in the Web",
                        Duration = "2-3 weeks",
                        Content = "Master JavaScript integration with HTML/CSS and rendering strategies",
                        KeyConcepts = new List<string>
                        {
                            "HTML Integration",
                            "CSS Manipulation",
                            "Rendering Strategies",
                            "SPA Concepts",
                            "Virtual DOM Concepts",
                            "Performance Optimization"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19111, StepId = 1911, Description = "Optimize JavaScript loading and execution" },
                            new LearningObjective { Id = 19112, StepId = 1911, Description = "Implement efficient DOM updates" },
                            new LearningObjective { Id = 19113, StepId = 1911, Description = "Understand rendering performance" },
                            new LearningObjective { Id = 19114, StepId = 1911, Description = "Build single-page application patterns" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19111, StepId = 1911, Title = "Web Performance Fundamentals", Type = "Guide", Url = "https://web.dev/performance/" },
                            new Resource { Id = 19112, StepId = 1911, Title = "JavaScript Loading Best Practices", Type = "Article", Url = "https://developers.google.com/speed/docs/insights/BlockingJS" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Optimize page loading performance",
                            "Build custom virtual DOM implementation",
                            "Create single-page router"
                        }
                    },

                    // 12. Advanced JavaScript Concepts
                    new RoadmapStep
                    {
                        Id = 1912,
                        RoadmapId = 19,
                        Title = "Advanced JavaScript Concepts",
                        Duration = "4-5 weeks",
                        Content = "Master advanced language features, execution context, and performance optimization",
                        KeyConcepts = new List<string>
                        {
                            "Execution Context & Call Stack",
                            "Hoisting & Temporal Dead Zone",
                            "Strict Mode",
                            "Memory Management",
                            "Functional Programming",
                            "Reactive Programming"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19121, StepId = 1912, Description = "Understand JavaScript engine internals" },
                            new LearningObjective { Id = 19122, StepId = 1912, Description = "Optimize memory usage and performance" },
                            new LearningObjective { Id = 19123, StepId = 1912, Description = "Apply advanced functional patterns" },
                            new LearningObjective { Id = 19124, StepId = 1912, Description = "Implement reactive programming concepts" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19121, StepId = 1912, Title = "JavaScript Engine Fundamentals", Type = "Article", Url = "https://mathiasbynens.be/notes/shapes-ics" },
                            new Resource { Id = 19122, StepId = 1912, Title = "Memory Management in JavaScript", Type = "Guide", Url = "https://developer.mozilla.org/en-US/docs/Web/JavaScript/Memory_Management" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Profile and optimize memory-intensive application",
                            "Build functional programming utility library",
                            "Implement reactive data flow patterns"
                        }
                    },

                    // 13. Security in JavaScript
                    new RoadmapStep
                    {
                        Id = 1913,
                        RoadmapId = 19,
                        Title = "Security in JavaScript",
                        Duration = "2-3 weeks",
                        Content = "Master web security concepts and secure JavaScript development practices",
                        KeyConcepts = new List<string>
                        {
                            "XSS Prevention",
                            "CSRF Protection",
                            "CORS Configuration",
                            "Content Security Policy",
                            "Input Sanitization",
                            "Secure Storage Practices"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19131, StepId = 1913, Description = "Prevent XSS and injection attacks" },
                            new LearningObjective { Id = 19132, StepId = 1913, Description = "Implement CSRF protection" },
                            new LearningObjective { Id = 19133, StepId = 1913, Description = "Configure secure CORS policies" },
                            new LearningObjective { Id = 19134, StepId = 1913, Description = "Sanitize and validate user input" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19131, StepId = 1913, Title = "Web Security Basics", Type = "Guide", Url = "https://developer.mozilla.org/en-US/docs/Web/Security" },
                            new Resource { Id = 19132, StepId = 1913, Title = "OWASP JavaScript Security", Type = "Guide", Url = "https://owasp.org/www-project-top-ten/" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Implement CSP and security headers",
                            "Build secure authentication system",
                            "Create input validation library"
                        }
                    },

                    // 14. Tooling & Build Systems
                    new RoadmapStep
                    {
                        Id = 1914,
                        RoadmapId = 19,
                        Title = "Tooling & Build Systems",
                        Duration = "3-4 weeks",
                        Content = "Master modern JavaScript tooling, bundlers, and development workflow optimization",
                        KeyConcepts = new List<string>
                        {
                            "Package Managers",
                            "Module Bundlers",
                            "Transpilers & Compilers",
                            "Task Runners",
                            "Development Servers",
                            "Monorepo Management"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19141, StepId = 1914, Description = "Configure modern build pipelines" },
                            new LearningObjective { Id = 19142, StepId = 1914, Description = "Optimize bundle size and loading" },
                            new LearningObjective { Id = 19143, StepId = 1914, Description = "Set up development workflow automation" },
                            new LearningObjective { Id = 19144, StepId = 1914, Description = "Manage complex project dependencies" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19141, StepId = 1914, Title = "Webpack Documentation", Type = "Documentation", Url = "https://webpack.js.org/guides/" },
                            new Resource { Id = 19142, StepId = 1914, Title = "Vite Guide", Type = "Guide", Url = "https://vitejs.dev/guide/" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Configure custom Webpack build",
                            "Set up Vite development environment",
                            "Create automated deployment pipeline"
                        }
                    },

                    // 15. Testing
                    new RoadmapStep
                    {
                        Id = 1915,
                        RoadmapId = 19,
                        Title = "JavaScript Testing",
                        Duration = "3-4 weeks",
                        Content = "Master testing strategies, frameworks, and automated testing practices",
                        KeyConcepts = new List<string>
                        {
                            "Unit Testing Frameworks",
                            "Integration Testing",
                            "End-to-End Testing",
                            "Mocking & Stubbing",
                            "Code Coverage",
                            "Test Automation"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19151, StepId = 1915, Description = "Write comprehensive unit tests" },
                            new LearningObjective { Id = 19152, StepId = 1915, Description = "Implement integration testing strategies" },
                            new LearningObjective { Id = 19153, StepId = 1915, Description = "Create E2E test automation" },
                            new LearningObjective { Id = 19154, StepId = 1915, Description = "Achieve high code coverage" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19151, StepId = 1915, Title = "Jest Documentation", Type = "Documentation", Url = "https://jestjs.io/docs/getting-started" },
                            new Resource { Id = 19152, StepId = 1915, Title = "Cypress Testing Guide", Type = "Guide", Url = "https://docs.cypress.io/guides/overview/why-cypress" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build comprehensive test suite with Jest",
                            "Create E2E tests with Cypress",
                            "Set up test automation in CI/CD"
                        }
                    },

                    // 16. Frameworks & Libraries
                    new RoadmapStep
                    {
                        Id = 1916,
                        RoadmapId = 19,
                        Title = "Frameworks & Libraries",
                        Duration = "4-5 weeks",
                        Content = "Master popular JavaScript frameworks and understand their architectural patterns",
                        KeyConcepts = new List<string>
                        {
                            "React.js Ecosystem",
                            "Angular Framework",
                            "Vue.js & Nuxt",
                            "Svelte & SvelteKit",
                            "State Management Libraries",
                            "Utility Libraries"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19161, StepId = 1916, Description = "Compare and choose appropriate frameworks" },
                            new LearningObjective { Id = 19162, StepId = 1916, Description = "Implement state management patterns" },
                            new LearningObjective { Id = 19163, StepId = 1916, Description = "Build component libraries" },
                            new LearningObjective { Id = 19164, StepId = 1916, Description = "Integrate multiple libraries effectively" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19161, StepId = 1916, Title = "Framework Comparison Guide", Type = "Article", Url = "https://2022.stateofjs.com/en-US/libraries/front-end-frameworks/" },
                            new Resource { Id = 19162, StepId = 1916, Title = "State Management Patterns", Type = "Guide", Url = "https://redux.js.org/understanding/thinking-in-redux/three-principles" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build same app in React, Vue, and Angular",
                            "Create reusable component library",
                            "Implement state management with multiple patterns"
                        }
                    },

                    // 17. Node.js & Backend JavaScript
                    new RoadmapStep
                    {
                        Id = 1917,
                        RoadmapId = 19,
                        Title = "Node.js & Backend JavaScript",
                        Duration = "4-5 weeks",
                        Content = "Master server-side JavaScript development with Node.js and backend frameworks",
                        KeyConcepts = new List<string>
                        {
                            "Node.js Core Modules",
                            "Express.js & Web Frameworks",
                            "REST API Development",
                            "Authentication Systems",
                            "Real-time Applications",
                            "Microservices Architecture"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19171, StepId = 1917, Description = "Build scalable Node.js applications" },
                            new LearningObjective { Id = 19172, StepId = 1917, Description = "Create robust REST APIs" },
                            new LearningObjective { Id = 19173, StepId = 1917, Description = "Implement secure authentication" },
                            new LearningObjective { Id = 19174, StepId = 1917, Description = "Deploy Node.js applications" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19171, StepId = 1917, Title = "Node.js Documentation", Type = "Documentation", Url = "https://nodejs.org/en/docs/" },
                            new Resource { Id = 19172, StepId = 1917, Title = "Express.js Guide", Type = "Guide", Url = "https://expressjs.com/en/guide/routing.html" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build full-stack application with Express",
                            "Create microservices with Node.js",
                            "Implement real-time features with Socket.IO"
                        }
                    },

                    // 18. Databases with JavaScript
                    new RoadmapStep
                    {
                        Id = 1918,
                        RoadmapId = 19,
                        Title = "Databases with JavaScript",
                        Duration = "3-4 weeks",
                        Content = "Master database integration, ORMs, and data persistence patterns",
                        KeyConcepts = new List<string>
                        {
                            "SQL Databases Integration",
                            "NoSQL Databases",
                            "ODM/ORM Libraries",
                            "Database Migrations",
                            "In-browser Databases",
                            "Caching Strategies"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19181, StepId = 1918, Description = "Integrate with SQL and NoSQL databases" },
                            new LearningObjective { Id = 19182, StepId = 1918, Description = "Use ORMs and query builders effectively" },
                            new LearningObjective { Id = 19183, StepId = 1918, Description = "Implement data caching strategies" },
                            new LearningObjective { Id = 19184, StepId = 1918, Description = "Handle database migrations and schemas" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19181, StepId = 1918, Title = "Prisma Documentation", Type = "Documentation", Url = "https://www.prisma.io/docs/" },
                            new Resource { Id = 19182, StepId = 1918, Title = "MongoDB with JavaScript", Type = "Tutorial", Url = "https://www.mongodb.com/developer/languages/javascript/" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build data layer with Prisma/Mongoose",
                            "Implement caching with Redis",
                            "Create database migration system"
                        }
                    },

                    // 19. Performance Optimization
                    new RoadmapStep
                    {
                        Id = 1919,
                        RoadmapId = 19,
                        Title = "Performance Optimization",
                        Duration = "3-4 weeks",
                        Content = "Master performance optimization techniques for both browser and server-side JavaScript",
                        KeyConcepts = new List<string>
                        {
                            "Code Splitting & Lazy Loading",
                            "Debouncing & Throttling",
                            "Memory Optimization",
                            "Web Workers",
                            "Caching Strategies",
                            "Performance Monitoring"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19191, StepId = 1919, Description = "Implement code splitting strategies" },
                            new LearningObjective { Id = 19192, StepId = 1919, Description = "Optimize runtime performance" },
                            new LearningObjective { Id = 19193, StepId = 1919, Description = "Use Web Workers for heavy tasks" },
                            new LearningObjective { Id = 19194, StepId = 1919, Description = "Monitor and measure performance" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19191, StepId = 1919, Title = "Web Performance Optimization", Type = "Guide", Url = "https://web.dev/fast/" },
                            new Resource { Id = 19192, StepId = 1919, Title = "JavaScript Performance Tips", Type = "Article", Url = "https://developers.google.com/speed/docs/insights/rules" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Optimize large-scale application performance",
                            "Implement Web Workers for image processing",
                            "Create performance monitoring dashboard"
                        }
                    },

                    // 20. Type Systems
                    new RoadmapStep
                    {
                        Id = 1920,
                        RoadmapId = 19,
                        Title = "Type Systems",
                        Duration = "3-4 weeks",
                        Content = "Master type safety in JavaScript with TypeScript and other typing solutions",
                        KeyConcepts = new List<string>
                        {
                            "TypeScript Fundamentals",
                            "Type Annotations & Inference",
                            "Generics & Advanced Types",
                            "JSDoc Type Annotations",
                            "Flow Type Checker",
                            "Type Safety Best Practices"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19201, StepId = 1920, Description = "Master TypeScript for large applications" },
                            new LearningObjective { Id = 19202, StepId = 1920, Description = "Implement advanced type patterns" },
                            new LearningObjective { Id = 19203, StepId = 1920, Description = "Migrate JavaScript projects to TypeScript" },
                            new LearningObjective { Id = 19204, StepId = 1920, Description = "Use JSDoc for type documentation" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19201, StepId = 1920, Title = "TypeScript Handbook", Type = "Documentation", Url = "https://www.typescriptlang.org/docs/" },
                            new Resource { Id = 19202, StepId = 1920, Title = "Advanced TypeScript", Type = "Tutorial", Url = "https://www.typescriptlang.org/docs/handbook/advanced-types.html" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Convert large JavaScript project to TypeScript",
                            "Create advanced type utilities",
                            "Build type-safe API layer"
                        }
                    },

                    // 21. Emerging & Specialized Topics
                    new RoadmapStep
                    {
                        Id = 1921,
                        RoadmapId = 19,
                        Title = "Emerging & Specialized Topics",
                        Duration = "4-5 weeks",
                        Content = "Explore cutting-edge JavaScript technologies and specialized application areas",
                        KeyConcepts = new List<string>
                        {
                            "WebAssembly Integration",
                            "Serverless JavaScript",
                            "JAMstack Architecture",
                            "Microfrontends",
                            "Edge Computing",
                            "AI/ML in JavaScript"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 19211, StepId = 1921, Description = "Integrate WebAssembly with JavaScript" },
                            new LearningObjective { Id = 19212, StepId = 1921, Description = "Build serverless applications" },
                            new LearningObjective { Id = 19213, StepId = 1921, Description = "Implement microfrontend architecture" },
                            new LearningObjective { Id = 19214, StepId = 1921, Description = "Use AI/ML libraries in JavaScript" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 19211, StepId = 1921, Title = "WebAssembly MDN Guide", Type = "Guide", Url = "https://developer.mozilla.org/en-US/docs/WebAssembly" },
                            new Resource { Id = 19212, StepId = 1921, Title = "TensorFlow.js Documentation", Type = "Documentation", Url = "https://www.tensorflow.org/js" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build WebAssembly-accelerated application",
                            "Create serverless API with Vercel/Netlify",
                            "Implement ML model with TensorFlow.js"
                        }
                    }
                };
            }
        }
    }
}