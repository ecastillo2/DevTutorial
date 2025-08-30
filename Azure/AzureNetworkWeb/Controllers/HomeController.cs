using Microsoft.AspNetCore.Mvc;
using AzureNetworkWeb.Models;

namespace AzureNetworkWeb.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var model = new NetworkArchitectureViewModel
        {
            Components = GetNetworkComponents()
        };
        
        return View(model);
    }

    public IActionResult Architecture()
    {
        return View();
    }

    public IActionResult Connectivity()
    {
        var model = new ConnectivityOptions();
        return View(model);
    }

    public IActionResult Security()
    {
        var model = new SecurityArchitecture();
        return View(model);
    }

    public IActionResult Performance()
    {
        var model = new PerformanceOptimization();
        return View(model);
    }

    public IActionResult DisasterRecovery()
    {
        var model = new DisasterRecovery();
        return View(model);
    }

    public IActionResult Implementation()
    {
        return View();
    }

    private List<NetworkComponent> GetNetworkComponents()
    {
        return new List<NetworkComponent>
        {
            new NetworkComponent
            {
                Name = "Hub VNet - Region 1",
                Type = "Hub",
                IpRange = "10.100.0.0/16",
                Purpose = "Central connectivity and shared services",
                Subnets = new List<string>
                {
                    "Gateway Subnet: 10.100.1.0/24",
                    "Firewall Subnet: 10.100.3.0/24",
                    "Management Subnet: 10.100.5.0/24",
                    "Shared Services: 10.100.10.0/24"
                }
            },
            new NetworkComponent
            {
                Name = "Production Spoke",
                Type = "Spoke",
                IpRange = "10.101.0.0/16",
                Purpose = "Production workloads",
                Subnets = new List<string>
                {
                    "Web Tier: 10.101.1.0/24",
                    "App Tier: 10.101.2.0/24",
                    "Data Tier: 10.101.3.0/24"
                }
            },
            new NetworkComponent
            {
                Name = "Dev/Test Spoke",
                Type = "Spoke",
                IpRange = "10.102.0.0/16",
                Purpose = "Development and testing",
                Subnets = new List<string>
                {
                    "Dev Servers: 10.102.1.0/24",
                    "Test Servers: 10.102.2.0/24",
                    "Dev Databases: 10.102.3.0/24"
                }
            },
            new NetworkComponent
            {
                Name = "Hub VNet - Region 2",
                Type = "Hub",
                IpRange = "10.200.0.0/16",
                Purpose = "Secondary region for DR",
                Subnets = new List<string>
                {
                    "Gateway Subnet: 10.200.1.0/24",
                    "Firewall Subnet: 10.200.3.0/24",
                    "Management Subnet: 10.200.5.0/24"
                }
            }
        };
    }
}