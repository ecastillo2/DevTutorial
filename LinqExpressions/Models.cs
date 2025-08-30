namespace LinqExpressions;

/// <summary>
/// Data models representing a simple e-commerce database structure
/// These models will be used to demonstrate LINQ queries that mirror SQL operations
/// </summary>

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public string City { get; set; } = "";
    public string Country { get; set; } = "";
    public DateTime RegisteredDate { get; set; }
    public bool IsActive { get; set; }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Category { get; set; } = "";
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public string Supplier { get; set; } = "";
    public bool IsDiscontinued { get; set; }
}

public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public string Status { get; set; } = "";
    public string ShippingCity { get; set; } = "";
    public string ShippingCountry { get; set; } = "";
}

public class OrderDetail
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }
}

/// <summary>
/// Sample data provider to simulate a database
/// </summary>
public static class SampleData
{
    public static List<Customer> GetCustomers()
    {
        return new List<Customer>
        {
            new() { Id = 1, Name = "John Smith", Email = "john@email.com", City = "New York", Country = "USA", RegisteredDate = new DateTime(2020, 1, 15), IsActive = true },
            new() { Id = 2, Name = "Maria Garcia", Email = "maria@email.com", City = "Madrid", Country = "Spain", RegisteredDate = new DateTime(2021, 3, 22), IsActive = true },
            new() { Id = 3, Name = "David Chen", Email = "david@email.com", City = "Shanghai", Country = "China", RegisteredDate = new DateTime(2019, 7, 8), IsActive = false },
            new() { Id = 4, Name = "Sarah Johnson", Email = "sarah@email.com", City = "London", Country = "UK", RegisteredDate = new DateTime(2022, 5, 10), IsActive = true },
            new() { Id = 5, Name = "Ahmed Hassan", Email = "ahmed@email.com", City = "Cairo", Country = "Egypt", RegisteredDate = new DateTime(2021, 11, 30), IsActive = true },
            new() { Id = 6, Name = "Lisa Anderson", Email = "lisa@email.com", City = "Los Angeles", Country = "USA", RegisteredDate = new DateTime(2020, 8, 14), IsActive = true },
            new() { Id = 7, Name = "Carlos Rodriguez", Email = "carlos@email.com", City = "Mexico City", Country = "Mexico", RegisteredDate = new DateTime(2023, 1, 5), IsActive = true },
            new() { Id = 8, Name = "Emma Wilson", Email = "emma@email.com", City = "Sydney", Country = "Australia", RegisteredDate = new DateTime(2022, 9, 18), IsActive = false },
            new() { Id = 9, Name = "Jean Dupont", Email = "jean@email.com", City = "Paris", Country = "France", RegisteredDate = new DateTime(2021, 6, 25), IsActive = true },
            new() { Id = 10, Name = "Yuki Tanaka", Email = "yuki@email.com", City = "Tokyo", Country = "Japan", RegisteredDate = new DateTime(2020, 12, 3), IsActive = true }
        };
    }

