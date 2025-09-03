using Microsoft.AspNetCore.Mvc;
using MicroservicesArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MicroservicesArchitecture.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new MicroservicesOverviewViewModel
            {
                Microservices = GetMicroservices(),
                AzureServices = GetAzureServices(),
                Patterns = GetPatterns(),
                Diagram = GetArchitectureDiagram()
            };

            return View(model);
        }

        public IActionResult Architecture()
        {
            var model = new
            {
                Title = "Complete Microservices Architecture",
                Diagram = GetDetailedArchitectureDiagram(),
                Layers = GetArchitectureLayers()
            };

            return View(model);
        }

        public IActionResult Services()
        {
            var services = GetMicroservices().Select(s => new ServiceDetails
            {
                Service = s,
                Endpoints = GetServiceEndpoints(s.Name),
                Database = GetDatabaseDesign(s.Name),
                Dependencies = GetServiceDependencies(s.Name),
                Deployment = GetDeploymentConfig(s.Name),
                Security = GetSecurityConfig(s.Name)
            }).ToList();

            return View(services);
        }

        public IActionResult Communication()
        {
            var patterns = new List<CommunicationPattern>
            {
                GetSynchronousCommunication(),
                GetAsynchronousCommunication(),
                GetEventDrivenCommunication()
            };

            return View(patterns);
        }

        public IActionResult AzureIntegration()
        {
            var model = new
            {
                Services = GetDetailedAzureServices(),
                IntegrationExamples = GetIntegrationExamples()
            };

            return View(model);
        }

        public IActionResult CodeExamples()
        {
            var examples = new Dictionary<string, List<CodeExample>>
            {
                ["API Gateway"] = GetApiGatewayExamples(),
                ["Microservice"] = GetMicroserviceExamples(),
                ["Event Bus"] = GetEventBusExamples(),
                ["Service Discovery"] = GetServiceDiscoveryExamples()
            };

            return View(examples);
        }

        public IActionResult Patterns()
        {
            var patterns = new Dictionary<string, List<Pattern>>
            {
                ["Design Patterns"] = GetDesignPatterns(),
                ["Integration Patterns"] = GetIntegrationPatterns(),
                ["Data Patterns"] = GetDataPatterns()
            };

            return View(patterns);
        }

        public IActionResult Monitoring()
        {
            var configs = GetMicroservices().Select(s => new ObservabilityConfig
            {
                Service = s.Name,
                Logging = GetLoggingConfig(s.Name),
                Tracing = GetTracingConfig(s.Name),
                Metrics = GetMetricsConfig(s.Name),
                HealthChecks = GetHealthCheckConfig(s.Name)
            }).ToList();

            return View(configs);
        }

        private List<Microservice> GetMicroservices()
        {
            return new List<Microservice>
            {
                new Microservice
                {
                    Name = "Product Service",
                    Description = "Manages product catalog, inventory, and pricing",
                    Technology = "ASP.NET Core 8.0 Web API",
                    Responsibilities = new List<string>
                    {
                        "Product CRUD operations",
                        "Inventory management",
                        "Price calculations",
                        "Category management"
                    },
                    APIs = new List<string>
                    {
                        "GET /api/products",
                        "GET /api/products/{id}",
                        "POST /api/products",
                        "PUT /api/products/{id}",
                        "DELETE /api/products/{id}",
                        "GET /api/products/search"
                    },
                    Icon = "📦",
                    Color = "#FF6B6B",
                    Code = new CodeExample
                    {
                        Title = "Product Service Controller",
                        Code = @"[ApiController]
[Route(""api/[controller]"")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(IProductService productService, ILogger<ProductsController> logger)
    {
        _productService = productService;
        _logger = logger;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<ProductDto>), 200)]
    public async Task<IActionResult> GetProducts([FromQuery] ProductFilter filter)
    {
        _logger.LogInformation(""Getting products with filter: {@Filter}"", filter);
        var products = await _productService.GetProductsAsync(filter);
        return Ok(products);
    }

    [HttpGet(""{id}"")]
    [ProducesResponseType(typeof(ProductDto), 200)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetProduct(Guid id)
    {
        var product = await _productService.GetProductByIdAsync(id);
        if (product == null)
        {
            _logger.LogWarning(""Product not found: {ProductId}"", id);
            return NotFound();
        }
        return Ok(product);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ProductDto), 201)]
    [ProducesResponseType(400)]
    public async Task<IActionResult> CreateProduct([FromBody] CreateProductDto createDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var product = await _productService.CreateProductAsync(createDto);
        _logger.LogInformation(""Product created: {ProductId}"", product.Id);
        
        return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
    }
}"
                    }
                },
                new Microservice
                {
                    Name = "Order Service",
                    Description = "Handles order processing, fulfillment, and tracking",
                    Technology = "ASP.NET Core 8.0 with MassTransit",
                    Responsibilities = new List<string>
                    {
                        "Order creation and validation",
                        "Payment processing coordination",
                        "Order status management",
                        "Shipping coordination"
                    },
                    APIs = new List<string>
                    {
                        "POST /api/orders",
                        "GET /api/orders/{id}",
                        "GET /api/orders/customer/{customerId}",
                        "PUT /api/orders/{id}/status",
                        "POST /api/orders/{id}/cancel"
                    },
                    Icon = "🛒",
                    Color = "#4ECDC4",
                    Code = new CodeExample
                    {
                        Title = "Order Service with Saga Pattern",
                        Code = @"public class OrderStateMachine : MassTransitStateMachine<OrderState>
{
    public State Submitted { get; private set; }
    public State PaymentPending { get; private set; }
    public State Processing { get; private set; }
    public State Shipped { get; private set; }
    public State Completed { get; private set; }
    public State Cancelled { get; private set; }

    public Event<OrderSubmitted> OrderSubmitted { get; private set; }
    public Event<PaymentCompleted> PaymentCompleted { get; private set; }
    public Event<OrderShipped> OrderShipped { get; private set; }
    public Event<OrderCancelled> OrderCancelled { get; private set; }

    public OrderStateMachine()
    {
        InstanceState(x => x.CurrentState);

        Event(() => OrderSubmitted, x => x.CorrelateById(context => context.Message.OrderId));
        Event(() => PaymentCompleted, x => x.CorrelateById(context => context.Message.OrderId));

        Initially(
            When(OrderSubmitted)
                .Then(context =>
                {
                    context.Instance.OrderId = context.Data.OrderId;
                    context.Instance.CustomerId = context.Data.CustomerId;
                    context.Instance.TotalAmount = context.Data.TotalAmount;
                    context.Instance.SubmittedAt = DateTime.UtcNow;
                })
                .TransitionTo(PaymentPending)
                .PublishAsync(context => context.Init<ProcessPayment>(new
                {
                    OrderId = context.Instance.OrderId,
                    Amount = context.Instance.TotalAmount
                }))
        );

        During(PaymentPending,
            When(PaymentCompleted)
                .TransitionTo(Processing)
                .PublishAsync(context => context.Init<PrepareShipment>(new
                {
                    OrderId = context.Instance.OrderId
                })),
            When(OrderCancelled)
                .TransitionTo(Cancelled)
                .Finalize()
        );
    }
}"
                    }
                },
                new Microservice
                {
                    Name = "Customer Service",
                    Description = "Manages customer profiles, preferences, and authentication",
                    Technology = "ASP.NET Core 8.0 with Identity",
                    Responsibilities = new List<string>
                    {
                        "Customer registration and authentication",
                        "Profile management",
                        "Address book management",
                        "Preference settings"
                    },
                    APIs = new List<string>
                    {
                        "POST /api/customers/register",
                        "POST /api/customers/login",
                        "GET /api/customers/{id}",
                        "PUT /api/customers/{id}",
                        "GET /api/customers/{id}/addresses"
                    },
                    Icon = "👤",
                    Color = "#FFE66D",
                    Code = new CodeExample
                    {
                        Title = "Customer Service with JWT Authentication",
                        Code = @"[ApiController]
[Route(""api/[controller]"")]
public class CustomersController : ControllerBase
{
    private readonly UserManager<Customer> _userManager;
    private readonly ITokenService _tokenService;

    [HttpPost(""register"")]
    public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
    {
        var customer = new Customer
        {
            Email = registerDto.Email,
            UserName = registerDto.Email,
            FirstName = registerDto.FirstName,
            LastName = registerDto.LastName
        };

        var result = await _userManager.CreateAsync(customer, registerDto.Password);
        
        if (!result.Succeeded)
            return BadRequest(result.Errors);

        var token = await _tokenService.CreateTokenAsync(customer);
        
        return Ok(new
        {
            Token = token,
            Customer = new CustomerDto(customer)
        });
    }

    [HttpPost(""login"")]
    public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
    {
        var customer = await _userManager.FindByEmailAsync(loginDto.Email);
        
        if (customer == null || !await _userManager.CheckPasswordAsync(customer, loginDto.Password))
            return Unauthorized(""Invalid credentials"");

        var token = await _tokenService.CreateTokenAsync(customer);
        
        return Ok(new
        {
            Token = token,
            Customer = new CustomerDto(customer)
        });
    }
}"
                    }
                },
                new Microservice
                {
                    Name = "Payment Service",
                    Description = "Processes payments and handles financial transactions",
                    Technology = "ASP.NET Core 8.0 with Stripe Integration",
                    Responsibilities = new List<string>
                    {
                        "Payment processing",
                        "Refund handling",
                        "Payment method management",
                        "Transaction history"
                    },
                    APIs = new List<string>
                    {
                        "POST /api/payments/process",
                        "POST /api/payments/refund",
                        "GET /api/payments/{id}",
                        "GET /api/payments/methods/{customerId}"
                    },
                    Icon = "💳",
                    Color = "#A8E6CF",
                    Code = new CodeExample
                    {
                        Title = "Payment Service Implementation",
                        Code = @"public class PaymentService : IPaymentService
{
    private readonly IStripeClient _stripeClient;
    private readonly IEventBus _eventBus;
    private readonly ILogger<PaymentService> _logger;

    public async Task<PaymentResult> ProcessPaymentAsync(PaymentRequest request)
    {
        try
        {
            var options = new ChargeCreateOptions
            {
                Amount = (long)(request.Amount * 100),
                Currency = ""usd"",
                Source = request.PaymentMethodId,
                Description = $""Order {request.OrderId}"",
                Metadata = new Dictionary<string, string>
                {
                    [""order_id""] = request.OrderId.ToString(),
                    [""customer_id""] = request.CustomerId.ToString()
                }
            };

            var charge = await new ChargeService(_stripeClient).CreateAsync(options);

            if (charge.Status == ""succeeded"")
            {
                await _eventBus.PublishAsync(new PaymentCompletedEvent
                {
                    OrderId = request.OrderId,
                    PaymentId = charge.Id,
                    Amount = request.Amount,
                    ProcessedAt = DateTime.UtcNow
                });

                return new PaymentResult
                {
                    Success = true,
                    TransactionId = charge.Id,
                    ProcessedAt = DateTime.UtcNow
                };
            }

            return new PaymentResult
            {
                Success = false,
                ErrorMessage = charge.FailureMessage
            };
        }
        catch (StripeException ex)
        {
            _logger.LogError(ex, ""Payment processing failed for order {OrderId}"", request.OrderId);
            return new PaymentResult
            {
                Success = false,
                ErrorMessage = ex.Message
            };
        }
    }
}"
                    }
                },
                new Microservice
                {
                    Name = "Notification Service",
                    Description = "Sends emails, SMS, and push notifications",
                    Technology = "ASP.NET Core 8.0 with SendGrid and Twilio",
                    Responsibilities = new List<string>
                    {
                        "Email notifications",
                        "SMS notifications",
                        "Push notifications",
                        "Notification templates"
                    },
                    APIs = new List<string>
                    {
                        "POST /api/notifications/email",
                        "POST /api/notifications/sms",
                        "POST /api/notifications/push",
                        "GET /api/notifications/templates"
                    },
                    Icon = "📧",
                    Color = "#FF8B94",
                    Code = new CodeExample
                    {
                        Title = "Notification Service with Multiple Channels",
                        Code = @"public interface INotificationService
{
    Task SendEmailAsync(EmailNotification notification);
    Task SendSmsAsync(SmsNotification notification);
    Task SendPushAsync(PushNotification notification);
}

public class NotificationService : INotificationService
{
    private readonly ISendGridClient _sendGridClient;
    private readonly ITwilioRestClient _twilioClient;
    private readonly ITemplateService _templateService;

    public async Task SendEmailAsync(EmailNotification notification)
    {
        var template = await _templateService.GetTemplateAsync(notification.TemplateId);
        var content = await _templateService.RenderTemplateAsync(template, notification.Data);

        var msg = new SendGridMessage
        {
            From = new EmailAddress(""noreply@example.com"", ""E-Commerce Platform""),
            Subject = notification.Subject,
            HtmlContent = content
        };
        
        msg.AddTo(new EmailAddress(notification.To));

        var response = await _sendGridClient.SendEmailAsync(msg);
        
        if (response.StatusCode != HttpStatusCode.Accepted)
        {
            throw new NotificationException($""Failed to send email: {response.StatusCode}"");
        }
    }

    public async Task SendSmsAsync(SmsNotification notification)
    {
        var message = await MessageResource.CreateAsync(
            body: notification.Message,
            from: new PhoneNumber(_twilioConfig.PhoneNumber),
            to: new PhoneNumber(notification.To),
            client: _twilioClient
        );

        if (message.Status == MessageResource.StatusEnum.Failed)
        {
            throw new NotificationException($""Failed to send SMS: {message.ErrorMessage}"");
        }
    }
}"
                    }
                }
            };
        }

        private List<AzureService> GetAzureServices()
        {
            return new List<AzureService>
            {
                new AzureService
                {
                    Name = "Azure Kubernetes Service (AKS)",
                    Category = "Container Orchestration",
                    Description = "Managed Kubernetes service for deploying and scaling containerized microservices",
                    Purpose = "Orchestrate and manage microservices containers at scale",
                    Features = new List<string>
                    {
                        "Automated scaling and self-healing",
                        "Integrated CI/CD with Azure DevOps",
                        "Built-in monitoring with Azure Monitor",
                        "Network policies and security features"
                    },
                    Icon = "☸️",
                    Integration = new CodeIntegration
                    {
                        SetupCode = @"# Deploy microservice to AKS
apiVersion: apps/v1
kind: Deployment
metadata:
  name: product-service
spec:
  replicas: 3
  selector:
    matchLabels:
      app: product-service
  template:
    metadata:
      labels:
        app: product-service
    spec:
      containers:
      - name: product-service
        image: myregistry.azurecr.io/product-service:latest
        ports:
        - containerPort: 80
        env:
        - name: ConnectionStrings__DefaultConnection
          valueFrom:
            secretKeyRef:
              name: product-service-secrets
              key: connection-string",
                        UsageCode = @"// Kubernetes health checks
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddHealthChecks()
            .AddCheck(""self"", () => HealthCheckResult.Healthy())
            .AddSqlServer(Configuration.GetConnectionString(""DefaultConnection""))
            .AddRedis(Configuration.GetConnectionString(""Redis""));
    }

    public void Configure(IApplicationBuilder app)
    {
        app.UseHealthChecks(""/health/ready"", new HealthCheckOptions
        {
            Predicate = _ => true
        });

        app.UseHealthChecks(""/health/live"", new HealthCheckOptions
        {
            Predicate = _ => false
        });
    }
}"
                    }
                },
                new AzureService
                {
                    Name = "Azure Service Bus",
                    Category = "Messaging",
                    Description = "Enterprise messaging service for decoupled communication between microservices",
                    Purpose = "Enable asynchronous communication and event-driven architecture",
                    Features = new List<string>
                    {
                        "Topics and subscriptions for pub/sub",
                        "Message queues for point-to-point",
                        "Dead letter queues",
                        "Message sessions and ordering"
                    },
                    Icon = "📨",
                    Integration = new CodeIntegration
                    {
                        NuGetPackages = new List<string>
                        {
                            "Azure.Messaging.ServiceBus",
                            "Microsoft.Extensions.Azure"
                        },
                        SetupCode = @"// Startup configuration
services.AddAzureClients(builder =>
{
    builder.AddServiceBusClient(Configuration.GetConnectionString(""ServiceBus""));
});

services.AddSingleton<IEventBus, AzureServiceBusEventBus>();",
                        UsageCode = @"public class AzureServiceBusEventBus : IEventBus
{
    private readonly ServiceBusClient _client;
    private readonly ILogger<AzureServiceBusEventBus> _logger;

    public async Task PublishAsync<T>(T @event) where T : IntegrationEvent
    {
        var topicName = typeof(T).Name;
        var sender = _client.CreateSender(topicName);

        try
        {
            var message = new ServiceBusMessage(JsonSerializer.Serialize(@event))
            {
                MessageId = @event.Id.ToString(),
                Subject = @event.GetType().Name,
                ApplicationProperties =
                {
                    [""EventType""] = @event.GetType().AssemblyQualifiedName
                }
            };

            await sender.SendMessageAsync(message);
            _logger.LogInformation(""Published event {EventId} to topic {Topic}"", @event.Id, topicName);
        }
        finally
        {
            await sender.DisposeAsync();
        }
    }

    public async Task SubscribeAsync<T>(Func<T, Task> handler) where T : IntegrationEvent
    {
        var topicName = typeof(T).Name;
        var subscriptionName = $""{Assembly.GetExecutingAssembly().GetName().Name}-{typeof(T).Name}"";
        
        var processor = _client.CreateProcessor(topicName, subscriptionName, new ServiceBusProcessorOptions
        {
            MaxConcurrentCalls = 10,
            AutoCompleteMessages = false
        });

        processor.ProcessMessageAsync += async args =>
        {
            var eventType = args.Message.ApplicationProperties[""EventType""].ToString();
            var @event = JsonSerializer.Deserialize<T>(args.Message.Body.ToString());
            
            await handler(@event);
            await args.CompleteMessageAsync(args.Message);
        };

        processor.ProcessErrorAsync += args =>
        {
            _logger.LogError(args.Exception, ""Error processing message"");
            return Task.CompletedTask;
        };

        await processor.StartProcessingAsync();
    }
}"
                    }
                },
                new AzureService
                {
                    Name = "Azure API Management",
                    Category = "API Gateway",
                    Description = "Centralized API gateway for managing, securing, and monitoring microservice APIs",
                    Purpose = "Provide a unified entry point for all microservices",
                    Features = new List<string>
                    {
                        "API versioning and documentation",
                        "Rate limiting and throttling",
                        "Authentication and authorization",
                        "Request/response transformation"
                    },
                    Icon = "🚪",
                    Integration = new CodeIntegration
                    {
                        ConfigurationCode = @"<!-- API Management Policy -->
<policies>
    <inbound>
        <base />
        <set-header name=""X-Correlation-Id"" exists-action=""skip"">
            <value>@(Guid.NewGuid().ToString())</value>
        </set-header>
        <authentication-managed-identity resource=""https://vault.azure.net"" />
        <rate-limit calls=""100"" renewal-period=""60"" />
        <cors>
            <allowed-origins>
                <origin>https://webapp.azurewebsites.net</origin>
            </allowed-origins>
        </cors>
    </inbound>
    <backend>
        <base />
    </backend>
    <outbound>
        <base />
        <set-header name=""X-Powered-By"" exists-action=""delete"" />
    </outbound>
</policies>",
                        UsageCode = @"// Configure service to work with API Management
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplicationInsightsTelemetry();
        
        services.AddAuthentication(""Bearer"")
            .AddJwtBearer(""Bearer"", options =>
            {
                options.Authority = Configuration[""AzureAd:Instance""] + Configuration[""AzureAd:TenantId""];
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = true,
                    ValidAudiences = new[] { Configuration[""AzureAd:ClientId""] }
                };
            });

        services.AddApiVersioning(options =>
        {
            options.DefaultApiVersion = new ApiVersion(1, 0);
            options.AssumeDefaultVersionWhenUnspecified = true;
            options.ReportApiVersions = true;
        });
    }
}"
                    }
                },
                new AzureService
                {
                    Name = "Azure Cosmos DB",
                    Category = "Database",
                    Description = "Globally distributed, multi-model database for microservices",
                    Purpose = "Provide scalable, low-latency data storage for microservices",
                    Features = new List<string>
                    {
                        "Multi-region replication",
                        "Multiple consistency levels",
                        "Automatic partitioning",
                        "SLA-backed availability"
                    },
                    Icon = "🌍",
                    Integration = new CodeIntegration
                    {
                        NuGetPackages = new List<string>
                        {
                            "Microsoft.Azure.Cosmos",
                            "Microsoft.Extensions.Configuration.AzureKeyVault"
                        },
                        SetupCode = @"services.AddSingleton<CosmosClient>(serviceProvider =>
{
    var configuration = serviceProvider.GetRequiredService<IConfiguration>();
    var endpoint = configuration[""CosmosDb:Endpoint""];
    var key = configuration[""CosmosDb:Key""];
    
    var cosmosClientOptions = new CosmosClientOptions
    {
        ApplicationName = ""ProductService"",
        ConnectionMode = ConnectionMode.Direct,
        ConsistencyLevel = ConsistencyLevel.Session
    };

    return new CosmosClient(endpoint, key, cosmosClientOptions);
});

services.AddScoped<IProductRepository, CosmosProductRepository>();",
                        UsageCode = @"public class CosmosProductRepository : IProductRepository
{
    private readonly Container _container;
    private readonly ILogger<CosmosProductRepository> _logger;

    public CosmosProductRepository(CosmosClient cosmosClient, IConfiguration configuration, ILogger<CosmosProductRepository> logger)
    {
        var databaseName = configuration[""CosmosDb:DatabaseName""];
        var containerName = configuration[""CosmosDb:ContainerName""];
        _container = cosmosClient.GetContainer(databaseName, containerName);
        _logger = logger;
    }

    public async Task<Product> GetByIdAsync(Guid id)
    {
        try
        {
            var response = await _container.ReadItemAsync<Product>(id.ToString(), new PartitionKey(id.ToString()));
            return response.Resource;
        }
        catch (CosmosException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
        {
            return null;
        }
    }

    public async Task<IEnumerable<Product>> GetByCategoryAsync(string category)
    {
        var query = new QueryDefinition(""SELECT * FROM c WHERE c.category = @category"")
            .WithParameter(""@category"", category);

        var iterator = _container.GetItemQueryIterator<Product>(query);
        var results = new List<Product>();

        while (iterator.HasMoreResults)
        {
            var response = await iterator.ReadNextAsync();
            results.AddRange(response.Resource);
        }

        return results;
    }

    public async Task<Product> CreateAsync(Product product)
    {
        product.Id = Guid.NewGuid();
        var response = await _container.CreateItemAsync(product, new PartitionKey(product.Id.ToString()));
        _logger.LogInformation(""Created product {ProductId} with RU charge: {RequestCharge}"", product.Id, response.RequestCharge);
        return response.Resource;
    }
}"
                    }
                },
                new AzureService
                {
                    Name = "Azure Monitor & Application Insights",
                    Category = "Monitoring",
                    Description = "Comprehensive monitoring and observability for microservices",
                    Purpose = "Monitor health, performance, and usage of microservices",
                    Features = new List<string>
                    {
                        "Distributed tracing",
                        "Custom metrics and logs",
                        "Alerts and notifications",
                        "Application map visualization"
                    },
                    Icon = "📊",
                    Integration = new CodeIntegration
                    {
                        NuGetPackages = new List<string>
                        {
                            "Microsoft.ApplicationInsights.AspNetCore",
                            "Microsoft.Extensions.Logging.ApplicationInsights"
                        },
                        SetupCode = @"// Configure Application Insights
services.AddApplicationInsightsTelemetry(options =>
{
    options.ConnectionString = Configuration[""ApplicationInsights:ConnectionString""];
});

services.AddApplicationInsightsKubernetesEnricher();

services.Configure<TelemetryConfiguration>(config =>
{
    config.TelemetryInitializers.Add(new CloudRoleNameTelemetryInitializer(""ProductService""));
});",
                        UsageCode = @"public class ProductService : IProductService
{
    private readonly ILogger<ProductService> _logger;
    private readonly TelemetryClient _telemetryClient;

    public async Task<Product> GetProductAsync(Guid id)
    {
        using var activity = Activity.StartActivity(""GetProduct"");
        activity?.SetTag(""product.id"", id);

        try
        {
            var stopwatch = Stopwatch.StartNew();
            var product = await _repository.GetByIdAsync(id);
            
            _telemetryClient.TrackMetric(""product.retrieval.duration"", stopwatch.ElapsedMilliseconds);
            
            if (product == null)
            {
                _logger.LogWarning(""Product not found: {ProductId}"", id);
                _telemetryClient.TrackEvent(""ProductNotFound"", new Dictionary<string, string>
                {
                    [""ProductId""] = id.ToString()
                });
            }

            return product;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ""Error retrieving product {ProductId}"", id);
            _telemetryClient.TrackException(ex, new Dictionary<string, string>
            {
                [""ProductId""] = id.ToString(),
                [""Operation""] = ""GetProduct""
            });
            throw;
        }
    }
}

// Custom telemetry initializer
public class CloudRoleNameTelemetryInitializer : ITelemetryInitializer
{
    private readonly string _roleName;

    public CloudRoleNameTelemetryInitializer(string roleName)
    {
        _roleName = roleName;
    }

    public void Initialize(ITelemetry telemetry)
    {
        telemetry.Context.Cloud.RoleName = _roleName;
        telemetry.Context.Cloud.RoleInstance = Environment.MachineName;
    }
}"
                    }
                }
            };
        }

        private List<Pattern> GetPatterns()
        {
            return new List<Pattern>
            {
                new Pattern
                {
                    Name = "Circuit Breaker",
                    Category = "Resilience",
                    Description = "Prevents cascading failures by failing fast when a service is unhealthy",
                    Benefits = new List<string>
                    {
                        "Prevents system overload",
                        "Fails fast when services are down",
                        "Automatic recovery detection",
                        "Improved system stability"
                    },
                    Challenges = new List<string>
                    {
                        "Requires careful threshold configuration",
                        "May reject valid requests during recovery",
                        "Needs proper monitoring"
                    },
                    Implementation = new CodeImplementation
                    {
                        ConceptCode = @"// Using Polly for Circuit Breaker
services.AddHttpClient<IProductServiceClient, ProductServiceClient>()
    .AddPolicyHandler(GetCircuitBreakerPolicy());

static IAsyncPolicy<HttpResponseMessage> GetCircuitBreakerPolicy()
{
    return HttpPolicyExtensions
        .HandleTransientHttpError()
        .CircuitBreakerAsync(
            handledEventsAllowedBeforeBreaking: 5,
            durationOfBreak: TimeSpan.FromSeconds(30),
            onBreak: (result, duration) =>
            {
                Log.Warning(""Circuit breaker opened for {Duration}s"", duration.TotalSeconds);
            },
            onReset: () =>
            {
                Log.Information(""Circuit breaker reset"");
            });
}",
                        ExampleCode = @"public class ProductServiceClient : IProductServiceClient
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<ProductServiceClient> _logger;

    public async Task<Product> GetProductAsync(Guid productId)
    {
        try
        {
            var response = await _httpClient.GetAsync($""api/products/{productId}"");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Product>();
        }
        catch (BrokenCircuitException ex)
        {
            _logger.LogWarning(""Circuit breaker is open. Service is unavailable."");
            throw new ServiceUnavailableException(""Product service is currently unavailable"", ex);
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, ""Error calling product service"");
            throw;
        }
    }
}"
                    }
                },
                new Pattern
                {
                    Name = "Saga Pattern",
                    Category = "Transaction Management",
                    Description = "Manages distributed transactions across multiple microservices",
                    Benefits = new List<string>
                    {
                        "Maintains data consistency",
                        "Handles long-running transactions",
                        "Supports compensating actions",
                        "No distributed locks required"
                    },
                    Challenges = new List<string>
                    {
                        "Complex implementation",
                        "Requires idempotent operations",
                        "Difficult debugging"
                    },
                    Implementation = new CodeImplementation
                    {
                        ConceptCode = @"// Order Saga Implementation
public class OrderSaga : Saga<OrderSagaData>,
    IAmStartedByMessages<StartOrder>,
    IHandleMessages<PaymentProcessed>,
    IHandleMessages<StockReserved>,
    IHandleMessages<OrderShipped>
{
    public async Task Handle(StartOrder message, IMessageHandlerContext context)
    {
        Data.OrderId = message.OrderId;
        Data.CustomerId = message.CustomerId;
        Data.TotalAmount = message.TotalAmount;

        await context.Send(new ProcessPayment
        {
            OrderId = Data.OrderId,
            Amount = Data.TotalAmount
        });
    }

    public async Task Handle(PaymentProcessed message, IMessageHandlerContext context)
    {
        Data.PaymentId = message.PaymentId;
        
        await context.Send(new ReserveStock
        {
            OrderId = Data.OrderId,
            Items = Data.OrderItems
        });
    }

    public async Task Handle(StockReserved message, IMessageHandlerContext context)
    {
        await context.Send(new ShipOrder
        {
            OrderId = Data.OrderId,
            ShippingAddress = Data.ShippingAddress
        });
    }

    public async Task Handle(OrderShipped message, IMessageHandlerContext context)
    {
        await context.Publish(new OrderCompleted
        {
            OrderId = Data.OrderId
        });
        
        MarkAsComplete();
    }
}",
                        BestPractices = new List<string>
                        {
                            "Keep saga data minimal",
                            "Use timeouts for each step",
                            "Implement compensating transactions",
                            "Make operations idempotent",
                            "Log all state transitions"
                        }
                    }
                },
                new Pattern
                {
                    Name = "API Gateway",
                    Category = "Architecture",
                    Description = "Single entry point for all client requests to microservices",
                    Benefits = new List<string>
                    {
                        "Simplified client interface",
                        "Cross-cutting concerns handling",
                        "Request routing and aggregation",
                        "Protocol translation"
                    },
                    Challenges = new List<string>
                    {
                        "Single point of failure",
                        "Performance bottleneck risk",
                        "Additional complexity"
                    },
                    Implementation = new CodeImplementation
                    {
                        ConceptCode = @"// Using Ocelot as API Gateway
public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            })
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                config
                    .SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
                    .AddJsonFile(""ocelot.json"")
                    .AddEnvironmentVariables();
            });
}

// ocelot.json configuration
{
  ""Routes"": [
    {
      ""DownstreamPathTemplate"": ""/api/products/{everything}"",
      ""DownstreamScheme"": ""http"",
      ""DownstreamHostAndPorts"": [
        {
          ""Host"": ""product-service"",
          ""Port"": 80
        }
      ],
      ""UpstreamPathTemplate"": ""/api/products/{everything}"",
      ""UpstreamHttpMethod"": [ ""GET"", ""POST"", ""PUT"", ""DELETE"" ],
      ""AuthenticationOptions"": {
        ""AuthenticationProviderKey"": ""Bearer"",
        ""AllowedScopes"": []
      },
      ""RateLimitOptions"": {
        ""ClientWhitelist"": [],
        ""EnableRateLimiting"": true,
        ""Period"": ""1m"",
        ""PeriodTimespan"": 60,
        ""Limit"": 100
      }
    }
  ],
  ""GlobalConfiguration"": {
    ""BaseUrl"": ""https://api.example.com""
  }
}",
                        ExampleCode = @"// Custom middleware for API Gateway
public class CorrelationIdMiddleware
{
    private readonly RequestDelegate _next;

    public async Task InvokeAsync(HttpContext context)
    {
        var correlationId = context.Request.Headers[""X-Correlation-Id""].FirstOrDefault() 
            ?? Guid.NewGuid().ToString();

        context.Items[""CorrelationId""] = correlationId;
        context.Response.Headers.Add(""X-Correlation-Id"", correlationId);

        using (LogContext.PushProperty(""CorrelationId"", correlationId))
        {
            await _next(context);
        }
    }
}

