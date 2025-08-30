namespace SqlInterviewWeb.Models;

public class SqlInterviewViewModel
{
    public string Question { get; set; } = @"Find the names, street address, and cities of residence for all employees who work for 'First Bank Corporation' and earn more than $100,000.";
    public DatabaseSchema Schema { get; set; } = new();
    public SqlQuery Query { get; set; } = new();
    public QueryExplanation Explanation { get; set; } = new();
    public List<QueryStep> ExecutionSteps { get; set; } = new();
    public SampleData SampleData { get; set; } = new();
}

public class DatabaseSchema
{
    public List<Table> Tables { get; set; } = new()
    {
        new Table
        {
            Name = "Employee",
            Description = "Stores employee personal and work information",
            Columns = new List<Column>
            {
                new Column { Name = "employee_id", DataType = "INT", IsPrimaryKey = true, Description = "Unique identifier for each employee" },
                new Column { Name = "first_name", DataType = "VARCHAR(50)", IsRequired = true, Description = "Employee's first name" },
                new Column { Name = "last_name", DataType = "VARCHAR(50)", IsRequired = true, Description = "Employee's last name" },
                new Column { Name = "street_address", DataType = "VARCHAR(100)", Description = "Employee's street address" },
                new Column { Name = "city", DataType = "VARCHAR(50)", Description = "Employee's city of residence" },
                new Column { Name = "state", DataType = "VARCHAR(2)", Description = "Employee's state" },
                new Column { Name = "zip_code", DataType = "VARCHAR(10)", Description = "Employee's ZIP code" },
                new Column { Name = "hire_date", DataType = "DATE", Description = "Date when employee was hired" },
                new Column { Name = "department_id", DataType = "INT", IsForeignKey = true, Description = "Reference to department" }
            }
        },
        new Table
        {
            Name = "Employment",
            Description = "Tracks employment details and salary information",
            Columns = new List<Column>
            {
                new Column { Name = "employment_id", DataType = "INT", IsPrimaryKey = true, Description = "Unique employment record ID" },
                new Column { Name = "employee_id", DataType = "INT", IsForeignKey = true, IsRequired = true, Description = "Reference to Employee" },
                new Column { Name = "company_id", DataType = "INT", IsForeignKey = true, IsRequired = true, Description = "Reference to Company" },
                new Column { Name = "position", DataType = "VARCHAR(100)", Description = "Job position/title" },
                new Column { Name = "salary", DataType = "DECIMAL(10,2)", Description = "Annual salary" },
                new Column { Name = "start_date", DataType = "DATE", Description = "Employment start date" },
                new Column { Name = "end_date", DataType = "DATE", Description = "Employment end date (NULL if current)" },
                new Column { Name = "is_active", DataType = "BOOLEAN", Description = "Whether employment is current" }
            }
        },
        new Table
        {
            Name = "Company",
            Description = "Stores company information",
            Columns = new List<Column>
            {
                new Column { Name = "company_id", DataType = "INT", IsPrimaryKey = true, Description = "Unique company identifier" },
                new Column { Name = "company_name", DataType = "VARCHAR(100)", IsRequired = true, Description = "Official company name" },
                new Column { Name = "industry", DataType = "VARCHAR(50)", Description = "Industry sector" },
                new Column { Name = "headquarters_city", DataType = "VARCHAR(50)", Description = "HQ location" },
                new Column { Name = "founded_year", DataType = "INT", Description = "Year company was founded" }
            }
        }
    };

    public List<Relationship> Relationships { get; set; } = new()
    {
        new Relationship 
        { 
            FromTable = "Employment", 
            FromColumn = "employee_id", 
            ToTable = "Employee", 
            ToColumn = "employee_id",
            Type = "Many-to-One",
            Description = "Each employment record belongs to one employee"
        },
        new Relationship 
        { 
            FromTable = "Employment", 
            FromColumn = "company_id", 
            ToTable = "Company", 
            ToColumn = "company_id",
            Type = "Many-to-One",
            Description = "Each employment record is associated with one company"
        }
    };
}

public class Table
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public List<Column> Columns { get; set; } = new();
}

public class Column
{
    public string Name { get; set; } = "";
    public string DataType { get; set; } = "";
    public bool IsPrimaryKey { get; set; }
    public bool IsForeignKey { get; set; }
    public bool IsRequired { get; set; }
    public string Description { get; set; } = "";
}

