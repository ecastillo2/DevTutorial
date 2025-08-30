using LinqExpressions;

Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║                    LINQ EXPRESSIONS - SQL-LIKE OPERATIONS              ║");
Console.WriteLine("║                 Language Integrated Query Demonstrations               ║");
Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
Console.WriteLine();

// Load sample data
var customers = SampleData.GetCustomers();
var products = SampleData.GetProducts();
var orders = SampleData.GetOrders();
var orderDetails = SampleData.GetOrderDetails();

Console.WriteLine("INTRODUCTION TO LINQ:");
Console.WriteLine("════════════════════");
Console.WriteLine("LINQ (Language Integrated Query) provides a consistent query experience");
Console.WriteLine("for objects (LINQ to Objects), databases (LINQ to SQL), XML (LINQ to XML),");
Console.WriteLine("and more. It uses a SQL-like syntax integrated directly into C#.");
Console.WriteLine();

Console.WriteLine("TWO SYNTAX STYLES:");
Console.WriteLine("• Query Syntax: Similar to SQL (from x in collection where ... select ...)");
Console.WriteLine("• Method Syntax: Using extension methods (.Where(), .Select(), etc.)");
Console.WriteLine();

// 1. SELECT - Basic Projection
Console.WriteLine("\n╔═══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║ 1. SELECT - Basic Projection (Getting specific columns)           ║");
Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝");

Console.WriteLine("\nSQL: SELECT Name, Email FROM Customers");
Console.WriteLine("\nQuery Syntax:");
var customerNamesQuery = from c in customers
                        select new { c.Name, c.Email };

Console.WriteLine("var result = from c in customers");
Console.WriteLine("            select new { c.Name, c.Email };");

Console.WriteLine("\nMethod Syntax:");
var customerNamesMethod = customers.Select(c => new { c.Name, c.Email });

Console.WriteLine("var result = customers.Select(c => new { c.Name, c.Email });");

Console.WriteLine("\nResults:");
foreach (var customer in customerNamesQuery.Take(3))
{
    Console.WriteLine($"  {customer.Name} - {customer.Email}");
}

Console.WriteLine("\n💡 Explanation:");
Console.WriteLine("• 'select new { }' creates anonymous types with only the fields we need");
Console.WriteLine("• This is equivalent to SQL's column selection");
Console.WriteLine("• Both syntaxes produce identical results");

// 2. WHERE - Filtering
Console.WriteLine("\n\n╔═══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║ 2. WHERE - Filtering Records                                      ║");
Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝");

Console.WriteLine("\nSQL: SELECT * FROM Customers WHERE Country = 'USA' AND IsActive = true");
Console.WriteLine("\nQuery Syntax:");
var usaCustomersQuery = from c in customers
                       where c.Country == "USA" && c.IsActive == true
                       select c;

Console.WriteLine("var result = from c in customers");
Console.WriteLine("            where c.Country == \"USA\" && c.IsActive == true");
Console.WriteLine("            select c;");

Console.WriteLine("\nMethod Syntax:");
var usaCustomersMethod = customers.Where(c => c.Country == "USA" && c.IsActive == true);

Console.WriteLine("var result = customers.Where(c => c.Country == \"USA\" && c.IsActive == true);");

Console.WriteLine("\nResults:");
foreach (var customer in usaCustomersQuery)
{
    Console.WriteLine($"  {customer.Name} from {customer.City}, {customer.Country}");
}

Console.WriteLine("\n💡 Explanation:");
Console.WriteLine("• 'where' clause filters records based on conditions");
Console.WriteLine("• Can use && (AND), || (OR), and other logical operators");
Console.WriteLine("• Lambda expressions in method syntax: c => condition");

// 3. ORDER BY - Sorting
Console.WriteLine("\n\n╔═══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║ 3. ORDER BY - Sorting Results                                     ║");
Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝");

Console.WriteLine("\nSQL: SELECT * FROM Products ORDER BY Price DESC, Name ASC");
Console.WriteLine("\nQuery Syntax:");
var sortedProductsQuery = from p in products
                         orderby p.Price descending, p.Name
                         select p;

