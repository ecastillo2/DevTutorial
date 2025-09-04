using System.Collections.Generic;
using System.Linq;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Services
{
    public partial class RoadmapService
    {
        private void AddExtendedSubTopics(List<Roadmap> roadmaps)
        {
            // Frontend Developer Roadmap
            var frontend = roadmaps.FirstOrDefault(r => r.Id == 1);
            if (frontend != null)
            {
                // HTML & CSS Fundamentals - Step 1
                var htmlCssStep = frontend.Steps.FirstOrDefault(s => s.Id == 1);
                if (htmlCssStep != null)
                {
                    htmlCssStep.SubTopics.AddRange(new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 3,
                            StepId = 1,
                            Title = "Responsive Web Design",
                            Description = "Master responsive design techniques for all devices",
                            Content = "Learn to create websites that adapt seamlessly to different screen sizes using modern CSS techniques",
                            KeyPoints = new List<string> 
                            { 
                                "Media queries and breakpoints",
                                "Mobile-first design approach",
                                "Responsive units (rem, em, vw, vh)",
                                "Responsive images and videos"
                            },
                            CodeExample = "/* Mobile-first responsive design */\n.container {\n  width: 100%;\n  padding: 1rem;\n}\n\n@media (min-width: 768px) {\n  .container {\n    max-width: 750px;\n    margin: 0 auto;\n  }\n}"
                        },
                        new SubTopic
                        {
                            Id = 4,
                            StepId = 1,
                            Title = "CSS Animations",
                            Description = "Create engaging animations with CSS",
                            Content = "Bring your websites to life with smooth CSS animations and transitions",
                            KeyPoints = new List<string> 
                            { 
                                "CSS transitions",
                                "Keyframe animations",
                                "Transform properties",
                                "Performance optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 10,
                            StepId = 1,
                            Title = "Advanced CSS Layouts",
                            Description = "Master complex layout techniques",
                            Content = "Learn advanced CSS layout systems including CSS Grid and Flexbox for creating sophisticated page layouts",
                            KeyPoints = new List<string> 
                            { 
                                "CSS Grid advanced patterns",
                                "Flexbox alignment and distribution",
                                "Multi-column layouts",
                                "CSS Shapes and Exclusions",
                                "Container queries"
                            }
                        },
                        new SubTopic
                        {
                            Id = 11,
                            StepId = 1,
                            Title = "CSS Preprocessors",
                            Description = "Enhance CSS with preprocessor features",
                            Content = "Use Sass/SCSS to write more maintainable and powerful stylesheets",
                            KeyPoints = new List<string> 
                            { 
                                "Variables and mixins",
                                "Nesting and partials",
                                "Functions and operators",
                                "Inheritance and extending",
                                "Build process integration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 12,
                            StepId = 1,
                            Title = "Web Accessibility",
                            Description = "Build inclusive websites for all users",
                            Content = "Learn WCAG guidelines and implement accessibility best practices",
                            KeyPoints = new List<string> 
                            { 
                                "ARIA roles and attributes",
                                "Semantic HTML importance",
                                "Keyboard navigation",
                                "Screen reader optimization",
                                "Color contrast and visual design"
                            }
                        },
                        new SubTopic
                        {
                            Id = 22,
                            StepId = 1,
                            Title = "CSS Architecture & Methodologies",
                            Description = "Organize CSS for large-scale projects",
                            Content = "Learn CSS architecture patterns and naming conventions for maintainable stylesheets",
                            KeyPoints = new List<string> 
                            { 
                                "BEM methodology",
                                "SMACSS architecture",
                                "Atomic CSS",
                                "CSS Modules",
                                "Utility-first CSS (Tailwind)"
                            }
                        },
                        new SubTopic
                        {
                            Id = 23,
                            StepId = 1,
                            Title = "Modern CSS Features",
                            Description = "Master cutting-edge CSS capabilities",
                            Content = "Explore the latest CSS features and browser APIs",
                            KeyPoints = new List<string> 
                            { 
                                "CSS Custom Properties (Variables)",
                                "CSS Logical Properties",
                                "Scroll Snap",
                                "CSS Containment",
                                "Cascade Layers"
                            }
                        },
                        new SubTopic
                        {
                            Id = 24,
                            StepId = 1,
                            Title = "Performance Optimization",
                            Description = "Optimize CSS for fast loading websites",
                            Content = "Learn techniques to improve CSS performance and reduce load times",
                            KeyPoints = new List<string> 
                            { 
                                "Critical CSS extraction",
                                "CSS minification",
                                "Eliminating render-blocking CSS",
                                "CSS tree shaking",
                                "Resource hints and preloading"
                            }
                        },
                        new SubTopic
                        {
                            Id = 25,
                            StepId = 1,
                            Title = "CSS Variables & Custom Properties",
                            Description = "Create dynamic, themeable designs",
                            Content = "Master CSS custom properties for flexible styling",
                            KeyPoints = new List<string> 
                            { 
                                "Declaring custom properties",
                                "Fallback values",
                                "JavaScript integration",
                                "Theming strategies",
                                "Performance benefits"
                            }
                        },
                        new SubTopic
                        {
                            Id = 26,
                            StepId = 1,
                            Title = "Advanced Selectors & Pseudo-classes",
                            Description = "Target elements precisely",
                            Content = "Learn complex CSS selectors for sophisticated styling",
                            KeyPoints = new List<string> 
                            { 
                                ":has() selector",
                                ":is() and :where()",
                                ":nth-child variations",
                                "Attribute selectors",
                                "Combinators mastery"
                            }
                        },
                        new SubTopic
                        {
                            Id = 27,
                            StepId = 1,
                            Title = "CSS Transforms & 3D",
                            Description = "Create 3D effects and transformations",
                            Content = "Build engaging visual effects with CSS transforms",
                            KeyPoints = new List<string> 
                            { 
                                "2D transforms",
                                "3D transforms",
                                "Perspective",
                                "Transform origin",
                                "Hardware acceleration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 28,
                            StepId = 1,
                            Title = "CSS Print Styling",
                            Description = "Optimize for print media",
                            Content = "Create print-friendly versions of web pages",
                            KeyPoints = new List<string> 
                            { 
                                "Print media queries",
                                "Page breaks",
                                "Print-specific layouts",
                                "Removing unnecessary elements",
                                "Print color optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 29,
                            StepId = 1,
                            Title = "CSS Filters & Blend Modes",
                            Description = "Apply visual effects",
                            Content = "Create stunning visual effects with CSS",
                            KeyPoints = new List<string> 
                            { 
                                "Filter functions",
                                "Backdrop filters",
                                "Mix blend modes",
                                "SVG filters",
                                "Performance considerations"
                            }
                        },
                        new SubTopic
                        {
                            Id = 30,
                            StepId = 1,
                            Title = "CSS Scroll Effects",
                            Description = "Create scroll-driven animations",
                            Content = "Build engaging scroll experiences",
                            KeyPoints = new List<string> 
                            { 
                                "Scroll-snap properties",
                                "Sticky positioning",
                                "Parallax effects",
                                "Scroll-linked animations",
                                "Intersection Observer"
                            }
                        },
                        new SubTopic
                        {
                            Id = 31,
                            StepId = 1,
                            Title = "CSS Houdini",
                            Description = "Extend CSS capabilities",
                            Content = "Access low-level CSS APIs",
                            KeyPoints = new List<string> 
                            { 
                                "CSS Paint API",
                                "Layout API",
                                "Properties & Values API",
                                "Animation Worklet",
                                "Browser support"
                            }
                        },
                        new SubTopic
                        {
                            Id = 32,
                            StepId = 1,
                            Title = "CSS-in-JS Solutions",
                            Description = "Style components with JavaScript",
                            Content = "Explore CSS-in-JS libraries and patterns",
                            KeyPoints = new List<string> 
                            { 
                                "Styled Components",
                                "Emotion",
                                "CSS Modules",
                                "Runtime vs build-time",
                                "Performance tradeoffs"
                            }
                        },
                        new SubTopic
                        {
                            Id = 33,
                            StepId = 1,
                            Title = "Responsive Images & Media",
                            Description = "Optimize media for all devices",
                            Content = "Serve the right image at the right size",
                            KeyPoints = new List<string> 
                            { 
                                "Picture element",
                                "Srcset and sizes",
                                "Art direction",
                                "WebP and modern formats",
                                "Lazy loading"
                            }
                        },
                        new SubTopic
                        {
                            Id = 34,
                            StepId = 1,
                            Title = "CSS Color Spaces",
                            Description = "Master color in CSS",
                            Content = "Understand modern color spaces and functions",
                            KeyPoints = new List<string> 
                            { 
                                "LAB and LCH colors",
                                "Color functions",
                                "Wide gamut colors",
                                "Color contrast",
                                "Dark mode implementation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 35,
                            StepId = 1,
                            Title = "CSS Container Queries",
                            Description = "Style based on container size",
                            Content = "Create truly responsive components",
                            KeyPoints = new List<string> 
                            { 
                                "Container query syntax",
                                "Container units",
                                "Style queries",
                                "Use cases",
                                "Fallback strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 36,
                            StepId = 1,
                            Title = "CSS Logical Properties",
                            Description = "Write direction-agnostic CSS",
                            Content = "Support multiple writing modes and directions",
                            KeyPoints = new List<string> 
                            { 
                                "Block and inline axes",
                                "Logical margins/padding",
                                "Logical borders",
                                "Writing modes",
                                "RTL support"
                            }
                        }
                    });
                }

                // JavaScript Programming - Step 2
                var jsStep = frontend.Steps.FirstOrDefault(s => s.Id == 2);
                if (jsStep != null)
                {
                    jsStep.SubTopics.AddRange(new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 5,
                            StepId = 2,
                            Title = "ES6+ Modern JavaScript",
                            Description = "Master modern JavaScript features",
                            Content = "Learn the latest JavaScript features that make code more readable and efficient",
                            KeyPoints = new List<string> 
                            { 
                                "Arrow functions",
                                "Destructuring",
                                "Async/await",
                                "Modules and imports"
                            }
                        },
                        new SubTopic
                        {
                            Id = 6,
                            StepId = 2,
                            Title = "DOM Manipulation",
                            Description = "Interact with web page elements",
                            Content = "Learn to dynamically modify web pages using JavaScript",
                            KeyPoints = new List<string> 
                            { 
                                "Selecting elements",
                                "Event handling",
                                "Creating and removing elements",
                                "Event delegation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 13,
                            StepId = 2,
                            Title = "JavaScript Data Structures",
                            Description = "Master advanced data structures in JavaScript",
                            Content = "Learn to work with complex data structures and algorithms",
                            KeyPoints = new List<string> 
                            { 
                                "Maps and Sets",
                                "WeakMap and WeakSet",
                                "Typed Arrays",
                                "Linked Lists implementation",
                                "Trees and Graphs"
                            }
                        },
                        new SubTopic
                        {
                            Id = 14,
                            StepId = 2,
                            Title = "Functional Programming",
                            Description = "Apply functional programming concepts in JavaScript",
                            Content = "Learn functional programming paradigms and techniques",
                            KeyPoints = new List<string> 
                            { 
                                "Pure functions",
                                "Immutability",
                                "Function composition",
                                "Currying and partial application",
                                "Functional libraries (Ramda, Lodash/fp)"
                            }
                        },
                        new SubTopic
                        {
                            Id = 15,
                            StepId = 2,
                            Title = "JavaScript Performance",
                            Description = "Optimize JavaScript for better performance",
                            Content = "Learn techniques to write high-performance JavaScript code",
                            KeyPoints = new List<string> 
                            { 
                                "Memory management",
                                "Event loop optimization",
                                "Debouncing and throttling",
                                "Web Workers",
                                "Performance profiling"
                            }
                        },
                        new SubTopic
                        {
                            Id = 25,
                            StepId = 2,
                            Title = "JavaScript Design Patterns",
                            Description = "Implement common JavaScript patterns",
                            Content = "Master design patterns for scalable JavaScript applications",
                            KeyPoints = new List<string> 
                            { 
                                "Module pattern",
                                "Observer pattern",
                                "Singleton pattern",
                                "Factory pattern",
                                "Revealing module pattern"
                            }
                        },
                        new SubTopic
                        {
                            Id = 26,
                            StepId = 2,
                            Title = "Browser APIs",
                            Description = "Leverage modern browser capabilities",
                            Content = "Explore powerful browser APIs for enhanced web applications",
                            KeyPoints = new List<string> 
                            { 
                                "Fetch API and AJAX",
                                "Local Storage and Session Storage",
                                "Geolocation API",
                                "Web Audio API",
                                "WebRTC basics"
                            }
                        },
                        new SubTopic
                        {
                            Id = 27,
                            StepId = 2,
                            Title = "JavaScript Security",
                            Description = "Write secure JavaScript code",
                            Content = "Learn security best practices and common vulnerabilities",
                            KeyPoints = new List<string> 
                            { 
                                "XSS prevention",
                                "CSRF protection",
                                "Content Security Policy",
                                "Secure data handling",
                                "Authentication patterns"
                            }
                        },
                        new SubTopic
                        {
                            Id = 37,
                            StepId = 2,
                            Title = "JavaScript Modules & Bundling",
                            Description = "Organize code with modules",
                            Content = "Master JavaScript module systems and bundling",
                            KeyPoints = new List<string> 
                            { 
                                "ES6 modules",
                                "CommonJS and AMD",
                                "Dynamic imports",
                                "Module bundlers",
                                "Tree shaking"
                            }
                        },
                        new SubTopic
                        {
                            Id = 38,
                            StepId = 2,
                            Title = "Regular Expressions",
                            Description = "Pattern matching in JavaScript",
                            Content = "Master regex for text processing",
                            KeyPoints = new List<string> 
                            { 
                                "Regex syntax",
                                "Capturing groups",
                                "Lookahead/lookbehind",
                                "Common patterns",
                                "Performance tips"
                            }
                        },
                        new SubTopic
                        {
                            Id = 39,
                            StepId = 2,
                            Title = "JavaScript Generators",
                            Description = "Control function execution",
                            Content = "Use generators for advanced control flow",
                            KeyPoints = new List<string> 
                            { 
                                "Generator functions",
                                "Yield keyword",
                                "Iteration protocol",
                                "Async generators",
                                "Use cases"
                            }
                        },
                        new SubTopic
                        {
                            Id = 40,
                            StepId = 2,
                            Title = "Proxy and Reflect",
                            Description = "Metaprogramming in JavaScript",
                            Content = "Intercept and customize operations",
                            KeyPoints = new List<string> 
                            { 
                                "Proxy handlers",
                                "Traps and intercepts",
                                "Reflect API",
                                "Validation proxies",
                                "Observable objects"
                            }
                        },
                        new SubTopic
                        {
                            Id = 41,
                            StepId = 2,
                            Title = "JavaScript Memory Management",
                            Description = "Optimize memory usage",
                            Content = "Prevent memory leaks and optimize performance",
                            KeyPoints = new List<string> 
                            { 
                                "Garbage collection",
                                "Memory leaks",
                                "WeakMap/WeakSet",
                                "Memory profiling",
                                "Best practices"
                            }
                        },
                        new SubTopic
                        {
                            Id = 42,
                            StepId = 2,
                            Title = "JavaScript Testing",
                            Description = "Write testable JavaScript",
                            Content = "Implement comprehensive testing strategies",
                            KeyPoints = new List<string> 
                            { 
                                "Jest framework",
                                "Unit testing",
                                "Integration testing",
                                "Mocking strategies",
                                "Test coverage"
                            }
                        },
                        new SubTopic
                        {
                            Id = 43,
                            StepId = 2,
                            Title = "WebAssembly Integration",
                            Description = "High-performance web apps",
                            Content = "Integrate WebAssembly with JavaScript",
                            KeyPoints = new List<string> 
                            { 
                                "WASM basics",
                                "Loading WASM modules",
                                "JS-WASM interop",
                                "Performance benefits",
                                "Use cases"
                            }
                        },
                        new SubTopic
                        {
                            Id = 44,
                            StepId = 2,
                            Title = "JavaScript Debugging",
                            Description = "Master debugging techniques",
                            Content = "Efficiently debug JavaScript applications",
                            KeyPoints = new List<string> 
                            { 
                                "Chrome DevTools",
                                "Breakpoints",
                                "Console methods",
                                "Source maps",
                                "Remote debugging"
                            }
                        },
                        new SubTopic
                        {
                            Id = 45,
                            StepId = 2,
                            Title = "JavaScript Animations",
                            Description = "Create smooth animations",
                            Content = "Build performant animations with JavaScript",
                            KeyPoints = new List<string> 
                            { 
                                "requestAnimationFrame",
                                "Web Animations API",
                                "Animation libraries",
                                "Performance optimization",
                                "GPU acceleration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 46,
                            StepId = 2,
                            Title = "Service Workers",
                            Description = "Offline functionality",
                            Content = "Build offline-capable web applications",
                            KeyPoints = new List<string> 
                            { 
                                "Service worker lifecycle",
                                "Caching strategies",
                                "Background sync",
                                "Push notifications",
                                "PWA features"
                            }
                        },
                        new SubTopic
                        {
                            Id = 47,
                            StepId = 2,
                            Title = "JavaScript Internationalization",
                            Description = "Build global applications",
                            Content = "Support multiple languages and locales",
                            KeyPoints = new List<string> 
                            { 
                                "Intl API",
                                "Number formatting",
                                "Date formatting",
                                "Collation",
                                "Locale management"
                            }
                        }
                    });
                }

                // Add React Development step
                frontend.Steps.Add(new RoadmapStep
                {
                    Id = 3,
                    RoadmapId = 1,
                    Title = "React Development",
                    Duration = "6-8 weeks",
                    Content = "Build modern web applications with React",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 7,
                            StepId = 3,
                            Title = "React Components",
                            Description = "Understanding React component architecture",
                            Content = "Learn to build reusable UI components with React",
                            KeyPoints = new List<string> 
                            { 
                                "Functional components",
                                "Props and state",
                                "Component lifecycle",
                                "Custom hooks"
                            }
                        },
                        new SubTopic
                        {
                            Id = 8,
                            StepId = 3,
                            Title = "State Management",
                            Description = "Managing application state in React",
                            Content = "Learn different approaches to state management in React applications",
                            KeyPoints = new List<string> 
                            { 
                                "useState and useReducer",
                                "Context API",
                                "Redux basics",
                                "State management patterns"
                            }
                        },
                        new SubTopic
                        {
                            Id = 16,
                            StepId = 3,
                            Title = "React Router",
                            Description = "Implement client-side routing in React",
                            Content = "Build single-page applications with React Router",
                            KeyPoints = new List<string> 
                            { 
                                "Route configuration",
                                "Dynamic routing",
                                "Route parameters",
                                "Navigation guards",
                                "Lazy loading routes"
                            }
                        },
                        new SubTopic
                        {
                            Id = 17,
                            StepId = 3,
                            Title = "React Performance Optimization",
                            Description = "Optimize React applications for better performance",
                            Content = "Learn advanced techniques to improve React app performance",
                            KeyPoints = new List<string> 
                            { 
                                "React.memo and useMemo",
                                "useCallback optimization",
                                "Code splitting",
                                "Virtual list rendering",
                                "Bundle size optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 28,
                            StepId = 3,
                            Title = "React Testing",
                            Description = "Test React components effectively",
                            Content = "Master testing strategies for React applications",
                            KeyPoints = new List<string> 
                            { 
                                "React Testing Library",
                                "Component unit tests",
                                "Integration testing",
                                "Mocking and stubs",
                                "Test-driven development"
                            }
                        },
                        new SubTopic
                        {
                            Id = 29,
                            StepId = 3,
                            Title = "Advanced React Patterns",
                            Description = "Implement advanced React patterns",
                            Content = "Learn sophisticated patterns for complex React applications",
                            KeyPoints = new List<string> 
                            { 
                                "Compound components",
                                "Render props pattern",
                                "Higher-order components",
                                "Custom hook patterns",
                                "Context module pattern"
                            }
                        },
                        new SubTopic
                        {
                            Id = 30,
                            StepId = 3,
                            Title = "React Ecosystem",
                            Description = "Navigate the React ecosystem",
                            Content = "Explore popular libraries and tools in the React ecosystem",
                            KeyPoints = new List<string> 
                            { 
                                "Form libraries (React Hook Form, Formik)",
                                "UI component libraries",
                                "Animation libraries",
                                "Developer tools",
                                "Server-side rendering (Next.js)"
                            }
                        },
                        new SubTopic
                        {
                            Id = 48,
                            StepId = 3,
                            Title = "React Forms & Validation",
                            Description = "Build complex forms in React",
                            Content = "Master form handling and validation in React applications",
                            KeyPoints = new List<string> 
                            { 
                                "Controlled vs uncontrolled components",
                                "Form state management",
                                "Validation strategies",
                                "Error handling",
                                "Form submission patterns"
                            }
                        },
                        new SubTopic
                        {
                            Id = 49,
                            StepId = 3,
                            Title = "React Context & Global State",
                            Description = "Manage global application state",
                            Content = "Deep dive into Context API and global state patterns",
                            KeyPoints = new List<string> 
                            { 
                                "Creating custom contexts",
                                "Context performance optimization",
                                "Multiple contexts pattern",
                                "Context vs Redux",
                                "State lifting strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 50,
                            StepId = 3,
                            Title = "React Suspense & Concurrent Mode",
                            Description = "Build responsive React apps",
                            Content = "Leverage React's concurrent features for better UX",
                            KeyPoints = new List<string> 
                            { 
                                "Suspense for data fetching",
                                "Error boundaries",
                                "Concurrent rendering",
                                "useTransition hook",
                                "Suspense list"
                            }
                        },
                        new SubTopic
                        {
                            Id = 51,
                            StepId = 3,
                            Title = "Server-Side Rendering",
                            Description = "Implement SSR with React",
                            Content = "Build SEO-friendly React applications with server-side rendering",
                            KeyPoints = new List<string> 
                            { 
                                "SSR fundamentals",
                                "Next.js framework",
                                "Static site generation",
                                "Incremental static regeneration",
                                "Hydration strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 52,
                            StepId = 3,
                            Title = "React Native Fundamentals",
                            Description = "Build mobile apps with React",
                            Content = "Extend React skills to mobile development",
                            KeyPoints = new List<string> 
                            { 
                                "React Native components",
                                "Platform-specific code",
                                "Navigation patterns",
                                "Native modules",
                                "Performance optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 53,
                            StepId = 3,
                            Title = "React DevTools & Debugging",
                            Description = "Debug React applications effectively",
                            Content = "Master React debugging tools and techniques",
                            KeyPoints = new List<string> 
                            { 
                                "React DevTools profiler",
                                "Component inspection",
                                "Performance profiling",
                                "Hook debugging",
                                "Production debugging"
                            }
                        },
                        new SubTopic
                        {
                            Id = 54,
                            StepId = 3,
                            Title = "React Security Best Practices",
                            Description = "Secure React applications",
                            Content = "Implement security measures in React apps",
                            KeyPoints = new List<string> 
                            { 
                                "XSS prevention",
                                "CSRF protection",
                                "Secure authentication",
                                "Content Security Policy",
                                "Dependency security"
                            }
                        },
                        new SubTopic
                        {
                            Id = 55,
                            StepId = 3,
                            Title = "React Animation Libraries",
                            Description = "Create smooth animations",
                            Content = "Add engaging animations to React applications",
                            KeyPoints = new List<string> 
                            { 
                                "Framer Motion",
                                "React Spring",
                                "CSS transitions in React",
                                "Gesture animations",
                                "Performance considerations"
                            }
                        },
                        new SubTopic
                        {
                            Id = 56,
                            StepId = 3,
                            Title = "React Data Fetching",
                            Description = "Master data fetching patterns",
                            Content = "Implement efficient data fetching strategies",
                            KeyPoints = new List<string> 
                            { 
                                "SWR and React Query",
                                "Caching strategies",
                                "Optimistic updates",
                                "Pagination patterns",
                                "Real-time data sync"
                            }
                        },
                        new SubTopic
                        {
                            Id = 57,
                            StepId = 3,
                            Title = "React TypeScript Integration",
                            Description = "Type-safe React development",
                            Content = "Build robust React apps with TypeScript",
                            KeyPoints = new List<string> 
                            { 
                                "Component typing",
                                "Props and state types",
                                "Generic components",
                                "Type inference",
                                "Advanced TypeScript patterns"
                            }
                        },
                        new SubTopic
                        {
                            Id = 58,
                            StepId = 3,
                            Title = "React Accessibility",
                            Description = "Build accessible React apps",
                            Content = "Ensure React applications are usable by everyone",
                            KeyPoints = new List<string> 
                            { 
                                "ARIA in React",
                                "Keyboard navigation",
                                "Screen reader support",
                                "Focus management",
                                "Accessibility testing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 59,
                            StepId = 3,
                            Title = "Micro-Frontend Architecture",
                            Description = "Build scalable frontend systems",
                            Content = "Implement micro-frontend patterns with React",
                            KeyPoints = new List<string> 
                            { 
                                "Module federation",
                                "Single-spa framework",
                                "Component isolation",
                                "Shared dependencies",
                                "Communication patterns"
                            }
                        },
                        new SubTopic
                        {
                            Id = 60,
                            StepId = 3,
                            Title = "React Performance Monitoring",
                            Description = "Monitor React app performance",
                            Content = "Track and improve React application performance",
                            KeyPoints = new List<string> 
                            { 
                                "Performance metrics",
                                "Real User Monitoring",
                                "Bundle analysis",
                                "Runtime performance",
                                "Performance budgets"
                            }
                        }
                    }
                });

                // Add Build Tools and Bundlers step
                frontend.Steps.Add(new RoadmapStep
                {
                    Id = 4,
                    RoadmapId = 1,
                    Title = "Build Tools & Module Bundlers",
                    Duration = "2-3 weeks",
                    Content = "Master modern build tools and development workflows",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 18,
                            StepId = 4,
                            Title = "Webpack Configuration",
                            Description = "Configure and optimize Webpack builds",
                            Content = "Learn to set up and customize Webpack for production builds",
                            KeyPoints = new List<string> 
                            { 
                                "Entry points and output",
                                "Loaders and plugins",
                                "Code splitting",
                                "Development vs production builds",
                                "Performance optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 19,
                            StepId = 4,
                            Title = "Vite and Modern Tools",
                            Description = "Use next-generation build tools",
                            Content = "Explore faster alternatives to traditional bundlers",
                            KeyPoints = new List<string> 
                            { 
                                "Vite configuration",
                                "ESBuild integration",
                                "Hot Module Replacement",
                                "Plugin ecosystem",
                                "Migration strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 61,
                            StepId = 4,
                            Title = "Package Management",
                            Description = "Master npm, yarn, and pnpm",
                            Content = "Efficiently manage project dependencies",
                            KeyPoints = new List<string> 
                            { 
                                "Package.json configuration",
                                "Lock files importance",
                                "Dependency versioning",
                                "Workspaces and monorepos",
                                "Security auditing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 62,
                            StepId = 4,
                            Title = "Build Optimization",
                            Description = "Optimize build performance",
                            Content = "Speed up builds and reduce bundle sizes",
                            KeyPoints = new List<string> 
                            { 
                                "Tree shaking",
                                "Dead code elimination",
                                "Bundle splitting",
                                "Lazy loading",
                                "Source maps"
                            }
                        },
                        new SubTopic
                        {
                            Id = 63,
                            StepId = 4,
                            Title = "Development Workflow",
                            Description = "Set up efficient dev environments",
                            Content = "Create productive development workflows",
                            KeyPoints = new List<string> 
                            { 
                                "Hot Module Replacement",
                                "Development servers",
                                "Proxy configuration",
                                "Environment variables",
                                "Browser sync"
                            }
                        },
                        new SubTopic
                        {
                            Id = 64,
                            StepId = 4,
                            Title = "Asset Processing",
                            Description = "Handle various asset types",
                            Content = "Process images, fonts, and other assets",
                            KeyPoints = new List<string> 
                            { 
                                "Image optimization",
                                "Font loading strategies",
                                "SVG handling",
                                "File loaders",
                                "Asset hashing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 65,
                            StepId = 4,
                            Title = "CSS Processing",
                            Description = "Transform and optimize CSS",
                            Content = "Set up CSS preprocessing and post-processing",
                            KeyPoints = new List<string> 
                            { 
                                "PostCSS configuration",
                                "CSS modules",
                                "Critical CSS extraction",
                                "PurgeCSS setup",
                                "CSS-in-JS integration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 66,
                            StepId = 4,
                            Title = "JavaScript Transpilation",
                            Description = "Configure Babel and TypeScript",
                            Content = "Set up JavaScript transpilation for browser compatibility",
                            KeyPoints = new List<string> 
                            { 
                                "Babel configuration",
                                "TypeScript compilation",
                                "Polyfills management",
                                "Target environments",
                                "Source transformations"
                            }
                        },
                        new SubTopic
                        {
                            Id = 67,
                            StepId = 4,
                            Title = "Module Federation",
                            Description = "Share code between applications",
                            Content = "Implement micro-frontend architectures",
                            KeyPoints = new List<string> 
                            { 
                                "Remote modules",
                                "Shared dependencies",
                                "Dynamic imports",
                                "Version management",
                                "Runtime integration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 68,
                            StepId = 4,
                            Title = "Build Caching",
                            Description = "Speed up builds with caching",
                            Content = "Implement effective caching strategies",
                            KeyPoints = new List<string> 
                            { 
                                "Filesystem cache",
                                "Memory cache",
                                "Persistent cache",
                                "Cache invalidation",
                                "Distributed caching"
                            }
                        },
                        new SubTopic
                        {
                            Id = 69,
                            StepId = 4,
                            Title = "Linting & Formatting",
                            Description = "Enforce code quality standards",
                            Content = "Set up automated code quality tools",
                            KeyPoints = new List<string> 
                            { 
                                "ESLint configuration",
                                "Prettier integration",
                                "Stylelint setup",
                                "Pre-commit hooks",
                                "Editor integration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 70,
                            StepId = 4,
                            Title = "Build Analysis",
                            Description = "Analyze and optimize bundles",
                            Content = "Use tools to understand build output",
                            KeyPoints = new List<string> 
                            { 
                                "Bundle analyzers",
                                "Performance metrics",
                                "Dependency graphs",
                                "Size tracking",
                                "Optimization opportunities"
                            }
                        },
                        new SubTopic
                        {
                            Id = 71,
                            StepId = 4,
                            Title = "Progressive Web Apps",
                            Description = "Build PWA features",
                            Content = "Add PWA capabilities to applications",
                            KeyPoints = new List<string> 
                            { 
                                "Service worker generation",
                                "Manifest files",
                                "Offline support",
                                "App shell pattern",
                                "Push notifications"
                            }
                        },
                        new SubTopic
                        {
                            Id = 72,
                            StepId = 4,
                            Title = "Build Security",
                            Description = "Secure the build process",
                            Content = "Implement security best practices in builds",
                            KeyPoints = new List<string> 
                            { 
                                "Dependency scanning",
                                "Supply chain security",
                                "Environment secrets",
                                "Secure configurations",
                                "Vulnerability alerts"
                            }
                        },
                        new SubTopic
                        {
                            Id = 73,
                            StepId = 4,
                            Title = "Multi-Environment Builds",
                            Description = "Build for different environments",
                            Content = "Configure builds for dev, staging, and production",
                            KeyPoints = new List<string> 
                            { 
                                "Environment configurations",
                                "Feature flags",
                                "API endpoint management",
                                "Build variants",
                                "Deployment targets"
                            }
                        },
                        new SubTopic
                        {
                            Id = 74,
                            StepId = 4,
                            Title = "Build Performance",
                            Description = "Optimize build speed",
                            Content = "Make builds faster and more efficient",
                            KeyPoints = new List<string> 
                            { 
                                "Parallel processing",
                                "Incremental builds",
                                "Build profiling",
                                "Hardware utilization",
                                "CI/CD optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 75,
                            StepId = 4,
                            Title = "Legacy Browser Support",
                            Description = "Support older browsers",
                            Content = "Configure builds for browser compatibility",
                            KeyPoints = new List<string> 
                            { 
                                "Browserslist configuration",
                                "Polyfill strategies",
                                "Progressive enhancement",
                                "Feature detection",
                                "Graceful degradation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 76,
                            StepId = 4,
                            Title = "Build Automation",
                            Description = "Automate build workflows",
                            Content = "Set up continuous integration pipelines",
                            KeyPoints = new List<string> 
                            { 
                                "CI/CD integration",
                                "Automated testing",
                                "Release automation",
                                "Version tagging",
                                "Deployment strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 77,
                            StepId = 4,
                            Title = "Rollup Configuration",
                            Description = "Use Rollup for libraries",
                            Content = "Configure Rollup for library bundling",
                            KeyPoints = new List<string> 
                            { 
                                "Library bundling",
                                "Output formats",
                                "External dependencies",
                                "Plugin system",
                                "Tree shaking"
                            }
                        }
                    }
                });

                // Add Testing step
                frontend.Steps.Add(new RoadmapStep
                {
                    Id = 5,
                    RoadmapId = 1,
                    Title = "Frontend Testing",
                    Duration = "3-4 weeks",
                    Content = "Implement comprehensive testing strategies",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 20,
                            StepId = 5,
                            Title = "Unit Testing with Jest",
                            Description = "Write unit tests for JavaScript code",
                            Content = "Learn to test individual components and functions",
                            KeyPoints = new List<string> 
                            { 
                                "Jest configuration",
                                "Writing test cases",
                                "Mocking dependencies",
                                "Code coverage",
                                "Snapshot testing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 21,
                            StepId = 5,
                            Title = "Integration and E2E Testing",
                            Description = "Test complete user workflows",
                            Content = "Implement end-to-end tests with modern tools",
                            KeyPoints = new List<string> 
                            { 
                                "React Testing Library",
                                "Cypress setup",
                                "Testing user interactions",
                                "API mocking",
                                "CI/CD integration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 78,
                            StepId = 5,
                            Title = "Visual Regression Testing",
                            Description = "Catch visual bugs automatically",
                            Content = "Implement visual testing strategies",
                            KeyPoints = new List<string> 
                            { 
                                "Screenshot comparison",
                                "Percy integration",
                                "Storybook visual tests",
                                "Cross-browser testing",
                                "Responsive design tests"
                            }
                        },
                        new SubTopic
                        {
                            Id = 79,
                            StepId = 5,
                            Title = "Performance Testing",
                            Description = "Test application performance",
                            Content = "Ensure applications meet performance requirements",
                            KeyPoints = new List<string> 
                            { 
                                "Lighthouse CI",
                                "Web Vitals testing",
                                "Load time analysis",
                                "Performance budgets",
                                "Regression detection"
                            }
                        },
                        new SubTopic
                        {
                            Id = 80,
                            StepId = 5,
                            Title = "Accessibility Testing",
                            Description = "Ensure apps are accessible",
                            Content = "Test for accessibility compliance",
                            KeyPoints = new List<string> 
                            { 
                                "Axe testing tools",
                                "Screen reader testing",
                                "Keyboard navigation tests",
                                "WCAG compliance",
                                "Automated a11y checks"
                            }
                        },
                        new SubTopic
                        {
                            Id = 81,
                            StepId = 5,
                            Title = "Test Doubles & Mocking",
                            Description = "Master test doubles",
                            Content = "Use mocks, stubs, and spies effectively",
                            KeyPoints = new List<string> 
                            { 
                                "Mock functions",
                                "Module mocking",
                                "API mocking strategies",
                                "Test data factories",
                                "Fixture management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 82,
                            StepId = 5,
                            Title = "Component Testing",
                            Description = "Test React components",
                            Content = "Write effective component tests",
                            KeyPoints = new List<string> 
                            { 
                                "Shallow vs deep rendering",
                                "Props testing",
                                "State testing",
                                "Event simulation",
                                "Custom hooks testing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 83,
                            StepId = 5,
                            Title = "Testing Best Practices",
                            Description = "Write maintainable tests",
                            Content = "Follow testing best practices and patterns",
                            KeyPoints = new List<string> 
                            { 
                                "AAA pattern",
                                "Test organization",
                                "Naming conventions",
                                "DRY in tests",
                                "Test documentation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 84,
                            StepId = 5,
                            Title = "Browser Testing",
                            Description = "Test across browsers",
                            Content = "Ensure cross-browser compatibility",
                            KeyPoints = new List<string> 
                            { 
                                "BrowserStack integration",
                                "Selenium WebDriver",
                                "Cross-browser strategies",
                                "Mobile browser testing",
                                "Browser automation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 85,
                            StepId = 5,
                            Title = "API Testing",
                            Description = "Test backend APIs",
                            Content = "Validate API contracts and behavior",
                            KeyPoints = new List<string> 
                            { 
                                "REST API testing",
                                "GraphQL testing",
                                "Contract testing",
                                "Load testing APIs",
                                "API documentation tests"
                            }
                        },
                        new SubTopic
                        {
                            Id = 86,
                            StepId = 5,
                            Title = "Test Coverage",
                            Description = "Measure test effectiveness",
                            Content = "Use coverage metrics wisely",
                            KeyPoints = new List<string> 
                            { 
                                "Coverage reports",
                                "Coverage thresholds",
                                "Branch coverage",
                                "Coverage pitfalls",
                                "Meaningful metrics"
                            }
                        },
                        new SubTopic
                        {
                            Id = 87,
                            StepId = 5,
                            Title = "Test Automation",
                            Description = "Automate test execution",
                            Content = "Set up automated testing pipelines",
                            KeyPoints = new List<string> 
                            { 
                                "CI/CD integration",
                                "Parallel test execution",
                                "Test scheduling",
                                "Failure reporting",
                                "Test result analysis"
                            }
                        },
                        new SubTopic
                        {
                            Id = 88,
                            StepId = 5,
                            Title = "Mobile App Testing",
                            Description = "Test mobile web apps",
                            Content = "Ensure mobile compatibility",
                            KeyPoints = new List<string> 
                            { 
                                "Device emulation",
                                "Touch event testing",
                                "Responsive testing",
                                "Mobile performance",
                                "Device-specific bugs"
                            }
                        },
                        new SubTopic
                        {
                            Id = 89,
                            StepId = 5,
                            Title = "Security Testing",
                            Description = "Test for vulnerabilities",
                            Content = "Identify security issues in frontend apps",
                            KeyPoints = new List<string> 
                            { 
                                "XSS vulnerability tests",
                                "Input validation tests",
                                "Authentication tests",
                                "OWASP compliance",
                                "Security scanning"
                            }
                        },
                        new SubTopic
                        {
                            Id = 90,
                            StepId = 5,
                            Title = "Mutation Testing",
                            Description = "Test your tests",
                            Content = "Ensure test quality with mutation testing",
                            KeyPoints = new List<string> 
                            { 
                                "Mutation operators",
                                "Stryker framework",
                                "Mutation scores",
                                "Test effectiveness",
                                "Coverage vs mutations"
                            }
                        },
                        new SubTopic
                        {
                            Id = 91,
                            StepId = 5,
                            Title = "Contract Testing",
                            Description = "Test API contracts",
                            Content = "Ensure frontend-backend compatibility",
                            KeyPoints = new List<string> 
                            { 
                                "Pact testing",
                                "Schema validation",
                                "Consumer-driven contracts",
                                "Version compatibility",
                                "Contract evolution"
                            }
                        },
                        new SubTopic
                        {
                            Id = 92,
                            StepId = 5,
                            Title = "Test Data Management",
                            Description = "Manage test data effectively",
                            Content = "Create and maintain test data",
                            KeyPoints = new List<string> 
                            { 
                                "Test data generation",
                                "Faker.js usage",
                                "Database seeding",
                                "Test environments",
                                "Data cleanup"
                            }
                        },
                        new SubTopic
                        {
                            Id = 93,
                            StepId = 5,
                            Title = "Error Boundary Testing",
                            Description = "Test error handling",
                            Content = "Ensure graceful error handling",
                            KeyPoints = new List<string> 
                            { 
                                "Error boundary tests",
                                "Error simulation",
                                "Fallback UI testing",
                                "Error reporting",
                                "Recovery testing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 94,
                            StepId = 5,
                            Title = "Continuous Testing",
                            Description = "Implement continuous testing",
                            Content = "Integrate testing into development workflow",
                            KeyPoints = new List<string> 
                            { 
                                "Test on save",
                                "Watch mode",
                                "Pre-push hooks",
                                "Automated PR checks",
                                "Test feedback loops"
                            }
                        }
                    }
                });
            }

            // Backend Developer Roadmap
            var backend = roadmaps.FirstOrDefault(r => r.Id == 2);
            if (backend != null)
            {
                // C# Fundamentals - Step 3
                var csharpStep = backend.Steps.FirstOrDefault(s => s.Id == 3);
                if (csharpStep != null)
                {
                    csharpStep.SubTopics.AddRange(new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 32,
                            StepId = 3,
                            Title = "Object-Oriented Programming",
                            Description = "Master OOP concepts in C#",
                            Content = "Learn the four pillars of OOP and how to apply them in C#",
                            KeyPoints = new List<string> 
                            { 
                                "Encapsulation",
                                "Inheritance",
                                "Polymorphism",
                                "Abstraction"
                            }
                        },
                        new SubTopic
                        {
                            Id = 33,
                            StepId = 3,
                            Title = "LINQ and Collections",
                            Description = "Query and manipulate data with LINQ",
                            Content = "Master Language Integrated Query for powerful data manipulation",
                            KeyPoints = new List<string> 
                            { 
                                "LINQ syntax",
                                "Method chaining",
                                "IEnumerable and IQueryable",
                                "Performance considerations"
                            }
                        },
                        new SubTopic
                        {
                            Id = 36,
                            StepId = 3,
                            Title = "Asynchronous Programming",
                            Description = "Master async/await patterns in C#",
                            Content = "Learn to write efficient asynchronous code for scalable applications",
                            KeyPoints = new List<string> 
                            { 
                                "Task and Task<T>",
                                "async/await best practices",
                                "ConfigureAwait usage",
                                "Parallel programming",
                                "Cancellation tokens"
                            }
                        },
                        new SubTopic
                        {
                            Id = 37,
                            StepId = 3,
                            Title = "Design Patterns in C#",
                            Description = "Implement common design patterns",
                            Content = "Learn to apply design patterns for better code architecture",
                            KeyPoints = new List<string> 
                            { 
                                "Singleton and Factory patterns",
                                "Repository pattern",
                                "Observer pattern",
                                "Dependency Injection",
                                "SOLID principles application"
                            }
                        },
                        new SubTopic
                        {
                            Id = 44,
                            StepId = 3,
                            Title = "Advanced C# Features",
                            Description = "Master advanced C# language features",
                            Content = "Explore sophisticated C# features for professional development",
                            KeyPoints = new List<string> 
                            { 
                                "Expression trees",
                                "Dynamic programming",
                                "Unsafe code and pointers",
                                "Span<T> and Memory<T>",
                                "Pattern matching"
                            }
                        },
                        new SubTopic
                        {
                            Id = 45,
                            StepId = 3,
                            Title = "C# Performance Optimization",
                            Description = "Write high-performance C# code",
                            Content = "Learn optimization techniques for C# applications",
                            KeyPoints = new List<string> 
                            { 
                                "Value types vs reference types",
                                "String optimization",
                                "Collection performance",
                                "Memory allocation",
                                "Benchmarking with BenchmarkDotNet"
                            }
                        },
                        new SubTopic
                        {
                            Id = 95,
                            StepId = 3,
                            Title = "Delegates and Events",
                            Description = "Master function pointers in C#",
                            Content = "Understand delegates, events, and their applications",
                            KeyPoints = new List<string> 
                            { 
                                "Delegate declarations",
                                "Multicast delegates",
                                "Event handling patterns",
                                "EventHandler<T>",
                                "Custom event args"
                            }
                        },
                        new SubTopic
                        {
                            Id = 96,
                            StepId = 3,
                            Title = "Generics",
                            Description = "Create type-safe reusable code",
                            Content = "Master generic types and methods in C#",
                            KeyPoints = new List<string> 
                            { 
                                "Generic classes",
                                "Generic methods",
                                "Type constraints",
                                "Covariance and contravariance",
                                "Generic interfaces"
                            }
                        },
                        new SubTopic
                        {
                            Id = 97,
                            StepId = 3,
                            Title = "Exception Handling",
                            Description = "Robust error handling strategies",
                            Content = "Implement effective exception handling patterns",
                            KeyPoints = new List<string> 
                            { 
                                "Try-catch-finally blocks",
                                "Custom exceptions",
                                "Exception filters",
                                "Global exception handling",
                                "Logging exceptions"
                            }
                        },
                        new SubTopic
                        {
                            Id = 98,
                            StepId = 3,
                            Title = "Attributes and Reflection",
                            Description = "Metadata and runtime inspection",
                            Content = "Use attributes and reflection for dynamic behavior",
                            KeyPoints = new List<string> 
                            { 
                                "Custom attributes",
                                "Reflection basics",
                                "Dynamic type creation",
                                "Assembly scanning",
                                "Performance implications"
                            }
                        },
                        new SubTopic
                        {
                            Id = 99,
                            StepId = 3,
                            Title = "File I/O and Serialization",
                            Description = "Work with files and data persistence",
                            Content = "Handle file operations and object serialization",
                            KeyPoints = new List<string> 
                            { 
                                "File and directory operations",
                                "Stream handling",
                                "JSON serialization",
                                "XML serialization",
                                "Binary serialization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 100,
                            StepId = 3,
                            Title = "Threading and Concurrency",
                            Description = "Parallel and concurrent programming",
                            Content = "Master multi-threaded programming in C#",
                            KeyPoints = new List<string> 
                            { 
                                "Thread class basics",
                                "Thread synchronization",
                                "Lock statements",
                                "Concurrent collections",
                                "Thread-safe patterns"
                            }
                        },
                        new SubTopic
                        {
                            Id = 101,
                            StepId = 3,
                            Title = "Memory Management",
                            Description = "Understand .NET memory model",
                            Content = "Optimize memory usage and prevent leaks",
                            KeyPoints = new List<string> 
                            { 
                                "Garbage collection",
                                "IDisposable pattern",
                                "Using statements",
                                "Memory profiling",
                                "Large object heap"
                            }
                        },
                        new SubTopic
                        {
                            Id = 102,
                            StepId = 3,
                            Title = "Extension Methods",
                            Description = "Extend existing types",
                            Content = "Create extension methods for cleaner APIs",
                            KeyPoints = new List<string> 
                            { 
                                "Extension method syntax",
                                "LINQ extensions",
                                "Best practices",
                                "Extension method discovery",
                                "Namespace considerations"
                            }
                        },
                        new SubTopic
                        {
                            Id = 103,
                            StepId = 3,
                            Title = "Nullable Reference Types",
                            Description = "Prevent null reference exceptions",
                            Content = "Use C# 8+ nullable reference types effectively",
                            KeyPoints = new List<string> 
                            { 
                                "Nullable contexts",
                                "Nullable annotations",
                                "Null-forgiving operator",
                                "Migration strategies",
                                "Compiler warnings"
                            }
                        },
                        new SubTopic
                        {
                            Id = 104,
                            StepId = 3,
                            Title = "Pattern Matching",
                            Description = "Modern C# pattern matching",
                            Content = "Use pattern matching for cleaner code",
                            KeyPoints = new List<string> 
                            { 
                                "Type patterns",
                                "Property patterns",
                                "Tuple patterns",
                                "Switch expressions",
                                "Relational patterns"
                            }
                        },
                        new SubTopic
                        {
                            Id = 105,
                            StepId = 3,
                            Title = "Records and Structs",
                            Description = "Value-based type design",
                            Content = "Use records and structs for immutable data",
                            KeyPoints = new List<string> 
                            { 
                                "Record types",
                                "Positional records",
                                "Value equality",
                                "With expressions",
                                "Struct improvements"
                            }
                        },
                        new SubTopic
                        {
                            Id = 106,
                            StepId = 3,
                            Title = "Indexers and Ranges",
                            Description = "Advanced collection access",
                            Content = "Use indexers and range operators effectively",
                            KeyPoints = new List<string> 
                            { 
                                "Custom indexers",
                                "Range operators",
                                "Index from end",
                                "Slice notation",
                                "Collection slicing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 107,
                            StepId = 3,
                            Title = "Interpolated Strings",
                            Description = "Modern string formatting",
                            Content = "Use string interpolation for readable code",
                            KeyPoints = new List<string> 
                            { 
                                "String interpolation syntax",
                                "Format specifiers",
                                "Culture-specific formatting",
                                "Verbatim strings",
                                "Raw string literals"
                            }
                        }
                    });
                }

                // Add ASP.NET Core step
                backend.Steps.Add(new RoadmapStep
                {
                    Id = 4,
                    RoadmapId = 2,
                    Title = "ASP.NET Core Web API",
                    Duration = "4-5 weeks",
                    Content = "Build RESTful APIs with ASP.NET Core",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 34,
                            StepId = 4,
                            Title = "RESTful API Design",
                            Description = "Design and implement RESTful APIs",
                            Content = "Learn best practices for creating RESTful web services",
                            KeyPoints = new List<string> 
                            { 
                                "HTTP methods and status codes",
                                "Resource-based URLs",
                                "API versioning",
                                "Content negotiation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 35,
                            StepId = 4,
                            Title = "Authentication & Authorization",
                            Description = "Secure your APIs",
                            Content = "Implement security in ASP.NET Core applications",
                            KeyPoints = new List<string> 
                            { 
                                "JWT tokens",
                                "Identity framework",
                                "Role-based authorization",
                                "OAuth 2.0"
                            }
                        },
                        new SubTopic
                        {
                            Id = 38,
                            StepId = 4,
                            Title = "API Documentation",
                            Description = "Document APIs with Swagger/OpenAPI",
                            Content = "Create comprehensive API documentation for better developer experience",
                            KeyPoints = new List<string> 
                            { 
                                "Swagger configuration",
                                "XML documentation comments",
                                "Custom schemas",
                                "API versioning documentation",
                                "Swagger UI customization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 39,
                            StepId = 4,
                            Title = "Middleware and Filters",
                            Description = "Extend ASP.NET Core pipeline",
                            Content = "Learn to create custom middleware and action filters",
                            KeyPoints = new List<string> 
                            { 
                                "Custom middleware",
                                "Action filters",
                                "Exception filters",
                                "Result filters",
                                "Pipeline configuration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 46,
                            StepId = 4,
                            Title = "API Versioning & Evolution",
                            Description = "Manage API versions effectively",
                            Content = "Learn strategies for API versioning and backward compatibility",
                            KeyPoints = new List<string> 
                            { 
                                "URL path versioning",
                                "Header versioning",
                                "Query string versioning",
                                "API deprecation",
                                "Breaking changes management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 47,
                            StepId = 4,
                            Title = "Real-time Communication",
                            Description = "Implement real-time features with SignalR",
                            Content = "Build real-time web functionality using SignalR",
                            KeyPoints = new List<string> 
                            { 
                                "SignalR hubs",
                                "WebSocket protocol",
                                "Connection management",
                                "Broadcasting patterns",
                                "Scaling SignalR"
                            }
                        },
                        new SubTopic
                        {
                            Id = 108,
                            StepId = 4,
                            Title = "Dependency Injection",
                            Description = "Master DI in ASP.NET Core",
                            Content = "Implement dependency injection patterns effectively",
                            KeyPoints = new List<string> 
                            { 
                                "Service lifetimes",
                                "Service registration",
                                "Constructor injection",
                                "Service factories",
                                "Third-party containers"
                            }
                        },
                        new SubTopic
                        {
                            Id = 109,
                            StepId = 4,
                            Title = "Configuration Management",
                            Description = "Handle application settings",
                            Content = "Manage configuration in ASP.NET Core applications",
                            KeyPoints = new List<string> 
                            { 
                                "appsettings.json",
                                "Environment variables",
                                "User secrets",
                                "Options pattern",
                                "Configuration providers"
                            }
                        },
                        new SubTopic
                        {
                            Id = 110,
                            StepId = 4,
                            Title = "Logging and Monitoring",
                            Description = "Implement comprehensive logging",
                            Content = "Add logging and monitoring to your APIs",
                            KeyPoints = new List<string> 
                            { 
                                "ILogger interface",
                                "Log levels",
                                "Structured logging",
                                "Serilog integration",
                                "Application Insights"
                            }
                        },
                        new SubTopic
                        {
                            Id = 111,
                            StepId = 4,
                            Title = "Caching Strategies",
                            Description = "Improve API performance with caching",
                            Content = "Implement various caching strategies",
                            KeyPoints = new List<string> 
                            { 
                                "In-memory caching",
                                "Distributed caching",
                                "Response caching",
                                "Cache invalidation",
                                "Redis integration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 112,
                            StepId = 4,
                            Title = "Health Checks",
                            Description = "Monitor API health status",
                            Content = "Implement health check endpoints",
                            KeyPoints = new List<string> 
                            { 
                                "Health check middleware",
                                "Custom health checks",
                                "Database connectivity",
                                "External service checks",
                                "Health check UI"
                            }
                        },
                        new SubTopic
                        {
                            Id = 113,
                            StepId = 4,
                            Title = "API Rate Limiting",
                            Description = "Protect APIs from abuse",
                            Content = "Implement rate limiting and throttling",
                            KeyPoints = new List<string> 
                            { 
                                "Rate limiting middleware",
                                "Throttling strategies",
                                "IP-based limits",
                                "API key quotas",
                                "Custom policies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 114,
                            StepId = 4,
                            Title = "CORS Configuration",
                            Description = "Handle cross-origin requests",
                            Content = "Configure CORS for web applications",
                            KeyPoints = new List<string> 
                            { 
                                "CORS policies",
                                "Allowed origins",
                                "Preflight requests",
                                "Credentials handling",
                                "Security implications"
                            }
                        },
                        new SubTopic
                        {
                            Id = 115,
                            StepId = 4,
                            Title = "Background Services",
                            Description = "Run background tasks",
                            Content = "Implement hosted services and background jobs",
                            KeyPoints = new List<string> 
                            { 
                                "IHostedService",
                                "BackgroundService",
                                "Timed tasks",
                                "Queue processing",
                                "Hangfire integration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 116,
                            StepId = 4,
                            Title = "File Upload/Download",
                            Description = "Handle file operations",
                            Content = "Implement file upload and download endpoints",
                            KeyPoints = new List<string> 
                            { 
                                "Multipart form data",
                                "File streaming",
                                "Large file handling",
                                "File validation",
                                "Storage strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 117,
                            StepId = 4,
                            Title = "API Testing",
                            Description = "Test ASP.NET Core APIs",
                            Content = "Write comprehensive API tests",
                            KeyPoints = new List<string> 
                            { 
                                "Integration testing",
                                "TestServer",
                                "WebApplicationFactory",
                                "Mock authentication",
                                "Database testing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 118,
                            StepId = 4,
                            Title = "Global Error Handling",
                            Description = "Handle errors gracefully",
                            Content = "Implement global exception handling",
                            KeyPoints = new List<string> 
                            { 
                                "Exception middleware",
                                "Problem Details",
                                "Custom error responses",
                                "Error logging",
                                "Client-friendly errors"
                            }
                        },
                        new SubTopic
                        {
                            Id = 119,
                            StepId = 4,
                            Title = "API Gateway Patterns",
                            Description = "Implement gateway patterns",
                            Content = "Use API gateway for microservices",
                            KeyPoints = new List<string> 
                            { 
                                "Gateway routing",
                                "Request aggregation",
                                "Authentication gateway",
                                "Load balancing",
                                "Circuit breakers"
                            }
                        },
                        new SubTopic
                        {
                            Id = 120,
                            StepId = 4,
                            Title = "GraphQL with .NET",
                            Description = "Build GraphQL APIs",
                            Content = "Implement GraphQL endpoints in ASP.NET Core",
                            KeyPoints = new List<string> 
                            { 
                                "HotChocolate setup",
                                "Schema definition",
                                "Resolvers",
                                "Mutations",
                                "Subscriptions"
                            }
                        }
                    }
                });

                // Add Database & EF Core step
                backend.Steps.Add(new RoadmapStep
                {
                    Id = 5,
                    RoadmapId = 2,
                    Title = "Database & Entity Framework Core",
                    Duration = "4-5 weeks",
                    Content = "Master data persistence with SQL and EF Core",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 40,
                            StepId = 5,
                            Title = "SQL Server Fundamentals",
                            Description = "Learn Microsoft SQL Server for .NET applications",
                            Content = "Master T-SQL and SQL Server features",
                            KeyPoints = new List<string> 
                            { 
                                "T-SQL syntax",
                                "Stored procedures",
                                "Views and functions",
                                "Indexes and performance",
                                "SQL Server Management Studio"
                            }
                        },
                        new SubTopic
                        {
                            Id = 41,
                            StepId = 5,
                            Title = "Entity Framework Core Mastery",
                            Description = "Advanced EF Core techniques",
                            Content = "Learn advanced Entity Framework Core patterns",
                            KeyPoints = new List<string> 
                            { 
                                "Complex queries",
                                "Performance optimization",
                                "Migrations strategies",
                                "Unit of Work pattern",
                                "Specification pattern"
                            }
                        },
                        new SubTopic
                        {
                            Id = 121,
                            StepId = 5,
                            Title = "Database Design Principles",
                            Description = "Design efficient databases",
                            Content = "Learn database design best practices",
                            KeyPoints = new List<string> 
                            { 
                                "Normalization rules",
                                "Primary and foreign keys",
                                "Indexing strategies",
                                "Denormalization",
                                "Schema design"
                            }
                        },
                        new SubTopic
                        {
                            Id = 122,
                            StepId = 5,
                            Title = "Query Optimization",
                            Description = "Write efficient SQL queries",
                            Content = "Optimize database query performance",
                            KeyPoints = new List<string> 
                            { 
                                "Execution plans",
                                "Query hints",
                                "Index usage",
                                "Query statistics",
                                "Performance tuning"
                            }
                        },
                        new SubTopic
                        {
                            Id = 123,
                            StepId = 5,
                            Title = "EF Core Relationships",
                            Description = "Model complex relationships",
                            Content = "Configure entity relationships in EF Core",
                            KeyPoints = new List<string> 
                            { 
                                "One-to-many relationships",
                                "Many-to-many relationships",
                                "Self-referencing relationships",
                                "Cascade delete",
                                "Navigation properties"
                            }
                        },
                        new SubTopic
                        {
                            Id = 124,
                            StepId = 5,
                            Title = "Database Transactions",
                            Description = "Manage database transactions",
                            Content = "Implement transactional consistency",
                            KeyPoints = new List<string> 
                            { 
                                "ACID properties",
                                "Transaction scope",
                                "Isolation levels",
                                "Distributed transactions",
                                "Rollback strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 125,
                            StepId = 5,
                            Title = "Database Migrations",
                            Description = "Manage schema evolution",
                            Content = "Handle database migrations effectively",
                            KeyPoints = new List<string> 
                            { 
                                "Code-first migrations",
                                "Database-first approach",
                                "Migration scripts",
                                "Rollback procedures",
                                "Production deployments"
                            }
                        },
                        new SubTopic
                        {
                            Id = 126,
                            StepId = 5,
                            Title = "NoSQL with .NET",
                            Description = "Work with NoSQL databases",
                            Content = "Integrate NoSQL solutions in .NET applications",
                            KeyPoints = new List<string> 
                            { 
                                "MongoDB integration",
                                "Cosmos DB",
                                "Document databases",
                                "Key-value stores",
                                "Graph databases"
                            }
                        },
                        new SubTopic
                        {
                            Id = 127,
                            StepId = 5,
                            Title = "Database Security",
                            Description = "Secure database access",
                            Content = "Implement database security best practices",
                            KeyPoints = new List<string> 
                            { 
                                "SQL injection prevention",
                                "Parameterized queries",
                                "Encryption at rest",
                                "Connection security",
                                "Access control"
                            }
                        },
                        new SubTopic
                        {
                            Id = 128,
                            StepId = 5,
                            Title = "Caching Strategies",
                            Description = "Implement data caching",
                            Content = "Use caching to improve performance",
                            KeyPoints = new List<string> 
                            { 
                                "Query result caching",
                                "Second-level cache",
                                "Redis caching",
                                "Cache invalidation",
                                "Distributed caching"
                            }
                        },
                        new SubTopic
                        {
                            Id = 129,
                            StepId = 5,
                            Title = "Bulk Operations",
                            Description = "Handle large data sets",
                            Content = "Perform efficient bulk operations",
                            KeyPoints = new List<string> 
                            { 
                                "Bulk insert",
                                "Bulk update",
                                "Bulk delete",
                                "SqlBulkCopy",
                                "EF Core bulk extensions"
                            }
                        },
                        new SubTopic
                        {
                            Id = 130,
                            StepId = 5,
                            Title = "Database Monitoring",
                            Description = "Monitor database performance",
                            Content = "Track and analyze database metrics",
                            KeyPoints = new List<string> 
                            { 
                                "Performance counters",
                                "Query profiling",
                                "Deadlock detection",
                                "Resource usage",
                                "Alert configuration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 131,
                            StepId = 5,
                            Title = "Data Seeding",
                            Description = "Initialize database data",
                            Content = "Populate databases with initial data",
                            KeyPoints = new List<string> 
                            { 
                                "Seed data strategies",
                                "Migration seeds",
                                "Test data generation",
                                "Environment-specific data",
                                "Data fixtures"
                            }
                        },
                        new SubTopic
                        {
                            Id = 132,
                            StepId = 5,
                            Title = "Database Testing",
                            Description = "Test data access code",
                            Content = "Write effective database tests",
                            KeyPoints = new List<string> 
                            { 
                                "In-memory database",
                                "Test containers",
                                "Mock repositories",
                                "Integration tests",
                                "Performance tests"
                            }
                        },
                        new SubTopic
                        {
                            Id = 133,
                            StepId = 5,
                            Title = "Concurrency Control",
                            Description = "Handle concurrent updates",
                            Content = "Manage concurrent data access",
                            KeyPoints = new List<string> 
                            { 
                                "Optimistic concurrency",
                                "Pessimistic locking",
                                "Row versioning",
                                "Conflict resolution",
                                "Retry policies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 134,
                            StepId = 5,
                            Title = "Database Sharding",
                            Description = "Scale databases horizontally",
                            Content = "Implement database sharding strategies",
                            KeyPoints = new List<string> 
                            { 
                                "Sharding strategies",
                                "Shard key selection",
                                "Cross-shard queries",
                                "Data distribution",
                                "Shard management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 135,
                            StepId = 5,
                            Title = "Backup and Recovery",
                            Description = "Protect data integrity",
                            Content = "Implement backup and recovery procedures",
                            KeyPoints = new List<string> 
                            { 
                                "Backup strategies",
                                "Point-in-time recovery",
                                "Disaster recovery",
                                "Backup automation",
                                "Recovery testing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 136,
                            StepId = 5,
                            Title = "Database Auditing",
                            Description = "Track database changes",
                            Content = "Implement audit trails for compliance",
                            KeyPoints = new List<string> 
                            { 
                                "Change tracking",
                                "Audit tables",
                                "Temporal tables",
                                "User activity logging",
                                "Compliance reporting"
                            }
                        },
                        new SubTopic
                        {
                            Id = 137,
                            StepId = 5,
                            Title = "Connection Management",
                            Description = "Optimize database connections",
                            Content = "Manage database connections efficiently",
                            KeyPoints = new List<string> 
                            { 
                                "Connection pooling",
                                "Connection strings",
                                "Retry logic",
                                "Connection lifecycle",
                                "Multi-tenancy"
                            }
                        },
                        new SubTopic
                        {
                            Id = 138,
                            StepId = 5,
                            Title = "Data Access Patterns",
                            Description = "Implement data layer patterns",
                            Content = "Use proven data access patterns",
                            KeyPoints = new List<string> 
                            { 
                                "Repository pattern",
                                "Unit of Work",
                                "CQRS pattern",
                                "Active Record",
                                "Data Mapper"
                            }
                        }
                    }
                });

                // Add Microservices step
                backend.Steps.Add(new RoadmapStep
                {
                    Id = 6,
                    RoadmapId = 2,
                    Title = "Microservices Architecture",
                    Duration = "5-6 weeks",
                    Content = "Design and build microservices-based applications",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 42,
                            StepId = 6,
                            Title = "Microservices Patterns",
                            Description = "Essential patterns for microservices",
                            Content = "Learn common microservices design patterns",
                            KeyPoints = new List<string> 
                            { 
                                "Service decomposition",
                                "API Gateway pattern",
                                "Service discovery",
                                "Circuit breaker",
                                "Saga pattern"
                            }
                        },
                        new SubTopic
                        {
                            Id = 43,
                            StepId = 6,
                            Title = "Message Queuing",
                            Description = "Implement asynchronous communication",
                            Content = "Use message brokers for microservices communication",
                            KeyPoints = new List<string> 
                            { 
                                "RabbitMQ basics",
                                "Azure Service Bus",
                                "Event-driven architecture",
                                "Message patterns",
                                "Error handling"
                            }
                        },
                        new SubTopic
                        {
                            Id = 139,
                            StepId = 6,
                            Title = "Service Mesh",
                            Description = "Manage service-to-service communication",
                            Content = "Implement service mesh for microservices",
                            KeyPoints = new List<string> 
                            { 
                                "Service discovery",
                                "Load balancing",
                                "Circuit breakers",
                                "Retry policies",
                                "Observability"
                            }
                        },
                        new SubTopic
                        {
                            Id = 140,
                            StepId = 6,
                            Title = "Distributed Tracing",
                            Description = "Trace requests across services",
                            Content = "Implement distributed tracing for debugging",
                            KeyPoints = new List<string> 
                            { 
                                "OpenTelemetry",
                                "Jaeger integration",
                                "Correlation IDs",
                                "Trace visualization",
                                "Performance analysis"
                            }
                        },
                        new SubTopic
                        {
                            Id = 141,
                            StepId = 6,
                            Title = "Event Sourcing",
                            Description = "Store events instead of state",
                            Content = "Implement event sourcing patterns",
                            KeyPoints = new List<string> 
                            { 
                                "Event store design",
                                "Event replay",
                                "Snapshots",
                                "Projections",
                                "CQRS integration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 142,
                            StepId = 6,
                            Title = "Containerization",
                            Description = "Package microservices in containers",
                            Content = "Use Docker for microservice deployment",
                            KeyPoints = new List<string> 
                            { 
                                "Docker fundamentals",
                                "Dockerfile best practices",
                                "Multi-stage builds",
                                "Container security",
                                "Registry management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 143,
                            StepId = 6,
                            Title = "Kubernetes Orchestration",
                            Description = "Deploy microservices to Kubernetes",
                            Content = "Use Kubernetes for container orchestration",
                            KeyPoints = new List<string> 
                            { 
                                "Deployments and pods",
                                "Services and ingress",
                                "ConfigMaps and secrets",
                                "Helm charts",
                                "Auto-scaling"
                            }
                        },
                        new SubTopic
                        {
                            Id = 144,
                            StepId = 6,
                            Title = "API Composition",
                            Description = "Aggregate data from multiple services",
                            Content = "Implement API composition patterns",
                            KeyPoints = new List<string> 
                            { 
                                "GraphQL federation",
                                "Backend for Frontend",
                                "API aggregation",
                                "Response composition",
                                "Error handling"
                            }
                        },
                        new SubTopic
                        {
                            Id = 145,
                            StepId = 6,
                            Title = "Service Resilience",
                            Description = "Build fault-tolerant services",
                            Content = "Implement resilience patterns",
                            KeyPoints = new List<string> 
                            { 
                                "Circuit breaker pattern",
                                "Retry with backoff",
                                "Timeout handling",
                                "Bulkhead pattern",
                                "Fallback strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 146,
                            StepId = 6,
                            Title = "Distributed Caching",
                            Description = "Share cache across services",
                            Content = "Implement distributed caching solutions",
                            KeyPoints = new List<string> 
                            { 
                                "Redis clusters",
                                "Cache-aside pattern",
                                "Write-through cache",
                                "Cache invalidation",
                                "Session management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 147,
                            StepId = 6,
                            Title = "Service Security",
                            Description = "Secure microservice communication",
                            Content = "Implement security in distributed systems",
                            KeyPoints = new List<string> 
                            { 
                                "mTLS authentication",
                                "OAuth 2.0 flows",
                                "API key management",
                                "Service-to-service auth",
                                "Zero trust architecture"
                            }
                        },
                        new SubTopic
                        {
                            Id = 148,
                            StepId = 6,
                            Title = "Distributed Logging",
                            Description = "Centralize logs from all services",
                            Content = "Implement centralized logging",
                            KeyPoints = new List<string> 
                            { 
                                "Log aggregation",
                                "Elasticsearch setup",
                                "Structured logging",
                                "Log correlation",
                                "Log analysis"
                            }
                        },
                        new SubTopic
                        {
                            Id = 149,
                            StepId = 6,
                            Title = "Service Versioning",
                            Description = "Version microservices effectively",
                            Content = "Manage service versions and compatibility",
                            KeyPoints = new List<string> 
                            { 
                                "Semantic versioning",
                                "API versioning strategies",
                                "Blue-green deployments",
                                "Canary releases",
                                "Feature flags"
                            }
                        },
                        new SubTopic
                        {
                            Id = 150,
                            StepId = 6,
                            Title = "Data Consistency",
                            Description = "Manage data in distributed systems",
                            Content = "Ensure data consistency across services",
                            KeyPoints = new List<string> 
                            { 
                                "Eventual consistency",
                                "Two-phase commit",
                                "Saga orchestration",
                                "Compensating transactions",
                                "Idempotency"
                            }
                        },
                        new SubTopic
                        {
                            Id = 151,
                            StepId = 6,
                            Title = "Service Testing",
                            Description = "Test microservices effectively",
                            Content = "Implement comprehensive testing strategies",
                            KeyPoints = new List<string> 
                            { 
                                "Contract testing",
                                "Service virtualization",
                                "Integration testing",
                                "Chaos engineering",
                                "Load testing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 152,
                            StepId = 6,
                            Title = "Service Monitoring",
                            Description = "Monitor microservice health",
                            Content = "Implement monitoring and alerting",
                            KeyPoints = new List<string> 
                            { 
                                "Prometheus metrics",
                                "Grafana dashboards",
                                "SLIs and SLOs",
                                "Alert rules",
                                "Incident response"
                            }
                        },
                        new SubTopic
                        {
                            Id = 153,
                            StepId = 6,
                            Title = "Service Documentation",
                            Description = "Document microservice APIs",
                            Content = "Create comprehensive service documentation",
                            KeyPoints = new List<string> 
                            { 
                                "OpenAPI specifications",
                                "AsyncAPI for events",
                                "Service catalogs",
                                "Dependency mapping",
                                "Architecture diagrams"
                            }
                        },
                        new SubTopic
                        {
                            Id = 154,
                            StepId = 6,
                            Title = "Service Governance",
                            Description = "Govern microservice ecosystem",
                            Content = "Implement governance and standards",
                            KeyPoints = new List<string> 
                            { 
                                "Service standards",
                                "Code ownership",
                                "Review processes",
                                "Compliance checks",
                                "Cost management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 155,
                            StepId = 6,
                            Title = "Migration Strategies",
                            Description = "Migrate from monolith to microservices",
                            Content = "Plan and execute microservice migration",
                            KeyPoints = new List<string> 
                            { 
                                "Strangler fig pattern",
                                "Domain decomposition",
                                "Data migration",
                                "Gradual rollout",
                                "Rollback planning"
                            }
                        }
                    }
                });
            }

            // C# Developer Roadmap
            var csharpDev = roadmaps.FirstOrDefault(r => r.Id == 11);
            if (csharpDev != null)
            {
                // C# Basics - Step 110
                var basicsStep = csharpDev.Steps.FirstOrDefault(s => s.Id == 110);
                if (basicsStep != null)
                {
                    basicsStep.SubTopics.AddRange(new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 1102,
                            StepId = 110,
                            Title = "JavaScript Essentials",
                            Description = "Master JavaScript fundamentals for modern web development",
                            Content = @"JavaScript is the programming language of the web, essential for creating dynamic and interactive user experiences. As a .NET developer, understanding JavaScript is crucial for full-stack development, especially when working with ASP.NET Core applications that require client-side functionality. JavaScript complements C# by handling client-side logic, DOM manipulation, asynchronous operations, and modern frontend frameworks integration.

This comprehensive guide covers JavaScript fundamentals including variables, functions, objects, arrays, promises, and modern ES6+ features. You'll learn why JavaScript is indispensable for modern web development and how it integrates seamlessly with .NET applications.",
                            KeyPoints = new List<string> 
                            { 
                                "Variables and Data Types",
                                "Functions and Scope",
                                "Objects and Prototypes",
                                "Arrays and Iteration",
                                "Asynchronous Programming",
                                "DOM Manipulation",
                                "ES6+ Features",
                                "Error Handling"
                            },
                            CodeExample = @"// JavaScript Essentials - Complete Examples

// 1. Variables and Data Types
// Why: JavaScript uses dynamic typing, different from C#'s static typing
let name = 'John Doe';              // String
const age = 30;                     // Number (immutable binding)
var isActive = true;                // Boolean (avoid var, use let/const)
let salary = 75000.50;              // Number (no separate float/double)
let nothing = null;                 // Intentional absence of value
let notDefined;                     // undefined

// Type checking
console.log(typeof name);           // 'string'
console.log(typeof age);            // 'number'

// 2. Functions - First-Class Citizens
// Why: Functions are values in JavaScript, enabling functional programming

// Function declaration
function calculateTotal(price, tax) {
    return price + (price * tax);
}

// Function expression
const greet = function(name) {
    return `Hello, ${name}!`;
};

// Arrow functions (ES6) - concise syntax
const multiply = (a, b) => a * b;

// Higher-order functions
const numbers = [1, 2, 3, 4, 5];
const doubled = numbers.map(n => n * 2);  // [2, 4, 6, 8, 10]

// 3. Objects - Dynamic and Flexible
// Why: Objects in JavaScript are more flexible than C# classes
const person = {
    firstName: 'John',
    lastName: 'Doe',
    age: 30,
    // Method shorthand
    getFullName() {
        return `${this.firstName} ${this.lastName}`;
    },
    // Computed property
    ['id_' + Date.now()]: 'unique'
};

// Object destructuring
const { firstName, age: userAge } = person;

// Object spread operator
const updatedPerson = { ...person, age: 31, city: 'New York' };

// 4. Arrays - Powerful Built-in Methods
// Why: Arrays have extensive methods for functional programming
const fruits = ['apple', 'banana', 'orange'];

// Array methods for transformation
const upperFruits = fruits.map(f => f.toUpperCase());
const filtered = fruits.filter(f => f.length > 5);
const total = [1, 2, 3, 4].reduce((sum, n) => sum + n, 0);

// Array destructuring
const [first, second, ...rest] = fruits;

// 5. Asynchronous Programming - Essential for Modern Web
// Why: Handle API calls, file operations, and timers without blocking

// Promises
function fetchUserData(id) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            if (id > 0) {
                resolve({ id, name: 'User ' + id });
            } else {
                reject(new Error('Invalid ID'));
            }
        }, 1000);
    });
}

// Async/Await - cleaner asynchronous code
async function getUserInfo() {
    try {
        const user = await fetchUserData(123);
        const posts = await fetchUserPosts(user.id);
        return { user, posts };
    } catch (error) {
        console.error('Error:', error.message);
        throw error;
    }
}

// 6. DOM Manipulation - Interact with Web Pages
// Why: Essential for creating interactive web applications
document.addEventListener('DOMContentLoaded', () => {
    // Select elements
    const button = document.querySelector('#submitBtn');
    const input = document.getElementById('userInput');
    const output = document.querySelector('.output');
    
    // Event handling
    button.addEventListener('click', async (e) => {
        e.preventDefault();
        
        // Update DOM
        output.textContent = 'Loading...';
        output.classList.add('loading');
        
        try {
            const data = await fetchData(input.value);
            output.innerHTML = `<strong>${data.result}</strong>`;
        } catch (error) {
            output.textContent = 'Error occurred';
        } finally {
            output.classList.remove('loading');
        }
    });
});

// 7. ES6+ Modern Features
// Why: Modern JavaScript features make code cleaner and more maintainable

// Classes (similar to C# but prototype-based)
class Animal {
    constructor(name) {
        this.name = name;
    }
    
    speak() {
        console.log(`${this.name} makes a sound`);
    }
}

class Dog extends Animal {
    constructor(name, breed) {
        super(name);
        this.breed = breed;
    }
    
    speak() {
        console.log(`${this.name} barks`);
    }
}

// Modules (import/export)
// utils.js
export const formatDate = (date) => {
    return new Intl.DateTimeFormat('en-US').format(date);
};

export default class Calculator {
    add(a, b) { return a + b; }
}

// main.js
import Calculator, { formatDate } from './utils.js';

// Template literals
const html = `
    <div class=""card"">
        <h2>${person.getFullName()}</h2>
        <p>Age: ${person.age}</p>
    </div>
`;

// Optional chaining and nullish coalescing
const city = person?.address?.city ?? 'Unknown';

// 8. Error Handling
// Why: Robust error handling for production applications
class ValidationError extends Error {
    constructor(message) {
        super(message);
        this.name = 'ValidationError';
    }
}

function validateEmail(email) {
    const regex = /^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$/;
    if (!regex.test(email)) {
        throw new ValidationError('Invalid email format');
    }
    return true;
}

try {
    validateEmail('invalid-email');
} catch (error) {
    if (error instanceof ValidationError) {
        console.error('Validation failed:', error.message);
    } else {
        console.error('Unexpected error:', error);
    }
}

// 9. Working with APIs - Fetch API
// Why: Communicate with backend services (like your .NET APIs)
async function callDotNetApi() {
    const response = await fetch('/api/users', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${token}`
        },
        body: JSON.stringify({
            name: 'John Doe',
            email: 'john@example.com'
        })
    });
    
    if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
    }
    
    const data = await response.json();
    return data;
}

// 10. Practical Integration with ASP.NET Core
// Why: JavaScript enhances ASP.NET Core applications

// Razor Pages integration
function initializeDataTable(tableId) {
    const table = document.getElementById(tableId);
    
    // Add sorting
    const headers = table.querySelectorAll('th');
    headers.forEach((header, index) => {
        header.addEventListener('click', () => sortTable(table, index));
    });
    
    // Add search
    const searchBox = document.createElement('input');
    searchBox.type = 'text';
    searchBox.placeholder = 'Search...';
    searchBox.addEventListener('input', (e) => filterTable(table, e.target.value));
    
    table.parentNode.insertBefore(searchBox, table);
}

// SignalR integration for real-time features
const connection = new signalR.HubConnectionBuilder()
    .withUrl('/notificationHub')
    .build();

connection.on('ReceiveNotification', (message) => {
    showNotification(message);
});

connection.start().catch(err => console.error(err));"
                        },
                        new SubTopic
                        {
                            Id = 1103,
                            StepId = 110,
                            Title = "Exception Handling",
                            Description = "Handle errors gracefully",
                            Content = "Learn to write robust code with proper exception handling",
                            KeyPoints = new List<string> 
                            { 
                                "Try-catch-finally blocks",
                                "Custom exceptions",
                                "Exception filters",
                                "Best practices"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1104,
                            StepId = 110,
                            Title = "File I/O and Serialization",
                            Description = "Work with files and data serialization",
                            Content = "Master file operations and data persistence in C#",
                            KeyPoints = new List<string> 
                            { 
                                "File and Directory operations",
                                "Streams and readers/writers",
                                "JSON serialization",
                                "XML processing",
                                "Binary serialization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1105,
                            StepId = 110,
                            Title = "Working with Dates and Times",
                            Description = "Handle date and time operations effectively",
                            Content = "Learn to work with DateTime, TimeSpan, and time zones",
                            KeyPoints = new List<string> 
                            { 
                                "DateTime and DateTimeOffset",
                                "TimeSpan calculations",
                                "Time zones handling",
                                "Date formatting",
                                "Calendar operations"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1106,
                            StepId = 110,
                            Title = "String Manipulation",
                            Description = "Master string operations in C#",
                            Content = "Learn efficient string handling and text processing",
                            KeyPoints = new List<string> 
                            { 
                                "String methods",
                                "StringBuilder usage",
                                "String formatting",
                                "Regular expressions",
                                "String interpolation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1107,
                            StepId = 110,
                            Title = "Nullable Types",
                            Description = "Work with nullable value types",
                            Content = "Understand nullable reference types and value types",
                            KeyPoints = new List<string> 
                            { 
                                "Nullable<T> syntax",
                                "Null-coalescing operators",
                                "Nullable reference types",
                                "Null safety",
                                "Default values"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1108,
                            StepId = 110,
                            Title = "Enumerations and Constants",
                            Description = "Define and use enums effectively",
                            Content = "Create type-safe constants and enumerations",
                            KeyPoints = new List<string> 
                            { 
                                "Enum declaration",
                                "Flags attribute",
                                "Enum parsing",
                                "Const vs readonly",
                                "Best practices"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1109,
                            StepId = 110,
                            Title = "Type Conversion",
                            Description = "Convert between different types",
                            Content = "Master type conversion and casting in C#",
                            KeyPoints = new List<string> 
                            { 
                                "Implicit conversions",
                                "Explicit casting",
                                "Convert class",
                                "Parse methods",
                                "Custom conversions"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1110,
                            StepId = 110,
                            Title = "Debugging Techniques",
                            Description = "Debug C# applications effectively",
                            Content = "Learn debugging tools and techniques",
                            KeyPoints = new List<string> 
                            { 
                                "Breakpoints",
                                "Watch windows",
                                "Immediate window",
                                "Debug.Assert",
                                "Conditional debugging"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1140,
                            StepId = 110,
                            Title = "XML Processing",
                            Description = "Work with XML data in C#",
                            Content = "Parse, create, and manipulate XML documents",
                            KeyPoints = new List<string> 
                            { 
                                "XDocument and XElement",
                                "LINQ to XML",
                                "XML serialization",
                                "XPath queries",
                                "XML validation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1141,
                            StepId = 110,
                            Title = "JSON Handling",
                            Description = "Work with JSON data",
                            Content = "Serialize and deserialize JSON in C# applications",
                            KeyPoints = new List<string> 
                            { 
                                "System.Text.Json",
                                "Newtonsoft.Json",
                                "Custom converters",
                                "JSON schemas",
                                "Performance tips"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1142,
                            StepId = 110,
                            Title = "Regular Expressions",
                            Description = "Pattern matching with regex",
                            Content = "Master regular expressions for text processing",
                            KeyPoints = new List<string> 
                            { 
                                "Regex patterns",
                                "Capture groups",
                                "Regex options",
                                "Performance",
                                "Common patterns"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1143,
                            StepId = 110,
                            Title = "Cryptography Basics",
                            Description = "Implement basic security features",
                            Content = "Use cryptographic functions in C#",
                            KeyPoints = new List<string> 
                            { 
                                "Hashing algorithms",
                                "Encryption/decryption",
                                "Digital signatures",
                                "Secure random numbers",
                                "Key management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1144,
                            StepId = 110,
                            Title = "Networking Basics",
                            Description = "Network programming fundamentals",
                            Content = "Build networked applications with C#",
                            KeyPoints = new List<string> 
                            { 
                                "HttpClient usage",
                                "TCP/IP sockets",
                                "WebSockets",
                                "Network streams",
                                "DNS operations"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1145,
                            StepId = 110,
                            Title = "Environment and Process",
                            Description = "Interact with system environment",
                            Content = "Work with processes and environment variables",
                            KeyPoints = new List<string> 
                            { 
                                "Environment variables",
                                "Process management",
                                "Command line args",
                                "System information",
                                "Registry access"
                            }
                        }
                    });
                }

                // Add Advanced C# step
                csharpDev.Steps.Add(new RoadmapStep
                {
                    Id = 111,
                    RoadmapId = 11,
                    Title = "Advanced C# Features",
                    Duration = "4 weeks",
                    Content = "Master advanced C# programming concepts",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 1111,
                            StepId = 111,
                            Title = "Async Programming",
                            Description = "Master asynchronous programming in C#",
                            Content = "Learn to write efficient asynchronous code",
                            KeyPoints = new List<string> 
                            { 
                                "async/await keywords",
                                "Task and Task<T>",
                                "Parallel programming",
                                "Cancellation tokens"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1112,
                            StepId = 111,
                            Title = "Delegates and Events",
                            Description = "Understand delegates and event-driven programming",
                            Content = "Master function pointers and event handling in C#",
                            KeyPoints = new List<string> 
                            { 
                                "Delegate types",
                                "Action and Func",
                                "Event handling",
                                "Lambda expressions"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1113,
                            StepId = 111,
                            Title = "Generics and Constraints",
                            Description = "Create reusable type-safe code with generics",
                            Content = "Master generic programming for flexible and type-safe code",
                            KeyPoints = new List<string> 
                            { 
                                "Generic classes and methods",
                                "Type constraints",
                                "Covariance and contravariance",
                                "Generic collections",
                                "Custom generic types"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1114,
                            StepId = 111,
                            Title = "Reflection and Attributes",
                            Description = "Inspect and manipulate code at runtime",
                            Content = "Learn metaprogramming techniques with reflection",
                            KeyPoints = new List<string> 
                            { 
                                "Type inspection",
                                "Dynamic object creation",
                                "Custom attributes",
                                "Assembly scanning",
                                "Performance considerations"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1115,
                            StepId = 111,
                            Title = "Threading and Concurrency",
                            Description = "Master multi-threaded programming",
                            Content = "Learn to write thread-safe concurrent applications",
                            KeyPoints = new List<string> 
                            { 
                                "Thread management",
                                "Thread synchronization",
                                "Concurrent collections",
                                "Task Parallel Library",
                                "PLINQ"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1116,
                            StepId = 111,
                            Title = "Memory Management",
                            Description = "Understand .NET memory management",
                            Content = "Master memory optimization and garbage collection",
                            KeyPoints = new List<string> 
                            { 
                                "Garbage collector internals",
                                "Memory profiling",
                                "IDisposable pattern",
                                "Memory leaks prevention",
                                "Large object heap"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1117,
                            StepId = 111,
                            Title = "Expression Trees",
                            Description = "Build dynamic queries and code",
                            Content = "Create and manipulate expression trees",
                            KeyPoints = new List<string> 
                            { 
                                "Expression tree basics",
                                "Building expressions",
                                "Compiling expressions",
                                "LINQ providers",
                                "Dynamic queries"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1118,
                            StepId = 111,
                            Title = "Dynamic Programming",
                            Description = "Use dynamic types in C#",
                            Content = "Work with dynamic objects and late binding",
                            KeyPoints = new List<string> 
                            { 
                                "dynamic keyword",
                                "ExpandoObject",
                                "DynamicObject",
                                "COM interop",
                                "Performance impact"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1119,
                            StepId = 111,
                            Title = "Unsafe Code",
                            Description = "Write high-performance unsafe code",
                            Content = "Use pointers and unmanaged memory",
                            KeyPoints = new List<string> 
                            { 
                                "Pointer types",
                                "Fixed statement",
                                "stackalloc",
                                "Span<T> usage",
                                "Memory safety"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1120,
                            StepId = 111,
                            Title = "Interoperability",
                            Description = "Integrate with unmanaged code",
                            Content = "Call native libraries from C#",
                            KeyPoints = new List<string> 
                            { 
                                "P/Invoke",
                                "Marshal class",
                                "COM interop",
                                "C++/CLI",
                                "Native callbacks"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1146,
                            StepId = 111,
                            Title = "Advanced LINQ",
                            Description = "Master LINQ query optimization",
                            Content = "Write efficient and complex LINQ queries",
                            KeyPoints = new List<string> 
                            { 
                                "Query optimization",
                                "Custom LINQ providers",
                                "Expression vs statement",
                                "Deferred execution",
                                "PLINQ usage"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1147,
                            StepId = 111,
                            Title = "Custom Operators",
                            Description = "Implement operator overloading",
                            Content = "Create custom operators for your types",
                            KeyPoints = new List<string> 
                            { 
                                "Operator overloading",
                                "Implicit conversions",
                                "Explicit conversions",
                                "Equality operators",
                                "Comparison operators"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1148,
                            StepId = 111,
                            Title = "Advanced Inheritance",
                            Description = "Master inheritance patterns",
                            Content = "Implement complex inheritance hierarchies",
                            KeyPoints = new List<string> 
                            { 
                                "Virtual members",
                                "Abstract classes",
                                "Sealed classes",
                                "Interface inheritance",
                                "Explicit implementation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1149,
                            StepId = 111,
                            Title = "Indexers and Properties",
                            Description = "Advanced property patterns",
                            Content = "Create sophisticated property implementations",
                            KeyPoints = new List<string> 
                            { 
                                "Property patterns",
                                "Auto-properties",
                                "Computed properties",
                                "Indexers",
                                "Init-only setters"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1150,
                            StepId = 111,
                            Title = "Tuples and Deconstruction",
                            Description = "Use tuples effectively",
                            Content = "Work with tuples and pattern matching",
                            KeyPoints = new List<string> 
                            { 
                                "ValueTuple syntax",
                                "Named tuples",
                                "Deconstruction",
                                "Pattern matching",
                                "Return multiple values"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1151,
                            StepId = 111,
                            Title = "Local Functions",
                            Description = "Define functions inside methods",
                            Content = "Use local functions for encapsulation",
                            KeyPoints = new List<string> 
                            { 
                                "Local function syntax",
                                "Closures",
                                "Static local functions",
                                "Recursive locals",
                                "Performance benefits"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1152,
                            StepId = 111,
                            Title = "Source Generators",
                            Description = "Generate code at compile time",
                            Content = "Create custom source generators",
                            KeyPoints = new List<string> 
                            { 
                                "Roslyn APIs",
                                "Generator basics",
                                "Syntax analysis",
                                "Code generation",
                                "Diagnostics"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1153,
                            StepId = 111,
                            Title = "Advanced Diagnostics",
                            Description = "Debug and profile applications",
                            Content = "Use advanced diagnostic tools",
                            KeyPoints = new List<string> 
                            { 
                                "ETW tracing",
                                "Performance counters",
                                "Memory dumps",
                                "PerfView usage",
                                "dotnet-trace"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1154,
                            StepId = 111,
                            Title = "Compiler Directives",
                            Description = "Control compilation behavior",
                            Content = "Use preprocessor directives effectively",
                            KeyPoints = new List<string> 
                            { 
                                "#if directives",
                                "Conditional compilation",
                                "#pragma warnings",
                                "Symbol definition",
                                "Platform-specific code"
                            }
                        }
                    }
                });

                // Add Design Patterns & Architecture step
                csharpDev.Steps.Add(new RoadmapStep
                {
                    Id = 112,
                    RoadmapId = 11,
                    Title = "Design Patterns & Architecture",
                    Duration = "4-5 weeks",
                    Content = "Master software design patterns and architectural principles",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 1121,
                            StepId = 112,
                            Title = "SOLID Principles",
                            Description = "Master the five SOLID principles",
                            Content = "Learn to write maintainable and extensible code",
                            KeyPoints = new List<string> 
                            { 
                                "Single Responsibility",
                                "Open-Closed Principle",
                                "Liskov Substitution",
                                "Interface Segregation",
                                "Dependency Inversion"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1122,
                            StepId = 112,
                            Title = "Creational Patterns",
                            Description = "Object creation design patterns",
                            Content = "Learn patterns for object instantiation",
                            KeyPoints = new List<string> 
                            { 
                                "Singleton pattern",
                                "Factory Method",
                                "Abstract Factory",
                                "Builder pattern",
                                "Prototype pattern"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1123,
                            StepId = 112,
                            Title = "Structural Patterns",
                            Description = "Object composition patterns",
                            Content = "Learn to compose objects for new functionality",
                            KeyPoints = new List<string> 
                            { 
                                "Adapter pattern",
                                "Decorator pattern",
                                "Facade pattern",
                                "Composite pattern",
                                "Proxy pattern"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1124,
                            StepId = 112,
                            Title = "Behavioral Patterns",
                            Description = "Object collaboration patterns",
                            Content = "Master patterns for object interactions and responsibilities",
                            KeyPoints = new List<string> 
                            { 
                                "Strategy pattern",
                                "Command pattern",
                                "Iterator pattern",
                                "Template Method",
                                "Chain of Responsibility"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1125,
                            StepId = 112,
                            Title = "Architectural Patterns",
                            Description = "Application-level design patterns",
                            Content = "Learn patterns for structuring entire applications",
                            KeyPoints = new List<string> 
                            { 
                                "MVC pattern",
                                "MVP pattern",
                                "MVVM pattern",
                                "Layered architecture",
                                "Microservices patterns"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1155,
                            StepId = 112,
                            Title = "Domain-Driven Design",
                            Description = "Model complex business domains",
                            Content = "Apply DDD principles to software design",
                            KeyPoints = new List<string> 
                            { 
                                "Bounded contexts",
                                "Aggregates",
                                "Value objects",
                                "Domain events",
                                "Ubiquitous language"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1156,
                            StepId = 112,
                            Title = "Clean Architecture",
                            Description = "Build maintainable systems",
                            Content = "Implement Uncle Bob's Clean Architecture",
                            KeyPoints = new List<string> 
                            { 
                                "Dependency rule",
                                "Layer separation",
                                "Use cases",
                                "Interface adapters",
                                "Framework independence"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1157,
                            StepId = 112,
                            Title = "Event-Driven Patterns",
                            Description = "Design event-based systems",
                            Content = "Implement reactive and event-driven architectures",
                            KeyPoints = new List<string> 
                            { 
                                "Observer pattern",
                                "Pub-sub pattern",
                                "Event sourcing",
                                "Message bus",
                                "Reactive extensions"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1158,
                            StepId = 112,
                            Title = "Repository Pattern",
                            Description = "Abstract data access",
                            Content = "Implement repository pattern correctly",
                            KeyPoints = new List<string> 
                            { 
                                "Generic repositories",
                                "Unit of Work",
                                "Specification pattern",
                                "Query objects",
                                "Testing strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1159,
                            StepId = 112,
                            Title = "Service Layer Pattern",
                            Description = "Business logic organization",
                            Content = "Structure business logic effectively",
                            KeyPoints = new List<string> 
                            { 
                                "Service interfaces",
                                "Transaction management",
                                "Cross-cutting concerns",
                                "Service composition",
                                "DTO patterns"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1160,
                            StepId = 112,
                            Title = "CQRS Pattern",
                            Description = "Separate reads and writes",
                            Content = "Implement Command Query Responsibility Segregation",
                            KeyPoints = new List<string> 
                            { 
                                "Command handlers",
                                "Query handlers",
                                "Read models",
                                "Write models",
                                "Event store"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1161,
                            StepId = 112,
                            Title = "Mediator Pattern",
                            Description = "Reduce coupling between components",
                            Content = "Implement mediator for complex interactions",
                            KeyPoints = new List<string> 
                            { 
                                "MediatR library",
                                "Request/Response",
                                "Pipeline behaviors",
                                "Notifications",
                                "Cross-cutting concerns"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1162,
                            StepId = 112,
                            Title = "Dependency Injection Patterns",
                            Description = "Master DI patterns and practices",
                            Content = "Implement dependency injection effectively",
                            KeyPoints = new List<string> 
                            { 
                                "Constructor injection",
                                "Property injection",
                                "Method injection",
                                "Service locator",
                                "Container configuration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1163,
                            StepId = 112,
                            Title = "Aspect-Oriented Programming",
                            Description = "Handle cross-cutting concerns",
                            Content = "Implement AOP patterns in C#",
                            KeyPoints = new List<string> 
                            { 
                                "Interceptors",
                                "Attributes",
                                "Dynamic proxies",
                                "PostSharp",
                                "Castle Windsor"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1164,
                            StepId = 112,
                            Title = "Anti-Patterns",
                            Description = "Recognize and avoid bad practices",
                            Content = "Learn common anti-patterns to avoid",
                            KeyPoints = new List<string> 
                            { 
                                "God object",
                                "Spaghetti code",
                                "Anemic domain model",
                                "Premature optimization",
                                "Over-engineering"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1165,
                            StepId = 112,
                            Title = "Refactoring Patterns",
                            Description = "Improve existing code",
                            Content = "Apply refactoring techniques systematically",
                            KeyPoints = new List<string> 
                            { 
                                "Extract method",
                                "Extract class",
                                "Replace conditionals",
                                "Introduce parameter object",
                                "Remove duplication"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1166,
                            StepId = 112,
                            Title = "Performance Patterns",
                            Description = "Optimize application performance",
                            Content = "Implement performance optimization patterns",
                            KeyPoints = new List<string> 
                            { 
                                "Object pooling",
                                "Lazy initialization",
                                "Caching strategies",
                                "Flyweight pattern",
                                "Data locality"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1167,
                            StepId = 112,
                            Title = "Security Patterns",
                            Description = "Implement secure design patterns",
                            Content = "Build security into your architecture",
                            KeyPoints = new List<string> 
                            { 
                                "Authentication patterns",
                                "Authorization patterns",
                                "Secure session",
                                "Input validation",
                                "Secure factory"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1168,
                            StepId = 112,
                            Title = "Concurrent Patterns",
                            Description = "Handle concurrent operations",
                            Content = "Implement thread-safe patterns",
                            KeyPoints = new List<string> 
                            { 
                                "Producer-consumer",
                                "Read-write lock",
                                "Thread pool pattern",
                                "Active object",
                                "Monitor object"
                            }
                        }
                    }
                });

                // Add Testing & Quality step
                csharpDev.Steps.Add(new RoadmapStep
                {
                    Id = 113,
                    RoadmapId = 11,
                    Title = "Testing & Code Quality",
                    Duration = "3-4 weeks",
                    Content = "Implement comprehensive testing and maintain code quality",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 1131,
                            StepId = 113,
                            Title = "Unit Testing with xUnit",
                            Description = "Write effective unit tests",
                            Content = "Master unit testing with xUnit framework",
                            KeyPoints = new List<string> 
                            { 
                                "Test structure",
                                "Assertions",
                                "Test data theories",
                                "Mocking with Moq",
                                "Test coverage"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1132,
                            StepId = 113,
                            Title = "Code Analysis & Refactoring",
                            Description = "Improve code quality systematically",
                            Content = "Use tools and techniques to maintain clean code",
                            KeyPoints = new List<string> 
                            { 
                                "Static code analysis",
                                "Code metrics",
                                "Refactoring patterns",
                                "Code reviews",
                                "Documentation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1169,
                            StepId = 113,
                            Title = "Integration Testing",
                            Description = "Test component interactions",
                            Content = "Write effective integration tests",
                            KeyPoints = new List<string> 
                            { 
                                "Test fixtures",
                                "Database testing",
                                "API testing",
                                "Service testing",
                                "Test data management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1170,
                            StepId = 113,
                            Title = "Test-Driven Development",
                            Description = "Write tests first",
                            Content = "Master TDD methodology",
                            KeyPoints = new List<string> 
                            { 
                                "Red-green-refactor",
                                "Test first approach",
                                "Minimal implementation",
                                "Continuous refactoring",
                                "TDD patterns"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1171,
                            StepId = 113,
                            Title = "Behavior-Driven Development",
                            Description = "Specify behavior with tests",
                            Content = "Implement BDD practices",
                            KeyPoints = new List<string> 
                            { 
                                "Gherkin syntax",
                                "SpecFlow framework",
                                "Feature files",
                                "Step definitions",
                                "Living documentation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1172,
                            StepId = 113,
                            Title = "Performance Testing",
                            Description = "Test application performance",
                            Content = "Ensure applications meet performance requirements",
                            KeyPoints = new List<string> 
                            { 
                                "Load testing",
                                "Stress testing",
                                "Benchmark tests",
                                "Performance profiling",
                                "Optimization strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1173,
                            StepId = 113,
                            Title = "Security Testing",
                            Description = "Test for vulnerabilities",
                            Content = "Identify and fix security issues",
                            KeyPoints = new List<string> 
                            { 
                                "OWASP testing",
                                "Penetration testing",
                                "SQL injection tests",
                                "Authentication tests",
                                "Security scanning"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1174,
                            StepId = 113,
                            Title = "Test Automation",
                            Description = "Automate test execution",
                            Content = "Build automated testing pipelines",
                            KeyPoints = new List<string> 
                            { 
                                "CI/CD integration",
                                "Test scheduling",
                                "Parallel execution",
                                "Test reporting",
                                "Flaky test management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1175,
                            StepId = 113,
                            Title = "Code Coverage",
                            Description = "Measure test effectiveness",
                            Content = "Use coverage metrics appropriately",
                            KeyPoints = new List<string> 
                            { 
                                "Line coverage",
                                "Branch coverage",
                                "Coverage tools",
                                "Coverage goals",
                                "Coverage pitfalls"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1176,
                            StepId = 113,
                            Title = "Test Data Management",
                            Description = "Manage test data effectively",
                            Content = "Create and maintain test datasets",
                            KeyPoints = new List<string> 
                            { 
                                "Test data generation",
                                "Data builders",
                                "Database seeding",
                                "Data cleanup",
                                "Data privacy"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1177,
                            StepId = 113,
                            Title = "Continuous Integration",
                            Description = "Integrate code continuously",
                            Content = "Set up effective CI pipelines",
                            KeyPoints = new List<string> 
                            { 
                                "Build automation",
                                "Test automation",
                                "Code quality gates",
                                "Artifact management",
                                "Build optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1178,
                            StepId = 113,
                            Title = "Code Documentation",
                            Description = "Document code effectively",
                            Content = "Write maintainable documentation",
                            KeyPoints = new List<string> 
                            { 
                                "XML documentation",
                                "API documentation",
                                "Code comments",
                                "README files",
                                "Architecture docs"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1179,
                            StepId = 113,
                            Title = "Code Style & Standards",
                            Description = "Enforce coding standards",
                            Content = "Maintain consistent code style",
                            KeyPoints = new List<string> 
                            { 
                                "Coding conventions",
                                "StyleCop rules",
                                "EditorConfig",
                                "Code formatters",
                                "Naming conventions"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1180,
                            StepId = 113,
                            Title = "Debugging & Profiling",
                            Description = "Advanced debugging techniques",
                            Content = "Master debugging and profiling tools",
                            KeyPoints = new List<string> 
                            { 
                                "Remote debugging",
                                "Memory profiling",
                                "Performance profiling",
                                "Diagnostic tools",
                                "Production debugging"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1181,
                            StepId = 113,
                            Title = "Dependency Management",
                            Description = "Manage project dependencies",
                            Content = "Handle NuGet packages effectively",
                            KeyPoints = new List<string> 
                            { 
                                "Package management",
                                "Version conflicts",
                                "Private feeds",
                                "Package creation",
                                "Security scanning"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1182,
                            StepId = 113,
                            Title = "Build Optimization",
                            Description = "Speed up build times",
                            Content = "Optimize build and compilation",
                            KeyPoints = new List<string> 
                            { 
                                "Incremental builds",
                                "Build caching",
                                "Parallel builds",
                                "Build analysis",
                                "MSBuild optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1183,
                            StepId = 113,
                            Title = "Release Management",
                            Description = "Manage software releases",
                            Content = "Implement effective release processes",
                            KeyPoints = new List<string> 
                            { 
                                "Versioning strategies",
                                "Release notes",
                                "Deployment automation",
                                "Rollback procedures",
                                "Feature toggles"
                            }
                        }
                    }
                });
            }

            // .NET Core Developer Roadmap
            var dotnetCore = roadmaps.FirstOrDefault(r => r.Id == 16);
            if (dotnetCore != null)
            {
                // .NET Core Fundamentals - Step 93
                var fundamentalsStep = dotnetCore.Steps.FirstOrDefault(s => s.Id == 93);
                if (fundamentalsStep != null)
                {
                    fundamentalsStep.SubTopics.AddRange(new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 932,
                            StepId = 93,
                            Title = "Dependency Injection",
                            Description = "Understanding DI in .NET Core",
                            Content = "Learn the built-in dependency injection container in .NET Core",
                            KeyPoints = new List<string> 
                            { 
                                "Service lifetimes",
                                "Service registration",
                                "Constructor injection",
                                "Service resolution"
                            }
                        },
                        new SubTopic
                        {
                            Id = 933,
                            StepId = 93,
                            Title = "Configuration Management",
                            Description = "Managing application settings",
                            Content = "Learn to handle configuration in .NET Core applications",
                            KeyPoints = new List<string> 
                            { 
                                "appsettings.json",
                                "Environment variables",
                                "User secrets",
                                "Options pattern"
                            }
                        },
                        new SubTopic
                        {
                            Id = 934,
                            StepId = 93,
                            Title = "Logging and Diagnostics",
                            Description = "Implement comprehensive logging",
                            Content = "Master logging and diagnostic tools in .NET Core",
                            KeyPoints = new List<string> 
                            { 
                                "ILogger interface",
                                "Logging providers",
                                "Structured logging",
                                "Application Insights",
                                "Health checks"
                            }
                        },
                        new SubTopic
                        {
                            Id = 935,
                            StepId = 93,
                            Title = "Background Services",
                            Description = "Create long-running background tasks",
                            Content = "Implement hosted services and background workers",
                            KeyPoints = new List<string> 
                            { 
                                "IHostedService",
                                "BackgroundService",
                                "Timed background tasks",
                                "Queue processing",
                                "Service lifetime"
                            }
                        },
                        new SubTopic
                        {
                            Id = 936,
                            StepId = 93,
                            Title = "Middleware Pipeline",
                            Description = "Understand request processing pipeline",
                            Content = "Master the middleware architecture in ASP.NET Core",
                            KeyPoints = new List<string> 
                            { 
                                "Middleware order",
                                "Custom middleware",
                                "Request/response modification",
                                "Conditional middleware",
                                "Terminal middleware"
                            }
                        },
                        new SubTopic
                        {
                            Id = 937,
                            StepId = 93,
                            Title = "Host and Startup",
                            Description = "Configure application hosting",
                            Content = "Learn about application startup and hosting configuration",
                            KeyPoints = new List<string> 
                            { 
                                "Generic Host",
                                "Startup class",
                                "Service configuration",
                                "Application lifetime",
                                "Environment detection"
                            }
                        },
                        new SubTopic
                        {
                            Id = 938,
                            StepId = 93,
                            Title = "Cross-Platform Development",
                            Description = "Build for multiple platforms",
                            Content = "Develop .NET Core applications for Windows, Linux, and macOS",
                            KeyPoints = new List<string> 
                            { 
                                "Platform-specific code",
                                "Runtime identifiers",
                                "Self-contained deployment",
                                "Platform APIs",
                                "Docker support"
                            }
                        },
                        new SubTopic
                        {
                            Id = 939,
                            StepId = 93,
                            Title = "Global Tools",
                            Description = "Create and use .NET tools",
                            Content = "Build command-line tools with .NET Core",
                            KeyPoints = new List<string> 
                            { 
                                "Tool creation",
                                "NuGet packaging",
                                "Tool installation",
                                "Command parsing",
                                "Tool distribution"
                            }
                        },
                        new SubTopic
                        {
                            Id = 940,
                            StepId = 93,
                            Title = "Memory Management",
                            Description = "Optimize memory usage",
                            Content = "Understand garbage collection and memory optimization",
                            KeyPoints = new List<string> 
                            { 
                                "GC generations",
                                "Memory profiling",
                                "Span<T> and Memory<T>",
                                "ArrayPool usage",
                                "Memory leaks"
                            }
                        },
                        new SubTopic
                        {
                            Id = 945,
                            StepId = 93,
                            Title = "Localization",
                            Description = "Build multilingual applications",
                            Content = "Implement localization in .NET Core apps",
                            KeyPoints = new List<string> 
                            { 
                                "Resource files",
                                "Culture providers",
                                "Request localization",
                                "Data formatting",
                                "Time zones"
                            }
                        },
                        new SubTopic
                        {
                            Id = 946,
                            StepId = 93,
                            Title = "File Providers",
                            Description = "Abstract file system operations",
                            Content = "Work with files using file providers",
                            KeyPoints = new List<string> 
                            { 
                                "IFileProvider",
                                "Physical files",
                                "Embedded resources",
                                "Composite providers",
                                "Change tokens"
                            }
                        },
                        new SubTopic
                        {
                            Id = 947,
                            StepId = 93,
                            Title = "HTTP Client Factory",
                            Description = "Manage HTTP connections efficiently",
                            Content = "Use IHttpClientFactory for resilient HTTP calls",
                            KeyPoints = new List<string> 
                            { 
                                "Named clients",
                                "Typed clients",
                                "Polly integration",
                                "Message handlers",
                                "Connection pooling"
                            }
                        },
                        new SubTopic
                        {
                            Id = 948,
                            StepId = 93,
                            Title = "Configuration Providers",
                            Description = "Extend configuration system",
                            Content = "Create custom configuration providers",
                            KeyPoints = new List<string> 
                            { 
                                "Custom providers",
                                "Configuration binding",
                                "Change notifications",
                                "Validation",
                                "Encryption"
                            }
                        },
                        new SubTopic
                        {
                            Id = 949,
                            StepId = 93,
                            Title = "Static Files",
                            Description = "Serve static content",
                            Content = "Configure static file serving in .NET Core",
                            KeyPoints = new List<string> 
                            { 
                                "Static file middleware",
                                "Directory browsing",
                                "MIME types",
                                "Cache headers",
                                "Compression"
                            }
                        },
                        new SubTopic
                        {
                            Id = 950,
                            StepId = 93,
                            Title = "WebSockets",
                            Description = "Real-time communication",
                            Content = "Implement WebSocket communication",
                            KeyPoints = new List<string> 
                            { 
                                "WebSocket protocol",
                                "Connection management",
                                "Message handling",
                                "SignalR integration",
                                "Scaling considerations"
                            }
                        },
                        new SubTopic
                        {
                            Id = 955,
                            StepId = 93,
                            Title = "Response Caching",
                            Description = "Improve performance with caching",
                            Content = "Implement response caching strategies",
                            KeyPoints = new List<string> 
                            { 
                                "Cache headers",
                                "VaryBy parameters",
                                "Cache profiles",
                                "Distributed cache",
                                "Cache invalidation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 956,
                            StepId = 93,
                            Title = "Session State",
                            Description = "Manage user sessions",
                            Content = "Implement session state in distributed applications",
                            KeyPoints = new List<string> 
                            { 
                                "Session middleware",
                                "Distributed sessions",
                                "Session security",
                                "Cookie configuration",
                                "State providers"
                            }
                        },
                        new SubTopic
                        {
                            Id = 957,
                            StepId = 93,
                            Title = "Request Features",
                            Description = "Access low-level HTTP features",
                            Content = "Work with HTTP request and response features",
                            KeyPoints = new List<string> 
                            { 
                                "Feature interfaces",
                                "Request body",
                                "Response body",
                                "Connection info",
                                "Server features"
                            }
                        },
                        new SubTopic
                        {
                            Id = 958,
                            StepId = 93,
                            Title = "Application Parts",
                            Description = "Modular application architecture",
                            Content = "Build modular applications with application parts",
                            KeyPoints = new List<string> 
                            { 
                                "Feature providers",
                                "Assembly scanning",
                                "Plugin architecture",
                                "Dynamic loading",
                                "Part managers"
                            }
                        }
                    });
                }

                // Add Entity Framework Core step
                dotnetCore.Steps.Add(new RoadmapStep
                {
                    Id = 94,
                    RoadmapId = 16,
                    Title = "Entity Framework Core",
                    Duration = "3-4 weeks",
                    Content = "Master data access with EF Core",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 941,
                            StepId = 94,
                            Title = "Database First vs Code First",
                            Description = "Choose the right approach for your project",
                            Content = "Understand different approaches to working with databases in EF Core",
                            KeyPoints = new List<string> 
                            { 
                                "Code First migrations",
                                "Database scaffolding",
                                "Model configuration",
                                "Fluent API"
                            }
                        },
                        new SubTopic
                        {
                            Id = 942,
                            StepId = 94,
                            Title = "Query Optimization",
                            Description = "Write efficient database queries",
                            Content = "Learn to optimize Entity Framework Core queries for performance",
                            KeyPoints = new List<string> 
                            { 
                                "Eager vs lazy loading",
                                "Query tracking",
                                "Raw SQL queries",
                                "Performance monitoring"
                            }
                        },
                        new SubTopic
                        {
                            Id = 943,
                            StepId = 94,
                            Title = "Advanced EF Core Features",
                            Description = "Master advanced Entity Framework Core capabilities",
                            Content = "Explore advanced features for complex data scenarios",
                            KeyPoints = new List<string> 
                            { 
                                "Global query filters",
                                "Interceptors and events",
                                "Concurrency handling",
                                "Shadow properties",
                                "Temporal tables"
                            }
                        },
                        new SubTopic
                        {
                            Id = 944,
                            StepId = 94,
                            Title = "Database Migrations",
                            Description = "Manage database schema evolution",
                            Content = "Learn to handle database migrations in production",
                            KeyPoints = new List<string> 
                            { 
                                "Migration strategies",
                                "Data seeding",
                                "Rollback procedures",
                                "Production deployment",
                                "Migration scripts"
                            }
                        },
                        new SubTopic
                        {
                            Id = 945,
                            StepId = 94,
                            Title = "Relationships and Navigation",
                            Description = "Model complex relationships",
                            Content = "Configure entity relationships and navigation properties",
                            KeyPoints = new List<string> 
                            { 
                                "One-to-many relationships",
                                "Many-to-many relationships",
                                "Self-referencing relationships",
                                "Cascade delete",
                                "Navigation properties"
                            }
                        },
                        new SubTopic
                        {
                            Id = 946,
                            StepId = 94,
                            Title = "Value Converters",
                            Description = "Transform data between database and model",
                            Content = "Implement custom value conversions",
                            KeyPoints = new List<string> 
                            { 
                                "Built-in converters",
                                "Custom converters",
                                "Enum conversions",
                                "JSON columns",
                                "Encryption/decryption"
                            }
                        },
                        new SubTopic
                        {
                            Id = 947,
                            StepId = 94,
                            Title = "Query Tags and Filters",
                            Description = "Enhance query diagnostics",
                            Content = "Add metadata and filters to queries",
                            KeyPoints = new List<string> 
                            { 
                                "Query tagging",
                                "Global query filters",
                                "Soft delete patterns",
                                "Multi-tenancy",
                                "Query interception"
                            }
                        },
                        new SubTopic
                        {
                            Id = 948,
                            StepId = 94,
                            Title = "Compiled Queries",
                            Description = "Optimize frequently used queries",
                            Content = "Use compiled queries for performance",
                            KeyPoints = new List<string> 
                            { 
                                "EF.CompileQuery",
                                "Async compiled queries",
                                "Parameter limitations",
                                "Performance benefits",
                                "Cache management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 949,
                            StepId = 94,
                            Title = "Database Functions",
                            Description = "Use database-specific functions",
                            Content = "Map and use database functions in queries",
                            KeyPoints = new List<string> 
                            { 
                                "Built-in functions",
                                "User-defined functions",
                                "Stored procedures",
                                "Table-valued functions",
                                "Function mapping"
                            }
                        },
                        new SubTopic
                        {
                            Id = 950,
                            StepId = 94,
                            Title = "Batch Operations",
                            Description = "Perform bulk operations efficiently",
                            Content = "Execute batch updates and deletes",
                            KeyPoints = new List<string> 
                            { 
                                "Bulk insert",
                                "Batch updates",
                                "Batch deletes",
                                "Performance tuning",
                                "Third-party libraries"
                            }
                        },
                        new SubTopic
                        {
                            Id = 951,
                            StepId = 94,
                            Title = "Connection Resiliency",
                            Description = "Handle transient failures",
                            Content = "Implement retry logic for database operations",
                            KeyPoints = new List<string> 
                            { 
                                "Execution strategies",
                                "Retry policies",
                                "Circuit breakers",
                                "Transient errors",
                                "Custom strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 952,
                            StepId = 94,
                            Title = "Database Providers",
                            Description = "Work with different databases",
                            Content = "Use EF Core with various database systems",
                            KeyPoints = new List<string> 
                            { 
                                "SQL Server provider",
                                "PostgreSQL provider",
                                "MySQL provider",
                                "SQLite provider",
                                "In-memory provider"
                            }
                        },
                        new SubTopic
                        {
                            Id = 953,
                            StepId = 94,
                            Title = "Complex Types",
                            Description = "Model complex data structures",
                            Content = "Work with owned entities and complex types",
                            KeyPoints = new List<string> 
                            { 
                                "Owned entities",
                                "Value objects",
                                "Complex type mapping",
                                "Table splitting",
                                "Entity splitting"
                            }
                        },
                        new SubTopic
                        {
                            Id = 954,
                            StepId = 94,
                            Title = "Change Tracking",
                            Description = "Understand entity state management",
                            Content = "Master EF Core change tracking mechanisms",
                            KeyPoints = new List<string> 
                            { 
                                "Entity states",
                                "Change tracker API",
                                "Detached entities",
                                "TrackGraph method",
                                "State management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 955,
                            StepId = 94,
                            Title = "Performance Profiling",
                            Description = "Profile EF Core performance",
                            Content = "Identify and resolve performance bottlenecks",
                            KeyPoints = new List<string> 
                            { 
                                "Query logging",
                                "Execution time tracking",
                                "N+1 query detection",
                                "MiniProfiler integration",
                                "Performance counters"
                            }
                        },
                        new SubTopic
                        {
                            Id = 956,
                            StepId = 94,
                            Title = "Database Indexing",
                            Description = "Configure indexes via EF Core",
                            Content = "Define and manage database indexes",
                            KeyPoints = new List<string> 
                            { 
                                "Index attributes",
                                "Fluent API configuration",
                                "Composite indexes",
                                "Unique indexes",
                                "Index filters"
                            }
                        },
                        new SubTopic
                        {
                            Id = 957,
                            StepId = 94,
                            Title = "Transactions",
                            Description = "Manage database transactions",
                            Content = "Handle transactions in EF Core applications",
                            KeyPoints = new List<string> 
                            { 
                                "Transaction scope",
                                "Savepoints",
                                "Distributed transactions",
                                "Isolation levels",
                                "Transaction patterns"
                            }
                        },
                        new SubTopic
                        {
                            Id = 958,
                            StepId = 94,
                            Title = "Testing Strategies",
                            Description = "Test EF Core applications",
                            Content = "Implement effective testing for data access",
                            KeyPoints = new List<string> 
                            { 
                                "In-memory database",
                                "SQLite for testing",
                                "Test data builders",
                                "Repository testing",
                                "Integration tests"
                            }
                        },
                        new SubTopic
                        {
                            Id = 959,
                            StepId = 94,
                            Title = "Model Validation",
                            Description = "Validate entities before saving",
                            Content = "Implement validation in EF Core",
                            KeyPoints = new List<string> 
                            { 
                                "Data annotations",
                                "IValidatableObject",
                                "Validation attributes",
                                "Custom validation",
                                "SaveChanges interception"
                            }
                        }
                    }
                });

                // Add Web API Development step
                dotnetCore.Steps.Add(new RoadmapStep
                {
                    Id = 95,
                    RoadmapId = 16,
                    Title = "Advanced Web API Development",
                    Duration = "4-5 weeks",
                    Content = "Build production-ready REST APIs with advanced features",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 951,
                            StepId = 95,
                            Title = "API Security",
                            Description = "Implement comprehensive API security",
                            Content = "Secure your APIs against common threats",
                            KeyPoints = new List<string> 
                            { 
                                "OAuth 2.0 implementation",
                                "API key management",
                                "Rate limiting",
                                "CORS configuration",
                                "Security headers"
                            }
                        },
                        new SubTopic
                        {
                            Id = 952,
                            StepId = 95,
                            Title = "API Performance",
                            Description = "Optimize API performance and scalability",
                            Content = "Build high-performance APIs",
                            KeyPoints = new List<string> 
                            { 
                                "Response caching",
                                "Output compression",
                                "Async programming",
                                "Database optimization",
                                "Load testing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 953,
                            StepId = 95,
                            Title = "API Documentation",
                            Description = "Create comprehensive API documentation",
                            Content = "Document your APIs effectively with OpenAPI/Swagger",
                            KeyPoints = new List<string> 
                            { 
                                "Swagger configuration",
                                "API versioning",
                                "Request/response examples",
                                "Authentication docs",
                                "API testing tools"
                            }
                        },
                        new SubTopic
                        {
                            Id = 954,
                            StepId = 95,
                            Title = "GraphQL Integration",
                            Description = "Implement GraphQL APIs",
                            Content = "Build flexible APIs with GraphQL in .NET",
                            KeyPoints = new List<string> 
                            { 
                                "GraphQL schema design",
                                "Hot Chocolate framework",
                                "Resolvers and data loaders",
                                "Subscriptions",
                                "Performance optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 955,
                            StepId = 95,
                            Title = "API Versioning",
                            Description = "Manage API versions effectively",
                            Content = "Implement versioning strategies for evolving APIs",
                            KeyPoints = new List<string> 
                            { 
                                "URL versioning",
                                "Header versioning",
                                "Query string versioning",
                                "Media type versioning",
                                "Deprecation policies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 956,
                            StepId = 95,
                            Title = "Content Negotiation",
                            Description = "Support multiple response formats",
                            Content = "Implement content negotiation in Web APIs",
                            KeyPoints = new List<string> 
                            { 
                                "Accept headers",
                                "Custom formatters",
                                "XML support",
                                "CSV output",
                                "Format selection"
                            }
                        },
                        new SubTopic
                        {
                            Id = 957,
                            StepId = 95,
                            Title = "Model Binding",
                            Description = "Advanced request data binding",
                            Content = "Master complex model binding scenarios",
                            KeyPoints = new List<string> 
                            { 
                                "Custom model binders",
                                "Value providers",
                                "Complex type binding",
                                "File uploads",
                                "Binding sources"
                            }
                        },
                        new SubTopic
                        {
                            Id = 958,
                            StepId = 95,
                            Title = "Action Filters",
                            Description = "Implement cross-cutting concerns",
                            Content = "Use filters for common API functionality",
                            KeyPoints = new List<string> 
                            { 
                                "Authorization filters",
                                "Resource filters",
                                "Action filters",
                                "Exception filters",
                                "Result filters"
                            }
                        },
                        new SubTopic
                        {
                            Id = 959,
                            StepId = 95,
                            Title = "API Testing",
                            Description = "Test Web APIs effectively",
                            Content = "Implement comprehensive API testing strategies",
                            KeyPoints = new List<string> 
                            { 
                                "Integration testing",
                                "WebApplicationFactory",
                                "Test fixtures",
                                "Mock authentication",
                                "Response assertions"
                            }
                        },
                        new SubTopic
                        {
                            Id = 960,
                            StepId = 95,
                            Title = "Error Handling",
                            Description = "Implement robust error responses",
                            Content = "Handle and format API errors consistently",
                            KeyPoints = new List<string> 
                            { 
                                "Problem Details",
                                "Global error handling",
                                "Custom error responses",
                                "Logging integration",
                                "Client-friendly errors"
                            }
                        },
                        new SubTopic
                        {
                            Id = 961,
                            StepId = 95,
                            Title = "Validation",
                            Description = "Validate API requests",
                            Content = "Implement comprehensive request validation",
                            KeyPoints = new List<string> 
                            { 
                                "Data annotations",
                                "FluentValidation",
                                "Custom validators",
                                "Validation errors",
                                "Client validation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 962,
                            StepId = 95,
                            Title = "Pagination and Filtering",
                            Description = "Handle large data sets",
                            Content = "Implement efficient data pagination and filtering",
                            KeyPoints = new List<string> 
                            { 
                                "Offset pagination",
                                "Cursor pagination",
                                "Dynamic filtering",
                                "Sorting options",
                                "Response headers"
                            }
                        },
                        new SubTopic
                        {
                            Id = 963,
                            StepId = 95,
                            Title = "File Handling",
                            Description = "Upload and download files",
                            Content = "Handle file operations in Web APIs",
                            KeyPoints = new List<string> 
                            { 
                                "Multipart uploads",
                                "Streaming downloads",
                                "Progress tracking",
                                "Virus scanning",
                                "Storage strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 964,
                            StepId = 95,
                            Title = "Real-time APIs",
                            Description = "Implement real-time features",
                            Content = "Add real-time capabilities to APIs",
                            KeyPoints = new List<string> 
                            { 
                                "SignalR integration",
                                "WebSocket APIs",
                                "Server-Sent Events",
                                "Long polling",
                                "Connection management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 965,
                            StepId = 95,
                            Title = "API Gateways",
                            Description = "Implement gateway patterns",
                            Content = "Use API gateways for microservices",
                            KeyPoints = new List<string> 
                            { 
                                "Ocelot configuration",
                                "Request routing",
                                "Load balancing",
                                "Authentication",
                                "Rate limiting"
                            }
                        },
                        new SubTopic
                        {
                            Id = 966,
                            StepId = 95,
                            Title = "Health Checks",
                            Description = "Monitor API health",
                            Content = "Implement health check endpoints",
                            KeyPoints = new List<string> 
                            { 
                                "Health check middleware",
                                "Custom health checks",
                                "Database checks",
                                "External service checks",
                                "Health UI"
                            }
                        },
                        new SubTopic
                        {
                            Id = 967,
                            StepId = 95,
                            Title = "Background Tasks",
                            Description = "Process work asynchronously",
                            Content = "Implement background processing in APIs",
                            KeyPoints = new List<string> 
                            { 
                                "Fire-and-forget",
                                "Queue-based processing",
                                "Hangfire integration",
                                "Scheduled tasks",
                                "Progress reporting"
                            }
                        },
                        new SubTopic
                        {
                            Id = 968,
                            StepId = 95,
                            Title = "API Monitoring",
                            Description = "Track API performance",
                            Content = "Implement comprehensive API monitoring",
                            KeyPoints = new List<string> 
                            { 
                                "Request logging",
                                "Performance metrics",
                                "Error tracking",
                                "Usage analytics",
                                "Alerting"
                            }
                        },
                        new SubTopic
                        {
                            Id = 969,
                            StepId = 95,
                            Title = "Hypermedia APIs",
                            Description = "Build HATEOAS-compliant APIs",
                            Content = "Implement hypermedia-driven APIs",
                            KeyPoints = new List<string> 
                            { 
                                "HAL format",
                                "Link generation",
                                "Resource discovery",
                                "State transitions",
                                "Client navigation"
                            }
                        }
                    }
                });

                // Add Cloud Integration step
                dotnetCore.Steps.Add(new RoadmapStep
                {
                    Id = 96,
                    RoadmapId = 16,
                    Title = "Cloud Integration & Deployment",
                    Duration = "3-4 weeks",
                    Content = "Deploy .NET Core applications to cloud platforms",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 961,
                            StepId = 96,
                            Title = "Azure App Service",
                            Description = "Deploy to Azure App Service",
                            Content = "Learn Azure deployment strategies",
                            KeyPoints = new List<string> 
                            { 
                                "App Service configuration",
                                "Deployment slots",
                                "Auto-scaling",
                                "Application Insights",
                                "Azure DevOps integration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 962,
                            StepId = 96,
                            Title = "Containerization",
                            Description = "Containerize .NET applications",
                            Content = "Use Docker for .NET Core apps",
                            KeyPoints = new List<string> 
                            { 
                                "Docker basics",
                                "Multi-stage builds",
                                "Docker Compose",
                                "Kubernetes deployment",
                                "Container registries"
                            }
                        },
                        new SubTopic
                        {
                            Id = 963,
                            StepId = 96,
                            Title = "Serverless Computing",
                            Description = "Build serverless .NET applications",
                            Content = "Deploy .NET functions to serverless platforms",
                            KeyPoints = new List<string> 
                            { 
                                "Azure Functions",
                                "AWS Lambda",
                                "Function triggers",
                                "Durable functions",
                                "Cost optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 964,
                            StepId = 96,
                            Title = "Infrastructure as Code",
                            Description = "Automate infrastructure deployment",
                            Content = "Use IaC tools for consistent deployments",
                            KeyPoints = new List<string> 
                            { 
                                "ARM templates",
                                "Terraform basics",
                                "Bicep language",
                                "CI/CD pipelines",
                                "Environment management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 965,
                            StepId = 96,
                            Title = "Cloud Native Patterns",
                            Description = "Design cloud-native applications",
                            Content = "Implement patterns for cloud environments",
                            KeyPoints = new List<string> 
                            { 
                                "12-factor apps",
                                "Stateless design",
                                "Service discovery",
                                "Configuration externalization",
                                "Graceful shutdown"
                            }
                        },
                        new SubTopic
                        {
                            Id = 966,
                            StepId = 96,
                            Title = "Container Orchestration",
                            Description = "Manage containers at scale",
                            Content = "Deploy applications using container orchestration",
                            KeyPoints = new List<string> 
                            { 
                                "Kubernetes basics",
                                "Helm charts",
                                "Service mesh",
                                "Ingress controllers",
                                "Pod autoscaling"
                            }
                        },
                        new SubTopic
                        {
                            Id = 967,
                            StepId = 96,
                            Title = "CI/CD Pipelines",
                            Description = "Automate deployment workflows",
                            Content = "Build continuous deployment pipelines",
                            KeyPoints = new List<string> 
                            { 
                                "GitHub Actions",
                                "Azure DevOps",
                                "GitLab CI",
                                "Jenkins integration",
                                "Deployment strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 968,
                            StepId = 96,
                            Title = "Cloud Storage",
                            Description = "Use cloud storage services",
                            Content = "Integrate cloud storage in applications",
                            KeyPoints = new List<string> 
                            { 
                                "Blob storage",
                                "File shares",
                                "CDN integration",
                                "Access policies",
                                "Data lifecycle"
                            }
                        },
                        new SubTopic
                        {
                            Id = 969,
                            StepId = 96,
                            Title = "Message Queues",
                            Description = "Implement cloud messaging",
                            Content = "Use cloud-based message queuing services",
                            KeyPoints = new List<string> 
                            { 
                                "Azure Service Bus",
                                "AWS SQS",
                                "RabbitMQ cloud",
                                "Dead letter queues",
                                "Message patterns"
                            }
                        },
                        new SubTopic
                        {
                            Id = 970,
                            StepId = 96,
                            Title = "Cloud Databases",
                            Description = "Use managed database services",
                            Content = "Deploy applications with cloud databases",
                            KeyPoints = new List<string> 
                            { 
                                "Azure SQL Database",
                                "Cosmos DB",
                                "AWS RDS",
                                "Connection pooling",
                                "Backup strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 971,
                            StepId = 96,
                            Title = "Monitoring and Logging",
                            Description = "Implement cloud monitoring",
                            Content = "Set up comprehensive monitoring in the cloud",
                            KeyPoints = new List<string> 
                            { 
                                "Application Insights",
                                "CloudWatch",
                                "Log aggregation",
                                "Custom metrics",
                                "Alert configuration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 972,
                            StepId = 96,
                            Title = "Cost Optimization",
                            Description = "Manage cloud costs effectively",
                            Content = "Optimize cloud resource usage and costs",
                            KeyPoints = new List<string> 
                            { 
                                "Resource tagging",
                                "Cost analysis",
                                "Reserved instances",
                                "Autoscaling policies",
                                "Budget alerts"
                            }
                        },
                        new SubTopic
                        {
                            Id = 973,
                            StepId = 96,
                            Title = "Security Best Practices",
                            Description = "Secure cloud deployments",
                            Content = "Implement cloud security measures",
                            KeyPoints = new List<string> 
                            { 
                                "Identity management",
                                "Network security",
                                "Encryption at rest",
                                "Key management",
                                "Compliance"
                            }
                        },
                        new SubTopic
                        {
                            Id = 974,
                            StepId = 96,
                            Title = "Multi-Region Deployment",
                            Description = "Deploy globally distributed apps",
                            Content = "Implement multi-region deployment strategies",
                            KeyPoints = new List<string> 
                            { 
                                "Region selection",
                                "Data replication",
                                "Traffic routing",
                                "Failover strategies",
                                "Latency optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 975,
                            StepId = 96,
                            Title = "Blue-Green Deployments",
                            Description = "Zero-downtime deployments",
                            Content = "Implement blue-green deployment patterns",
                            KeyPoints = new List<string> 
                            { 
                                "Environment setup",
                                "Traffic switching",
                                "Database migrations",
                                "Rollback procedures",
                                "Testing strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 976,
                            StepId = 96,
                            Title = "Canary Releases",
                            Description = "Gradual feature rollouts",
                            Content = "Implement canary deployment strategies",
                            KeyPoints = new List<string> 
                            { 
                                "Traffic splitting",
                                "Monitoring metrics",
                                "Rollback triggers",
                                "A/B testing",
                                "Feature flags"
                            }
                        },
                        new SubTopic
                        {
                            Id = 977,
                            StepId = 96,
                            Title = "Cloud APIs",
                            Description = "Integrate cloud provider APIs",
                            Content = "Use cloud provider SDKs and APIs",
                            KeyPoints = new List<string> 
                            { 
                                "Azure SDK",
                                "AWS SDK",
                                "Authentication",
                                "Resource management",
                                "Error handling"
                            }
                        },
                        new SubTopic
                        {
                            Id = 978,
                            StepId = 96,
                            Title = "Disaster Recovery",
                            Description = "Plan for disaster scenarios",
                            Content = "Implement disaster recovery strategies",
                            KeyPoints = new List<string> 
                            { 
                                "Backup strategies",
                                "Recovery objectives",
                                "Failover testing",
                                "Data replication",
                                "Documentation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 979,
                            StepId = 96,
                            Title = "Performance Testing",
                            Description = "Test cloud application performance",
                            Content = "Conduct performance testing in cloud environments",
                            KeyPoints = new List<string> 
                            { 
                                "Load testing tools",
                                "Stress testing",
                                "Scalability testing",
                                "Bottleneck analysis",
                                "Optimization"
                            }
                        }
                    }
                });

                // Add Microservices Architecture step
                dotnetCore.Steps.Add(new RoadmapStep
                {
                    Id = 97,
                    RoadmapId = 16,
                    Title = "Microservices Architecture",
                    Duration = "4-6 weeks",
                    Content = "Design and build microservices-based applications",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 971,
                            StepId = 97,
                            Title = "Microservices Fundamentals",
                            Description = "Understanding microservices architecture",
                            Content = "Learn the principles and patterns of microservices",
                            KeyPoints = new List<string> 
                            { 
                                "Service boundaries",
                                "Domain-driven design",
                                "Service communication",
                                "Data management",
                                "Service discovery"
                            }
                        },
                        new SubTopic
                        {
                            Id = 972,
                            StepId = 97,
                            Title = "Service Mesh & API Gateway",
                            Description = "Manage microservice communication",
                            Content = "Implement service mesh and API gateway patterns",
                            KeyPoints = new List<string> 
                            { 
                                "Ocelot API Gateway",
                                "Service mesh concepts",
                                "Load balancing",
                                "Circuit breakers",
                                "Request routing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 973,
                            StepId = 97,
                            Title = "Event-Driven Architecture",
                            Description = "Build event-driven microservices",
                            Content = "Implement asynchronous communication patterns",
                            KeyPoints = new List<string> 
                            { 
                                "Message brokers",
                                "Event sourcing",
                                "CQRS pattern",
                                "Saga pattern",
                                "RabbitMQ/Kafka"
                            }
                        },
                        new SubTopic
                        {
                            Id = 974,
                            StepId = 97,
                            Title = "Distributed Tracing & Monitoring",
                            Description = "Monitor distributed systems",
                            Content = "Implement observability in microservices",
                            KeyPoints = new List<string> 
                            { 
                                "OpenTelemetry",
                                "Distributed tracing",
                                "Centralized logging",
                                "Metrics collection",
                                "Alerting strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 975,
                            StepId = 97,
                            Title = "Service Registry",
                            Description = "Implement service discovery",
                            Content = "Enable dynamic service discovery",
                            KeyPoints = new List<string> 
                            { 
                                "Consul integration",
                                "Eureka server",
                                "Health checks",
                                "Load balancing",
                                "Service metadata"
                            }
                        },
                        new SubTopic
                        {
                            Id = 976,
                            StepId = 97,
                            Title = "Data Consistency",
                            Description = "Manage distributed data",
                            Content = "Handle data consistency in microservices",
                            KeyPoints = new List<string> 
                            { 
                                "Eventual consistency",
                                "Two-phase commit",
                                "Compensation patterns",
                                "Distributed locks",
                                "Conflict resolution"
                            }
                        },
                        new SubTopic
                        {
                            Id = 977,
                            StepId = 97,
                            Title = "Security Patterns",
                            Description = "Secure microservices communication",
                            Content = "Implement security in distributed systems",
                            KeyPoints = new List<string> 
                            { 
                                "Service-to-service auth",
                                "JWT tokens",
                                "OAuth flows",
                                "mTLS",
                                "API keys"
                            }
                        },
                        new SubTopic
                        {
                            Id = 978,
                            StepId = 97,
                            Title = "Resilience Patterns",
                            Description = "Build resilient microservices",
                            Content = "Implement fault tolerance patterns",
                            KeyPoints = new List<string> 
                            { 
                                "Retry policies",
                                "Timeout handling",
                                "Bulkhead isolation",
                                "Health endpoints",
                                "Graceful degradation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 979,
                            StepId = 97,
                            Title = "Configuration Management",
                            Description = "Centralize configuration",
                            Content = "Manage configuration across services",
                            KeyPoints = new List<string> 
                            { 
                                "Config server",
                                "Environment variables",
                                "Secret management",
                                "Dynamic refresh",
                                "Version control"
                            }
                        },
                        new SubTopic
                        {
                            Id = 980,
                            StepId = 97,
                            Title = "Testing Strategies",
                            Description = "Test microservices effectively",
                            Content = "Implement comprehensive testing for distributed systems",
                            KeyPoints = new List<string> 
                            { 
                                "Contract testing",
                                "Integration tests",
                                "End-to-end tests",
                                "Chaos testing",
                                "Service virtualization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 981,
                            StepId = 97,
                            Title = "Deployment Strategies",
                            Description = "Deploy microservices independently",
                            Content = "Implement deployment patterns for microservices",
                            KeyPoints = new List<string> 
                            { 
                                "Independent deployment",
                                "Version management",
                                "Rolling updates",
                                "Feature toggles",
                                "Rollback strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 982,
                            StepId = 97,
                            Title = "Service Boundaries",
                            Description = "Define service boundaries",
                            Content = "Design proper service boundaries using DDD",
                            KeyPoints = new List<string> 
                            { 
                                "Bounded contexts",
                                "Aggregates",
                                "Context mapping",
                                "Anti-corruption layer",
                                "Shared kernel"
                            }
                        },
                        new SubTopic
                        {
                            Id = 983,
                            StepId = 97,
                            Title = "Distributed Caching",
                            Description = "Implement caching strategies",
                            Content = "Use distributed caching in microservices",
                            KeyPoints = new List<string> 
                            { 
                                "Redis integration",
                                "Cache patterns",
                                "Cache invalidation",
                                "Session management",
                                "Performance optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 984,
                            StepId = 97,
                            Title = "Service Contracts",
                            Description = "Define service interfaces",
                            Content = "Create and maintain service contracts",
                            KeyPoints = new List<string> 
                            { 
                                "API versioning",
                                "Schema evolution",
                                "Breaking changes",
                                "Documentation",
                                "Client libraries"
                            }
                        },
                        new SubTopic
                        {
                            Id = 985,
                            StepId = 97,
                            Title = "Sidecar Pattern",
                            Description = "Implement sidecar containers",
                            Content = "Use sidecar pattern for cross-cutting concerns",
                            KeyPoints = new List<string> 
                            { 
                                "Proxy sidecars",
                                "Logging sidecars",
                                "Security sidecars",
                                "Service mesh integration",
                                "Configuration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 986,
                            StepId = 97,
                            Title = "Database per Service",
                            Description = "Implement data isolation",
                            Content = "Design database strategies for microservices",
                            KeyPoints = new List<string> 
                            { 
                                "Data isolation",
                                "Shared database anti-pattern",
                                "Data synchronization",
                                "Query patterns",
                                "Reporting challenges"
                            }
                        },
                        new SubTopic
                        {
                            Id = 987,
                            StepId = 97,
                            Title = "API Composition",
                            Description = "Aggregate data from services",
                            Content = "Implement API composition patterns",
                            KeyPoints = new List<string> 
                            { 
                                "Gateway aggregation",
                                "Backend for frontend",
                                "GraphQL federation",
                                "Response caching",
                                "Error handling"
                            }
                        },
                        new SubTopic
                        {
                            Id = 988,
                            StepId = 97,
                            Title = "Service Templates",
                            Description = "Create service blueprints",
                            Content = "Build reusable service templates",
                            KeyPoints = new List<string> 
                            { 
                                "Project templates",
                                "Common libraries",
                                "Shared utilities",
                                "Code generation",
                                "Standards enforcement"
                            }
                        },
                        new SubTopic
                        {
                            Id = 989,
                            StepId = 97,
                            Title = "Microservices Governance",
                            Description = "Establish governance practices",
                            Content = "Implement governance for microservices architecture",
                            KeyPoints = new List<string> 
                            { 
                                "Service ownership",
                                "API standards",
                                "Security policies",
                                "Compliance",
                                "Architecture reviews"
                            }
                        }
                    }
                });
            }

            // SQL & Database Developer Roadmap
            var sqlDev = roadmaps.FirstOrDefault(r => r.Id == 15);
            if (sqlDev != null)
            {
                // SQL Basics - Step 150
                var sqlBasicsStep = sqlDev.Steps.FirstOrDefault(s => s.Id == 150);
                if (sqlBasicsStep != null)
                {
                    sqlBasicsStep.SubTopics.AddRange(new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 1502,
                            StepId = 150,
                            Title = "Advanced Queries",
                            Description = "Master complex SQL queries",
                            Content = "Learn to write advanced SQL queries for complex data retrieval",
                            KeyPoints = new List<string> 
                            { 
                                "Subqueries",
                                "Common Table Expressions",
                                "Window functions",
                                "Pivot tables"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1503,
                            StepId = 150,
                            Title = "Database Design",
                            Description = "Design efficient database schemas",
                            Content = "Learn principles of good database design",
                            KeyPoints = new List<string> 
                            { 
                                "Normalization",
                                "Primary and foreign keys",
                                "Indexes",
                                "Constraints"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1504,
                            StepId = 150,
                            Title = "Joins and Relationships",
                            Description = "Master SQL joins",
                            Content = "Understand different types of joins and their usage",
                            KeyPoints = new List<string> 
                            { 
                                "Inner joins",
                                "Left/Right joins",
                                "Full outer joins",
                                "Cross joins",
                                "Self joins"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1505,
                            StepId = 150,
                            Title = "Stored Procedures",
                            Description = "Write database stored procedures",
                            Content = "Create reusable database code with stored procedures",
                            KeyPoints = new List<string> 
                            { 
                                "Procedure syntax",
                                "Parameters",
                                "Return values",
                                "Error handling",
                                "Security benefits"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1506,
                            StepId = 150,
                            Title = "Triggers",
                            Description = "Implement database triggers",
                            Content = "Use triggers for automated database actions",
                            KeyPoints = new List<string> 
                            { 
                                "INSERT triggers",
                                "UPDATE triggers",
                                "DELETE triggers",
                                "INSTEAD OF triggers",
                                "Trigger best practices"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1507,
                            StepId = 150,
                            Title = "Views",
                            Description = "Create and manage database views",
                            Content = "Simplify complex queries with views",
                            KeyPoints = new List<string> 
                            { 
                                "Simple views",
                                "Complex views",
                                "Materialized views",
                                "Indexed views",
                                "View security"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1508,
                            StepId = 150,
                            Title = "Functions",
                            Description = "Create SQL functions",
                            Content = "Build reusable functions for data manipulation",
                            KeyPoints = new List<string> 
                            { 
                                "Scalar functions",
                                "Table-valued functions",
                                "System functions",
                                "User-defined functions",
                                "Performance considerations"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1509,
                            StepId = 150,
                            Title = "Transactions",
                            Description = "Manage database transactions",
                            Content = "Ensure data consistency with transactions",
                            KeyPoints = new List<string> 
                            { 
                                "ACID properties",
                                "BEGIN/COMMIT/ROLLBACK",
                                "Transaction isolation",
                                "Deadlock handling",
                                "Distributed transactions"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1510,
                            StepId = 150,
                            Title = "Data Types",
                            Description = "Master SQL data types",
                            Content = "Choose appropriate data types for columns",
                            KeyPoints = new List<string> 
                            { 
                                "Numeric types",
                                "String types",
                                "Date/time types",
                                "Binary types",
                                "JSON/XML types"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1513,
                            StepId = 150,
                            Title = "Aggregate Functions",
                            Description = "Use aggregate functions effectively",
                            Content = "Perform calculations on sets of rows",
                            KeyPoints = new List<string> 
                            { 
                                "COUNT, SUM, AVG",
                                "MIN, MAX",
                                "GROUP BY",
                                "HAVING clause",
                                "ROLLUP/CUBE"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1514,
                            StepId = 150,
                            Title = "Set Operations",
                            Description = "Combine query results",
                            Content = "Use set operations to merge data",
                            KeyPoints = new List<string> 
                            { 
                                "UNION",
                                "INTERSECT",
                                "EXCEPT",
                                "UNION ALL",
                                "Performance tips"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1515,
                            StepId = 150,
                            Title = "Database Security",
                            Description = "Implement database security",
                            Content = "Secure your database from threats",
                            KeyPoints = new List<string> 
                            { 
                                "User management",
                                "Role-based access",
                                "Permissions",
                                "Encryption",
                                "SQL injection prevention"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1516,
                            StepId = 150,
                            Title = "Import/Export Data",
                            Description = "Move data in and out",
                            Content = "Transfer data between systems",
                            KeyPoints = new List<string> 
                            { 
                                "BULK INSERT",
                                "BCP utility",
                                "Import/Export wizard",
                                "CSV handling",
                                "ETL basics"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1517,
                            StepId = 150,
                            Title = "Cursors",
                            Description = "Process data row by row",
                            Content = "Use cursors for sequential processing",
                            KeyPoints = new List<string> 
                            { 
                                "Cursor declaration",
                                "FETCH operations",
                                "Cursor types",
                                "Performance impact",
                                "Alternatives to cursors"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1518,
                            StepId = 150,
                            Title = "Temporary Tables",
                            Description = "Use temporary storage",
                            Content = "Work with temporary tables and table variables",
                            KeyPoints = new List<string> 
                            { 
                                "Local temp tables",
                                "Global temp tables",
                                "Table variables",
                                "CTE usage",
                                "Performance comparison"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1519,
                            StepId = 150,
                            Title = "Dynamic SQL",
                            Description = "Build queries dynamically",
                            Content = "Create flexible SQL statements at runtime",
                            KeyPoints = new List<string> 
                            { 
                                "EXECUTE statement",
                                "sp_executesql",
                                "Security risks",
                                "Parameter handling",
                                "Best practices"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1520,
                            StepId = 150,
                            Title = "Error Handling",
                            Description = "Handle SQL errors gracefully",
                            Content = "Implement robust error handling in SQL",
                            KeyPoints = new List<string> 
                            { 
                                "TRY/CATCH blocks",
                                "ERROR functions",
                                "RAISERROR",
                                "Custom error messages",
                                "Error logging"
                            }
                        }
                    });
                }

                // Add Performance Tuning step
                sqlDev.Steps.Add(new RoadmapStep
                {
                    Id = 151,
                    RoadmapId = 15,
                    Title = "SQL Performance Tuning",
                    Duration = "3 weeks",
                    Content = "Optimize database performance",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 1511,
                            StepId = 151,
                            Title = "Query Optimization",
                            Description = "Optimize slow SQL queries",
                            Content = "Learn techniques to improve query performance",
                            KeyPoints = new List<string> 
                            { 
                                "Execution plans",
                                "Index strategies",
                                "Query hints",
                                "Statistics"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1512,
                            StepId = 151,
                            Title = "Database Maintenance",
                            Description = "Keep databases running smoothly",
                            Content = "Learn essential database maintenance tasks",
                            KeyPoints = new List<string> 
                            { 
                                "Backup strategies",
                                "Index maintenance",
                                "Statistics updates",
                                "Monitoring"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1513,
                            StepId = 151,
                            Title = "Execution Plans",
                            Description = "Analyze query execution plans",
                            Content = "Read and optimize execution plans",
                            KeyPoints = new List<string> 
                            { 
                                "Graphical plans",
                                "Plan operators",
                                "Cost estimation",
                                "Plan cache",
                                "Forced plans"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1514,
                            StepId = 151,
                            Title = "Index Strategies",
                            Description = "Design effective indexes",
                            Content = "Create and maintain optimal indexes",
                            KeyPoints = new List<string> 
                            { 
                                "Clustered indexes",
                                "Non-clustered indexes",
                                "Covering indexes",
                                "Filtered indexes",
                                "Index fragmentation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1515,
                            StepId = 151,
                            Title = "Query Hints",
                            Description = "Use query hints wisely",
                            Content = "Override optimizer decisions when necessary",
                            KeyPoints = new List<string> 
                            { 
                                "Join hints",
                                "Table hints",
                                "Query hints",
                                "Plan guides",
                                "Hint risks"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1516,
                            StepId = 151,
                            Title = "Statistics Management",
                            Description = "Maintain query optimizer statistics",
                            Content = "Ensure accurate statistics for optimal plans",
                            KeyPoints = new List<string> 
                            { 
                                "Auto-update statistics",
                                "Manual updates",
                                "Histogram analysis",
                                "Sampling rates",
                                "Statistics objects"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1517,
                            StepId = 151,
                            Title = "Wait Statistics",
                            Description = "Identify performance bottlenecks",
                            Content = "Analyze wait types and resource contention",
                            KeyPoints = new List<string> 
                            { 
                                "Common wait types",
                                "DMV queries",
                                "Resource waits",
                                "Blocking analysis",
                                "Wait stat baselines"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1518,
                            StepId = 151,
                            Title = "Memory Optimization",
                            Description = "Optimize memory usage",
                            Content = "Configure and monitor memory allocation",
                            KeyPoints = new List<string> 
                            { 
                                "Buffer pool",
                                "Plan cache",
                                "Memory grants",
                                "In-memory OLTP",
                                "Memory pressure"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1519,
                            StepId = 151,
                            Title = "Partitioning",
                            Description = "Implement table partitioning",
                            Content = "Manage large tables with partitioning",
                            KeyPoints = new List<string> 
                            { 
                                "Partition functions",
                                "Partition schemes",
                                "Sliding window",
                                "Partition elimination",
                                "Maintenance benefits"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1520,
                            StepId = 151,
                            Title = "Compression",
                            Description = "Reduce storage and improve I/O",
                            Content = "Implement data compression strategies",
                            KeyPoints = new List<string> 
                            { 
                                "Row compression",
                                "Page compression",
                                "Columnstore indexes",
                                "Backup compression",
                                "CPU trade-offs"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1521,
                            StepId = 151,
                            Title = "Resource Governor",
                            Description = "Manage resource allocation",
                            Content = "Control CPU and memory usage",
                            KeyPoints = new List<string> 
                            { 
                                "Resource pools",
                                "Workload groups",
                                "Classifier functions",
                                "Resource limits",
                                "Monitoring usage"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1522,
                            StepId = 151,
                            Title = "Extended Events",
                            Description = "Advanced performance monitoring",
                            Content = "Use Extended Events for detailed analysis",
                            KeyPoints = new List<string> 
                            { 
                                "Event sessions",
                                "Targets",
                                "Predicates",
                                "Performance impact",
                                "Analysis tools"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1523,
                            StepId = 151,
                            Title = "Query Store",
                            Description = "Track query performance history",
                            Content = "Use Query Store for performance troubleshooting",
                            KeyPoints = new List<string> 
                            { 
                                "Configuration options",
                                "Query performance",
                                "Plan forcing",
                                "Regression detection",
                                "Reports and analysis"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1524,
                            StepId = 151,
                            Title = "Deadlock Analysis",
                            Description = "Resolve deadlock issues",
                            Content = "Identify and prevent deadlocks",
                            KeyPoints = new List<string> 
                            { 
                                "Deadlock graphs",
                                "Trace flags",
                                "Lock ordering",
                                "Isolation levels",
                                "Prevention strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1525,
                            StepId = 151,
                            Title = "TempDB Optimization",
                            Description = "Optimize TempDB performance",
                            Content = "Configure TempDB for optimal performance",
                            KeyPoints = new List<string> 
                            { 
                                "File configuration",
                                "Trace flags",
                                "Contention reduction",
                                "Monitoring usage",
                                "Best practices"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1526,
                            StepId = 151,
                            Title = "Parameter Sniffing",
                            Description = "Handle parameter sniffing issues",
                            Content = "Resolve performance problems from parameter sniffing",
                            KeyPoints = new List<string> 
                            { 
                                "Problem identification",
                                "OPTIMIZE FOR hints",
                                "Plan guides",
                                "Recompilation",
                                "Solution patterns"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1527,
                            StepId = 151,
                            Title = "Baseline Performance",
                            Description = "Establish performance baselines",
                            Content = "Create and maintain performance baselines",
                            KeyPoints = new List<string> 
                            { 
                                "Metric collection",
                                "Baseline periods",
                                "Trend analysis",
                                "Alert thresholds",
                                "Capacity planning"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1528,
                            StepId = 151,
                            Title = "High Availability Impact",
                            Description = "Performance in HA environments",
                            Content = "Optimize performance in high availability setups",
                            KeyPoints = new List<string> 
                            { 
                                "AlwaysOn performance",
                                "Mirroring overhead",
                                "Replication latency",
                                "Clustering considerations",
                                "Readable secondaries"
                            }
                        },
                        new SubTopic
                        {
                            Id = 1529,
                            StepId = 151,
                            Title = "Application Optimization",
                            Description = "Optimize from application side",
                            Content = "Improve database performance through application changes",
                            KeyPoints = new List<string> 
                            { 
                                "Connection pooling",
                                "Batch operations",
                                "Caching strategies",
                                "Async operations",
                                "ORM optimization"
                            }
                        }
                    }
                });
            }

            // Add subtopics for other roadmaps
            AddMobileSubTopics(roadmaps);
            AddDataScienceSubTopics(roadmaps);
            AddDevOpsSubTopics(roadmaps);
            AddSpecializedSubTopics(roadmaps);
        }

        private void AddMobileSubTopics(List<Roadmap> roadmaps)
        {
            // Mobile App Developer
            var mobile = roadmaps.FirstOrDefault(r => r.Id == 3);
            if (mobile != null)
            {
                var mobileBasics = mobile.Steps.FirstOrDefault(s => s.Id == 30);
                if (mobileBasics != null)
                {
                    mobileBasics.SubTopics.AddRange(new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 302,
                            StepId = 30,
                            Title = "Mobile UI/UX Design",
                            Description = "Design principles for mobile apps",
                            Content = "Learn to create intuitive mobile user interfaces",
                            KeyPoints = new List<string> 
                            { 
                                "Touch-friendly interfaces",
                                "Navigation patterns",
                                "Material Design",
                                "iOS Human Interface Guidelines"
                            }
                        },
                        new SubTopic
                        {
                            Id = 303,
                            StepId = 30,
                            Title = "Cross-Platform Development",
                            Description = "Build once, deploy everywhere",
                            Content = "Explore cross-platform mobile development frameworks",
                            KeyPoints = new List<string> 
                            { 
                                "React Native",
                                "Flutter",
                                ".NET MAUI",
                                "Framework comparison"
                            }
                        },
                        new SubTopic
                        {
                            Id = 304,
                            StepId = 30,
                            Title = "Mobile App Architecture",
                            Description = "Design scalable mobile applications",
                            Content = "Learn architectural patterns for mobile development",
                            KeyPoints = new List<string> 
                            { 
                                "MVVM pattern",
                                "Clean Architecture",
                                "State management",
                                "Offline-first design",
                                "Code sharing strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 305,
                            StepId = 30,
                            Title = "Mobile Performance",
                            Description = "Optimize mobile app performance",
                            Content = "Learn techniques to build fast and efficient mobile applications",
                            KeyPoints = new List<string> 
                            { 
                                "Memory management",
                                "Battery optimization",
                                "Network efficiency",
                                "Image optimization",
                                "App size reduction"
                            }
                        },
                        new SubTopic
                        {
                            Id = 306,
                            StepId = 30,
                            Title = "Mobile Security",
                            Description = "Implement secure mobile applications",
                            Content = "Learn mobile security best practices and implementation",
                            KeyPoints = new List<string> 
                            { 
                                "Data encryption",
                                "Secure authentication",
                                "Certificate pinning",
                                "Code obfuscation",
                                "Security testing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 307,
                            StepId = 30,
                            Title = "Mobile DevOps",
                            Description = "Implement CI/CD for mobile apps",
                            Content = "Automate mobile app build, test, and deployment processes",
                            KeyPoints = new List<string> 
                            { 
                                "Automated builds",
                                "Unit and UI testing",
                                "Beta distribution",
                                "App store automation",
                                "Crash reporting"
                            }
                        },
                        new SubTopic
                        {
                            Id = 308,
                            StepId = 30,
                            Title = "Mobile Analytics",
                            Description = "Track user behavior and app performance",
                            Content = "Implement analytics to understand user engagement",
                            KeyPoints = new List<string> 
                            { 
                                "Event tracking",
                                "User funnels",
                                "Crash analytics",
                                "Performance metrics",
                                "A/B testing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 309,
                            StepId = 30,
                            Title = "Mobile Accessibility",
                            Description = "Build accessible mobile applications",
                            Content = "Ensure apps are usable by everyone",
                            KeyPoints = new List<string> 
                            { 
                                "Screen reader support",
                                "Color contrast",
                                "Touch target sizes",
                                "Voice control",
                                "Accessibility testing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 310,
                            StepId = 30,
                            Title = "Mobile Monetization",
                            Description = "Generate revenue from mobile apps",
                            Content = "Implement various monetization strategies",
                            KeyPoints = new List<string> 
                            { 
                                "In-app purchases",
                                "Subscription models",
                                "Ad integration",
                                "Freemium strategies",
                                "Payment processing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 311,
                            StepId = 30,
                            Title = "App Store Guidelines",
                            Description = "Navigate app store requirements",
                            Content = "Understand and comply with platform policies",
                            KeyPoints = new List<string> 
                            { 
                                "Apple App Store rules",
                                "Google Play policies",
                                "Content guidelines",
                                "Privacy requirements",
                                "Review process"
                            }
                        },
                        new SubTopic
                        {
                            Id = 312,
                            StepId = 30,
                            Title = "Mobile Prototyping",
                            Description = "Rapidly prototype mobile ideas",
                            Content = "Use tools to quickly validate app concepts",
                            KeyPoints = new List<string> 
                            { 
                                "Wireframing tools",
                                "Interactive prototypes",
                                "User testing",
                                "Iteration cycles",
                                "Design handoff"
                            }
                        },
                        new SubTopic
                        {
                            Id = 313,
                            StepId = 30,
                            Title = "Mobile State Management",
                            Description = "Manage app state effectively",
                            Content = "Learn patterns for state management in mobile apps",
                            KeyPoints = new List<string> 
                            { 
                                "State patterns",
                                "Redux/MobX",
                                "Provider pattern",
                                "State persistence",
                                "State synchronization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 314,
                            StepId = 30,
                            Title = "Mobile Networking",
                            Description = "Handle network operations in mobile",
                            Content = "Implement robust networking in mobile applications",
                            KeyPoints = new List<string> 
                            { 
                                "RESTful APIs",
                                "GraphQL clients",
                                "Offline handling",
                                "Request caching",
                                "Network monitoring"
                            }
                        },
                        new SubTopic
                        {
                            Id = 315,
                            StepId = 30,
                            Title = "Mobile Navigation",
                            Description = "Design intuitive navigation patterns",
                            Content = "Implement effective navigation in mobile apps",
                            KeyPoints = new List<string> 
                            { 
                                "Tab navigation",
                                "Stack navigation",
                                "Drawer patterns",
                                "Deep linking",
                                "Navigation state"
                            }
                        },
                        new SubTopic
                        {
                            Id = 316,
                            StepId = 30,
                            Title = "Mobile Forms",
                            Description = "Create user-friendly mobile forms",
                            Content = "Design and implement effective form inputs",
                            KeyPoints = new List<string> 
                            { 
                                "Input validation",
                                "Keyboard handling",
                                "Error states",
                                "Auto-complete",
                                "Form persistence"
                            }
                        },
                        new SubTopic
                        {
                            Id = 317,
                            StepId = 30,
                            Title = "Mobile Gestures",
                            Description = "Implement touch gestures",
                            Content = "Add intuitive gesture interactions",
                            KeyPoints = new List<string> 
                            { 
                                "Swipe gestures",
                                "Pinch to zoom",
                                "Long press",
                                "Drag and drop",
                                "Custom gestures"
                            }
                        },
                        new SubTopic
                        {
                            Id = 318,
                            StepId = 30,
                            Title = "Mobile Localization",
                            Description = "Build multilingual mobile apps",
                            Content = "Support multiple languages and regions",
                            KeyPoints = new List<string> 
                            { 
                                "String resources",
                                "RTL support",
                                "Date/time formatting",
                                "Currency handling",
                                "Cultural considerations"
                            }
                        },
                        new SubTopic
                        {
                            Id = 319,
                            StepId = 30,
                            Title = "Mobile Media",
                            Description = "Work with media in mobile apps",
                            Content = "Handle images, audio, and video content",
                            KeyPoints = new List<string> 
                            { 
                                "Image optimization",
                                "Video playback",
                                "Audio recording",
                                "Media compression",
                                "Streaming content"
                            }
                        }
                    });
                }

                // Add Native Development step
                mobile.Steps.Add(new RoadmapStep
                {
                    Id = 31,
                    RoadmapId = 3,
                    Title = "Native Mobile Development",
                    Duration = "6-8 weeks",
                    Content = "Build native iOS and Android applications",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 311,
                            StepId = 31,
                            Title = "iOS Development with Swift",
                            Description = "Build native iOS applications",
                            Content = "Learn Swift and iOS SDK for iPhone/iPad apps",
                            KeyPoints = new List<string> 
                            { 
                                "Swift language basics",
                                "UIKit framework",
                                "SwiftUI",
                                "Core Data",
                                "App Store deployment"
                            }
                        },
                        new SubTopic
                        {
                            Id = 312,
                            StepId = 31,
                            Title = "Android Development with Kotlin",
                            Description = "Build native Android applications",
                            Content = "Master Kotlin and Android SDK",
                            KeyPoints = new List<string> 
                            { 
                                "Kotlin fundamentals",
                                "Android Jetpack",
                                "Jetpack Compose",
                                "Room database",
                                "Google Play deployment"
                            }
                        },
                        new SubTopic
                        {
                            Id = 313,
                            StepId = 31,
                            Title = "Native UI Components",
                            Description = "Master platform-specific UI elements",
                            Content = "Build beautiful native user interfaces",
                            KeyPoints = new List<string> 
                            { 
                                "Custom views and controls",
                                "Animation frameworks",
                                "Gesture recognition",
                                "Adaptive layouts",
                                "Dark mode support"
                            }
                        },
                        new SubTopic
                        {
                            Id = 314,
                            StepId = 31,
                            Title = "Platform Services",
                            Description = "Integrate with device capabilities",
                            Content = "Access native platform features and services",
                            KeyPoints = new List<string> 
                            { 
                                "Camera and media",
                                "Location services",
                                "Biometric authentication",
                                "Sensors and motion",
                                "Background tasks"
                            }
                        },
                        new SubTopic
                        {
                            Id = 315,
                            StepId = 31,
                            Title = "Native Performance Optimization",
                            Description = "Optimize native app performance",
                            Content = "Implement performance best practices for native apps",
                            KeyPoints = new List<string> 
                            { 
                                "Memory profiling",
                                "CPU optimization",
                                "Render performance",
                                "Launch time optimization",
                                "Battery efficiency"
                            }
                        },
                        new SubTopic
                        {
                            Id = 316,
                            StepId = 31,
                            Title = "Native Debugging",
                            Description = "Debug native mobile applications",
                            Content = "Master debugging tools for iOS and Android",
                            KeyPoints = new List<string> 
                            { 
                                "Xcode debugger",
                                "Android Studio debugger",
                                "Memory leak detection",
                                "Performance monitoring",
                                "Crash symbolication"
                            }
                        },
                        new SubTopic
                        {
                            Id = 317,
                            StepId = 31,
                            Title = "Platform-Specific Features",
                            Description = "Leverage unique platform capabilities",
                            Content = "Implement features specific to iOS or Android",
                            KeyPoints = new List<string> 
                            { 
                                "iOS widgets",
                                "Android widgets",
                                "Siri integration",
                                "Google Assistant",
                                "Platform extensions"
                            }
                        },
                        new SubTopic
                        {
                            Id = 318,
                            StepId = 31,
                            Title = "Native Threading",
                            Description = "Manage threads in native apps",
                            Content = "Implement concurrent programming in mobile",
                            KeyPoints = new List<string> 
                            { 
                                "Main thread safety",
                                "Background threads",
                                "Async operations",
                                "Thread pools",
                                "Synchronization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 319,
                            StepId = 31,
                            Title = "Native Data Storage",
                            Description = "Persist data in native apps",
                            Content = "Implement various data storage solutions",
                            KeyPoints = new List<string> 
                            { 
                                "UserDefaults/SharedPreferences",
                                "File system storage",
                                "Keychain/Keystore",
                                "Database integration",
                                "Cloud sync"
                            }
                        },
                        new SubTopic
                        {
                            Id = 320,
                            StepId = 31,
                            Title = "Native Animations",
                            Description = "Create smooth native animations",
                            Content = "Implement engaging animations in native apps",
                            KeyPoints = new List<string> 
                            { 
                                "Core Animation (iOS)",
                                "Android Animation APIs",
                                "Physics-based animations",
                                "Transition animations",
                                "Gesture-driven animations"
                            }
                        },
                        new SubTopic
                        {
                            Id = 321,
                            StepId = 31,
                            Title = "Native Testing",
                            Description = "Test native mobile applications",
                            Content = "Implement comprehensive testing strategies",
                            KeyPoints = new List<string> 
                            { 
                                "XCTest framework",
                                "Espresso testing",
                                "UI testing",
                                "Integration tests",
                                "Test automation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 322,
                            StepId = 31,
                            Title = "Native Dependency Management",
                            Description = "Manage dependencies in native projects",
                            Content = "Use package managers for native development",
                            KeyPoints = new List<string> 
                            { 
                                "CocoaPods",
                                "Swift Package Manager",
                                "Gradle dependencies",
                                "Maven repositories",
                                "Version management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 323,
                            StepId = 31,
                            Title = "Native Code Architecture",
                            Description = "Design scalable native app architecture",
                            Content = "Implement clean architecture patterns",
                            KeyPoints = new List<string> 
                            { 
                                "MVC/MVP/MVVM",
                                "Clean Architecture",
                                "Dependency injection",
                                "Modular design",
                                "Code organization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 324,
                            StepId = 31,
                            Title = "Native Notifications",
                            Description = "Implement local and push notifications",
                            Content = "Create engaging notification experiences",
                            KeyPoints = new List<string> 
                            { 
                                "Local notifications",
                                "Push notification setup",
                                "Rich notifications",
                                "Notification actions",
                                "Silent notifications"
                            }
                        },
                        new SubTopic
                        {
                            Id = 325,
                            StepId = 31,
                            Title = "Native Security",
                            Description = "Secure native mobile applications",
                            Content = "Implement security best practices",
                            KeyPoints = new List<string> 
                            { 
                                "Code obfuscation",
                                "Certificate pinning",
                                "Secure storage",
                                "Biometric auth",
                                "Anti-tampering"
                            }
                        },
                        new SubTopic
                        {
                            Id = 326,
                            StepId = 31,
                            Title = "Native Accessibility",
                            Description = "Build accessible native apps",
                            Content = "Implement platform accessibility features",
                            KeyPoints = new List<string> 
                            { 
                                "VoiceOver support",
                                "TalkBack support",
                                "Dynamic type",
                                "Color adjustments",
                                "Assistive technologies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 327,
                            StepId = 31,
                            Title = "Native Localization",
                            Description = "Localize native applications",
                            Content = "Support multiple languages in native apps",
                            KeyPoints = new List<string> 
                            { 
                                "String catalogs",
                                "Plural rules",
                                "Date formatting",
                                "Number formatting",
                                "Image localization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 328,
                            StepId = 31,
                            Title = "Native Distribution",
                            Description = "Distribute native apps",
                            Content = "Manage app distribution and updates",
                            KeyPoints = new List<string> 
                            { 
                                "App signing",
                                "Beta testing",
                                "App store submission",
                                "Enterprise distribution",
                                "Update mechanisms"
                            }
                        },
                        new SubTopic
                        {
                            Id = 329,
                            StepId = 31,
                            Title = "Native Monitoring",
                            Description = "Monitor native app performance",
                            Content = "Track app health in production",
                            KeyPoints = new List<string> 
                            { 
                                "Crash reporting",
                                "Performance metrics",
                                "User analytics",
                                "Error tracking",
                                "Real-time monitoring"
                            }
                        }
                    }
                });

                // Add Mobile Backend Integration step
                mobile.Steps.Add(new RoadmapStep
                {
                    Id = 32,
                    RoadmapId = 3,
                    Title = "Mobile Backend Integration",
                    Duration = "3-4 weeks",
                    Content = "Connect mobile apps to backend services",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 321,
                            StepId = 32,
                            Title = "REST API Integration",
                            Description = "Consume REST APIs in mobile apps",
                            Content = "Learn to integrate mobile apps with backend services",
                            KeyPoints = new List<string> 
                            { 
                                "HTTP networking",
                                "JSON parsing",
                                "Authentication handling",
                                "Offline sync",
                                "Error handling"
                            }
                        },
                        new SubTopic
                        {
                            Id = 322,
                            StepId = 32,
                            Title = "Push Notifications",
                            Description = "Implement push notifications",
                            Content = "Add real-time notifications to mobile apps",
                            KeyPoints = new List<string> 
                            { 
                                "Firebase Cloud Messaging",
                                "Apple Push Notification Service",
                                "Local notifications",
                                "Notification handling",
                                "Deep linking"
                            }
                        },
                        new SubTopic
                        {
                            Id = 323,
                            StepId = 32,
                            Title = "Mobile Database Solutions",
                            Description = "Implement local data persistence",
                            Content = "Choose and implement mobile database solutions",
                            KeyPoints = new List<string> 
                            { 
                                "SQLite integration",
                                "Core Data (iOS)",
                                "Room (Android)",
                                "Realm database",
                                "Data synchronization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 324,
                            StepId = 32,
                            Title = "Cloud Services Integration",
                            Description = "Leverage cloud platforms for mobile",
                            Content = "Integrate mobile apps with cloud services",
                            KeyPoints = new List<string> 
                            { 
                                "Firebase services",
                                "AWS Amplify",
                                "Azure Mobile Apps",
                                "User authentication",
                                "Cloud storage"
                            }
                        },
                        new SubTopic
                        {
                            Id = 325,
                            StepId = 32,
                            Title = "Mobile Authentication",
                            Description = "Implement secure authentication",
                            Content = "Add various authentication methods to mobile apps",
                            KeyPoints = new List<string> 
                            { 
                                "OAuth 2.0",
                                "Social login",
                                "Biometric auth",
                                "Multi-factor auth",
                                "Token management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 326,
                            StepId = 32,
                            Title = "Real-time Data Sync",
                            Description = "Synchronize data in real-time",
                            Content = "Implement real-time data synchronization",
                            KeyPoints = new List<string> 
                            { 
                                "WebSocket connections",
                                "Firebase Realtime DB",
                                "Conflict resolution",
                                "Offline queuing",
                                "Sync strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 327,
                            StepId = 32,
                            Title = "Mobile GraphQL",
                            Description = "Use GraphQL in mobile apps",
                            Content = "Implement GraphQL clients for mobile",
                            KeyPoints = new List<string> 
                            { 
                                "Apollo Client",
                                "Query optimization",
                                "Caching strategies",
                                "Subscriptions",
                                "Error handling"
                            }
                        },
                        new SubTopic
                        {
                            Id = 328,
                            StepId = 32,
                            Title = "Backend for Frontend (BFF)",
                            Description = "Design mobile-specific backends",
                            Content = "Create optimized backends for mobile clients",
                            KeyPoints = new List<string> 
                            { 
                                "BFF pattern",
                                "Mobile optimization",
                                "API aggregation",
                                "Response formatting",
                                "Bandwidth optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 329,
                            StepId = 32,
                            Title = "Mobile Caching",
                            Description = "Implement effective caching",
                            Content = "Cache data for offline access and performance",
                            KeyPoints = new List<string> 
                            { 
                                "Cache strategies",
                                "Cache invalidation",
                                "Image caching",
                                "API response caching",
                                "Cache size management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 330,
                            StepId = 32,
                            Title = "Mobile Security",
                            Description = "Secure mobile-backend communication",
                            Content = "Implement security best practices",
                            KeyPoints = new List<string> 
                            { 
                                "API key management",
                                "Certificate pinning",
                                "Request signing",
                                "Encryption in transit",
                                "Security headers"
                            }
                        },
                        new SubTopic
                        {
                            Id = 331,
                            StepId = 32,
                            Title = "Mobile Analytics Backend",
                            Description = "Track and analyze mobile data",
                            Content = "Implement backend analytics for mobile apps",
                            KeyPoints = new List<string> 
                            { 
                                "Event collection",
                                "User tracking",
                                "Performance metrics",
                                "Custom dashboards",
                                "Data warehousing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 332,
                            StepId = 32,
                            Title = "Mobile File Upload",
                            Description = "Handle file uploads from mobile",
                            Content = "Implement efficient file upload mechanisms",
                            KeyPoints = new List<string> 
                            { 
                                "Multipart uploads",
                                "Resumable uploads",
                                "Progress tracking",
                                "Compression",
                                "Background uploads"
                            }
                        },
                        new SubTopic
                        {
                            Id = 333,
                            StepId = 32,
                            Title = "Mobile Payments",
                            Description = "Integrate payment processing",
                            Content = "Add payment capabilities to mobile apps",
                            KeyPoints = new List<string> 
                            { 
                                "Apple Pay",
                                "Google Pay",
                                "Stripe integration",
                                "PCI compliance",
                                "Transaction security"
                            }
                        },
                        new SubTopic
                        {
                            Id = 334,
                            StepId = 32,
                            Title = "Mobile Backend Monitoring",
                            Description = "Monitor mobile backend health",
                            Content = "Track backend performance for mobile apps",
                            KeyPoints = new List<string> 
                            { 
                                "API monitoring",
                                "Error tracking",
                                "Performance metrics",
                                "Alerting",
                                "Log aggregation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 335,
                            StepId = 32,
                            Title = "Mobile Data Compression",
                            Description = "Optimize data transfer",
                            Content = "Reduce bandwidth usage for mobile apps",
                            KeyPoints = new List<string> 
                            { 
                                "Response compression",
                                "Image optimization",
                                "Protocol buffers",
                                "Delta sync",
                                "Bandwidth monitoring"
                            }
                        },
                        new SubTopic
                        {
                            Id = 336,
                            StepId = 32,
                            Title = "Mobile API Versioning",
                            Description = "Manage API versions for mobile",
                            Content = "Handle multiple API versions gracefully",
                            KeyPoints = new List<string> 
                            { 
                                "Version strategies",
                                "Backward compatibility",
                                "Deprecation policies",
                                "Client detection",
                                "Migration paths"
                            }
                        },
                        new SubTopic
                        {
                            Id = 337,
                            StepId = 32,
                            Title = "Mobile Queue Processing",
                            Description = "Handle asynchronous operations",
                            Content = "Implement job queues for mobile backends",
                            KeyPoints = new List<string> 
                            { 
                                "Job queuing",
                                "Background processing",
                                "Retry mechanisms",
                                "Status tracking",
                                "Priority queues"
                            }
                        },
                        new SubTopic
                        {
                            Id = 338,
                            StepId = 32,
                            Title = "Mobile Search",
                            Description = "Implement search functionality",
                            Content = "Add powerful search to mobile apps",
                            KeyPoints = new List<string> 
                            { 
                                "Full-text search",
                                "Search suggestions",
                                "Faceted search",
                                "Search analytics",
                                "Relevance tuning"
                            }
                        },
                        new SubTopic
                        {
                            Id = 339,
                            StepId = 32,
                            Title = "Mobile Geolocation Services",
                            Description = "Build location-based features",
                            Content = "Integrate geolocation services in mobile apps",
                            KeyPoints = new List<string> 
                            { 
                                "Geofencing",
                                "Location tracking",
                                "Maps integration",
                                "Distance calculations",
                                "Location privacy"
                            }
                        }
                    }
                });

                // Add Mobile Testing step
                mobile.Steps.Add(new RoadmapStep
                {
                    Id = 33,
                    RoadmapId = 3,
                    Title = "Mobile Testing & Quality",
                    Duration = "3-4 weeks",
                    Content = "Ensure mobile app quality through comprehensive testing",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 331,
                            StepId = 33,
                            Title = "Mobile Testing Strategies",
                            Description = "Implement comprehensive mobile testing",
                            Content = "Learn mobile-specific testing approaches",
                            KeyPoints = new List<string> 
                            { 
                                "Unit testing frameworks",
                                "UI automation testing",
                                "Performance testing",
                                "Device fragmentation",
                                "Beta testing programs"
                            }
                        },
                        new SubTopic
                        {
                            Id = 332,
                            StepId = 33,
                            Title = "App Store Optimization",
                            Description = "Maximize app visibility and downloads",
                            Content = "Learn ASO techniques for app stores",
                            KeyPoints = new List<string> 
                            { 
                                "Keyword optimization",
                                "App descriptions",
                                "Screenshot optimization",
                                "User reviews management",
                                "A/B testing listings"
                            }
                        },
                        new SubTopic
                        {
                            Id = 333,
                            StepId = 33,
                            Title = "Mobile Test Automation",
                            Description = "Automate mobile app testing",
                            Content = "Build automated test suites for mobile apps",
                            KeyPoints = new List<string> 
                            { 
                                "Appium framework",
                                "XCUITest",
                                "Espresso",
                                "Test scripting",
                                "CI integration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 334,
                            StepId = 33,
                            Title = "Cross-Platform Testing",
                            Description = "Test across multiple platforms",
                            Content = "Ensure consistency across iOS and Android",
                            KeyPoints = new List<string> 
                            { 
                                "Platform differences",
                                "Test strategies",
                                "Device farms",
                                "Compatibility testing",
                                "Feature parity"
                            }
                        },
                        new SubTopic
                        {
                            Id = 335,
                            StepId = 33,
                            Title = "Mobile Security Testing",
                            Description = "Test app security",
                            Content = "Identify and fix security vulnerabilities",
                            KeyPoints = new List<string> 
                            { 
                                "Penetration testing",
                                "OWASP mobile",
                                "Static analysis",
                                "Dynamic analysis",
                                "Security scanning"
                            }
                        },
                        new SubTopic
                        {
                            Id = 336,
                            StepId = 33,
                            Title = "Usability Testing",
                            Description = "Evaluate user experience",
                            Content = "Conduct effective usability tests",
                            KeyPoints = new List<string> 
                            { 
                                "User testing sessions",
                                "Task completion",
                                "Heat maps",
                                "Session recordings",
                                "Feedback analysis"
                            }
                        },
                        new SubTopic
                        {
                            Id = 337,
                            StepId = 33,
                            Title = "Load Testing Mobile Apps",
                            Description = "Test app under heavy load",
                            Content = "Ensure apps handle high user volumes",
                            KeyPoints = new List<string> 
                            { 
                                "Backend load testing",
                                "Client performance",
                                "Concurrent users",
                                "Stress testing",
                                "Scalability testing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 338,
                            StepId = 33,
                            Title = "Mobile Accessibility Testing",
                            Description = "Verify accessibility compliance",
                            Content = "Test apps for accessibility standards",
                            KeyPoints = new List<string> 
                            { 
                                "Screen reader testing",
                                "Color contrast",
                                "Touch targets",
                                "Navigation testing",
                                "WCAG compliance"
                            }
                        },
                        new SubTopic
                        {
                            Id = 339,
                            StepId = 33,
                            Title = "Beta Testing Programs",
                            Description = "Manage beta testing",
                            Content = "Run effective beta testing programs",
                            KeyPoints = new List<string> 
                            { 
                                "TestFlight setup",
                                "Google Play Beta",
                                "User recruitment",
                                "Feedback collection",
                                "Bug tracking"
                            }
                        },
                        new SubTopic
                        {
                            Id = 340,
                            StepId = 33,
                            Title = "Mobile Crash Analysis",
                            Description = "Analyze and fix crashes",
                            Content = "Use crash reporting tools effectively",
                            KeyPoints = new List<string> 
                            { 
                                "Crash symbolication",
                                "Stack trace analysis",
                                "Crash grouping",
                                "Priority assessment",
                                "Root cause analysis"
                            }
                        },
                        new SubTopic
                        {
                            Id = 341,
                            StepId = 33,
                            Title = "Network Testing",
                            Description = "Test network conditions",
                            Content = "Verify app behavior under various network conditions",
                            KeyPoints = new List<string> 
                            { 
                                "Offline testing",
                                "Slow network",
                                "Network switching",
                                "Proxy testing",
                                "VPN compatibility"
                            }
                        },
                        new SubTopic
                        {
                            Id = 342,
                            StepId = 33,
                            Title = "Mobile Localization Testing",
                            Description = "Test localized versions",
                            Content = "Ensure quality across all languages",
                            KeyPoints = new List<string> 
                            { 
                                "Text truncation",
                                "Character encoding",
                                "Date/time formats",
                                "Currency display",
                                "Cultural validation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 343,
                            StepId = 33,
                            Title = "Memory Testing",
                            Description = "Identify memory issues",
                            Content = "Test and optimize memory usage",
                            KeyPoints = new List<string> 
                            { 
                                "Memory leaks",
                                "Memory profiling",
                                "Allocation tracking",
                                "Memory warnings",
                                "Optimization techniques"
                            }
                        },
                        new SubTopic
                        {
                            Id = 344,
                            StepId = 33,
                            Title = "Battery Testing",
                            Description = "Monitor battery impact",
                            Content = "Ensure efficient battery usage",
                            KeyPoints = new List<string> 
                            { 
                                "Power profiling",
                                "Background usage",
                                "Wake lock testing",
                                "GPS impact",
                                "Optimization strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 345,
                            StepId = 33,
                            Title = "Regression Testing",
                            Description = "Prevent feature breakage",
                            Content = "Implement effective regression test suites",
                            KeyPoints = new List<string> 
                            { 
                                "Test case management",
                                "Automated regression",
                                "Smoke testing",
                                "Test prioritization",
                                "Version tracking"
                            }
                        },
                        new SubTopic
                        {
                            Id = 346,
                            StepId = 33,
                            Title = "Mobile CI/CD Testing",
                            Description = "Integrate testing in pipelines",
                            Content = "Automate testing in CI/CD workflows",
                            KeyPoints = new List<string> 
                            { 
                                "Build automation",
                                "Test execution",
                                "Result reporting",
                                "Pipeline optimization",
                                "Parallel testing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 347,
                            StepId = 33,
                            Title = "App Review Guidelines Testing",
                            Description = "Test for store compliance",
                            Content = "Ensure apps meet store requirements",
                            KeyPoints = new List<string> 
                            { 
                                "Policy compliance",
                                "Content guidelines",
                                "Technical requirements",
                                "Metadata validation",
                                "Pre-submission checks"
                            }
                        },
                        new SubTopic
                        {
                            Id = 348,
                            StepId = 33,
                            Title = "Mobile Analytics Testing",
                            Description = "Verify analytics implementation",
                            Content = "Test analytics tracking accuracy",
                            KeyPoints = new List<string> 
                            { 
                                "Event tracking",
                                "Data accuracy",
                                "Privacy compliance",
                                "Debug tools",
                                "Data validation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 349,
                            StepId = 33,
                            Title = "Mobile Test Documentation",
                            Description = "Document test processes",
                            Content = "Create comprehensive test documentation",
                            KeyPoints = new List<string> 
                            { 
                                "Test plans",
                                "Test cases",
                                "Bug reports",
                                "Test metrics",
                                "Knowledge sharing"
                            }
                        }
                    }
                });

                // Add Advanced Mobile Topics step
                mobile.Steps.Add(new RoadmapStep
                {
                    Id = 34,
                    RoadmapId = 3,
                    Title = "Advanced Mobile Technologies",
                    Duration = "4-5 weeks",
                    Content = "Explore cutting-edge mobile development technologies",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 341,
                            StepId = 34,
                            Title = "AR/VR Development",
                            Description = "Build augmented and virtual reality apps",
                            Content = "Create immersive mobile experiences",
                            KeyPoints = new List<string> 
                            { 
                                "ARKit (iOS)",
                                "ARCore (Android)",
                                "3D graphics basics",
                                "Unity integration",
                                "Spatial computing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 342,
                            StepId = 34,
                            Title = "Machine Learning on Mobile",
                            Description = "Implement ML models in mobile apps",
                            Content = "Deploy AI capabilities on mobile devices",
                            KeyPoints = new List<string> 
                            { 
                                "Core ML (iOS)",
                                "ML Kit (Android)",
                                "TensorFlow Lite",
                                "On-device inference",
                                "Model optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 343,
                            StepId = 34,
                            Title = "IoT and Wearables",
                            Description = "Connect mobile apps to IoT devices",
                            Content = "Build apps for connected devices and wearables",
                            KeyPoints = new List<string> 
                            { 
                                "Bluetooth connectivity",
                                "WatchOS development",
                                "Wear OS development",
                                "Home automation",
                                "Health sensors integration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 344,
                            StepId = 34,
                            Title = "Mobile Gaming",
                            Description = "Develop mobile games",
                            Content = "Create engaging mobile gaming experiences",
                            KeyPoints = new List<string> 
                            { 
                                "Unity mobile",
                                "Game engines",
                                "3D graphics",
                                "Physics engines",
                                "Multiplayer features"
                            }
                        },
                        new SubTopic
                        {
                            Id = 345,
                            StepId = 34,
                            Title = "Progressive Web Apps",
                            Description = "Build PWAs for mobile",
                            Content = "Create app-like web experiences",
                            KeyPoints = new List<string> 
                            { 
                                "Service workers",
                                "App manifest",
                                "Offline functionality",
                                "Push notifications",
                                "App installation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 346,
                            StepId = 34,
                            Title = "Voice Interfaces",
                            Description = "Implement voice control",
                            Content = "Add voice capabilities to mobile apps",
                            KeyPoints = new List<string> 
                            { 
                                "Speech recognition",
                                "Natural language processing",
                                "Voice commands",
                                "Text-to-speech",
                                "Voice assistants"
                            }
                        },
                        new SubTopic
                        {
                            Id = 347,
                            StepId = 34,
                            Title = "Mobile Blockchain",
                            Description = "Integrate blockchain technology",
                            Content = "Build decentralized mobile applications",
                            KeyPoints = new List<string> 
                            { 
                                "Wallet integration",
                                "Smart contracts",
                                "Cryptocurrency",
                                "DApp development",
                                "Security considerations"
                            }
                        },
                        new SubTopic
                        {
                            Id = 348,
                            StepId = 34,
                            Title = "Edge Computing",
                            Description = "Process data on-device",
                            Content = "Implement edge computing in mobile apps",
                            KeyPoints = new List<string> 
                            { 
                                "On-device processing",
                                "Edge AI",
                                "Offline capabilities",
                                "Data privacy",
                                "Performance benefits"
                            }
                        },
                        new SubTopic
                        {
                            Id = 349,
                            StepId = 34,
                            Title = "Mobile Computer Vision",
                            Description = "Implement visual recognition",
                            Content = "Add computer vision features to mobile apps",
                            KeyPoints = new List<string> 
                            { 
                                "Object detection",
                                "Face recognition",
                                "OCR capabilities",
                                "Image segmentation",
                                "Real-time processing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 350,
                            StepId = 34,
                            Title = "5G Mobile Development",
                            Description = "Leverage 5G capabilities",
                            Content = "Build apps optimized for 5G networks",
                            KeyPoints = new List<string> 
                            { 
                                "Ultra-low latency",
                                "High bandwidth apps",
                                "Network slicing",
                                "Edge computing",
                                "New use cases"
                            }
                        },
                        new SubTopic
                        {
                            Id = 351,
                            StepId = 34,
                            Title = "Mobile Haptics",
                            Description = "Implement haptic feedback",
                            Content = "Create tactile experiences in mobile apps",
                            KeyPoints = new List<string> 
                            { 
                                "Haptic patterns",
                                "Tactile feedback",
                                "Core Haptics",
                                "Vibration API",
                                "User experience"
                            }
                        },
                        new SubTopic
                        {
                            Id = 352,
                            StepId = 34,
                            Title = "Mobile Biometrics",
                            Description = "Advanced biometric features",
                            Content = "Implement advanced biometric authentication",
                            KeyPoints = new List<string> 
                            { 
                                "Face ID/recognition",
                                "Fingerprint scanning",
                                "Voice recognition",
                                "Behavioral biometrics",
                                "Multi-modal auth"
                            }
                        },
                        new SubTopic
                        {
                            Id = 353,
                            StepId = 34,
                            Title = "Mobile Health Tech",
                            Description = "Build health-focused apps",
                            Content = "Develop mobile health and fitness applications",
                            KeyPoints = new List<string> 
                            { 
                                "HealthKit/Google Fit",
                                "Wearable integration",
                                "Health data privacy",
                                "Medical compliance",
                                "Telehealth features"
                            }
                        },
                        new SubTopic
                        {
                            Id = 354,
                            StepId = 34,
                            Title = "Mobile AI Assistants",
                            Description = "Build intelligent assistants",
                            Content = "Create AI-powered mobile assistants",
                            KeyPoints = new List<string> 
                            { 
                                "Conversational AI",
                                "Intent recognition",
                                "Context awareness",
                                "Personalization",
                                "Multi-turn dialogs"
                            }
                        },
                        new SubTopic
                        {
                            Id = 355,
                            StepId = 34,
                            Title = "Mobile Streaming",
                            Description = "Implement live streaming",
                            Content = "Build live streaming capabilities",
                            KeyPoints = new List<string> 
                            { 
                                "Live video streaming",
                                "Audio streaming",
                                "Low latency protocols",
                                "CDN integration",
                                "Interactive features"
                            }
                        },
                        new SubTopic
                        {
                            Id = 356,
                            StepId = 34,
                            Title = "Mobile Robotics",
                            Description = "Control robots via mobile",
                            Content = "Develop mobile apps for robotics control",
                            KeyPoints = new List<string> 
                            { 
                                "Robot communication",
                                "Remote control",
                                "Sensor data",
                                "Real-time control",
                                "Autonomous features"
                            }
                        },
                        new SubTopic
                        {
                            Id = 357,
                            StepId = 34,
                            Title = "Mobile Sustainability",
                            Description = "Build eco-friendly apps",
                            Content = "Develop sustainable mobile applications",
                            KeyPoints = new List<string> 
                            { 
                                "Energy efficiency",
                                "Carbon footprint",
                                "Green computing",
                                "Resource optimization",
                                "Sustainable UX"
                            }
                        },
                        new SubTopic
                        {
                            Id = 358,
                            StepId = 34,
                            Title = "Mobile Edge AI",
                            Description = "Run AI models on-device",
                            Content = "Deploy AI at the edge for mobile apps",
                            KeyPoints = new List<string> 
                            { 
                                "Model optimization",
                                "Quantization",
                                "Neural engine usage",
                                "Privacy preservation",
                                "Offline AI"
                            }
                        },
                        new SubTopic
                        {
                            Id = 359,
                            StepId = 34,
                            Title = "Mobile Quantum Computing",
                            Description = "Quantum computing interfaces",
                            Content = "Access quantum computing from mobile",
                            KeyPoints = new List<string> 
                            { 
                                "Quantum APIs",
                                "Cloud quantum",
                                "Hybrid algorithms",
                                "Quantum simulation",
                                "Future readiness"
                            }
                        }
                    }
                });
            }
        }

        private void AddDataScienceSubTopics(List<Roadmap> roadmaps)
        {
            // Data Scientist
            var dataScience = roadmaps.FirstOrDefault(r => r.Id == 4);
            if (dataScience != null)
            {
                var dsBasics = dataScience.Steps.FirstOrDefault(s => s.Id == 40);
                if (dsBasics != null)
                {
                    dsBasics.SubTopics.AddRange(new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 402,
                            StepId = 40,
                            Title = "Python for Data Science",
                            Description = "Essential Python libraries for data analysis",
                            Content = "Master Python tools for data science work",
                            KeyPoints = new List<string> 
                            { 
                                "NumPy arrays",
                                "Pandas DataFrames",
                                "Matplotlib visualization",
                                "Scikit-learn basics"
                            }
                        },
                        new SubTopic
                        {
                            Id = 403,
                            StepId = 40,
                            Title = "Statistical Analysis",
                            Description = "Statistical foundations for data science",
                            Content = "Learn essential statistics for data analysis",
                            KeyPoints = new List<string> 
                            { 
                                "Descriptive statistics",
                                "Hypothesis testing",
                                "Correlation and regression",
                                "Probability distributions"
                            }
                        },
                        new SubTopic
                        {
                            Id = 404,
                            StepId = 40,
                            Title = "Machine Learning Fundamentals",
                            Description = "Introduction to machine learning algorithms",
                            Content = "Learn core machine learning concepts and algorithms",
                            KeyPoints = new List<string> 
                            { 
                                "Supervised vs unsupervised learning",
                                "Classification algorithms",
                                "Regression techniques",
                                "Model evaluation metrics",
                                "Cross-validation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 405,
                            StepId = 40,
                            Title = "Data Visualization",
                            Description = "Create compelling data visualizations",
                            Content = "Master data visualization techniques for effective communication",
                            KeyPoints = new List<string> 
                            { 
                                "Visualization principles",
                                "Chart types and selection",
                                "Interactive dashboards",
                                "Storytelling with data",
                                "Tools: Matplotlib, Seaborn, Plotly"
                            }
                        },
                        new SubTopic
                        {
                            Id = 406,
                            StepId = 40,
                            Title = "Data Wrangling & Cleaning",
                            Description = "Prepare data for analysis",
                            Content = "Master data preprocessing and cleaning techniques",
                            KeyPoints = new List<string> 
                            { 
                                "Handling missing data",
                                "Data transformation",
                                "Feature engineering",
                                "Outlier detection",
                                "Data quality assessment"
                            }
                        },
                        new SubTopic
                        {
                            Id = 407,
                            StepId = 40,
                            Title = "Exploratory Data Analysis",
                            Description = "Discover insights through exploration",
                            Content = "Learn systematic approaches to understanding data",
                            KeyPoints = new List<string> 
                            { 
                                "Data profiling",
                                "Statistical summaries",
                                "Pattern identification",
                                "Correlation analysis",
                                "Feature importance"
                            }
                        },
                        new SubTopic
                        {
                            Id = 408,
                            StepId = 40,
                            Title = "Data Collection Methods",
                            Description = "Gather data from various sources",
                            Content = "Learn different data collection techniques",
                            KeyPoints = new List<string> 
                            { 
                                "Web scraping",
                                "API integration",
                                "Survey design",
                                "Database queries",
                                "Data streaming"
                            }
                        },
                        new SubTopic
                        {
                            Id = 409,
                            StepId = 40,
                            Title = "Feature Engineering",
                            Description = "Create meaningful features for ML",
                            Content = "Transform raw data into useful features",
                            KeyPoints = new List<string> 
                            { 
                                "Feature creation",
                                "Feature scaling",
                                "Encoding techniques",
                                "Feature selection",
                                "Dimensionality reduction"
                            }
                        },
                        new SubTopic
                        {
                            Id = 410,
                            StepId = 40,
                            Title = "SQL for Data Science",
                            Description = "Query and manipulate databases",
                            Content = "Master SQL for data analysis tasks",
                            KeyPoints = new List<string> 
                            { 
                                "Complex queries",
                                "Window functions",
                                "CTEs",
                                "Performance optimization",
                                "NoSQL basics"
                            }
                        },
                        new SubTopic
                        {
                            Id = 416,
                            StepId = 40,
                            Title = "Data Science Workflow",
                            Description = "End-to-end data science process",
                            Content = "Understand the complete data science lifecycle",
                            KeyPoints = new List<string> 
                            { 
                                "Problem definition",
                                "Data acquisition",
                                "Model development",
                                "Validation strategies",
                                "Deployment planning"
                            }
                        },
                        new SubTopic
                        {
                            Id = 417,
                            StepId = 40,
                            Title = "Jupyter Notebooks",
                            Description = "Interactive data science environment",
                            Content = "Master Jupyter for data science projects",
                            KeyPoints = new List<string> 
                            { 
                                "Notebook best practices",
                                "Magic commands",
                                "Extension ecosystem",
                                "Version control",
                                "Collaboration tools"
                            }
                        },
                        new SubTopic
                        {
                            Id = 418,
                            StepId = 40,
                            Title = "Data Sampling Techniques",
                            Description = "Select representative data samples",
                            Content = "Learn various sampling methods",
                            KeyPoints = new List<string> 
                            { 
                                "Random sampling",
                                "Stratified sampling",
                                "Cluster sampling",
                                "Bootstrap methods",
                                "Sample size determination"
                            }
                        },
                        new SubTopic
                        {
                            Id = 419,
                            StepId = 40,
                            Title = "Data Quality Assessment",
                            Description = "Ensure data reliability",
                            Content = "Evaluate and improve data quality",
                            KeyPoints = new List<string> 
                            { 
                                "Completeness checks",
                                "Consistency validation",
                                "Accuracy assessment",
                                "Timeliness evaluation",
                                "Data profiling tools"
                            }
                        },
                        new SubTopic
                        {
                            Id = 420,
                            StepId = 40,
                            Title = "Business Understanding",
                            Description = "Align data science with business goals",
                            Content = "Connect technical work to business value",
                            KeyPoints = new List<string> 
                            { 
                                "Stakeholder communication",
                                "KPI definition",
                                "ROI estimation",
                                "Success metrics",
                                "Business context"
                            }
                        },
                        new SubTopic
                        {
                            Id = 421,
                            StepId = 40,
                            Title = "Data Science Tools",
                            Description = "Essential tools ecosystem",
                            Content = "Master key data science tools and platforms",
                            KeyPoints = new List<string> 
                            { 
                                "Anaconda environment",
                                "Git for data science",
                                "Cloud platforms",
                                "IDE selection",
                                "Collaboration tools"
                            }
                        },
                        new SubTopic
                        {
                            Id = 422,
                            StepId = 40,
                            Title = "Reproducible Research",
                            Description = "Ensure reproducible results",
                            Content = "Build reproducible data science workflows",
                            KeyPoints = new List<string> 
                            { 
                                "Environment management",
                                "Random seed control",
                                "Documentation practices",
                                "Code organization",
                                "Dependency tracking"
                            }
                        },
                        new SubTopic
                        {
                            Id = 423,
                            StepId = 40,
                            Title = "Data Science Math",
                            Description = "Mathematical foundations",
                            Content = "Essential mathematics for data science",
                            KeyPoints = new List<string> 
                            { 
                                "Linear algebra basics",
                                "Calculus essentials",
                                "Probability theory",
                                "Statistical inference",
                                "Optimization basics"
                            }
                        },
                        new SubTopic
                        {
                            Id = 424,
                            StepId = 40,
                            Title = "Data Storytelling",
                            Description = "Communicate insights effectively",
                            Content = "Present data findings compellingly",
                            KeyPoints = new List<string> 
                            { 
                                "Narrative structure",
                                "Visual hierarchy",
                                "Audience adaptation",
                                "Presentation skills",
                                "Report writing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 425,
                            StepId = 40,
                            Title = "Data Science Ethics",
                            Description = "Ethical considerations in data science",
                            Content = "Understanding responsible data science practices",
                            KeyPoints = new List<string> 
                            { 
                                "Privacy concerns",
                                "Bias awareness",
                                "Transparency",
                                "Data consent",
                                "Ethical frameworks"
                            }
                        }
                    });
                }

                // Add Machine Learning step
                dataScience.Steps.Add(new RoadmapStep
                {
                    Id = 41,
                    RoadmapId = 4,
                    Title = "Machine Learning Engineering",
                    Duration = "6-8 weeks",
                    Content = "Build and deploy machine learning models",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 411,
                            StepId = 41,
                            Title = "Deep Learning Basics",
                            Description = "Introduction to neural networks",
                            Content = "Learn deep learning fundamentals",
                            KeyPoints = new List<string> 
                            { 
                                "Neural network architecture",
                                "Backpropagation",
                                "TensorFlow/PyTorch",
                                "CNNs for computer vision",
                                "RNNs for sequences"
                            }
                        },
                        new SubTopic
                        {
                            Id = 412,
                            StepId = 41,
                            Title = "Model Deployment",
                            Description = "Deploy ML models to production",
                            Content = "Learn MLOps best practices",
                            KeyPoints = new List<string> 
                            { 
                                "Model serving",
                                "API deployment",
                                "Model versioning",
                                "A/B testing",
                                "Performance monitoring"
                            }
                        },
                        new SubTopic
                        {
                            Id = 413,
                            StepId = 41,
                            Title = "Advanced ML Algorithms",
                            Description = "Master complex machine learning techniques",
                            Content = "Explore advanced algorithms and ensemble methods",
                            KeyPoints = new List<string> 
                            { 
                                "Gradient boosting",
                                "Random forests",
                                "XGBoost/LightGBM",
                                "Ensemble methods",
                                "AutoML tools"
                            }
                        },
                        new SubTopic
                        {
                            Id = 414,
                            StepId = 41,
                            Title = "Natural Language Processing",
                            Description = "Process and analyze text data",
                            Content = "Learn NLP techniques for text analysis",
                            KeyPoints = new List<string> 
                            { 
                                "Text preprocessing",
                                "Word embeddings",
                                "Sentiment analysis",
                                "Named entity recognition",
                                "Transformer models"
                            }
                        },
                        new SubTopic
                        {
                            Id = 415,
                            StepId = 41,
                            Title = "Time Series Analysis",
                            Description = "Analyze and forecast temporal data",
                            Content = "Master time series analysis and forecasting",
                            KeyPoints = new List<string> 
                            { 
                                "ARIMA models",
                                "Seasonality detection",
                                "Prophet forecasting",
                                "LSTM for sequences",
                                "Anomaly detection"
                            }
                        },
                        new SubTopic
                        {
                            Id = 416,
                            StepId = 41,
                            Title = "Computer Vision",
                            Description = "Image processing and analysis",
                            Content = "Build computer vision applications",
                            KeyPoints = new List<string> 
                            { 
                                "Image preprocessing",
                                "Object detection",
                                "Image segmentation",
                                "Face recognition",
                                "Transfer learning"
                            }
                        },
                        new SubTopic
                        {
                            Id = 417,
                            StepId = 41,
                            Title = "Reinforcement Learning",
                            Description = "Train agents through interaction",
                            Content = "Implement RL algorithms",
                            KeyPoints = new List<string> 
                            { 
                                "Q-learning",
                                "Policy gradients",
                                "Deep Q-Networks",
                                "Environment design",
                                "Multi-agent systems"
                            }
                        },
                        new SubTopic
                        {
                            Id = 418,
                            StepId = 41,
                            Title = "Model Optimization",
                            Description = "Improve model performance",
                            Content = "Optimize ML models for production",
                            KeyPoints = new List<string> 
                            { 
                                "Hyperparameter tuning",
                                "Model compression",
                                "Quantization",
                                "Pruning techniques",
                                "Knowledge distillation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 419,
                            StepId = 41,
                            Title = "Feature Selection",
                            Description = "Identify important features",
                            Content = "Select optimal features for models",
                            KeyPoints = new List<string> 
                            { 
                                "Filter methods",
                                "Wrapper methods",
                                "Embedded methods",
                                "Recursive elimination",
                                "SHAP values"
                            }
                        },
                        new SubTopic
                        {
                            Id = 420,
                            StepId = 41,
                            Title = "Unsupervised Learning",
                            Description = "Find patterns without labels",
                            Content = "Master clustering and dimensionality reduction",
                            KeyPoints = new List<string> 
                            { 
                                "K-means clustering",
                                "Hierarchical clustering",
                                "DBSCAN",
                                "PCA/t-SNE",
                                "Anomaly detection"
                            }
                        },
                        new SubTopic
                        {
                            Id = 426,
                            StepId = 41,
                            Title = "MLOps Pipelines",
                            Description = "Automate ML workflows",
                            Content = "Build production ML pipelines",
                            KeyPoints = new List<string> 
                            { 
                                "Pipeline orchestration",
                                "Feature stores",
                                "Model registry",
                                "Continuous training",
                                "Monitoring systems"
                            }
                        },
                        new SubTopic
                        {
                            Id = 427,
                            StepId = 41,
                            Title = "A/B Testing for ML",
                            Description = "Experiment with models",
                            Content = "Test model improvements scientifically",
                            KeyPoints = new List<string> 
                            { 
                                "Experiment design",
                                "Statistical significance",
                                "Multi-armed bandits",
                                "Online learning",
                                "Result interpretation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 428,
                            StepId = 41,
                            Title = "Model Interpretability",
                            Description = "Explain model predictions",
                            Content = "Make ML models interpretable",
                            KeyPoints = new List<string> 
                            { 
                                "LIME explanations",
                                "SHAP analysis",
                                "Feature importance",
                                "Partial dependence",
                                "Model cards"
                            }
                        },
                        new SubTopic
                        {
                            Id = 429,
                            StepId = 41,
                            Title = "Transfer Learning",
                            Description = "Leverage pre-trained models",
                            Content = "Apply transfer learning techniques",
                            KeyPoints = new List<string> 
                            { 
                                "Pre-trained models",
                                "Fine-tuning strategies",
                                "Domain adaptation",
                                "Few-shot learning",
                                "Model zoo usage"
                            }
                        },
                        new SubTopic
                        {
                            Id = 430,
                            StepId = 41,
                            Title = "Distributed Training",
                            Description = "Train models at scale",
                            Content = "Implement distributed ML training",
                            KeyPoints = new List<string> 
                            { 
                                "Data parallelism",
                                "Model parallelism",
                                "Horovod framework",
                                "GPU clusters",
                                "Gradient aggregation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 431,
                            StepId = 41,
                            Title = "Edge ML Deployment",
                            Description = "Deploy models on edge devices",
                            Content = "Optimize models for edge computing",
                            KeyPoints = new List<string> 
                            { 
                                "TensorFlow Lite",
                                "ONNX conversion",
                                "Mobile deployment",
                                "IoT integration",
                                "Power optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 432,
                            StepId = 41,
                            Title = "Recommendation Systems",
                            Description = "Build personalization engines",
                            Content = "Create recommendation algorithms",
                            KeyPoints = new List<string> 
                            { 
                                "Collaborative filtering",
                                "Content-based filtering",
                                "Matrix factorization",
                                "Deep learning recommenders",
                                "Cold start solutions"
                            }
                        },
                        new SubTopic
                        {
                            Id = 433,
                            StepId = 41,
                            Title = "Generative Models",
                            Description = "Generate new data samples",
                            Content = "Build generative AI models",
                            KeyPoints = new List<string> 
                            { 
                                "GANs architecture",
                                "VAE models",
                                "Diffusion models",
                                "Text generation",
                                "Image synthesis"
                            }
                        },
                        new SubTopic
                        {
                            Id = 434,
                            StepId = 41,
                            Title = "Model Monitoring",
                            Description = "Track model performance",
                            Content = "Monitor models in production",
                            KeyPoints = new List<string> 
                            { 
                                "Drift detection",
                                "Performance metrics",
                                "Alert systems",
                                "Model retraining",
                                "Logging practices"
                            }
                        }
                    }
                });

                // Add Big Data step
                dataScience.Steps.Add(new RoadmapStep
                {
                    Id = 42,
                    RoadmapId = 4,
                    Title = "Big Data Technologies",
                    Duration = "4-5 weeks",
                    Content = "Process large-scale data with distributed computing",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 421,
                            StepId = 42,
                            Title = "Apache Spark",
                            Description = "Distributed data processing",
                            Content = "Master big data processing with Spark",
                            KeyPoints = new List<string> 
                            { 
                                "Spark architecture",
                                "RDDs and DataFrames",
                                "Spark SQL",
                                "Spark streaming",
                                "PySpark"
                            }
                        },
                        new SubTopic
                        {
                            Id = 422,
                            StepId = 42,
                            Title = "Cloud Data Platforms",
                            Description = "Use cloud services for data processing",
                            Content = "Learn cloud-based data solutions",
                            KeyPoints = new List<string> 
                            { 
                                "AWS data services",
                                "Azure data factory",
                                "Google Cloud Platform",
                                "Data lakes",
                                "Serverless analytics"
                            }
                        },
                        new SubTopic
                        {
                            Id = 423,
                            StepId = 42,
                            Title = "Real-time Data Processing",
                            Description = "Process streaming data in real-time",
                            Content = "Build real-time data processing pipelines",
                            KeyPoints = new List<string> 
                            { 
                                "Stream processing concepts",
                                "Apache Kafka",
                                "Real-time analytics",
                                "Event-driven architecture",
                                "Lambda architecture"
                            }
                        },
                        new SubTopic
                        {
                            Id = 424,
                            StepId = 42,
                            Title = "Data Engineering",
                            Description = "Build robust data pipelines",
                            Content = "Design and implement data infrastructure",
                            KeyPoints = new List<string> 
                            { 
                                "ETL/ELT processes",
                                "Data pipeline orchestration",
                                "Apache Airflow",
                                "Data quality monitoring",
                                "Schema evolution"
                            }
                        },
                        new SubTopic
                        {
                            Id = 425,
                            StepId = 42,
                            Title = "Hadoop Ecosystem",
                            Description = "Master Hadoop components",
                            Content = "Learn the Hadoop ecosystem for big data",
                            KeyPoints = new List<string> 
                            { 
                                "HDFS architecture",
                                "MapReduce programming",
                                "Hive queries",
                                "HBase NoSQL",
                                "Pig scripting"
                            }
                        },
                        new SubTopic
                        {
                            Id = 426,
                            StepId = 42,
                            Title = "Data Lake Architecture",
                            Description = "Design scalable data lakes",
                            Content = "Build modern data lake solutions",
                            KeyPoints = new List<string> 
                            { 
                                "Lake vs warehouse",
                                "Delta Lake",
                                "Data catalog",
                                "Governance frameworks",
                                "Access patterns"
                            }
                        },
                        new SubTopic
                        {
                            Id = 427,
                            StepId = 42,
                            Title = "Batch Processing",
                            Description = "Process data in batches",
                            Content = "Implement batch processing systems",
                            KeyPoints = new List<string> 
                            { 
                                "Batch scheduling",
                                "Job optimization",
                                "Resource allocation",
                                "Error handling",
                                "Checkpointing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 428,
                            StepId = 42,
                            Title = "Stream Analytics",
                            Description = "Real-time data analytics",
                            Content = "Analyze streaming data in real-time",
                            KeyPoints = new List<string> 
                            { 
                                "Window operations",
                                "Stateful processing",
                                "Complex event processing",
                                "Low-latency analytics",
                                "Stream joins"
                            }
                        },
                        new SubTopic
                        {
                            Id = 429,
                            StepId = 42,
                            Title = "NoSQL Databases",
                            Description = "Work with NoSQL systems",
                            Content = "Master different NoSQL database types",
                            KeyPoints = new List<string> 
                            { 
                                "Document stores",
                                "Key-value stores",
                                "Graph databases",
                                "Column families",
                                "Multi-model databases"
                            }
                        },
                        new SubTopic
                        {
                            Id = 430,
                            StepId = 42,
                            Title = "Data Governance",
                            Description = "Implement data governance",
                            Content = "Establish data governance practices",
                            KeyPoints = new List<string> 
                            { 
                                "Data lineage",
                                "Metadata management",
                                "Access controls",
                                "Compliance tracking",
                                "Data quality rules"
                            }
                        },
                        new SubTopic
                        {
                            Id = 435,
                            StepId = 42,
                            Title = "Distributed Storage",
                            Description = "Manage distributed data storage",
                            Content = "Implement scalable storage solutions",
                            KeyPoints = new List<string> 
                            { 
                                "Object storage",
                                "Block storage",
                                "File systems",
                                "Replication strategies",
                                "Data partitioning"
                            }
                        },
                        new SubTopic
                        {
                            Id = 436,
                            StepId = 42,
                            Title = "Data Mesh Architecture",
                            Description = "Decentralized data architecture",
                            Content = "Implement data mesh principles",
                            KeyPoints = new List<string> 
                            { 
                                "Domain ownership",
                                "Data products",
                                "Self-serve platform",
                                "Federated governance",
                                "Interoperability"
                            }
                        },
                        new SubTopic
                        {
                            Id = 437,
                            StepId = 42,
                            Title = "Big Data Security",
                            Description = "Secure big data systems",
                            Content = "Implement security in big data environments",
                            KeyPoints = new List<string> 
                            { 
                                "Kerberos authentication",
                                "Encryption at rest",
                                "Network security",
                                "Audit logging",
                                "Data masking"
                            }
                        },
                        new SubTopic
                        {
                            Id = 438,
                            StepId = 42,
                            Title = "Cloud Data Warehouses",
                            Description = "Modern cloud warehousing",
                            Content = "Use cloud-native data warehouses",
                            KeyPoints = new List<string> 
                            { 
                                "Snowflake architecture",
                                "BigQuery optimization",
                                "Redshift tuning",
                                "Synapse Analytics",
                                "Cost optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 439,
                            StepId = 42,
                            Title = "Data Integration",
                            Description = "Integrate diverse data sources",
                            Content = "Connect and combine data from multiple sources",
                            KeyPoints = new List<string> 
                            { 
                                "CDC techniques",
                                "API integration",
                                "File transfers",
                                "Real-time sync",
                                "Data federation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 440,
                            StepId = 42,
                            Title = "Data Orchestration",
                            Description = "Coordinate data workflows",
                            Content = "Orchestrate complex data pipelines",
                            KeyPoints = new List<string> 
                            { 
                                "DAG design",
                                "Dependency management",
                                "Error recovery",
                                "Monitoring dashboards",
                                "SLA management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 441,
                            StepId = 42,
                            Title = "Big Data Optimization",
                            Description = "Optimize big data performance",
                            Content = "Tune big data systems for efficiency",
                            KeyPoints = new List<string> 
                            { 
                                "Query optimization",
                                "Caching strategies",
                                "Compression techniques",
                                "Resource tuning",
                                "Cost efficiency"
                            }
                        },
                        new SubTopic
                        {
                            Id = 442,
                            StepId = 42,
                            Title = "Data Formats",
                            Description = "Work with big data formats",
                            Content = "Choose optimal data formats",
                            KeyPoints = new List<string> 
                            { 
                                "Parquet files",
                                "ORC format",
                                "Avro schemas",
                                "JSON processing",
                                "Protocol buffers"
                            }
                        },
                        new SubTopic
                        {
                            Id = 443,
                            StepId = 42,
                            Title = "Batch vs Stream Trade-offs",
                            Description = "Choose processing paradigms",
                            Content = "Understand when to use batch vs stream",
                            KeyPoints = new List<string> 
                            { 
                                "Latency requirements",
                                "Throughput needs",
                                "Complexity analysis",
                                "Cost considerations",
                                "Hybrid approaches"
                            }
                        }
                    }
                });

                // Add Data Ethics & Governance step
                dataScience.Steps.Add(new RoadmapStep
                {
                    Id = 43,
                    RoadmapId = 4,
                    Title = "Data Ethics & Governance",
                    Duration = "2-3 weeks",
                    Content = "Understand ethical considerations and governance in data science",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 431,
                            StepId = 43,
                            Title = "Data Privacy & Security",
                            Description = "Protect sensitive data",
                            Content = "Learn data privacy regulations and security practices",
                            KeyPoints = new List<string> 
                            { 
                                "GDPR compliance",
                                "Data anonymization",
                                "Differential privacy",
                                "Secure data handling",
                                "Access controls"
                            }
                        },
                        new SubTopic
                        {
                            Id = 432,
                            StepId = 43,
                            Title = "Responsible AI",
                            Description = "Build ethical AI systems",
                            Content = "Understand bias and fairness in machine learning",
                            KeyPoints = new List<string> 
                            { 
                                "Algorithmic bias",
                                "Fairness metrics",
                                "Explainable AI",
                                "Model transparency",
                                "Ethical guidelines"
                            }
                        },
                        new SubTopic
                        {
                            Id = 433,
                            StepId = 43,
                            Title = "Data Compliance",
                            Description = "Navigate data regulations",
                            Content = "Ensure compliance with data laws",
                            KeyPoints = new List<string> 
                            { 
                                "GDPR requirements",
                                "CCPA compliance",
                                "HIPAA for healthcare",
                                "Data retention policies",
                                "Cross-border transfers"
                            }
                        },
                        new SubTopic
                        {
                            Id = 434,
                            StepId = 43,
                            Title = "Privacy by Design",
                            Description = "Build privacy into systems",
                            Content = "Implement privacy-first architectures",
                            KeyPoints = new List<string> 
                            { 
                                "Privacy principles",
                                "Data minimization",
                                "Purpose limitation",
                                "User consent",
                                "Privacy impact assessments"
                            }
                        },
                        new SubTopic
                        {
                            Id = 435,
                            StepId = 43,
                            Title = "Data Ownership",
                            Description = "Understand data ownership rights",
                            Content = "Navigate complex data ownership issues",
                            KeyPoints = new List<string> 
                            { 
                                "Intellectual property",
                                "User rights",
                                "Data licensing",
                                "Third-party data",
                                "Data monetization ethics"
                            }
                        },
                        new SubTopic
                        {
                            Id = 436,
                            StepId = 43,
                            Title = "AI Governance",
                            Description = "Govern AI systems effectively",
                            Content = "Establish AI governance frameworks",
                            KeyPoints = new List<string> 
                            { 
                                "Governance structures",
                                "Risk assessment",
                                "Accountability measures",
                                "Audit trails",
                                "Decision documentation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 437,
                            StepId = 43,
                            Title = "Bias Detection",
                            Description = "Identify and measure bias",
                            Content = "Detect bias in data and models",
                            KeyPoints = new List<string> 
                            { 
                                "Bias types",
                                "Detection methods",
                                "Statistical tests",
                                "Bias metrics",
                                "Monitoring tools"
                            }
                        },
                        new SubTopic
                        {
                            Id = 438,
                            StepId = 43,
                            Title = "Fairness in ML",
                            Description = "Ensure fair ML outcomes",
                            Content = "Implement fairness in machine learning",
                            KeyPoints = new List<string> 
                            { 
                                "Fairness definitions",
                                "Group fairness",
                                "Individual fairness",
                                "Fairness constraints",
                                "Trade-offs"
                            }
                        },
                        new SubTopic
                        {
                            Id = 439,
                            StepId = 43,
                            Title = "Data Subject Rights",
                            Description = "Respect individual rights",
                            Content = "Implement data subject rights",
                            KeyPoints = new List<string> 
                            { 
                                "Right to access",
                                "Right to deletion",
                                "Data portability",
                                "Rectification rights",
                                "Opt-out mechanisms"
                            }
                        },
                        new SubTopic
                        {
                            Id = 440,
                            StepId = 43,
                            Title = "Ethical Decision Making",
                            Description = "Make ethical data decisions",
                            Content = "Framework for ethical decision making",
                            KeyPoints = new List<string> 
                            { 
                                "Ethical frameworks",
                                "Stakeholder analysis",
                                "Impact assessment",
                                "Decision trees",
                                "Documentation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 444,
                            StepId = 43,
                            Title = "Data Breach Response",
                            Description = "Handle data breaches",
                            Content = "Respond effectively to data incidents",
                            KeyPoints = new List<string> 
                            { 
                                "Incident response plans",
                                "Breach notification",
                                "Forensics basics",
                                "Communication strategies",
                                "Remediation steps"
                            }
                        },
                        new SubTopic
                        {
                            Id = 445,
                            StepId = 43,
                            Title = "Synthetic Data",
                            Description = "Generate privacy-safe data",
                            Content = "Create and use synthetic datasets",
                            KeyPoints = new List<string> 
                            { 
                                "Generation techniques",
                                "Privacy guarantees",
                                "Utility preservation",
                                "Validation methods",
                                "Use cases"
                            }
                        },
                        new SubTopic
                        {
                            Id = 446,
                            StepId = 43,
                            Title = "Consent Management",
                            Description = "Manage user consent",
                            Content = "Implement consent management systems",
                            KeyPoints = new List<string> 
                            { 
                                "Consent collection",
                                "Preference centers",
                                "Granular consent",
                                "Consent tracking",
                                "Withdrawal processes"
                            }
                        },
                        new SubTopic
                        {
                            Id = 447,
                            StepId = 43,
                            Title = "Data Minimization",
                            Description = "Collect only necessary data",
                            Content = "Implement data minimization practices",
                            KeyPoints = new List<string> 
                            { 
                                "Necessity assessment",
                                "Collection policies",
                                "Storage limits",
                                "Retention schedules",
                                "Deletion practices"
                            }
                        },
                        new SubTopic
                        {
                            Id = 448,
                            StepId = 43,
                            Title = "Transparency Reports",
                            Description = "Communicate data practices",
                            Content = "Create transparency in data use",
                            KeyPoints = new List<string> 
                            { 
                                "Report structure",
                                "Key metrics",
                                "Data requests",
                                "Usage statistics",
                                "Public communication"
                            }
                        },
                        new SubTopic
                        {
                            Id = 449,
                            StepId = 43,
                            Title = "Ethical Review Boards",
                            Description = "Establish review processes",
                            Content = "Create ethical oversight mechanisms",
                            KeyPoints = new List<string> 
                            { 
                                "Board composition",
                                "Review criteria",
                                "Decision processes",
                                "Appeals mechanisms",
                                "Continuous monitoring"
                            }
                        },
                        new SubTopic
                        {
                            Id = 450,
                            StepId = 43,
                            Title = "Cross-Cultural Ethics",
                            Description = "Navigate global ethical differences",
                            Content = "Handle ethics across cultures",
                            KeyPoints = new List<string> 
                            { 
                                "Cultural sensitivity",
                                "Local regulations",
                                "Global standards",
                                "Ethical relativism",
                                "Universal principles"
                            }
                        },
                        new SubTopic
                        {
                            Id = 451,
                            StepId = 43,
                            Title = "AI Safety",
                            Description = "Ensure AI system safety",
                            Content = "Build safe and reliable AI systems",
                            KeyPoints = new List<string> 
                            { 
                                "Safety testing",
                                "Failure modes",
                                "Robustness checks",
                                "Human oversight",
                                "Kill switches"
                            }
                        },
                        new SubTopic
                        {
                            Id = 452,
                            StepId = 43,
                            Title = "Data Ethics Training",
                            Description = "Educate teams on ethics",
                            Content = "Build ethical awareness in organizations",
                            KeyPoints = new List<string> 
                            { 
                                "Training programs",
                                "Case studies",
                                "Role playing",
                                "Certification",
                                "Continuous education"
                            }
                        }
                    }
                });

                // Add Advanced Analytics step
                dataScience.Steps.Add(new RoadmapStep
                {
                    Id = 44,
                    RoadmapId = 4,
                    Title = "Advanced Analytics & Research",
                    Duration = "4-6 weeks",
                    Content = "Apply advanced analytical techniques to complex problems",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 441,
                            StepId = 44,
                            Title = "Causal Inference",
                            Description = "Determine cause and effect relationships",
                            Content = "Learn methods for causal analysis",
                            KeyPoints = new List<string> 
                            { 
                                "A/B testing",
                                "Randomized experiments",
                                "Propensity score matching",
                                "Instrumental variables",
                                "Difference-in-differences"
                            }
                        },
                        new SubTopic
                        {
                            Id = 442,
                            StepId = 44,
                            Title = "Advanced Visualization",
                            Description = "Create sophisticated data presentations",
                            Content = "Master advanced visualization techniques",
                            KeyPoints = new List<string> 
                            { 
                                "D3.js for custom visuals",
                                "Geospatial visualization",
                                "Network visualization",
                                "Real-time dashboards",
                                "Business intelligence tools"
                            }
                        },
                        new SubTopic
                        {
                            Id = 443,
                            StepId = 44,
                            Title = "Optimization & Operations Research",
                            Description = "Solve complex optimization problems",
                            Content = "Apply OR techniques to business problems",
                            KeyPoints = new List<string> 
                            { 
                                "Linear programming",
                                "Constraint optimization",
                                "Simulation modeling",
                                "Resource allocation",
                                "Supply chain optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 444,
                            StepId = 44,
                            Title = "Bayesian Analysis",
                            Description = "Apply Bayesian methods",
                            Content = "Use Bayesian statistics for inference",
                            KeyPoints = new List<string> 
                            { 
                                "Bayes theorem",
                                "Prior distributions",
                                "MCMC methods",
                                "Bayesian networks",
                                "Probabilistic programming"
                            }
                        },
                        new SubTopic
                        {
                            Id = 445,
                            StepId = 44,
                            Title = "Survival Analysis",
                            Description = "Analyze time-to-event data",
                            Content = "Model duration until events occur",
                            KeyPoints = new List<string> 
                            { 
                                "Kaplan-Meier curves",
                                "Cox regression",
                                "Hazard functions",
                                "Censored data",
                                "Competing risks"
                            }
                        },
                        new SubTopic
                        {
                            Id = 446,
                            StepId = 44,
                            Title = "Network Analysis",
                            Description = "Analyze complex networks",
                            Content = "Study relationships and connections",
                            KeyPoints = new List<string> 
                            { 
                                "Graph theory",
                                "Centrality measures",
                                "Community detection",
                                "Link prediction",
                                "Social network analysis"
                            }
                        },
                        new SubTopic
                        {
                            Id = 447,
                            StepId = 44,
                            Title = "Spatial Analytics",
                            Description = "Analyze geographic data",
                            Content = "Work with location-based data",
                            KeyPoints = new List<string> 
                            { 
                                "GIS fundamentals",
                                "Spatial statistics",
                                "Clustering analysis",
                                "Heat maps",
                                "Route optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 448,
                            StepId = 44,
                            Title = "Text Mining",
                            Description = "Extract insights from text",
                            Content = "Analyze unstructured text data",
                            KeyPoints = new List<string> 
                            { 
                                "Topic modeling",
                                "Sentiment analysis",
                                "Entity extraction",
                                "Document clustering",
                                "Text summarization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 449,
                            StepId = 44,
                            Title = "Advanced Statistics",
                            Description = "Master complex statistical methods",
                            Content = "Apply advanced statistical techniques",
                            KeyPoints = new List<string> 
                            { 
                                "Multivariate analysis",
                                "Time series models",
                                "Mixed effects models",
                                "Bootstrap methods",
                                "Robust statistics"
                            }
                        },
                        new SubTopic
                        {
                            Id = 450,
                            StepId = 44,
                            Title = "Research Design",
                            Description = "Design effective studies",
                            Content = "Plan and execute research projects",
                            KeyPoints = new List<string> 
                            { 
                                "Experimental design",
                                "Sample size calculation",
                                "Control variables",
                                "Replication studies",
                                "Meta-analysis"
                            }
                        },
                        new SubTopic
                        {
                            Id = 451,
                            StepId = 44,
                            Title = "Predictive Modeling",
                            Description = "Build advanced predictive models",
                            Content = "Create sophisticated prediction systems",
                            KeyPoints = new List<string> 
                            { 
                                "Ensemble stacking",
                                "Feature engineering",
                                "Model calibration",
                                "Uncertainty quantification",
                                "Prediction intervals"
                            }
                        },
                        new SubTopic
                        {
                            Id = 452,
                            StepId = 44,
                            Title = "Anomaly Detection",
                            Description = "Identify unusual patterns",
                            Content = "Detect outliers and anomalies",
                            KeyPoints = new List<string> 
                            { 
                                "Statistical methods",
                                "Isolation forests",
                                "Autoencoders",
                                "One-class SVM",
                                "Contextual anomalies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 453,
                            StepId = 44,
                            Title = "Simulation Modeling",
                            Description = "Build simulation models",
                            Content = "Create models to simulate complex systems",
                            KeyPoints = new List<string> 
                            { 
                                "Monte Carlo methods",
                                "Discrete event simulation",
                                "Agent-based models",
                                "System dynamics",
                                "Validation techniques"
                            }
                        },
                        new SubTopic
                        {
                            Id = 454,
                            StepId = 44,
                            Title = "Prescriptive Analytics",
                            Description = "Recommend optimal actions",
                            Content = "Move from prediction to prescription",
                            KeyPoints = new List<string> 
                            { 
                                "Decision optimization",
                                "Scenario analysis",
                                "What-if modeling",
                                "Recommendation engines",
                                "Action optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 455,
                            StepId = 44,
                            Title = "Advanced Forecasting",
                            Description = "Master forecasting techniques",
                            Content = "Build sophisticated forecasting models",
                            KeyPoints = new List<string> 
                            { 
                                "Hierarchical forecasting",
                                "Forecast combination",
                                "Uncertainty estimation",
                                "Forecast reconciliation",
                                "Judgmental adjustments"
                            }
                        },
                        new SubTopic
                        {
                            Id = 456,
                            StepId = 44,
                            Title = "Data Fusion",
                            Description = "Combine multiple data sources",
                            Content = "Integrate diverse data for insights",
                            KeyPoints = new List<string> 
                            { 
                                "Sensor fusion",
                                "Multi-modal data",
                                "Conflicting sources",
                                "Weight optimization",
                                "Quality assessment"
                            }
                        },
                        new SubTopic
                        {
                            Id = 457,
                            StepId = 44,
                            Title = "Research Communication",
                            Description = "Present research effectively",
                            Content = "Communicate complex findings clearly",
                            KeyPoints = new List<string> 
                            { 
                                "Academic writing",
                                "Peer review process",
                                "Conference presentations",
                                "Executive summaries",
                                "Visual abstracts"
                            }
                        },
                        new SubTopic
                        {
                            Id = 458,
                            StepId = 44,
                            Title = "Advanced A/B Testing",
                            Description = "Design complex experiments",
                            Content = "Run sophisticated A/B tests",
                            KeyPoints = new List<string> 
                            { 
                                "Multi-variate testing",
                                "Sequential testing",
                                "Bayesian A/B tests",
                                "Network effects",
                                "Long-term impacts"
                            }
                        },
                        new SubTopic
                        {
                            Id = 459,
                            StepId = 44,
                            Title = "Decision Science",
                            Description = "Support complex decisions",
                            Content = "Apply decision science frameworks",
                            KeyPoints = new List<string> 
                            { 
                                "Decision trees",
                                "Multi-criteria analysis",
                                "Risk assessment",
                                "Utility theory",
                                "Behavioral factors"
                            }
                        }
                    }
                });
            }
        }

        private void AddDevOpsSubTopics(List<Roadmap> roadmaps)
        {
            // DevOps Engineer
            var devops = roadmaps.FirstOrDefault(r => r.Id == 5);
            if (devops != null)
            {
                var devopsBasics = devops.Steps.FirstOrDefault(s => s.Id == 50);
                if (devopsBasics != null)
                {
                    devopsBasics.SubTopics.AddRange(new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 502,
                            StepId = 50,
                            Title = "CI/CD Pipelines",
                            Description = "Automate your deployment process",
                            Content = "Build continuous integration and deployment pipelines",
                            KeyPoints = new List<string> 
                            { 
                                "Git workflows",
                                "Azure DevOps",
                                "GitHub Actions",
                                "Pipeline as code"
                            }
                        },
                        new SubTopic
                        {
                            Id = 503,
                            StepId = 50,
                            Title = "Containerization",
                            Description = "Package applications in containers",
                            Content = "Learn Docker and container orchestration",
                            KeyPoints = new List<string> 
                            { 
                                "Docker basics",
                                "Dockerfile best practices",
                                "Docker Compose",
                                "Kubernetes introduction"
                            }
                        },
                        new SubTopic
                        {
                            Id = 504,
                            StepId = 50,
                            Title = "Infrastructure Monitoring",
                            Description = "Monitor and troubleshoot infrastructure",
                            Content = "Implement comprehensive monitoring and observability",
                            KeyPoints = new List<string> 
                            { 
                                "Metrics collection",
                                "Log aggregation",
                                "Distributed tracing",
                                "Alert management",
                                "Dashboard creation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 505,
                            StepId = 50,
                            Title = "Security in DevOps",
                            Description = "Implement DevSecOps practices",
                            Content = "Integrate security throughout the DevOps pipeline",
                            KeyPoints = new List<string> 
                            { 
                                "Security scanning",
                                "Secret management",
                                "Compliance automation",
                                "Vulnerability assessment",
                                "Security as code"
                            }
                        },
                        new SubTopic
                        {
                            Id = 506,
                            StepId = 50,
                            Title = "Version Control Mastery",
                            Description = "Advanced Git techniques for DevOps",
                            Content = "Master version control for team collaboration",
                            KeyPoints = new List<string> 
                            { 
                                "Git branching strategies",
                                "Pull request workflows",
                                "Git hooks and automation",
                                "Monorepo vs polyrepo",
                                "Semantic versioning"
                            }
                        },
                        new SubTopic
                        {
                            Id = 507,
                            StepId = 50,
                            Title = "Infrastructure as Code",
                            Description = "Define infrastructure through code",
                            Content = "Learn IaC principles and tools",
                            KeyPoints = new List<string> 
                            { 
                                "IaC benefits and patterns",
                                "Terraform fundamentals",
                                "Configuration management",
                                "Immutable infrastructure",
                                "GitOps principles"
                            }
                        },
                        new SubTopic
                        {
                            Id = 508,
                            StepId = 50,
                            Title = "DevOps Culture",
                            Description = "Build collaborative DevOps culture",
                            Content = "Foster DevOps mindset and practices",
                            KeyPoints = new List<string> 
                            { 
                                "Breaking down silos",
                                "Shared responsibility",
                                "Continuous learning",
                                "Blameless postmortems",
                                "Team collaboration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 509,
                            StepId = 50,
                            Title = "Build Automation",
                            Description = "Automate build processes",
                            Content = "Implement automated build systems",
                            KeyPoints = new List<string> 
                            { 
                                "Build tools",
                                "Dependency management",
                                "Artifact management",
                                "Build optimization",
                                "Build reproducibility"
                            }
                        },
                        new SubTopic
                        {
                            Id = 510,
                            StepId = 50,
                            Title = "Testing Automation",
                            Description = "Automate testing processes",
                            Content = "Implement comprehensive test automation",
                            KeyPoints = new List<string> 
                            { 
                                "Unit testing",
                                "Integration testing",
                                "E2E testing",
                                "Performance testing",
                                "Security testing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 515,
                            StepId = 50,
                            Title = "Release Management",
                            Description = "Manage software releases",
                            Content = "Implement effective release strategies",
                            KeyPoints = new List<string> 
                            { 
                                "Release planning",
                                "Feature flags",
                                "Canary releases",
                                "Blue-green deployments",
                                "Rollback strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 516,
                            StepId = 50,
                            Title = "Configuration Management",
                            Description = "Manage system configurations",
                            Content = "Implement configuration management practices",
                            KeyPoints = new List<string> 
                            { 
                                "Configuration drift",
                                "Environment consistency",
                                "Secret management",
                                "Configuration validation",
                                "Automated provisioning"
                            }
                        },
                        new SubTopic
                        {
                            Id = 517,
                            StepId = 50,
                            Title = "DevOps Metrics",
                            Description = "Measure DevOps performance",
                            Content = "Track key DevOps metrics and KPIs",
                            KeyPoints = new List<string> 
                            { 
                                "DORA metrics",
                                "Deployment frequency",
                                "Lead time",
                                "MTTR",
                                "Change failure rate"
                            }
                        },
                        new SubTopic
                        {
                            Id = 518,
                            StepId = 50,
                            Title = "Incident Management",
                            Description = "Handle production incidents",
                            Content = "Implement incident response procedures",
                            KeyPoints = new List<string> 
                            { 
                                "Incident response",
                                "On-call rotation",
                                "Escalation procedures",
                                "Post-incident reviews",
                                "Documentation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 519,
                            StepId = 50,
                            Title = "DevOps Tools Ecosystem",
                            Description = "Navigate DevOps tooling landscape",
                            Content = "Choose and integrate DevOps tools",
                            KeyPoints = new List<string> 
                            { 
                                "Tool selection criteria",
                                "Tool integration",
                                "Open source vs commercial",
                                "Tool chain design",
                                "Vendor lock-in"
                            }
                        },
                        new SubTopic
                        {
                            Id = 520,
                            StepId = 50,
                            Title = "Compliance Automation",
                            Description = "Automate compliance checks",
                            Content = "Implement compliance as code",
                            KeyPoints = new List<string> 
                            { 
                                "Policy as code",
                                "Audit automation",
                                "Compliance scanning",
                                "Evidence collection",
                                "Regulatory requirements"
                            }
                        },
                        new SubTopic
                        {
                            Id = 521,
                            StepId = 50,
                            Title = "Database DevOps",
                            Description = "Apply DevOps to databases",
                            Content = "Implement database lifecycle management",
                            KeyPoints = new List<string> 
                            { 
                                "Database versioning",
                                "Schema migrations",
                                "Data masking",
                                "Backup automation",
                                "Performance monitoring"
                            }
                        },
                        new SubTopic
                        {
                            Id = 522,
                            StepId = 50,
                            Title = "Cost Optimization",
                            Description = "Optimize infrastructure costs",
                            Content = "Implement cost-effective DevOps practices",
                            KeyPoints = new List<string> 
                            { 
                                "Resource optimization",
                                "Cost monitoring",
                                "Right-sizing",
                                "Reserved instances",
                                "Waste elimination"
                            }
                        },
                        new SubTopic
                        {
                            Id = 523,
                            StepId = 50,
                            Title = "DevOps for Microservices",
                            Description = "DevOps in microservices architecture",
                            Content = "Apply DevOps to distributed systems",
                            KeyPoints = new List<string> 
                            { 
                                "Service deployment",
                                "Service discovery",
                                "Distributed tracing",
                                "Service mesh",
                                "Multi-service pipelines"
                            }
                        },
                        new SubTopic
                        {
                            Id = 524,
                            StepId = 50,
                            Title = "Platform Engineering",
                            Description = "Build internal developer platforms",
                            Content = "Create self-service platforms for developers",
                            KeyPoints = new List<string> 
                            { 
                                "Platform design",
                                "Developer experience",
                                "Self-service portals",
                                "Golden paths",
                                "Platform adoption"
                            }
                        }
                    });
                }

                // Add Cloud Infrastructure step
                devops.Steps.Add(new RoadmapStep
                {
                    Id = 51,
                    RoadmapId = 5,
                    Title = "Cloud Infrastructure Management",
                    Duration = "4-5 weeks",
                    Content = "Master cloud infrastructure and automation",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 511,
                            StepId = 51,
                            Title = "AWS Fundamentals",
                            Description = "Master Amazon Web Services",
                            Content = "Learn core AWS services for DevOps",
                            KeyPoints = new List<string> 
                            { 
                                "EC2 and VPC",
                                "S3 and storage",
                                "Lambda functions",
                                "CloudFormation",
                                "AWS CLI and SDK"
                            }
                        },
                        new SubTopic
                        {
                            Id = 512,
                            StepId = 51,
                            Title = "Azure DevOps Services",
                            Description = "Use Azure for DevOps workflows",
                            Content = "Implement DevOps practices with Azure",
                            KeyPoints = new List<string> 
                            { 
                                "Azure Pipelines",
                                "Azure Repos",
                                "Azure Artifacts",
                                "Azure Monitor",
                                "ARM templates"
                            }
                        },
                        new SubTopic
                        {
                            Id = 513,
                            StepId = 51,
                            Title = "Multi-Cloud Strategies",
                            Description = "Work across multiple cloud providers",
                            Content = "Implement cloud-agnostic solutions",
                            KeyPoints = new List<string> 
                            { 
                                "Cloud provider comparison",
                                "Multi-cloud architecture",
                                "Cloud cost optimization",
                                "Hybrid cloud patterns",
                                "Cloud migration strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 514,
                            StepId = 51,
                            Title = "Serverless Architecture",
                            Description = "Build serverless applications",
                            Content = "Leverage serverless computing for scalability",
                            KeyPoints = new List<string> 
                            { 
                                "Function as a Service",
                                "Event-driven architecture",
                                "API Gateway patterns",
                                "Serverless frameworks",
                                "Cold start optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 515,
                            StepId = 51,
                            Title = "Google Cloud Platform",
                            Description = "Master GCP for DevOps",
                            Content = "Use Google Cloud services effectively",
                            KeyPoints = new List<string> 
                            { 
                                "Compute Engine",
                                "Cloud Run",
                                "GKE",
                                "Cloud Build",
                                "Deployment Manager"
                            }
                        },
                        new SubTopic
                        {
                            Id = 516,
                            StepId = 51,
                            Title = "Cloud Networking",
                            Description = "Design cloud network architectures",
                            Content = "Implement secure cloud networking",
                            KeyPoints = new List<string> 
                            { 
                                "Virtual networks",
                                "Load balancing",
                                "CDN integration",
                                "VPN connections",
                                "Network security"
                            }
                        },
                        new SubTopic
                        {
                            Id = 517,
                            StepId = 51,
                            Title = "Cloud Storage Solutions",
                            Description = "Manage cloud storage effectively",
                            Content = "Choose and implement storage solutions",
                            KeyPoints = new List<string> 
                            { 
                                "Object storage",
                                "Block storage",
                                "File storage",
                                "Database options",
                                "Backup strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 518,
                            StepId = 51,
                            Title = "Cloud Security",
                            Description = "Secure cloud infrastructure",
                            Content = "Implement cloud security best practices",
                            KeyPoints = new List<string> 
                            { 
                                "IAM policies",
                                "Encryption strategies",
                                "Network security",
                                "Compliance tools",
                                "Security monitoring"
                            }
                        },
                        new SubTopic
                        {
                            Id = 519,
                            StepId = 51,
                            Title = "Infrastructure Automation",
                            Description = "Automate cloud infrastructure",
                            Content = "Use automation tools for cloud management",
                            KeyPoints = new List<string> 
                            { 
                                "Terraform advanced",
                                "CloudFormation",
                                "Pulumi",
                                "Crossplane",
                                "CDK patterns"
                            }
                        },
                        new SubTopic
                        {
                            Id = 520,
                            StepId = 51,
                            Title = "Cloud Cost Management",
                            Description = "Optimize cloud spending",
                            Content = "Implement cost optimization strategies",
                            KeyPoints = new List<string> 
                            { 
                                "Cost analysis",
                                "Budget alerts",
                                "Resource tagging",
                                "Spot instances",
                                "FinOps practices"
                            }
                        },
                        new SubTopic
                        {
                            Id = 525,
                            StepId = 51,
                            Title = "Hybrid Cloud",
                            Description = "Integrate on-premise and cloud",
                            Content = "Build hybrid cloud architectures",
                            KeyPoints = new List<string> 
                            { 
                                "Hybrid connectivity",
                                "Data synchronization",
                                "Identity federation",
                                "Workload migration",
                                "Hybrid management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 526,
                            StepId = 51,
                            Title = "Cloud Disaster Recovery",
                            Description = "Implement DR in the cloud",
                            Content = "Build resilient disaster recovery solutions",
                            KeyPoints = new List<string> 
                            { 
                                "Backup strategies",
                                "RTO/RPO planning",
                                "Failover testing",
                                "Cross-region replication",
                                "Recovery automation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 527,
                            StepId = 51,
                            Title = "Cloud Compliance",
                            Description = "Ensure cloud compliance",
                            Content = "Meet regulatory requirements in cloud",
                            KeyPoints = new List<string> 
                            { 
                                "Compliance frameworks",
                                "Audit trails",
                                "Data residency",
                                "Compliance automation",
                                "Certification management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 528,
                            StepId = 51,
                            Title = "Cloud Migration",
                            Description = "Migrate workloads to cloud",
                            Content = "Plan and execute cloud migrations",
                            KeyPoints = new List<string> 
                            { 
                                "6 R's of migration",
                                "Assessment tools",
                                "Migration planning",
                                "Data migration",
                                "Application modernization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 529,
                            StepId = 51,
                            Title = "Edge Computing",
                            Description = "Deploy at the edge",
                            Content = "Implement edge computing solutions",
                            KeyPoints = new List<string> 
                            { 
                                "Edge locations",
                                "CDN integration",
                                "IoT edge",
                                "Low latency apps",
                                "Edge security"
                            }
                        },
                        new SubTopic
                        {
                            Id = 530,
                            StepId = 51,
                            Title = "Cloud Native Applications",
                            Description = "Build cloud-native apps",
                            Content = "Design applications for the cloud",
                            KeyPoints = new List<string> 
                            { 
                                "12-factor apps",
                                "Microservices patterns",
                                "Container-first design",
                                "Stateless architecture",
                                "Cloud-native storage"
                            }
                        },
                        new SubTopic
                        {
                            Id = 531,
                            StepId = 51,
                            Title = "Cloud Orchestration",
                            Description = "Orchestrate cloud resources",
                            Content = "Manage complex cloud deployments",
                            KeyPoints = new List<string> 
                            { 
                                "Resource orchestration",
                                "Workflow automation",
                                "Service catalogs",
                                "Self-service portals",
                                "Orchestration tools"
                            }
                        },
                        new SubTopic
                        {
                            Id = 532,
                            StepId = 51,
                            Title = "Cloud Performance",
                            Description = "Optimize cloud performance",
                            Content = "Ensure optimal cloud application performance",
                            KeyPoints = new List<string> 
                            { 
                                "Performance monitoring",
                                "Auto-scaling",
                                "Caching strategies",
                                "Database optimization",
                                "CDN optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 533,
                            StepId = 51,
                            Title = "Cloud Governance",
                            Description = "Implement cloud governance",
                            Content = "Establish cloud governance frameworks",
                            KeyPoints = new List<string> 
                            { 
                                "Policy management",
                                "Resource controls",
                                "Access governance",
                                "Cost governance",
                                "Risk management"
                            }
                        }
                    }
                });

                // Add Kubernetes step
                devops.Steps.Add(new RoadmapStep
                {
                    Id = 52,
                    RoadmapId = 5,
                    Title = "Kubernetes Orchestration",
                    Duration = "5-6 weeks",
                    Content = "Master container orchestration with Kubernetes",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 521,
                            StepId = 52,
                            Title = "Kubernetes Core Concepts",
                            Description = "Understand Kubernetes architecture",
                            Content = "Learn Kubernetes fundamentals",
                            KeyPoints = new List<string> 
                            { 
                                "Pods and deployments",
                                "Services and ingress",
                                "ConfigMaps and secrets",
                                "Persistent volumes",
                                "Namespaces"
                            }
                        },
                        new SubTopic
                        {
                            Id = 522,
                            StepId = 52,
                            Title = "Kubernetes Operations",
                            Description = "Operate production Kubernetes clusters",
                            Content = "Master Kubernetes administration",
                            KeyPoints = new List<string> 
                            { 
                                "Cluster management",
                                "Helm charts",
                                "GitOps workflows",
                                "Service mesh (Istio)",
                                "Monitoring with Prometheus"
                            }
                        },
                        new SubTopic
                        {
                            Id = 523,
                            StepId = 52,
                            Title = "Container Security",
                            Description = "Secure containerized applications",
                            Content = "Implement security best practices for containers",
                            KeyPoints = new List<string> 
                            { 
                                "Image scanning",
                                "Runtime security",
                                "Network policies",
                                "RBAC configuration",
                                "Pod security policies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 524,
                            StepId = 52,
                            Title = "Advanced Kubernetes",
                            Description = "Master advanced Kubernetes features",
                            Content = "Implement complex Kubernetes patterns",
                            KeyPoints = new List<string> 
                            { 
                                "Custom Resource Definitions",
                                "Operators and controllers",
                                "Multi-tenancy",
                                "Autoscaling strategies",
                                "Disaster recovery"
                            }
                        },
                        new SubTopic
                        {
                            Id = 525,
                            StepId = 52,
                            Title = "Kubernetes Networking",
                            Description = "Master K8s networking concepts",
                            Content = "Implement advanced networking in Kubernetes",
                            KeyPoints = new List<string> 
                            { 
                                "CNI plugins",
                                "Service mesh integration",
                                "Network policies",
                                "Load balancer config",
                                "DNS configuration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 526,
                            StepId = 52,
                            Title = "Kubernetes Storage",
                            Description = "Manage persistent storage",
                            Content = "Implement storage solutions in K8s",
                            KeyPoints = new List<string> 
                            { 
                                "Storage classes",
                                "Dynamic provisioning",
                                "StatefulSets",
                                "Volume snapshots",
                                "CSI drivers"
                            }
                        },
                        new SubTopic
                        {
                            Id = 527,
                            StepId = 52,
                            Title = "Kubernetes Monitoring",
                            Description = "Monitor K8s clusters effectively",
                            Content = "Implement comprehensive monitoring",
                            KeyPoints = new List<string> 
                            { 
                                "Prometheus setup",
                                "Grafana dashboards",
                                "Metrics collection",
                                "Log aggregation",
                                "Alert rules"
                            }
                        },
                        new SubTopic
                        {
                            Id = 528,
                            StepId = 52,
                            Title = "Kubernetes CI/CD",
                            Description = "Deploy to K8s with CI/CD",
                            Content = "Integrate Kubernetes with CI/CD pipelines",
                            KeyPoints = new List<string> 
                            { 
                                "GitOps workflows",
                                "ArgoCD setup",
                                "Flux integration",
                                "Progressive delivery",
                                "Rollback automation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 529,
                            StepId = 52,
                            Title = "Kubernetes Troubleshooting",
                            Description = "Debug K8s issues effectively",
                            Content = "Master troubleshooting techniques",
                            KeyPoints = new List<string> 
                            { 
                                "Pod debugging",
                                "Network troubleshooting",
                                "Performance issues",
                                "Resource conflicts",
                                "Log analysis"
                            }
                        },
                        new SubTopic
                        {
                            Id = 530,
                            StepId = 52,
                            Title = "Kubernetes Backup",
                            Description = "Backup and restore K8s",
                            Content = "Implement backup strategies",
                            KeyPoints = new List<string> 
                            { 
                                "etcd backup",
                                "Velero setup",
                                "Application backup",
                                "Disaster recovery",
                                "Cross-cluster restore"
                            }
                        },
                        new SubTopic
                        {
                            Id = 534,
                            StepId = 52,
                            Title = "Kubernetes Federation",
                            Description = "Manage multi-cluster deployments",
                            Content = "Implement federation for multiple clusters",
                            KeyPoints = new List<string> 
                            { 
                                "Multi-cluster setup",
                                "Federation v2",
                                "Cross-cluster networking",
                                "Global load balancing",
                                "Cluster management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 535,
                            StepId = 52,
                            Title = "Kubernetes Cost Optimization",
                            Description = "Optimize K8s costs",
                            Content = "Reduce Kubernetes infrastructure costs",
                            KeyPoints = new List<string> 
                            { 
                                "Resource requests/limits",
                                "Node optimization",
                                "Spot instances",
                                "Autoscaling policies",
                                "Cost monitoring"
                            }
                        },
                        new SubTopic
                        {
                            Id = 536,
                            StepId = 52,
                            Title = "Kubernetes API",
                            Description = "Work with K8s API",
                            Content = "Interact with Kubernetes programmatically",
                            KeyPoints = new List<string> 
                            { 
                                "API resources",
                                "Client libraries",
                                "Webhook development",
                                "API extensions",
                                "Authentication"
                            }
                        },
                        new SubTopic
                        {
                            Id = 537,
                            StepId = 52,
                            Title = "Kubernetes Patterns",
                            Description = "Implement K8s design patterns",
                            Content = "Apply proven Kubernetes patterns",
                            KeyPoints = new List<string> 
                            { 
                                "Sidecar pattern",
                                "Ambassador pattern",
                                "Adapter pattern",
                                "Init containers",
                                "Leader election"
                            }
                        },
                        new SubTopic
                        {
                            Id = 538,
                            StepId = 52,
                            Title = "Kubernetes Development",
                            Description = "Develop on Kubernetes",
                            Content = "Set up development environments",
                            KeyPoints = new List<string> 
                            { 
                                "Local K8s setup",
                                "Skaffold",
                                "Telepresence",
                                "Dev containers",
                                "Hot reloading"
                            }
                        },
                        new SubTopic
                        {
                            Id = 539,
                            StepId = 52,
                            Title = "Kubernetes Compliance",
                            Description = "Ensure K8s compliance",
                            Content = "Implement compliance in Kubernetes",
                            KeyPoints = new List<string> 
                            { 
                                "CIS benchmarks",
                                "Pod security standards",
                                "OPA policies",
                                "Audit logging",
                                "Compliance scanning"
                            }
                        },
                        new SubTopic
                        {
                            Id = 540,
                            StepId = 52,
                            Title = "Kubernetes Performance",
                            Description = "Optimize K8s performance",
                            Content = "Tune Kubernetes for performance",
                            KeyPoints = new List<string> 
                            { 
                                "Scheduler tuning",
                                "Node performance",
                                "etcd optimization",
                                "API server tuning",
                                "Network performance"
                            }
                        },
                        new SubTopic
                        {
                            Id = 541,
                            StepId = 52,
                            Title = "Kubernetes Upgrades",
                            Description = "Upgrade K8s safely",
                            Content = "Plan and execute cluster upgrades",
                            KeyPoints = new List<string> 
                            { 
                                "Upgrade planning",
                                "Version compatibility",
                                "Rolling updates",
                                "Downtime minimization",
                                "Rollback procedures"
                            }
                        },
                        new SubTopic
                        {
                            Id = 542,
                            StepId = 52,
                            Title = "Kubernetes Observability",
                            Description = "Implement full observability",
                            Content = "Build observable Kubernetes systems",
                            KeyPoints = new List<string> 
                            { 
                                "Distributed tracing",
                                "Service mesh observability",
                                "APM integration",
                                "Custom metrics",
                                "Correlation analysis"
                            }
                        }
                    }
                });

                // Add Automation & Orchestration step
                devops.Steps.Add(new RoadmapStep
                {
                    Id = 53,
                    RoadmapId = 5,
                    Title = "Automation & Orchestration",
                    Duration = "4-5 weeks",
                    Content = "Master automation tools and techniques",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 531,
                            StepId = 53,
                            Title = "Ansible Automation",
                            Description = "Automate with Ansible",
                            Content = "Learn configuration management with Ansible",
                            KeyPoints = new List<string> 
                            { 
                                "Playbook development",
                                "Inventory management",
                                "Roles and collections",
                                "Ansible Tower/AWX",
                                "Dynamic inventories"
                            }
                        },
                        new SubTopic
                        {
                            Id = 532,
                            StepId = 53,
                            Title = "Pipeline Orchestration",
                            Description = "Build complex deployment pipelines",
                            Content = "Orchestrate multi-stage deployments",
                            KeyPoints = new List<string> 
                            { 
                                "Jenkins pipelines",
                                "GitLab CI/CD",
                                "ArgoCD for GitOps",
                                "Spinnaker deployment",
                                "Blue-green deployments"
                            }
                        },
                        new SubTopic
                        {
                            Id = 533,
                            StepId = 53,
                            Title = "Terraform Advanced",
                            Description = "Master Terraform for IaC",
                            Content = "Advanced Terraform techniques",
                            KeyPoints = new List<string> 
                            { 
                                "Module development",
                                "State management",
                                "Workspaces",
                                "Provider development",
                                "Terraform Cloud"
                            }
                        },
                        new SubTopic
                        {
                            Id = 534,
                            StepId = 53,
                            Title = "Chef Configuration",
                            Description = "Automate with Chef",
                            Content = "Use Chef for configuration management",
                            KeyPoints = new List<string> 
                            { 
                                "Chef recipes",
                                "Cookbooks",
                                "Chef server",
                                "Kitchen testing",
                                "InSpec compliance"
                            }
                        },
                        new SubTopic
                        {
                            Id = 535,
                            StepId = 53,
                            Title = "Puppet Automation",
                            Description = "Infrastructure automation with Puppet",
                            Content = "Master Puppet for configuration",
                            KeyPoints = new List<string> 
                            { 
                                "Puppet manifests",
                                "Modules and classes",
                                "Hiera data",
                                "PuppetDB",
                                "Bolt orchestration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 536,
                            StepId = 53,
                            Title = "SaltStack",
                            Description = "Event-driven automation",
                            Content = "Implement SaltStack for orchestration",
                            KeyPoints = new List<string> 
                            { 
                                "Salt states",
                                "Salt pillars",
                                "Remote execution",
                                "Event reactor",
                                "Salt cloud"
                            }
                        },
                        new SubTopic
                        {
                            Id = 537,
                            StepId = 53,
                            Title = "Workflow Automation",
                            Description = "Automate complex workflows",
                            Content = "Build automated workflow systems",
                            KeyPoints = new List<string> 
                            { 
                                "Apache Airflow",
                                "Temporal workflows",
                                "Step Functions",
                                "Workflow patterns",
                                "Error handling"
                            }
                        },
                        new SubTopic
                        {
                            Id = 538,
                            StepId = 53,
                            Title = "GitOps Practices",
                            Description = "Implement GitOps workflows",
                            Content = "Use Git as source of truth",
                            KeyPoints = new List<string> 
                            { 
                                "GitOps principles",
                                "Flux CD",
                                "ArgoCD patterns",
                                "Repository structure",
                                "Drift detection"
                            }
                        },
                        new SubTopic
                        {
                            Id = 539,
                            StepId = 53,
                            Title = "Scripting for DevOps",
                            Description = "Master automation scripting",
                            Content = "Write effective automation scripts",
                            KeyPoints = new List<string> 
                            { 
                                "Bash scripting",
                                "Python automation",
                                "PowerShell",
                                "Go for tools",
                                "Script testing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 540,
                            StepId = 53,
                            Title = "Service Orchestration",
                            Description = "Orchestrate microservices",
                            Content = "Manage service dependencies",
                            KeyPoints = new List<string> 
                            { 
                                "Service discovery",
                                "Dependency management",
                                "Orchestration patterns",
                                "Service mesh",
                                "API gateway"
                            }
                        },
                        new SubTopic
                        {
                            Id = 543,
                            StepId = 53,
                            Title = "Event-Driven Automation",
                            Description = "Automate based on events",
                            Content = "Build event-driven systems",
                            KeyPoints = new List<string> 
                            { 
                                "Event sources",
                                "Event processing",
                                "Webhook automation",
                                "Message queues",
                                "Event routing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 544,
                            StepId = 53,
                            Title = "Infrastructure Testing",
                            Description = "Test infrastructure code",
                            Content = "Implement testing for IaC",
                            KeyPoints = new List<string> 
                            { 
                                "Unit testing",
                                "Integration tests",
                                "Compliance testing",
                                "Chaos engineering",
                                "Test frameworks"
                            }
                        },
                        new SubTopic
                        {
                            Id = 545,
                            StepId = 53,
                            Title = "Self-Healing Systems",
                            Description = "Build self-healing infrastructure",
                            Content = "Implement auto-remediation",
                            KeyPoints = new List<string> 
                            { 
                                "Health checks",
                                "Auto-remediation",
                                "Failure detection",
                                "Recovery actions",
                                "Escalation policies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 546,
                            StepId = 53,
                            Title = "Multi-Cloud Orchestration",
                            Description = "Orchestrate across clouds",
                            Content = "Manage multi-cloud deployments",
                            KeyPoints = new List<string> 
                            { 
                                "Cloud agnostic tools",
                                "Cross-cloud networking",
                                "Unified management",
                                "Cost optimization",
                                "Compliance management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 547,
                            StepId = 53,
                            Title = "Secrets Automation",
                            Description = "Automate secret management",
                            Content = "Handle secrets securely",
                            KeyPoints = new List<string> 
                            { 
                                "HashiCorp Vault",
                                "Secret rotation",
                                "Dynamic secrets",
                                "PKI automation",
                                "Encryption as service"
                            }
                        },
                        new SubTopic
                        {
                            Id = 548,
                            StepId = 53,
                            Title = "Deployment Strategies",
                            Description = "Advanced deployment patterns",
                            Content = "Implement sophisticated deployments",
                            KeyPoints = new List<string> 
                            { 
                                "Canary deployments",
                                "Feature flags",
                                "A/B testing",
                                "Progressive rollouts",
                                "Rollback automation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 549,
                            StepId = 53,
                            Title = "Automation Metrics",
                            Description = "Measure automation effectiveness",
                            Content = "Track automation success",
                            KeyPoints = new List<string> 
                            { 
                                "Automation KPIs",
                                "Time savings",
                                "Error reduction",
                                "Coverage metrics",
                                "ROI calculation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 550,
                            StepId = 53,
                            Title = "Automation Governance",
                            Description = "Govern automation practices",
                            Content = "Establish automation standards",
                            KeyPoints = new List<string> 
                            { 
                                "Automation policies",
                                "Change control",
                                "Approval workflows",
                                "Audit trails",
                                "Documentation standards"
                            }
                        },
                        new SubTopic
                        {
                            Id = 551,
                            StepId = 53,
                            Title = "AI/ML in Automation",
                            Description = "Use AI for intelligent automation",
                            Content = "Implement AI-driven automation",
                            KeyPoints = new List<string> 
                            { 
                                "Predictive automation",
                                "Anomaly detection",
                                "Auto-scaling ML",
                                "Intelligent routing",
                                "Self-optimization"
                            }
                        }
                    }
                });

                // Add SRE Practices step
                devops.Steps.Add(new RoadmapStep
                {
                    Id = 54,
                    RoadmapId = 5,
                    Title = "Site Reliability Engineering",
                    Duration = "4-5 weeks",
                    Content = "Implement SRE practices for reliability",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 541,
                            StepId = 54,
                            Title = "SLIs, SLOs, and Error Budgets",
                            Description = "Define and measure reliability",
                            Content = "Implement SRE measurement frameworks",
                            KeyPoints = new List<string> 
                            { 
                                "Service level indicators",
                                "Service level objectives",
                                "Error budget policies",
                                "Reliability targets",
                                "Incident management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 542,
                            StepId = 54,
                            Title = "Chaos Engineering",
                            Description = "Test system resilience",
                            Content = "Implement chaos engineering practices",
                            KeyPoints = new List<string> 
                            { 
                                "Failure injection",
                                "Chaos experiments",
                                "Game days",
                                "Resilience testing",
                                "Chaos tools (Chaos Monkey)"
                            }
                        },
                        new SubTopic
                        {
                            Id = 543,
                            StepId = 54,
                            Title = "Performance Engineering",
                            Description = "Optimize system performance",
                            Content = "Implement performance monitoring and optimization",
                            KeyPoints = new List<string> 
                            { 
                                "Load testing strategies",
                                "Performance profiling",
                                "Capacity planning",
                                "Resource optimization",
                                "Performance SLOs"
                            }
                        },
                        new SubTopic
                        {
                            Id = 544,
                            StepId = 54,
                            Title = "Observability Platforms",
                            Description = "Build comprehensive observability",
                            Content = "Implement full-stack observability solutions",
                            KeyPoints = new List<string> 
                            { 
                                "Three pillars of observability",
                                "Distributed tracing",
                                "Metrics collection",
                                "Log aggregation",
                                "Correlation analysis"
                            }
                        },
                        new SubTopic
                        {
                            Id = 545,
                            StepId = 54,
                            Title = "Incident Response",
                            Description = "Handle production incidents effectively",
                            Content = "Build robust incident response processes",
                            KeyPoints = new List<string> 
                            { 
                                "Incident command structure",
                                "On-call rotations",
                                "Runbook automation",
                                "Post-mortem culture",
                                "Blameless retrospectives"
                            }
                        },
                        new SubTopic
                        {
                            Id = 546,
                            StepId = 54,
                            Title = "Capacity Planning",
                            Description = "Predict and manage resource needs",
                            Content = "Implement data-driven capacity planning",
                            KeyPoints = new List<string> 
                            { 
                                "Demand forecasting",
                                "Resource modeling",
                                "Growth projections",
                                "Cost optimization",
                                "Scaling strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 547,
                            StepId = 54,
                            Title = "Reliability Patterns",
                            Description = "Implement patterns for high availability",
                            Content = "Design systems for maximum reliability",
                            KeyPoints = new List<string> 
                            { 
                                "Circuit breakers",
                                "Retry mechanisms",
                                "Bulkhead pattern",
                                "Timeout handling",
                                "Graceful degradation"
                            }
                        },
                        new SubTopic
                        {
                            Id = 548,
                            StepId = 54,
                            Title = "Load Balancing Strategies",
                            Description = "Distribute traffic effectively",
                            Content = "Master various load balancing techniques",
                            KeyPoints = new List<string> 
                            { 
                                "Layer 4 vs Layer 7",
                                "Health checks",
                                "Session affinity",
                                "Geographic distribution",
                                "Traffic shaping"
                            }
                        },
                        new SubTopic
                        {
                            Id = 549,
                            StepId = 54,
                            Title = "Database Reliability",
                            Description = "Ensure database high availability",
                            Content = "Implement reliable database operations",
                            KeyPoints = new List<string> 
                            { 
                                "Replication strategies",
                                "Backup automation",
                                "Failover procedures",
                                "Connection pooling",
                                "Query optimization"
                            }
                        },
                        new SubTopic
                        {
                            Id = 550,
                            StepId = 54,
                            Title = "Service Dependencies",
                            Description = "Manage service interdependencies",
                            Content = "Handle complex service relationships",
                            KeyPoints = new List<string> 
                            { 
                                "Dependency mapping",
                                "Critical path analysis",
                                "Failure propagation",
                                "Isolation strategies",
                                "Service mesh"
                            }
                        },
                        new SubTopic
                        {
                            Id = 551,
                            StepId = 54,
                            Title = "Automation Framework",
                            Description = "Automate reliability operations",
                            Content = "Build automation for SRE tasks",
                            KeyPoints = new List<string> 
                            { 
                                "Toil reduction",
                                "Self-healing systems",
                                "Automated remediation",
                                "Infrastructure as code",
                                "ChatOps"
                            }
                        },
                        new SubTopic
                        {
                            Id = 552,
                            StepId = 54,
                            Title = "Release Engineering",
                            Description = "Safe and reliable deployments",
                            Content = "Implement progressive delivery techniques",
                            KeyPoints = new List<string> 
                            { 
                                "Canary deployments",
                                "Feature flags",
                                "Blue-green deployments",
                                "Rollback procedures",
                                "Deployment pipelines"
                            }
                        },
                        new SubTopic
                        {
                            Id = 553,
                            StepId = 54,
                            Title = "Security in SRE",
                            Description = "Integrate security into reliability",
                            Content = "Build secure and reliable systems",
                            KeyPoints = new List<string> 
                            { 
                                "Security monitoring",
                                "Compliance automation",
                                "Vulnerability scanning",
                                "Secret management",
                                "Zero trust architecture"
                            }
                        },
                        new SubTopic
                        {
                            Id = 554,
                            StepId = 54,
                            Title = "Cost Reliability",
                            Description = "Balance cost and reliability",
                            Content = "Optimize spending while maintaining SLOs",
                            KeyPoints = new List<string> 
                            { 
                                "Cost monitoring",
                                "Resource optimization",
                                "Reserved capacity",
                                "Spot instance strategies",
                                "FinOps practices"
                            }
                        },
                        new SubTopic
                        {
                            Id = 555,
                            StepId = 54,
                            Title = "Multi-Region Architecture",
                            Description = "Design for global reliability",
                            Content = "Build systems that span regions",
                            KeyPoints = new List<string> 
                            { 
                                "Data replication",
                                "Traffic routing",
                                "Consistency models",
                                "Disaster recovery",
                                "Edge computing"
                            }
                        },
                        new SubTopic
                        {
                            Id = 556,
                            StepId = 54,
                            Title = "SRE Team Building",
                            Description = "Build effective SRE teams",
                            Content = "Create and manage SRE organizations",
                            KeyPoints = new List<string> 
                            { 
                                "Hiring practices",
                                "Team structure",
                                "Skill development",
                                "Cultural transformation",
                                "Collaboration models"
                            }
                        },
                        new SubTopic
                        {
                            Id = 557,
                            StepId = 54,
                            Title = "Reliability Testing",
                            Description = "Test system reliability",
                            Content = "Comprehensive reliability testing strategies",
                            KeyPoints = new List<string> 
                            { 
                                "Load testing",
                                "Stress testing",
                                "Failure injection",
                                "Game days",
                                "Disaster recovery drills"
                            }
                        },
                        new SubTopic
                        {
                            Id = 558,
                            StepId = 54,
                            Title = "Platform Reliability",
                            Description = "Build reliable platforms",
                            Content = "Create self-service reliable platforms",
                            KeyPoints = new List<string> 
                            { 
                                "Platform engineering",
                                "Golden paths",
                                "Service catalogs",
                                "Platform APIs",
                                "Developer experience"
                            }
                        },
                        new SubTopic
                        {
                            Id = 559,
                            StepId = 54,
                            Title = "SRE Metrics & KPIs",
                            Description = "Measure SRE effectiveness",
                            Content = "Track and improve SRE performance",
                            KeyPoints = new List<string> 
                            { 
                                "MTTR and MTBF",
                                "Toil measurement",
                                "Reliability dashboards",
                                "Team velocity",
                                "Business impact metrics"
                            }
                        },
                        new SubTopic
                        {
                            Id = 560,
                            StepId = 54,
                            Title = "Future of SRE",
                            Description = "Emerging trends in reliability",
                            Content = "Stay ahead with new SRE practices",
                            KeyPoints = new List<string> 
                            { 
                                "AI/ML in operations",
                                "Predictive analytics",
                                "Quantum-safe systems",
                                "Sustainability",
                                "Edge reliability"
                            }
                        }
                    }
                });
            }
        }

        private void AddSpecializedSubTopics(List<Roadmap> roadmaps)
        {
            // Azure Developer Roadmap
            var azureDev = roadmaps.FirstOrDefault(r => r.Id == 24);
            if (azureDev != null)
            {
                // Azure Fundamentals - Step 240
                var fundamentalsStep = azureDev.Steps.FirstOrDefault(s => s.Id == 240);
                if (fundamentalsStep != null)
                {
                    fundamentalsStep.SubTopics.AddRange(new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 2403,
                            StepId = 240,
                            Title = "Azure Networking Basics",
                            Description = "Understand Azure networking fundamentals",
                            Content = "Learn core networking concepts in Azure",
                            KeyPoints = new List<string> 
                            { 
                                "Virtual Networks (VNet)",
                                "Subnets and NSGs",
                                "Azure Load Balancer",
                                "VPN Gateway basics",
                                "Network peering"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2404,
                            StepId = 240,
                            Title = "Azure Cost Management",
                            Description = "Optimize Azure spending",
                            Content = "Learn to manage and optimize Azure costs",
                            KeyPoints = new List<string> 
                            { 
                                "Pricing calculator",
                                "Cost analysis tools",
                                "Budgets and alerts",
                                "Reserved instances",
                                "Cost optimization strategies"
                            }
                        }
                    });
                }

                // Azure Compute - Step 241
                var computeStep = azureDev.Steps.FirstOrDefault(s => s.Id == 241);
                if (computeStep != null)
                {
                    computeStep.SubTopics.AddRange(new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 2413,
                            StepId = 241,
                            Title = "Azure Functions",
                            Description = "Serverless compute with Azure Functions",
                            Content = "Build event-driven serverless applications",
                            KeyPoints = new List<string> 
                            { 
                                "Function triggers and bindings",
                                "Durable Functions",
                                "Function app configuration",
                                "Local development and testing",
                                "Monitoring and diagnostics"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2414,
                            StepId = 241,
                            Title = "Azure Container Services",
                            Description = "Container orchestration in Azure",
                            Content = "Deploy and manage containerized applications",
                            KeyPoints = new List<string> 
                            { 
                                "Azure Container Instances",
                                "Azure Kubernetes Service (AKS)",
                                "Container Registry",
                                "Docker integration",
                                "Container security"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2415,
                            StepId = 241,
                            Title = "Azure Logic Apps",
                            Description = "Build automated workflows",
                            Content = "Create enterprise integration solutions",
                            KeyPoints = new List<string> 
                            { 
                                "Workflow designer",
                                "Connectors and triggers",
                                "Enterprise integration pack",
                                "B2B scenarios",
                                "Custom connectors"
                            }
                        }
                    });
                }

                // Add Advanced Azure Services step
                azureDev.Steps.Add(new RoadmapStep
                {
                    Id = 244,
                    RoadmapId = 24,
                    Title = "Advanced Azure Services",
                    Duration = "4-5 weeks",
                    Content = "Master advanced Azure services and patterns",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 2441,
                            StepId = 244,
                            Title = "Azure Service Bus & Event Grid",
                            Description = "Message-based integration services",
                            Content = "Build decoupled, scalable applications",
                            KeyPoints = new List<string> 
                            { 
                                "Service Bus queues and topics",
                                "Event Grid architecture",
                                "Event Hubs for streaming",
                                "Message patterns",
                                "Dead letter queues"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2442,
                            StepId = 244,
                            Title = "Azure API Management",
                            Description = "Manage and secure APIs",
                            Content = "Create API gateways and developer portals",
                            KeyPoints = new List<string> 
                            { 
                                "API gateway patterns",
                                "Policy configuration",
                                "Developer portal",
                                "API versioning",
                                "Throttling and quotas"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2443,
                            StepId = 244,
                            Title = "Azure Cognitive Services",
                            Description = "Add AI capabilities to applications",
                            Content = "Integrate pre-built AI models",
                            KeyPoints = new List<string> 
                            { 
                                "Computer Vision",
                                "Language Understanding",
                                "Speech Services",
                                "Azure OpenAI Service",
                                "Custom Vision"
                            }
                        }
                    }
                });

                // Add Azure Security & Compliance step
                azureDev.Steps.Add(new RoadmapStep
                {
                    Id = 245,
                    RoadmapId = 24,
                    Title = "Azure Security & Compliance",
                    Duration = "3-4 weeks",
                    Content = "Implement security best practices and compliance",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 2451,
                            StepId = 245,
                            Title = "Azure Security Center",
                            Description = "Unified security management",
                            Content = "Monitor and improve security posture",
                            KeyPoints = new List<string> 
                            { 
                                "Security recommendations",
                                "Threat protection",
                                "Compliance assessment",
                                "Security policies",
                                "Just-in-time access"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2452,
                            StepId = 245,
                            Title = "Network Security",
                            Description = "Secure Azure network infrastructure",
                            Content = "Implement defense-in-depth networking",
                            KeyPoints = new List<string> 
                            { 
                                "Azure Firewall",
                                "DDoS Protection",
                                "Application Gateway WAF",
                                "Private endpoints",
                                "Azure Bastion"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2453,
                            StepId = 245,
                            Title = "Compliance & Governance",
                            Description = "Meet regulatory requirements",
                            Content = "Implement governance and compliance controls",
                            KeyPoints = new List<string> 
                            { 
                                "Azure Policy",
                                "Blueprints",
                                "Management Groups",
                                "Compliance Manager",
                                "Audit logging"
                            }
                        }
                    }
                });

                // Add Azure Architecture Patterns step
                azureDev.Steps.Add(new RoadmapStep
                {
                    Id = 246,
                    RoadmapId = 24,
                    Title = "Azure Architecture Patterns",
                    Duration = "3-4 weeks",
                    Content = "Design scalable and reliable Azure solutions",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 2461,
                            StepId = 246,
                            Title = "Cloud Design Patterns",
                            Description = "Common architectural patterns",
                            Content = "Implement proven design patterns",
                            KeyPoints = new List<string> 
                            { 
                                "Microservices on Azure",
                                "Event-driven architecture",
                                "CQRS and Event Sourcing",
                                "Strangler Fig pattern",
                                "Circuit breaker pattern"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2462,
                            StepId = 246,
                            Title = "High Availability & DR",
                            Description = "Design for reliability",
                            Content = "Implement HA and disaster recovery",
                            KeyPoints = new List<string> 
                            { 
                                "Availability zones",
                                "Geo-redundancy",
                                "Backup strategies",
                                "Azure Site Recovery",
                                "RTO and RPO planning"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2463,
                            StepId = 246,
                            Title = "Performance & Scalability",
                            Description = "Optimize for performance",
                            Content = "Build scalable Azure solutions",
                            KeyPoints = new List<string> 
                            { 
                                "Auto-scaling strategies",
                                "Caching with Redis",
                                "CDN integration",
                                "Performance testing",
                                "Load testing with Azure"
                            }
                        }
                    }
                });

                // Add more comprehensive subtopics to existing steps
                var storageStep = azureDev.Steps.FirstOrDefault(s => s.Id == 242);
                if (storageStep != null)
                {
                    storageStep.SubTopics.AddRange(new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 2423,
                            StepId = 242,
                            Title = "Azure Data Lake",
                            Description = "Big data storage and analytics",
                            Content = "Implement data lake solutions for big data scenarios",
                            KeyPoints = new List<string> 
                            { 
                                "Data Lake Storage Gen2",
                                "Hierarchical namespace",
                                "Data lifecycle management",
                                "Integration with analytics",
                                "Security and access control"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2424,
                            StepId = 242,
                            Title = "Azure Synapse Analytics",
                            Description = "Unified analytics platform",
                            Content = "Build end-to-end analytics solutions",
                            KeyPoints = new List<string> 
                            { 
                                "Synapse workspace",
                                "Dedicated SQL pools",
                                "Spark pools",
                                "Data pipelines",
                                "Power BI integration"
                            }
                        }
                    });
                }

                var devopsStep = azureDev.Steps.FirstOrDefault(s => s.Id == 243);
                if (devopsStep != null)
                {
                    devopsStep.SubTopics.AddRange(new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 2433,
                            StepId = 243,
                            Title = "Infrastructure as Code with Bicep",
                            Description = "Azure-native IaC solution",
                            Content = "Deploy Azure resources using Bicep language",
                            KeyPoints = new List<string> 
                            { 
                                "Bicep syntax and structure",
                                "Resource dependencies",
                                "Modules and reusability",
                                "Parameter files",
                                "CI/CD integration"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2434,
                            StepId = 243,
                            Title = "GitHub Actions for Azure",
                            Description = "Automate Azure deployments",
                            Content = "Use GitHub Actions for CI/CD to Azure",
                            KeyPoints = new List<string> 
                            { 
                                "Azure login action",
                                "Service principal setup",
                                "Deployment workflows",
                                "Secret management",
                                "Environment protection"
                            }
                        }
                    });
                }

                // Add Azure Data & AI step
                azureDev.Steps.Add(new RoadmapStep
                {
                    Id = 247,
                    RoadmapId = 24,
                    Title = "Azure Data & AI Services",
                    Duration = "5-6 weeks",
                    Content = "Build intelligent data-driven applications",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 2471,
                            StepId = 247,
                            Title = "Azure Machine Learning",
                            Description = "Build and deploy ML models",
                            Content = "Create end-to-end machine learning solutions",
                            KeyPoints = new List<string> 
                            { 
                                "ML Studio workspace",
                                "AutoML capabilities",
                                "Model training pipelines",
                                "Model deployment",
                                "MLOps practices"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2472,
                            StepId = 247,
                            Title = "Azure Databricks",
                            Description = "Big data analytics platform",
                            Content = "Process large-scale data with Apache Spark",
                            KeyPoints = new List<string> 
                            { 
                                "Databricks workspace",
                                "Notebooks and clusters",
                                "Delta Lake",
                                "Spark SQL and DataFrames",
                                "Integration with Azure services"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2473,
                            StepId = 247,
                            Title = "Azure Data Factory",
                            Description = "Data integration service",
                            Content = "Build ETL/ELT pipelines at scale",
                            KeyPoints = new List<string> 
                            { 
                                "Pipeline orchestration",
                                "Data flow transformations",
                                "Integration runtime",
                                "Linked services",
                                "Monitoring and alerts"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2474,
                            StepId = 247,
                            Title = "Azure Stream Analytics",
                            Description = "Real-time data processing",
                            Content = "Analyze streaming data in real-time",
                            KeyPoints = new List<string> 
                            { 
                                "Stream processing jobs",
                                "Windowing functions",
                                "IoT Hub integration",
                                "Power BI real-time dashboards",
                                "Edge deployments"
                            }
                        }
                    }
                });

                // Add Azure Integration Services step
                azureDev.Steps.Add(new RoadmapStep
                {
                    Id = 248,
                    RoadmapId = 24,
                    Title = "Azure Integration Services",
                    Duration = "4-5 weeks",
                    Content = "Connect applications, data, and devices",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 2481,
                            StepId = 248,
                            Title = "Azure Service Fabric",
                            Description = "Microservices platform",
                            Content = "Build and manage scalable microservices",
                            KeyPoints = new List<string> 
                            { 
                                "Service Fabric clusters",
                                "Stateful services",
                                "Actor model",
                                "Application lifecycle",
                                "Health monitoring"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2482,
                            StepId = 248,
                            Title = "Azure Event Hubs",
                            Description = "Big data streaming platform",
                            Content = "Ingest millions of events per second",
                            KeyPoints = new List<string> 
                            { 
                                "Event Hub namespaces",
                                "Partitions and throughput",
                                "Capture to storage",
                                "Kafka compatibility",
                                "Event processors"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2483,
                            StepId = 248,
                            Title = "Azure IoT Services",
                            Description = "Internet of Things solutions",
                            Content = "Connect and manage IoT devices",
                            KeyPoints = new List<string> 
                            { 
                                "IoT Hub device management",
                                "IoT Edge computing",
                                "Device provisioning",
                                "Time Series Insights",
                                "Digital Twins"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2484,
                            StepId = 248,
                            Title = "Azure SignalR Service",
                            Description = "Real-time web functionality",
                            Content = "Add real-time features to applications",
                            KeyPoints = new List<string> 
                            { 
                                "WebSocket connections",
                                "Hub scaling",
                                "Authentication modes",
                                "Client SDKs",
                                "Serverless mode"
                            }
                        }
                    }
                });

                // Add Azure Hybrid & Multi-Cloud step
                azureDev.Steps.Add(new RoadmapStep
                {
                    Id = 249,
                    RoadmapId = 24,
                    Title = "Hybrid & Multi-Cloud Solutions",
                    Duration = "4-5 weeks",
                    Content = "Extend Azure to on-premises and other clouds",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 2491,
                            StepId = 249,
                            Title = "Azure Arc",
                            Description = "Manage resources anywhere",
                            Content = "Extend Azure management to any infrastructure",
                            KeyPoints = new List<string> 
                            { 
                                "Arc-enabled servers",
                                "Arc-enabled Kubernetes",
                                "Arc-enabled data services",
                                "Policy enforcement",
                                "Unified management"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2492,
                            StepId = 249,
                            Title = "Azure Stack",
                            Description = "Azure services on-premises",
                            Content = "Run Azure services in your datacenter",
                            KeyPoints = new List<string> 
                            { 
                                "Azure Stack Hub",
                                "Azure Stack Edge",
                                "Azure Stack HCI",
                                "Hybrid connectivity",
                                "Consistent operations"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2493,
                            StepId = 249,
                            Title = "ExpressRoute",
                            Description = "Private connection to Azure",
                            Content = "Establish dedicated network connections",
                            KeyPoints = new List<string> 
                            { 
                                "ExpressRoute circuits",
                                "Peering configuration",
                                "Global Reach",
                                "FastPath",
                                "Connection monitoring"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2494,
                            StepId = 249,
                            Title = "Multi-Cloud Strategies",
                            Description = "Work across cloud providers",
                            Content = "Implement multi-cloud architectures",
                            KeyPoints = new List<string> 
                            { 
                                "Azure Arc for multi-cloud",
                                "Cross-cloud networking",
                                "Identity federation",
                                "Data synchronization",
                                "Cost management"
                            }
                        }
                    }
                });

                // Add Azure Specialized Workloads step
                azureDev.Steps.Add(new RoadmapStep
                {
                    Id = 250,
                    RoadmapId = 24,
                    Title = "Specialized Azure Workloads",
                    Duration = "4-5 weeks",
                    Content = "Implement industry-specific and specialized solutions",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 2501,
                            StepId = 250,
                            Title = "Azure for SAP Workloads",
                            Description = "Run SAP on Azure",
                            Content = "Deploy and manage SAP systems on Azure",
                            KeyPoints = new List<string> 
                            { 
                                "SAP certified VMs",
                                "High availability setup",
                                "SAP HANA on Azure",
                                "Backup and DR",
                                "Monitoring solutions"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2502,
                            StepId = 250,
                            Title = "Azure HPC & Batch",
                            Description = "High-performance computing",
                            Content = "Run large-scale parallel workloads",
                            KeyPoints = new List<string> 
                            { 
                                "Azure Batch service",
                                "HPC VM families",
                                "CycleCloud",
                                "Parallel file systems",
                                "Job scheduling"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2503,
                            StepId = 250,
                            Title = "Azure Blockchain",
                            Description = "Blockchain solutions",
                            Content = "Build blockchain applications",
                            KeyPoints = new List<string> 
                            { 
                                "Azure Blockchain Service",
                                "Consortium management",
                                "Smart contracts",
                                "Integration patterns",
                                "Ledger databases"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2504,
                            StepId = 250,
                            Title = "Azure Quantum",
                            Description = "Quantum computing services",
                            Content = "Explore quantum computing on Azure",
                            KeyPoints = new List<string> 
                            { 
                                "Quantum workspace",
                                "Q# programming",
                                "Quantum simulators",
                                "Hardware providers",
                                "Quantum algorithms"
                            }
                        }
                    }
                });

                // Add Azure Migration & Modernization step
                azureDev.Steps.Add(new RoadmapStep
                {
                    Id = 251,
                    RoadmapId = 24,
                    Title = "Migration & Modernization",
                    Duration = "4-5 weeks",
                    Content = "Migrate and modernize applications on Azure",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 2511,
                            StepId = 251,
                            Title = "Azure Migrate",
                            Description = "Assess and migrate workloads",
                            Content = "Discover, assess, and migrate to Azure",
                            KeyPoints = new List<string> 
                            { 
                                "Discovery and assessment",
                                "Server migration",
                                "Database migration",
                                "Web app migration",
                                "Dependency mapping"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2512,
                            StepId = 251,
                            Title = "Application Modernization",
                            Description = "Modernize legacy applications",
                            Content = "Transform applications for the cloud",
                            KeyPoints = new List<string> 
                            { 
                                "Containerization strategies",
                                "Microservices transformation",
                                "Serverless migration",
                                "Data modernization",
                                "DevOps adoption"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2513,
                            StepId = 251,
                            Title = "Database Migration Service",
                            Description = "Migrate databases to Azure",
                            Content = "Seamlessly migrate databases with minimal downtime",
                            KeyPoints = new List<string> 
                            { 
                                "Online migrations",
                                "Schema conversion",
                                "Performance optimization",
                                "Validation and testing",
                                "Cutover strategies"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2514,
                            StepId = 251,
                            Title = "Cloud Adoption Framework",
                            Description = "Best practices for cloud adoption",
                            Content = "Follow Microsoft's Cloud Adoption Framework",
                            KeyPoints = new List<string> 
                            { 
                                "Strategy definition",
                                "Planning phase",
                                "Ready phase",
                                "Adopt phase",
                                "Govern and manage"
                            }
                        }
                    }
                });

                // Add Azure Well-Architected Framework step
                azureDev.Steps.Add(new RoadmapStep
                {
                    Id = 252,
                    RoadmapId = 24,
                    Title = "Well-Architected Framework",
                    Duration = "3-4 weeks",
                    Content = "Design reliable, secure, and efficient solutions",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = 2521,
                            StepId = 252,
                            Title = "Reliability Pillar",
                            Description = "Build resilient applications",
                            Content = "Design for high availability and disaster recovery",
                            KeyPoints = new List<string> 
                            { 
                                "Failure mode analysis",
                                "Health probes and checks",
                                "Retry and circuit breaker",
                                "Data replication",
                                "Testing resilience"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2522,
                            StepId = 252,
                            Title = "Security Pillar",
                            Description = "Implement defense in depth",
                            Content = "Apply security best practices across all layers",
                            KeyPoints = new List<string> 
                            { 
                                "Zero Trust model",
                                "Identity as perimeter",
                                "Encryption everywhere",
                                "Security monitoring",
                                "Incident response"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2523,
                            StepId = 252,
                            Title = "Cost Optimization Pillar",
                            Description = "Optimize Azure spending",
                            Content = "Maximize value while minimizing costs",
                            KeyPoints = new List<string> 
                            { 
                                "Right-sizing resources",
                                "Reserved capacity",
                                "Spot instances",
                                "Cost allocation",
                                "FinOps practices"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2524,
                            StepId = 252,
                            Title = "Operational Excellence Pillar",
                            Description = "Operate efficiently at scale",
                            Content = "Implement DevOps and automation practices",
                            KeyPoints = new List<string> 
                            { 
                                "Infrastructure as Code",
                                "Deployment automation",
                                "Monitoring and alerting",
                                "Incident management",
                                "Continuous improvement"
                            }
                        },
                        new SubTopic
                        {
                            Id = 2525,
                            StepId = 252,
                            Title = "Performance Efficiency Pillar",
                            Description = "Scale to meet demand",
                            Content = "Optimize performance and scalability",
                            KeyPoints = new List<string> 
                            { 
                                "Performance baselines",
                                "Auto-scaling patterns",
                                "Caching strategies",
                                "Async patterns",
                                "Load testing"
                            }
                        }
                    }
                });
            }

            // Add subtopics for remaining roadmaps with empty Steps
            foreach (var roadmap in roadmaps.Where(r => !r.Steps.Any()))
            {
                roadmap.Steps.Add(new RoadmapStep
                {
                    Id = roadmap.Id * 10,
                    RoadmapId = roadmap.Id,
                    Title = "Getting Started",
                    Duration = "2-3 weeks",
                    Content = $"Introduction to {roadmap.Title}",
                    SubTopics = new List<SubTopic>
                    {
                        new SubTopic
                        {
                            Id = roadmap.Id * 100 + 1,
                            StepId = roadmap.Id * 10,
                            Title = "Fundamentals",
                            Description = $"Core concepts of {roadmap.Title}",
                            Content = $"Learn the essential foundations",
                            KeyPoints = new List<string> 
                            { 
                                "Basic concepts",
                                "Key terminology",
                                "Industry standards",
                                "Best practices"
                            }
                        }
                    }
                });
            }
        }
        
    }
}