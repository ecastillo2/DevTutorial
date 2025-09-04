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

    public partial class RoadmapService : IRoadmapService
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
            var roadmaps = new List<Roadmap>
            {
                // Frontend Developer
                new Roadmap
                {
                    Id = 1,
                    Title = "Frontend Developer",
                    Description = "Master modern web development with HTML, CSS, JavaScript, and React",
                    Icon = "🎨",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "6-8 months",
                    Difficulty = "Beginner to Advanced",
                    ActionName = "FrontendDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "Frontend development is the practice of creating the visual and interactive elements of websites and web applications.",
                    Prerequisites = new List<string>
                    {
                        "Basic computer literacy",
                        "No prior programming experience required"
                    },
                    CareerPaths = new List<string>
                    {
                        "Frontend Developer ($60K-$120K)",
                        "UI/UX Engineer ($70K-$130K)",
                        "Full Stack Developer ($80K-$150K)"
                    },
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 1,
                            RoadmapId = 1,
                            Title = "HTML & CSS Fundamentals",
                            Duration = "2-3 weeks",
                            Content = "Learn the building blocks of web development",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 1,
                                    StepId = 1,
                                    Title = "HTML Document Structure",
                                    Description = "Understanding the basics of HTML",
                                    Content = "Learn about HTML elements, attributes, and document structure",
                                    KeyPoints = new List<string> { "DOCTYPE", "Head and Body", "Semantic Elements" },
                                    CodeExample = "<!-- Basic HTML structure example -->"
                                },
                                new SubTopic
                                {
                                    Id = 2,
                                    StepId = 1,
                                    Title = "CSS Styling",
                                    Description = "Styling web pages with CSS",
                                    Content = "Learn CSS selectors, properties, and the box model",
                                    KeyPoints = new List<string> { "Selectors", "Box Model", "Flexbox", "Grid" },
                                    CodeExample = "/* CSS styling example */"
                                }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 2,
                            RoadmapId = 1,
                            Title = "JavaScript Programming",
                            Duration = "4-6 weeks",
                            Content = "Master JavaScript fundamentals and modern ES6+ features",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 3,
                                    StepId = 2,
                                    Title = "JavaScript Basics",
                                    Description = "Core JavaScript concepts",
                                    Content = "Variables, functions, and control flow",
                                    KeyPoints = new List<string> { "Variables", "Functions", "Arrays", "Objects" },
                                    CodeExample = "// JavaScript basics example"
                                }
                            }
                        }
                    }
                },

                // Backend Developer
                new Roadmap
                {
                    Id = 2,
                    Title = "Backend Developer",
                    Description = "Build robust server-side applications and APIs",
                    Icon = "⚙️",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "6-8 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "BackendDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "Backend development focuses on server-side logic, database management, and API development.",
                    Prerequisites = new List<string>
                    {
                        "Basic programming concepts",
                        "Understanding of web concepts"
                    },
                    CareerPaths = new List<string>
                    {
                        "Backend Developer ($70K-$130K)",
                        ".NET Developer ($65K-$125K)",
                        "Full Stack Developer ($80K-$150K)"
                    },
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 3,
                            RoadmapId = 2,
                            Title = "C# Fundamentals",
                            Duration = "3-4 weeks",
                            Content = "Master C# programming language basics",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 31,
                                    StepId = 3,
                                    Title = "C# Language Basics",
                                    Description = "Introduction to C# programming",
                                    Content = "Learn the fundamentals of C# programming language",
                                    KeyPoints = new List<string> { "Syntax", "Types", "Classes", "Methods" }
                                }
                            }
                        }
                    }
                },

                // C# Developer
                new Roadmap
                {
                    Id = 11,
                    Title = "C# Developer",
                    Description = "Master C# programming from basics to advanced features",
                    Icon = "🔷",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "4-6 months",
                    Difficulty = "Beginner to Advanced",
                    ActionName = "CSharpDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "C# is a modern, object-oriented programming language developed by Microsoft.",
                    Prerequisites = new List<string>
                    {
                        "Basic computer skills",
                        "Logical thinking"
                    },
                    CareerPaths = new List<string>
                    {
                        "C# Developer ($60K-$120K)",
                        ".NET Developer ($65K-$125K)",
                        "Software Engineer ($70K-$140K)"
                    },
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 110,
                            RoadmapId = 11,
                            Title = "C# Basics",
                            Duration = "3 weeks",
                            Content = "Learn C# syntax and basic programming concepts",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 1101,
                                    StepId = 110,
                                    Title = "C# Fundamentals",
                                    Description = "Master the core building blocks of C# programming language",
                                    Content = "C# is a modern, object-oriented programming language developed by Microsoft as part of the .NET framework. Understanding C# fundamentals is essential for building robust applications. This comprehensive guide covers variables, data types, control flow, methods, and object-oriented programming concepts that form the foundation of C# development.",
                                    KeyPoints = new List<string> 
                                    { 
                                        "Variables and Data Types", 
                                        "Control Flow Statements", 
                                        "Methods and Parameters", 
                                        "Object-Oriented Programming", 
                                        "Exception Handling",
                                        "Collections and Arrays",
                                        "String Manipulation",
                                        "LINQ Basics"
                                    },
                                    CodeExample = @"// C# Fundamentals Examples

// 1. Variables and Data Types
int age = 25;
double salary = 75000.50;
string name = ""John Doe"";
bool isActive = true;
char grade = 'A';

// Nullable types
int? nullableAge = null;

// 2. Control Flow
if (age >= 18)
{
    Console.WriteLine(""Adult"");
}
else
{
    Console.WriteLine(""Minor"");
}

// Switch expression (C# 8.0+)
string category = age switch
{
    &lt; 13 => ""Child"",
    &lt; 18 => ""Teenager"",
    _ => ""Adult""
};

// Loops
for (int i = 0; i &lt; 5; i++)
{
    Console.WriteLine($""Number: {i}"");
}

// 3. Methods
public static int CalculateSum(int a, int b)
{
    return a + b;
}

// Method with optional parameters
public static void PrintInfo(string name, int age = 0, bool showAge = true)
{
    Console.WriteLine(showAge ? $""Name: {name}, Age: {age}"" : $""Name: {name}"");
}

// 4. Object-Oriented Programming
public class Person
{
    // Properties
    public string Name { get; set; }
    public int Age { get; private set; }
    
    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    // Method
    public void Introduce()
    {
        Console.WriteLine($""Hello, I'm {Name} and I'm {Age} years old."");
    }
}

// 5. Exception Handling
try
{
    int result = 10 / 0;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($""Error: {ex.Message}"");
}
finally
{
    Console.WriteLine(""Cleanup code here"");
}

// 6. Collections
List<string> names = new List<string> { ""Alice"", ""Bob"", ""Charlie"" };
Dictionary<string, int> ages = new Dictionary<string, int>
{
    [""Alice""] = 25,
    [""Bob""] = 30
};

// 7. LINQ Examples
var adults = names.Where(name => ages.GetValueOrDefault(name, 0) >= 18).ToList();
var totalAge = ages.Values.Sum();

// 8. String Manipulation
string text = ""Hello, World!"";
string upper = text.ToUpper();
string substring = text.Substring(0, 5);
bool contains = text.Contains(""World"");
string formatted = $""Welcome, {name}!"";

// String interpolation with formatting
string price = $""Price: {salary:C}""; // Currency format
string percentage = $""Rate: {0.85:P}""; // Percentage format"
                                }
                            }
                        }
                    }
                },

                // .NET Core Developer
                new Roadmap
                {
                    Id = 16,
                    Title = ".NET Core Developer",
                    Description = "Build modern applications with .NET Core and ASP.NET Core",
                    Icon = "⚡",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "5-7 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "NETCoreDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = ".NET Core is a cross-platform, high-performance framework for building modern applications.",
                    Prerequisites = new List<string>
                    {
                        "C# programming knowledge",
                        "Basic web development concepts"
                    },
                    CareerPaths = new List<string>
                    {
                        ".NET Developer ($65K-$125K)",
                        "Full Stack Developer ($80K-$150K)",
                        "Solutions Architect ($120K-$180K)"
                    },
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 93,
                            RoadmapId = 16,
                            Title = ".NET Core Fundamentals",
                            Duration = "2-3 weeks",
                            Content = "Understanding .NET Core architecture and basics",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 931,
                                    StepId = 93,
                                    Title = ".NET Core Architecture",
                                    Description = "Understanding the modular architecture of .NET Core",
                                    Content = ".NET Core is a cross-platform framework",
                                    KeyPoints = new List<string> { "Cross-platform", "Modular", "High performance" },
                                    CodeExample = "// .NET Core example"
                                }
                            }
                        }
                    }
                },

                // SQL & Database
                new Roadmap
                {
                    Id = 15,
                    Title = "SQL & Database Developer",
                    Description = "Master database design, SQL queries, and optimization",
                    Icon = "🗄️",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "3-4 months",
                    Difficulty = "Beginner to Intermediate",
                    ActionName = "SQLDatabaseDevelopment",
                    ControllerName = "WebDevelopment",
                    Context = "SQL is the standard language for managing and manipulating databases.",
                    Prerequisites = new List<string>
                    {
                        "Basic computer skills",
                        "Understanding of data concepts"
                    },
                    CareerPaths = new List<string>
                    {
                        "Database Developer ($65K-$120K)",
                        "Data Analyst ($60K-$110K)",
                        "Database Administrator ($70K-$130K)"
                    },
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 150,
                            RoadmapId = 15,
                            Title = "SQL Basics",
                            Duration = "2 weeks",
                            Content = "Learn SQL fundamentals and database concepts",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 1501,
                                    StepId = 150,
                                    Title = "Introduction to SQL",
                                    Description = "Understanding SQL and relational databases",
                                    Content = "SQL is a declarative language for working with data",
                                    KeyPoints = new List<string> { "SELECT statements", "WHERE clauses", "JOIN operations" }
                                }
                            }
                        }
                    }
                },

                // Add other roadmaps with minimal structure...
                new Roadmap
                {
                    Id = 3,
                    Title = "Mobile App Developer",
                    Description = "Create native and cross-platform mobile applications",
                    Icon = "📱",
                    Category = CategoryConstants.Mobile,
                    Duration = "6-8 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "AppDeveloper",
                    ControllerName = "Mobile",
                    Context = "Mobile development involves creating applications for iOS and Android devices.",
                    Prerequisites = new List<string> { "Programming basics", "Understanding of mobile UX" },
                    CareerPaths = new List<string> { "Mobile Developer ($70K-$140K)", "iOS Developer ($75K-$150K)" },
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 30,
                            RoadmapId = 3,
                            Title = "Mobile Development Basics",
                            Duration = "2 weeks",
                            Content = "Introduction to mobile development concepts",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 301,
                                    StepId = 30,
                                    Title = "Mobile Platforms Overview",
                                    Description = "Understanding iOS and Android ecosystems",
                                    Content = "Learn about different mobile platforms and their characteristics",
                                    KeyPoints = new List<string> { "iOS vs Android", "Native vs Cross-platform", "Mobile UI/UX principles" }
                                }
                            }
                        }
                    }
                },

                new Roadmap
                {
                    Id = 4,
                    Title = "Data Scientist",
                    Description = "Analyze data and build predictive models",
                    Icon = "📊",
                    Category = CategoryConstants.DataScience,
                    Duration = "8-12 months",
                    Difficulty = "Advanced",
                    ActionName = "DataScientist",
                    ControllerName = "DataScience",
                    Context = "Data science combines statistics, programming, and domain expertise.",
                    Prerequisites = new List<string> { "Statistics knowledge", "Programming skills" },
                    CareerPaths = new List<string> { "Data Scientist ($90K-$160K)", "ML Engineer ($100K-$180K)" },
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 40,
                            RoadmapId = 4,
                            Title = "Data Science Fundamentals",
                            Duration = "3 weeks",
                            Content = "Introduction to data science concepts and tools",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 401,
                                    StepId = 40,
                                    Title = "Data Science Overview",
                                    Description = "Understanding the data science workflow",
                                    Content = "Learn about the data science process and key concepts",
                                    KeyPoints = new List<string> { "Data collection", "Data cleaning", "Exploratory analysis", "Model building" }
                                }
                            }
                        }
                    }
                },

                // DevOps Engineer
                new Roadmap
                {
                    Id = 5,
                    Title = "DevOps Engineer",
                    Description = "Master continuous integration, deployment, and cloud infrastructure",
                    Icon = "🚀",
                    Category = CategoryConstants.DevOps,
                    Duration = "6-9 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "DevOpsEngineer",
                    ControllerName = "DevOps",
                    Context = "DevOps bridges development and operations through automation and collaboration.",
                    Prerequisites = new List<string> { "Linux basics", "Scripting knowledge" },
                    CareerPaths = new List<string> { "DevOps Engineer ($80K-$150K)", "SRE ($90K-$170K)" },
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 50,
                            RoadmapId = 5,
                            Title = "DevOps Fundamentals",
                            Duration = "2 weeks",
                            Content = "Introduction to DevOps principles and practices",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 501,
                                    StepId = 50,
                                    Title = "DevOps Culture",
                                    Description = "Understanding DevOps philosophy",
                                    Content = "Learn about DevOps principles and benefits",
                                    KeyPoints = new List<string> { "CI/CD", "Infrastructure as Code", "Monitoring" }
                                }
                            }
                        }
                    }
                },

                // Cloud Architect
                new Roadmap
                {
                    Id = 6,
                    Title = "Cloud Architect",
                    Description = "Design and implement scalable cloud solutions",
                    Icon = "☁️",
                    Category = CategoryConstants.DevOps,
                    Duration = "8-10 months",
                    Difficulty = "Advanced",
                    ActionName = "CloudArchitect",
                    ControllerName = "DevOps",
                    Context = "Cloud architects design distributed systems and cloud infrastructure.",
                    Prerequisites = new List<string> { "Networking basics", "System design" },
                    CareerPaths = new List<string> { "Cloud Architect ($120K-$200K)", "Solutions Architect ($130K-$220K)" },
                    Steps = new List<RoadmapStep>()
                },

                // Machine Learning Engineer
                new Roadmap
                {
                    Id = 7,
                    Title = "Machine Learning Engineer",
                    Description = "Build and deploy machine learning systems",
                    Icon = "🤖",
                    Category = CategoryConstants.DataScience,
                    Duration = "9-12 months",
                    Difficulty = "Advanced",
                    ActionName = "MLEngineer",
                    ControllerName = "DataScience",
                    Context = "ML engineers build production-ready machine learning systems.",
                    Prerequisites = new List<string> { "Python programming", "Mathematics basics" },
                    CareerPaths = new List<string> { "ML Engineer ($100K-$180K)", "AI Engineer ($110K-$200K)" },
                    Steps = new List<RoadmapStep>()
                },

                // Cybersecurity Specialist
                new Roadmap
                {
                    Id = 8,
                    Title = "Cybersecurity Specialist",
                    Description = "Protect systems and data from security threats",
                    Icon = "🔒",
                    Category = CategoryConstants.Specialized,
                    Duration = "6-9 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "Cybersecurity",
                    ControllerName = "Specialized",
                    Context = "Cybersecurity professionals protect organizations from digital threats.",
                    Prerequisites = new List<string> { "Networking knowledge", "Operating systems" },
                    CareerPaths = new List<string> { "Security Analyst ($70K-$130K)", "Security Engineer ($90K-$160K)" },
                    Steps = new List<RoadmapStep>()
                },

                // QA Engineer
                new Roadmap
                {
                    Id = 9,
                    Title = "QA Engineer",
                    Description = "Ensure software quality through comprehensive testing",
                    Icon = "✅",
                    Category = CategoryConstants.Testing,
                    Duration = "4-6 months",
                    Difficulty = "Beginner to Intermediate",
                    ActionName = "QAEngineer",
                    ControllerName = "Testing",
                    Context = "QA engineers ensure software meets quality standards.",
                    Prerequisites = new List<string> { "Attention to detail", "Basic programming" },
                    CareerPaths = new List<string> { "QA Engineer ($60K-$110K)", "Test Lead ($80K-$140K)" },
                    Steps = new List<RoadmapStep>()
                },

                // Software Architect
                new Roadmap
                {
                    Id = 10,
                    Title = "Software Architect",
                    Description = "Design scalable and maintainable software systems",
                    Icon = "🏗️",
                    Category = CategoryConstants.Architecture,
                    Duration = "12-18 months",
                    Difficulty = "Expert",
                    ActionName = "SoftwareArchitect",
                    ControllerName = "Architecture",
                    Context = "Software architects design high-level software structures.",
                    Prerequisites = new List<string> { "5+ years experience", "System design knowledge" },
                    CareerPaths = new List<string> { "Software Architect ($130K-$200K)", "Principal Engineer ($150K-$250K)" },
                    Steps = new List<RoadmapStep>()
                },

                // Data Engineer
                new Roadmap
                {
                    Id = 12,
                    Title = "Data Engineer",
                    Description = "Build data pipelines and infrastructure",
                    Icon = "🔧",
                    Category = CategoryConstants.DataScience,
                    Duration = "6-8 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "DataEngineer",
                    ControllerName = "DataScience",
                    Context = "Data engineers build the infrastructure for data generation, collection, and storage.",
                    Prerequisites = new List<string> { "SQL knowledge", "Programming skills" },
                    CareerPaths = new List<string> { "Data Engineer ($80K-$150K)", "Big Data Engineer ($90K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                // iOS Developer
                new Roadmap
                {
                    Id = 13,
                    Title = "iOS Developer",
                    Description = "Create native iOS applications with Swift",
                    Icon = "🍎",
                    Category = CategoryConstants.Mobile,
                    Duration = "5-7 months",
                    Difficulty = "Intermediate",
                    ActionName = "IOSDeveloper",
                    ControllerName = "Mobile",
                    Context = "iOS developers create applications for Apple devices.",
                    Prerequisites = new List<string> { "Mac computer", "Basic programming" },
                    CareerPaths = new List<string> { "iOS Developer ($75K-$150K)", "Senior iOS Developer ($120K-$180K)" },
                    Steps = new List<RoadmapStep>()
                },

                // Android Developer
                new Roadmap
                {
                    Id = 14,
                    Title = "Android Developer",
                    Description = "Build Android apps with Kotlin and Java",
                    Icon = "🤖",
                    Category = CategoryConstants.Mobile,
                    Duration = "5-7 months",
                    Difficulty = "Intermediate",
                    ActionName = "AndroidDeveloper",
                    ControllerName = "Mobile",
                    Context = "Android developers create applications for Android devices.",
                    Prerequisites = new List<string> { "Java or Kotlin basics", "OOP concepts" },
                    CareerPaths = new List<string> { "Android Developer ($70K-$140K)", "Senior Android Developer ($110K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                // .NET MAUI Developer
                new Roadmap
                {
                    Id = 17,
                    Title = ".NET MAUI Developer",
                    Description = "Create cross-platform mobile and desktop applications with .NET MAUI",
                    Icon = "📱",
                    Category = CategoryConstants.Mobile,
                    Duration = "4-6 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "NETMAUIDeveloper",
                    ControllerName = "Mobile",
                    Context = ".NET MAUI is Microsoft's framework for building cross-platform native mobile and desktop apps with C# and XAML.",
                    Prerequisites = new List<string> { "C# programming", ".NET fundamentals", "XAML basics" },
                    CareerPaths = new List<string> { ".NET MAUI Developer ($75K-$140K)", "Mobile App Developer ($80K-$150K)", "Cross-Platform Developer ($85K-$160K)" },
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 170,
                            RoadmapId = 17,
                            Title = "MAUI Fundamentals",
                            Duration = "2-3 weeks",
                            Content = "Learn the basics of .NET MAUI development",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 1701,
                                    StepId = 170,
                                    Title = "MAUI Project Structure",
                                    Description = "Understanding .NET MAUI project organization",
                                    Content = "Learn how .NET MAUI projects are structured and organized",
                                    KeyPoints = new List<string> { "Single project approach", "Platform-specific code", "Shared resources", "App lifecycle" }
                                }
                            }
                        }
                    }
                },

                // Azure Developer
                new Roadmap
                {
                    Id = 18,
                    Title = "Azure Cloud Developer",
                    Description = "Master Azure cloud services and .NET integration",
                    Icon = "☁️",
                    Category = CategoryConstants.DevOps,
                    Duration = "6-8 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "AzureDeveloper",
                    ControllerName = "DevOps",
                    Context = "Azure developers build and deploy scalable cloud applications using Microsoft Azure services.",
                    Prerequisites = new List<string> { ".NET Core experience", "Basic cloud concepts", "HTTP/REST APIs" },
                    CareerPaths = new List<string> { "Azure Developer ($85K-$160K)", "Cloud Solutions Architect ($120K-$200K)", "DevOps Engineer ($90K-$170K)" },
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 180,
                            RoadmapId = 18,
                            Title = "Azure Fundamentals",
                            Duration = "3-4 weeks",
                            Content = "Introduction to Microsoft Azure cloud services",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 1801,
                                    StepId = 180,
                                    Title = "Azure Core Services",
                                    Description = "Essential Azure services for developers",
                                    Content = "Learn about the core Azure services used in application development",
                                    KeyPoints = new List<string> { "App Services", "Azure Functions", "Storage Account", "Key Vault", "Application Insights" }
                                }
                            }
                        }
                    }
                },

                // JavaScript Developer
                new Roadmap
                {
                    Id = 19,
                    Title = "JavaScript Developer",
                    Description = "Master modern JavaScript from fundamentals to advanced concepts",
                    Icon = "📜",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "3-4 months",
                    Difficulty = "Beginner to Advanced",
                    ActionName = "JavaScriptDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "JavaScript is the programming language of the web, essential for all frontend development and increasingly important for backend development.",
                    Prerequisites = new List<string> { "Basic computer skills", "HTML/CSS basics" },
                    CareerPaths = new List<string> { "Frontend Developer ($60K-$120K)", "Full Stack Developer ($80K-$150K)", "JavaScript Developer ($70K-$130K)" },
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 190,
                            RoadmapId = 19,
                            Title = "JavaScript Fundamentals",
                            Duration = "3-4 weeks",
                            Content = "Learn core JavaScript concepts and syntax",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 1901,
                                    StepId = 190,
                                    Title = "Variables and Data Types",
                                    Description = "Understanding JavaScript variables and primitive data types",
                                    Content = "Learn about var, let, const and JavaScript's dynamic typing system",
                                    KeyPoints = new List<string> { "Variable declarations", "Primitive types", "Type coercion", "Scope" }
                                }
                            }
                        }
                    }
                },

                // React Developer
                new Roadmap
                {
                    Id = 20,
                    Title = "React Developer",
                    Description = "Build modern user interfaces with React and its ecosystem",
                    Icon = "⚛️",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "4-6 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "ReactDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "React is a popular JavaScript library for building user interfaces, especially single-page applications where you need fast, interactive UIs.",
                    Prerequisites = new List<string> { "JavaScript ES6+", "HTML/CSS", "Basic programming concepts" },
                    CareerPaths = new List<string> { "React Developer ($70K-$140K)", "Frontend Engineer ($80K-$150K)", "Full Stack Developer ($90K-$170K)" },
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 200,
                            RoadmapId = 20,
                            Title = "React Fundamentals",
                            Duration = "3-4 weeks",
                            Content = "Learn the core concepts of React development",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 2001,
                                    StepId = 200,
                                    Title = "Components and JSX",
                                    Description = "Understanding React components and JSX syntax",
                                    Content = "Learn how to create and use React components with JSX",
                                    KeyPoints = new List<string> { "Functional components", "JSX syntax", "Props", "Component composition" }
                                }
                            }
                        }
                    }
                },

                // Angular Developer
                new Roadmap
                {
                    Id = 21,
                    Title = "Angular Developer",
                    Description = "Create enterprise applications with Angular and TypeScript",
                    Icon = "🔺",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "5-7 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "AngularDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "Angular is a platform and framework for building single-page client applications using HTML and TypeScript, developed by Google.",
                    Prerequisites = new List<string> { "JavaScript/TypeScript", "HTML/CSS", "Object-oriented programming" },
                    CareerPaths = new List<string> { "Angular Developer ($75K-$145K)", "Frontend Architect ($100K-$180K)", "Full Stack Developer ($90K-$170K)" },
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 210,
                            RoadmapId = 21,
                            Title = "Angular Fundamentals",
                            Duration = "4-5 weeks",
                            Content = "Learn the core concepts of Angular development",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 2101,
                                    StepId = 210,
                                    Title = "Angular Architecture",
                                    Description = "Understanding Angular's component-based architecture",
                                    Content = "Learn about components, services, modules, and dependency injection",
                                    KeyPoints = new List<string> { "Components", "Services", "Modules", "Dependency Injection" }
                                }
                            }
                        }
                    }
                },

                // Azure DevOps & Git CI/CD
                new Roadmap
                {
                    Id = 22,
                    Title = "Azure DevOps & Git CI/CD",
                    Description = "Master version control, continuous integration, and deployment pipelines",
                    Icon = "🔄",
                    Category = CategoryConstants.DevOps,
                    Duration = "4-6 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "GitCICD",
                    ControllerName = "DevOps",
                    Context = "Learn Git version control, Azure DevOps, and CI/CD pipelines to automate your development workflow and deployments.",
                    Prerequisites = new List<string> { "Basic programming knowledge", "Command line familiarity", "Understanding of software development lifecycle" },
                    CareerPaths = new List<string> { "DevOps Engineer ($80K-$150K)", "Build Engineer ($70K-$130K)", "Release Manager ($85K-$160K)", "Site Reliability Engineer ($90K-$170K)" },
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 220,
                            RoadmapId = 22,
                            Title = "Git Version Control",
                            Duration = "2-3 weeks",
                            Content = "Master Git fundamentals and collaboration workflows",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 2201,
                                    StepId = 220,
                                    Title = "Git Fundamentals",
                                    Description = "Core Git concepts and commands",
                                    Content = "Learn essential Git commands, branching, merging, and repository management",
                                    KeyPoints = new List<string> { "Repository initialization", "Staging and commits", "Branching strategies", "Merge vs Rebase", "Remote repositories" }
                                },
                                new SubTopic
                                {
                                    Id = 2202,
                                    StepId = 220,
                                    Title = "Git Workflows",
                                    Description = "Professional Git workflows and best practices",
                                    Content = "Understand GitFlow, GitHub Flow, and enterprise Git workflows",
                                    KeyPoints = new List<string> { "GitFlow workflow", "Feature branches", "Pull requests", "Code reviews", "Conflict resolution" }
                                }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 221,
                            RoadmapId = 22,
                            Title = "Azure DevOps Fundamentals",
                            Duration = "3-4 weeks",
                            Content = "Learn Azure DevOps services and project management",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 2211,
                                    StepId = 221,
                                    Title = "Azure Repos & Boards",
                                    Description = "Source control and project management in Azure DevOps",
                                    Content = "Set up repositories, manage work items, and track project progress",
                                    KeyPoints = new List<string> { "Azure Repos setup", "Work items", "Boards and sprints", "Branch policies", "Team collaboration" }
                                },
                                new SubTopic
                                {
                                    Id = 2212,
                                    StepId = 221,
                                    Title = "Azure Test Plans",
                                    Description = "Testing and quality assurance with Azure DevOps",
                                    Content = "Create test plans, run automated tests, and track quality metrics",
                                    KeyPoints = new List<string> { "Test cases", "Test suites", "Automated testing", "Test reporting", "Quality gates" }
                                }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 222,
                            RoadmapId = 22,
                            Title = "CI/CD Pipelines",
                            Duration = "4-5 weeks",
                            Content = "Build automated CI/CD pipelines with Azure Pipelines",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 2221,
                                    StepId = 222,
                                    Title = "Build Pipelines",
                                    Description = "Automated build and compilation processes",
                                    Content = "Create build pipelines for .NET applications with automated testing",
                                    KeyPoints = new List<string> { "YAML pipelines", "Build agents", "Build tasks", "Artifact publishing", "Multi-stage builds" }
                                },
                                new SubTopic
                                {
                                    Id = 2222,
                                    StepId = 222,
                                    Title = "Release Pipelines",
                                    Description = "Automated deployment and release management",
                                    Content = "Deploy applications to multiple environments with approval gates",
                                    KeyPoints = new List<string> { "Deployment stages", "Environment approvals", "Variable groups", "Release triggers", "Rollback strategies" }
                                }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 223,
                            RoadmapId = 22,
                            Title = "Advanced DevOps Practices",
                            Duration = "3-4 weeks",
                            Content = "Advanced DevOps concepts and infrastructure as code",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 2231,
                                    StepId = 223,
                                    Title = "Infrastructure as Code",
                                    Description = "Manage infrastructure using code and templates",
                                    Content = "Use ARM templates, Terraform, and Azure Resource Manager for infrastructure automation",
                                    KeyPoints = new List<string> { "ARM templates", "Terraform basics", "Resource groups", "Infrastructure pipelines", "State management" }
                                },
                                new SubTopic
                                {
                                    Id = 2232,
                                    StepId = 223,
                                    Title = "Monitoring & Observability",
                                    Description = "Application monitoring and performance tracking",
                                    Content = "Implement monitoring, logging, and alerting for production applications",
                                    KeyPoints = new List<string> { "Application Insights", "Log Analytics", "Performance counters", "Custom metrics", "Alert rules" }
                                }
                            }
                        }
                    }
                },

                // xUnit Unit Testing
                new Roadmap
                {
                    Id = 23,
                    Title = "xUnit Unit Testing",
                    Description = "Master unit testing with xUnit, mocking, and test-driven development",
                    Icon = "✅",
                    Category = CategoryConstants.Testing,
                    Duration = "3-4 months",
                    Difficulty = "Beginner to Advanced",
                    ActionName = "XUnitTesting",
                    ControllerName = "Testing",
                    Context = "Unit testing is essential for building reliable, maintainable software. xUnit is the most popular testing framework for .NET applications.",
                    Prerequisites = new List<string> { "C# fundamentals", "Basic .NET knowledge", "Understanding of OOP concepts" },
                    CareerPaths = new List<string> { "Software Developer ($70K-$140K)", "QA Engineer ($60K-$120K)", "Test Automation Engineer ($75K-$135K)", "Senior Developer ($90K-$160K)" },
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 230,
                            RoadmapId = 23,
                            Title = "Unit Testing Fundamentals",
                            Duration = "2-3 weeks",
                            Content = "Learn the principles and benefits of unit testing",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 2301,
                                    StepId = 230,
                                    Title = "Testing Principles",
                                    Description = "Core concepts of unit testing and test design",
                                    Content = "Understand the fundamentals of unit testing, test isolation, and the testing pyramid",
                                    KeyPoints = new List<string> { "Test isolation", "Arrange-Act-Assert pattern", "Test naming conventions", "Testing pyramid", "FIRST principles" }
                                },
                                new SubTopic
                                {
                                    Id = 2302,
                                    StepId = 230,
                                    Title = "Test-Driven Development (TDD)",
                                    Description = "Red-Green-Refactor cycle and TDD best practices",
                                    Content = "Master the TDD workflow and understand when and how to apply it effectively",
                                    KeyPoints = new List<string> { "Red-Green-Refactor", "Writing failing tests first", "Minimal implementation", "Refactoring with confidence" }
                                }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 231,
                            RoadmapId = 23,
                            Title = "xUnit Framework Basics",
                            Duration = "3-4 weeks",
                            Content = "Learn xUnit syntax, attributes, and basic test writing",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 2311,
                                    StepId = 231,
                                    Title = "xUnit Test Structure",
                                    Description = "Understanding xUnit test classes and methods",
                                    Content = "Learn how to structure xUnit tests and use core attributes",
                                    KeyPoints = new List<string> { "[Fact] attribute", "[Theory] attribute", "Test class organization", "Test method naming", "Assert methods" }
                                },
                                new SubTopic
                                {
                                    Id = 2312,
                                    StepId = 231,
                                    Title = "Data-Driven Tests",
                                    Description = "Parameterized tests with Theory and InlineData",
                                    Content = "Create flexible tests that run with multiple data sets using Theory and various data sources",
                                    KeyPoints = new List<string> { "[InlineData] attribute", "[MemberData] attribute", "[ClassData] attribute", "Custom data sources", "Test data organization" }
                                }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 232,
                            RoadmapId = 23,
                            Title = "Advanced Testing Concepts",
                            Duration = "4-5 weeks",
                            Content = "Master mocking, test doubles, and advanced testing patterns",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 2321,
                                    StepId = 232,
                                    Title = "Mocking with Moq",
                                    Description = "Create test doubles and mock dependencies",
                                    Content = "Use Moq framework to create mocks, stubs, and verify interactions between objects",
                                    KeyPoints = new List<string> { "Mock creation", "Setup methods", "Verify calls", "Callback functions", "Strict vs loose mocks" }
                                },
                                new SubTopic
                                {
                                    Id = 2322,
                                    StepId = 232,
                                    Title = "Testing Async Code",
                                    Description = "Unit testing asynchronous methods and operations",
                                    Content = "Learn patterns for testing async/await code, handling timing issues, and testing concurrent operations",
                                    KeyPoints = new List<string> { "Testing async methods", "ConfigureAwait in tests", "Task completion", "Testing cancellation tokens", "Avoiding deadlocks" }
                                }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 233,
                            RoadmapId = 23,
                            Title = "Integration & End-to-End Testing",
                            Duration = "3-4 weeks",
                            Content = "Expand testing to integration tests and end-to-end scenarios",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 2331,
                                    StepId = 233,
                                    Title = "ASP.NET Core Testing",
                                    Description = "Testing web APIs and MVC applications",
                                    Content = "Use TestServer and WebApplicationFactory to test ASP.NET Core applications",
                                    KeyPoints = new List<string> { "TestServer setup", "WebApplicationFactory", "Testing controllers", "Testing middleware", "Database testing strategies" }
                                },
                                new SubTopic
                                {
                                    Id = 2332,
                                    StepId = 233,
                                    Title = "Test Organization & CI/CD",
                                    Description = "Organizing tests and integrating with build pipelines",
                                    Content = "Structure test projects, configure test execution, and integrate with continuous integration",
                                    KeyPoints = new List<string> { "Test project organization", "Test categories", "Parallel test execution", "Test reporting", "CI/CD integration" }
                                }
                            }
                        }
                    }
                },

                // Azure Developer
                new Roadmap
                {
                    Id = 24,
                    Title = "Azure Developer",
                    Description = "Master Microsoft Azure cloud platform for building, deploying, and managing applications",
                    Icon = "☁️",
                    Category = CategoryConstants.DevOps,
                    Duration = "4-6 months",
                    Difficulty = "Beginner to Advanced",
                    ActionName = "AzureCloudDeveloper",
                    ControllerName = "DevOps",
                    Context = "Microsoft Azure is one of the leading cloud platforms, offering a comprehensive suite of cloud services for building, testing, deploying, and managing applications.",
                    Prerequisites = new List<string> 
                    { 
                        "Basic programming knowledge (C#, Python, or JavaScript)",
                        "Understanding of web technologies",
                        "Basic networking concepts",
                        "Familiarity with databases"
                    },
                    CareerPaths = new List<string> 
                    { 
                        "Azure Developer ($80K-$150K)",
                        "Cloud Solutions Architect ($100K-$180K)",
                        "DevOps Engineer ($85K-$160K)",
                        "Cloud Security Engineer ($95K-$170K)"
                    },
                    Steps = new List<RoadmapStep>
                    {
                        new RoadmapStep
                        {
                            Id = 240,
                            RoadmapId = 24,
                            Title = "Azure Fundamentals",
                            Duration = "2-3 weeks",
                            Content = "Learn the core concepts of Microsoft Azure",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 2401,
                                    StepId = 240,
                                    Title = "Azure Architecture & Services",
                                    Description = "Understanding Azure's global infrastructure",
                                    Content = "Learn about Azure regions, availability zones, and core services",
                                    KeyPoints = new List<string> 
                                    { 
                                        "Azure regions and geography",
                                        "Availability zones and sets",
                                        "Resource groups and subscriptions",
                                        "Azure Resource Manager (ARM)",
                                        "Azure Portal navigation"
                                    }
                                },
                                new SubTopic
                                {
                                    Id = 2402,
                                    StepId = 240,
                                    Title = "Azure Identity & Security",
                                    Description = "Secure access to Azure resources",
                                    Content = "Master Azure Active Directory and security fundamentals",
                                    KeyPoints = new List<string> 
                                    { 
                                        "Azure Active Directory basics",
                                        "Authentication and authorization",
                                        "Role-Based Access Control (RBAC)",
                                        "Managed identities",
                                        "Azure Key Vault"
                                    }
                                }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 241,
                            RoadmapId = 24,
                            Title = "Azure Compute Services",
                            Duration = "3-4 weeks",
                            Content = "Master Azure compute options for running applications",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 2411,
                                    StepId = 241,
                                    Title = "Azure Virtual Machines",
                                    Description = "Deploy and manage VMs in Azure",
                                    Content = "Learn to create, configure, and manage Azure VMs",
                                    KeyPoints = new List<string> 
                                    { 
                                        "VM sizes and families",
                                        "VM creation and configuration",
                                        "Availability sets and scale sets",
                                        "VM extensions and automation",
                                        "Cost optimization"
                                    }
                                },
                                new SubTopic
                                {
                                    Id = 2412,
                                    StepId = 241,
                                    Title = "Azure App Service",
                                    Description = "PaaS for web applications",
                                    Content = "Build and deploy web apps using Azure App Service",
                                    KeyPoints = new List<string> 
                                    { 
                                        "Web Apps deployment",
                                        "App Service plans",
                                        "Deployment slots",
                                        "Custom domains and SSL",
                                        "Continuous deployment"
                                    }
                                }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 242,
                            RoadmapId = 24,
                            Title = "Azure Storage & Data Services",
                            Duration = "3-4 weeks",
                            Content = "Work with Azure storage solutions and databases",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 2421,
                                    StepId = 242,
                                    Title = "Azure Storage Services",
                                    Description = "Master Azure storage options",
                                    Content = "Learn about different storage types and their use cases",
                                    KeyPoints = new List<string> 
                                    { 
                                        "Blob storage",
                                        "File storage",
                                        "Queue storage",
                                        "Table storage",
                                        "Storage security and access"
                                    }
                                },
                                new SubTopic
                                {
                                    Id = 2422,
                                    StepId = 242,
                                    Title = "Azure Databases",
                                    Description = "Managed database services in Azure",
                                    Content = "Deploy and manage databases in Azure",
                                    KeyPoints = new List<string> 
                                    { 
                                        "Azure SQL Database",
                                        "Cosmos DB",
                                        "Azure Database for PostgreSQL/MySQL",
                                        "Azure Cache for Redis",
                                        "Database security and backup"
                                    }
                                }
                            }
                        },
                        new RoadmapStep
                        {
                            Id = 243,
                            RoadmapId = 24,
                            Title = "Azure DevOps & Monitoring",
                            Duration = "3-4 weeks",
                            Content = "Implement DevOps practices and monitoring in Azure",
                            SubTopics = new List<SubTopic>
                            {
                                new SubTopic
                                {
                                    Id = 2431,
                                    StepId = 243,
                                    Title = "Azure DevOps Services",
                                    Description = "CI/CD with Azure DevOps",
                                    Content = "Build continuous integration and deployment pipelines",
                                    KeyPoints = new List<string> 
                                    { 
                                        "Azure Repos",
                                        "Azure Pipelines",
                                        "Azure Artifacts",
                                        "Azure Test Plans",
                                        "Release management"
                                    }
                                },
                                new SubTopic
                                {
                                    Id = 2432,
                                    StepId = 243,
                                    Title = "Azure Monitoring",
                                    Description = "Monitor and troubleshoot Azure applications",
                                    Content = "Implement comprehensive monitoring solutions",
                                    KeyPoints = new List<string> 
                                    { 
                                        "Azure Monitor",
                                        "Application Insights",
                                        "Log Analytics",
                                        "Alerts and notifications",
                                        "Azure Dashboard"
                                    }
                                }
                            }
                        }
                    }
                },

                // New Extended Roadmaps - Web Development Category
                new Roadmap
                {
                    Id = 25,
                    Title = "Vue.js Developer",
                    Description = "Build progressive web applications with Vue.js framework",
                    Icon = "💚",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate",
                    ActionName = "VueJSDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "Vue.js is a progressive JavaScript framework for building user interfaces, known for its gentle learning curve.",
                    Prerequisites = new List<string> { "JavaScript ES6+", "HTML/CSS", "Basic programming concepts" },
                    CareerPaths = new List<string> { "Vue.js Developer ($65K-$130K)", "Frontend Engineer ($75K-$140K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 26,
                    Title = "TypeScript Developer",
                    Description = "Master TypeScript for type-safe JavaScript development",
                    Icon = "🔷",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "2-3 months",
                    Difficulty = "Intermediate",
                    ActionName = "TypeScriptDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "TypeScript adds static typing to JavaScript, improving code quality and developer productivity.",
                    Prerequisites = new List<string> { "JavaScript proficiency", "Basic OOP concepts" },
                    CareerPaths = new List<string> { "TypeScript Developer ($75K-$140K)", "Senior Frontend Developer ($90K-$160K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 27,
                    Title = "Node.js Developer",
                    Description = "Build scalable backend applications with Node.js",
                    Icon = "🟢",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "5-6 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "NodeJSDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "Node.js enables JavaScript on the server-side, perfect for building fast, scalable network applications.",
                    Prerequisites = new List<string> { "JavaScript expertise", "Basic server concepts" },
                    CareerPaths = new List<string> { "Node.js Developer ($70K-$140K)", "Full Stack Developer ($80K-$150K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 28,
                    Title = "GraphQL Developer",
                    Description = "Master GraphQL for efficient API development",
                    Icon = "🔷",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "3-4 months",
                    Difficulty = "Advanced",
                    ActionName = "GraphQLDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "GraphQL provides a more efficient, powerful and flexible alternative to REST APIs.",
                    Prerequisites = new List<string> { "API development experience", "JavaScript/TypeScript" },
                    CareerPaths = new List<string> { "API Developer ($75K-$145K)", "Backend Architect ($100K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 29,
                    Title = "Next.js Developer",
                    Description = "Build production-ready React applications with Next.js",
                    Icon = "⚡",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "NextJSDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "Next.js is the React framework for production, offering server-side rendering and static generation.",
                    Prerequisites = new List<string> { "React proficiency", "JavaScript ES6+" },
                    CareerPaths = new List<string> { "Next.js Developer ($80K-$150K)", "Senior React Developer ($90K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 30,
                    Title = "Svelte Developer",
                    Description = "Learn the compile-time framework that writes less code",
                    Icon = "🟠",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    ActionName = "SvelteDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "Svelte shifts work from runtime to compile-time, resulting in faster applications.",
                    Prerequisites = new List<string> { "JavaScript fundamentals", "HTML/CSS" },
                    CareerPaths = new List<string> { "Svelte Developer ($70K-$135K)", "Frontend Developer ($75K-$140K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 31,
                    Title = "Web Components Developer",
                    Description = "Create reusable custom elements with Web Components",
                    Icon = "🧩",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "3-4 months",
                    Difficulty = "Advanced",
                    ActionName = "WebComponentsDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "Web Components let you create reusable custom elements with encapsulated functionality.",
                    Prerequisites = new List<string> { "Advanced JavaScript", "DOM manipulation" },
                    CareerPaths = new List<string> { "Component Library Developer ($80K-$145K)", "UI Architect ($90K-$160K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 32,
                    Title = "PWA Developer",
                    Description = "Build Progressive Web Apps that work offline",
                    Icon = "📱",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "PWADeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "Progressive Web Apps combine the best of web and mobile apps with offline capabilities.",
                    Prerequisites = new List<string> { "Web development basics", "JavaScript proficiency" },
                    CareerPaths = new List<string> { "PWA Developer ($75K-$140K)", "Mobile Web Developer ($80K-$150K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 33,
                    Title = "WebAssembly Developer",
                    Description = "Run high-performance applications in the browser",
                    Icon = "🚀",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "4-5 months",
                    Difficulty = "Expert",
                    ActionName = "WebAssemblyDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "WebAssembly enables near-native performance for web applications.",
                    Prerequisites = new List<string> { "C/C++ or Rust", "Web development", "Systems programming" },
                    CareerPaths = new List<string> { "WebAssembly Engineer ($90K-$170K)", "Performance Engineer ($100K-$180K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 34,
                    Title = "Jamstack Developer",
                    Description = "Build fast and secure sites with Jamstack architecture",
                    Icon = "🏗️",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    ActionName = "JamstackDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "Jamstack architecture delivers better performance, security, and developer experience.",
                    Prerequisites = new List<string> { "JavaScript", "Git", "API basics" },
                    CareerPaths = new List<string> { "Jamstack Developer ($70K-$140K)", "Frontend Architect ($85K-$160K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 35,
                    Title = "Micro Frontend Developer",
                    Description = "Architect scalable applications with micro frontends",
                    Icon = "🔲",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "4-5 months",
                    Difficulty = "Expert",
                    ActionName = "MicroFrontendDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "Micro frontends bring microservice principles to frontend development.",
                    Prerequisites = new List<string> { "Frontend frameworks", "Architecture patterns", "DevOps basics" },
                    CareerPaths = new List<string> { "Frontend Architect ($100K-$180K)", "Technical Lead ($110K-$190K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 36,
                    Title = "PHP Laravel Developer",
                    Description = "Build modern web applications with PHP and Laravel",
                    Icon = "🐘",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate",
                    ActionName = "PHPLaravelDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "Laravel is the most popular PHP framework for building elegant web applications.",
                    Prerequisites = new List<string> { "PHP basics", "MySQL", "Web fundamentals" },
                    CareerPaths = new List<string> { "PHP Developer ($60K-$120K)", "Laravel Developer ($65K-$130K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 37,
                    Title = "Python Django Developer",
                    Description = "Build secure web applications with Python and Django",
                    Icon = "🐍",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "5-6 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "PythonDjangoDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "Django is a high-level Python framework that encourages rapid development.",
                    Prerequisites = new List<string> { "Python programming", "Web concepts", "Database basics" },
                    CareerPaths = new List<string> { "Django Developer ($70K-$140K)", "Python Full Stack ($80K-$150K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 38,
                    Title = "Ruby on Rails Developer",
                    Description = "Build web applications with Ruby on Rails",
                    Icon = "💎",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "5-6 months",
                    Difficulty = "Intermediate",
                    ActionName = "RubyOnRailsDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "Ruby on Rails emphasizes convention over configuration for rapid development.",
                    Prerequisites = new List<string> { "Ruby basics", "MVC pattern", "Web fundamentals" },
                    CareerPaths = new List<string> { "Rails Developer ($70K-$140K)", "Ruby Engineer ($75K-$145K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 39,
                    Title = "Java Spring Developer",
                    Description = "Build enterprise applications with Spring Framework",
                    Icon = "🍃",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "6-7 months",
                    Difficulty = "Advanced",
                    ActionName = "JavaSpringDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "Spring is the most popular Java framework for building enterprise applications.",
                    Prerequisites = new List<string> { "Java proficiency", "OOP concepts", "Web services" },
                    CareerPaths = new List<string> { "Spring Developer ($80K-$150K)", "Java Architect ($100K-$180K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 40,
                    Title = "Golang Developer",
                    Description = "Build high-performance applications with Go",
                    Icon = "🐹",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "GolangDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "Go is perfect for building scalable web services and cloud-native applications.",
                    Prerequisites = new List<string> { "Programming experience", "Concurrency concepts" },
                    CareerPaths = new List<string> { "Go Developer ($85K-$160K)", "Backend Engineer ($90K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 41,
                    Title = "Rust Web Developer",
                    Description = "Build blazing fast web services with Rust",
                    Icon = "🦀",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "5-6 months",
                    Difficulty = "Expert",
                    ActionName = "RustWebDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "Rust offers memory safety and performance for web development.",
                    Prerequisites = new List<string> { "Systems programming", "Memory management concepts" },
                    CareerPaths = new List<string> { "Rust Developer ($90K-$170K)", "Systems Engineer ($95K-$180K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 42,
                    Title = "Elixir Phoenix Developer",
                    Description = "Build fault-tolerant applications with Elixir and Phoenix",
                    Icon = "💜",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "ElixirPhoenixDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "Elixir and Phoenix enable building highly concurrent, fault-tolerant applications.",
                    Prerequisites = new List<string> { "Functional programming basics", "Web development" },
                    CareerPaths = new List<string> { "Elixir Developer ($80K-$150K)", "Distributed Systems Engineer ($90K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 43,
                    Title = "API Design Expert",
                    Description = "Master the art of designing robust and scalable APIs",
                    Icon = "🔌",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "3-4 months",
                    Difficulty = "Advanced",
                    ActionName = "APIDesignExpert",
                    ControllerName = "WebDevelopment",
                    Context = "Well-designed APIs are crucial for modern software architecture.",
                    Prerequisites = new List<string> { "HTTP/REST knowledge", "Backend development", "Security basics" },
                    CareerPaths = new List<string> { "API Architect ($90K-$160K)", "Platform Engineer ($95K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 44,
                    Title = "WebRTC Developer",
                    Description = "Build real-time communication applications",
                    Icon = "📹",
                    Category = CategoryConstants.WebDevelopment,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "WebRTCDeveloper",
                    ControllerName = "WebDevelopment",
                    Context = "WebRTC enables peer-to-peer communication in web browsers.",
                    Prerequisites = new List<string> { "JavaScript expertise", "Networking concepts", "Media streaming" },
                    CareerPaths = new List<string> { "WebRTC Developer ($85K-$160K)", "Real-time Systems Engineer ($90K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                // Mobile Development Extended Roadmaps
                new Roadmap
                {
                    Id = 45,
                    Title = "React Native Developer",
                    Description = "Build cross-platform mobile apps with React Native",
                    Icon = "⚛️",
                    Category = CategoryConstants.Mobile,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate",
                    ActionName = "ReactNativeDeveloper",
                    ControllerName = "Mobile",
                    Context = "React Native enables building native mobile apps using React.",
                    Prerequisites = new List<string> { "React knowledge", "JavaScript ES6+", "Mobile concepts" },
                    CareerPaths = new List<string> { "React Native Developer ($75K-$145K)", "Mobile Engineer ($80K-$150K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 46,
                    Title = "Flutter Developer",
                    Description = "Create beautiful native apps with Flutter and Dart",
                    Icon = "🦋",
                    Category = CategoryConstants.Mobile,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate",
                    ActionName = "FlutterDeveloper",
                    ControllerName = "Mobile",
                    Context = "Flutter is Google's UI toolkit for building native applications from a single codebase.",
                    Prerequisites = new List<string> { "Programming basics", "OOP concepts", "Mobile design" },
                    CareerPaths = new List<string> { "Flutter Developer ($70K-$140K)", "Cross-platform Developer ($75K-$145K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 47,
                    Title = "Swift iOS Developer",
                    Description = "Master native iOS development with Swift",
                    Icon = "🍏",
                    Category = CategoryConstants.Mobile,
                    Duration = "5-6 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "SwiftiOSDeveloper",
                    ControllerName = "Mobile",
                    Context = "Swift is Apple's powerful and intuitive programming language for iOS development.",
                    Prerequisites = new List<string> { "Mac computer", "Programming fundamentals", "iOS basics" },
                    CareerPaths = new List<string> { "iOS Developer ($80K-$160K)", "Senior iOS Engineer ($100K-$180K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 48,
                    Title = "Kotlin Android Developer",
                    Description = "Build modern Android apps with Kotlin",
                    Icon = "🤖",
                    Category = CategoryConstants.Mobile,
                    Duration = "5-6 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "KotlinAndroidDeveloper",
                    ControllerName = "Mobile",
                    Context = "Kotlin is the preferred language for Android development, offering modern features and safety.",
                    Prerequisites = new List<string> { "Java basics", "Android Studio", "Mobile concepts" },
                    CareerPaths = new List<string> { "Android Developer ($75K-$150K)", "Senior Android Engineer ($95K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 49,
                    Title = "Xamarin Developer",
                    Description = "Build native apps for multiple platforms with C# and Xamarin",
                    Icon = "📱",
                    Category = CategoryConstants.Mobile,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate",
                    ActionName = "XamarinDeveloper",
                    ControllerName = "Mobile",
                    Context = "Xamarin allows building native mobile apps using C# and .NET.",
                    Prerequisites = new List<string> { "C# proficiency", ".NET knowledge", "Mobile basics" },
                    CareerPaths = new List<string> { "Xamarin Developer ($70K-$140K)", ".NET Mobile Developer ($75K-$145K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 50,
                    Title = "Ionic Developer",
                    Description = "Build hybrid mobile apps with web technologies",
                    Icon = "⚡",
                    Category = CategoryConstants.Mobile,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    ActionName = "IonicDeveloper",
                    ControllerName = "Mobile",
                    Context = "Ionic enables building mobile apps using web technologies like HTML, CSS, and JavaScript.",
                    Prerequisites = new List<string> { "Web development", "Angular/React/Vue", "Mobile concepts" },
                    CareerPaths = new List<string> { "Ionic Developer ($65K-$130K)", "Hybrid App Developer ($70K-$135K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 51,
                    Title = "Mobile Game Developer",
                    Description = "Create engaging mobile games with Unity",
                    Icon = "🎮",
                    Category = CategoryConstants.Mobile,
                    Duration = "6-8 months",
                    Difficulty = "Advanced",
                    ActionName = "MobileGameDeveloper",
                    ControllerName = "Mobile",
                    Context = "Mobile game development combines programming skills with game design principles.",
                    Prerequisites = new List<string> { "C# programming", "Mathematics basics", "Game design interest" },
                    CareerPaths = new List<string> { "Mobile Game Developer ($70K-$140K)", "Unity Developer ($75K-$150K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 52,
                    Title = "AR/VR Mobile Developer",
                    Description = "Build augmented and virtual reality mobile experiences",
                    Icon = "🥽",
                    Category = CategoryConstants.Mobile,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "ARVRMobileDeveloper",
                    ControllerName = "Mobile",
                    Context = "AR/VR technologies are transforming mobile experiences across industries.",
                    Prerequisites = new List<string> { "3D mathematics", "Mobile development", "Graphics programming" },
                    CareerPaths = new List<string> { "AR/VR Developer ($80K-$160K)", "XR Engineer ($85K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 53,
                    Title = "Mobile Security Specialist",
                    Description = "Secure mobile applications against threats",
                    Icon = "🔐",
                    Category = CategoryConstants.Mobile,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "MobileSecuritySpecialist",
                    ControllerName = "Mobile",
                    Context = "Mobile security is critical for protecting user data and preventing attacks.",
                    Prerequisites = new List<string> { "Mobile development", "Security concepts", "Cryptography basics" },
                    CareerPaths = new List<string> { "Mobile Security Engineer ($85K-$160K)", "Security Architect ($95K-$175K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 54,
                    Title = "Mobile DevOps Engineer",
                    Description = "Automate mobile app deployment and testing",
                    Icon = "🔄",
                    Category = CategoryConstants.Mobile,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "MobileDevOpsEngineer",
                    ControllerName = "Mobile",
                    Context = "Mobile DevOps streamlines the development, testing, and deployment of mobile apps.",
                    Prerequisites = new List<string> { "Mobile development", "CI/CD concepts", "Scripting" },
                    CareerPaths = new List<string> { "Mobile DevOps Engineer ($80K-$155K)", "Release Engineer ($85K-$160K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 55,
                    Title = "Mobile Performance Engineer",
                    Description = "Optimize mobile app performance and battery life",
                    Icon = "⚡",
                    Category = CategoryConstants.Mobile,
                    Duration = "3-4 months",
                    Difficulty = "Advanced",
                    ActionName = "MobilePerformanceEngineer",
                    ControllerName = "Mobile",
                    Context = "Performance optimization is crucial for mobile app success and user retention.",
                    Prerequisites = new List<string> { "Mobile development", "Profiling tools", "System architecture" },
                    CareerPaths = new List<string> { "Performance Engineer ($85K-$160K)", "Mobile Architect ($95K-$175K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 56,
                    Title = "Mobile UI/UX Designer",
                    Description = "Design intuitive mobile user experiences",
                    Icon = "🎨",
                    Category = CategoryConstants.Mobile,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate",
                    ActionName = "MobileUIUXDesigner",
                    ControllerName = "Mobile",
                    Context = "Great mobile UI/UX is essential for app success and user satisfaction.",
                    Prerequisites = new List<string> { "Design principles", "Mobile patterns", "User research" },
                    CareerPaths = new List<string> { "Mobile UI/UX Designer ($70K-$140K)", "Product Designer ($80K-$150K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 57,
                    Title = "Mobile Backend Developer",
                    Description = "Build scalable backends for mobile applications",
                    Icon = "☁️",
                    Category = CategoryConstants.Mobile,
                    Duration = "5-6 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "MobileBackendDeveloper",
                    ControllerName = "Mobile",
                    Context = "Mobile backends handle data synchronization, push notifications, and user management.",
                    Prerequisites = new List<string> { "Backend development", "API design", "Cloud services" },
                    CareerPaths = new List<string> { "Mobile Backend Developer ($75K-$145K)", "Backend Engineer ($80K-$155K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 58,
                    Title = "Mobile Analytics Engineer",
                    Description = "Implement analytics and data tracking for mobile apps",
                    Icon = "📊",
                    Category = CategoryConstants.Mobile,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    ActionName = "MobileAnalyticsEngineer",
                    ControllerName = "Mobile",
                    Context = "Mobile analytics provide insights into user behavior and app performance.",
                    Prerequisites = new List<string> { "Mobile development", "Analytics tools", "Data analysis" },
                    CareerPaths = new List<string> { "Analytics Engineer ($75K-$145K)", "Data Engineer ($80K-$150K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 59,
                    Title = "Mobile Automation Tester",
                    Description = "Automate testing for mobile applications",
                    Icon = "🤖",
                    Category = CategoryConstants.Mobile,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    ActionName = "MobileAutomationTester",
                    ControllerName = "Mobile",
                    Context = "Automated testing ensures mobile app quality across devices and platforms.",
                    Prerequisites = new List<string> { "Testing concepts", "Mobile basics", "Scripting" },
                    CareerPaths = new List<string> { "Mobile QA Engineer ($65K-$125K)", "Test Automation Lead ($75K-$140K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 60,
                    Title = "Mobile Accessibility Specialist",
                    Description = "Make mobile apps accessible to all users",
                    Icon = "♿",
                    Category = CategoryConstants.Mobile,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    ActionName = "MobileAccessibilitySpecialist",
                    ControllerName = "Mobile",
                    Context = "Accessibility ensures mobile apps can be used by people with disabilities.",
                    Prerequisites = new List<string> { "Mobile development", "Accessibility guidelines", "Testing tools" },
                    CareerPaths = new List<string> { "Accessibility Engineer ($70K-$135K)", "Inclusive Design Lead ($80K-$145K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 61,
                    Title = "Mobile Commerce Developer",
                    Description = "Build mobile e-commerce applications",
                    Icon = "🛒",
                    Category = CategoryConstants.Mobile,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "MobileCommerceDeveloper",
                    ControllerName = "Mobile",
                    Context = "Mobile commerce is revolutionizing how people shop and make payments.",
                    Prerequisites = new List<string> { "Mobile development", "Payment systems", "Security" },
                    CareerPaths = new List<string> { "M-Commerce Developer ($75K-$145K)", "Payment Systems Engineer ($80K-$155K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 62,
                    Title = "Mobile AI/ML Engineer",
                    Description = "Integrate AI and machine learning into mobile apps",
                    Icon = "🤖",
                    Category = CategoryConstants.Mobile,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "MobileAIMLEngineer",
                    ControllerName = "Mobile",
                    Context = "On-device AI enables intelligent features while preserving user privacy.",
                    Prerequisites = new List<string> { "Mobile development", "ML basics", "Mathematics" },
                    CareerPaths = new List<string> { "Mobile ML Engineer ($85K-$165K)", "AI Mobile Developer ($90K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 63,
                    Title = "Mobile IoT Developer",
                    Description = "Connect mobile apps with IoT devices",
                    Icon = "📡",
                    Category = CategoryConstants.Mobile,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "MobileIoTDeveloper",
                    ControllerName = "Mobile",
                    Context = "Mobile apps serve as the primary interface for IoT devices and smart home systems.",
                    Prerequisites = new List<string> { "Mobile development", "Networking", "IoT protocols" },
                    CareerPaths = new List<string> { "IoT Mobile Developer ($75K-$150K)", "Connected Systems Engineer ($80K-$160K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 64,
                    Title = "Mobile Blockchain Developer",
                    Description = "Build blockchain-powered mobile applications",
                    Icon = "⛓️",
                    Category = CategoryConstants.Mobile,
                    Duration = "5-6 months",
                    Difficulty = "Expert",
                    ActionName = "MobileBlockchainDeveloper",
                    ControllerName = "Mobile",
                    Context = "Blockchain technology enables secure, decentralized mobile applications.",
                    Prerequisites = new List<string> { "Mobile development", "Blockchain concepts", "Cryptography" },
                    CareerPaths = new List<string> { "Blockchain Mobile Developer ($85K-$170K)", "DApp Developer ($90K-$180K)" },
                    Steps = new List<RoadmapStep>()
                },

                // Data Science & AI Extended Roadmaps
                new Roadmap
                {
                    Id = 65,
                    Title = "AI Engineer",
                    Description = "Build and deploy artificial intelligence systems",
                    Icon = "🧠",
                    Category = CategoryConstants.DataScience,
                    Duration = "8-10 months",
                    Difficulty = "Advanced",
                    ActionName = "AIEngineer",
                    ControllerName = "DataScience",
                    Context = "AI Engineers bridge the gap between AI research and practical applications.",
                    Prerequisites = new List<string> { "Python proficiency", "ML knowledge", "Software engineering" },
                    CareerPaths = new List<string> { "AI Engineer ($100K-$180K)", "ML Platform Engineer ($110K-$190K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 66,
                    Title = "Computer Vision Engineer",
                    Description = "Develop systems that understand visual information",
                    Icon = "👁️",
                    Category = CategoryConstants.DataScience,
                    Duration = "6-8 months",
                    Difficulty = "Advanced",
                    ActionName = "ComputerVisionEngineer",
                    ControllerName = "DataScience",
                    Context = "Computer vision enables machines to interpret and understand visual information.",
                    Prerequisites = new List<string> { "Python/C++", "Linear algebra", "Image processing" },
                    CareerPaths = new List<string> { "CV Engineer ($90K-$170K)", "Vision Research Engineer ($95K-$180K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 67,
                    Title = "NLP Engineer",
                    Description = "Build systems that understand human language",
                    Icon = "💬",
                    Category = CategoryConstants.DataScience,
                    Duration = "6-8 months",
                    Difficulty = "Advanced",
                    ActionName = "NLPEngineer",
                    ControllerName = "DataScience",
                    Context = "Natural Language Processing enables machines to understand and generate human language.",
                    Prerequisites = new List<string> { "Python", "Linguistics basics", "Deep learning" },
                    CareerPaths = new List<string> { "NLP Engineer ($95K-$175K)", "Language AI Developer ($100K-$185K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 68,
                    Title = "MLOps Engineer",
                    Description = "Deploy and maintain ML models in production",
                    Icon = "🔧",
                    Category = CategoryConstants.DataScience,
                    Duration = "5-7 months",
                    Difficulty = "Advanced",
                    ActionName = "MLOpsEngineer",
                    ControllerName = "DataScience",
                    Context = "MLOps combines ML, DevOps, and data engineering to deliver ML solutions at scale.",
                    Prerequisites = new List<string> { "ML basics", "DevOps", "Cloud platforms" },
                    CareerPaths = new List<string> { "MLOps Engineer ($95K-$170K)", "ML Infrastructure Engineer ($100K-$180K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 69,
                    Title = "Data Analytics Engineer",
                    Description = "Transform data into actionable insights",
                    Icon = "📈",
                    Category = CategoryConstants.DataScience,
                    Duration = "4-6 months",
                    Difficulty = "Intermediate",
                    ActionName = "DataAnalyticsEngineer",
                    ControllerName = "DataScience",
                    Context = "Data analytics engineers build systems to analyze and visualize complex data.",
                    Prerequisites = new List<string> { "SQL", "Python/R", "Statistics" },
                    CareerPaths = new List<string> { "Analytics Engineer ($75K-$140K)", "BI Developer ($80K-$145K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 70,
                    Title = "Big Data Engineer",
                    Description = "Process and analyze massive datasets",
                    Icon = "🗄️",
                    Category = CategoryConstants.DataScience,
                    Duration = "6-8 months",
                    Difficulty = "Advanced",
                    ActionName = "BigDataEngineer",
                    ControllerName = "DataScience",
                    Context = "Big Data engineers build infrastructure to handle petabyte-scale data processing.",
                    Prerequisites = new List<string> { "Distributed systems", "Spark/Hadoop", "Cloud platforms" },
                    CareerPaths = new List<string> { "Big Data Engineer ($90K-$170K)", "Data Platform Engineer ($95K-$180K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 71,
                    Title = "Business Intelligence Developer",
                    Description = "Create data-driven business solutions",
                    Icon = "💼",
                    Category = CategoryConstants.DataScience,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate",
                    ActionName = "BIDeeveloper",
                    ControllerName = "DataScience",
                    Context = "BI developers create tools and systems for business decision-making.",
                    Prerequisites = new List<string> { "SQL expertise", "Data modeling", "Visualization tools" },
                    CareerPaths = new List<string> { "BI Developer ($70K-$135K)", "BI Architect ($85K-$155K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 72,
                    Title = "Deep Learning Engineer",
                    Description = "Build advanced neural network systems",
                    Icon = "🧬",
                    Category = CategoryConstants.DataScience,
                    Duration = "7-9 months",
                    Difficulty = "Expert",
                    ActionName = "DeepLearningEngineer",
                    ControllerName = "DataScience",
                    Context = "Deep Learning engineers create sophisticated AI models for complex problems.",
                    Prerequisites = new List<string> { "Neural networks", "Python", "GPU programming" },
                    CareerPaths = new List<string> { "DL Engineer ($100K-$185K)", "AI Research Engineer ($110K-$200K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 73,
                    Title = "Reinforcement Learning Engineer",
                    Description = "Build AI agents that learn through interaction",
                    Icon = "🎮",
                    Category = CategoryConstants.DataScience,
                    Duration = "6-8 months",
                    Difficulty = "Expert",
                    ActionName = "RLEngineer",
                    ControllerName = "DataScience",
                    Context = "RL engineers create AI systems that learn optimal behaviors through trial and error.",
                    Prerequisites = new List<string> { "ML foundations", "Probability theory", "Python" },
                    CareerPaths = new List<string> { "RL Engineer ($95K-$180K)", "AI Research Scientist ($105K-$195K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 74,
                    Title = "Quantitative Analyst",
                    Description = "Apply data science to financial markets",
                    Icon = "💹",
                    Category = CategoryConstants.DataScience,
                    Duration = "6-8 months",
                    Difficulty = "Advanced",
                    ActionName = "QuantitativeAnalyst",
                    ControllerName = "DataScience",
                    Context = "Quants use mathematical models to analyze financial markets and securities.",
                    Prerequisites = new List<string> { "Mathematics", "Statistics", "Programming" },
                    CareerPaths = new List<string> { "Quant Analyst ($90K-$200K)", "Quant Developer ($100K-$250K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 75,
                    Title = "Bioinformatics Specialist",
                    Description = "Apply data science to biological data",
                    Icon = "🧬",
                    Category = CategoryConstants.DataScience,
                    Duration = "6-8 months",
                    Difficulty = "Advanced",
                    ActionName = "BioinformaticsSpecialist",
                    ControllerName = "DataScience",
                    Context = "Bioinformatics combines biology, computer science, and data analysis.",
                    Prerequisites = new List<string> { "Biology basics", "Programming", "Statistics" },
                    CareerPaths = new List<string> { "Bioinformatics Analyst ($70K-$140K)", "Computational Biologist ($80K-$160K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 76,
                    Title = "Time Series Analyst",
                    Description = "Analyze and forecast temporal data",
                    Icon = "⏰",
                    Category = CategoryConstants.DataScience,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "TimeSeriesAnalyst",
                    ControllerName = "DataScience",
                    Context = "Time series analysis is crucial for forecasting and understanding temporal patterns.",
                    Prerequisites = new List<string> { "Statistics", "Python/R", "Mathematical modeling" },
                    CareerPaths = new List<string> { "Time Series Analyst ($75K-$145K)", "Forecasting Specialist ($80K-$155K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 77,
                    Title = "Recommendation Systems Engineer",
                    Description = "Build personalized recommendation engines",
                    Icon = "🎯",
                    Category = CategoryConstants.DataScience,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "RecommendationSystemsEngineer",
                    ControllerName = "DataScience",
                    Context = "Recommendation systems power personalized experiences in e-commerce and content platforms.",
                    Prerequisites = new List<string> { "ML algorithms", "Collaborative filtering", "Python" },
                    CareerPaths = new List<string> { "RecSys Engineer ($85K-$165K)", "Personalization Engineer ($90K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 78,
                    Title = "Data Visualization Specialist",
                    Description = "Create compelling data stories through visualization",
                    Icon = "📊",
                    Category = CategoryConstants.DataScience,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    ActionName = "DataVisualizationSpecialist",
                    ControllerName = "DataScience",
                    Context = "Data visualization makes complex data accessible and actionable for decision-makers.",
                    Prerequisites = new List<string> { "Design principles", "Statistics", "Visualization tools" },
                    CareerPaths = new List<string> { "Data Viz Specialist ($70K-$135K)", "Analytics Designer ($75K-$145K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 79,
                    Title = "AI Ethics Specialist",
                    Description = "Ensure responsible AI development and deployment",
                    Icon = "⚖️",
                    Category = CategoryConstants.DataScience,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "AIEthicsSpecialist",
                    ControllerName = "DataScience",
                    Context = "AI ethics ensures fairness, transparency, and accountability in AI systems.",
                    Prerequisites = new List<string> { "AI/ML knowledge", "Ethics", "Policy understanding" },
                    CareerPaths = new List<string> { "AI Ethics Specialist ($80K-$150K)", "Responsible AI Lead ($90K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 80,
                    Title = "Generative AI Developer",
                    Description = "Build creative AI systems using generative models",
                    Icon = "🎨",
                    Category = CategoryConstants.DataScience,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "GenerativeAIDeveloper",
                    ControllerName = "DataScience",
                    Context = "Generative AI creates new content including text, images, music, and code.",
                    Prerequisites = new List<string> { "Deep learning", "GANs/Transformers", "Python" },
                    CareerPaths = new List<string> { "Gen AI Developer ($95K-$180K)", "AI Creative Engineer ($100K-$190K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 81,
                    Title = "Edge AI Engineer",
                    Description = "Deploy AI models on edge devices",
                    Icon = "📱",
                    Category = CategoryConstants.DataScience,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "EdgeAIEngineer",
                    ControllerName = "DataScience",
                    Context = "Edge AI brings intelligence to IoT devices and embedded systems.",
                    Prerequisites = new List<string> { "ML optimization", "Embedded systems", "Model compression" },
                    CareerPaths = new List<string> { "Edge AI Engineer ($85K-$165K)", "Embedded ML Engineer ($90K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 82,
                    Title = "AutoML Engineer",
                    Description = "Automate machine learning pipeline development",
                    Icon = "🤖",
                    Category = CategoryConstants.DataScience,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "AutoMLEngineer",
                    ControllerName = "DataScience",
                    Context = "AutoML democratizes machine learning by automating model selection and tuning.",
                    Prerequisites = new List<string> { "ML pipelines", "Hyperparameter tuning", "Python" },
                    CareerPaths = new List<string> { "AutoML Engineer ($85K-$160K)", "ML Platform Developer ($90K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 83,
                    Title = "Federated Learning Engineer",
                    Description = "Build privacy-preserving distributed ML systems",
                    Icon = "🔐",
                    Category = CategoryConstants.DataScience,
                    Duration = "5-6 months",
                    Difficulty = "Expert",
                    ActionName = "FederatedLearningEngineer",
                    ControllerName = "DataScience",
                    Context = "Federated learning enables ML training on distributed data while preserving privacy.",
                    Prerequisites = new List<string> { "Distributed systems", "ML theory", "Privacy techniques" },
                    CareerPaths = new List<string> { "FL Engineer ($90K-$175K)", "Privacy ML Engineer ($95K-$185K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 84,
                    Title = "Explainable AI Engineer",
                    Description = "Make AI decisions transparent and interpretable",
                    Icon = "🔍",
                    Category = CategoryConstants.DataScience,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "ExplainableAIEngineer",
                    ControllerName = "DataScience",
                    Context = "Explainable AI makes complex models understandable to humans.",
                    Prerequisites = new List<string> { "ML models", "Interpretability methods", "Visualization" },
                    CareerPaths = new List<string> { "XAI Engineer ($85K-$165K)", "AI Transparency Lead ($90K-$175K)" },
                    Steps = new List<RoadmapStep>()
                },

                // DevOps & Cloud Extended Roadmaps
                new Roadmap
                {
                    Id = 85,
                    Title = "Kubernetes Engineer",
                    Description = "Master container orchestration with Kubernetes",
                    Icon = "☸️",
                    Category = CategoryConstants.DevOps,
                    Duration = "4-6 months",
                    Difficulty = "Advanced",
                    ActionName = "KubernetesEngineer",
                    ControllerName = "DevOps",
                    Context = "Kubernetes is the industry standard for container orchestration at scale.",
                    Prerequisites = new List<string> { "Docker", "Linux", "Networking basics" },
                    CareerPaths = new List<string> { "K8s Engineer ($90K-$170K)", "Platform Engineer ($95K-$180K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 86,
                    Title = "Site Reliability Engineer",
                    Description = "Ensure system reliability and performance at scale",
                    Icon = "🛡️",
                    Category = CategoryConstants.DevOps,
                    Duration = "6-8 months",
                    Difficulty = "Advanced",
                    ActionName = "SiteReliabilityEngineer",
                    ControllerName = "DevOps",
                    Context = "SREs combine software engineering with operations to build reliable systems.",
                    Prerequisites = new List<string> { "Systems thinking", "Programming", "Operations experience" },
                    CareerPaths = new List<string> { "SRE ($95K-$180K)", "Principal SRE ($120K-$220K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 87,
                    Title = "Infrastructure as Code Engineer",
                    Description = "Automate infrastructure with code",
                    Icon = "📝",
                    Category = CategoryConstants.DevOps,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "IaCEngineer",
                    ControllerName = "DevOps",
                    Context = "IaC enables version-controlled, reproducible infrastructure deployment.",
                    Prerequisites = new List<string> { "Cloud basics", "Scripting", "Version control" },
                    CareerPaths = new List<string> { "IaC Engineer ($85K-$160K)", "Cloud Automation Engineer ($90K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 88,
                    Title = "AWS Solutions Architect",
                    Description = "Design scalable solutions on Amazon Web Services",
                    Icon = "🟠",
                    Category = CategoryConstants.DevOps,
                    Duration = "5-7 months",
                    Difficulty = "Advanced",
                    ActionName = "AWSSolutionsArchitect",
                    ControllerName = "DevOps",
                    Context = "AWS is the leading cloud platform for building scalable applications.",
                    Prerequisites = new List<string> { "Cloud concepts", "Networking", "Security basics" },
                    CareerPaths = new List<string> { "AWS Architect ($100K-$190K)", "Cloud Solutions Architect ($110K-$200K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 89,
                    Title = "Google Cloud Engineer",
                    Description = "Build and manage applications on Google Cloud Platform",
                    Icon = "☁️",
                    Category = CategoryConstants.DevOps,
                    Duration = "5-6 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "GoogleCloudEngineer",
                    ControllerName = "DevOps",
                    Context = "Google Cloud Platform offers cutting-edge services for modern applications.",
                    Prerequisites = new List<string> { "Cloud basics", "Containerization", "Data concepts" },
                    CareerPaths = new List<string> { "GCP Engineer ($85K-$165K)", "Cloud Engineer ($90K-$175K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 90,
                    Title = "Multi-Cloud Architect",
                    Description = "Design solutions across multiple cloud platforms",
                    Icon = "☁️",
                    Category = CategoryConstants.DevOps,
                    Duration = "6-8 months",
                    Difficulty = "Expert",
                    ActionName = "MultiCloudArchitect",
                    ControllerName = "DevOps",
                    Context = "Multi-cloud strategies prevent vendor lock-in and optimize for best-of-breed services.",
                    Prerequisites = new List<string> { "Multiple cloud platforms", "Architecture patterns", "Cost optimization" },
                    CareerPaths = new List<string> { "Multi-Cloud Architect ($110K-$200K)", "Enterprise Architect ($120K-$220K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 91,
                    Title = "Docker Specialist",
                    Description = "Master containerization with Docker",
                    Icon = "🐳",
                    Category = CategoryConstants.DevOps,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    ActionName = "DockerSpecialist",
                    ControllerName = "DevOps",
                    Context = "Docker revolutionized application deployment through containerization.",
                    Prerequisites = new List<string> { "Linux basics", "Application deployment", "Networking" },
                    CareerPaths = new List<string> { "Container Engineer ($80K-$150K)", "DevOps Engineer ($85K-$160K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 92,
                    Title = "CI/CD Pipeline Engineer",
                    Description = "Build automated software delivery pipelines",
                    Icon = "🔄",
                    Category = CategoryConstants.DevOps,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "CICDEngineer",
                    ControllerName = "DevOps",
                    Context = "CI/CD pipelines enable rapid, reliable software delivery.",
                    Prerequisites = new List<string> { "Version control", "Build tools", "Testing basics" },
                    CareerPaths = new List<string> { "CI/CD Engineer ($80K-$155K)", "Release Engineer ($85K-$165K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 93,
                    Title = "Platform Engineer",
                    Description = "Build internal developer platforms",
                    Icon = "🏗️",
                    Category = CategoryConstants.DevOps,
                    Duration = "5-7 months",
                    Difficulty = "Advanced",
                    ActionName = "PlatformEngineer",
                    ControllerName = "DevOps",
                    Context = "Platform engineers create self-service platforms for development teams.",
                    Prerequisites = new List<string> { "Cloud platforms", "Automation", "Developer tools" },
                    CareerPaths = new List<string> { "Platform Engineer ($95K-$175K)", "Principal Platform Engineer ($110K-$200K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 94,
                    Title = "Chaos Engineer",
                    Description = "Build resilient systems through controlled failure",
                    Icon = "💥",
                    Category = CategoryConstants.DevOps,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "ChaosEngineer",
                    ControllerName = "DevOps",
                    Context = "Chaos engineering proactively discovers system weaknesses before they cause outages.",
                    Prerequisites = new List<string> { "Distributed systems", "Monitoring", "Scripting" },
                    CareerPaths = new List<string> { "Chaos Engineer ($90K-$170K)", "Reliability Engineer ($95K-$180K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 95,
                    Title = "Cloud Security Engineer",
                    Description = "Secure cloud infrastructure and applications",
                    Icon = "🔒",
                    Category = CategoryConstants.DevOps,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "CloudSecurityEngineer",
                    ControllerName = "DevOps",
                    Context = "Cloud security engineers protect cloud resources from threats and ensure compliance.",
                    Prerequisites = new List<string> { "Cloud platforms", "Security principles", "Compliance knowledge" },
                    CareerPaths = new List<string> { "Cloud Security Engineer ($95K-$175K)", "Security Architect ($105K-$190K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 96,
                    Title = "Monitoring & Observability Engineer",
                    Description = "Build comprehensive monitoring solutions",
                    Icon = "📊",
                    Category = CategoryConstants.DevOps,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "MonitoringEngineer",
                    ControllerName = "DevOps",
                    Context = "Observability enables understanding complex system behavior in production.",
                    Prerequisites = new List<string> { "Metrics/Logs/Traces", "Data analysis", "Distributed systems" },
                    CareerPaths = new List<string> { "Observability Engineer ($85K-$165K)", "SRE ($90K-$175K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 97,
                    Title = "GitOps Engineer",
                    Description = "Implement Git-based operational workflows",
                    Icon = "🔀",
                    Category = CategoryConstants.DevOps,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "GitOpsEngineer",
                    ControllerName = "DevOps",
                    Context = "GitOps uses Git as the single source of truth for infrastructure and applications.",
                    Prerequisites = new List<string> { "Git expertise", "Kubernetes", "CI/CD" },
                    CareerPaths = new List<string> { "GitOps Engineer ($85K-$160K)", "Platform Engineer ($90K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 98,
                    Title = "Edge Computing Engineer",
                    Description = "Deploy applications at the network edge",
                    Icon = "🌐",
                    Category = CategoryConstants.DevOps,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "EdgeComputingEngineer",
                    ControllerName = "DevOps",
                    Context = "Edge computing brings computation closer to data sources for reduced latency.",
                    Prerequisites = new List<string> { "Distributed systems", "IoT basics", "Networking" },
                    CareerPaths = new List<string> { "Edge Engineer ($85K-$165K)", "Distributed Systems Engineer ($90K-$175K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 99,
                    Title = "FinOps Engineer",
                    Description = "Optimize cloud costs and financial operations",
                    Icon = "💰",
                    Category = CategoryConstants.DevOps,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    ActionName = "FinOpsEngineer",
                    ControllerName = "DevOps",
                    Context = "FinOps brings financial accountability to cloud spending.",
                    Prerequisites = new List<string> { "Cloud platforms", "Cost analysis", "Automation" },
                    CareerPaths = new List<string> { "FinOps Engineer ($80K-$155K)", "Cloud Cost Analyst ($85K-$160K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 100,
                    Title = "Serverless Architect",
                    Description = "Design applications using serverless technologies",
                    Icon = "⚡",
                    Category = CategoryConstants.DevOps,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "ServerlessArchitect",
                    ControllerName = "DevOps",
                    Context = "Serverless computing enables building applications without managing servers.",
                    Prerequisites = new List<string> { "Cloud functions", "Event-driven architecture", "API design" },
                    CareerPaths = new List<string> { "Serverless Architect ($90K-$170K)", "Cloud Architect ($95K-$180K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 101,
                    Title = "Service Mesh Engineer",
                    Description = "Implement microservices communication infrastructure",
                    Icon = "🕸️",
                    Category = CategoryConstants.DevOps,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "ServiceMeshEngineer",
                    ControllerName = "DevOps",
                    Context = "Service mesh provides secure, reliable microservices communication.",
                    Prerequisites = new List<string> { "Microservices", "Kubernetes", "Networking" },
                    CareerPaths = new List<string> { "Service Mesh Engineer ($90K-$170K)", "Platform Architect ($95K-$180K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 102,
                    Title = "Database Reliability Engineer",
                    Description = "Ensure database performance and availability",
                    Icon = "🗃️",
                    Category = CategoryConstants.DevOps,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "DatabaseReliabilityEngineer",
                    ControllerName = "DevOps",
                    Context = "Database reliability engineers ensure data systems perform optimally at scale.",
                    Prerequisites = new List<string> { "Database administration", "Performance tuning", "High availability" },
                    CareerPaths = new List<string> { "Database SRE ($90K-$170K)", "Data Platform Engineer ($95K-$180K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 103,
                    Title = "Cloud Migration Specialist",
                    Description = "Lead cloud transformation initiatives",
                    Icon = "🚀",
                    Category = CategoryConstants.DevOps,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "CloudMigrationSpecialist",
                    ControllerName = "DevOps",
                    Context = "Cloud migration specialists help organizations move to the cloud efficiently.",
                    Prerequisites = new List<string> { "Legacy systems", "Cloud platforms", "Migration strategies" },
                    CareerPaths = new List<string> { "Migration Specialist ($85K-$165K)", "Cloud Consultant ($90K-$175K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 104,
                    Title = "DevSecOps Engineer",
                    Description = "Integrate security into DevOps practices",
                    Icon = "🛡️",
                    Category = CategoryConstants.DevOps,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "DevSecOpsEngineer",
                    ControllerName = "DevOps",
                    Context = "DevSecOps embeds security practices throughout the software development lifecycle.",
                    Prerequisites = new List<string> { "DevOps practices", "Security tools", "Compliance" },
                    CareerPaths = new List<string> { "DevSecOps Engineer ($90K-$170K)", "Security Architect ($95K-$180K)" },
                    Steps = new List<RoadmapStep>()
                },

                // Specialized Category Extended Roadmaps
                new Roadmap
                {
                    Id = 105,
                    Title = "UX/UI Designer",
                    Description = "Create intuitive and beautiful user interfaces",
                    Icon = "🎨",
                    Category = CategoryConstants.Specialized,
                    Duration = "5-6 months",
                    Difficulty = "Intermediate",
                    ActionName = "UXUIDesigner",
                    ControllerName = "Specialized",
                    Context = "UX/UI designers create user-centered designs that balance aesthetics with functionality.",
                    Prerequisites = new List<string> { "Design principles", "User research", "Design tools" },
                    CareerPaths = new List<string> { "UI/UX Designer ($65K-$130K)", "Product Designer ($75K-$150K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 106,
                    Title = "Product Manager",
                    Description = "Lead product development and strategy",
                    Icon = "📋",
                    Category = CategoryConstants.Specialized,
                    Duration = "6-8 months",
                    Difficulty = "Advanced",
                    ActionName = "ProductManager",
                    ControllerName = "Specialized",
                    Context = "Product managers bridge business, technology, and user experience to deliver successful products.",
                    Prerequisites = new List<string> { "Business acumen", "Technical knowledge", "Communication skills" },
                    CareerPaths = new List<string> { "Product Manager ($90K-$160K)", "Senior PM ($110K-$200K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 107,
                    Title = "Technical Writer",
                    Description = "Create clear technical documentation",
                    Icon = "✍️",
                    Category = CategoryConstants.Specialized,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    ActionName = "TechnicalWriter",
                    ControllerName = "Specialized",
                    Context = "Technical writers make complex technical information accessible to various audiences.",
                    Prerequisites = new List<string> { "Writing skills", "Technical understanding", "Documentation tools" },
                    CareerPaths = new List<string> { "Technical Writer ($60K-$110K)", "Documentation Lead ($75K-$130K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 108,
                    Title = "Blockchain Developer",
                    Description = "Build decentralized applications and smart contracts",
                    Icon = "⛓️",
                    Category = CategoryConstants.Specialized,
                    Duration = "6-8 months",
                    Difficulty = "Advanced",
                    ActionName = "BlockchainDeveloper",
                    ControllerName = "Specialized",
                    Context = "Blockchain developers create decentralized solutions using blockchain technology.",
                    Prerequisites = new List<string> { "Cryptography basics", "Distributed systems", "Smart contracts" },
                    CareerPaths = new List<string> { "Blockchain Developer ($85K-$170K)", "DApp Developer ($90K-$180K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 109,
                    Title = "IoT Developer",
                    Description = "Build connected device solutions",
                    Icon = "📡",
                    Category = CategoryConstants.Specialized,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "IoTDeveloper",
                    ControllerName = "Specialized",
                    Context = "IoT developers create systems that connect physical devices to the internet.",
                    Prerequisites = new List<string> { "Embedded systems", "Networking", "Cloud platforms" },
                    CareerPaths = new List<string> { "IoT Developer ($75K-$145K)", "IoT Architect ($85K-$160K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 110,
                    Title = "Game Developer",
                    Description = "Create interactive gaming experiences",
                    Icon = "🎮",
                    Category = CategoryConstants.Specialized,
                    Duration = "6-8 months",
                    Difficulty = "Advanced",
                    ActionName = "GameDeveloper",
                    ControllerName = "Specialized",
                    Context = "Game developers combine programming, art, and design to create engaging games.",
                    Prerequisites = new List<string> { "Programming (C++/C#)", "Mathematics", "Game engines" },
                    CareerPaths = new List<string> { "Game Developer ($65K-$130K)", "Game Engineer ($75K-$150K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 111,
                    Title = "AR/VR Developer",
                    Description = "Build immersive augmented and virtual reality experiences",
                    Icon = "🥽",
                    Category = CategoryConstants.Specialized,
                    Duration = "6-7 months",
                    Difficulty = "Advanced",
                    ActionName = "ARVRDeveloper",
                    ControllerName = "Specialized",
                    Context = "AR/VR developers create immersive experiences for various industries.",
                    Prerequisites = new List<string> { "3D graphics", "Unity/Unreal", "Spatial computing" },
                    CareerPaths = new List<string> { "AR/VR Developer ($80K-$160K)", "XR Engineer ($85K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 112,
                    Title = "Embedded Systems Engineer",
                    Description = "Program hardware devices and microcontrollers",
                    Icon = "🔌",
                    Category = CategoryConstants.Specialized,
                    Duration = "6-8 months",
                    Difficulty = "Advanced",
                    ActionName = "EmbeddedSystemsEngineer",
                    ControllerName = "Specialized",
                    Context = "Embedded engineers create software for hardware devices and real-time systems.",
                    Prerequisites = new List<string> { "C/C++", "Hardware knowledge", "Real-time systems" },
                    CareerPaths = new List<string> { "Embedded Engineer ($75K-$145K)", "Firmware Engineer ($80K-$155K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 113,
                    Title = "Robotics Engineer",
                    Description = "Design and program robotic systems",
                    Icon = "🤖",
                    Category = CategoryConstants.Specialized,
                    Duration = "8-10 months",
                    Difficulty = "Expert",
                    ActionName = "RoboticsEngineer",
                    ControllerName = "Specialized",
                    Context = "Robotics engineers combine mechanical, electrical, and software engineering.",
                    Prerequisites = new List<string> { "Mathematics", "Control systems", "Programming", "Electronics" },
                    CareerPaths = new List<string> { "Robotics Engineer ($80K-$155K)", "Automation Engineer ($85K-$165K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 114,
                    Title = "Growth Engineer",
                    Description = "Drive product growth through technical solutions",
                    Icon = "📈",
                    Category = CategoryConstants.Specialized,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "GrowthEngineer",
                    ControllerName = "Specialized",
                    Context = "Growth engineers use engineering to drive user acquisition and retention.",
                    Prerequisites = new List<string> { "Full stack development", "Analytics", "A/B testing" },
                    CareerPaths = new List<string> { "Growth Engineer ($85K-$160K)", "Growth Lead ($95K-$175K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 115,
                    Title = "Voice Interface Developer",
                    Description = "Build voice-activated applications and assistants",
                    Icon = "🎤",
                    Category = CategoryConstants.Specialized,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "VoiceInterfaceDeveloper",
                    ControllerName = "Specialized",
                    Context = "Voice developers create natural language interfaces for applications.",
                    Prerequisites = new List<string> { "NLP basics", "API integration", "Audio processing" },
                    CareerPaths = new List<string> { "Voice Developer ($75K-$145K)", "Conversational AI Engineer ($80K-$155K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 116,
                    Title = "Low-Code Developer",
                    Description = "Build applications using low-code platforms",
                    Icon = "🧩",
                    Category = CategoryConstants.Specialized,
                    Duration = "2-3 months",
                    Difficulty = "Beginner to Intermediate",
                    ActionName = "LowCodeDeveloper",
                    ControllerName = "Specialized",
                    Context = "Low-code developers rapidly build applications using visual development platforms.",
                    Prerequisites = new List<string> { "Basic logic", "Process understanding", "Platform knowledge" },
                    CareerPaths = new List<string> { "Low-Code Developer ($60K-$110K)", "Citizen Developer ($65K-$120K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 117,
                    Title = "Quantum Computing Developer",
                    Description = "Program quantum computers and algorithms",
                    Icon = "⚛️",
                    Category = CategoryConstants.Specialized,
                    Duration = "8-10 months",
                    Difficulty = "Expert",
                    ActionName = "QuantumComputingDeveloper",
                    ControllerName = "Specialized",
                    Context = "Quantum developers create algorithms for quantum computers.",
                    Prerequisites = new List<string> { "Quantum mechanics", "Linear algebra", "Quantum algorithms" },
                    CareerPaths = new List<string> { "Quantum Developer ($100K-$200K)", "Quantum Researcher ($110K-$220K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 118,
                    Title = "3D Graphics Developer",
                    Description = "Create stunning 3D visualizations and graphics",
                    Icon = "🎯",
                    Category = CategoryConstants.Specialized,
                    Duration = "6-7 months",
                    Difficulty = "Advanced",
                    ActionName = "GraphicsDeveloper",
                    ControllerName = "Specialized",
                    Context = "3D graphics developers create visual experiences for games, simulations, and applications.",
                    Prerequisites = new List<string> { "Mathematics", "Graphics APIs", "Shader programming" },
                    CareerPaths = new List<string> { "Graphics Developer ($75K-$150K)", "Graphics Engineer ($85K-$165K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 119,
                    Title = "Accessibility Engineer",
                    Description = "Make technology accessible to everyone",
                    Icon = "♿",
                    Category = CategoryConstants.Specialized,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    ActionName = "AccessibilityEngineer",
                    ControllerName = "Specialized",
                    Context = "Accessibility engineers ensure technology is usable by people with disabilities.",
                    Prerequisites = new List<string> { "Web standards", "WCAG guidelines", "Assistive technologies" },
                    CareerPaths = new List<string> { "Accessibility Engineer ($70K-$135K)", "Inclusive Design Lead ($80K-$150K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 120,
                    Title = "Performance Engineer",
                    Description = "Optimize application and system performance",
                    Icon = "⚡",
                    Category = CategoryConstants.Specialized,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "PerformanceEngineer",
                    ControllerName = "Specialized",
                    Context = "Performance engineers ensure applications run fast and efficiently.",
                    Prerequisites = new List<string> { "System architecture", "Profiling tools", "Optimization techniques" },
                    CareerPaths = new List<string> { "Performance Engineer ($85K-$160K)", "Performance Architect ($95K-$175K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 121,
                    Title = "API Platform Engineer",
                    Description = "Build and manage API ecosystems",
                    Icon = "🔌",
                    Category = CategoryConstants.Specialized,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "APIPlatformEngineer",
                    ControllerName = "Specialized",
                    Context = "API platform engineers create infrastructure for API development and management.",
                    Prerequisites = new List<string> { "API design", "Gateway patterns", "Developer experience" },
                    CareerPaths = new List<string> { "API Platform Engineer ($85K-$165K)", "Platform Architect ($95K-$180K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 122,
                    Title = "Search Engineer",
                    Description = "Build powerful search and discovery systems",
                    Icon = "🔍",
                    Category = CategoryConstants.Specialized,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "SearchEngineer",
                    ControllerName = "Specialized",
                    Context = "Search engineers create systems that help users find relevant information quickly.",
                    Prerequisites = new List<string> { "Information retrieval", "Elasticsearch/Solr", "Relevance tuning" },
                    CareerPaths = new List<string> { "Search Engineer ($85K-$160K)", "Search Architect ($95K-$175K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 123,
                    Title = "Streaming Engineer",
                    Description = "Build real-time data streaming systems",
                    Icon = "🌊",
                    Category = CategoryConstants.Specialized,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "StreamingEngineer",
                    ControllerName = "Specialized",
                    Context = "Streaming engineers build systems for processing real-time data at scale.",
                    Prerequisites = new List<string> { "Kafka/Pulsar", "Stream processing", "Distributed systems" },
                    CareerPaths = new List<string> { "Streaming Engineer ($85K-$165K)", "Data Platform Engineer ($90K-$175K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 124,
                    Title = "Developer Advocate",
                    Description = "Bridge the gap between developers and products",
                    Icon = "🗣️",
                    Category = CategoryConstants.Specialized,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate",
                    ActionName = "DeveloperAdvocate",
                    ControllerName = "Specialized",
                    Context = "Developer advocates help developers succeed with products and technologies.",
                    Prerequisites = new List<string> { "Technical expertise", "Communication skills", "Community building" },
                    CareerPaths = new List<string> { "Developer Advocate ($80K-$150K)", "DevRel Lead ($90K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                // Testing & Quality Assurance Extended Roadmaps
                new Roadmap
                {
                    Id = 125,
                    Title = "Automation Test Engineer",
                    Description = "Build comprehensive test automation frameworks",
                    Icon = "🤖",
                    Category = CategoryConstants.Testing,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "AutomationTestEngineer",
                    ControllerName = "Testing",
                    Context = "Automation engineers create frameworks that ensure software quality at scale.",
                    Prerequisites = new List<string> { "Programming skills", "Testing concepts", "CI/CD knowledge" },
                    CareerPaths = new List<string> { "Automation Engineer ($70K-$135K)", "SDET ($80K-$150K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 126,
                    Title = "Performance Tester",
                    Description = "Test application performance and scalability",
                    Icon = "📊",
                    Category = CategoryConstants.Testing,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "PerformanceTester",
                    ControllerName = "Testing",
                    Context = "Performance testers ensure applications can handle expected load and scale.",
                    Prerequisites = new List<string> { "Performance tools", "Metrics analysis", "Scripting" },
                    CareerPaths = new List<string> { "Performance Tester ($70K-$130K)", "Performance Engineer ($80K-$150K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 127,
                    Title = "Security Tester",
                    Description = "Find and fix security vulnerabilities",
                    Icon = "🔒",
                    Category = CategoryConstants.Testing,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "SecurityTester",
                    ControllerName = "Testing",
                    Context = "Security testers protect applications from threats and vulnerabilities.",
                    Prerequisites = new List<string> { "Security concepts", "Penetration testing", "OWASP knowledge" },
                    CareerPaths = new List<string> { "Security Tester ($75K-$140K)", "Security Engineer ($85K-$160K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 128,
                    Title = "Mobile Test Engineer",
                    Description = "Test mobile applications across devices",
                    Icon = "📱",
                    Category = CategoryConstants.Testing,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate",
                    ActionName = "MobileTestEngineer",
                    ControllerName = "Testing",
                    Context = "Mobile testers ensure apps work flawlessly across different devices and platforms.",
                    Prerequisites = new List<string> { "Mobile platforms", "Testing tools", "Device farms" },
                    CareerPaths = new List<string> { "Mobile Tester ($65K-$125K)", "Mobile QA Lead ($75K-$140K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 129,
                    Title = "API Test Engineer",
                    Description = "Test APIs and web services",
                    Icon = "🔌",
                    Category = CategoryConstants.Testing,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    ActionName = "APITestEngineer",
                    ControllerName = "Testing",
                    Context = "API testers ensure web services are reliable, secure, and performant.",
                    Prerequisites = new List<string> { "REST/GraphQL", "API tools", "Automation basics" },
                    CareerPaths = new List<string> { "API Tester ($65K-$125K)", "API Test Lead ($75K-$140K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 130,
                    Title = "Test Architect",
                    Description = "Design comprehensive testing strategies",
                    Icon = "🏗️",
                    Category = CategoryConstants.Testing,
                    Duration = "6-8 months",
                    Difficulty = "Expert",
                    ActionName = "TestArchitect",
                    ControllerName = "Testing",
                    Context = "Test architects design testing frameworks and strategies for complex systems.",
                    Prerequisites = new List<string> { "Testing expertise", "Architecture knowledge", "Leadership skills" },
                    CareerPaths = new List<string> { "Test Architect ($90K-$170K)", "QA Director ($100K-$180K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 131,
                    Title = "Accessibility Tester",
                    Description = "Ensure applications are accessible to all users",
                    Icon = "♿",
                    Category = CategoryConstants.Testing,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    ActionName = "AccessibilityTester",
                    ControllerName = "Testing",
                    Context = "Accessibility testers ensure applications meet accessibility standards.",
                    Prerequisites = new List<string> { "WCAG guidelines", "Screen readers", "Accessibility tools" },
                    CareerPaths = new List<string> { "Accessibility Tester ($65K-$120K)", "Accessibility Lead ($75K-$135K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 132,
                    Title = "Game Tester",
                    Description = "Test video games for bugs and playability",
                    Icon = "🎮",
                    Category = CategoryConstants.Testing,
                    Duration = "3-4 months",
                    Difficulty = "Beginner to Intermediate",
                    ActionName = "GameTester",
                    ControllerName = "Testing",
                    Context = "Game testers ensure games are bug-free and provide great player experiences.",
                    Prerequisites = new List<string> { "Gaming knowledge", "Attention to detail", "Bug reporting" },
                    CareerPaths = new List<string> { "Game Tester ($50K-$90K)", "QA Lead ($65K-$120K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 133,
                    Title = "ETL Tester",
                    Description = "Test data pipelines and transformations",
                    Icon = "🔄",
                    Category = CategoryConstants.Testing,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "ETLTester",
                    ControllerName = "Testing",
                    Context = "ETL testers ensure data integrity in extract, transform, and load processes.",
                    Prerequisites = new List<string> { "SQL expertise", "Data warehousing", "ETL tools" },
                    CareerPaths = new List<string> { "ETL Tester ($70K-$130K)", "Data Quality Engineer ($80K-$145K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 134,
                    Title = "Blockchain Tester",
                    Description = "Test blockchain applications and smart contracts",
                    Icon = "⛓️",
                    Category = CategoryConstants.Testing,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "BlockchainTester",
                    ControllerName = "Testing",
                    Context = "Blockchain testers ensure the security and reliability of decentralized applications.",
                    Prerequisites = new List<string> { "Blockchain concepts", "Smart contracts", "Security testing" },
                    CareerPaths = new List<string> { "Blockchain Tester ($75K-$145K)", "DApp QA Engineer ($85K-$160K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 135,
                    Title = "IoT Tester",
                    Description = "Test Internet of Things devices and systems",
                    Icon = "📡",
                    Category = CategoryConstants.Testing,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "IoTTester",
                    ControllerName = "Testing",
                    Context = "IoT testers ensure connected devices work reliably and securely.",
                    Prerequisites = new List<string> { "IoT protocols", "Hardware testing", "Network testing" },
                    CareerPaths = new List<string> { "IoT Tester ($70K-$130K)", "IoT QA Lead ($80K-$145K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 136,
                    Title = "Usability Tester",
                    Description = "Test user experience and interface design",
                    Icon = "👤",
                    Category = CategoryConstants.Testing,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    ActionName = "UsabilityTester",
                    ControllerName = "Testing",
                    Context = "Usability testers ensure applications are intuitive and user-friendly.",
                    Prerequisites = new List<string> { "UX principles", "User research", "Testing methods" },
                    CareerPaths = new List<string> { "Usability Tester ($60K-$115K)", "UX Researcher ($70K-$130K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 137,
                    Title = "Localization Tester",
                    Description = "Test software for international markets",
                    Icon = "🌍",
                    Category = CategoryConstants.Testing,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    ActionName = "LocalizationTester",
                    ControllerName = "Testing",
                    Context = "Localization testers ensure software works correctly in different languages and regions.",
                    Prerequisites = new List<string> { "Multiple languages", "Cultural awareness", "Testing tools" },
                    CareerPaths = new List<string> { "Localization Tester ($60K-$110K)", "L10n QA Lead ($70K-$125K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 138,
                    Title = "Compliance Tester",
                    Description = "Ensure software meets regulatory requirements",
                    Icon = "📋",
                    Category = CategoryConstants.Testing,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "ComplianceTester",
                    ControllerName = "Testing",
                    Context = "Compliance testers verify software meets industry regulations and standards.",
                    Prerequisites = new List<string> { "Regulatory knowledge", "Audit processes", "Documentation" },
                    CareerPaths = new List<string> { "Compliance Tester ($70K-$135K)", "Compliance Manager ($80K-$150K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 139,
                    Title = "Chaos Testing Engineer",
                    Description = "Test system resilience through controlled failures",
                    Icon = "💥",
                    Category = CategoryConstants.Testing,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "ChaosTestingEngineer",
                    ControllerName = "Testing",
                    Context = "Chaos testers proactively find system weaknesses through failure injection.",
                    Prerequisites = new List<string> { "Distributed systems", "Failure scenarios", "Monitoring" },
                    CareerPaths = new List<string> { "Chaos Engineer ($85K-$160K)", "Resilience Engineer ($90K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 140,
                    Title = "Contract Tester",
                    Description = "Test API contracts between services",
                    Icon = "📄",
                    Category = CategoryConstants.Testing,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "ContractTester",
                    ControllerName = "Testing",
                    Context = "Contract testers ensure services communicate correctly through defined interfaces.",
                    Prerequisites = new List<string> { "API design", "Contract testing tools", "Microservices" },
                    CareerPaths = new List<string> { "Contract Tester ($70K-$130K)", "Integration Test Lead ($80K-$145K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 141,
                    Title = "Visual Regression Tester",
                    Description = "Test UI consistency across changes",
                    Icon = "👁️",
                    Category = CategoryConstants.Testing,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    ActionName = "VisualRegressionTester",
                    ControllerName = "Testing",
                    Context = "Visual regression testers ensure UI changes don't break existing designs.",
                    Prerequisites = new List<string> { "UI testing tools", "Screenshot comparison", "CSS knowledge" },
                    CareerPaths = new List<string> { "Visual Tester ($65K-$120K)", "UI Test Engineer ($75K-$135K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 142,
                    Title = "Data Quality Engineer",
                    Description = "Ensure data accuracy and integrity",
                    Icon = "📊",
                    Category = CategoryConstants.Testing,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "DataQualityEngineer",
                    ControllerName = "Testing",
                    Context = "Data quality engineers ensure data meets quality standards for business use.",
                    Prerequisites = new List<string> { "SQL expertise", "Data profiling", "Quality metrics" },
                    CareerPaths = new List<string> { "Data Quality Engineer ($75K-$140K)", "Data Governance Lead ($85K-$155K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 143,
                    Title = "Test Data Engineer",
                    Description = "Create and manage test data strategies",
                    Icon = "💾",
                    Category = CategoryConstants.Testing,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "TestDataEngineer",
                    ControllerName = "Testing",
                    Context = "Test data engineers create realistic data sets for comprehensive testing.",
                    Prerequisites = new List<string> { "Data modeling", "Privacy compliance", "Automation" },
                    CareerPaths = new List<string> { "Test Data Engineer ($70K-$135K)", "Data Test Architect ($80K-$150K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 144,
                    Title = "BDD Test Engineer",
                    Description = "Implement behavior-driven development testing",
                    Icon = "📝",
                    Category = CategoryConstants.Testing,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    ActionName = "BDDTestEngineer",
                    ControllerName = "Testing",
                    Context = "BDD engineers bridge business requirements and automated tests.",
                    Prerequisites = new List<string> { "Gherkin syntax", "BDD frameworks", "Collaboration skills" },
                    CareerPaths = new List<string> { "BDD Engineer ($70K-$130K)", "Test Automation Lead ($80K-$145K)" },
                    Steps = new List<RoadmapStep>()
                },

                // Architecture & System Design Extended Roadmaps
                new Roadmap
                {
                    Id = 145,
                    Title = "Microservices Architect",
                    Description = "Design scalable microservices architectures",
                    Icon = "🔲",
                    Category = CategoryConstants.Architecture,
                    Duration = "6-8 months",
                    Difficulty = "Expert",
                    ActionName = "MicroservicesArchitect",
                    ControllerName = "Architecture",
                    Context = "Microservices architects design distributed systems using microservice patterns.",
                    Prerequisites = new List<string> { "Distributed systems", "API design", "Domain-driven design" },
                    CareerPaths = new List<string> { "Microservices Architect ($110K-$190K)", "Principal Architect ($130K-$220K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 146,
                    Title = "Cloud Solution Architect",
                    Description = "Design cloud-native application architectures",
                    Icon = "☁️",
                    Category = CategoryConstants.Architecture,
                    Duration = "6-8 months",
                    Difficulty = "Advanced",
                    ActionName = "CloudSolutionArchitect",
                    ControllerName = "Architecture",
                    Context = "Cloud architects design scalable, resilient cloud solutions.",
                    Prerequisites = new List<string> { "Cloud platforms", "Distributed systems", "Security" },
                    CareerPaths = new List<string> { "Cloud Architect ($100K-$190K)", "Solutions Architect ($110K-$200K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 147,
                    Title = "Enterprise Architect",
                    Description = "Align technology with business strategy",
                    Icon = "🏢",
                    Category = CategoryConstants.Architecture,
                    Duration = "12-18 months",
                    Difficulty = "Expert",
                    ActionName = "EnterpriseArchitect",
                    ControllerName = "Architecture",
                    Context = "Enterprise architects ensure technology supports business objectives.",
                    Prerequisites = new List<string> { "Business acumen", "Systems thinking", "Leadership" },
                    CareerPaths = new List<string> { "Enterprise Architect ($120K-$200K)", "Chief Architect ($150K-$250K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 148,
                    Title = "Security Architect",
                    Description = "Design secure system architectures",
                    Icon = "🔐",
                    Category = CategoryConstants.Architecture,
                    Duration = "6-8 months",
                    Difficulty = "Advanced",
                    ActionName = "SecurityArchitect",
                    ControllerName = "Architecture",
                    Context = "Security architects design systems that protect against threats.",
                    Prerequisites = new List<string> { "Security principles", "Threat modeling", "Compliance" },
                    CareerPaths = new List<string> { "Security Architect ($105K-$190K)", "Chief Security Officer ($130K-$230K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 149,
                    Title = "Data Architect",
                    Description = "Design enterprise data architectures",
                    Icon = "🗄️",
                    Category = CategoryConstants.Architecture,
                    Duration = "6-8 months",
                    Difficulty = "Advanced",
                    ActionName = "DataArchitect",
                    ControllerName = "Architecture",
                    Context = "Data architects design systems for storing, processing, and analyzing data.",
                    Prerequisites = new List<string> { "Database design", "Big data", "Data modeling" },
                    CareerPaths = new List<string> { "Data Architect ($95K-$180K)", "Chief Data Officer ($120K-$220K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 150,
                    Title = "Domain-Driven Design Expert",
                    Description = "Master DDD for complex business domains",
                    Icon = "📐",
                    Category = CategoryConstants.Architecture,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "DDDExpert",
                    ControllerName = "Architecture",
                    Context = "DDD experts model complex business domains in software.",
                    Prerequisites = new List<string> { "Software design", "Business analysis", "OOP" },
                    CareerPaths = new List<string> { "DDD Expert ($100K-$180K)", "Domain Architect ($110K-$190K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 151,
                    Title = "Event-Driven Architect",
                    Description = "Design event-driven and reactive systems",
                    Icon = "⚡",
                    Category = CategoryConstants.Architecture,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "EventDrivenArchitect",
                    ControllerName = "Architecture",
                    Context = "Event-driven architects design systems based on event streaming.",
                    Prerequisites = new List<string> { "Message queuing", "Event sourcing", "CQRS" },
                    CareerPaths = new List<string> { "Event Architect ($95K-$175K)", "Streaming Architect ($100K-$185K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 152,
                    Title = "Integration Architect",
                    Description = "Design system integration solutions",
                    Icon = "🔗",
                    Category = CategoryConstants.Architecture,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "IntegrationArchitect",
                    ControllerName = "Architecture",
                    Context = "Integration architects connect disparate systems seamlessly.",
                    Prerequisites = new List<string> { "API design", "Middleware", "ESB patterns" },
                    CareerPaths = new List<string> { "Integration Architect ($90K-$170K)", "Solution Architect ($100K-$185K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 153,
                    Title = "Mobile Architecture Expert",
                    Description = "Design scalable mobile application architectures",
                    Icon = "📱",
                    Category = CategoryConstants.Architecture,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "MobileArchitect",
                    ControllerName = "Architecture",
                    Context = "Mobile architects design architectures for complex mobile applications.",
                    Prerequisites = new List<string> { "Mobile platforms", "Offline sync", "Performance" },
                    CareerPaths = new List<string> { "Mobile Architect ($95K-$175K)", "Principal Mobile Engineer ($105K-$185K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 154,
                    Title = "API Architecture Specialist",
                    Description = "Design enterprise API strategies",
                    Icon = "🔌",
                    Category = CategoryConstants.Architecture,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "APIArchitect",
                    ControllerName = "Architecture",
                    Context = "API architects design consistent, scalable API ecosystems.",
                    Prerequisites = new List<string> { "REST/GraphQL", "API governance", "Versioning" },
                    CareerPaths = new List<string> { "API Architect ($90K-$170K)", "Platform Architect ($100K-$185K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 155,
                    Title = "Serverless Architecture Expert",
                    Description = "Design serverless-first architectures",
                    Icon = "⚡",
                    Category = CategoryConstants.Architecture,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "ServerlessArchitect",
                    ControllerName = "Architecture",
                    Context = "Serverless architects design applications without managing servers.",
                    Prerequisites = new List<string> { "Cloud functions", "Event-driven design", "Cost optimization" },
                    CareerPaths = new List<string> { "Serverless Architect ($95K-$175K)", "Cloud Architect ($100K-$185K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 156,
                    Title = "Resilience Architect",
                    Description = "Design highly available and fault-tolerant systems",
                    Icon = "🛡️",
                    Category = CategoryConstants.Architecture,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "ResilienceArchitect",
                    ControllerName = "Architecture",
                    Context = "Resilience architects ensure systems survive failures gracefully.",
                    Prerequisites = new List<string> { "Distributed systems", "Failure patterns", "Recovery strategies" },
                    CareerPaths = new List<string> { "Resilience Architect ($100K-$180K)", "Reliability Architect ($105K-$190K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 157,
                    Title = "Clean Architecture Expert",
                    Description = "Master clean architecture principles",
                    Icon = "🏛️",
                    Category = CategoryConstants.Architecture,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "CleanArchitectureExpert",
                    ControllerName = "Architecture",
                    Context = "Clean architecture creates maintainable, testable applications.",
                    Prerequisites = new List<string> { "SOLID principles", "Design patterns", "Testing" },
                    CareerPaths = new List<string> { "Clean Architecture Expert ($90K-$170K)", "Software Architect ($100K-$185K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 158,
                    Title = "Performance Architect",
                    Description = "Design high-performance system architectures",
                    Icon = "⚡",
                    Category = CategoryConstants.Architecture,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "PerformanceArchitect",
                    ControllerName = "Architecture",
                    Context = "Performance architects optimize systems for speed and efficiency.",
                    Prerequisites = new List<string> { "Performance analysis", "Caching strategies", "Load balancing" },
                    CareerPaths = new List<string> { "Performance Architect ($95K-$180K)", "Principal Engineer ($105K-$195K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 159,
                    Title = "Blockchain Architect",
                    Description = "Design decentralized blockchain solutions",
                    Icon = "⛓️",
                    Category = CategoryConstants.Architecture,
                    Duration = "6-8 months",
                    Difficulty = "Expert",
                    ActionName = "BlockchainArchitect",
                    ControllerName = "Architecture",
                    Context = "Blockchain architects design decentralized, trustless systems.",
                    Prerequisites = new List<string> { "Blockchain protocols", "Cryptography", "Consensus mechanisms" },
                    CareerPaths = new List<string> { "Blockchain Architect ($100K-$190K)", "DeFi Architect ($110K-$210K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 160,
                    Title = "IoT Architecture Specialist",
                    Description = "Design Internet of Things architectures",
                    Icon = "📡",
                    Category = CategoryConstants.Architecture,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "IoTArchitect",
                    ControllerName = "Architecture",
                    Context = "IoT architects design systems connecting millions of devices.",
                    Prerequisites = new List<string> { "IoT protocols", "Edge computing", "Security" },
                    CareerPaths = new List<string> { "IoT Architect ($90K-$170K)", "Connected Systems Architect ($95K-$180K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 161,
                    Title = "Machine Learning Architect",
                    Description = "Design ML systems architecture",
                    Icon = "🧠",
                    Category = CategoryConstants.Architecture,
                    Duration = "6-8 months",
                    Difficulty = "Expert",
                    ActionName = "MLArchitect",
                    ControllerName = "Architecture",
                    Context = "ML architects design scalable machine learning systems.",
                    Prerequisites = new List<string> { "ML pipelines", "Model serving", "Data architecture" },
                    CareerPaths = new List<string> { "ML Architect ($105K-$195K)", "AI Architect ($115K-$210K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 162,
                    Title = "Multi-Tenant Architecture Expert",
                    Description = "Design scalable multi-tenant SaaS architectures",
                    Icon = "🏢",
                    Category = CategoryConstants.Architecture,
                    Duration = "5-6 months",
                    Difficulty = "Advanced",
                    ActionName = "MultiTenantArchitect",
                    ControllerName = "Architecture",
                    Context = "Multi-tenant architects design SaaS platforms serving multiple customers.",
                    Prerequisites = new List<string> { "Data isolation", "Scalability patterns", "Security" },
                    CareerPaths = new List<string> { "SaaS Architect ($95K-$180K)", "Platform Architect ($100K-$190K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 163,
                    Title = "Legacy Modernization Architect",
                    Description = "Transform legacy systems to modern architectures",
                    Icon = "🔄",
                    Category = CategoryConstants.Architecture,
                    Duration = "6-8 months",
                    Difficulty = "Expert",
                    ActionName = "ModernizationArchitect",
                    ControllerName = "Architecture",
                    Context = "Modernization architects transform legacy systems while maintaining business continuity.",
                    Prerequisites = new List<string> { "Legacy systems", "Migration patterns", "Risk management" },
                    CareerPaths = new List<string> { "Modernization Architect ($100K-$185K)", "Transformation Lead ($110K-$200K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 164,
                    Title = "Observability Architect",
                    Description = "Design comprehensive observability solutions",
                    Icon = "👁️",
                    Category = CategoryConstants.Architecture,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "ObservabilityArchitect",
                    ControllerName = "Architecture",
                    Context = "Observability architects design systems for understanding complex system behavior.",
                    Prerequisites = new List<string> { "Monitoring tools", "Distributed tracing", "Log aggregation" },
                    CareerPaths = new List<string> { "Observability Architect ($95K-$175K)", "SRE Architect ($100K-$185K)" },
                    Steps = new List<RoadmapStep>()
                },

                // Programming Fundamentals Extended Roadmaps
                new Roadmap
                {
                    Id = 165,
                    Title = "Programming Basics",
                    Description = "Start your programming journey from scratch",
                    Icon = "👶",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "2-3 months",
                    Difficulty = "Beginner",
                    ActionName = "ProgrammingBasics",
                    ControllerName = "ProgrammingFundamentals",
                    Context = "Learn fundamental programming concepts that apply to any language.",
                    Prerequisites = new List<string> { "Basic computer skills", "Logical thinking" },
                    CareerPaths = new List<string> { "Junior Developer ($50K-$80K)", "Software Developer ($60K-$100K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 166,
                    Title = "Data Structures & Algorithms",
                    Description = "Master fundamental computer science concepts",
                    Icon = "🌳",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "4-6 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "DataStructuresAlgorithms",
                    ControllerName = "ProgrammingFundamentals",
                    Context = "Data structures and algorithms are essential for efficient problem solving.",
                    Prerequisites = new List<string> { "Programming basics", "Mathematics", "Logic" },
                    CareerPaths = new List<string> { "Software Engineer ($70K-$140K)", "Algorithm Engineer ($80K-$160K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 167,
                    Title = "Object-Oriented Programming",
                    Description = "Master OOP principles and design",
                    Icon = "🔷",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    ActionName = "ObjectOrientedProgramming",
                    ControllerName = "ProgrammingFundamentals",
                    Context = "OOP is a fundamental paradigm for organizing and structuring code.",
                    Prerequisites = new List<string> { "Basic programming", "Logic", "Problem solving" },
                    CareerPaths = new List<string> { "OOP Developer ($65K-$125K)", "Software Engineer ($75K-$145K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 168,
                    Title = "Functional Programming",
                    Description = "Learn functional programming paradigm",
                    Icon = "λ",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "4-5 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "FunctionalProgramming",
                    ControllerName = "ProgrammingFundamentals",
                    Context = "Functional programming emphasizes immutability and pure functions.",
                    Prerequisites = new List<string> { "Programming basics", "Mathematics", "Abstract thinking" },
                    CareerPaths = new List<string> { "Functional Developer ($75K-$145K)", "Scala/Clojure Developer ($85K-$160K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 169,
                    Title = "Design Patterns",
                    Description = "Master software design patterns",
                    Icon = "🎨",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "3-4 months",
                    Difficulty = "Advanced",
                    ActionName = "DesignPatterns",
                    ControllerName = "ProgrammingFundamentals",
                    Context = "Design patterns provide reusable solutions to common programming problems.",
                    Prerequisites = new List<string> { "OOP", "Software design", "Problem solving" },
                    CareerPaths = new List<string> { "Senior Developer ($80K-$150K)", "Software Architect ($90K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 170,
                    Title = "SOLID Principles",
                    Description = "Master SOLID design principles",
                    Icon = "🏗️",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "2-3 months",
                    Difficulty = "Intermediate",
                    ActionName = "SOLIDPrinciples",
                    ControllerName = "ProgrammingFundamentals",
                    Context = "SOLID principles guide the creation of maintainable, flexible software.",
                    Prerequisites = new List<string> { "OOP", "Basic design", "Refactoring" },
                    CareerPaths = new List<string> { "Senior Developer ($75K-$140K)", "Lead Developer ($85K-$160K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 171,
                    Title = "Version Control with Git",
                    Description = "Master Git and collaborative workflows",
                    Icon = "🔀",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "2-3 weeks",
                    Difficulty = "Beginner to Intermediate",
                    ActionName = "GitVersionControl",
                    ControllerName = "ProgrammingFundamentals",
                    Context = "Git is essential for modern software development and collaboration.",
                    Prerequisites = new List<string> { "Basic command line", "File systems" },
                    CareerPaths = new List<string> { "Developer ($60K-$120K)", "DevOps Engineer ($70K-$140K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 172,
                    Title = "Clean Code Principles",
                    Description = "Write readable, maintainable code",
                    Icon = "✨",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "2-3 months",
                    Difficulty = "Intermediate",
                    ActionName = "CleanCode",
                    ControllerName = "ProgrammingFundamentals",
                    Context = "Clean code principles help create code that's easy to understand and maintain.",
                    Prerequisites = new List<string> { "Programming experience", "Code review", "Refactoring" },
                    CareerPaths = new List<string> { "Senior Developer ($75K-$140K)", "Code Quality Lead ($85K-$155K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 173,
                    Title = "Debugging & Troubleshooting",
                    Description = "Master debugging techniques and tools",
                    Icon = "🐛",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "2-3 months",
                    Difficulty = "Intermediate",
                    ActionName = "DebuggingTroubleshooting",
                    ControllerName = "ProgrammingFundamentals",
                    Context = "Effective debugging skills are essential for every developer.",
                    Prerequisites = new List<string> { "Programming basics", "IDE usage", "Problem solving" },
                    CareerPaths = new List<string> { "Software Developer ($65K-$125K)", "Senior Developer ($75K-$145K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 174,
                    Title = "Regular Expressions",
                    Description = "Master pattern matching with regex",
                    Icon = "🔤",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "2-3 weeks",
                    Difficulty = "Intermediate",
                    ActionName = "RegularExpressions",
                    ControllerName = "ProgrammingFundamentals",
                    Context = "Regular expressions are powerful tools for text processing and validation.",
                    Prerequisites = new List<string> { "String manipulation", "Pattern recognition" },
                    CareerPaths = new List<string> { "Developer ($60K-$120K)", "Data Engineer ($70K-$140K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 175,
                    Title = "Concurrency & Parallelism",
                    Description = "Master concurrent and parallel programming",
                    Icon = "🔀",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "ConcurrencyParallelism",
                    ControllerName = "ProgrammingFundamentals",
                    Context = "Concurrency is essential for building efficient, scalable applications.",
                    Prerequisites = new List<string> { "Programming proficiency", "Operating systems", "Threading" },
                    CareerPaths = new List<string> { "Systems Developer ($80K-$150K)", "Performance Engineer ($85K-$160K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 176,
                    Title = "Memory Management",
                    Description = "Understand memory allocation and optimization",
                    Icon = "💾",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "3-4 months",
                    Difficulty = "Advanced",
                    ActionName = "MemoryManagement",
                    ControllerName = "ProgrammingFundamentals",
                    Context = "Understanding memory management is crucial for system-level programming.",
                    Prerequisites = new List<string> { "C/C++ basics", "Operating systems", "Data structures" },
                    CareerPaths = new List<string> { "Systems Programmer ($75K-$145K)", "Performance Engineer ($85K-$160K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 177,
                    Title = "Compiler Design",
                    Description = "Build compilers and interpreters",
                    Icon = "🔧",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "6-8 months",
                    Difficulty = "Expert",
                    ActionName = "CompilerDesign",
                    ControllerName = "ProgrammingFundamentals",
                    Context = "Compiler design teaches deep understanding of programming languages.",
                    Prerequisites = new List<string> { "Formal languages", "Parsing", "Code generation" },
                    CareerPaths = new List<string> { "Compiler Engineer ($90K-$170K)", "Language Designer ($100K-$190K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 178,
                    Title = "Operating Systems Concepts",
                    Description = "Understand how operating systems work",
                    Icon = "💻",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "OperatingSystemsConcepts",
                    ControllerName = "ProgrammingFundamentals",
                    Context = "OS concepts are fundamental for system programming and optimization.",
                    Prerequisites = new List<string> { "C programming", "Computer architecture", "Algorithms" },
                    CareerPaths = new List<string> { "Systems Engineer ($80K-$155K)", "Kernel Developer ($90K-$175K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 179,
                    Title = "Network Programming",
                    Description = "Build networked applications and protocols",
                    Icon = "🌐",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "4-5 months",
                    Difficulty = "Advanced",
                    ActionName = "NetworkProgramming",
                    ControllerName = "ProgrammingFundamentals",
                    Context = "Network programming is essential for distributed systems and web applications.",
                    Prerequisites = new List<string> { "TCP/IP", "Socket programming", "Protocols" },
                    CareerPaths = new List<string> { "Network Developer ($75K-$145K)", "Backend Engineer ($80K-$155K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 180,
                    Title = "Database Fundamentals",
                    Description = "Master database concepts and SQL",
                    Icon = "🗄️",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    ActionName = "DatabaseFundamentals",
                    ControllerName = "ProgrammingFundamentals",
                    Context = "Database knowledge is essential for building data-driven applications.",
                    Prerequisites = new List<string> { "Data concepts", "Set theory", "Logic" },
                    CareerPaths = new List<string> { "Database Developer ($70K-$130K)", "Backend Developer ($75K-$140K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 181,
                    Title = "Cryptography Basics",
                    Description = "Understand encryption and security fundamentals",
                    Icon = "🔐",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "3-4 months",
                    Difficulty = "Advanced",
                    ActionName = "CryptographyBasics",
                    ControllerName = "ProgrammingFundamentals",
                    Context = "Cryptography is essential for building secure applications.",
                    Prerequisites = new List<string> { "Mathematics", "Algorithms", "Security concepts" },
                    CareerPaths = new List<string> { "Security Developer ($80K-$150K)", "Cryptography Engineer ($90K-$170K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 182,
                    Title = "Software Testing Fundamentals",
                    Description = "Learn essential testing principles and practices",
                    Icon = "✅",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "2-3 months",
                    Difficulty = "Intermediate",
                    ActionName = "TestingFundamentals",
                    ControllerName = "ProgrammingFundamentals",
                    Context = "Testing is crucial for delivering quality software.",
                    Prerequisites = new List<string> { "Programming basics", "Debugging", "Quality concepts" },
                    CareerPaths = new List<string> { "QA Engineer ($60K-$110K)", "Test Automation Engineer ($70K-$130K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 183,
                    Title = "Refactoring Techniques",
                    Description = "Master code refactoring and improvement",
                    Icon = "♻️",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "2-3 months",
                    Difficulty = "Intermediate to Advanced",
                    ActionName = "RefactoringTechniques",
                    ControllerName = "ProgrammingFundamentals",
                    Context = "Refactoring improves code quality without changing functionality.",
                    Prerequisites = new List<string> { "Clean code", "Testing", "Design patterns" },
                    CareerPaths = new List<string> { "Senior Developer ($75K-$145K)", "Technical Lead ($85K-$165K)" },
                    Steps = new List<RoadmapStep>()
                },

                new Roadmap
                {
                    Id = 184,
                    Title = "API Development Basics",
                    Description = "Learn to design and build APIs",
                    Icon = "🔌",
                    Category = CategoryConstants.ProgrammingFundamentals,
                    Duration = "3-4 months",
                    Difficulty = "Intermediate",
                    ActionName = "APIDevelopmentBasics",
                    ControllerName = "ProgrammingFundamentals",
                    Context = "APIs are the backbone of modern software integration.",
                    Prerequisites = new List<string> { "HTTP basics", "JSON/XML", "Backend basics" },
                    CareerPaths = new List<string> { "API Developer ($70K-$135K)", "Backend Developer ($75K-$145K)" },
                    Steps = new List<RoadmapStep>()
                }
            };

            // Add extended subtopics
            AddExtendedSubTopics(roadmaps);
            
            // Update Azure Developer roadmap with comprehensive structure
            UpdateAzureDeveloperRoadmap(roadmaps);
            
            // Update C# Developer roadmap with comprehensive structure
            UpdateCSharpDeveloperRoadmap(roadmaps);
            
            // Update Software Architect roadmap with comprehensive structure
            UpdateSoftwareArchitectRoadmap(roadmaps);
            
            // Update SQL & Database Developer roadmap with comprehensive structure
            UpdateSQLDatabaseDeveloperRoadmap(roadmaps);
            
            // Update Angular roadmap with comprehensive structure
            UpdateAngularRoadmap(roadmaps);
            
            // Update Azure DevOps & Git CI/CD roadmap with comprehensive structure
            UpdateAzureDevOpsGitCICDRoadmap(roadmaps);
            
            // Update JavaScript roadmap with comprehensive structure
            UpdateJavaScriptRoadmap(roadmaps);
            
            return roadmaps;
        }
    }
}