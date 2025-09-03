using System.Collections.Generic;
using System.Linq;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Services
{
    public interface IChallengeService
    {
        List<Challenge> GetAllChallenges();
        List<Challenge> GetChallengesByCategory(string category);
        Challenge GetChallengeById(int id);
    }

    public class ChallengeService : IChallengeService
    {
        private readonly List<Challenge> _challenges;

        public ChallengeService()
        {
            _challenges = InitializeChallenges();
        }

        public List<Challenge> GetAllChallenges() => _challenges;

        public List<Challenge> GetChallengesByCategory(string category) => 
            _challenges.Where(c => c.Category == category).ToList();

        public Challenge GetChallengeById(int id) => 
            _challenges.FirstOrDefault(c => c.Id == id);

        private List<Challenge> InitializeChallenges()
        {
            return new List<Challenge>
            {
                // Scenario 1: Real-time IoT Event Processing
                new Challenge
                {
                    Id = 1,
                    Title = "Real-time IoT Event Processing",
                    Scenario = "Design a system that can handle 1 million IoT devices sending telemetry data every 10 seconds. The system needs to process events in real-time, detect anomalies, store raw data for analytics, and provide dashboards for monitoring.",
                    Category = ChallengeCategory.CloudDesign,
                    Difficulty = ChallengeDifficulty.Advanced,
                    Duration = "45-60 minutes",
                    Requirements = new List<string>
                    {
                        "Handle 1M+ events per second",
                        "Real-time anomaly detection",
                        "Store raw data for historical analysis",
                        "Provide real-time dashboards",
                        "Support for different device types",
                        "Scalable and cost-effective"
                    },
                    Constraints = new List<string>
                    {
                        "Must use Azure cloud services",
                        "Budget considerations for high throughput",
                        "Data retention for 7 years",
                        "Sub-second latency for alerts",
                        "99.9% availability requirement"
                    },
                    Solution = new ChallengeSolution
                    {
                        Id = 1,
                        ChallengeId = 1,
                        Overview = "The solution uses Azure Event Hub for high-throughput ingestion, Stream Analytics for real-time processing, Data Lake for storage, and Cosmos DB for fast queries. Power BI provides visualization capabilities.",
                        Architecture = "Event Hub → Stream Analytics/Azure Functions → Data Lake Storage + Cosmos DB → Power BI Dashboard",
                        Components = new List<ArchitectureComponent>
                        {
                            new ArchitectureComponent
                            {
                                Id = 1,
                                Name = "Azure Event Hub",
                                Purpose = "Ingestion of telemetry data",
                                Technology = "Azure Event Hub",
                                Justification = "Designed for high-throughput ingestion (millions of events/sec). Better than Service Bus for IoT scenarios due to partitioning and scalability."
                            },
                            new ArchitectureComponent
                            {
                                Id = 2,
                                Name = "Stream Analytics",
                                Purpose = "Real-time data processing and anomaly detection",
                                Technology = "Azure Stream Analytics",
                                Justification = "Serverless, SQL-based stream processing. Built-in anomaly detection capabilities and integration with ML models."
                            },
                            new ArchitectureComponent
                            {
                                Id = 3,
                                Name = "Data Lake Storage",
                                Purpose = "Raw data storage for analytics",
                                Technology = "Azure Data Lake Storage Gen2",
                                Justification = "Cost-effective storage for massive amounts of unstructured data with hierarchical namespace for analytics."
                            },
                            new ArchitectureComponent
                            {
                                Id = 4,
                                Name = "Cosmos DB",
                                Purpose = "Fast queries and real-time access",
                                Technology = "Azure Cosmos DB",
                                Justification = "Low-latency, globally distributed database for dashboard queries and device metadata."
                            }
                        },
                        ImplementationSteps = new List<string>
                        {
                            "Set up Event Hub with appropriate partition count",
                            "Configure Stream Analytics job with anomaly detection queries",
                            "Set up Data Lake Storage with proper folder structure",
                            "Deploy Cosmos DB with appropriate partition key",
                            "Create Power BI dashboards connected to processed data",
                            "Implement alerting for anomalies using Logic Apps",
                            "Set up monitoring and auto-scaling policies"
                        },
                        BestPractices = new List<string>
                        {
                            "Use partitioning in Event Hub for parallel processing",
                            "Implement proper error handling and dead letter queues",
                            "Use managed identities for secure authentication",
                            "Implement data lifecycle policies for cost optimization",
                            "Use connection pooling in IoT devices"
                        },
                        CodeExample = @"// Stream Analytics Query for Anomaly Detection
SELECT
    DeviceId,
    Temperature,
    Humidity,
    EventTime,
    AnomalyDetection_SpikeAndDip(Temperature, 95, 120, 'spikesanddips')
        OVER(PARTITION BY DeviceId LIMIT DURATION(minute, 2)) as SpikeAndDipScores
INTO
    [anomaly-output]
FROM
    [iothub-input]
WHERE
    AnomalyDetection_SpikeAndDip(Temperature, 95, 120, 'spikesanddips')
        OVER(PARTITION BY DeviceId LIMIT DURATION(minute, 2)) > 0.65"
                    }
                },

                // Scenario 2: High Availability Web API
                new Challenge
                {
                    Id = 2,
                    Title = "High Availability Web API",
                    Scenario = "Design a globally distributed web API that serves 10,000 requests per second with 99.99% uptime. The API needs to handle user authentication, serve data from multiple regions, and support zero-downtime deployments.",
                    Category = ChallengeCategory.Architecture,
                    Difficulty = ChallengeDifficulty.Advanced,
                    Duration = "45-60 minutes",
                    Requirements = new List<string>
                    {
                        "99.99% uptime (less than 1 hour downtime per year)",
                        "Global distribution across 3+ regions",
                        "10,000+ requests per second",
                        "Zero-downtime deployments",
                        "Automatic failover",
                        "Response time under 200ms globally"
                    },
                    Constraints = new List<string>
                    {
                        "Must support authentication",
                        "Data consistency requirements",
                        "Cost optimization needed",
                        "Security compliance (SOC 2)",
                        "Disaster recovery plan required"
                    },
                    Solution = new ChallengeSolution
                    {
                        Id = 2,
                        ChallengeId = 2,
                        Overview = "Multi-region deployment using Azure App Service with Azure Front Door for global load balancing, Azure SQL with geo-replication, and Azure DevOps for automated deployments using blue-green strategy.",
                        Architecture = "Azure Front Door → Multi-region App Service → Geo-replicated SQL Database + Redis Cache",
                        Components = new List<ArchitectureComponent>
                        {
                            new ArchitectureComponent
                            {
                                Id = 5,
                                Name = "Azure Front Door",
                                Purpose = "Global load balancing and SSL termination",
                                Technology = "Azure Front Door",
                                Justification = "Provides intelligent routing, SSL termination, and automatic failover between regions with built-in DDoS protection."
                            },
                            new ArchitectureComponent
                            {
                                Id = 6,
                                Name = "App Service",
                                Purpose = "API hosting with auto-scaling",
                                Technology = "Azure App Service (Premium tier)",
                                Justification = "Managed platform with deployment slots for zero-downtime deployments and auto-scaling capabilities."
                            },
                            new ArchitectureComponent
                            {
                                Id = 7,
                                Name = "SQL Database",
                                Purpose = "Primary data storage with geo-replication",
                                Technology = "Azure SQL Database",
                                Justification = "Managed database with active geo-replication for disaster recovery and read replicas for performance."
                            }
                        },
                        ImplementationSteps = new List<string>
                        {
                            "Deploy App Service in multiple regions (Primary, Secondary)",
                            "Set up Azure SQL with geo-replication",
                            "Configure Azure Front Door with health probes",
                            "Implement Redis Cache for session management",
                            "Set up Azure DevOps pipeline with blue-green deployments",
                            "Configure Application Insights for monitoring",
                            "Implement circuit breaker pattern in API"
                        },
                        BestPractices = new List<string>
                        {
                            "Use deployment slots for zero-downtime deployments",
                            "Implement health check endpoints",
                            "Use connection pooling and retry policies",
                            "Cache frequently accessed data in Redis",
                            "Monitor performance with Application Insights"
                        },
                        CodeExample = @"// Health Check Implementation
public class DatabaseHealthCheck : IHealthCheck
{
    private readonly IDbConnection _connection;
    
    public async Task<HealthCheckResult> CheckHealthAsync(
        HealthCheckContext context, 
        CancellationToken cancellationToken = default)
    {
        try
        {
            await _connection.QueryAsync(""SELECT 1"", cancellationToken);
            return HealthCheckResult.Healthy();
        }
        catch (Exception ex)
        {
            return HealthCheckResult.Unhealthy(exception: ex);
        }
    }
}"
                    }
                },

                // Scenario 3: Secure API with Authentication
                new Challenge
                {
                    Id = 3,
                    Title = "Secure API with Multi-tenant Authentication",
                    Scenario = "Design a secure multi-tenant API that supports both B2B (corporate users) and B2C (individual customers) authentication. The API needs to handle different permission levels, API rate limiting, and protect against common security threats.",
                    Category = ChallengeCategory.Security,
                    Difficulty = ChallengeDifficulty.Expert,
                    Duration = "60 minutes",
                    Requirements = new List<string>
                    {
                        "Support B2B and B2C authentication",
                        "Role-based access control (RBAC)",
                        "API rate limiting per client",
                        "Protection against OWASP top 10",
                        "Audit logging for compliance",
                        "Token-based authentication"
                    },
                    Constraints = new List<string>
                    {
                        "Multi-tenant isolation",
                        "GDPR compliance",
                        "PCI DSS for payment data",
                        "SOC 2 compliance",
                        "99.9% availability for auth service"
                    },
                    Solution = new ChallengeSolution
                    {
                        Id = 3,
                        ChallengeId = 3,
                        Overview = "Solution uses Azure AD for B2B authentication and Azure AD B2C for customer authentication, with API Management for rate limiting and security policies, and Key Vault for secrets management.",
                        Architecture = "Azure AD/B2C → Azure API Management → App Service → Key Vault + Application Insights",
                        Components = new List<ArchitectureComponent>
                        {
                            new ArchitectureComponent
                            {
                                Id = 8,
                                Name = "Azure AD",
                                Purpose = "B2B corporate authentication",
                                Technology = "Azure Active Directory",
                                Justification = "Enterprise-grade identity provider with support for SAML, OAuth2, and conditional access policies."
                            },
                            new ArchitectureComponent
                            {
                                Id = 9,
                                Name = "Azure AD B2C",
                                Purpose = "B2C customer authentication",
                                Technology = "Azure Active Directory B2C",
                                Justification = "Scalable identity service for customers with social login support and custom policies for complex scenarios."
                            },
                            new ArchitectureComponent
                            {
                                Id = 10,
                                Name = "API Management",
                                Purpose = "API gateway with security policies",
                                Technology = "Azure API Management",
                                Justification = "Provides rate limiting, JWT validation, IP filtering, and comprehensive API security policies."
                            }
                        },
                        ImplementationSteps = new List<string>
                        {
                            "Set up Azure AD tenant for B2B authentication",
                            "Configure Azure AD B2C with custom policies",
                            "Deploy API Management with JWT validation policies",
                            "Implement RBAC in API with claims-based authorization",
                            "Set up Key Vault for secrets and certificates",
                            "Configure rate limiting and throttling policies",
                            "Implement comprehensive audit logging"
                        },
                        BestPractices = new List<string>
                        {
                            "Use managed identities instead of connection strings",
                            "Implement principle of least privilege",
                            "Use HTTPS everywhere with HSTS headers",
                            "Implement proper CORS policies",
                            "Regular security scanning and penetration testing"
                        }
                    }
                },

                // Scenario 4: Event-Driven Microservices
                new Challenge
                {
                    Id = 4,
                    Title = "Event-Driven Microservices Architecture",
                    Scenario = "Design a scalable e-commerce platform with multiple microservices (inventory, orders, payments, notifications) that communicate through events. The system needs to handle high order volumes, ensure eventual consistency, and provide reliable message delivery.",
                    Category = ChallengeCategory.Microservices,
                    Difficulty = ChallengeDifficulty.Expert,
                    Duration = "60-90 minutes",
                    Requirements = new List<string>
                    {
                        "Event-driven communication between services",
                        "Handle 50K+ orders per hour",
                        "Eventual consistency across services",
                        "Reliable message delivery with retries",
                        "Dead letter queue handling",
                        "Saga pattern for distributed transactions"
                    },
                    Constraints = new List<string>
                    {
                        "Each service must be independently deployable",
                        "No direct service-to-service HTTP calls for business logic",
                        "Handle duplicate messages gracefully",
                        "Support for rollback scenarios",
                        "Audit trail for all business events"
                    },
                    Solution = new ChallengeSolution
                    {
                        Id = 4,
                        ChallengeId = 4,
                        Overview = "Solution uses Azure Service Bus for reliable messaging, implements Saga pattern for distributed transactions, and uses event sourcing for audit trails. Each microservice is containerized and deployed independently.",
                        Architecture = "API Gateway → Microservices → Service Bus Topics → Event Handlers → Database per Service",
                        Components = new List<ArchitectureComponent>
                        {
                            new ArchitectureComponent
                            {
                                Id = 11,
                                Name = "Service Bus Topics",
                                Purpose = "Event publishing and subscription",
                                Technology = "Azure Service Bus",
                                Justification = "Provides reliable pub/sub messaging with dead letter queues, duplicate detection, and transaction support."
                            },
                            new ArchitectureComponent
                            {
                                Id = 12,
                                Name = "Saga Orchestrator",
                                Purpose = "Manage distributed transactions",
                                Technology = "Custom orchestrator service",
                                Justification = "Coordinates complex business processes across multiple services with compensating actions for rollbacks."
                            }
                        },
                        ImplementationSteps = new List<string>
                        {
                            "Define domain events for each business operation",
                            "Implement Service Bus topics and subscriptions",
                            "Create saga orchestrator for complex workflows",
                            "Implement idempotent event handlers",
                            "Set up dead letter queue monitoring",
                            "Add comprehensive logging and monitoring"
                        },
                        BestPractices = new List<string>
                        {
                            "Make event handlers idempotent",
                            "Use correlation IDs for tracing",
                            "Implement circuit breaker pattern",
                            "Version your events for backward compatibility",
                            "Monitor message processing times and failures"
                        }
                    }
                },

                // Scenario 5: CI/CD Pipeline Architecture
                new Challenge
                {
                    Id = 5,
                    Title = "Enterprise CI/CD Pipeline",
                    Scenario = "Design a comprehensive CI/CD pipeline for a large development team (50+ developers) working on a microservices application. The pipeline must support multiple environments, automated testing, security scanning, and blue-green deployments.",
                    Category = ChallengeCategory.Architecture,
                    Difficulty = ChallengeDifficulty.Advanced,
                    Duration = "45-60 minutes",
                    Requirements = new List<string>
                    {
                        "Support for multiple branches and environments",
                        "Automated unit, integration, and security tests",
                        "Container-based deployments",
                        "Blue-green deployment strategy",
                        "Approval workflows for production",
                        "Rollback capabilities"
                    },
                    Constraints = new List<string>
                    {
                        "Zero-downtime deployments to production",
                        "Security scanning must pass before deployment",
                        "Infrastructure as Code for all environments",
                        "Audit trail for all deployments",
                        "Cost optimization for pipeline execution"
                    },
                    Solution = new ChallengeSolution
                    {
                        Id = 5,
                        ChallengeId = 5,
                        Overview = "Multi-stage Azure DevOps pipeline with automated testing, security scanning, container builds, and blue-green deployments using Azure Container Registry and AKS.",
                        Architecture = "Git → Azure DevOps → Unit Tests → Security Scan → ACR → AKS Blue/Green → Production",
                        Components = new List<ArchitectureComponent>
                        {
                            new ArchitectureComponent
                            {
                                Id = 13,
                                Name = "Azure DevOps Pipelines",
                                Purpose = "Orchestrate CI/CD process",
                                Technology = "Azure DevOps YAML Pipelines",
                                Justification = "Provides comprehensive pipeline capabilities with approval workflows, parallel jobs, and extensive integrations."
                            },
                            new ArchitectureComponent
                            {
                                Id = 14,
                                Name = "Azure Container Registry",
                                Purpose = "Store and scan container images",
                                Technology = "Azure Container Registry",
                                Justification = "Secure container registry with vulnerability scanning and geo-replication capabilities."
                            }
                        },
                        ImplementationSteps = new List<string>
                        {
                            "Set up multi-stage YAML pipeline",
                            "Implement automated testing stages",
                            "Configure security scanning with tools like Snyk",
                            "Set up blue-green deployment scripts",
                            "Configure approval gates for production",
                            "Implement monitoring and alerting for deployments"
                        },
                        BestPractices = new List<string>
                        {
                            "Use pipeline templates for consistency",
                            "Implement proper secret management",
                            "Enable parallel execution where possible",
                            "Use conditional deployments based on branch",
                            "Monitor pipeline performance and costs"
                        }
                    }
                },

                // Scenario 6: Big Data Analytics Architecture
                new Challenge
                {
                    Id = 6,
                    Title = "Big Data Analytics Platform",
                    Scenario = "Design a big data analytics platform that ingests streaming logs from 1000+ microservices, performs real-time and batch analytics, and provides interactive dashboards. The platform must handle TB-scale data daily and support machine learning workloads.",
                    Category = ChallengeCategory.CloudDesign,
                    Difficulty = ChallengeDifficulty.Expert,
                    Duration = "60-90 minutes",
                    Requirements = new List<string>
                    {
                        "Ingest streaming data from multiple sources",
                        "Support both real-time and batch processing",
                        "Store raw and processed data efficiently",
                        "Provide interactive analytics dashboards",
                        "Support machine learning model training",
                        "Handle TB-scale data daily"
                    },
                    Constraints = new List<string>
                    {
                        "Cost optimization for storage and compute",
                        "Data retention policies (7 years raw, 2 years processed)",
                        "GDPR compliance for personal data",
                        "Sub-second response time for dashboards",
                        "Auto-scaling based on data volume"
                    },
                    Solution = new ChallengeSolution
                    {
                        Id = 6,
                        ChallengeId = 6,
                        Overview = "Comprehensive data platform using Event Hub for ingestion, Stream Analytics for real-time processing, Databricks for batch analytics, Data Lake for storage, and Power BI for visualization.",
                        Architecture = "Event Hub → Stream Analytics + Databricks → Data Lake → Synapse Analytics → Power BI",
                        Components = new List<ArchitectureComponent>
                        {
                            new ArchitectureComponent
                            {
                                Id = 15,
                                Name = "Azure Databricks",
                                Purpose = "Advanced analytics and ML",
                                Technology = "Azure Databricks",
                                Justification = "Unified analytics platform for big data processing, machine learning, and collaborative analytics with auto-scaling capabilities."
                            },
                            new ArchitectureComponent
                            {
                                Id = 16,
                                Name = "Azure Synapse Analytics",
                                Purpose = "Data warehousing and analytics",
                                Technology = "Azure Synapse Analytics",
                                Justification = "Massively parallel processing for complex analytical queries with integration to Power BI and other tools."
                            }
                        },
                        ImplementationSteps = new List<string>
                        {
                            "Set up Event Hub with appropriate partition strategy",
                            "Configure Stream Analytics for real-time aggregations",
                            "Deploy Databricks workspace with auto-scaling clusters",
                            "Implement data lake with proper folder structure and partitioning",
                            "Set up Synapse Analytics with appropriate performance tiers",
                            "Create Power BI dashboards with DirectQuery/Import modes"
                        },
                        BestPractices = new List<string>
                        {
                            "Implement proper data partitioning strategy",
                            "Use appropriate compression formats (Parquet, Delta)",
                            "Implement data lifecycle management policies",
                            "Monitor data pipeline performance and costs",
                            "Implement proper data governance and cataloging"
                        }
                    }
                }
            };
        }
    }
}