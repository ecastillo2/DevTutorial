using Microsoft.AspNetCore.Mvc;
using SqlInterviewWeb.Models;

namespace SqlInterviewWeb.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var model = new SqlInterviewViewModel
        {
            ExecutionSteps = GetExecutionSteps()
        };
        
        return View(model);
    }

    public IActionResult Schema()
    {
        var model = new DatabaseSchema();
        return View(model);
    }

    public IActionResult Query()
    {
        var model = new SqlQuery();
        return View(model);
    }

    public IActionResult Explanation()
    {
        var model = GetSqlExplanation();
        return View(model);
    }

    public IActionResult SampleData()
    {
        var model = GetSampleDataset();
        return View(model);
    }

    public IActionResult ExecuteQuery()
    {
        var model = GetQueryResults();
        return View(model);
    }

    private List<QueryStep> GetExecutionSteps()
    {
        return new List<QueryStep>
        {
            new QueryStep
            {
                StepNumber = 1,
                Operation = "Table Scan/Index Seek on Company",
                Description = "Find the company with name 'First Bank Corporation'",
                SqlFragment = "WHERE c.company_name = 'First Bank Corporation'",
                EstimatedRows = 1
            },
            new QueryStep
            {
                StepNumber = 2,
                Operation = "Index Seek on Employment",
                Description = "Find all employment records for the found company",
                SqlFragment = "JOIN Employment emp ON emp.company_id = c.company_id",
                EstimatedRows = 50
            },
            new QueryStep
            {
                StepNumber = 3,
                Operation = "Filter on Salary",
                Description = "Keep only employment records with salary > 100000",
                SqlFragment = "WHERE emp.salary > 100000",
                EstimatedRows = 15
            },
            new QueryStep
            {
                StepNumber = 4,
                Operation = "Filter on Active Status",
                Description = "Keep only active employment records",
                SqlFragment = "AND emp.is_active = 1",
                EstimatedRows = 12
            },
            new QueryStep
            {
                StepNumber = 5,
                Operation = "Nested Loop Join with Employee",
                Description = "Join with Employee table to get personal information",
                SqlFragment = "JOIN Employee e ON e.employee_id = emp.employee_id",
                EstimatedRows = 12
            },
            new QueryStep
            {
                StepNumber = 6,
                Operation = "Compute Scalar",
                Description = "Concatenate first and last names, select required columns",
                SqlFragment = "SELECT e.first_name + ' ' + e.last_name AS employee_name, e.street_address, e.city",
                EstimatedRows = 12
            }
        };
    }

    private QueryResult GetQueryResults()
    {
        var result = new QueryResult
        {
            SqlQuery = @"SELECT 
    e.first_name + ' ' + e.last_name AS employee_name,
    e.street_address,
    e.city
FROM 
    Employee e
    INNER JOIN Employment emp ON e.employee_id = emp.employee_id
    INNER JOIN Company c ON emp.company_id = c.company_id
WHERE 
    c.company_name = 'First Bank Corporation'
    AND emp.salary > 100000
    AND emp.is_active = 1;",
            ColumnHeaders = new List<string> { "Employee Name", "Street Address", "City" },
            ExecutionTime = 23,
            Status = "Success"
        };

        // Add sample result rows
        result.Rows.Add(new QueryResultRow { Values = new List<string> { "John Smith", "123 Main St", "New York" } });
        result.Rows.Add(new QueryResultRow { Values = new List<string> { "Sarah Johnson", "456 Oak Ave", "Boston" } });
        result.Rows.Add(new QueryResultRow { Values = new List<string> { "David Davis", "654 Maple Ln", "Seattle" } });
        
        result.RowCount = result.Rows.Count;
        return result;
    }

    private SampleDataset GetSampleDataset()
    {
        var dataset = new SampleDataset();
        
        // Add employees
        dataset.Employees.Add(new Employee { EmployeeId = 1, FirstName = "John", LastName = "Smith", StreetAddress = "123 Main St", City = "New York", State = "NY", ZipCode = "10001", HireDate = new DateTime(2020, 1, 15) });
        dataset.Employees.Add(new Employee { EmployeeId = 2, FirstName = "Sarah", LastName = "Johnson", StreetAddress = "456 Oak Ave", City = "Boston", State = "MA", ZipCode = "02134", HireDate = new DateTime(2019, 6, 20) });
        dataset.Employees.Add(new Employee { EmployeeId = 3, FirstName = "Michael", LastName = "Williams", StreetAddress = "789 Elm Dr", City = "Chicago", State = "IL", ZipCode = "60601", HireDate = new DateTime(2021, 3, 10) });
        dataset.Employees.Add(new Employee { EmployeeId = 4, FirstName = "Emily", LastName = "Brown", StreetAddress = "321 Pine St", City = "San Francisco", State = "CA", ZipCode = "94105", HireDate = new DateTime(2022, 1, 5) });
        dataset.Employees.Add(new Employee { EmployeeId = 5, FirstName = "David", LastName = "Davis", StreetAddress = "654 Maple Ln", City = "Seattle", State = "WA", ZipCode = "98101", HireDate = new DateTime(2020, 8, 12) });
        
        // Add companies
        dataset.Companies.Add(new Company { CompanyId = 1, CompanyName = "First Bank Corporation", Industry = "Financial Services", HeadquartersCity = "New York", FoundedYear = 1985 });
        dataset.Companies.Add(new Company { CompanyId = 2, CompanyName = "Tech Innovations Inc", Industry = "Technology", HeadquartersCity = "San Francisco", FoundedYear = 2010 });
        dataset.Companies.Add(new Company { CompanyId = 3, CompanyName = "Global Retail Corp", Industry = "Retail", HeadquartersCity = "Chicago", FoundedYear = 1995 });
        
        // Add employments
        dataset.Employments.Add(new Employment { EmploymentId = 1, EmployeeId = 1, CompanyId = 1, Position = "Senior Developer", Salary = 120000, StartDate = new DateTime(2020, 1, 15), IsActive = true });
        dataset.Employments.Add(new Employment { EmploymentId = 2, EmployeeId = 2, CompanyId = 1, Position = "Project Manager", Salary = 130000, StartDate = new DateTime(2019, 6, 20), IsActive = true });
        dataset.Employments.Add(new Employment { EmploymentId = 3, EmployeeId = 3, CompanyId = 2, Position = "Data Analyst", Salary = 95000, StartDate = new DateTime(2021, 3, 10), IsActive = true });
        dataset.Employments.Add(new Employment { EmploymentId = 4, EmployeeId = 4, CompanyId = 1, Position = "Junior Developer", Salary = 85000, StartDate = new DateTime(2022, 1, 5), IsActive = true });
        dataset.Employments.Add(new Employment { EmploymentId = 5, EmployeeId = 5, CompanyId = 1, Position = "Database Administrator", Salary = 110000, StartDate = new DateTime(2020, 8, 12), IsActive = true });
        
        dataset.TotalEmployees = dataset.Employees.Count;
        dataset.TotalCompanies = dataset.Companies.Count;
        dataset.ActiveEmployments = dataset.Employments.Count(e => e.IsActive);
        
        return dataset;
    }

    private SqlExplanation GetSqlExplanation()
    {
        return new SqlExplanation
        {
            Steps = new List<ExplanationStep>
            {
                new ExplanationStep
                {
                    StepNumber = 1,
                    Title = "Understanding the Tables",
                    Explanation = "We have three tables involved in this query: Employee (personal info), Employment (job details), and Company (employer info). Each table serves a specific purpose in our normalized database design.",
                    SqlSnippet = "FROM Employee e\n    INNER JOIN Employment emp ON e.employee_id = emp.employee_id\n    INNER JOIN Company c ON emp.company_id = c.company_id",
                    KeyPoints = new List<string>
                    {
                        "Employee table contains personal information",
                        "Employment table acts as a junction table with salary info",
                        "Company table stores employer details"
                    }
                },
                new ExplanationStep
                {
                    StepNumber = 2,
                    Title = "JOIN Operations",
                    Explanation = "We use INNER JOINs to connect the tables. This ensures we only get employees who have employment records at companies.",
                    SqlSnippet = "INNER JOIN Employment emp ON e.employee_id = emp.employee_id\nINNER JOIN Company c ON emp.company_id = c.company_id",
                    KeyPoints = new List<string>
                    {
                        "INNER JOIN returns only matching records from both tables",
                        "First JOIN connects employees to their employment records",
                        "Second JOIN connects employment records to companies"
                    }
                },
                new ExplanationStep
                {
                    StepNumber = 3,
                    Title = "WHERE Clause Filtering",
                    Explanation = "The WHERE clause applies three conditions that must all be true for a record to be included in the results.",
                    SqlSnippet = "WHERE \n    c.company_name = 'First Bank Corporation'\n    AND emp.salary > 100000\n    AND emp.is_active = 1",
                    KeyPoints = new List<string>
                    {
                        "Exact match on company name (case-sensitive in some databases)",
                        "Salary must be greater than (not equal to) $100,000",
                        "Only active employees are included"
                    }
                },
                new ExplanationStep
                {
                    StepNumber = 4,
                    Title = "SELECT Clause",
                    Explanation = "The SELECT clause determines what columns appear in our result set. We concatenate names and select address fields.",
                    SqlSnippet = "SELECT \n    e.first_name + ' ' + e.last_name AS employee_name,\n    e.street_address,\n    e.city",
                    KeyPoints = new List<string>
                    {
                        "Concatenation creates full name from first and last names",
                        "AS creates an alias for the calculated column",
                        "Only requested fields are returned (not SELECT *)"
                    }
                }
            },
            KeyConcepts = new List<KeyConcept>
            {
                new KeyConcept { Name = "INNER JOIN", Description = "Returns rows when there is a match in both tables" },
                new KeyConcept { Name = "Table Aliases", Description = "Short names (e, emp, c) make queries more readable" },
                new KeyConcept { Name = "String Concatenation", Description = "Combines multiple columns into one result column" },
                new KeyConcept { Name = "Boolean Logic", Description = "AND requires all conditions to be true" },
                new KeyConcept { Name = "Normalization", Description = "Data is split across tables to reduce redundancy" }
            }
        };
    }
}