namespace AzureNetworkWeb.Models;

public class NetworkArchitectureViewModel
{
    public string Title { get; set; } = "Azure Virtual Network Architecture - Migration Design";
    public ScenarioOverview Scenario { get; set; } = new();
    public List<NetworkComponent> Components { get; set; } = new();
    public ConnectivityOptions Connectivity { get; set; } = new();
    public SecurityArchitecture Security { get; set; } = new();
    public PerformanceOptimization Performance { get; set; } = new();
    public DisasterRecovery DR { get; set; } = new();
}

public class ScenarioOverview
{
    public string Description { get; set; } = "Enterprise migration from on-premises datacenter to Azure";
    public List<string> Requirements { get; set; } = new()
    {
        "Migrate on-premises datacenter to Azure",
        "Ensure optimal performance across regions",
        "Implement enterprise-grade security",
        "Enable seamless hybrid connectivity",
        "Support multi-region deployment",
        "Maintain high availability and scalability"
    };
    public List<string> KeyObjectives { get; set; } = new()
    {
        "Minimize latency between on-premises and cloud",
        "Implement defense-in-depth security",
        "Enable global scale with regional presence",
        "Ensure business continuity",
        "Optimize costs while maintaining performance"
    };
}

public class NetworkComponent
{
    public string Name { get; set; } = "";
    public string Type { get; set; } = "";
    public string IpRange { get; set; } = "";
    public string Purpose { get; set; } = "";
    public List<string> Subnets { get; set; } = new();
}

public class ConnectivityOptions
{
    public ExpressRouteConfig ExpressRoute { get; set; } = new();
    public VpnConfig VPN { get; set; } = new();
    public GlobalConnectivity Global { get; set; } = new();
}

public class ExpressRouteConfig
{
    public string Type { get; set; } = "Primary Connection";
    public string Bandwidth { get; set; } = "50 Mbps - 100 Gbps";
    public string Latency { get; set; } = "< 5ms";
    public string SLA { get; set; } = "99.95%";
    public List<string> Features { get; set; } = new()
    {
        "Private Peering for VNet access",
        "Microsoft Peering for M365",
        "Global Reach for multi-site connectivity",
        "ExpressRoute FastPath for ultra-low latency"
    };
}

public class VpnConfig
{
    public string Type { get; set; } = "Backup Connection";
    public string Encryption { get; set; } = "IPSec with 256-bit AES";
    public string Bandwidth { get; set; } = "Up to 1.25 Gbps";
    public string Configuration { get; set; } = "Active-Active";
    public List<string> Features { get; set; } = new()
    {
        "Zone-redundant deployment",
        "BGP enabled for dynamic routing",
        "Automatic failover from ExpressRoute",
        "Multiple tunnels for redundancy"
    };
}

public class GlobalConnectivity
{
    public string Method { get; set; } = "Global VNet Peering";
    public string Bandwidth { get; set; } = "25-100 Gbps";
    public string Latency { get; set; } = "< 80ms cross-region";
    public List<string> Benefits { get; set; } = new()
    {
        "No gateway required",
        "Encrypted by default",
        "Low latency",
        "High bandwidth"
    };
}

public class SecurityArchitecture
{
    public List<SecurityLayer> Layers { get; set; } = new()
    {
        new SecurityLayer 
        { 
            Name = "Perimeter Security",
            Components = new() { "Azure DDoS Protection", "Web Application Firewall", "Azure Front Door" }
        },
        new SecurityLayer 
        { 
            Name = "Network Security",
            Components = new() { "Azure Firewall Premium", "Network Security Groups", "Route Tables" }
        },
        new SecurityLayer 
        { 
            Name = "Identity & Access",
            Components = new() { "Azure AD with MFA", "Conditional Access", "Privileged Identity Management" }
        },
        new SecurityLayer 
        { 
            Name = "Data Security",
            Components = new() { "Encryption at rest", "Encryption in transit", "Key Vault integration" }
        }
    };
    public string Approach { get; set; } = "Zero Trust Security Model";
}

public class SecurityLayer
{
    public string Name { get; set; } = "";
    public List<string> Components { get; set; } = new();
}

public class PerformanceOptimization
{
    public List<OptimizationStrategy> Strategies { get; set; } = new()
    {
        new OptimizationStrategy 
        { 
            Area = "Traffic Optimization",
            Techniques = new() { "Azure Front Door", "Traffic Manager", "CDN Integration" }
        },
        new OptimizationStrategy 
        { 
            Area = "Compute Optimization",
            Techniques = new() { "Proximity Placement Groups", "Accelerated Networking", "Premium SSDs" }
        },
        new OptimizationStrategy 
        { 
            Area = "Caching",
            Techniques = new() { "Azure Redis Cache", "Application-level caching", "CDN caching" }
        },
        new OptimizationStrategy 
        { 
            Area = "Network",
            Techniques = new() { "ExpressRoute FastPath", "Local Network Gateway", "Optimized routing" }
        }
    };
}

public class OptimizationStrategy
{
    public string Area { get; set; } = "";
    public List<string> Techniques { get; set; } = new();
}

public class DisasterRecovery
{
    public List<RecoveryTier> Tiers { get; set; } = new()
    {
        new RecoveryTier 
        { 
            Name = "Critical Systems",
            RTO = "< 15 minutes",
            RPO = "< 5 minutes",
            Strategy = "Active-Active with automatic failover"
        },
        new RecoveryTier 
        { 
            Name = "Important Systems",
            RTO = "< 1 hour",
            RPO = "< 30 minutes",
            Strategy = "Warm standby with automated recovery"
        },
        new RecoveryTier 
        { 
            Name = "Standard Systems",
            RTO = "< 4 hours",
            RPO = "< 24 hours",
            Strategy = "Cold standby with manual intervention"
        }
    };
    public string TestingSchedule { get; set; } = "Monthly DR drills, Quarterly full failover";
}

public class RecoveryTier
{
    public string Name { get; set; } = "";
    public string RTO { get; set; } = "";
    public string RPO { get; set; } = "";
    public string Strategy { get; set; } = "";
}