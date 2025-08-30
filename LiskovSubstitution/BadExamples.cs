namespace LiskovSubstitution.BadExamples;

/// <summary>
/// BAD EXAMPLE - Rectangle/Square violating Liskov Substitution Principle
/// 
/// The classic example of LSP violation. Square changes the behavior
/// of Rectangle in ways that break expectations.
/// 
/// PROBLEMS:
/// - Square changes behavior of setters
/// - Violates expected invariants of Rectangle
/// - Code using Rectangle may break with Square
/// - Substitution is not transparent
/// </summary>
public class Rectangle_Bad
{
    /// <summary>
    /// Virtual properties allow overriding - but this leads to LSP violation
    /// </summary>
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public int CalculateArea()
    {
        return Width * Height;
    }
}

/// <summary>
/// VIOLATION: Square changes the behavior of Rectangle's properties
/// This breaks the substitution principle
/// </summary>
public class Square_Bad : Rectangle_Bad
{
    /// <summary>
    /// PROBLEM: Overrides setter to maintain square invariant
    /// This changes the expected behavior of Rectangle
    /// </summary>
    public override int Width
    {
        get => base.Width;
        set
        {
            base.Width = value;
            base.Height = value; // Forces height to match!
        }
    }

    public override int Height
    {
        get => base.Height;
        set
        {
            base.Height = value;
            base.Width = value; // Forces width to match!
        }
    }
}

/// <summary>
/// BAD EXAMPLE - Bird hierarchy violating LSP
/// 
/// Not all birds can fly, but the base class assumes they can
/// </summary>
public class Bird_Bad
{
    public string Name { get; set; } = "";

    /// <summary>
    /// PROBLEM: Assumes all birds can fly
    /// </summary>
    public virtual void Fly()
    {
        Console.WriteLine($"{Name} is flying high in the sky!");
    }

    public virtual void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}

/// <summary>
/// VIOLATION: Penguin can't fly but inherits from Bird
/// </summary>
public class Penguin_Bad : Bird_Bad
{
    /// <summary>
    /// PROBLEM: Throws exception instead of flying
    /// This violates LSP - code expecting any Bird to fly will break
    /// </summary>
    public override void Fly()
    {
        throw new NotSupportedException("Penguins cannot fly!");
    }
}

/// <summary>
/// Another LSP violation - Ostrich
/// </summary>
public class Ostrich_Bad : Bird_Bad
{
    /// <summary>
    /// PROBLEM: Changes behavior completely
    /// </summary>
    public override void Fly()
    {
        Console.WriteLine($"{Name} cannot fly, but runs fast instead!");
        // Not flying - violates expectation
    }
}

/// <summary>
/// BAD EXAMPLE - FileStorage violating LSP
/// 
/// ReadOnlyFileStorage changes fundamental behavior
/// </summary>
public class FileStorage_Bad
{
    protected Dictionary<string, string> files = new Dictionary<string, string>();

    public virtual void Save(string filename, string content)
    {
        files[filename] = content;
        Console.WriteLine($"Saved file: {filename}");
    }

    public virtual string Read(string filename)
    {
        if (files.ContainsKey(filename))
            return files[filename];
        throw new FileNotFoundException($"File {filename} not found");
    }

    public virtual void Delete(string filename)
    {
        if (files.Remove(filename))
            Console.WriteLine($"Deleted file: {filename}");
        else
            throw new FileNotFoundException($"File {filename} not found");
    }
}

/// <summary>
/// VIOLATION: ReadOnlyFileStorage breaks write operations
/// </summary>
public class ReadOnlyFileStorage_Bad : FileStorage_Bad
{
    /// <summary>
    /// PROBLEM: Throws exception instead of saving
    /// </summary>
    public override void Save(string filename, string content)
    {
        throw new InvalidOperationException("Cannot save to read-only storage!");
    }

    /// <summary>
    /// PROBLEM: Throws exception instead of deleting
    /// </summary>
    public override void Delete(string filename)
    {
        throw new InvalidOperationException("Cannot delete from read-only storage!");
    }
}

/// <summary>
/// BAD EXAMPLE - Employee hierarchy violating LSP
/// 
/// Different employee types have incompatible behaviors
/// </summary>
public abstract class Employee_Bad
{
    public string Name { get; set; } = "";
    public decimal BaseSalary { get; set; }

