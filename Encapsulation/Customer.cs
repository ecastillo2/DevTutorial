namespace Encapsulation;

/// <summary>
/// Customer class demonstrates different aspects of ENCAPSULATION:
/// - Auto-implemented properties with different access modifiers
/// - Computed properties
/// - Private backing fields with public properties
/// - Method encapsulation for business logic
/// 
/// This shows a more modern C# approach to encapsulation
/// </summary>
public class Customer
{
    /// <summary>
    /// PRIVATE FIELDS for sensitive data
    /// These demonstrate traditional encapsulation with backing fields
    /// </summary>
    private string email;
    private int age;
    private readonly List<BankAccount> accounts;
    private decimal creditLimit;

    /// <summary>
    /// AUTO-IMPLEMENTED PROPERTIES with different access levels
    /// Modern C# way of encapsulation
    /// </summary>
    
    /// <summary>
    /// CustomerID - Read-only auto-property
    /// Can only be set in constructor (init)
    /// </summary>
    public string CustomerID { get; }

    /// <summary>
    /// FirstName - Public get, private set
    /// Can be read by anyone but only modified internally
    /// </summary>
    public string FirstName { get; private set; }

    /// <summary>
    /// LastName - Public get, private set
    /// Demonstrates controlled modification
    /// </summary>
    public string LastName { get; private set; }

    /// <summary>
    /// COMPUTED PROPERTY - FullName
    /// Demonstrates encapsulation of logic
    /// No backing field, computed on-the-fly
    /// </summary>
    public string FullName 
    { 
        get { return $"{FirstName} {LastName}"; }
    }

    /// <summary>
    /// Email property with validation
    /// Demonstrates encapsulation of validation logic
    /// </summary>
    public string Email
    {
        get { return email; }
        set
        {
            // Email validation encapsulated in setter
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Email cannot be empty");
            
            if (!value.Contains("@") || !value.Contains("."))
                throw new ArgumentException("Invalid email format");
            
            email = value.ToLower(); // Normalize to lowercase
        }
    }

    /// <summary>
    /// Age property with business rule validation
    /// Demonstrates how encapsulation enforces business rules
    /// </summary>
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 18)
                throw new ArgumentException("Customer must be at least 18 years old");
            if (value > 150)
                throw new ArgumentException("Invalid age");
            age = value;
        }
    }

    /// <summary>
    /// Credit Score - Private set ensures it can only be modified through specific methods
    /// </summary>
    public int CreditScore { get; private set; }

    /// <summary>
    /// VIP Status - Computed based on internal business logic
    /// Demonstrates encapsulation of business rules
    /// </summary>
    public bool IsVIP 
    { 
        get 
        { 
            // Business logic encapsulated in property
            return CreditScore > 750 || GetTotalBalance() > 100000;
        }
    }

    /// <summary>
    /// Constructor encapsulates object initialization
    /// Ensures object is created in valid state
    /// </summary>
    public Customer(string customerId, string firstName, string lastName, string email, int age)
    {
        // Validate and set through properties where applicable
        if (string.IsNullOrWhiteSpace(customerId))
            throw new ArgumentException("Customer ID is required");
        
        CustomerID = customerId;
        FirstName = ValidateName(firstName, "First name");
        LastName = ValidateName(lastName, "Last name");
        Email = email; // Uses property setter for validation
        Age = age; // Uses property setter for validation
        
        // Initialize with default values
        CreditScore = 600; // Default credit score
        creditLimit = 1000m; // Default credit limit
        accounts = new List<BankAccount>();
    }

    /// <summary>
    /// PRIVATE METHOD - Name validation
    /// Internal helper method, hidden from external use
    /// </summary>
    private string ValidateName(string name, string fieldName)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException($"{fieldName} cannot be empty");
        
        if (name.Length < 2 || name.Length > 50)
            throw new ArgumentException($"{fieldName} must be between 2 and 50 characters");
        
        // Capitalize first letter
        return char.ToUpper(name[0]) + name.Substring(1).ToLower();
    }

    /// <summary>
    /// PUBLIC METHOD - Add bank account
    /// Controlled way to modify internal collection
    /// </summary>
    public void AddAccount(BankAccount account)
    {
        if (account == null)
            throw new ArgumentNullException(nameof(account));
        
        // Business rule: Maximum 5 accounts per customer
        if (accounts.Count >= 5)
            throw new InvalidOperationException("Customer cannot have more than 5 accounts");
        
        // Business rule: Account holder name must match customer name
        if (account.AccountHolderName != this.FullName)
            throw new InvalidOperationException("Account holder name must match customer name");
        
        accounts.Add(account);
        
        // Update credit score based on number of accounts
        UpdateCreditScore(10); // Bonus points for new account
    }

    /// <summary>
    /// PUBLIC METHOD - Get accounts
    /// Returns a read-only view of accounts
    /// Prevents external modification of internal collection
    /// </summary>
    public IReadOnlyList<BankAccount> GetAccounts()
    {
        return accounts.AsReadOnly();
    }

    /// <summary>
    /// PUBLIC METHOD - Get total balance across all accounts
    /// Encapsulates calculation logic
    /// </summary>
    public decimal GetTotalBalance()
    {
        decimal total = 0;
        foreach (var account in accounts)
        {
            total += account.Balance;
        }
        return total;
    }

    /// <summary>
    /// PUBLIC METHOD - Update credit score
    /// Controlled way to modify credit score with validation
    /// </summary>
    public void UpdateCreditScore(int change)
    {
        int newScore = CreditScore + change;
        
        // Ensure credit score stays within valid range
        if (newScore < 300)
            CreditScore = 300;
        else if (newScore > 850)
            CreditScore = 850;
        else
            CreditScore = newScore;
        
        // Update credit limit based on new score
        UpdateCreditLimit();
    }

    /// <summary>
    /// PRIVATE METHOD - Update credit limit
    /// Internal business logic, hidden from external access
    /// </summary>
    private void UpdateCreditLimit()
    {
        // Credit limit calculation based on credit score
        if (CreditScore >= 800)
            creditLimit = 50000m;
        else if (CreditScore >= 700)
            creditLimit = 25000m;
        else if (CreditScore >= 600)
            creditLimit = 10000m;
        else
            creditLimit = 1000m;
    }

    /// <summary>
    /// PUBLIC METHOD - Get credit limit
    /// Read-only access to credit limit
    /// </summary>
    public decimal GetCreditLimit()
    {
        return creditLimit;
    }

    /// <summary>
    /// PUBLIC METHOD - Get customer info
    /// Provides formatted view of customer data
    /// Encapsulates presentation logic
    /// </summary>
    public string GetCustomerInfo()
    {
        return $"Customer ID: {CustomerID}\n" +
               $"Name: {FullName}\n" +
               $"Email: {Email}\n" +
               $"Age: {Age}\n" +
               $"Credit Score: {CreditScore}\n" +
               $"Credit Limit: ${creditLimit:F2}\n" +
               $"VIP Status: {(IsVIP ? "Yes" : "No")}\n" +
               $"Total Balance: ${GetTotalBalance():F2}\n" +
               $"Number of Accounts: {accounts.Count}";
    }

    /// <summary>
    /// PRIVATE METHOD - Log activity
    /// Internal method for audit trail
    /// Demonstrates that not all methods need to be public
    /// </summary>
    private void LogActivity(string activity)
    {
        // In real application, this would write to a log file or database
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Console.WriteLine($"[{timestamp}] Customer {CustomerID}: {activity}");
    }
}