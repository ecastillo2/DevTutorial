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
                            "JavaScript History & Evolution: Programming language created in 1995, evolved through ECMAScript standards. ES6+ introduced modern features like arrow functions, classes, modules enabling sophisticated application development.",
                            "Variables & Constants (var, let, const): Variable declarations with different scoping rules. var has function scope, let/const have block scope. const creates immutable bindings for primitive values and object references.",
                            "Data Types (Primitives & Objects): Seven primitive types (undefined, null, boolean, number, bigint, string, symbol) and objects. Understanding type system crucial for effective JavaScript programming.",
                            "Type Conversion & Coercion: Explicit conversion using constructors and implicit coercion during operations. Understanding truthy/falsy values and comparison operators (==, ===) prevents unexpected behavior.",
                            "Operators & Expressions: Arithmetic, logical, comparison, assignment, and specialized operators. Expressions evaluate to values, understanding precedence and associativity ensures correct code behavior.",
                            "Statements vs Expressions: Statements perform actions (if, for, while), expressions produce values. Understanding distinction important for functional programming and language comprehension."
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
                            "Function Declarations vs Expressions: Two ways to define functions with different behaviors. Declarations are hoisted and can be called before definition, expressions are not hoisted and create more predictable code.",
                            "Arrow Functions: Concise function syntax with lexical this binding. Shorter syntax for simple functions, but different behavior for this context and cannot be used as constructors.",
                            "Parameters & Arguments: Function inputs with various patterns including default parameters, rest parameters, and destructuring. Arguments object provides access to all passed parameters.",
                            "Scope & Closures: Scope determines variable accessibility, closures allow inner functions to access outer function variables even after outer function returns. Essential for module patterns and data privacy.",
                            "Higher-Order Functions: Functions that take other functions as arguments or return functions. Foundation of functional programming including map, filter, reduce, and custom utility functions.",
                            "Functional Programming Patterns: Programming paradigm emphasizing immutability, pure functions, and function composition. Includes currying, partial application, and monadic patterns for cleaner code."
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
                            "Conditionals & Branching: Decision-making structures including if/else statements, switch expressions, and ternary operators. Modern features like optional chaining (?.) and nullish coalescing (??) for cleaner branching logic.",
                            "Loops & Iteration: Repetitive execution patterns including for, while, do-while loops, and modern for-in/for-of loops. Understanding performance implications and choosing appropriate iteration methods.",
                            "Iterators & Generators: Advanced iteration protocols. Iterators define sequence access, generators create iterators using function* syntax with yield. Enable lazy evaluation and infinite sequences.",
                            "Error Handling: Managing runtime errors using try/catch/finally blocks. Understanding error types, stack traces, and creating robust error recovery mechanisms for application stability.",
                            "Custom Error Types: Creating application-specific error classes extending built-in Error types. Enables precise error identification, custom properties, and improved debugging capabilities.",
                            "Flow Control Best Practices: Guidelines for writing readable, maintainable control flow including early returns, guard clauses, avoiding deep nesting, and clear conditional expressions."
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
                            "Object Creation Patterns: Various methods for creating objects including literal notation, constructor functions, Object.create(), factory functions, and class instantiation. Each pattern has different use cases and performance characteristics.",
                            "Prototypal Inheritance: JavaScript's inheritance model where objects inherit directly from other objects through prototype chain. Understanding __proto__, prototype property, and Object.setPrototypeOf() for inheritance hierarchies.",
                            "ES6 Classes: Syntactic sugar over prototypal inheritance providing familiar class-based syntax. Includes constructor methods, static methods, private fields, and extends keyword for inheritance.",
                            "this Keyword Binding: Context object reference that changes based on invocation pattern. Understanding call-site rules, explicit binding with call/apply/bind, arrow functions, and implicit binding.",
                            "Object Manipulation: Techniques for working with objects including property enumeration, descriptors, getters/setters, Object.keys/values/entries, and modern spreading/destructuring operations.",
                            "Symbols & Metadata: Primitive symbol type for unique object property keys. Well-known symbols define object behavior, Symbol.iterator enables custom iteration, metadata programming with symbols."
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
                            "Array Creation & Access: Multiple array creation methods including literal notation, Array constructor, Array.from(), Array.of(), and spread operator. Index-based access and length property manipulation.",
                            "Mutating vs Non-Mutating Methods: Distinction between methods that modify original array (push, pop, splice) and those that return new arrays (map, filter, concat). Critical for functional programming and avoiding side effects.",
                            "Functional Array Methods: Higher-order functions for data transformation including map, filter, reduce, forEach, find, some, every. Enable declarative programming style and data pipeline construction.",
                            "Array Destructuring: ES6 syntax for extracting array elements into variables. Includes rest patterns, default values, and nested destructuring for elegant data access patterns.",
                            "Multi-dimensional Arrays: Arrays containing other arrays for matrix operations, table data, and complex data structures. Techniques for accessing and manipulating nested array data.",
                            "Typed Arrays: Special array-like objects for handling binary data including Int8Array, Float32Array, etc. Used for high-performance numeric operations, file handling, and WebGL programming."
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
                            "Callbacks & Callback Hell: Function passed as argument to be executed later. Callback hell occurs with nested callbacks creating unreadable code. Understanding inversion of control and callback patterns.",
                            "Promises & Promise Chaining: Objects representing eventual completion of asynchronous operations. Chaining with then/catch/finally provides linear async code flow and better error handling than callbacks.",
                            "Async/Await Patterns: Syntactic sugar over promises making asynchronous code look synchronous. Error handling with try/catch, parallel execution with Promise.all, and async iteration patterns.",
                            "Event Loop & Task Queue: JavaScript's concurrency model using call stack, callback queue, and event loop. Understanding how async operations are scheduled and executed in single-threaded environment.",
                            "Microtasks vs Macrotasks: Different task types with different priorities. Microtasks (Promise.then, queueMicrotask) execute before macrotasks (setTimeout, setInterval) in each event loop iteration.",
                            "Observable Patterns: Reactive programming patterns for handling asynchronous data streams. RxJS observables provide powerful composition operators for complex async scenarios and event handling."
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
                            "DOM Selection & Manipulation: Methods for selecting DOM elements (querySelector, getElementById) and modifying them (innerHTML, textContent, classList). Understanding performance implications of DOM operations.",
                            "Event System & Delegation: Browser event system with capturing and bubbling phases. Event delegation uses bubbling to handle events on parent elements, improving performance and handling dynamic content.",
                            "Event Propagation: Three phases of event handling: capturing (down the tree), target (at element), and bubbling (up the tree). stopPropagation() and preventDefault() control event behavior.",
                            "Custom Events: Creating and dispatching custom events for component communication. CustomEvent constructor enables passing data between decoupled components using standard event system.",
                            "Form Handling: Processing form data including validation, submission handling, and user interaction. FormData API for file uploads and modern form validation techniques.",
                            "Touch & Pointer Events: Handling touch interactions on mobile devices and pointer events for unified input handling. Includes gesture recognition, multi-touch support, and responsive input design."
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
                            "ES6 Modules - The standard module system for JavaScript, using import/export syntax to create reusable, encapsulated code units with explicit dependencies and cleaner namespace management",
                            "CommonJS & Node.js Modules - The module system used in Node.js environments, utilizing require() and module.exports for synchronous module loading, essential for server-side JavaScript development",
                            "Module Bundling - The process of combining multiple JavaScript modules into optimized bundles for browser delivery, reducing HTTP requests and enabling modern development workflows with tools like Webpack and Rollup",
                            "Namespaces & IIFE - Traditional patterns for organizing JavaScript code before modules, using Immediately Invoked Function Expressions to create isolated scopes and prevent global namespace pollution",
                            "Tree Shaking - Dead code elimination technique that removes unused exports from bundles during the build process, significantly reducing bundle size by only including code that's actually imported and used",
                            "Dynamic Imports - Runtime module loading using import() expressions, enabling code splitting, lazy loading, and conditional module loading based on user interactions or application state"
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
                            "Error Types & Debugging - Understanding JavaScript's error types (SyntaxError, TypeError, ReferenceError, etc.) and debugging techniques including breakpoints, stack traces, and error handling patterns for robust applications",
                            "Browser DevTools - Comprehensive developer tools in modern browsers for debugging JavaScript, inspecting DOM/network activity, analyzing performance, and testing code with features like console, debugger, and profiler",
                            "Console API - Browser's console methods beyond console.log(), including table(), time(), assert(), trace(), and group() for advanced debugging, performance measurement, and organized logging output",
                            "Debugging Strategies - Systematic approaches to finding and fixing bugs including binary search debugging, rubber duck debugging, logging strategies, and using source maps for debugging minified code",
                            "Linting & Code Quality - Static code analysis tools like ESLint and Prettier that enforce coding standards, catch errors early, maintain consistency, and improve code quality through automated rule checking",
                            "Performance Profiling - Using browser profiler tools to identify performance bottlenecks, memory leaks, and inefficient code by analyzing CPU usage, memory allocation, and rendering performance metrics"
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
                            "DOM & BOM APIs - Document Object Model for manipulating page structure and Browser Object Model for interacting with browser features like window, location, history, and navigator objects",
                            "Storage APIs - Browser storage mechanisms including localStorage for persistent data, sessionStorage for session-scoped data, IndexedDB for complex data structures, and Cache API for offline resource storage",
                            "Fetch & Network APIs - Modern promise-based API for making HTTP requests, handling responses, and managing network operations with features like request/response manipulation, streaming, and CORS handling",
                            "Geolocation & Device APIs - Browser APIs for accessing device capabilities including GPS location, camera, microphone, device orientation, battery status, and other hardware features with proper permission handling",
                            "Service Workers - JavaScript workers that act as network proxies, enabling offline functionality, push notifications, background sync, and caching strategies for building Progressive Web Apps",
                            "WebRTC & Real-time Communication - Web Real-Time Communication API for peer-to-peer audio, video, and data sharing directly between browsers without plugins, enabling video calls, screen sharing, and real-time collaboration"
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
                            "HTML Integration - Techniques for efficiently loading and executing JavaScript in web pages, including script placement, defer/async attributes, and module loading strategies for optimal page performance",
                            "CSS Manipulation - Programmatic styling through JavaScript using inline styles, CSSOM manipulation, CSS classes, CSS-in-JS libraries, and dynamic stylesheet creation for responsive UI updates",
                            "Rendering Strategies - Understanding browser rendering pipeline, reflow/repaint optimization, critical rendering path, and techniques like requestAnimationFrame for smooth animations and efficient DOM updates",
                            "SPA Concepts - Single Page Application architecture patterns including client-side routing, state management, component lifecycles, and techniques for building dynamic web apps that update without full page reloads",
                            "Virtual DOM Concepts - Abstraction layer that represents UI as JavaScript objects, enabling efficient updates by comparing virtual trees and applying minimal changes to the actual DOM, popularized by React",
                            "Performance Optimization - Web performance techniques including lazy loading, code splitting, resource hints, compression, minification, and Core Web Vitals optimization for fast, responsive user experiences"
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
                            "Execution Context & Call Stack - JavaScript's execution environment including global/function/eval contexts, lexical environment, variable environment, and the call stack mechanism for tracking function execution order",
                            "Hoisting & Temporal Dead Zone - JavaScript's behavior of moving declarations to the top of their scope during compilation, and the TDZ where let/const variables exist but cannot be accessed before initialization",
                            "Strict Mode - JavaScript's strict execution mode that eliminates silent errors, prevents unsafe actions, disables confusing features, and enables better optimization by JavaScript engines for cleaner code",
                            "Memory Management - Understanding JavaScript's automatic garbage collection, memory leaks prevention, heap/stack allocation, reference counting, and techniques for optimizing memory usage in large applications",
                            "Functional Programming - Programming paradigm emphasizing immutability, pure functions, higher-order functions, function composition, and declarative code style for more predictable and testable JavaScript",
                            "Reactive Programming - Programming paradigm using observables and data streams to handle asynchronous events, enabling declarative handling of complex async operations with libraries like RxJS"
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
                            "XSS Prevention - Cross-Site Scripting attack prevention through proper output encoding, Content Security Policy, avoiding innerHTML with user data, and using frameworks that auto-escape by default",
                            "CSRF Protection - Cross-Site Request Forgery defense using anti-CSRF tokens, SameSite cookies, double-submit patterns, and verifying origin headers to prevent unauthorized state-changing requests",
                            "CORS Configuration - Cross-Origin Resource Sharing setup for secure cross-domain requests, understanding preflight requests, allowed origins, credentials handling, and proper header configuration",
                            "Content Security Policy - HTTP header-based security layer that helps detect and mitigate XSS and data injection attacks by specifying allowed sources for scripts, styles, and other resources",
                            "Input Sanitization - Techniques for cleaning and validating user input including HTML sanitization, SQL injection prevention, command injection protection, and using allowlists for acceptable input patterns",
                            "Secure Storage Practices - Best practices for client-side data storage including avoiding sensitive data in localStorage, using secure cookies with proper flags, and implementing encryption for sensitive information"
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
                            "Package Managers - Tools like npm, Yarn, and pnpm for managing project dependencies, handling version conflicts, creating lockfiles for reproducible builds, and automating package installation and updates",
                            "Module Bundlers - Build tools like Webpack, Rollup, and Parcel that combine JavaScript modules into optimized bundles, handle assets, enable code splitting, and transform code for browser compatibility",
                            "Transpilers & Compilers - Tools like Babel and TypeScript compiler that transform modern JavaScript/TypeScript into backwards-compatible versions, enabling use of latest language features across all browsers",
                            "Task Runners - Automation tools like Gulp and npm scripts for automating repetitive development tasks such as compilation, minification, testing, and deployment through configurable task pipelines",
                            "Development Servers - Local development tools like Webpack Dev Server and Vite that provide hot module replacement, proxy configuration, HTTPS support, and optimized build-time performance for rapid development",
                            "Monorepo Management - Tools and strategies like Lerna, Nx, and Yarn Workspaces for managing multiple related packages in a single repository, enabling code sharing and coordinated versioning"
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
                            "Unit Testing Frameworks - Testing libraries like Jest, Mocha, and Vitest for writing and running isolated tests of individual functions and components with assertions, test suites, and lifecycle hooks",
                            "Integration Testing - Testing multiple components together to verify their interactions, including API integration tests, database tests, and testing component communication in real scenarios",
                            "End-to-End Testing - Full application testing with tools like Cypress, Playwright, and Selenium that simulate real user interactions, test complete user flows, and verify application behavior in browsers",
                            "Mocking & Stubbing - Test doubles techniques for isolating units under test by replacing dependencies with controlled implementations, including spies, stubs, mocks, and fake objects",
                            "Code Coverage - Metrics and tools for measuring test completeness including statement, branch, function, and line coverage, helping identify untested code paths and improve test suite quality",
                            "Test Automation - Continuous testing strategies including test runners, CI/CD integration, parallel test execution, visual regression testing, and automated test report generation for reliable software delivery"
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
                            "React.js Ecosystem - Component-based library for building UIs with virtual DOM, JSX syntax, hooks for state management, and rich ecosystem including Next.js, React Router, and React Native",
                            "Angular Framework - Full-featured MVC framework with TypeScript, dependency injection, RxJS for reactive programming, powerful CLI, and comprehensive tooling for enterprise-scale applications",
                            "Vue.js & Nuxt - Progressive framework with template-based syntax, reactive data binding, single-file components, and Nuxt.js for server-side rendering and static site generation",
                            "Svelte & SvelteKit - Compile-time framework that generates vanilla JavaScript, eliminating runtime overhead, with reactive declarations and SvelteKit for full-stack application development",
                            "State Management Libraries - Solutions like Redux, MobX, Zustand, and Pinia for managing complex application state, implementing flux architecture, and handling cross-component data flow",
                            "Utility Libraries - Essential helper libraries like Lodash for utilities, Axios for HTTP requests, date-fns for date manipulation, and other specialized tools that enhance JavaScript capabilities"
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
                            "Node.js Core Modules - Built-in modules like fs for file system operations, http for server creation, path for file paths, crypto for encryption, and stream for handling data flows in Node.js applications",
                            "Express.js & Web Frameworks - Minimal and flexible Node.js frameworks for building web applications and APIs, featuring middleware, routing, template engines, and extensive plugin ecosystems",
                            "REST API Development - Building RESTful services with proper HTTP methods, status codes, resource naming, pagination, filtering, versioning, and following REST architectural constraints",
                            "Authentication Systems - Implementing secure user authentication with JWT tokens, OAuth 2.0, session management, password hashing with bcrypt, and role-based access control for protected resources",
                            "Real-time Applications - Building live applications using WebSockets, Socket.IO, or Server-Sent Events for features like chat, notifications, collaborative editing, and live data updates",
                            "Microservices Architecture - Designing distributed systems with Node.js including service discovery, API gateways, message queuing, inter-service communication, and containerization with Docker"
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
                            "SQL Databases Integration - Working with relational databases like PostgreSQL and MySQL using query builders, connection pooling, prepared statements, and transaction management for data integrity",
                            "NoSQL Databases - Using document stores like MongoDB, key-value stores like Redis, and graph databases, understanding their use cases, query languages, and scaling characteristics",
                            "ODM/ORM Libraries - Object-Document/Relational Mapping tools like Mongoose, Prisma, and TypeORM that provide abstraction layers for database operations, schema definitions, and relationship management",
                            "Database Migrations - Version control for database schemas using migration tools, managing schema changes across environments, rollback strategies, and maintaining data integrity during updates",
                            "In-browser Databases - Client-side storage solutions like IndexedDB and WebSQL for offline-capable applications, managing large datasets in browsers, and implementing sync strategies with servers",
                            "Caching Strategies - Implementing caching layers with Redis or Memcached, cache invalidation patterns, CDN integration, browser caching headers, and optimizing database query performance"
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
                            "Code Splitting & Lazy Loading - Breaking applications into chunks loaded on demand, reducing initial bundle size, implementing route-based splitting, and using dynamic imports for optimal loading performance",
                            "Debouncing & Throttling - Rate-limiting techniques for controlling function execution frequency, preventing excessive API calls, optimizing scroll/resize handlers, and improving input field performance",
                            "Memory Optimization - Techniques for preventing memory leaks, managing object references, using WeakMap/WeakSet, implementing object pooling, and profiling memory usage in JavaScript applications",
                            "Web Workers - Running JavaScript in background threads for CPU-intensive tasks, parallel processing, offloading heavy computations, and maintaining responsive UI during complex operations",
                            "Caching Strategies - Implementing browser caching, service worker caches, memory caching, HTTP cache headers, and cache invalidation patterns for improved application performance",
                            "Performance Monitoring - Using tools like Lighthouse, Performance API, and monitoring services to track metrics, identify bottlenecks, set performance budgets, and continuously optimize applications"
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
                            "TypeScript Fundamentals - Statically typed superset of JavaScript with interfaces, enums, classes, and modules that compiles to plain JavaScript while catching errors at compile time",
                            "Type Annotations & Inference - Explicitly declaring variable types and leveraging TypeScript's ability to automatically infer types from context, balancing type safety with code readability",
                            "Generics & Advanced Types - Creating reusable type-safe components with generic types, conditional types, mapped types, template literal types, and utility types for flexible type transformations",
                            "JSDoc Type Annotations - Adding type information to JavaScript using JSDoc comments, enabling type checking in JavaScript files without TypeScript syntax for gradual migration or lightweight typing",
                            "Flow Type Checker - Facebook's static type checker for JavaScript, offering gradual typing, type inference, and null safety as an alternative to TypeScript for type-safe JavaScript development",
                            "Type Safety Best Practices - Strategies for maximizing type safety including strict compiler options, avoiding any types, proper null handling, discriminated unions, and exhaustive type checking"
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
                            "WebAssembly Integration - Running high-performance compiled code in browsers alongside JavaScript, enabling C++/Rust integration, computational intensive tasks, and near-native performance for web applications",
                            "Serverless JavaScript - Building scalable applications with Functions-as-a-Service platforms like AWS Lambda, Vercel, and Netlify Functions, focusing on business logic without server management",
                            "JAMstack Architecture - Modern web architecture using JavaScript, APIs, and Markup for building fast, secure, and scalable websites with static site generators and headless CMS integration",
                            "Microfrontends - Architectural pattern for breaking frontend monoliths into smaller, independent applications that can be developed, deployed, and scaled independently by different teams",
                            "Edge Computing - Running JavaScript at edge locations closer to users with platforms like Cloudflare Workers and Deno Deploy, reducing latency and enabling geo-distributed applications",
                            "AI/ML in JavaScript - Machine learning in browsers and Node.js using TensorFlow.js, Brain.js, and ML5.js for computer vision, natural language processing, and predictive models without backend infrastructure"
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