    /// <summary>
    /// PROBLEM: Not all employees get bonuses
    /// </summary>
    public abstract decimal CalculateBonus();
    
    /// <summary>
    /// PROBLEM: Not all employees have same work hours
    /// </summary>
    public abstract void Work(int hours);
}

/// <summary>
/// Regular employee implementation
/// </summary>
public class RegularEmployee_Bad : Employee_Bad
{
    public override decimal CalculateBonus()
    {
        return BaseSalary * 0.10m; // 10% bonus
    }

    public override void Work(int hours)
    {
        if (hours > 8)
        {
            Console.WriteLine($"{Name} worked {hours} hours (including {hours - 8} overtime hours)");
        }
        else
        {
            Console.WriteLine($"{Name} worked {hours} regular hours");
        }
    }
}

/// <summary>
/// VIOLATION: Contractor doesn't get bonuses and has different work rules
/// </summary>
public class Contractor_Bad : Employee_Bad
{
    /// <summary>
    /// PROBLEM: Returns 0 instead of actual bonus
    /// </summary>
    public override decimal CalculateBonus()
    {
        return 0; // Contractors don't get bonuses - misleading!
    }

    /// <summary>
    /// PROBLEM: Different work hour constraints
    /// </summary>
    public override void Work(int hours)
    {
        if (hours > 40)
        {
            throw new InvalidOperationException("Contractors cannot work more than 40 hours per week!");
        }
        Console.WriteLine($"{Name} worked {hours} contract hours");
    }
}

/// <summary>
/// VIOLATION: Volunteer has completely different compensation model
/// </summary>
public class Volunteer_Bad : Employee_Bad
{
    public override decimal CalculateBonus()
    {
        throw new NotSupportedException("Volunteers don't receive monetary bonuses!");
    }

    public override void Work(int hours)
    {
        Console.WriteLine($"{Name} volunteered for {hours} hours");
        // No pay calculation - different from other employees
    }
}

/// <summary>
/// BAD EXAMPLE - Account hierarchy violating LSP
/// 
/// Different account types have incompatible withdrawal rules
/// </summary>
public class BankAccount_Bad
{
    public string AccountNumber { get; set; } = "";
    protected decimal balance;

    public decimal Balance => balance;

    public virtual void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive");
        
        balance += amount;
        Console.WriteLine($"Deposited ${amount}. New balance: ${balance}");
    }

    /// <summary>
    /// PROBLEM: Not all accounts allow withdrawals
    /// </summary>
    public virtual void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive");
        
        if (amount > balance)
            throw new InvalidOperationException("Insufficient funds");
        
        balance -= amount;
        Console.WriteLine($"Withdrew ${amount}. New balance: ${balance}");
    }
}

/// <summary>
/// VIOLATION: FixedDepositAccount doesn't allow withdrawals before maturity
/// </summary>
public class FixedDepositAccount_Bad : BankAccount_Bad
{
    private DateTime maturityDate;

    public FixedDepositAccount_Bad(DateTime maturityDate)
    {
        this.maturityDate = maturityDate;
    }

    /// <summary>
    /// PROBLEM: Changes withdrawal behavior based on date
    /// </summary>
    public override void Withdraw(decimal amount)
    {
        if (DateTime.Now < maturityDate)
        {
            throw new InvalidOperationException($"Cannot withdraw before maturity date: {maturityDate:yyyy-MM-dd}");
        }
        
        base.Withdraw(amount);
    }
}

/// <summary>
/// VIOLATION: LoanAccount has negative balance and different rules
/// </summary>
public class LoanAccount_Bad : BankAccount_Bad
{
    public LoanAccount_Bad(decimal loanAmount)
    {
        balance = -loanAmount; // Negative balance!
    }

    /// <summary>
    /// PROBLEM: Withdraw increases debt instead of decreasing balance
    /// </summary>
    public override void Withdraw(decimal amount)
    {
        // In loan account, withdrawal increases debt
        balance -= amount;
        Console.WriteLine($"Borrowed additional ${amount}. Total debt: ${-balance}");
    }

    /// <summary>
    /// Deposit reduces debt
    /// </summary>
    public override void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"Paid ${amount} towards loan. Remaining debt: ${-balance}");
    }
}