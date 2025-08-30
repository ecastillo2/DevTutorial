namespace LiskovSubstitution.GoodExamples;

/// <summary>
/// GOOD EXAMPLE - Shape hierarchy following LSP
/// 
/// Uses composition and proper abstraction instead of problematic inheritance
/// Rectangle and Square are separate types, not parent-child
/// </summary>
public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

/// <summary>
/// Rectangle as its own type
/// </summary>
public class Rectangle : IShape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        if (width <= 0 || height <= 0)
            throw new ArgumentException("Width and height must be positive");
        
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}

/// <summary>
/// Square as its own type - not derived from Rectangle
/// </summary>
public class Square : IShape
{
    public double Side { get; }

    public Square(double side)
    {
        if (side <= 0)
            throw new ArgumentException("Side must be positive");
        
        Side = side;
    }

    public double CalculateArea()
    {
        return Side * Side;
    }

    public double CalculatePerimeter()
    {
        return 4 * Side;
    }
}

/// <summary>
/// GOOD EXAMPLE - Bird hierarchy following LSP
/// 
/// Separates flying behavior from bird identity
/// </summary>
public abstract class Bird
{
    public string Name { get; protected set; }

    protected Bird(string name)
    {
        Name = name;
    }

    public abstract void Eat();
    public abstract void Move();
}

/// <summary>
/// Interface for birds that can fly
/// </summary>
public interface IFlyingBird
{
    void Fly();
    double GetFlightSpeed();
}

/// <summary>
/// Interface for birds that can swim
/// </summary>
public interface ISwimmingBird
{
    void Swim();
    double GetSwimSpeed();
}

/// <summary>
/// Eagle - a flying bird
/// </summary>
public class Eagle : Bird, IFlyingBird
{
    public Eagle(string name) : base(name) { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} hunts for prey");
    }

    public override void Move()
    {
        Fly(); // Primary movement is flying
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} soars high in the sky!");
    }

    public double GetFlightSpeed()
    {
        return 160.0; // km/h
    }
}

/// <summary>
/// Penguin - a swimming bird (no flying)
/// </summary>
public class Penguin : Bird, ISwimmingBird
{
    public Penguin(string name) : base(name) { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} catches fish");
    }

    public override void Move()
    {
        Swim(); // Primary movement is swimming
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} swims gracefully underwater!");
    }

    public double GetSwimSpeed()
    {
        return 35.0; // km/h
    }
}

/// <summary>
/// Duck - can both fly and swim
/// </summary>
public class Duck : Bird, IFlyingBird, ISwimmingBird
{
    public Duck(string name) : base(name) { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} eats aquatic plants and insects");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} can fly or swim");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} flies in V-formation!");
    }

    public double GetFlightSpeed()
    {
        return 80.0; // km/h
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} paddles on the water!");
    }

    public double GetSwimSpeed()
    {
        return 10.0; // km/h
    }
}

/// <summary>
/// GOOD EXAMPLE - Storage hierarchy following LSP
/// 
/// Separates read and write capabilities
/// </summary>
public interface IReadableStorage
{
    string Read(string key);
    bool Exists(string key);
}

public interface IWritableStorage
{
    void Write(string key, string content);
    void Delete(string key);
}

/// <summary>
/// Full storage with both read and write
/// </summary>
public class FileStorage : IReadableStorage, IWritableStorage
{
    private readonly Dictionary<string, string> files = new Dictionary<string, string>();

    public string Read(string key)
    {
        if (files.ContainsKey(key))
            return files[key];
        throw new KeyNotFoundException($"File {key} not found");
    }

    public bool Exists(string key)
    {
        return files.ContainsKey(key);
    }

    public void Write(string key, string content)
    {
        files[key] = content;
        Console.WriteLine($"Written file: {key}");
    }

    public void Delete(string key)
    {
        if (files.Remove(key))
            Console.WriteLine($"Deleted file: {key}");
        else
            throw new KeyNotFoundException($"File {key} not found");
    }
}

/// <summary>
/// Read-only storage - only implements IReadableStorage
/// </summary>
public class ReadOnlyStorage : IReadableStorage
{
    private readonly Dictionary<string, string> files = new Dictionary<string, string>();