public class Relationship
{
    public string FromTable { get; set; } = "";
    public string FromColumn { get; set; } = "";
    public string ToTable { get; set; } = "";
    public string ToColumn { get; set; } = "";
    public string Type { get; set; } = "";
    public string Description { get; set; } = "";
}

public class SqlQuery
{
    public string MainQuery { get; set; } = @"SELECT 
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
    AND emp.is_active = 1;";

    public List<string> AlternativeQueries { get; set; } = new()
    {
        @"-- Using CONCAT instead of + for string concatenation (MySQL/PostgreSQL)
SELECT 
    CONCAT(e.first_name, ' ', e.last_name) AS employee_name,
    e.street_address,
    e.city
FROM 
    Employee e
    INNER JOIN Employment emp ON e.employee_id = emp.employee_id
    INNER JOIN Company c ON emp.company_id = c.company_id
WHERE 
    c.company_name = 'First Bank Corporation'
    AND emp.salary > 100000
    AND emp.is_active = TRUE;",

        @"-- Using subquery approach
SELECT 
    first_name + ' ' + last_name AS employee_name,
    street_address,
    city
FROM 
    Employee
WHERE 
    employee_id IN (
        SELECT emp.employee_id
        FROM Employment emp
        INNER JOIN Company c ON emp.company_id = c.company_id
        WHERE c.company_name = 'First Bank Corporation'
        AND emp.salary > 100000
        AND emp.is_active = 1
    );",

        @"-- Using EXISTS clause
SELECT 
    e.first_name + ' ' + e.last_name AS employee_name,
    e.street_address,
    e.city
FROM 
    Employee e
WHERE 
    EXISTS (
        SELECT 1
        FROM Employment emp
        INNER JOIN Company c ON emp.company_id = c.company_id
        WHERE emp.employee_id = e.employee_id
        AND c.company_name = 'First Bank Corporation'
        AND emp.salary > 100000
        AND emp.is_active = 1
    );"
    };
}

public class QueryExplanation
{
    public List<ExplanationPoint> Points { get; set; } = new()
    {
        new ExplanationPoint 
        { 
            Title = "JOIN Strategy",
            Description = "We use INNER JOINs to connect three tables: Employee (personal info), Employment (job details), and Company (employer info).",
            Importance = "Critical",
            Details = new List<string>
            {
                "Employee → Employment: Links via employee_id to get job details",
                "Employment → Company: Links via company_id to identify the employer",
                "INNER JOIN ensures we only get employees with active employment records"
            }
        },
        new ExplanationPoint 
        { 
            Title = "WHERE Clause Conditions",
            Description = "Three conditions filter the results to match our requirements exactly.",
            Importance = "Critical",
            Details = new List<string>
            {
                "c.company_name = 'First Bank Corporation': Filters for specific employer",
                "emp.salary > 100000: Ensures only high earners (note: > not >=)",
                "emp.is_active = 1: Only current employees (important for accurate results)"
            }
        },
        new ExplanationPoint 
        { 
            Title = "SELECT Clause",
            Description = "We retrieve only the requested information: full name, street address, and city.",
            Importance = "High",
            Details = new List<string>
            {
                "Concatenates first_name and last_name with a space",
                "Aliases the result as 'employee_name' for clarity",
                "Directly selects street_address and city from Employee table"
            }
        },
        new ExplanationPoint 
        { 
            Title = "Performance Considerations",
            Description = "Query optimization techniques to ensure fast execution.",
            Importance = "Medium",
            Details = new List<string>
            {
                "Indexes should exist on: employee_id, company_id, company_name, salary",
                "Consider filtered index on Employment where is_active = 1",
                "Company name comparison is case-sensitive in some databases"
            }
        }
    };
}

public class ExplanationPoint
{
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string Importance { get; set; } = "";
    public List<string> Details { get; set; } = new();
}

public class QueryStep
{
    public int StepNumber { get; set; }
    public string Operation { get; set; } = "";
    public string Description { get; set; } = "";
    public string SqlFragment { get; set; } = "";
    public int EstimatedRows { get; set; }
}