Console.WriteLine("var result = from p in products");
Console.WriteLine("            orderby p.Price descending, p.Name");
Console.WriteLine("            select p;");

Console.WriteLine("\nMethod Syntax:");
var sortedProductsMethod = products.OrderByDescending(p => p.Price)
                                  .ThenBy(p => p.Name);

Console.WriteLine("var result = products.OrderByDescending(p => p.Price)");
Console.WriteLine("                    .ThenBy(p => p.Name);");

Console.WriteLine("\nTop 5 Most Expensive Products:");
foreach (var product in sortedProductsQuery.Take(5))
{
    Console.WriteLine($"  ${product.Price:F2} - {product.Name}");
}

Console.WriteLine("\n💡 Explanation:");
Console.WriteLine("• 'orderby' sorts results (default is ascending)");
Console.WriteLine("• 'descending' keyword for reverse order");
Console.WriteLine("• Multiple sort criteria separated by commas");
Console.WriteLine("• Method syntax uses OrderBy/OrderByDescending and ThenBy/ThenByDescending");

// 4. GROUP BY - Grouping and Aggregation
Console.WriteLine("\n\n╔═══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║ 4. GROUP BY - Grouping and Aggregation                           ║");
Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝");

Console.WriteLine("\nSQL: SELECT Category, COUNT(*) as Count, AVG(Price) as AvgPrice");
Console.WriteLine("     FROM Products GROUP BY Category");

Console.WriteLine("\nQuery Syntax:");
var groupedProductsQuery = from p in products
                          group p by p.Category into g
                          select new
                          {
                              Category = g.Key,
                              Count = g.Count(),
                              AvgPrice = g.Average(p => p.Price),
                              MinPrice = g.Min(p => p.Price),
                              MaxPrice = g.Max(p => p.Price)
                          };

Console.WriteLine("var result = from p in products");
Console.WriteLine("            group p by p.Category into g");
Console.WriteLine("            select new");
Console.WriteLine("            {");
Console.WriteLine("                Category = g.Key,");
Console.WriteLine("                Count = g.Count(),");
Console.WriteLine("                AvgPrice = g.Average(p => p.Price)");
Console.WriteLine("            };");

Console.WriteLine("\nMethod Syntax:");
var groupedProductsMethod = products.GroupBy(p => p.Category)
                                   .Select(g => new
                                   {
                                       Category = g.Key,
                                       Count = g.Count(),
                                       AvgPrice = g.Average(p => p.Price),
                                       MinPrice = g.Min(p => p.Price),
                                       MaxPrice = g.Max(p => p.Price)
                                   });

Console.WriteLine("\nResults:");
foreach (var group in groupedProductsQuery)
{
    Console.WriteLine($"  {group.Category}:");
    Console.WriteLine($"    Count: {group.Count} products");
    Console.WriteLine($"    Average Price: ${group.AvgPrice:F2}");
    Console.WriteLine($"    Price Range: ${group.MinPrice:F2} - ${group.MaxPrice:F2}");
}

Console.WriteLine("\n💡 Explanation:");
Console.WriteLine("• 'group by' creates groups based on a key");
Console.WriteLine("• 'into g' creates a grouping variable");
Console.WriteLine("• g.Key contains the grouping value");
Console.WriteLine("• Aggregate functions: Count(), Sum(), Average(), Min(), Max()");

// 5. JOIN - Combining Tables
Console.WriteLine("\n\n╔═══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║ 5. JOIN - Combining Multiple Data Sources                        ║");
Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝");

Console.WriteLine("\nSQL: SELECT o.Id, c.Name, o.TotalAmount");
Console.WriteLine("     FROM Orders o");
Console.WriteLine("     INNER JOIN Customers c ON o.CustomerId = c.Id");

Console.WriteLine("\nQuery Syntax:");
var orderCustomerJoinQuery = from o in orders
                            join c in customers on o.CustomerId equals c.Id
                            select new
                            {
                                OrderId = o.Id,
                                CustomerName = c.Name,
                                OrderDate = o.OrderDate,
                                Total = o.TotalAmount
                            };

