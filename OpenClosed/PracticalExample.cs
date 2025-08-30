namespace OpenClosed.PracticalExample;

/// <summary>
/// PRACTICAL EXAMPLE - E-Commerce System
/// Demonstrates how OCP creates extensible, maintainable systems
/// </summary>

// ========== PRODUCT PRICING SYSTEM ==========

/// <summary>
/// Interface for pricing rules - allows extension without modification
/// </summary>
public interface IPricingRule
{
    decimal CalculatePrice(Product product, int quantity);
    string GetRuleName();
    int Priority { get; } // Higher priority rules apply first
}

/// <summary>
/// Basic pricing rule - no special pricing
/// </summary>
public class StandardPricingRule : IPricingRule
{
    public int Priority => 0;

    public decimal CalculatePrice(Product product, int quantity)
    {
        return product.BasePrice * quantity;
    }

    public string GetRuleName()
    {
        return "Standard Pricing";
    }
}

/// <summary>
/// Bulk discount pricing rule
/// </summary>
public class BulkDiscountPricingRule : IPricingRule
{
    private readonly int _minimumQuantity;
    private readonly decimal _discountPercentage;

    public int Priority => 10;

    public BulkDiscountPricingRule(int minimumQuantity, decimal discountPercentage)
    {
        _minimumQuantity = minimumQuantity;
        _discountPercentage = discountPercentage;
    }

    public decimal CalculatePrice(Product product, int quantity)
    {
        if (quantity >= _minimumQuantity)
        {
            var standardPrice = product.BasePrice * quantity;
            var discount = standardPrice * _discountPercentage;
            return standardPrice - discount;
        }

        // If minimum not met, return max value so other rules can apply
        return decimal.MaxValue;
    }

    public string GetRuleName()
    {
        return $"Bulk Discount ({_minimumQuantity}+ items: {_discountPercentage:P0} off)";
    }
}

/// <summary>
/// Buy X Get Y Free pricing rule
/// </summary>
public class BuyXGetYFreeRule : IPricingRule
{
    private readonly int _buyQuantity;
    private readonly int _freeQuantity;

    public int Priority => 20;

    public BuyXGetYFreeRule(int buyQuantity, int freeQuantity)
    {
        _buyQuantity = buyQuantity;
        _freeQuantity = freeQuantity;
    }

    public decimal CalculatePrice(Product product, int quantity)
    {
        var groups = quantity / (_buyQuantity + _freeQuantity);
        var remainder = quantity % (_buyQuantity + _freeQuantity);
        
        var paidItems = groups * _buyQuantity + Math.Min(remainder, _buyQuantity);
        return product.BasePrice * paidItems;
    }

    public string GetRuleName()
    {
        return $"Buy {_buyQuantity} Get {_freeQuantity} Free";
    }
}

/// <summary>
/// NEW RULE: Weekend special pricing - Added without modifying existing code!
/// </summary>
public class WeekendSpecialRule : IPricingRule
{
    private readonly decimal _weekendDiscount;

    public int Priority => 15;

    public WeekendSpecialRule(decimal weekendDiscount)
    {
        _weekendDiscount = weekendDiscount;
    }

    public decimal CalculatePrice(Product product, int quantity)
    {
        if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || 
            DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
        {
            var standardPrice = product.BasePrice * quantity;
            return standardPrice * (1 - _weekendDiscount);
        }

        return decimal.MaxValue;
    }

    public string GetRuleName()
    {
        return $"Weekend Special ({_weekendDiscount:P0} off)";
    }
}

/// <summary>
/// Pricing Engine that follows OCP
/// </summary>
public class PricingEngine
{
    private readonly List<IPricingRule> _rules = new List<IPricingRule>();

    public void AddRule(IPricingRule rule)
    {
        _rules.Add(rule);
        Console.WriteLine($"[OCP] Added pricing rule: {rule.GetRuleName()}");
    }

    public decimal CalculateBestPrice(Product product, int quantity)
    {
        Console.WriteLine($"\n[OCP] Calculating best price for {quantity}x {product.Name}");
        
        decimal bestPrice = decimal.MaxValue;
        string bestRule = "";

        // Apply rules in priority order
        foreach (var rule in _rules.OrderByDescending(r => r.Priority))
        {
            var price = rule.CalculatePrice(product, quantity);
            Console.WriteLine($"  {rule.GetRuleName()}: ${price:F2}");
            
            if (price < bestPrice)
            {
                bestPrice = price;
                bestRule = rule.GetRuleName();
            }
        }

        Console.WriteLine($"  Best price: ${bestPrice:F2} using {bestRule}");
        return bestPrice;
    }
}

// ========== TAX CALCULATION SYSTEM ==========