    public static List<Product> GetProducts()
    {
        return new List<Product>
        {
            new() { Id = 1, Name = "Laptop Pro 15", Category = "Electronics", Price = 1299.99m, StockQuantity = 50, Supplier = "TechCorp", IsDiscontinued = false },
            new() { Id = 2, Name = "Wireless Mouse", Category = "Electronics", Price = 29.99m, StockQuantity = 200, Supplier = "TechCorp", IsDiscontinued = false },
            new() { Id = 3, Name = "Office Chair", Category = "Furniture", Price = 249.99m, StockQuantity = 75, Supplier = "FurniturePlus", IsDiscontinued = false },
            new() { Id = 4, Name = "Standing Desk", Category = "Furniture", Price = 599.99m, StockQuantity = 30, Supplier = "FurniturePlus", IsDiscontinued = false },
            new() { Id = 5, Name = "USB-C Hub", Category = "Electronics", Price = 49.99m, StockQuantity = 150, Supplier = "TechCorp", IsDiscontinued = false },
            new() { Id = 6, Name = "Monitor 27\"", Category = "Electronics", Price = 399.99m, StockQuantity = 40, Supplier = "DisplayTech", IsDiscontinued = false },
            new() { Id = 7, Name = "Desk Lamp", Category = "Furniture", Price = 79.99m, StockQuantity = 100, Supplier = "LightingCo", IsDiscontinued = false },
            new() { Id = 8, Name = "Mechanical Keyboard", Category = "Electronics", Price = 149.99m, StockQuantity = 80, Supplier = "TechCorp", IsDiscontinued = false },
            new() { Id = 9, Name = "Webcam HD", Category = "Electronics", Price = 89.99m, StockQuantity = 60, Supplier = "CameraTech", IsDiscontinued = false },
            new() { Id = 10, Name = "Printer Inkjet", Category = "Electronics", Price = 199.99m, StockQuantity = 25, Supplier = "PrintMaster", IsDiscontinued = true },
            new() { Id = 11, Name = "Bookshelf", Category = "Furniture", Price = 149.99m, StockQuantity = 45, Supplier = "FurniturePlus", IsDiscontinued = false },
            new() { Id = 12, Name = "Coffee Maker", Category = "Appliances", Price = 99.99m, StockQuantity = 35, Supplier = "HomeTech", IsDiscontinued = false },
            new() { Id = 13, Name = "Water Bottle", Category = "Accessories", Price = 19.99m, StockQuantity = 300, Supplier = "LifeStyle", IsDiscontinued = false },
            new() { Id = 14, Name = "Notebook Set", Category = "Stationery", Price = 24.99m, StockQuantity = 250, Supplier = "PaperCo", IsDiscontinued = false },
            new() { Id = 15, Name = "Phone Stand", Category = "Accessories", Price = 15.99m, StockQuantity = 180, Supplier = "AccessoriesInc", IsDiscontinued = false }
        };
    }

    public static List<Order> GetOrders()
    {
        return new List<Order>
        {
            new() { Id = 1, CustomerId = 1, OrderDate = new DateTime(2023, 10, 1), TotalAmount = 1329.98m, Status = "Delivered", ShippingCity = "New York", ShippingCountry = "USA" },
            new() { Id = 2, CustomerId = 2, OrderDate = new DateTime(2023, 10, 5), TotalAmount = 849.97m, Status = "Delivered", ShippingCity = "Madrid", ShippingCountry = "Spain" },
            new() { Id = 3, CustomerId = 1, OrderDate = new DateTime(2023, 10, 10), TotalAmount = 229.97m, Status = "Shipped", ShippingCity = "New York", ShippingCountry = "USA" },
            new() { Id = 4, CustomerId = 4, OrderDate = new DateTime(2023, 10, 12), TotalAmount = 649.98m, Status = "Processing", ShippingCity = "London", ShippingCountry = "UK" },
            new() { Id = 5, CustomerId = 5, OrderDate = new DateTime(2023, 10, 15), TotalAmount = 199.98m, Status = "Delivered", ShippingCity = "Cairo", ShippingCountry = "Egypt" },
            new() { Id = 6, CustomerId = 6, OrderDate = new DateTime(2023, 10, 18), TotalAmount = 449.97m, Status = "Shipped", ShippingCity = "Los Angeles", ShippingCountry = "USA" },
            new() { Id = 7, CustomerId = 7, OrderDate = new DateTime(2023, 10, 20), TotalAmount = 1899.96m, Status = "Processing", ShippingCity = "Mexico City", ShippingCountry = "Mexico" },
            new() { Id = 8, CustomerId = 9, OrderDate = new DateTime(2023, 10, 22), TotalAmount = 329.97m, Status = "Delivered", ShippingCity = "Paris", ShippingCountry = "France" },
            new() { Id = 9, CustomerId = 10, OrderDate = new DateTime(2023, 10, 25), TotalAmount = 179.97m, Status = "Shipped", ShippingCity = "Tokyo", ShippingCountry = "Japan" },
            new() { Id = 10, CustomerId = 1, OrderDate = new DateTime(2023, 10, 28), TotalAmount = 99.99m, Status = "Processing", ShippingCity = "New York", ShippingCountry = "USA" },
            new() { Id = 11, CustomerId = 2, OrderDate = new DateTime(2023, 11, 1), TotalAmount = 599.99m, Status = "Delivered", ShippingCity = "Madrid", ShippingCountry = "Spain" },
            new() { Id = 12, CustomerId = 4, OrderDate = new DateTime(2023, 11, 3), TotalAmount = 249.99m, Status = "Shipped", ShippingCity = "London", ShippingCountry = "UK" }
        };
    }