Console.WriteLine("var result = from o in orders");
Console.WriteLine("            join c in customers on o.CustomerId equals c.Id");
Console.WriteLine("            select new { o.Id, c.Name, o.TotalAmount };");

Console.WriteLine("\nMethod Syntax:");
var orderCustomerJoinMethod = orders.Join(customers,
    o => o.CustomerId,
    c => c.Id,
    (o, c) => new
    {
        OrderId = o.Id,
        CustomerName = c.Name,
        OrderDate = o.OrderDate,
        Total = o.TotalAmount
    });

Console.WriteLine("\nFirst 5 Orders with Customer Names:");
foreach (var item in orderCustomerJoinQuery.Take(5))
{
    Console.WriteLine($"  Order #{item.OrderId} - {item.CustomerName} - ${item.Total:F2} ({item.OrderDate:yyyy-MM-dd})");
}

Console.WriteLine("\n💡 Explanation:");
Console.WriteLine("• 'join' combines two collections based on matching keys");
Console.WriteLine("• Uses 'equals' keyword (not ==) for join conditions");
Console.WriteLine("• Can project results into new shape with 'select new'");

// 6. LEFT JOIN - Including All Records from Left Table
Console.WriteLine("\n\n╔═══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║ 6. LEFT JOIN - Including All Records from One Side               ║");
Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝");

Console.WriteLine("\nSQL: SELECT c.Name, COUNT(o.Id) as OrderCount");
Console.WriteLine("     FROM Customers c");
Console.WriteLine("     LEFT JOIN Orders o ON c.Id = o.CustomerId");
Console.WriteLine("     GROUP BY c.Id, c.Name");

Console.WriteLine("\nQuery Syntax (using GroupJoin):");
var customerOrdersQuery = from c in customers
                         join o in orders on c.Id equals o.CustomerId into customerOrders
                         select new
                         {
                             CustomerName = c.Name,
                             OrderCount = customerOrders.Count(),
                             TotalSpent = customerOrders.Sum(o => o.TotalAmount)
                         };

Console.WriteLine("var result = from c in customers");
Console.WriteLine("            join o in orders on c.Id equals o.CustomerId into customerOrders");
Console.WriteLine("            select new");
Console.WriteLine("            {");
Console.WriteLine("                CustomerName = c.Name,");
Console.WriteLine("                OrderCount = customerOrders.Count()");
Console.WriteLine("            };");

Console.WriteLine("\nResults - All Customers with Order Summary:");
foreach (var customer in customerOrdersQuery)
{
    Console.WriteLine($"  {customer.CustomerName}: {customer.OrderCount} orders, Total: ${customer.TotalSpent:F2}");
}

Console.WriteLine("\n💡 Explanation:");
Console.WriteLine("• 'join...into' creates a group join (similar to LEFT JOIN)");
Console.WriteLine("• All customers included even if they have no orders");
Console.WriteLine("• customerOrders is a collection of matching orders (can be empty)");

// 7. Complex Query - Multiple Joins and Aggregations
Console.WriteLine("\n\n╔═══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║ 7. COMPLEX QUERY - Multiple Joins and Aggregations               ║");
Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝");

Console.WriteLine("\nSQL: SELECT p.Name, SUM(od.Quantity) as TotalSold, SUM(od.Quantity * od.UnitPrice) as Revenue");
Console.WriteLine("     FROM Products p");
Console.WriteLine("     JOIN OrderDetails od ON p.Id = od.ProductId");
Console.WriteLine("     JOIN Orders o ON od.OrderId = o.Id");
Console.WriteLine("     WHERE o.Status = 'Delivered'");
Console.WriteLine("     GROUP BY p.Id, p.Name");
Console.WriteLine("     HAVING SUM(od.Quantity) > 2");
Console.WriteLine("     ORDER BY Revenue DESC");