/// <summary>
/// Interface for tax calculations - extensible for different regions
/// </summary>
public interface ITaxCalculator
{
    decimal CalculateTax(decimal amount);
    string GetTaxType();
}

/// <summary>
/// US Sales Tax Calculator
/// </summary>
public class USSalesTaxCalculator : ITaxCalculator
{
    private readonly string _state;
    private readonly Dictionary<string, decimal> _stateTaxRates = new Dictionary<string, decimal>
    {
        { "CA", 0.0725m },
        { "TX", 0.0625m },
        { "NY", 0.08m },
        { "FL", 0.06m }
    };

    public USSalesTaxCalculator(string state)
    {
        _state = state;
    }

    public decimal CalculateTax(decimal amount)
    {
        if (_stateTaxRates.TryGetValue(_state, out var rate))
        {
            return amount * rate;
        }
        return amount * 0.05m; // Default 5%
    }

    public string GetTaxType()
    {
        return $"US Sales Tax ({_state})";
    }
}

/// <summary>
/// European VAT Calculator
/// </summary>
public class EuropeanVATCalculator : ITaxCalculator
{
    private readonly string _country;
    private readonly Dictionary<string, decimal> _vatRates = new Dictionary<string, decimal>
    {
        { "UK", 0.20m },
        { "DE", 0.19m },
        { "FR", 0.20m },
        { "ES", 0.21m }
    };

    public EuropeanVATCalculator(string country)
    {
        _country = country;
    }

    public decimal CalculateTax(decimal amount)
    {
        if (_vatRates.TryGetValue(_country, out var rate))
        {
            return amount * rate;
        }
        return amount * 0.20m; // Default 20%
    }

    public string GetTaxType()
    {
        return $"VAT ({_country})";
    }
}

/// <summary>
/// NEW TAX TYPE: Digital Services Tax - Added without modification!
/// </summary>
public class DigitalServicesTaxCalculator : ITaxCalculator
{
    private readonly decimal _rate = 0.03m; // 3% digital services tax

    public decimal CalculateTax(decimal amount)
    {
        return amount * _rate;
    }

    public string GetTaxType()
    {
        return "Digital Services Tax";
    }
}

// ========== SHIPPING CALCULATION SYSTEM ==========

/// <summary>
/// Interface for shipping methods
/// </summary>
public interface IShippingMethod
{
    decimal CalculateShippingCost(decimal weight, decimal distance);
    string GetShippingName();
    int EstimatedDays { get; }
}

/// <summary>
/// Standard shipping implementation
/// </summary>
public class StandardShipping : IShippingMethod
{
    public int EstimatedDays => 5;

    public decimal CalculateShippingCost(decimal weight, decimal distance)
    {
        return weight * 0.5m + distance * 0.1m;
    }

    public string GetShippingName()
    {
        return "Standard Shipping (5-7 days)";
    }
}

/// <summary>
/// Express shipping implementation
/// </summary>
public class ExpressShipping : IShippingMethod
{
    public int EstimatedDays => 2;

    public decimal CalculateShippingCost(decimal weight, decimal distance)
    {
        return (weight * 1.5m + distance * 0.3m) * 1.5m; // 50% premium
    }

    public string GetShippingName()
    {
        return "Express Shipping (2-3 days)";
    }
}

/// <summary>
/// NEW SHIPPING: Drone delivery - Added without modification!
/// </summary>
public class DroneDelivery : IShippingMethod
{
    private readonly decimal _maxWeight = 5.0m; // 5 kg max

    public int EstimatedDays => 0; // Same day!

    public decimal CalculateShippingCost(decimal weight, decimal distance)
    {
        if (weight > _maxWeight)
        {
            return decimal.MaxValue; // Not available
        }

        // Premium pricing for drone delivery
        return 25.0m + distance * 0.5m;
    }

    public string GetShippingName()
    {
        return "Drone Delivery (Same Day)";
    }
}

// ========== ORDER PROCESSING SYSTEM ==========

/// <summary>
/// Interface for order validation rules
/// </summary>
public interface IOrderValidationRule
{
    ValidationResult Validate(Order order);
    string GetRuleName();
}

/// <summary>
/// Minimum order amount validation
/// </summary>
public class MinimumOrderAmountRule : IOrderValidationRule
{
    private readonly decimal _minimumAmount;

    public MinimumOrderAmountRule(decimal minimumAmount)
    {
        _minimumAmount = minimumAmount;
    }

    public ValidationResult Validate(Order order)
    {
        if (order.GetTotal() < _minimumAmount)
        {
            return new ValidationResult
            {
                IsValid = false,
                ErrorMessage = $"Order total must be at least ${_minimumAmount:F2}"
            };
        }

        return new ValidationResult { IsValid = true };
    }

    public string GetRuleName()
    {
        return $"Minimum Order ${_minimumAmount:F2}";
    }
}