    public ReadOnlyStorage(Dictionary<string, string> initialFiles)
    {
        files = new Dictionary<string, string>(initialFiles);
    }

    public string Read(string key)
    {
        if (files.ContainsKey(key))
            return files[key];
        throw new KeyNotFoundException($"File {key} not found");
    }

    public bool Exists(string key)
    {
        return files.ContainsKey(key);
    }
}

/// <summary>
/// Cache storage with TTL - fully implements both interfaces
/// </summary>
public class CacheStorage : IReadableStorage, IWritableStorage
{
    private readonly Dictionary<string, (string content, DateTime expiry)> cache = new();
    private readonly TimeSpan ttl;

    public CacheStorage(TimeSpan ttl)
    {
        this.ttl = ttl;
    }

    public string Read(string key)
    {
        if (cache.TryGetValue(key, out var entry))
        {
            if (entry.expiry > DateTime.Now)
                return entry.content;
            
            cache.Remove(key); // Remove expired entry
        }
        throw new KeyNotFoundException($"Key {key} not found or expired");
    }

    public bool Exists(string key)
    {
        if (cache.TryGetValue(key, out var entry))
        {
            if (entry.expiry > DateTime.Now)
                return true;
            
            cache.Remove(key);
        }
        return false;
    }

    public void Write(string key, string content)
    {
        cache[key] = (content, DateTime.Now.Add(ttl));
        Console.WriteLine($"Cached {key} with TTL {ttl}");
    }

    public void Delete(string key)
    {
        if (cache.Remove(key))
            Console.WriteLine($"Removed {key} from cache");
    }
}

/// <summary>
/// GOOD EXAMPLE - Employee hierarchy following LSP
/// 
/// Uses composition for different employee capabilities
/// </summary>
public abstract class Employee
{
    public string Name { get; }
    public string EmployeeId { get; }

    protected Employee(string name, string employeeId)
    {
        Name = name;
        EmployeeId = employeeId;
    }

    public abstract void PerformDuties();
    public abstract string GetEmployeeType();
}

/// <summary>
/// Interface for employees who receive salary
/// </summary>
public interface ISalariedEmployee
{
    decimal GetMonthlySalary();
}

/// <summary>
/// Interface for employees eligible for bonuses
/// </summary>
public interface IBonusEligible
{
    decimal CalculateBonus();
}

/// <summary>
/// Interface for employees with hourly rates
/// </summary>
public interface IHourlyEmployee
{
    decimal GetHourlyRate();
    decimal CalculatePay(double hoursWorked);
}

/// <summary>
/// Full-time employee - salaried with bonus
/// </summary>
public class FullTimeEmployee : Employee, ISalariedEmployee, IBonusEligible
{
    private readonly decimal monthlySalary;
    private readonly decimal bonusPercentage;

    public FullTimeEmployee(string name, string employeeId, decimal monthlySalary, decimal bonusPercentage)
        : base(name, employeeId)
    {
        this.monthlySalary = monthlySalary;
        this.bonusPercentage = bonusPercentage;
    }

    public override void PerformDuties()
    {
        Console.WriteLine($"{Name} performs full-time duties");
    }

    public override string GetEmployeeType()
    {
        return "Full-Time Employee";
    }

    public decimal GetMonthlySalary()
    {
        return monthlySalary;
    }

    public decimal CalculateBonus()
    {
        return monthlySalary * bonusPercentage;
    }
}

/// <summary>
/// Contractor - hourly rate, no bonus
/// </summary>
public class Contractor : Employee, IHourlyEmployee
{
    private readonly decimal hourlyRate;

    public Contractor(string name, string employeeId, decimal hourlyRate)
        : base(name, employeeId)
    {
        this.hourlyRate = hourlyRate;
    }

    public override void PerformDuties()
    {
        Console.WriteLine($"{Name} performs contract work");
    }

    public override string GetEmployeeType()
    {
        return "Contractor";
    }

    public decimal GetHourlyRate()
    {
        return hourlyRate;
    }

    public decimal CalculatePay(double hoursWorked)
    {
        if (hoursWorked > 40)
        {
            // Overtime pay for contractors
            var regularPay = 40 * hourlyRate;
            var overtimePay = (decimal)(hoursWorked - 40) * hourlyRate * 1.5m;
            return regularPay + overtimePay;
        }
        return (decimal)hoursWorked * hourlyRate;
    }
}

/// <summary>
/// Volunteer - no monetary compensation
/// </summary>
public class Volunteer : Employee
{
    public Volunteer(string name, string employeeId)
        : base(name, employeeId)
    {
    }

    public override void PerformDuties()
    {
        Console.WriteLine($"{Name} volunteers their time");
    }

    public override string GetEmployeeType()
    {
        return "Volunteer";
    }
}

/// <summary>
/// GOOD EXAMPLE - Account hierarchy following LSP
/// 
/// Different account types with compatible behaviors
/// </summary>
public interface IAccount
{
    string AccountNumber { get; }
    decimal GetBalance();
    string GetAccountType();
}

/// <summary>
/// Interface for accounts that accept deposits
/// </summary>
public interface IDepositAccount
{
    void Deposit(decimal amount);
}

/// <summary>
/// Interface for accounts that allow withdrawals
/// </summary>
public interface IWithdrawableAccount
{
    void Withdraw(decimal amount);
    bool CanWithdraw(decimal amount);
}

/// <summary>
/// Regular savings account - supports both deposit and withdrawal
/// </summary>
public class SavingsAccount : IAccount, IDepositAccount, IWithdrawableAccount
{
    private decimal balance;
    
    public string AccountNumber { get; }

    public SavingsAccount(string accountNumber, decimal initialBalance = 0)
    {
        AccountNumber = accountNumber;
        balance = initialBalance;
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public string GetAccountType()
    {
        return "Savings Account";
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive");
        
        balance += amount;
        Console.WriteLine($"Deposited ${amount} to savings. Balance: ${balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (!CanWithdraw(amount))
            throw new InvalidOperationException("Insufficient funds");
        
        balance -= amount;
        Console.WriteLine($"Withdrew ${amount} from savings. Balance: ${balance}");
    }

    public bool CanWithdraw(decimal amount)
    {
        return amount > 0 && amount <= balance;
    }
}

/// <summary>
/// Fixed deposit - can deposit, but withdrawal has conditions
/// </summary>
public class FixedDepositAccount : IAccount, IDepositAccount, IWithdrawableAccount
{
    private decimal balance;
    private readonly DateTime maturityDate;
    private readonly decimal penaltyRate = 0.10m; // 10% penalty
    
    public string AccountNumber { get; }

    public FixedDepositAccount(string accountNumber, DateTime maturityDate)
    {
        AccountNumber = accountNumber;
        this.maturityDate = maturityDate;
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public string GetAccountType()
    {
        return "Fixed Deposit Account";
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive");
        
        balance += amount;
        Console.WriteLine($"Deposited ${amount} to fixed deposit. Balance: ${balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (!CanWithdraw(amount))
            throw new InvalidOperationException("Cannot withdraw this amount");
        
        if (DateTime.Now < maturityDate)
        {
            var penalty = amount * penaltyRate;
            var actualAmount = amount - penalty;
            balance -= amount;
            Console.WriteLine($"Early withdrawal of ${amount} with penalty ${penalty}. Received: ${actualAmount}");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Withdrew ${amount} from matured fixed deposit. Balance: ${balance}");
        }
    }

    public bool CanWithdraw(decimal amount)
    {
        return amount > 0 && amount <= balance;
    }
}

/// <summary>
/// Loan account - represents debt, supports payments but not withdrawals
/// </summary>
public class LoanAccount : IAccount, IDepositAccount
{
    private decimal outstandingAmount;
    
    public string AccountNumber { get; }

    public LoanAccount(string accountNumber, decimal loanAmount)
    {
        AccountNumber = accountNumber;
        outstandingAmount = loanAmount;
    }

    public decimal GetBalance()
    {
        return -outstandingAmount; // Negative balance indicates debt
    }

    public string GetAccountType()
    {
        return "Loan Account";
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Payment amount must be positive");
        
        outstandingAmount -= amount;
        Console.WriteLine($"Paid ${amount} towards loan. Outstanding: ${outstandingAmount}");
    }
}