// Request aggregation
public class ProductAggregatorController : ControllerBase
{
    private readonly IHttpClientFactory _httpClientFactory;

    [HttpGet(""products/{id}/details"")]
    public async Task<IActionResult> GetProductDetails(Guid id)
    {
        var tasks = new List<Task>();
        var productTask = GetProductAsync(id);
        var reviewsTask = GetProductReviewsAsync(id);
        var inventoryTask = GetInventoryAsync(id);

        await Task.WhenAll(productTask, reviewsTask, inventoryTask);

        return Ok(new
        {
            Product = await productTask,
            Reviews = await reviewsTask,
            Inventory = await inventoryTask
        });
    }
}"
                    }
                }
            };
        }

        private ArchitectureDiagram GetArchitectureDiagram()
        {
            return new ArchitectureDiagram
            {
                Title = "E-Commerce Microservices Architecture",
                Components = new List<DiagramComponent>
                {
                    // Client Layer
                    new DiagramComponent { Id = "web-app", Name = "Web Application", Type = "Client", X = 100, Y = 50, Width = 150, Height = 60, Color = "#3498db", Icon = "🌐" },
                    new DiagramComponent { Id = "mobile-app", Name = "Mobile App", Type = "Client", X = 300, Y = 50, Width = 150, Height = 60, Color = "#3498db", Icon = "📱" },
                    
                    // API Gateway
                    new DiagramComponent { Id = "api-gateway", Name = "API Gateway", Type = "Gateway", X = 200, Y = 150, Width = 200, Height = 60, Color = "#e74c3c", Icon = "🚪" },
                    
                    // Microservices
                    new DiagramComponent { Id = "product-service", Name = "Product Service", Type = "Service", X = 50, Y = 280, Width = 140, Height = 60, Color = "#2ecc71", Icon = "📦" },
                    new DiagramComponent { Id = "order-service", Name = "Order Service", Type = "Service", X = 210, Y = 280, Width = 140, Height = 60, Color = "#2ecc71", Icon = "🛒" },
                    new DiagramComponent { Id = "customer-service", Name = "Customer Service", Type = "Service", X = 370, Y = 280, Width = 140, Height = 60, Color = "#2ecc71", Icon = "👤" },
                    new DiagramComponent { Id = "payment-service", Name = "Payment Service", Type = "Service", X = 50, Y = 370, Width = 140, Height = 60, Color = "#2ecc71", Icon = "💳" },
                    new DiagramComponent { Id = "notification-service", Name = "Notification Service", Type = "Service", X = 210, Y = 370, Width = 140, Height = 60, Color = "#2ecc71", Icon = "📧" },
                    
                    // Message Bus
                    new DiagramComponent { Id = "service-bus", Name = "Azure Service Bus", Type = "MessageBus", X = 150, Y = 470, Width = 250, Height = 50, Color = "#9b59b6", Icon = "📨" },
                    
                    // Data Stores
                    new DiagramComponent { Id = "product-db", Name = "Product DB", Type = "Database", X = 50, Y = 560, Width = 100, Height = 50, Color = "#f39c12", Icon = "🗄️" },
                    new DiagramComponent { Id = "order-db", Name = "Order DB", Type = "Database", X = 170, Y = 560, Width = 100, Height = 50, Color = "#f39c12", Icon = "🗄️" },
                    new DiagramComponent { Id = "customer-db", Name = "Customer DB", Type = "Database", X = 290, Y = 560, Width = 100, Height = 50, Color = "#f39c12", Icon = "🗄️" },
                    
                    // Azure Services
                    new DiagramComponent { Id = "aks", Name = "Azure Kubernetes Service", Type = "Platform", X = 550, Y = 250, Width = 180, Height = 60, Color = "#0078d4", Icon = "☸️" },
                    new DiagramComponent { Id = "monitor", Name = "Azure Monitor", Type = "Monitoring", X = 550, Y = 330, Width = 180, Height = 60, Color = "#0078d4", Icon = "📊" },
                    new DiagramComponent { Id = "keyvault", Name = "Azure Key Vault", Type = "Security", X = 550, Y = 410, Width = 180, Height = 60, Color = "#0078d4", Icon = "🔐" }
                },
                Connections = new List<DiagramConnection>
                {
                    // Client to API Gateway
                    new DiagramConnection { From = "web-app", To = "api-gateway", Label = "HTTPS", Type = "sync", Protocol = "REST" },
                    new DiagramConnection { From = "mobile-app", To = "api-gateway", Label = "HTTPS", Type = "sync", Protocol = "REST" },
                    
                    // API Gateway to Services
                    new DiagramConnection { From = "api-gateway", To = "product-service", Label = "HTTP", Type = "sync", Protocol = "REST" },
                    new DiagramConnection { From = "api-gateway", To = "order-service", Label = "HTTP", Type = "sync", Protocol = "REST" },
                    new DiagramConnection { From = "api-gateway", To = "customer-service", Label = "HTTP", Type = "sync", Protocol = "REST" },
                    
                    // Service to Service Bus
                    new DiagramConnection { From = "order-service", To = "service-bus", Label = "Events", Type = "async", Protocol = "AMQP" },
                    new DiagramConnection { From = "payment-service", To = "service-bus", Label = "Events", Type = "async", Protocol = "AMQP" },
                    new DiagramConnection { From = "service-bus", To = "notification-service", Label = "Events", Type = "async", Protocol = "AMQP" },
                    
                    // Services to Databases
                    new DiagramConnection { From = "product-service", To = "product-db", Label = "SQL", Type = "sync", Protocol = "TCP" },
                    new DiagramConnection { From = "order-service", To = "order-db", Label = "SQL", Type = "sync", Protocol = "TCP" },
                    new DiagramConnection { From = "customer-service", To = "customer-db", Label = "SQL", Type = "sync", Protocol = "TCP" }
                }
            };
        }

        private ArchitectureDiagram GetDetailedArchitectureDiagram()
        {
            // Return a more detailed architecture diagram with all components
            return GetArchitectureDiagram(); // Simplified for brevity
        }

        private List<object> GetArchitectureLayers()
        {
            return new List<object>
            {
                new { Name = "Client Layer", Description = "Web and mobile applications", Y = 0, Height = 100 },
                new { Name = "API Gateway Layer", Description = "Single entry point, routing, authentication", Y = 100, Height = 100 },
                new { Name = "Microservices Layer", Description = "Business logic and domain services", Y = 200, Height = 200 },
                new { Name = "Integration Layer", Description = "Message bus and event streaming", Y = 400, Height = 100 },
                new { Name = "Data Layer", Description = "Databases and data stores", Y = 500, Height = 100 },
                new { Name = "Infrastructure Layer", Description = "Azure platform services", Y = 600, Height = 100 }
            };
        }

        private List<MicroservicesArchitecture.Models.Endpoint> GetServiceEndpoints(string serviceName)
        {
            // Return endpoints based on service name
            if (serviceName == "Product Service")
            {
                return new List<MicroservicesArchitecture.Models.Endpoint>
                {
                    new MicroservicesArchitecture.Models.Endpoint
                    {
                        Method = "GET",
                        Path = "/api/products",
                        Description = "Get all products with optional filtering",
                        RequestBody = "",
                        ResponseBody = @"[
  {
    ""id"": ""guid"",
    ""name"": ""string"",
    ""description"": ""string"",
    ""price"": 0,
    ""category"": ""string"",
    ""inStock"": true
  }
]",
                        ControllerCode = @"[HttpGet]
public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts([FromQuery] ProductFilter filter)
{
    var products = await _productService.GetProductsAsync(filter);
    return Ok(products);
}"
                    }
                };
            }
            
            return new List<MicroservicesArchitecture.Models.Endpoint>();
        }

        private DatabaseDesign GetDatabaseDesign(string serviceName)
        {
            if (serviceName == "Product Service")
            {
                return new DatabaseDesign
                {
                    Type = "SQL Server",
                    ConnectionString = "Server=.;Database=ProductDb;Integrated Security=true",
                    Entities = new List<Entity>
                    {
                        new Entity
                        {
                            Name = "Product",
                            Properties = new List<Property>
                            {
                                new Property { Name = "Id", Type = "Guid", IsKey = true },
                                new Property { Name = "Name", Type = "string", IsRequired = true },
                                new Property { Name = "Description", Type = "string" },
                                new Property { Name = "Price", Type = "decimal", IsRequired = true },
                                new Property { Name = "CategoryId", Type = "int", IsRequired = true }
                            },
                            EntityCode = @"public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}"
                        }
                    }
                };
            }
            
            return new DatabaseDesign();
        }

        private List<ServiceDependency> GetServiceDependencies(string serviceName)
        {
            if (serviceName == "Order Service")
            {
                return new List<ServiceDependency>
                {
                    new ServiceDependency
                    {
                        ServiceName = "Product Service",
                        Purpose = "Validate product availability and pricing",
                        CommunicationType = "HTTP",
                        ClientCode = @"public interface IProductServiceClient
{
    Task<Product> GetProductAsync(Guid productId);
    Task<bool> CheckAvailabilityAsync(Guid productId, int quantity);
}

public class ProductServiceClient : IProductServiceClient
{
    private readonly HttpClient _httpClient;

    public async Task<Product> GetProductAsync(Guid productId)
    {
        var response = await _httpClient.GetAsync($""/api/products/{productId}"");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Product>();
    }
}"
                    }
                };
            }
            
            return new List<ServiceDependency>();
        }

        private DeploymentConfig GetDeploymentConfig(string serviceName)
        {
            return new DeploymentConfig
            {
                Platform = "Azure Kubernetes Service",
                DockerfileContent = @"FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY [""ProductService/ProductService.csproj"", ""ProductService/""]
RUN dotnet restore ""ProductService/ProductService.csproj""
COPY . .
WORKDIR ""/src/ProductService""
RUN dotnet build ""ProductService.csproj"" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish ""ProductService.csproj"" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT [""dotnet"", ""ProductService.dll""]",
                KubernetesYaml = @"apiVersion: apps/v1
kind: Deployment
metadata:
  name: product-service
spec:
  replicas: 3
  selector:
    matchLabels:
      app: product-service
  template:
    metadata:
      labels:
        app: product-service
    spec:
      containers:
      - name: product-service
        image: myregistry.azurecr.io/product-service:latest
        ports:
        - containerPort: 80
        resources:
          requests:
            memory: ""256Mi""
            cpu: ""250m""
          limits:
            memory: ""512Mi""
            cpu: ""500m""",
                EnvironmentVariables = new List<EnvironmentVariable>
                {
                    new EnvironmentVariable { Name = "ASPNETCORE_ENVIRONMENT", Value = "Production" },
                    new EnvironmentVariable { Name = "ConnectionStrings__DefaultConnection", Value = "Server=...", IsSecret = true }
                }
            };
        }

        private List<SecurityConfig> GetSecurityConfig(string serviceName)
        {
            return new List<SecurityConfig>
            {
                new SecurityConfig
                {
                    Type = "Authentication",
                    Implementation = "JWT Bearer Token",
                    Code = @"services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.Authority = Configuration[""Auth:Authority""];
        options.Audience = Configuration[""Auth:Audience""];
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ClockSkew = TimeSpan.Zero
        };
    });",
                    BestPractices = new List<string>
                    {
                        "Always use HTTPS",
                        "Implement token refresh",
                        "Use short-lived tokens",
                        "Store secrets in Key Vault"
                    }
                }
            };
        }

        private CommunicationPattern GetSynchronousCommunication()
        {
            return new CommunicationPattern
            {
                Name = "Synchronous HTTP Communication",
                Type = "Request-Response",
                Description = "Direct HTTP calls between services",
                Examples = new List<CommunicationExample>
                {
                    new CommunicationExample
                    {
                        Scenario = "Order Service calling Product Service",
                        ProducerCode = @"[ApiController]
[Route(""api/[controller]"")]
public class ProductsController : ControllerBase
{
    [HttpGet(""{id}"")]
    public async Task<ActionResult<Product>> GetProduct(Guid id)
    {
        var product = await _productService.GetByIdAsync(id);
        if (product == null)
            return NotFound();
        return Ok(product);
    }
}",
                        ConsumerCode = @"public class OrderService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public async Task<bool> ValidateOrderItems(List<OrderItem> items)
    {
        var httpClient = _httpClientFactory.CreateClient(""ProductService"");
        
        foreach (var item in items)
        {
            var response = await httpClient.GetAsync($""/api/products/{item.ProductId}"");
            if (!response.IsSuccessStatusCode)
                return false;
                
            var product = await response.Content.ReadFromJsonAsync<Product>();
            if (product.Stock < item.Quantity)
                return false;
        }
        
        return true;
    }
}",
                        ConfigurationCode = @"services.AddHttpClient(""ProductService"", client =>
{
    client.BaseAddress = new Uri(Configuration[""Services:ProductService:BaseUrl""]);
    client.DefaultRequestHeaders.Add(""Accept"", ""application/json"");
})
.AddPolicyHandler(GetRetryPolicy())
.AddPolicyHandler(GetCircuitBreakerPolicy());"
                    }
                }
            };
        }

        private CommunicationPattern GetAsynchronousCommunication()
        {
            return new CommunicationPattern
            {
                Name = "Message Queue Communication",
                Type = "Point-to-Point",
                Description = "Asynchronous messaging via Azure Service Bus queues",
                Examples = new List<CommunicationExample>
                {
                    new CommunicationExample
                    {
                        Scenario = "Order processing with message queues",
                        ProducerCode = @"public class OrderService
{
    private readonly ServiceBusSender _sender;

    public async Task ProcessOrderAsync(Order order)
    {
        var message = new ServiceBusMessage(JsonSerializer.Serialize(order))
        {
            Subject = ""OrderCreated"",
            ApplicationProperties =
            {
                [""OrderId""] = order.Id,
                [""CustomerId""] = order.CustomerId
            }
        };

        await _sender.SendMessageAsync(message);
    }
}",
                        ConsumerCode = @"public class PaymentProcessor : BackgroundService
{
    private readonly ServiceBusProcessor _processor;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _processor.ProcessMessageAsync += ProcessOrderAsync;
        _processor.ProcessErrorAsync += ProcessErrorAsync;
        
        await _processor.StartProcessingAsync(stoppingToken);
    }

    private async Task ProcessOrderAsync(ProcessMessageEventArgs args)
    {
        var order = JsonSerializer.Deserialize<Order>(args.Message.Body.ToString());
        
        // Process payment
        await _paymentService.ProcessPaymentAsync(order);
        
        // Complete the message
        await args.CompleteMessageAsync(args.Message);
    }
}",
                        ConfigurationCode = @"services.AddSingleton(provider =>
{
    var connectionString = Configuration[""ServiceBus:ConnectionString""];
    return new ServiceBusClient(connectionString);
});

services.AddSingleton(provider =>
{
    var client = provider.GetRequiredService<ServiceBusClient>();
    return client.CreateSender(""order-queue"");
});"
                    }
                }
            };
        }

        private CommunicationPattern GetEventDrivenCommunication()
        {
            return new CommunicationPattern
            {
                Name = "Event-Driven Communication",
                Type = "Publish-Subscribe",
                Description = "Event broadcasting via Azure Service Bus topics",
                Examples = new List<CommunicationExample>
                {
                    new CommunicationExample
                    {
                        Scenario = "Publishing domain events",
                        ProducerCode = @"public interface IEventBus
{
    Task PublishAsync<T>(T @event) where T : IntegrationEvent;
}

public class OrderService
{
    private readonly IEventBus _eventBus;

    public async Task CreateOrderAsync(CreateOrderCommand command)
    {
        // Create order
        var order = new Order { /* ... */ };
        await _repository.AddAsync(order);

        // Publish event
        await _eventBus.PublishAsync(new OrderCreatedEvent
        {
            OrderId = order.Id,
            CustomerId = order.CustomerId,
            TotalAmount = order.TotalAmount,
            Items = order.Items.Select(i => new OrderItemDto
            {
                ProductId = i.ProductId,
                Quantity = i.Quantity,
                Price = i.Price
            }).ToList()
        });
    }
}",
                        ConsumerCode = @"public class InventoryService : IHostedService
{
    private readonly IEventBus _eventBus;

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        await _eventBus.SubscribeAsync<OrderCreatedEvent>(HandleOrderCreatedAsync);
    }

    private async Task HandleOrderCreatedAsync(OrderCreatedEvent @event)
    {
        foreach (var item in @event.Items)
        {
            await _inventoryService.ReserveStockAsync(item.ProductId, item.Quantity);
        }
        
        await _eventBus.PublishAsync(new StockReservedEvent
        {
            OrderId = @event.OrderId,
            ReservedAt = DateTime.UtcNow
        });
    }
}",
                        ConfigurationCode = @"// Event Bus registration
services.AddSingleton<IEventBus, AzureServiceBusEventBus>();

// Configure subscriptions
services.Configure<EventBusOptions>(options =>
{
    options.SubscriptionClientName = ""inventory-service"";
    options.RetryPolicy = new RetryExponential(
        minimumBackoff: TimeSpan.FromSeconds(1),
        maximumBackoff: TimeSpan.FromSeconds(30),
        maximumRetryCount: 5);
});"
                    }
                }
            };
        }

        private List<AzureService> GetDetailedAzureServices()
        {
            return GetAzureServices(); // Reuse the same list for simplicity
        }

        private List<object> GetIntegrationExamples()
        {
            return new List<object>
            {
                new
                {
                    Title = "Complete Azure Integration Example",
                    Description = "Full microservice with all Azure services integrated",
                    Code = @"public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Azure Key Vault for secrets
        var keyVaultEndpoint = Configuration[""KeyVault:Endpoint""];
        var secretClient = new SecretClient(new Uri(keyVaultEndpoint), new DefaultAzureCredential());
        services.AddSingleton(secretClient);

        // Azure Service Bus for messaging
        services.AddAzureClients(builder =>
        {
            builder.AddServiceBusClient(Configuration[""ServiceBus:ConnectionString""]);
        });

        // Azure Cosmos DB for data storage
        services.AddSingleton<CosmosClient>(sp =>
        {
            var endpoint = Configuration[""CosmosDb:Endpoint""];
            var key = secretClient.GetSecret(""CosmosDbKey"").Value.Value;
            return new CosmosClient(endpoint, key);
        });

        // Application Insights for monitoring
        services.AddApplicationInsightsTelemetry();

        // Azure AD for authentication
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddMicrosoftIdentityWebApi(Configuration.GetSection(""AzureAd""));

        // Health checks for all services
        services.AddHealthChecks()
            .AddAzureServiceBusQueue(""order-queue"", Configuration[""ServiceBus:ConnectionString""])
            .AddCosmosDb(Configuration[""CosmosDb:ConnectionString""])
            .AddApplicationInsightsPublisher();
    }
}"
                }
            };
        }

        private List<CodeExample> GetApiGatewayExamples()
        {
            return new List<CodeExample>
            {
                new CodeExample
                {
                    Title = "API Gateway with Authentication",
                    Description = "Implementing authentication and authorization in API Gateway",
                    Code = @"public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddOcelot()
            .AddDelegatingHandler<CorrelationIdDelegatingHandler>()
            .AddDelegatingHandler<LoggingDelegatingHandler>();

        services.AddAuthentication(""Bearer"")
            .AddJwtBearer(""Bearer"", options =>
            {
                options.Authority = Configuration[""IdentityServer:Authority""];
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = false
                };
            });

        services.AddAuthorization(options =>
        {
            options.AddPolicy(""ApiScope"", policy =>
            {
                policy.RequireAuthenticatedUser();
                policy.RequireClaim(""scope"", ""api.read"");
            });
        });
    }

    public void Configure(IApplicationBuilder app)
    {
        app.UseAuthentication();
        app.UseOcelot().Wait();
    }
}

public class CorrelationIdDelegatingHandler : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request, 
        CancellationToken cancellationToken)
    {
        var correlationId = Guid.NewGuid().ToString();
        request.Headers.Add(""X-Correlation-Id"", correlationId);
        
        using (LogContext.PushProperty(""CorrelationId"", correlationId))
        {
            return await base.SendAsync(request, cancellationToken);
        }
    }
}"
                }
            };
        }

        private List<CodeExample> GetMicroserviceExamples()
        {
            return new List<CodeExample>
            {
                new CodeExample
                {
                    Title = "Complete Microservice Implementation",
                    Description = "Full microservice with all patterns implemented",
                    Snippets = new List<CodeSnippet>
                    {
                        new CodeSnippet
                        {
                            Title = "Program.cs - Service Configuration",
                            FileName = "Program.cs",
                            Code = @"var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add application services
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

// Add resilience
builder.Services.AddHttpClient<IInventoryServiceClient, InventoryServiceClient>()
    .AddPolicyHandler(GetRetryPolicy())
    .AddPolicyHandler(GetCircuitBreakerPolicy());

// Add health checks
builder.Services.AddHealthChecks()
    .AddSqlServer(builder.Configuration.GetConnectionString(""DefaultConnection""))
    .AddCheck(""self"", () => HealthCheckResult.Healthy());

// Add authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.Authority = builder.Configuration[""Auth:Authority""];
        options.Audience = builder.Configuration[""Auth:Audience""];
    });

// Add telemetry
builder.Services.AddApplicationInsightsTelemetry();

var app = builder.Build();

// Configure pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.MapHealthChecks(""/health"");

app.Run();

// Resilience policies
static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
{
    return HttpPolicyExtensions
        .HandleTransientHttpError()
        .WaitAndRetryAsync(
            3,
            retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)),
            onRetry: (outcome, timespan, retryCount, context) =>
            {
                Log.Warning(""Delaying for {delay}ms, then making retry {retry}."", timespan.TotalMilliseconds, retryCount);
            });
}

static IAsyncPolicy<HttpResponseMessage> GetCircuitBreakerPolicy()
{
    return HttpPolicyExtensions
        .HandleTransientHttpError()
        .CircuitBreakerAsync(5, TimeSpan.FromSeconds(30));
}",
                            Explanation = "Main entry point configuring all cross-cutting concerns"
                        },
                        new CodeSnippet
                        {
                            Title = "Domain Model",
                            FileName = "Models/Product.cs",
                            Code = @"public class Product : AggregateRoot
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public int StockQuantity { get; private set; }
    public ProductStatus Status { get; private set; }
    
    protected Product() { } // EF Core
    
    public Product(string name, string description, decimal price, int stockQuantity)
    {
        Id = Guid.NewGuid();
        Name = Guard.Against.NullOrWhiteSpace(name, nameof(name));
        Description = description;
        Price = Guard.Against.NegativeOrZero(price, nameof(price));
        StockQuantity = Guard.Against.Negative(stockQuantity, nameof(stockQuantity));
        Status = ProductStatus.Active;
        
        AddDomainEvent(new ProductCreatedEvent(Id, Name, Price));
    }
    
    public void UpdatePrice(decimal newPrice)
    {
        var oldPrice = Price;
        Price = Guard.Against.NegativeOrZero(newPrice, nameof(newPrice));
        
        if (oldPrice != newPrice)
        {
            AddDomainEvent(new ProductPriceChangedEvent(Id, oldPrice, newPrice));
        }
    }
    
    public void DeductStock(int quantity)
    {
        if (StockQuantity < quantity)
            throw new InsufficientStockException($""Product {Name} has insufficient stock"");
            
        StockQuantity -= quantity;
        
        if (StockQuantity == 0)
        {
            AddDomainEvent(new ProductOutOfStockEvent(Id, Name));
        }
    }
}

public enum ProductStatus
{
    Active,
    Inactive,
    Discontinued
}",
                            Explanation = "Domain model with business logic and domain events"
                        }
                    }
                }
            };
        }

        private List<CodeExample> GetEventBusExamples()
        {
            return new List<CodeExample>
            {
                new CodeExample
                {
                    Title = "Event Bus Implementation",
                    Description = "Complete event bus with Azure Service Bus",
                    Code = @"public interface IEventBus
{
    Task PublishAsync<T>(T @event) where T : IntegrationEvent;
    Task SubscribeAsync<T, TH>() 
        where T : IntegrationEvent
        where TH : IIntegrationEventHandler<T>;
}

public class AzureServiceBusEventBus : IEventBus
{
    private readonly ServiceBusClient _serviceBusClient;
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<AzureServiceBusEventBus> _logger;
    private readonly Dictionary<string, ServiceBusProcessor> _processors;

    public AzureServiceBusEventBus(
        ServiceBusClient serviceBusClient,
        IServiceProvider serviceProvider,
        ILogger<AzureServiceBusEventBus> logger)
    {
        _serviceBusClient = serviceBusClient;
        _serviceProvider = serviceProvider;
        _logger = logger;
        _processors = new Dictionary<string, ServiceBusProcessor>();
    }

    public async Task PublishAsync<T>(T @event) where T : IntegrationEvent
    {
        var topicName = GetTopicName<T>();
        var sender = _serviceBusClient.CreateSender(topicName);

        try
        {
            var message = CreateServiceBusMessage(@event);
            await sender.SendMessageAsync(message);
            
            _logger.LogInformation(
                ""Published event {EventName} with Id {EventId}"",
                @event.GetType().Name,
                @event.Id);
        }
        finally
        {
            await sender.DisposeAsync();
        }
    }

    public async Task SubscribeAsync<T, TH>()
        where T : IntegrationEvent
        where TH : IIntegrationEventHandler<T>
    {
        var topicName = GetTopicName<T>();
        var subscriptionName = GetSubscriptionName<TH>();

        var processor = _serviceBusClient.CreateProcessor(
            topicName,
            subscriptionName,
            new ServiceBusProcessorOptions
            {
                AutoCompleteMessages = false,
                MaxConcurrentCalls = 10
            });

        processor.ProcessMessageAsync += async args =>
        {
            using var scope = _serviceProvider.CreateScope();
            var handler = scope.ServiceProvider.GetRequiredService<TH>();
            
            var eventData = args.Message.Body.ToString();
            var @event = JsonSerializer.Deserialize<T>(eventData);
            
            await handler.Handle(@event);
            await args.CompleteMessageAsync(args.Message);
        };

        processor.ProcessErrorAsync += args =>
        {
            _logger.LogError(args.Exception, ""Error processing message"");
            return Task.CompletedTask;
        };

        await processor.StartProcessingAsync();
        _processors[subscriptionName] = processor;
    }

    private ServiceBusMessage CreateServiceBusMessage<T>(T @event) where T : IntegrationEvent
    {
        var json = JsonSerializer.Serialize(@event);
        var message = new ServiceBusMessage(json)
        {
            MessageId = @event.Id.ToString(),
            Subject = @event.GetType().Name,
            ApplicationProperties =
            {
                [""EventType""] = @event.GetType().AssemblyQualifiedName,
                [""EventVersion""] = ""1.0""
            }
        };

        return message;
    }

    private string GetTopicName<T>() => typeof(T).Name.ToLower();
    private string GetSubscriptionName<TH>() => $""{Assembly.GetEntryAssembly().GetName().Name}-{typeof(TH).Name}"";
}

// Integration event base class
public abstract class IntegrationEvent
{
    public Guid Id { get; }
    public DateTime CreatedAt { get; }

    protected IntegrationEvent()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
    }
}

// Event handler interface
public interface IIntegrationEventHandler<in TEvent> where TEvent : IntegrationEvent
{
    Task Handle(TEvent @event);
}

// Example event
public class OrderCreatedIntegrationEvent : IntegrationEvent
{
    public Guid OrderId { get; }
    public Guid CustomerId { get; }
    public decimal TotalAmount { get; }
    public List<OrderItemDto> Items { get; }

    public OrderCreatedIntegrationEvent(
        Guid orderId,
        Guid customerId,
        decimal totalAmount,
        List<OrderItemDto> items)
    {
        OrderId = orderId;
        CustomerId = customerId;
        TotalAmount = totalAmount;
        Items = items;
    }
}

// Example handler
public class OrderCreatedIntegrationEventHandler : IIntegrationEventHandler<OrderCreatedIntegrationEvent>
{
    private readonly IInventoryService _inventoryService;

    public async Task Handle(OrderCreatedIntegrationEvent @event)
    {
        foreach (var item in @event.Items)
        {
            await _inventoryService.ReserveStockAsync(item.ProductId, item.Quantity);
        }
    }
}"
                }
            };
        }

        private List<CodeExample> GetServiceDiscoveryExamples()
        {
            return new List<CodeExample>
            {
                new CodeExample
                {
                    Title = "Service Discovery with Consul",
                    Description = "Implementing service discovery for microservices",
                    Code = @"public interface IServiceDiscovery
{
    Task<IEnumerable<ServiceInstance>> GetServicesAsync(string serviceName);
    Task RegisterServiceAsync(ServiceRegistration registration);
    Task DeregisterServiceAsync(string serviceId);
}

public class ConsulServiceDiscovery : IServiceDiscovery
{
    private readonly IConsulClient _consulClient;
    private readonly ILogger<ConsulServiceDiscovery> _logger;

    public ConsulServiceDiscovery(IConsulClient consulClient, ILogger<ConsulServiceDiscovery> logger)
    {
        _consulClient = consulClient;
        _logger = logger;
    }

    public async Task<IEnumerable<ServiceInstance>> GetServicesAsync(string serviceName)
    {
        var queryResult = await _consulClient.Health.Service(serviceName, string.Empty, true);
        
        return queryResult.Response.Select(service => new ServiceInstance
        {
            ServiceId = service.Service.ID,
            ServiceName = service.Service.Service,
            Address = service.Service.Address,
            Port = service.Service.Port,
            Tags = service.Service.Tags,
            Meta = service.Service.Meta
        });
    }

    public async Task RegisterServiceAsync(ServiceRegistration registration)
    {
        var agentServiceRegistration = new AgentServiceRegistration
        {
            ID = registration.Id,
            Name = registration.Name,
            Address = registration.Address,
            Port = registration.Port,
            Tags = registration.Tags.ToArray(),
            Check = new AgentServiceCheck
            {
                HTTP = $""http://{registration.Address}:{registration.Port}/health"",
                Interval = TimeSpan.FromSeconds(10),
                Timeout = TimeSpan.FromSeconds(5),
                DeregisterCriticalServiceAfter = TimeSpan.FromMinutes(5)
            }
        };

        await _consulClient.Agent.ServiceRegister(agentServiceRegistration);
        _logger.LogInformation(""Service registered: {ServiceName} ({ServiceId})"", registration.Name, registration.Id);
    }

    public async Task DeregisterServiceAsync(string serviceId)
    {
        await _consulClient.Agent.ServiceDeregister(serviceId);
        _logger.LogInformation(""Service deregistered: {ServiceId}"", serviceId);
    }
}

// Service registration at startup
public class ServiceDiscoveryHostedService : IHostedService
{
    private readonly IServiceDiscovery _serviceDiscovery;
    private readonly IConfiguration _configuration;
    private ServiceRegistration _registration;

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        var serviceId = Guid.NewGuid().ToString();
        var serviceName = _configuration[""Service:Name""];
        var serviceHost = _configuration[""Service:Host""];
        var servicePort = int.Parse(_configuration[""Service:Port""]);

        _registration = new ServiceRegistration
        {
            Id = serviceId,
            Name = serviceName,
            Address = serviceHost,
            Port = servicePort,
            Tags = new[] { ""api"", ""v1"" }
        };

        await _serviceDiscovery.RegisterServiceAsync(_registration);
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        if (_registration != null)
        {
            await _serviceDiscovery.DeregisterServiceAsync(_registration.Id);
        }
    }
}

// Load balancing with service discovery
public class ServiceDiscoveryHttpMessageHandler : DelegatingHandler
{
    private readonly IServiceDiscovery _serviceDiscovery;
    private readonly ILoadBalancer _loadBalancer;

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var serviceName = GetServiceName(request.RequestUri);
        var services = await _serviceDiscovery.GetServicesAsync(serviceName);
        var service = _loadBalancer.Select(services);

        var uriBuilder = new UriBuilder(request.RequestUri)
        {
            Host = service.Address,
            Port = service.Port
        };

        request.RequestUri = uriBuilder.Uri;
        return await base.SendAsync(request, cancellationToken);
    }
}"
                }
            };
        }

        private List<Pattern> GetDesignPatterns()
        {
            return new List<Pattern>
            {
                new Pattern
                {
                    Name = "Repository Pattern",
                    Category = "Data Access",
                    Description = "Abstracts data access logic and provides a more object-oriented view of the persistence layer",
                    Benefits = new List<string>
                    {
                        "Decouples business logic from data access",
                        "Enables unit testing with mocks",
                        "Centralizes query logic",
                        "Supports multiple data sources"
                    },
                    Implementation = new CodeImplementation
                    {
                        ConceptCode = @"// Generic repository interface
public interface IRepository<T> where T : class, IAggregateRoot
{
    Task<T> GetByIdAsync(Guid id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<IReadOnlyList<T>> GetAsync(ISpecification<T> spec);
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}

// Specification pattern for complex queries
public interface ISpecification<T>
{
    Expression<Func<T, bool>> Criteria { get; }
    List<Expression<Func<T, object>>> Includes { get; }
    List<string> IncludeStrings { get; }
}

// Base repository implementation
public class Repository<T> : IRepository<T> where T : class, IAggregateRoot
{
    private readonly DbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(DbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<IReadOnlyList<T>> GetAsync(ISpecification<T> spec)
    {
        return await ApplySpecification(spec).ToListAsync();
    }

    private IQueryable<T> ApplySpecification(ISpecification<T> spec)
    {
        return SpecificationEvaluator<T>.GetQuery(_dbSet.AsQueryable(), spec);
    }
}",
                        BestPractices = new List<string>
                        {
                            "Keep repositories focused on data access",
                            "Use specifications for complex queries",
                            "Don't expose IQueryable from repositories",
                            "Consider using Unit of Work pattern",
                            "Implement async methods throughout"
                        }
                    }
                },
                new Pattern
                {
                    Name = "CQRS Pattern",
                    Category = "Architecture",
                    Description = "Separates read and write operations for better scalability and performance",
                    Benefits = new List<string>
                    {
                        "Independent scaling of reads and writes",
                        "Optimized data models for queries",
                        "Simplified business logic",
                        "Better performance"
                    },
                    Implementation = new CodeImplementation
                    {
                        ConceptCode = @"// Command interface
public interface ICommand
{
    Guid Id { get; }
}

public interface ICommandHandler<in TCommand> where TCommand : ICommand
{
    Task<CommandResult> HandleAsync(TCommand command);
}

// Query interface
public interface IQuery<TResult>
{
}

public interface IQueryHandler<in TQuery, TResult> where TQuery : IQuery<TResult>
{
    Task<TResult> HandleAsync(TQuery query);
}

// Example command
public class CreateProductCommand : ICommand
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
}

// Command handler
public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand>
{
    private readonly IProductRepository _repository;
    private readonly IEventBus _eventBus;

    public async Task<CommandResult> HandleAsync(CreateProductCommand command)
    {
        var product = new Product(command.Name, command.Price, command.StockQuantity);
        
        await _repository.AddAsync(product);
        await _repository.SaveChangesAsync();
        
        await _eventBus.PublishAsync(new ProductCreatedEvent
        {
            ProductId = product.Id,
            Name = product.Name,
            Price = product.Price
        });
        
        return new CommandResult { Success = true, Id = product.Id };
    }
}

// Example query
public class GetProductByIdQuery : IQuery<ProductDto>
{
    public Guid ProductId { get; set; }
}

// Query handler
public class GetProductByIdQueryHandler : IQueryHandler<GetProductByIdQuery, ProductDto>
{
    private readonly IProductReadModelRepository _repository;

    public async Task<ProductDto> HandleAsync(GetProductByIdQuery query)
    {
        return await _repository.GetProductAsync(query.ProductId);
    }
}",
                        BestPractices = new List<string>
                        {
                            "Keep commands task-focused",
                            "Use separate read models for queries",
                            "Consider event sourcing for audit trails",
                            "Implement proper validation",
                            "Use mediator pattern for decoupling"
                        }
                    }
                }
            };
        }

        private List<Pattern> GetIntegrationPatterns()
        {
            return new List<Pattern>
            {
                new Pattern
                {
                    Name = "Outbox Pattern",
                    Category = "Reliability",
                    Description = "Ensures reliable message publishing by storing events in a database before publishing",
                    Benefits = new List<string>
                    {
                        "Guarantees at-least-once delivery",
                        "Maintains consistency between database and messages",
                        "Handles transient failures",
                        "Provides message ordering"
                    },
                    Implementation = new CodeImplementation
                    {
                        ConceptCode = @"public class OutboxMessage
{
    public Guid Id { get; set; }
    public string EventType { get; set; }
    public string EventData { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ProcessedAt { get; set; }
    public int RetryCount { get; set; }
}

public interface IOutboxService
{
    Task AddMessageAsync(IntegrationEvent @event);
    Task ProcessPendingMessagesAsync();
}

public class OutboxService : IOutboxService
{
    private readonly ApplicationDbContext _context;
    private readonly IEventBus _eventBus;

    public async Task AddMessageAsync(IntegrationEvent @event)
    {
        var outboxMessage = new OutboxMessage
        {
            Id = Guid.NewGuid(),
            EventType = @event.GetType().AssemblyQualifiedName,
            EventData = JsonSerializer.Serialize(@event),
            CreatedAt = DateTime.UtcNow
        };

        _context.OutboxMessages.Add(outboxMessage);
        // Save within the same transaction as the business operation
    }

    public async Task ProcessPendingMessagesAsync()
    {
        var pendingMessages = await _context.OutboxMessages
            .Where(m => m.ProcessedAt == null && m.RetryCount < 5)
            .OrderBy(m => m.CreatedAt)
            .Take(100)
            .ToListAsync();

        foreach (var message in pendingMessages)
        {
            try
            {
                var eventType = Type.GetType(message.EventType);
                var @event = JsonSerializer.Deserialize(message.EventData, eventType) as IntegrationEvent;
                
                await _eventBus.PublishAsync(@event);
                
                message.ProcessedAt = DateTime.UtcNow;
            }
            catch (Exception ex)
            {
                message.RetryCount++;
                _logger.LogError(ex, ""Failed to process outbox message {MessageId}"", message.Id);
            }
        }

        await _context.SaveChangesAsync();
    }
}

// Background service to process outbox
public class OutboxProcessorService : BackgroundService
{
    private readonly IServiceProvider _serviceProvider;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            using var scope = _serviceProvider.CreateScope();
            var outboxService = scope.ServiceProvider.GetRequiredService<IOutboxService>();
            
            await outboxService.ProcessPendingMessagesAsync();
            await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
        }
    }
}",
                        BestPractices = new List<string>
                        {
                            "Process messages in order",
                            "Implement idempotency",
                            "Set reasonable retry limits",
                            "Monitor failed messages",
                            "Clean up old processed messages"
                        }
                    }
                }
            };
        }

        private List<Pattern> GetDataPatterns()
        {
            return new List<Pattern>
            {
                new Pattern
                {
                    Name = "Database per Service",
                    Category = "Data Management",
                    Description = "Each microservice owns its data and database schema",
                    Benefits = new List<string>
                    {
                        "Service autonomy",
                        "Independent scaling",
                        "Technology diversity",
                        "Fault isolation"
                    },
                    Challenges = new List<string>
                    {
                        "Data consistency across services",
                        "Distributed queries complexity",
                        "Data duplication"
                    },
                    Implementation = new CodeImplementation
                    {
                        ConceptCode = @"// Product Service with its own database
public class ProductDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Product service owns product data
        modelBuilder.Entity<Product>().ToTable(""Products"", ""product"");
        modelBuilder.Entity<Category>().ToTable(""Categories"", ""product"");
    }
}

// Order Service with its own database
public class OrderDbContext : DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Order service owns order data
        modelBuilder.Entity<Order>().ToTable(""Orders"", ""order"");
        modelBuilder.Entity<OrderItem>().ToTable(""OrderItems"", ""order"");
        
        // Store only necessary product information
        modelBuilder.Entity<OrderItem>()
            .OwnsOne(i => i.ProductSnapshot, ps =>
            {
                ps.Property(p => p.ProductId);
                ps.Property(p => p.ProductName);
                ps.Property(p => p.Price);
            });
    }
}

// Cross-service data synchronization
public class ProductUpdatedEventHandler : IIntegrationEventHandler<ProductUpdatedEvent>
{
    private readonly OrderDbContext _context;

    public async Task Handle(ProductUpdatedEvent @event)
    {
        // Update denormalized product data in order service
        var ordersWithProduct = await _context.OrderItems
            .Where(i => i.ProductSnapshot.ProductId == @event.ProductId)
            .ToListAsync();

        foreach (var item in ordersWithProduct)
        {
            item.ProductSnapshot.ProductName = @event.NewName;
            // Price remains historical
        }

        await _context.SaveChangesAsync();
    }
}",
                        BestPractices = new List<string>
                        {
                            "Define clear boundaries",
                            "Use events for synchronization",
                            "Implement eventual consistency",
                            "Store only needed data",
                            "Version your APIs"
                        }
                    }
                }
            };
        }

        private LoggingConfig GetLoggingConfig(string serviceName)
        {
            return new LoggingConfig
            {
                Provider = "Serilog with Application Insights",
                ConfigurationCode = @"// appsettings.json
{
  ""Serilog"": {
    ""Using"": [""Serilog.Sinks.Console"", ""Serilog.Sinks.ApplicationInsights""],
    ""MinimumLevel"": {
      ""Default"": ""Information"",
      ""Override"": {
        ""Microsoft"": ""Warning"",
        ""System"": ""Warning""
      }
    },
    ""WriteTo"": [
      {
        ""Name"": ""Console"",
        ""Args"": {
          ""outputTemplate"": ""[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj} {Properties:j}{NewLine}{Exception}""
        }
      },
      {
        ""Name"": ""ApplicationInsights"",
        ""Args"": {
          ""telemetryConverter"": ""Serilog.Sinks.ApplicationInsights.TelemetryConverters.TraceTelemetryConverter, Serilog.Sinks.ApplicationInsights""
        }
      }
    ],
    ""Enrich"": [""FromLogContext"", ""WithMachineName"", ""WithThreadId""],
    ""Properties"": {
      ""ServiceName"": """ + serviceName + @"""
    }
  }
}",
                UsageCode = @"public class ProductService
{
    private readonly ILogger<ProductService> _logger;

    public async Task<Product> GetProductAsync(Guid productId)
    {
        using (_logger.BeginScope(new Dictionary<string, object>
        {
            [""ProductId""] = productId,
            [""Operation""] = ""GetProduct""
        }))
        {
            _logger.LogInformation(""Retrieving product {ProductId}"", productId);
            
            try
            {
                var product = await _repository.GetByIdAsync(productId);
                
                if (product == null)
                {
                    _logger.LogWarning(""Product {ProductId} not found"", productId);
                }
                
                return product;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ""Error retrieving product {ProductId}"", productId);
                throw;
            }
        }
    }
}",
                BestPractices = new List<string>
                {
                    "Use structured logging",
                    "Include correlation IDs",
                    "Log at appropriate levels",
                    "Avoid logging sensitive data",
                    "Use scopes for context"
                }
            };
        }

        private TracingConfig GetTracingConfig(string serviceName)
        {
            return new TracingConfig
            {
                Provider = "OpenTelemetry with Application Insights",
                SetupCode = @"services.AddOpenTelemetryTracing(builder =>
{
    builder
        .SetResourceBuilder(ResourceBuilder.CreateDefault().AddService(serviceName))
        .AddAspNetCoreInstrumentation()
        .AddHttpClientInstrumentation()
        .AddSqlClientInstrumentation()
        .AddSource(serviceName)
        .AddAzureMonitorTraceExporter(o =>
        {
            o.ConnectionString = Configuration[""ApplicationInsights:ConnectionString""];
        });
});",
                InstrumentationCode = @"public class ProductService
{
    private readonly ActivitySource _activitySource;

    public ProductService()
    {
        _activitySource = new ActivitySource(""ProductService"");
    }

    public async Task<Product> GetProductAsync(Guid productId)
    {
        using var activity = _activitySource.StartActivity(""GetProduct"");
        activity?.SetTag(""product.id"", productId);
        activity?.SetTag(""service.name"", ""ProductService"");

        try
        {
            var product = await _repository.GetByIdAsync(productId);
            activity?.SetTag(""product.found"", product != null);
            return product;
        }
        catch (Exception ex)
        {
            activity?.SetStatus(ActivityStatusCode.Error, ex.Message);
            throw;
        }
    }
}"
            };
        }

        private MetricsConfig GetMetricsConfig(string serviceName)
        {
            return new MetricsConfig
            {
                Provider = "Prometheus with Azure Monitor",
                CustomMetrics = new List<Metric>
                {
                    new Metric
                    {
                        Name = "product_requests_total",
                        Type = "Counter",
                        Description = "Total number of product requests",
                        Code = @"private readonly Counter _requestCounter = Metrics
    .CreateCounter(""product_requests_total"", ""Total number of product requests"", 
    new CounterConfiguration
    {
        LabelNames = new[] { ""method"", ""status"" }
    });"
                    },
                    new Metric
                    {
                        Name = "product_request_duration_seconds",
                        Type = "Histogram",
                        Description = "Product request duration in seconds",
                        Code = @"private readonly Histogram _requestDuration = Metrics
    .CreateHistogram(""product_request_duration_seconds"", ""Product request duration in seconds"",
    new HistogramConfiguration
    {
        Buckets = Histogram.LinearBuckets(0.01, 0.01, 20),
        LabelNames = new[] { ""method"" }
    });"
                    }
                },
                DashboardConfig = @"// Grafana dashboard query examples
// Request rate
rate(product_requests_total[5m])

// Error rate
rate(product_requests_total{status!~""2..""}[5m])

// P95 latency
histogram_quantile(0.95, rate(product_request_duration_seconds_bucket[5m]))"
            };
        }

        private HealthCheckConfig GetHealthCheckConfig(string serviceName)
        {
            return new HealthCheckConfig
            {
                Checks = new List<HealthCheck>
                {
                    new HealthCheck
                    {
                        Name = "self",
                        Type = "Liveness",
                        Endpoint = "/health/live",
                        Implementation = @"public class LivenessHealthCheck : IHealthCheck
{
    public Task<HealthCheckResult> CheckHealthAsync(
        HealthCheckContext context,
        CancellationToken cancellationToken = default)
    {
        return Task.FromResult(HealthCheckResult.Healthy(""Application is running""));
    }
}"
                    },
                    new HealthCheck
                    {
                        Name = "ready",
                        Type = "Readiness",
                        Endpoint = "/health/ready",
                        Implementation = @"public class ReadinessHealthCheck : IHealthCheck
{
    private readonly IDbContextFactory<ProductDbContext> _contextFactory;
    private readonly IServiceBusClient _serviceBusClient;

    public async Task<HealthCheckResult> CheckHealthAsync(
        HealthCheckContext context,
        CancellationToken cancellationToken = default)
    {
        try
        {
            // Check database
            using var dbContext = _contextFactory.CreateDbContext();
            await dbContext.Database.CanConnectAsync(cancellationToken);

            // Check service bus
            await _serviceBusClient.CheckHealthAsync(cancellationToken);

            return HealthCheckResult.Healthy(""Application is ready"");
        }
        catch (Exception ex)
        {
            return HealthCheckResult.Unhealthy(""Application is not ready"", ex);
        }
    }
}"
                    }
                },
                StartupCode = @"services.AddHealthChecks()
    .AddCheck<LivenessHealthCheck>(""liveness"", tags: new[] { ""live"" })
    .AddCheck<ReadinessHealthCheck>(""readiness"", tags: new[] { ""ready"" })
    .AddSqlServer(
        Configuration.GetConnectionString(""DefaultConnection""),
        name: ""database"",
        tags: new[] { ""ready"" })
    .AddAzureServiceBusQueue(
        Configuration[""ServiceBus:ConnectionString""],
        ""product-queue"",
        name: ""servicebus"",
        tags: new[] { ""ready"" });

app.MapHealthChecks(""/health/live"", new HealthCheckOptions
{
    Predicate = check => check.Tags.Contains(""live"")
});

app.MapHealthChecks(""/health/ready"", new HealthCheckOptions
{
    Predicate = check => check.Tags.Contains(""ready""),
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});"
            };
        }
    }
}