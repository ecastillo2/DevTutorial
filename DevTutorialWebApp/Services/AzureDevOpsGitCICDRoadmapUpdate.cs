using System.Collections.Generic;
using System.Linq;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Services
{
    public partial class RoadmapService
    {
        private void UpdateAzureDevOpsGitCICDRoadmap(List<Roadmap> roadmaps)
        {
            var azureDevOps = roadmaps.FirstOrDefault(r => r.Id == 22);
            if (azureDevOps != null)
            {
                // Update the Azure DevOps & Git CI/CD roadmap with comprehensive structure
                azureDevOps.Title = "Azure DevOps & Git CI/CD";
                azureDevOps.Description = "Master version control, continuous integration, deployment pipelines, and DevOps practices";
                azureDevOps.Duration = "10-14 months";
                azureDevOps.Difficulty = "Intermediate to Expert";
                azureDevOps.Context = "Azure DevOps & Git CI/CD encompasses the complete software development lifecycle from source control to production deployment. This comprehensive path covers Git workflows, Azure DevOps services, pipeline automation, testing integration, security practices, and advanced DevOps patterns for enterprise-scale development.";
                
                azureDevOps.Prerequisites = new List<string>
                {
                    "Basic programming experience in any language",
                    "Understanding of software development lifecycle",
                    "Command line familiarity",
                    "Basic networking concepts",
                    "Version control concepts"
                };
                
                azureDevOps.CareerPaths = new List<string>
                {
                    "DevOps Engineer ($80K-$150K)",
                    "Build Engineer ($70K-$130K)",
                    "Release Manager ($85K-$160K)",
                    "Site Reliability Engineer ($90K-$170K)",
                    "Platform Engineer ($95K-$180K)",
                    "DevOps Architect ($110K-$200K)"
                };

                // Replace existing steps with comprehensive 14-category structure
                azureDevOps.Steps = new List<RoadmapStep>
                {
                    // 1. Core Git & Source Control
                    new RoadmapStep
                    {
                        Id = 2201,
                        RoadmapId = 22,
                        Title = "Core Git & Source Control",
                        Duration = "3-4 weeks",
                        Content = "Master Git fundamentals, branching strategies, and collaborative workflows for professional development",
                        KeyConcepts = new List<string> 
                        { 
                            "Git Fundamentals",
                            "Branching Strategies",
                            "Merge vs Rebase",
                            "Pull Requests & Code Reviews",
                            "Git LFS for Large Files",
                            "Commit Best Practices"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 22011, StepId = 2201, Description = "Master advanced Git commands and workflows" },
                            new LearningObjective { Id = 22012, StepId = 2201, Description = "Implement professional branching strategies" },
                            new LearningObjective { Id = 22013, StepId = 2201, Description = "Resolve complex merge conflicts effectively" },
                            new LearningObjective { Id = 22014, StepId = 2201, Description = "Establish code review best practices" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 22011, StepId = 2201, Title = "Pro Git Book", Type = "Book", Url = "https://git-scm.com/book" },
                            new Resource { Id = 22012, StepId = 2201, Title = "Git Branching Strategies", Type = "Guide", Url = "https://docs.microsoft.com/en-us/azure/devops/repos/git/git-branching-guidance" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Set up Git Flow workflow for a team project",
                            "Resolve complex merge conflicts in a simulated scenario",
                            "Create and enforce branch policies with protection rules"
                        }
                    },

                    // 2. Azure DevOps Fundamentals
                    new RoadmapStep
                    {
                        Id = 2202,
                        RoadmapId = 22,
                        Title = "Azure DevOps Fundamentals",
                        Duration = "2-3 weeks",
                        Content = "Master Azure DevOps services, organization structure, and service integrations",
                        KeyConcepts = new List<string>
                        {
                            "Azure DevOps Services Overview",
                            "Project & Organization Structure",
                            "Service Connections",
                            "Users & Permissions",
                            "Integration Points",
                            "Auditing & Compliance"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 22021, StepId = 2202, Description = "Configure Azure DevOps organizations and projects" },
                            new LearningObjective { Id = 22022, StepId = 2202, Description = "Set up service connections securely" },
                            new LearningObjective { Id = 22023, StepId = 2202, Description = "Manage users and permissions effectively" },
                            new LearningObjective { Id = 22024, StepId = 2202, Description = "Implement compliance and audit logging" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 22021, StepId = 2202, Title = "Azure DevOps Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/en-us/azure/devops/" },
                            new Resource { Id = 22022, StepId = 2202, Title = "Service Connections Guide", Type = "Guide", Url = "https://docs.microsoft.com/en-us/azure/devops/pipelines/library/service-endpoints" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Set up enterprise Azure DevOps organization",
                            "Configure service connections to Azure and third-party services",
                            "Implement role-based access control across teams"
                        }
                    },

                    // 3. Continuous Integration (CI)
                    new RoadmapStep
                    {
                        Id = 2203,
                        RoadmapId = 22,
                        Title = "Continuous Integration (CI)",
                        Duration = "4-5 weeks",
                        Content = "Build comprehensive CI pipelines with testing, analysis, and quality gates",
                        KeyConcepts = new List<string>
                        {
                            "YAML Pipeline Structure",
                            "Multi-language Build Support",
                            "Agent Management",
                            "Pipeline Templates",
                            "Testing Integration",
                            "Code Quality Analysis"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 22031, StepId = 2203, Description = "Design scalable CI pipeline architectures" },
                            new LearningObjective { Id = 22032, StepId = 2203, Description = "Integrate automated testing at all levels" },
                            new LearningObjective { Id = 22033, StepId = 2203, Description = "Implement code quality gates and analysis" },
                            new LearningObjective { Id = 22034, StepId = 2203, Description = "Optimize build performance with caching" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 22031, StepId = 2203, Title = "Azure Pipelines YAML Schema", Type = "Reference", Url = "https://docs.microsoft.com/en-us/azure/devops/pipelines/yaml-schema" },
                            new Resource { Id = 22032, StepId = 2203, Title = "CI/CD Best Practices", Type = "Guide", Url = "https://docs.microsoft.com/en-us/azure/devops/learn/what-is-continuous-integration" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build multi-stage CI pipeline for .NET application",
                            "Integrate SonarQube for code quality analysis",
                            "Create reusable pipeline templates library"
                        }
                    },

                    // 4. Continuous Delivery & Deployment (CD)
                    new RoadmapStep
                    {
                        Id = 2204,
                        RoadmapId = 22,
                        Title = "Continuous Delivery & Deployment (CD)",
                        Duration = "4-5 weeks",
                        Content = "Master deployment strategies, infrastructure automation, and release management",
                        KeyConcepts = new List<string>
                        {
                            "Release Pipeline Strategies",
                            "Environment Management",
                            "Deployment Patterns",
                            "Infrastructure as Code",
                            "Approval Workflows",
                            "Rollback Strategies"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 22041, StepId = 2204, Description = "Implement advanced deployment strategies" },
                            new LearningObjective { Id = 22042, StepId = 2204, Description = "Automate infrastructure provisioning" },
                            new LearningObjective { Id = 22043, StepId = 2204, Description = "Configure multi-environment promotion" },
                            new LearningObjective { Id = 22044, StepId = 2204, Description = "Design effective approval and gate systems" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 22041, StepId = 2204, Title = "Deployment Strategies Guide", Type = "Guide", Url = "https://docs.microsoft.com/en-us/azure/devops/pipelines/process/deployment-jobs" },
                            new Resource { Id = 22042, StepId = 2204, Title = "Infrastructure as Code in Azure", Type = "Tutorial", Url = "https://docs.microsoft.com/en-us/azure/azure-resource-manager/" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Implement blue-green deployment pipeline",
                            "Set up canary release with monitoring",
                            "Automate infrastructure with ARM templates"
                        }
                    },

                    // 5. Artifact & Package Management
                    new RoadmapStep
                    {
                        Id = 2205,
                        RoadmapId = 22,
                        Title = "Artifact & Package Management",
                        Duration = "2-3 weeks",
                        Content = "Master package management, versioning strategies, and artifact distribution",
                        KeyConcepts = new List<string>
                        {
                            "Azure Artifacts Overview",
                            "Package Feed Management",
                            "Versioning Strategies",
                            "Universal Packages",
                            "External Feed Integration",
                            "Security & Access Control"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 22051, StepId = 2205, Description = "Configure multi-format package feeds" },
                            new LearningObjective { Id = 22052, StepId = 2205, Description = "Implement semantic versioning strategies" },
                            new LearningObjective { Id = 22053, StepId = 2205, Description = "Secure package distribution" },
                            new LearningObjective { Id = 22054, StepId = 2205, Description = "Integrate with external package sources" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 22051, StepId = 2205, Title = "Azure Artifacts Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/en-us/azure/devops/artifacts/" },
                            new Resource { Id = 22052, StepId = 2205, Title = "Package Management Best Practices", Type = "Guide", Url = "https://docs.microsoft.com/en-us/azure/devops/artifacts/concepts/best-practices" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Set up multi-format feeds for NuGet, npm, and Maven",
                            "Implement automated package versioning",
                            "Configure upstream sources and feed security"
                        }
                    },

                    // 6. Testing & Quality Assurance
                    new RoadmapStep
                    {
                        Id = 2206,
                        RoadmapId = 22,
                        Title = "Testing & Quality Assurance",
                        Duration = "3-4 weeks",
                        Content = "Integrate comprehensive testing strategies into CI/CD pipelines",
                        KeyConcepts = new List<string>
                        {
                            "Automated Testing Pyramid",
                            "Test Execution in Pipelines",
                            "Quality Gates",
                            "Test Plans & Case Management",
                            "Performance Testing",
                            "Security Testing Integration"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 22061, StepId = 2206, Description = "Implement comprehensive testing strategies" },
                            new LearningObjective { Id = 22062, StepId = 2206, Description = "Configure quality gates and thresholds" },
                            new LearningObjective { Id = 22063, StepId = 2206, Description = "Automate security testing in pipelines" },
                            new LearningObjective { Id = 22064, StepId = 2206, Description = "Generate and analyze test reports" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 22061, StepId = 2206, Title = "Azure Test Plans Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/en-us/azure/devops/test/" },
                            new Resource { Id = 22062, StepId = 2206, Title = "Testing in DevOps", Type = "Guide", Url = "https://docs.microsoft.com/en-us/azure/devops/learn/what-is-continuous-testing" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build testing pyramid with unit, integration, and E2E tests",
                            "Configure quality gates with coverage thresholds",
                            "Set up automated security scanning with OWASP tools"
                        }
                    },

                    // 7. Security & Compliance in CI/CD
                    new RoadmapStep
                    {
                        Id = 2207,
                        RoadmapId = 22,
                        Title = "Security & Compliance in CI/CD",
                        Duration = "3-4 weeks",
                        Content = "Implement DevSecOps practices, secrets management, and compliance automation",
                        KeyConcepts = new List<string>
                        {
                            "DevSecOps Practices",
                            "Secrets Management",
                            "Identity & Access Control",
                            "Compliance Automation",
                            "Vulnerability Scanning",
                            "Audit Logging"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 22071, StepId = 2207, Description = "Implement secure secrets management" },
                            new LearningObjective { Id = 22072, StepId = 2207, Description = "Configure identity-based pipeline security" },
                            new LearningObjective { Id = 22073, StepId = 2207, Description = "Automate compliance checking" },
                            new LearningObjective { Id = 22074, StepId = 2207, Description = "Set up vulnerability scanning workflows" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 22071, StepId = 2207, Title = "DevSecOps with Azure DevOps", Type = "Guide", Url = "https://docs.microsoft.com/en-us/azure/devops/migrate/security-validation-cicd-pipeline" },
                            new Resource { Id = 22072, StepId = 2207, Title = "Azure Key Vault with Pipelines", Type = "Tutorial", Url = "https://docs.microsoft.com/en-us/azure/devops/pipelines/release/azure-key-vault" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Implement Key Vault integration for secrets",
                            "Set up dependency scanning with WhiteSource/Snyk",
                            "Configure managed identities for pipeline security"
                        }
                    },

                    // 8. Monitoring & Observability
                    new RoadmapStep
                    {
                        Id = 2208,
                        RoadmapId = 22,
                        Title = "Monitoring & Observability",
                        Duration = "2-3 weeks",
                        Content = "Implement comprehensive monitoring, logging, and alerting for pipelines and deployments",
                        KeyConcepts = new List<string>
                        {
                            "Pipeline Monitoring",
                            "Deployment Observability",
                            "Azure Monitor Integration",
                            "Log Analytics",
                            "Alerting & Notifications",
                            "Recovery Strategies"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 22081, StepId = 2208, Description = "Set up comprehensive pipeline monitoring" },
                            new LearningObjective { Id = 22082, StepId = 2208, Description = "Implement deployment health tracking" },
                            new LearningObjective { Id = 22083, StepId = 2208, Description = "Configure automated alerting systems" },
                            new LearningObjective { Id = 22084, StepId = 2208, Description = "Design effective rollback procedures" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 22081, StepId = 2208, Title = "Azure Monitor Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/en-us/azure/azure-monitor/" },
                            new Resource { Id = 22082, StepId = 2208, Title = "Pipeline Monitoring Best Practices", Type = "Guide", Url = "https://docs.microsoft.com/en-us/azure/devops/pipelines/reports/pipelinereport" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Set up Application Insights for deployment tracking",
                            "Create custom dashboards for pipeline metrics",
                            "Configure automated rollback on failure detection"
                        }
                    },

                    // 9. Agile Project Management (Boards)
                    new RoadmapStep
                    {
                        Id = 2209,
                        RoadmapId = 22,
                        Title = "Agile Project Management (Boards)",
                        Duration = "2-3 weeks",
                        Content = "Master Azure Boards for agile project management and work item tracking",
                        KeyConcepts = new List<string>
                        {
                            "Agile Process Templates",
                            "Work Item Hierarchies",
                            "Kanban & Sprint Boards",
                            "Backlog Management",
                            "Dashboards & Reporting",
                            "Third-party Integrations"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 22091, StepId = 2209, Description = "Configure agile processes for teams" },
                            new LearningObjective { Id = 22092, StepId = 2209, Description = "Set up effective work item tracking" },
                            new LearningObjective { Id = 22093, StepId = 2209, Description = "Create insightful dashboards and reports" },
                            new LearningObjective { Id = 22094, StepId = 2209, Description = "Integrate with external project management tools" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 22091, StepId = 2209, Title = "Azure Boards Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/en-us/azure/devops/boards/" },
                            new Resource { Id = 22092, StepId = 2209, Title = "Agile Process Guidance", Type = "Guide", Url = "https://docs.microsoft.com/en-us/azure/devops/boards/work-items/guidance/" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Set up Scrum process with custom work item types",
                            "Create automated sprint burndown dashboards",
                            "Configure Jira synchronization with Azure Boards"
                        }
                    },

                    // 10. Collaboration & Integration
                    new RoadmapStep
                    {
                        Id = 2210,
                        RoadmapId = 22,
                        Title = "Collaboration & Integration",
                        Duration = "2-3 weeks",
                        Content = "Master team collaboration tools and external service integrations",
                        KeyConcepts = new List<string>
                        {
                            "GitHub Actions Integration",
                            "Communication Integrations",
                            "Third-party Tool Connections",
                            "Webhook Automation",
                            "Hybrid Workflows",
                            "API Automation"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 22101, StepId = 2210, Description = "Integrate with GitHub Actions workflows" },
                            new LearningObjective { Id = 22102, StepId = 2210, Description = "Set up automated notifications and updates" },
                            new LearningObjective { Id = 22103, StepId = 2210, Description = "Configure webhook-driven automation" },
                            new LearningObjective { Id = 22104, StepId = 2210, Description = "Design hybrid development workflows" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 22101, StepId = 2210, Title = "Azure DevOps REST API", Type = "API Reference", Url = "https://docs.microsoft.com/en-us/rest/api/azure/devops/" },
                            new Resource { Id = 22102, StepId = 2210, Title = "Service Hooks Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/en-us/azure/devops/service-hooks/" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Create Slack/Teams integration for pipeline notifications",
                            "Build webhook automation for external systems",
                            "Set up GitHub to Azure DevOps synchronization"
                        }
                    },

                    // 11. Infrastructure as Code & Automation
                    new RoadmapStep
                    {
                        Id = 2211,
                        RoadmapId = 22,
                        Title = "Infrastructure as Code & Automation",
                        Duration = "4-5 weeks",
                        Content = "Master infrastructure automation with ARM, Bicep, Terraform, and configuration management",
                        KeyConcepts = new List<string>
                        {
                            "ARM Templates & Bicep",
                            "Terraform Integration",
                            "Configuration Management",
                            "PowerShell & Bash Automation",
                            "Desired State Configuration",
                            "Infrastructure Testing"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 22111, StepId = 2211, Description = "Master ARM templates and Bicep" },
                            new LearningObjective { Id = 22112, StepId = 2211, Description = "Integrate Terraform with Azure Pipelines" },
                            new LearningObjective { Id = 22113, StepId = 2211, Description = "Automate configuration management" },
                            new LearningObjective { Id = 22114, StepId = 2211, Description = "Test infrastructure code" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 22111, StepId = 2211, Title = "Bicep Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/en-us/azure/azure-resource-manager/bicep/" },
                            new Resource { Id = 22112, StepId = 2211, Title = "Terraform on Azure", Type = "Tutorial", Url = "https://docs.microsoft.com/en-us/azure/developer/terraform/" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Convert ARM templates to Bicep",
                            "Build Terraform pipeline with state management",
                            "Implement infrastructure testing with Pester"
                        }
                    },

                    // 12. Advanced Topics
                    new RoadmapStep
                    {
                        Id = 2212,
                        RoadmapId = 22,
                        Title = "Advanced DevOps Topics",
                        Duration = "3-4 weeks",
                        Content = "Master advanced DevOps patterns including multi-cloud, containerization, and scaling",
                        KeyConcepts = new List<string>
                        {
                            "Multi-tenant Pipeline Design",
                            "Monorepo vs Polyrepo Strategies",
                            "Pipeline Templates & Libraries",
                            "Containerized Builds",
                            "Agent Scaling",
                            "Cost Optimization"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 22121, StepId = 2212, Description = "Design enterprise-scale pipeline architectures" },
                            new LearningObjective { Id = 22122, StepId = 2212, Description = "Implement containerized build strategies" },
                            new LearningObjective { Id = 22123, StepId = 2212, Description = "Scale self-hosted agents effectively" },
                            new LearningObjective { Id = 22124, StepId = 2212, Description = "Optimize pipeline costs and performance" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 22121, StepId = 2212, Title = "Enterprise DevOps Patterns", Type = "Guide", Url = "https://docs.microsoft.com/en-us/azure/devops/migrate/migrate-from-tfvc-to-git" },
                            new Resource { Id = 22122, StepId = 2212, Title = "Container-based Builds", Type = "Tutorial", Url = "https://docs.microsoft.com/en-us/azure/devops/pipelines/process/container-phases" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Build multi-cloud deployment pipeline",
                            "Implement matrix builds with parallel jobs",
                            "Set up auto-scaling agent pools"
                        }
                    },

                    // 13. Governance & Best Practices
                    new RoadmapStep
                    {
                        Id = 2213,
                        RoadmapId = 22,
                        Title = "Governance & Best Practices",
                        Duration = "2-3 weeks",
                        Content = "Implement governance policies, standards, and enterprise best practices",
                        KeyConcepts = new List<string>
                        {
                            "Policy Enforcement",
                            "Branch & PR Policies",
                            "Naming Conventions",
                            "Template Libraries",
                            "Resource Usage Monitoring",
                            "SLA Management"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 22131, StepId = 2213, Description = "Implement enterprise governance policies" },
                            new LearningObjective { Id = 22132, StepId = 2213, Description = "Create reusable template libraries" },
                            new LearningObjective { Id = 22133, StepId = 2213, Description = "Monitor and optimize resource usage" },
                            new LearningObjective { Id = 22134, StepId = 2213, Description = "Establish pipeline SLAs and reliability" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 22131, StepId = 2213, Title = "Branch Policies Guide", Type = "Guide", Url = "https://docs.microsoft.com/en-us/azure/devops/repos/git/branch-policies" },
                            new Resource { Id = 22132, StepId = 2213, Title = "Pipeline Templates", Type = "Documentation", Url = "https://docs.microsoft.com/en-us/azure/devops/pipelines/process/templates" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Implement organization-wide policies",
                            "Create centralized template library",
                            "Set up cost monitoring and optimization"
                        }
                    },

                    // 14. Emerging & Specialized Areas
                    new RoadmapStep
                    {
                        Id = 2214,
                        RoadmapId = 22,
                        Title = "Emerging & Specialized Areas",
                        Duration = "4-5 weeks",
                        Content = "Explore cutting-edge DevOps practices including AI integration, chaos engineering, and GitOps",
                        KeyConcepts = new List<string>
                        {
                            "AI-driven DevOps",
                            "GitHub Copilot in CI/CD",
                            "Chaos Engineering",
                            "Green DevOps Practices",
                            "GitOps with Flux/ArgoCD",
                            "Service Mesh Deployment"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 22141, StepId = 2214, Description = "Implement AI-assisted pipeline optimization" },
                            new LearningObjective { Id = 22142, StepId = 2214, Description = "Set up chaos engineering practices" },
                            new LearningObjective { Id = 22143, StepId = 2214, Description = "Implement sustainable DevOps practices" },
                            new LearningObjective { Id = 22144, StepId = 2214, Description = "Deploy with GitOps methodologies" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 22141, StepId = 2214, Title = "GitOps with Azure Arc", Type = "Guide", Url = "https://docs.microsoft.com/en-us/azure/azure-arc/kubernetes/tutorial-use-gitops-flux2" },
                            new Resource { Id = 22142, StepId = 2214, Title = "Chaos Engineering Principles", Type = "Article", Url = "https://principlesofchaos.org/" }
                        },
                        PracticalExercises = new List<string>
                        {
                            "Implement GitOps workflow with Flux on AKS",
                            "Set up chaos engineering experiments",
                            "Build carbon-aware deployment strategies"
                        }
                    }
                };
            }
        }
    }
}