    public static List<OrderDetail> GetOrderDetails()
    {
        return new List<OrderDetail>
        {
            // Order 1 details
            new() { Id = 1, OrderId = 1, ProductId = 1, Quantity = 1, UnitPrice = 1299.99m, Discount = 0 },
            new() { Id = 2, OrderId = 1, ProductId = 2, Quantity = 1, UnitPrice = 29.99m, Discount = 0 },
            
            // Order 2 details
            new() { Id = 3, OrderId = 2, ProductId = 3, Quantity = 1, UnitPrice = 249.99m, Discount = 0 },
            new() { Id = 4, OrderId = 2, ProductId = 4, Quantity = 1, UnitPrice = 599.99m, Discount = 0 },
            
            // Order 3 details
            new() { Id = 5, OrderId = 3, ProductId = 5, Quantity = 2, UnitPrice = 49.99m, Discount = 0 },
            new() { Id = 6, OrderId = 3, ProductId = 8, Quantity = 1, UnitPrice = 149.99m, Discount = 0.1m },
            
            // Order 4 details
            new() { Id = 7, OrderId = 4, ProductId = 6, Quantity = 1, UnitPrice = 399.99m, Discount = 0 },
            new() { Id = 8, OrderId = 4, ProductId = 3, Quantity = 1, UnitPrice = 249.99m, Discount = 0 },
            
            // Order 5 details
            new() { Id = 9, OrderId = 5, ProductId = 9, Quantity = 1, UnitPrice = 89.99m, Discount = 0 },
            new() { Id = 10, OrderId = 5, ProductId = 7, Quantity = 1, UnitPrice = 79.99m, Discount = 0 },
            new() { Id = 11, OrderId = 5, ProductId = 2, Quantity = 1, UnitPrice = 29.99m, Discount = 0 },
            
            // Order 6 details
            new() { Id = 12, OrderId = 6, ProductId = 11, Quantity = 2, UnitPrice = 149.99m, Discount = 0 },
            new() { Id = 13, OrderId = 6, ProductId = 8, Quantity = 1, UnitPrice = 149.99m, Discount = 0 },
            
            // Order 7 details
            new() { Id = 14, OrderId = 7, ProductId = 1, Quantity = 1, UnitPrice = 1299.99m, Discount = 0 },
            new() { Id = 15, OrderId = 7, ProductId = 4, Quantity = 1, UnitPrice = 599.99m, Discount = 0 },
            
            // Order 8 details
            new() { Id = 16, OrderId = 8, ProductId = 7, Quantity = 2, UnitPrice = 79.99m, Discount = 0 },
            new() { Id = 17, OrderId = 8, ProductId = 14, Quantity = 3, UnitPrice = 24.99m, Discount = 0 },
            new() { Id = 18, OrderId = 8, ProductId = 12, Quantity = 1, UnitPrice = 99.99m, Discount = 0.05m },
            
            // Order 9 details
            new() { Id = 19, OrderId = 9, ProductId = 13, Quantity = 3, UnitPrice = 19.99m, Discount = 0 },
            new() { Id = 20, OrderId = 9, ProductId = 15, Quantity = 2, UnitPrice = 15.99m, Discount = 0 },
            new() { Id = 21, OrderId = 9, ProductId = 9, Quantity = 1, UnitPrice = 89.99m, Discount = 0 },
            
            // Order 10 details
            new() { Id = 22, OrderId = 10, ProductId = 12, Quantity = 1, UnitPrice = 99.99m, Discount = 0 },
            
            // Order 11 details
            new() { Id = 23, OrderId = 11, ProductId = 4, Quantity = 1, UnitPrice = 599.99m, Discount = 0 },
            
            // Order 12 details
            new() { Id = 24, OrderId = 12, ProductId = 3, Quantity = 1, UnitPrice = 249.99m, Discount = 0 }
        };
    }
}