var productSalesQuery = from p in products
                       join od in orderDetails on p.Id equals od.ProductId
                       join o in orders on od.OrderId equals o.Id
                       where o.Status == "Delivered"
                       group new { p, od } by new { p.Id, p.Name } into g
                       let totalQuantity = g.Sum(x => x.od.Quantity)
                       let revenue = g.Sum(x => x.od.Quantity * x.od.UnitPrice)
                       where totalQuantity > 2
                       orderby revenue descending
                       select new
                       {
                           ProductName = g.Key.Name,
                           TotalSold = totalQuantity,
                           Revenue = revenue
                       };

Console.WriteLine("\nTop Selling Products (Delivered Orders Only):");
foreach (var item in productSalesQuery)
{
    Console.WriteLine($"  {item.ProductName}: {item.TotalSold} units sold, Revenue: ${item.Revenue:F2}");
}

Console.WriteLine("\n💡 Explanation:");
Console.WriteLine("• Multiple joins chain together");
Console.WriteLine("• 'let' keyword creates intermediate variables");
Console.WriteLine("• 'where' after 'group by' acts like SQL's HAVING clause");
Console.WriteLine("• Complex aggregations possible within grouped data");

// 8. DISTINCT and Set Operations
Console.WriteLine("\n\n╔═══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║ 8. DISTINCT and Set Operations                                   ║");
Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝");

Console.WriteLine("\nSQL: SELECT DISTINCT Country FROM Customers");
var distinctCountries = customers.Select(c => c.Country).Distinct();

Console.WriteLine("\nDistinct Countries:");
foreach (var country in distinctCountries.OrderBy(c => c))
{
    Console.WriteLine($"  • {country}");
}

Console.WriteLine("\nSQL: SELECT ProductId FROM OrderDetails WHERE OrderId IN (1,2)");
Console.WriteLine("     UNION");
Console.WriteLine("     SELECT ProductId FROM OrderDetails WHERE OrderId IN (3,4)");

var products1_2 = orderDetails.Where(od => od.OrderId == 1 || od.OrderId == 2).Select(od => od.ProductId);
var products3_4 = orderDetails.Where(od => od.OrderId == 3 || od.OrderId == 4).Select(od => od.ProductId);

var unionProducts = products1_2.Union(products3_4);
var intersectProducts = products1_2.Intersect(products3_4);
var exceptProducts = products1_2.Except(products3_4);

Console.WriteLine($"\nProducts in Orders 1-2: {string.Join(", ", products1_2.Distinct())}");
Console.WriteLine($"Products in Orders 3-4: {string.Join(", ", products3_4.Distinct())}");
Console.WriteLine($"Union (all products): {string.Join(", ", unionProducts)}");
Console.WriteLine($"Intersect (common products): {string.Join(", ", intersectProducts)}");
Console.WriteLine($"Except (in 1-2 but not 3-4): {string.Join(", ", exceptProducts)}");

Console.WriteLine("\n💡 Explanation:");
Console.WriteLine("• Distinct() removes duplicates");
Console.WriteLine("• Union() combines sets (no duplicates)");
Console.WriteLine("• Intersect() finds common elements");
Console.WriteLine("• Except() finds elements in first but not second");

// 9. ANY, ALL, and EXISTS equivalent
Console.WriteLine("\n\n╔═══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║ 9. ANY, ALL, and EXISTS Operations                               ║");
Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝");

Console.WriteLine("\nSQL: SELECT * FROM Customers WHERE EXISTS");
Console.WriteLine("     (SELECT 1 FROM Orders WHERE CustomerId = Customers.Id)");

var customersWithOrders = customers.Where(c => orders.Any(o => o.CustomerId == c.Id));

Console.WriteLine("\nCustomers with at least one order:");
foreach (var customer in customersWithOrders)
{
    Console.WriteLine($"  • {customer.Name}");
}

Console.WriteLine("\nChecking conditions:");
var anyExpensiveProducts = products.Any(p => p.Price > 1000);
var allProductsInStock = products.All(p => p.StockQuantity > 0);
var allProductsUnder2000 = products.All(p => p.Price < 2000);

Console.WriteLine($"Any products over $1000? {anyExpensiveProducts}");
Console.WriteLine($"All products in stock? {allProductsInStock}");
Console.WriteLine($"All products under $2000? {allProductsUnder2000}");

