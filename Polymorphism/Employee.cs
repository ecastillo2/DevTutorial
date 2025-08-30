namespace Polymorphism;

/// <summary>
/// Employee hierarchy demonstrates polymorphism in a business context
/// Shows how polymorphism enables different calculations and behaviors
/// for different employee types while treating them uniformly
/// </summary>
public abstract class Employee
{
    /// <summary>
    /// Common properties for all employees
    /// </summary>
    public string EmployeeId { get; protected set; }
    public string Name { get; protected set; }
    public string Department { get; protected set; }
    public DateTime HireDate { get; protected set; }

    /// <summary>
    /// Constructor for base Employee class
    /// </summary>
    protected Employee(string employeeId, string name, string department)
    {
        EmployeeId = employeeId;
        Name = name;
        Department = department;
        HireDate = DateTime.Now;
    }

    /// <summary>
    /// ABSTRACT METHOD - CalculateSalary
    /// 
    /// Each employee type MUST implement this differently
    /// This enforces polymorphism - no default implementation
    /// Perfect for cases where each derived class has unique logic
    /// </summary>
    public abstract decimal CalculateSalary();

    /// <summary>
    /// ABSTRACT METHOD - GetEmployeeType
    /// Forces each derived class to identify its type
    /// </summary>
    public abstract string GetEmployeeType();

    /// <summary>
    /// VIRTUAL METHOD - GetBenefits
    /// Provides default implementation that can be overridden
    /// </summary>
    public virtual string GetBenefits()
    {
        return "Standard health insurance, 15 days PTO";
    }

    /// <summary>
    /// VIRTUAL METHOD - CalculateBonus
    /// Default bonus calculation that can be customized
    /// </summary>
    public virtual decimal CalculateBonus()
    {
        return CalculateSalary() * 0.05m; // 5% default bonus
    }

    /// <summary>
    /// NON-VIRTUAL METHOD - DisplayInfo
    /// Uses polymorphic methods internally
    /// Shows how polymorphism enables code reuse
    /// </summary>
    public void DisplayInfo()
    {
        Console.WriteLine($"Employee: {Name} ({EmployeeId})");
        Console.WriteLine($"Type: {GetEmployeeType()}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Salary: ${CalculateSalary():F2}");
        Console.WriteLine($"Bonus: ${CalculateBonus():F2}");
        Console.WriteLine($"Benefits: {GetBenefits()}");
    }
}

/// <summary>
/// SalariedEmployee - Fixed salary regardless of hours worked
/// </summary>
public class SalariedEmployee : Employee
{
    public decimal AnnualSalary { get; private set; }

    public SalariedEmployee(string employeeId, string name, string department, decimal annualSalary) 
        : base(employeeId, name, department)
    {
        AnnualSalary = annualSalary;
    }

    /// <summary>
    /// OVERRIDE - CalculateSalary
    /// Simple calculation for salaried employees
    /// </summary>
    public override decimal CalculateSalary()
    {
        return AnnualSalary / 12; // Monthly salary
    }

    /// <summary>
    /// OVERRIDE - GetEmployeeType
    /// </summary>
    public override string GetEmployeeType()
    {
        return "Salaried Employee";
    }

    /// <summary>
    /// OVERRIDE - GetBenefits
    /// Salaried employees get enhanced benefits
    /// </summary>
    public override string GetBenefits()
    {
        return base.GetBenefits() + ", Stock options, 401k matching";
    }
}

/// <summary>
/// HourlyEmployee - Paid based on hours worked
/// </summary>
public class HourlyEmployee : Employee
{
    public decimal HourlyRate { get; private set; }
    public int HoursWorked { get; set; }

    public HourlyEmployee(string employeeId, string name, string department, decimal hourlyRate) 
        : base(employeeId, name, department)
    {
        HourlyRate = hourlyRate;
        HoursWorked = 0;
    }

    /// <summary>
    /// OVERRIDE - CalculateSalary
    /// Different calculation based on hours worked
    /// </summary>
    public override decimal CalculateSalary()
    {
        decimal regularHours = Math.Min(HoursWorked, 160); // 40 hours/week * 4 weeks
        decimal overtimeHours = Math.Max(0, HoursWorked - 160);
        
        return (regularHours * HourlyRate) + (overtimeHours * HourlyRate * 1.5m);
    }