public class SampleData
{
    public List<EmployeeData> Employees { get; set; } = new()
    {
        new EmployeeData { EmployeeId = 1, FirstName = "John", LastName = "Smith", StreetAddress = "123 Main St", City = "New York", State = "NY" },
        new EmployeeData { EmployeeId = 2, FirstName = "Sarah", LastName = "Johnson", StreetAddress = "456 Oak Ave", City = "Boston", State = "MA" },
        new EmployeeData { EmployeeId = 3, FirstName = "Michael", LastName = "Williams", StreetAddress = "789 Elm Dr", City = "Chicago", State = "IL" },
        new EmployeeData { EmployeeId = 4, FirstName = "Emily", LastName = "Brown", StreetAddress = "321 Pine St", City = "San Francisco", State = "CA" },
        new EmployeeData { EmployeeId = 5, FirstName = "David", LastName = "Davis", StreetAddress = "654 Maple Ln", City = "Seattle", State = "WA" }
    };

    public List<EmploymentData> Employments { get; set; } = new()
    {
        new EmploymentData { EmploymentId = 1, EmployeeId = 1, CompanyId = 1, Position = "Senior Developer", Salary = 120000, IsActive = true },
        new EmploymentData { EmploymentId = 2, EmployeeId = 2, CompanyId = 1, Position = "Project Manager", Salary = 130000, IsActive = true },
        new EmploymentData { EmploymentId = 3, EmployeeId = 3, CompanyId = 2, Position = "Data Analyst", Salary = 95000, IsActive = true },
        new EmploymentData { EmploymentId = 4, EmployeeId = 4, CompanyId = 1, Position = "Junior Developer", Salary = 85000, IsActive = true },
        new EmploymentData { EmploymentId = 5, EmployeeId = 5, CompanyId = 1, Position = "Database Administrator", Salary = 110000, IsActive = true }
    };

    public List<CompanyData> Companies { get; set; } = new()
    {
        new CompanyData { CompanyId = 1, CompanyName = "First Bank Corporation", Industry = "Financial Services", HeadquartersCity = "New York" },
        new CompanyData { CompanyId = 2, CompanyName = "Tech Innovations Inc", Industry = "Technology", HeadquartersCity = "San Francisco" },
        new CompanyData { CompanyId = 3, CompanyName = "Global Retail Corp", Industry = "Retail", HeadquartersCity = "Chicago" }
    };
}

public class EmployeeData
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string StreetAddress { get; set; } = "";
    public string City { get; set; } = "";
    public string State { get; set; } = "";
}

public class EmploymentData
{
    public int EmploymentId { get; set; }
    public int EmployeeId { get; set; }
    public int CompanyId { get; set; }
    public string Position { get; set; } = "";
    public decimal Salary { get; set; }
    public bool IsActive { get; set; }
}

public class CompanyData
{
    public int CompanyId { get; set; }
    public string CompanyName { get; set; } = "";
    public string Industry { get; set; } = "";
    public string HeadquartersCity { get; set; } = "";
}

// Additional models for views
public class QueryResult
{
    public string SqlQuery { get; set; } = "";
    public List<string> ColumnHeaders { get; set; } = new();
    public List<QueryResultRow> Rows { get; set; } = new();
    public int RowCount { get; set; }
    public int ExecutionTime { get; set; }
    public string Status { get; set; } = "Success";
}

public class QueryResultRow
{
    public List<string> Values { get; set; } = new();
}

public class SampleDataset
{
    public int TotalEmployees { get; set; }
    public int TotalCompanies { get; set; }
    public int ActiveEmployments { get; set; }
    public List<Employee> Employees { get; set; } = new();
    public List<Company> Companies { get; set; } = new();
    public List<Employment> Employments { get; set; } = new();
}

public class Employee
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string StreetAddress { get; set; } = "";
    public string City { get; set; } = "";
    public string State { get; set; } = "";
    public string ZipCode { get; set; } = "";
    public DateTime HireDate { get; set; }
    public int? DepartmentId { get; set; }
}

public class Company
{
    public int CompanyId { get; set; }
    public string CompanyName { get; set; } = "";
    public string Industry { get; set; } = "";
    public string HeadquartersCity { get; set; } = "";
    public int FoundedYear { get; set; }
}

public class Employment
{
    public int EmploymentId { get; set; }
    public int EmployeeId { get; set; }
    public int CompanyId { get; set; }
    public string Position { get; set; } = "";
    public decimal Salary { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool IsActive { get; set; }
}

public class SqlExplanation
{
    public List<ExplanationStep> Steps { get; set; } = new();
    public List<KeyConcept> KeyConcepts { get; set; } = new();
}

public class ExplanationStep
{
    public int StepNumber { get; set; }
    public string Title { get; set; } = "";
    public string Explanation { get; set; } = "";
    public string SqlSnippet { get; set; } = "";
    public List<string> KeyPoints { get; set; } = new();
}

public class KeyConcept
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
}