Console.WriteLine("\n💡 Explanation:");
Console.WriteLine("• Any() checks if any element matches condition (EXISTS)");
Console.WriteLine("• All() checks if all elements match condition");
Console.WriteLine("• These return boolean values, not collections");

// 10. Pagination with SKIP and TAKE
Console.WriteLine("\n\n╔═══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║ 10. PAGINATION - Skip and Take (LIMIT/OFFSET)                    ║");
Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝");

Console.WriteLine("\nSQL: SELECT * FROM Products ORDER BY Name LIMIT 5 OFFSET 5");
Console.WriteLine("     (Get page 2 with 5 items per page)");

int pageSize = 5;
int pageNumber = 2;
var pagedProducts = products.OrderBy(p => p.Name)
                           .Skip((pageNumber - 1) * pageSize)
                           .Take(pageSize);

Console.WriteLine($"\nPage {pageNumber} of Products (sorted by name):");
foreach (var product in pagedProducts)
{
    Console.WriteLine($"  • {product.Name} - ${product.Price:F2}");
}

Console.WriteLine("\n💡 Explanation:");
Console.WriteLine("• Skip() bypasses a number of elements (OFFSET)");
Console.WriteLine("• Take() limits the number of results (LIMIT)");
Console.WriteLine("• Perfect for implementing pagination");

// Summary
Console.WriteLine("\n\n╔═══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║                          LINQ SUMMARY                             ║");
Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝");

Console.WriteLine("\nKEY LINQ CONCEPTS:");
Console.WriteLine("┌─────────────────────────────────────────────────────────────────┐");
Console.WriteLine("│ 1. DEFERRED EXECUTION: Queries execute when iterated, not defined│");
Console.WriteLine("│ 2. STRONGLY TYPED: Compile-time checking and IntelliSense      │");
Console.WriteLine("│ 3. COMPOSABLE: Chain multiple operations together               │");
Console.WriteLine("│ 4. CONSISTENT: Same syntax for different data sources           │");
Console.WriteLine("│ 5. FUNCTIONAL: Based on functional programming principles       │");
Console.WriteLine("└─────────────────────────────────────────────────────────────────┘");

Console.WriteLine("\nSQL TO LINQ MAPPING:");
Console.WriteLine("┌──────────────────┬────────────────────────────────────────────┐");
Console.WriteLine("│ SQL              │ LINQ                                       │");
Console.WriteLine("├──────────────────┼────────────────────────────────────────────┤");
Console.WriteLine("│ SELECT           │ select (projection)                        │");
Console.WriteLine("│ WHERE            │ where (filtering)                          │");
Console.WriteLine("│ ORDER BY         │ orderby / OrderBy()                        │");
Console.WriteLine("│ GROUP BY         │ group by / GroupBy()                       │");
Console.WriteLine("│ HAVING           │ where (after grouping)                     │");
Console.WriteLine("│ JOIN             │ join / Join()                              │");
Console.WriteLine("│ LEFT JOIN        │ join...into / GroupJoin()                  │");
Console.WriteLine("│ DISTINCT         │ Distinct()                                 │");
Console.WriteLine("│ COUNT/SUM/AVG    │ Count()/Sum()/Average()                    │");
Console.WriteLine("│ LIMIT/OFFSET     │ Take()/Skip()                              │");
Console.WriteLine("│ EXISTS           │ Any()                                      │");
Console.WriteLine("│ IN               │ Contains()                                 │");
Console.WriteLine("└──────────────────┴────────────────────────────────────────────┘");

Console.WriteLine("\nADVANTAGES OF LINQ:");
Console.WriteLine("• Type safety and IntelliSense support");
Console.WriteLine("• Unified query syntax across different data sources");
Console.WriteLine("• Deferred execution for performance optimization");
Console.WriteLine("• Functional programming capabilities");
Console.WriteLine("• Easier to read and maintain than SQL strings");

Console.WriteLine("\n╔══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║   LINQ: Write queries in C#, think in SQL! 🔍                   ║");
Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝");