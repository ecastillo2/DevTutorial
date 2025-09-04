using System.Collections.Generic;
using System.Linq;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Services
{
    public partial class RoadmapService
    {
        private void UpdateAzureDeveloperRoadmap(List<Roadmap> roadmaps)
        {
            var azureDev = roadmaps.FirstOrDefault(r => r.Id == 24);
            if (azureDev != null)
            {
                // Update the Azure Developer roadmap with comprehensive structure
                azureDev.Title = "Azure Developer / Architect";
                azureDev.Description = "Master Microsoft Azure cloud platform for development, architecture, security, and DevOps";
                azureDev.Duration = "8-12 months";
                azureDev.Difficulty = "Beginner to Expert";
                azureDev.Context = "Microsoft Azure is a comprehensive cloud computing platform offering 200+ services across compute, storage, networking, databases, analytics, AI, IoT, and more. This learning path covers development, architecture, security, DevOps, and advanced cloud concepts.";
                
                azureDev.Prerequisites = new List<string>
                {
                    "Programming knowledge (C#, Python, or JavaScript preferred)",
                    "Understanding of web technologies and REST APIs",
                    "Basic networking and database concepts",
                    "Familiarity with Git and version control"
                };
                
                azureDev.CareerPaths = new List<string>
                {
                    "Azure Developer ($80K-$150K)",
                    "Cloud Solutions Architect ($100K-$200K)",
                    "Azure DevOps Engineer ($90K-$170K)",
                    "Cloud Security Engineer ($95K-$180K)",
                    "Azure AI/ML Engineer ($110K-$190K)"
                };

                // Replace existing steps with comprehensive 17-category structure
                azureDev.Steps = new List<RoadmapStep>
                {
                    // 1. Core Azure Fundamentals
                    new RoadmapStep
                    {
                        Id = 2401,
                        RoadmapId = 24,
                        Title = "Core Azure Fundamentals",
                        Duration = "2-3 weeks",
                        Content = "Master the foundational concepts of Microsoft Azure cloud platform",
                        KeyConcepts = new List<string> 
                        { 
                            "Azure Resource Manager (ARM)",
                            "Subscriptions & Management Groups",
                            "Resource Groups & Tags",
                            "Azure Regions & Availability",
                            "Azure Policy & Governance"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 24011, StepId = 2401, Description = "Navigate Azure Portal, CLI, and PowerShell effectively" },
                            new LearningObjective { Id = 24012, StepId = 2401, Description = "Create and manage ARM templates and Bicep files" },
                            new LearningObjective { Id = 24013, StepId = 2401, Description = "Implement governance with Azure Policy and Blueprints" },
                            new LearningObjective { Id = 24014, StepId = 2401, Description = "Design subscription and resource group hierarchy" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 24011, StepId = 2401, Title = "Azure Fundamentals Learning Path", Type = "Course", Url = "https://docs.microsoft.com/learn/paths/azure-fundamentals/" },
                            new Resource { Id = 24012, StepId = 2401, Title = "ARM Template Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/azure/azure-resource-manager/templates/" }
                        }
                    },

                    // 2. Compute Services
                    new RoadmapStep
                    {
                        Id = 2402,
                        RoadmapId = 24,
                        Title = "Azure Compute Services",
                        Duration = "3-4 weeks",
                        Content = "Master all Azure compute options from VMs to serverless",
                        KeyConcepts = new List<string>
                        {
                            "Virtual Machines & Scale Sets",
                            "App Service (Web, API, Mobile)",
                            "Azure Functions (Serverless)",
                            "Azure Kubernetes Service (AKS)",
                            "Container Instances & Batch"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 24021, StepId = 2402, Description = "Deploy and manage VMs with availability sets" },
                            new LearningObjective { Id = 24022, StepId = 2402, Description = "Build scalable web apps with App Service" },
                            new LearningObjective { Id = 24023, StepId = 2402, Description = "Create serverless solutions with Azure Functions" },
                            new LearningObjective { Id = 24024, StepId = 2402, Description = "Deploy containerized apps with AKS" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 24021, StepId = 2402, Title = "Azure Compute Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/azure/virtual-machines/" },
                            new Resource { Id = 24022, StepId = 2402, Title = "AKS Workshop", Type = "Workshop", Url = "https://aksworkshop.io/" }
                        }
                    },

                    // 3. Networking
                    new RoadmapStep
                    {
                        Id = 2403,
                        RoadmapId = 24,
                        Title = "Azure Networking",
                        Duration = "3-4 weeks",
                        Content = "Design and implement secure network architectures in Azure",
                        KeyConcepts = new List<string>
                        {
                            "Virtual Networks & Subnets",
                            "Network Security Groups",
                            "Load Balancers & App Gateway",
                            "VPN & ExpressRoute",
                            "Azure Firewall & WAF"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 24031, StepId = 2403, Description = "Design VNet architectures with peering and service endpoints" },
                            new LearningObjective { Id = 24032, StepId = 2403, Description = "Implement network security with NSGs and Azure Firewall" },
                            new LearningObjective { Id = 24033, StepId = 2403, Description = "Configure load balancing and traffic management" },
                            new LearningObjective { Id = 24034, StepId = 2403, Description = "Set up hybrid connectivity with VPN/ExpressRoute" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 24031, StepId = 2403, Title = "Azure Networking Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/azure/networking/" },
                            new Resource { Id = 24032, StepId = 2403, Title = "Network Security Best Practices", Type = "Article", Url = "https://docs.microsoft.com/azure/security/fundamentals/network-best-practices" }
                        }
                    },

                    // 4. Storage
                    new RoadmapStep
                    {
                        Id = 2404,
                        RoadmapId = 24,
                        Title = "Azure Storage Solutions",
                        Duration = "2-3 weeks",
                        Content = "Master Azure storage services for different data types and scenarios",
                        KeyConcepts = new List<string>
                        {
                            "Blob Storage & Tiers",
                            "Azure Files & File Sync",
                            "Table & Queue Storage",
                            "Disk Storage Types",
                            "Data Lake Storage Gen2"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 24041, StepId = 2404, Description = "Implement blob storage with lifecycle management" },
                            new LearningObjective { Id = 24042, StepId = 2404, Description = "Configure Azure Files for shared storage" },
                            new LearningObjective { Id = 24043, StepId = 2404, Description = "Design data lake architectures" },
                            new LearningObjective { Id = 24044, StepId = 2404, Description = "Implement backup and disaster recovery" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 24041, StepId = 2404, Title = "Azure Storage Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/azure/storage/" },
                            new Resource { Id = 24042, StepId = 2404, Title = "Data Lake Best Practices", Type = "Guide", Url = "https://docs.microsoft.com/azure/storage/blobs/data-lake-storage-best-practices" }
                        }
                    },

                    // 5. Databases
                    new RoadmapStep
                    {
                        Id = 2405,
                        RoadmapId = 24,
                        Title = "Azure Database Services",
                        Duration = "3-4 weeks",
                        Content = "Deploy and manage various database solutions in Azure",
                        KeyConcepts = new List<string>
                        {
                            "Azure SQL Database & MI",
                            "Cosmos DB & Partitioning",
                            "PostgreSQL, MySQL, MariaDB",
                            "Synapse Analytics",
                            "Database Migration"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 24051, StepId = 2405, Description = "Deploy Azure SQL with elastic pools and geo-replication" },
                            new LearningObjective { Id = 24052, StepId = 2405, Description = "Design globally distributed apps with Cosmos DB" },
                            new LearningObjective { Id = 24053, StepId = 2405, Description = "Implement data warehousing with Synapse" },
                            new LearningObjective { Id = 24054, StepId = 2405, Description = "Migrate on-premises databases to Azure" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 24051, StepId = 2405, Title = "Azure SQL Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/azure/azure-sql/" },
                            new Resource { Id = 24052, StepId = 2405, Title = "Cosmos DB Design Patterns", Type = "Guide", Url = "https://docs.microsoft.com/azure/cosmos-db/design-patterns" }
                        }
                    },

                    // 6. Identity & Security
                    new RoadmapStep
                    {
                        Id = 2406,
                        RoadmapId = 24,
                        Title = "Identity & Security",
                        Duration = "3-4 weeks",
                        Content = "Implement comprehensive security and identity solutions",
                        KeyConcepts = new List<string>
                        {
                            "Azure AD & Conditional Access",
                            "Managed Identities",
                            "Azure Key Vault",
                            "RBAC & Zero Trust",
                            "Security Center & Sentinel"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 24061, StepId = 2406, Description = "Configure Azure AD with MFA and conditional access" },
                            new LearningObjective { Id = 24062, StepId = 2406, Description = "Implement managed identities for secure access" },
                            new LearningObjective { Id = 24063, StepId = 2406, Description = "Manage secrets with Key Vault" },
                            new LearningObjective { Id = 24064, StepId = 2406, Description = "Design Zero Trust architecture" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 24061, StepId = 2406, Title = "Azure AD Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/azure/active-directory/" },
                            new Resource { Id = 24062, StepId = 2406, Title = "Zero Trust Deployment Guide", Type = "Guide", Url = "https://docs.microsoft.com/security/zero-trust/" }
                        }
                    },

                    // 7. DevOps & CI/CD
                    new RoadmapStep
                    {
                        Id = 2407,
                        RoadmapId = 24,
                        Title = "Azure DevOps & CI/CD",
                        Duration = "3-4 weeks",
                        Content = "Implement DevOps practices with Azure DevOps and GitHub",
                        KeyConcepts = new List<string>
                        {
                            "Azure Repos & Pipelines",
                            "Infrastructure as Code",
                            "ARM, Bicep, Terraform",
                            "Release Management",
                            "Feature Flags"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 24071, StepId = 2407, Description = "Create CI/CD pipelines with Azure DevOps" },
                            new LearningObjective { Id = 24072, StepId = 2407, Description = "Implement IaC with Bicep or Terraform" },
                            new LearningObjective { Id = 24073, StepId = 2407, Description = "Configure deployment slots and blue-green deployments" },
                            new LearningObjective { Id = 24074, StepId = 2407, Description = "Implement feature flags with App Configuration" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 24071, StepId = 2407, Title = "Azure DevOps Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/azure/devops/" },
                            new Resource { Id = 24072, StepId = 2407, Title = "Bicep Learning Path", Type = "Course", Url = "https://docs.microsoft.com/learn/paths/bicep-deploy/" }
                        }
                    },

                    // 8. Monitoring & Management
                    new RoadmapStep
                    {
                        Id = 2408,
                        RoadmapId = 24,
                        Title = "Monitoring & Management",
                        Duration = "2-3 weeks",
                        Content = "Implement comprehensive monitoring and management solutions",
                        KeyConcepts = new List<string>
                        {
                            "Azure Monitor & Alerts",
                            "Application Insights",
                            "Log Analytics",
                            "Cost Management",
                            "Azure Automation"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 24081, StepId = 2408, Description = "Configure Azure Monitor with custom metrics and alerts" },
                            new LearningObjective { Id = 24082, StepId = 2408, Description = "Implement application monitoring with App Insights" },
                            new LearningObjective { Id = 24083, StepId = 2408, Description = "Create KQL queries for log analysis" },
                            new LearningObjective { Id = 24084, StepId = 2408, Description = "Implement cost optimization strategies" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 24081, StepId = 2408, Title = "Azure Monitor Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/azure/azure-monitor/" },
                            new Resource { Id = 24082, StepId = 2408, Title = "KQL Tutorial", Type = "Tutorial", Url = "https://docs.microsoft.com/azure/data-explorer/kusto/query/tutorial" }
                        }
                    },

                    // 9. Messaging & Integration
                    new RoadmapStep
                    {
                        Id = 2409,
                        RoadmapId = 24,
                        Title = "Messaging & Integration",
                        Duration = "3-4 weeks",
                        Content = "Build event-driven architectures with Azure messaging services",
                        KeyConcepts = new List<string>
                        {
                            "Service Bus Topics/Queues",
                            "Event Grid & Event Hubs",
                            "Logic Apps",
                            "API Management",
                            "Durable Functions"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 24091, StepId = 2409, Description = "Implement message-based communication with Service Bus" },
                            new LearningObjective { Id = 24092, StepId = 2409, Description = "Build event-driven solutions with Event Grid" },
                            new LearningObjective { Id = 24093, StepId = 2409, Description = "Create workflow automation with Logic Apps" },
                            new LearningObjective { Id = 24094, StepId = 2409, Description = "Design API strategies with APIM" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 24091, StepId = 2409, Title = "Azure Messaging Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/azure/messaging-services/" },
                            new Resource { Id = 24092, StepId = 2409, Title = "Event-Driven Architecture Guide", Type = "Guide", Url = "https://docs.microsoft.com/azure/architecture/guide/architecture-styles/event-driven" }
                        }
                    },

                    // 10. Data & Analytics
                    new RoadmapStep
                    {
                        Id = 2410,
                        RoadmapId = 24,
                        Title = "Data & Analytics",
                        Duration = "4-5 weeks",
                        Content = "Build modern data platforms and analytics solutions",
                        KeyConcepts = new List<string>
                        {
                            "Synapse Analytics",
                            "Data Factory & Pipelines",
                            "Azure Databricks",
                            "Stream Analytics",
                            "Power BI Embedded"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 24101, StepId = 2410, Description = "Build data pipelines with Data Factory" },
                            new LearningObjective { Id = 24102, StepId = 2410, Description = "Implement real-time analytics with Stream Analytics" },
                            new LearningObjective { Id = 24103, StepId = 2410, Description = "Create data lakes with Synapse" },
                            new LearningObjective { Id = 24104, StepId = 2410, Description = "Build ML pipelines with Databricks" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 24101, StepId = 2410, Title = "Azure Synapse Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/azure/synapse-analytics/" },
                            new Resource { Id = 24102, StepId = 2410, Title = "Modern Data Warehouse Pattern", Type = "Architecture", Url = "https://docs.microsoft.com/azure/architecture/solution-ideas/articles/modern-data-warehouse" }
                        }
                    },

                    // 11. AI & Machine Learning
                    new RoadmapStep
                    {
                        Id = 2411,
                        RoadmapId = 24,
                        Title = "AI & Machine Learning",
                        Duration = "4-5 weeks",
                        Content = "Implement AI solutions with Azure Cognitive Services and ML",
                        KeyConcepts = new List<string>
                        {
                            "Cognitive Services APIs",
                            "Azure OpenAI Service",
                            "Azure ML & MLOps",
                            "Bot Framework",
                            "Responsible AI"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 24111, StepId = 2411, Description = "Integrate Cognitive Services for vision, speech, and language" },
                            new LearningObjective { Id = 24112, StepId = 2411, Description = "Build applications with Azure OpenAI" },
                            new LearningObjective { Id = 24113, StepId = 2411, Description = "Implement MLOps with Azure ML" },
                            new LearningObjective { Id = 24114, StepId = 2411, Description = "Apply Responsible AI principles" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 24111, StepId = 2411, Title = "Azure AI Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/azure/cognitive-services/" },
                            new Resource { Id = 24112, StepId = 2411, Title = "Azure OpenAI Quickstart", Type = "Tutorial", Url = "https://docs.microsoft.com/azure/cognitive-services/openai/" }
                        }
                    },

                    // 12. IoT
                    new RoadmapStep
                    {
                        Id = 2412,
                        RoadmapId = 24,
                        Title = "Internet of Things (IoT)",
                        Duration = "3-4 weeks",
                        Content = "Build and manage IoT solutions with Azure IoT services",
                        KeyConcepts = new List<string>
                        {
                            "IoT Hub & DPS",
                            "IoT Edge Computing",
                            "Azure Sphere Security",
                            "Digital Twins",
                            "Time Series Insights"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 24121, StepId = 2412, Description = "Connect and manage devices with IoT Hub" },
                            new LearningObjective { Id = 24122, StepId = 2412, Description = "Deploy edge computing with IoT Edge" },
                            new LearningObjective { Id = 24123, StepId = 2412, Description = "Model physical systems with Digital Twins" },
                            new LearningObjective { Id = 24124, StepId = 2412, Description = "Implement IoT security best practices" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 24121, StepId = 2412, Title = "Azure IoT Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/azure/iot/" },
                            new Resource { Id = 24122, StepId = 2412, Title = "IoT Reference Architecture", Type = "Architecture", Url = "https://docs.microsoft.com/azure/architecture/reference-architectures/iot" }
                        }
                    },

                    // 13. Hybrid & Multi-Cloud
                    new RoadmapStep
                    {
                        Id = 2413,
                        RoadmapId = 24,
                        Title = "Hybrid & Multi-Cloud",
                        Duration = "3-4 weeks",
                        Content = "Design and implement hybrid cloud solutions with Azure Arc",
                        KeyConcepts = new List<string>
                        {
                            "Azure Arc",
                            "Azure Stack Family",
                            "VMware on Azure",
                            "Hybrid Connectivity",
                            "Multi-cloud Management"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 24131, StepId = 2413, Description = "Manage hybrid resources with Azure Arc" },
                            new LearningObjective { Id = 24132, StepId = 2413, Description = "Deploy Azure Stack for edge scenarios" },
                            new LearningObjective { Id = 24133, StepId = 2413, Description = "Implement hybrid identity solutions" },
                            new LearningObjective { Id = 24134, StepId = 2413, Description = "Design multi-cloud architectures" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 24131, StepId = 2413, Title = "Azure Arc Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/azure/azure-arc/" },
                            new Resource { Id = 24132, StepId = 2413, Title = "Hybrid Cloud Guide", Type = "Guide", Url = "https://docs.microsoft.com/azure/architecture/hybrid/" }
                        }
                    },

                    // 14. Migration & Modernization
                    new RoadmapStep
                    {
                        Id = 2414,
                        RoadmapId = 24,
                        Title = "Migration & Modernization",
                        Duration = "3-4 weeks",
                        Content = "Plan and execute cloud migration and modernization strategies",
                        KeyConcepts = new List<string>
                        {
                            "Cloud Adoption Framework",
                            "Azure Migrate Tools",
                            "App Modernization",
                            "Database Migration",
                            "Cost Optimization"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 24141, StepId = 2414, Description = "Apply Cloud Adoption Framework methodology" },
                            new LearningObjective { Id = 24142, StepId = 2414, Description = "Assess and migrate workloads with Azure Migrate" },
                            new LearningObjective { Id = 24143, StepId = 2414, Description = "Modernize applications using cloud-native services" },
                            new LearningObjective { Id = 24144, StepId = 2414, Description = "Implement FinOps practices" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 24141, StepId = 2414, Title = "Cloud Adoption Framework", Type = "Framework", Url = "https://docs.microsoft.com/azure/cloud-adoption-framework/" },
                            new Resource { Id = 24142, StepId = 2414, Title = "Migration Guide", Type = "Guide", Url = "https://docs.microsoft.com/azure/migrate/" }
                        }
                    },

                    // 15. Advanced Architecture & Design
                    new RoadmapStep
                    {
                        Id = 2415,
                        RoadmapId = 24,
                        Title = "Advanced Architecture & Design",
                        Duration = "4-5 weeks",
                        Content = "Master advanced architectural patterns and design principles",
                        KeyConcepts = new List<string>
                        {
                            "High Availability & DR",
                            "Global Scale Design",
                            "Microservices Patterns",
                            "Event-Driven Architecture",
                            "Performance Optimization"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 24151, StepId = 2415, Description = "Design for 99.99% availability" },
                            new LearningObjective { Id = 24152, StepId = 2415, Description = "Implement microservices with service mesh" },
                            new LearningObjective { Id = 24153, StepId = 2415, Description = "Build event-driven systems at scale" },
                            new LearningObjective { Id = 24154, StepId = 2415, Description = "Optimize for performance and cost" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 24151, StepId = 2415, Title = "Azure Architecture Center", Type = "Architecture", Url = "https://docs.microsoft.com/azure/architecture/" },
                            new Resource { Id = 24152, StepId = 2415, Title = "Well-Architected Framework", Type = "Framework", Url = "https://docs.microsoft.com/azure/architecture/framework/" }
                        }
                    },

                    // 16. Compliance & Governance
                    new RoadmapStep
                    {
                        Id = 2416,
                        RoadmapId = 24,
                        Title = "Compliance & Governance",
                        Duration = "2-3 weeks",
                        Content = "Implement governance and ensure compliance in Azure",
                        KeyConcepts = new List<string>
                        {
                            "Azure Policy & Blueprints",
                            "Compliance Manager",
                            "Regulatory Standards",
                            "Resource Tagging",
                            "Cost Governance"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 24161, StepId = 2416, Description = "Implement governance with Azure Policy" },
                            new LearningObjective { Id = 24162, StepId = 2416, Description = "Ensure compliance with regulatory standards" },
                            new LearningObjective { Id = 24163, StepId = 2416, Description = "Design tagging strategies" },
                            new LearningObjective { Id = 24164, StepId = 2416, Description = "Implement cost allocation models" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 24161, StepId = 2416, Title = "Azure Governance Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/azure/governance/" },
                            new Resource { Id = 24162, StepId = 2416, Title = "Compliance Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/azure/compliance/" }
                        }
                    },

                    // 17. Emerging & Specialized Areas
                    new RoadmapStep
                    {
                        Id = 2417,
                        RoadmapId = 24,
                        Title = "Emerging & Specialized Technologies",
                        Duration = "3-4 weeks",
                        Content = "Explore cutting-edge Azure technologies and future trends",
                        KeyConcepts = new List<string>
                        {
                            "Confidential Computing",
                            "Quantum Computing",
                            "Edge Computing",
                            "Sustainability",
                            "Metaverse Technologies"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 24171, StepId = 2417, Description = "Implement confidential computing solutions" },
                            new LearningObjective { Id = 24172, StepId = 2417, Description = "Explore quantum computing with Azure Quantum" },
                            new LearningObjective { Id = 24173, StepId = 2417, Description = "Design edge computing architectures" },
                            new LearningObjective { Id = 24174, StepId = 2417, Description = "Apply sustainable cloud practices" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 24171, StepId = 2417, Title = "Azure Confidential Computing", Type = "Documentation", Url = "https://docs.microsoft.com/azure/confidential-computing/" },
                            new Resource { Id = 24172, StepId = 2417, Title = "Azure Quantum Development", Type = "Course", Url = "https://docs.microsoft.com/learn/paths/quantum-computing-fundamentals/" }
                        }
                    }
                };

                // Add practical exercises for each step
                foreach (var step in azureDev.Steps)
                {
                    step.PracticalExercises = GetPracticalExercisesForStep(step.Id);
                }
            }
        }

        private List<string> GetPracticalExercisesForStep(int stepId)
        {
            return stepId switch
            {
                2401 => new List<string>
                {
                    "Create a multi-subscription hierarchy with management groups",
                    "Deploy resources using ARM templates and Bicep",
                    "Implement governance policies for naming conventions",
                    "Set up cost alerts and budgets"
                },
                2402 => new List<string>
                {
                    "Deploy a highly available web application with App Service",
                    "Create a serverless API with Azure Functions",
                    "Deploy a microservices application on AKS",
                    "Implement auto-scaling for VM Scale Sets"
                },
                2403 => new List<string>
                {
                    "Design a hub-spoke network topology",
                    "Configure Application Gateway with WAF",
                    "Set up site-to-site VPN connection",
                    "Implement network security with Azure Firewall"
                },
                2404 => new List<string>
                {
                    "Implement blob storage lifecycle management",
                    "Set up geo-redundant backup solution",
                    "Create a data lake architecture",
                    "Configure CDN for static website hosting"
                },
                2405 => new List<string>
                {
                    "Deploy Azure SQL with automatic failover groups",
                    "Implement Cosmos DB with global distribution",
                    "Migrate on-premises database to Azure",
                    "Set up Synapse Analytics workspace"
                },
                2406 => new List<string>
                {
                    "Configure B2C tenant for customer authentication",
                    "Implement conditional access policies",
                    "Set up managed identities for app-to-app auth",
                    "Create security automation with Sentinel"
                },
                2407 => new List<string>
                {
                    "Create multi-stage CI/CD pipeline",
                    "Implement blue-green deployment strategy",
                    "Automate infrastructure deployment with Terraform",
                    "Set up feature flags for progressive rollout"
                },
                2408 => new List<string>
                {
                    "Create custom monitoring dashboard",
                    "Implement distributed tracing with App Insights",
                    "Set up log aggregation with KQL queries",
                    "Create cost optimization recommendations"
                },
                2409 => new List<string>
                {
                    "Build event-driven architecture with Event Grid",
                    "Implement message processing with Service Bus",
                    "Create workflow automation with Logic Apps",
                    "Design API gateway with rate limiting"
                },
                2410 => new List<string>
                {
                    "Build ETL pipeline with Data Factory",
                    "Implement real-time dashboard with Stream Analytics",
                    "Create data warehouse with Synapse",
                    "Build ML model with Databricks"
                },
                2411 => new List<string>
                {
                    "Integrate Computer Vision API for image analysis",
                    "Build chatbot with Bot Framework and LUIS",
                    "Implement sentiment analysis with Text Analytics",
                    "Create ML pipeline with Azure ML"
                },
                2412 => new List<string>
                {
                    "Connect IoT devices to IoT Hub",
                    "Deploy ML model to IoT Edge",
                    "Create Digital Twin solution",
                    "Implement IoT security best practices"
                },
                2413 => new List<string>
                {
                    "Manage on-premises servers with Arc",
                    "Deploy Azure Stack HCI cluster",
                    "Implement hybrid identity with AD Connect",
                    "Create multi-cloud governance strategy"
                },
                2414 => new List<string>
                {
                    "Assess workloads with Azure Migrate",
                    "Modernize .NET app to containers",
                    "Implement database migration strategy",
                    "Create cloud cost optimization plan"
                },
                2415 => new List<string>
                {
                    "Design multi-region active-active architecture",
                    "Implement CQRS and event sourcing",
                    "Create service mesh with Istio on AKS",
                    "Design for 99.99% availability"
                },
                2416 => new List<string>
                {
                    "Implement compliance policies for GDPR",
                    "Create resource tagging strategy",
                    "Set up cost allocation for departments",
                    "Implement security compliance dashboard"
                },
                2417 => new List<string>
                {
                    "Implement confidential VM for sensitive workloads",
                    "Create quantum algorithm with Q#",
                    "Deploy edge AI solution",
                    "Measure and reduce carbon footprint"
                },
                _ => new List<string>()
            };
        }
    }
}