    /// <summary>
    /// OVERRIDE - GetEmployeeType
    /// </summary>
    public override string GetEmployeeType()
    {
        return "Hourly Employee";
    }

    /// <summary>
    /// OVERRIDE - CalculateBonus
    /// Hourly employees get bonus based on overtime
    /// </summary>
    public override decimal CalculateBonus()
    {
        if (HoursWorked > 180)
            return 500m; // Fixed bonus for high overtime
        return 0m;
    }

    public void LogHours(int hours)
    {
        HoursWorked += hours;
        Console.WriteLine($"{Name} logged {hours} hours. Total: {HoursWorked}");
    }
}

/// <summary>
/// CommissionEmployee - Paid based on sales
/// </summary>
public class CommissionEmployee : Employee
{
    public decimal BaseSalary { get; private set; }
    public decimal CommissionRate { get; private set; }
    public decimal TotalSales { get; set; }

    public CommissionEmployee(string employeeId, string name, string department, 
        decimal baseSalary, decimal commissionRate) 
        : base(employeeId, name, department)
    {
        BaseSalary = baseSalary;
        CommissionRate = commissionRate;
        TotalSales = 0;
    }

    /// <summary>
    /// OVERRIDE - CalculateSalary
    /// Base salary plus commission
    /// </summary>
    public override decimal CalculateSalary()
    {
        return (BaseSalary / 12) + (TotalSales * CommissionRate);
    }

    /// <summary>
    /// OVERRIDE - GetEmployeeType
    /// </summary>
    public override string GetEmployeeType()
    {
        return "Commission Employee";
    }

    /// <summary>
    /// OVERRIDE - CalculateBonus
    /// Bonus based on sales performance
    /// </summary>
    public override decimal CalculateBonus()
    {
        if (TotalSales > 100000)
            return TotalSales * 0.02m; // 2% of sales as bonus
        return base.CalculateBonus();
    }

    /// <summary>
    /// OVERRIDE - GetBenefits
    /// Commission employees get sales incentives
    /// </summary>
    public override string GetBenefits()
    {
        return base.GetBenefits() + ", Company car, Sales incentive trips";
    }

    public void RecordSale(decimal amount)
    {
        TotalSales += amount;
        Console.WriteLine($"{Name} made a sale of ${amount:F2}. Total sales: ${TotalSales:F2}");
    }
}

/// <summary>
/// Manager - Special type of salaried employee with team management
/// Demonstrates multi-level inheritance and polymorphism
/// </summary>
public class Manager : SalariedEmployee
{
    private List<Employee> teamMembers;
    
    public Manager(string employeeId, string name, string department, decimal annualSalary) 
        : base(employeeId, name, department, annualSalary)
    {
        teamMembers = new List<Employee>();
    }

    /// <summary>
    /// OVERRIDE - GetEmployeeType
    /// </summary>
    public override string GetEmployeeType()
    {
        return "Manager";
    }

    /// <summary>
    /// OVERRIDE - CalculateBonus
    /// Managers get bonus based on team performance
    /// </summary>
    public override decimal CalculateBonus()
    {
        decimal baseBonus = base.CalculateBonus();
        decimal teamBonus = teamMembers.Count * 1000; // $1000 per team member
        return baseBonus + teamBonus;
    }

    /// <summary>
    /// OVERRIDE - GetBenefits
    /// Managers get executive benefits
    /// </summary>
    public override string GetBenefits()
    {
        return base.GetBenefits() + ", Executive health plan, 25 days PTO, Company phone";
    }

    /// <summary>
    /// Manager-specific method
    /// Demonstrates polymorphism in action - can manage any type of employee
    /// </summary>
    public void AddTeamMember(Employee employee)
    {
        teamMembers.Add(employee);
        Console.WriteLine($"{employee.Name} added to {Name}'s team");
    }

    /// <summary>
    /// Calculate total team cost using polymorphism
    /// Each employee's salary is calculated differently
    /// </summary>
    public decimal CalculateTeamCost()
    {
        decimal totalCost = CalculateSalary(); // Manager's own salary
        
        foreach (Employee member in teamMembers)
        {
            totalCost += member.CalculateSalary(); // Polymorphic call
        }
        
        return totalCost;
    }
}