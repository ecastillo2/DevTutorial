using System;
using System.Collections.Generic;

namespace MicroservicesArchitecture.Models
{
    public class MicroservicesOverviewViewModel
    {
        public string Title { get; set; } = "C# Microservices Architecture on Azure";
        public string Description { get; set; } = "A comprehensive guide to building microservices with C# and Azure services";
        public List<Microservice> Microservices { get; set; } = new();
        public List<AzureService> AzureServices { get; set; } = new();
        public List<Pattern> Patterns { get; set; } = new();
        public ArchitectureDiagram Diagram { get; set; } = new();
    }

    public class Microservice
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Technology { get; set; } = "";
        public List<string> Responsibilities { get; set; } = new();
        public List<string> APIs { get; set; } = new();
        public string Icon { get; set; } = "";
        public string Color { get; set; } = "";
        public CodeExample Code { get; set; } = new();
    }

    public class AzureService
    {
        public string Name { get; set; } = "";
        public string Category { get; set; } = "";
        public string Description { get; set; } = "";
        public string Purpose { get; set; } = "";
        public List<string> Features { get; set; } = new();
        public string Icon { get; set; } = "";
        public CodeIntegration Integration { get; set; } = new();
    }

    public class Pattern
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Category { get; set; } = "";
        public List<string> Benefits { get; set; } = new();
        public List<string> Challenges { get; set; } = new();
        public CodeImplementation Implementation { get; set; } = new();
    }

    public class ArchitectureDiagram
    {
        public string Title { get; set; } = "";
        public List<DiagramComponent> Components { get; set; } = new();
        public List<DiagramConnection> Connections { get; set; } = new();
        public List<DiagramLayer> Layers { get; set; } = new();
    }

    public class DiagramComponent
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string Type { get; set; } = "";
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Color { get; set; } = "";
        public string Icon { get; set; } = "";
    }

    public class DiagramConnection
    {
        public string From { get; set; } = "";
        public string To { get; set; } = "";
        public string Label { get; set; } = "";
        public string Type { get; set; } = "";
        public string Protocol { get; set; } = "";
    }

    public class DiagramLayer
    {
        public string Name { get; set; } = "";
        public int Y { get; set; }
        public int Height { get; set; }
        public string Color { get; set; } = "";
        public string Description { get; set; } = "";
    }

    public class CodeExample
    {
        public string Language { get; set; } = "csharp";
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Code { get; set; } = "";
        public List<CodeSnippet> Snippets { get; set; } = new();
    }

    public class CodeSnippet
    {
        public string Title { get; set; } = "";
        public string Code { get; set; } = "";
        public string Explanation { get; set; } = "";
        public string FileName { get; set; } = "";
    }

    public class CodeIntegration
    {
        public string SetupCode { get; set; } = "";
        public string UsageCode { get; set; } = "";
        public string ConfigurationCode { get; set; } = "";
        public List<string> NuGetPackages { get; set; } = new();
    }

    public class CodeImplementation
    {
        public string ConceptCode { get; set; } = "";
        public string ExampleCode { get; set; } = "";
        public List<string> BestPractices { get; set; } = new();
    }

    // Detailed component models
    public class ServiceDetails
    {
        public Microservice Service { get; set; } = new();
        public List<Endpoint> Endpoints { get; set; } = new();
        public DatabaseDesign Database { get; set; } = new();
        public List<ServiceDependency> Dependencies { get; set; } = new();
        public DeploymentConfig Deployment { get; set; } = new();
        public List<SecurityConfig> Security { get; set; } = new();
    }

    public class Endpoint
    {
        public string Method { get; set; } = "";
        public string Path { get; set; } = "";
        public string Description { get; set; } = "";
        public string RequestBody { get; set; } = "";
        public string ResponseBody { get; set; } = "";
        public List<string> Headers { get; set; } = new();
        public string ControllerCode { get; set; } = "";
    }

    public class DatabaseDesign
    {
        public string Type { get; set; } = "";
        public string ConnectionString { get; set; } = "";
        public List<Entity> Entities { get; set; } = new();
        public string MigrationCode { get; set; } = "";
    }

    public class Entity
    {
        public string Name { get; set; } = "";
        public List<Property> Properties { get; set; } = new();
        public string EntityCode { get; set; } = "";
    }

    public class Property
    {
        public string Name { get; set; } = "";
        public string Type { get; set; } = "";
        public bool IsRequired { get; set; }
        public bool IsKey { get; set; }
        public string DefaultValue { get; set; } = "";
    }

    public class ServiceDependency
    {
        public string ServiceName { get; set; } = "";
        public string Purpose { get; set; } = "";
        public string CommunicationType { get; set; } = "";
        public string ClientCode { get; set; } = "";
    }

    public class DeploymentConfig
    {
        public string Platform { get; set; } = "";
        public string DockerfileContent { get; set; } = "";
        public string KubernetesYaml { get; set; } = "";
        public string AzureConfig { get; set; } = "";
        public List<EnvironmentVariable> EnvironmentVariables { get; set; } = new();
    }

    public class EnvironmentVariable
    {
        public string Name { get; set; } = "";
        public string Value { get; set; } = "";
        public string Description { get; set; } = "";
        public bool IsSecret { get; set; }
    }

    public class SecurityConfig
    {
        public string Type { get; set; } = "";
        public string Implementation { get; set; } = "";
        public string Code { get; set; } = "";
        public List<string> BestPractices { get; set; } = new();
    }

    // Communication patterns
    public class CommunicationPattern
    {
        public string Name { get; set; } = "";
        public string Type { get; set; } = "";
        public string Description { get; set; } = "";
        public List<CommunicationExample> Examples { get; set; } = new();
    }

    public class CommunicationExample
    {
        public string Scenario { get; set; } = "";
        public string ProducerCode { get; set; } = "";
        public string ConsumerCode { get; set; } = "";
        public string ConfigurationCode { get; set; } = "";
    }

    // Monitoring and observability
    public class ObservabilityConfig
    {
        public string Service { get; set; } = "";
        public LoggingConfig Logging { get; set; } = new();
        public TracingConfig Tracing { get; set; } = new();
        public MetricsConfig Metrics { get; set; } = new();
        public HealthCheckConfig HealthChecks { get; set; } = new();
    }

    public class LoggingConfig
    {
        public string Provider { get; set; } = "";
        public string ConfigurationCode { get; set; } = "";
        public string UsageCode { get; set; } = "";
        public List<string> BestPractices { get; set; } = new();
    }

    public class TracingConfig
    {
        public string Provider { get; set; } = "";
        public string SetupCode { get; set; } = "";
        public string InstrumentationCode { get; set; } = "";
    }

    public class MetricsConfig
    {
        public string Provider { get; set; } = "";
        public List<Metric> CustomMetrics { get; set; } = new();
        public string DashboardConfig { get; set; } = "";
    }

    public class Metric
    {
        public string Name { get; set; } = "";
        public string Type { get; set; } = "";
        public string Description { get; set; } = "";
        public string Code { get; set; } = "";
    }

    public class HealthCheckConfig
    {
        public List<HealthCheck> Checks { get; set; } = new();
        public string StartupCode { get; set; } = "";
        public string CustomCheckCode { get; set; } = "";
    }

    public class HealthCheck
    {
        public string Name { get; set; } = "";
        public string Type { get; set; } = "";
        public string Endpoint { get; set; } = "";
        public string Implementation { get; set; } = "";
    }
}