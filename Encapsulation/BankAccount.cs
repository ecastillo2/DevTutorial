namespace Encapsulation;

/// <summary>
/// BankAccount class demonstrates ENCAPSULATION principles:
/// 
/// ENCAPSULATION is the bundling of data and methods that work on that data within a single unit (class),
/// and restricting direct access to some of the object's components.
/// 
/// Key Principles:
/// 1. DATA HIDING: Internal state is private and hidden from outside access
/// 2. CONTROLLED ACCESS: Public methods provide controlled ways to interact with the data
/// 3. VALIDATION: Methods can validate data before modifying internal state
/// 4. MAINTAINING INVARIANTS: The class ensures its data remains in a valid state
/// 
/// Benefits:
/// - Security: Sensitive data is hidden from external access
/// - Flexibility: Internal implementation can change without affecting external code
/// - Maintainability: Easier to maintain and modify code
/// - Control: Complete control over how data is accessed and modified
/// </summary>
public class BankAccount
{
    /// <summary>
    /// PRIVATE FIELDS - The heart of encapsulation
    /// These fields are completely hidden from outside access.
    /// No external code can directly read or modify these values.
    /// This is DATA HIDING in action.
    /// </summary>
    private string accountNumber;
    private decimal balance;
    private string accountHolderName;
    private readonly List<string> transactionHistory;
    private readonly DateTime accountCreatedDate;
    private const decimal MinimumBalance = 10.00m;

    /// <summary>
    /// PUBLIC PROPERTIES with different access levels demonstrate encapsulation:
    /// - Some are read-only (only get)
    /// - Some have private setters
    /// - Some have validation logic
    /// This provides CONTROLLED ACCESS to internal data
    /// </summary>
    
    /// <summary>
    /// Account Number - Read-only property
    /// Once set in constructor, it cannot be changed (immutability)
    /// </summary>
    public string AccountNumber 
    { 
        get { return accountNumber; }
        private set 
        { 
            // Validation in setter - ensures account number format
            if (string.IsNullOrWhiteSpace(value) || value.Length != 10)
                throw new ArgumentException("Account number must be 10 characters");
            accountNumber = value;
        }
    }

    /// <summary>
    /// Balance - Read-only property for external code
    /// Can only be modified through Deposit/Withdraw methods
    /// This ensures balance changes are tracked and validated
    /// </summary>
    public decimal Balance 
    { 
        get { return balance; }
        private set { balance = value; }
    }

    /// <summary>
    /// Account Holder Name - Demonstrates property with validation
    /// Even though it has a public setter, it validates the input
    /// </summary>
    public string AccountHolderName 
    { 
        get { return accountHolderName; }
        set 
        {
            // Validation logic encapsulated within the property
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Account holder name cannot be empty");
            if (value.Length < 2 || value.Length > 100)
                throw new ArgumentException("Name must be between 2 and 100 characters");
            accountHolderName = value;
        }
    }

    /// <summary>
    /// Read-only property - provides controlled access to creation date
    /// No setter at all - true immutability
    /// </summary>
    public DateTime AccountCreatedDate 
    { 
        get { return accountCreatedDate; }
    }

    /// <summary>
    /// Constructor - The gatekeeper for object creation
    /// Ensures the object is created in a valid state
    /// Encapsulates initialization logic
    /// </summary>
    public BankAccount(string accountNumber, string accountHolderName, decimal initialDeposit)
    {
        // All validation happens here, ensuring object is never in invalid state
        if (initialDeposit < MinimumBalance)
            throw new ArgumentException($"Initial deposit must be at least ${MinimumBalance}");

        // Using property setters for validation
        this.AccountNumber = accountNumber;
        this.AccountHolderName = accountHolderName;
        this.balance = initialDeposit;
        this.accountCreatedDate = DateTime.Now;
        this.transactionHistory = new List<string>();
        
        AddToTransactionHistory($"Account created with initial deposit: ${initialDeposit:F2}");
    }

    /// <summary>
    /// PUBLIC METHOD - Deposit
    /// This is the ONLY way to add money to the account
    /// Encapsulates business logic and validation
    /// </summary>
    public void Deposit(decimal amount)
    {
        // Validation logic is encapsulated within the method
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive");
        
        if (amount > 1000000)
            throw new ArgumentException("Single deposit cannot exceed $1,000,000");

        // State modification is controlled and tracked
        balance += amount;
        AddToTransactionHistory($"Deposited: ${amount:F2}. New balance: ${balance:F2}");
    }

    /// <summary>
    /// PUBLIC METHOD - Withdraw
    /// Controlled way to remove money with business rules
    /// Demonstrates how encapsulation enforces business logic
    /// </summary>
    public void Withdraw(decimal amount)
    {
        // Multiple validation rules encapsulated here
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive");
        
        if (amount > balance - MinimumBalance)
            throw new InvalidOperationException($"Insufficient funds. Must maintain minimum balance of ${MinimumBalance}");
        
        if (amount > 5000)
            throw new InvalidOperationException("Single withdrawal cannot exceed $5,000");

        // Controlled state modification
        balance -= amount;
        AddToTransactionHistory($"Withdrew: ${amount:F2}. New balance: ${balance:F2}");
    }

    /// <summary>
    /// PUBLIC METHOD - Get Transaction History
    /// Returns a COPY of the transaction history, not the actual list
    /// This prevents external code from modifying our internal data
    /// This is DEFENSIVE COPYING - a key encapsulation technique
    /// </summary>
    public List<string> GetTransactionHistory()
    {
        // Return a new list to prevent external modification
        return new List<string>(transactionHistory);
    }

    /// <summary>
    /// PUBLIC METHOD - Get Account Summary
    /// Provides controlled access to multiple pieces of data
    /// Formats and presents data in a specific way
    /// </summary>
    public string GetAccountSummary()
    {
        return $"Account: {AccountNumber}\n" +
               $"Holder: {AccountHolderName}\n" +
               $"Balance: ${Balance:F2}\n" +
               $"Created: {AccountCreatedDate:yyyy-MM-dd}\n" +
               $"Transactions: {transactionHistory.Count}";
    }

    /// <summary>
    /// PRIVATE METHOD - Internal helper method
    /// This method is completely hidden from external code
    /// It's an implementation detail that can be changed without affecting public API
    /// </summary>
    private void AddToTransactionHistory(string transaction)
    {
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        transactionHistory.Add($"[{timestamp}] {transaction}");
        
        // Keep only last 100 transactions (internal business rule)
        if (transactionHistory.Count > 100)
        {
            transactionHistory.RemoveAt(0);
        }
    }

    /// <summary>
    /// PUBLIC METHOD - Transfer money to another account
    /// Demonstrates how encapsulation enables complex operations
    /// while maintaining data integrity
    /// </summary>
    public void TransferTo(BankAccount targetAccount, decimal amount)
    {
        if (targetAccount == null)
            throw new ArgumentNullException(nameof(targetAccount));
        
        if (targetAccount == this)
            throw new InvalidOperationException("Cannot transfer to the same account");

        // The beauty of encapsulation: we use our own public methods
        // This ensures all validation and business rules are applied
        this.Withdraw(amount);  // This will validate the withdrawal
        targetAccount.Deposit(amount);  // This will validate the deposit
        
        // Add transfer record to history
        AddToTransactionHistory($"Transferred ${amount:F2} to account {targetAccount.AccountNumber}");
    }
}