/// <summary>
/// Stock availability validation
/// </summary>
public class StockAvailabilityRule : IOrderValidationRule
{
    private readonly IInventoryService _inventoryService;

    public StockAvailabilityRule(IInventoryService inventoryService)
    {
        _inventoryService = inventoryService;
    }

    public ValidationResult Validate(Order order)
    {
        foreach (var item in order.Items)
        {
            if (!_inventoryService.IsAvailable(item.Product.Id, item.Quantity))
            {
                return new ValidationResult
                {
                    IsValid = false,
                    ErrorMessage = $"Insufficient stock for {item.Product.Name}"
                };
            }
        }

        return new ValidationResult { IsValid = true };
    }

    public string GetRuleName()
    {
        return "Stock Availability Check";
    }
}

/// <summary>
/// Order Processor that follows OCP
/// </summary>
public class OrderProcessor
{
    private readonly List<IOrderValidationRule> _validationRules = new List<IOrderValidationRule>();
    private readonly PricingEngine _pricingEngine;
    private readonly List<ITaxCalculator> _taxCalculators = new List<ITaxCalculator>();
    private readonly List<IShippingMethod> _shippingMethods = new List<IShippingMethod>();

    public OrderProcessor(PricingEngine pricingEngine)
    {
        _pricingEngine = pricingEngine;
    }

    public void AddValidationRule(IOrderValidationRule rule)
    {
        _validationRules.Add(rule);
    }

    public void AddTaxCalculator(ITaxCalculator calculator)
    {
        _taxCalculators.Add(calculator);
    }

    public void AddShippingMethod(IShippingMethod method)
    {
        _shippingMethods.Add(method);
    }

    public OrderResult ProcessOrder(Order order, IShippingMethod selectedShipping)
    {
        Console.WriteLine("\n[OCP] Processing Order");
        
        // Validate order
        foreach (var rule in _validationRules)
        {
            var result = rule.Validate(order);
            if (!result.IsValid)
            {
                Console.WriteLine($"  Validation failed: {rule.GetRuleName()} - {result.ErrorMessage}");
                return new OrderResult { Success = false, Message = result.ErrorMessage };
            }
        }

        // Calculate pricing
        decimal subtotal = 0;
        foreach (var item in order.Items)
        {
            var price = _pricingEngine.CalculateBestPrice(item.Product, item.Quantity);
            subtotal += price;
        }

        // Calculate taxes
        decimal totalTax = 0;
        foreach (var calculator in _taxCalculators)
        {
            var tax = calculator.CalculateTax(subtotal);
            Console.WriteLine($"  {calculator.GetTaxType()}: ${tax:F2}");
            totalTax += tax;
        }

        // Calculate shipping
        var shippingCost = selectedShipping.CalculateShippingCost(
            order.GetTotalWeight(), 
            order.ShippingDistance
        );
        Console.WriteLine($"  {selectedShipping.GetShippingName()}: ${shippingCost:F2}");

        // Final total
        var finalTotal = subtotal + totalTax + shippingCost;
        Console.WriteLine($"  Final Total: ${finalTotal:F2}");

        return new OrderResult
        {
            Success = true,
            Subtotal = subtotal,
            Tax = totalTax,
            Shipping = shippingCost,
            Total = finalTotal
        };
    }
}

// ========== SUPPORTING CLASSES ==========

public class Product
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public decimal BasePrice { get; set; }
    public decimal Weight { get; set; }
}

public class OrderItem
{
    public Product Product { get; set; } = new Product();
    public int Quantity { get; set; }
}

public class Order
{
    public string OrderId { get; set; } = "";
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    public decimal ShippingDistance { get; set; }

    public decimal GetTotal()
    {
        return Items.Sum(i => i.Product.BasePrice * i.Quantity);
    }

    public decimal GetTotalWeight()
    {
        return Items.Sum(i => i.Product.Weight * i.Quantity);
    }
}

public class ValidationResult
{
    public bool IsValid { get; set; }
    public string ErrorMessage { get; set; } = "";
}

public class OrderResult
{
    public bool Success { get; set; }
    public string Message { get; set; } = "";
    public decimal Subtotal { get; set; }
    public decimal Tax { get; set; }
    public decimal Shipping { get; set; }
    public decimal Total { get; set; }
}

public interface IInventoryService
{
    bool IsAvailable(string productId, int quantity);
}

public class SimpleInventoryService : IInventoryService
{
    private readonly Dictionary<string, int> _stock = new Dictionary<string, int>();

    public void AddStock(string productId, int quantity)
    {
        if (!_stock.ContainsKey(productId))
            _stock[productId] = 0;
        _stock[productId] += quantity;
    }

    public bool IsAvailable(string productId, int quantity)
    {
        return _stock.ContainsKey(productId) && _stock[productId] >= quantity;
    }
}