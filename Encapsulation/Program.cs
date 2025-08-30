using Encapsulation;

Console.WriteLine("╔══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║                    OOP ENCAPSULATION EXAMPLE                     ║");
Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝");
Console.WriteLine();

// Display encapsulation concept diagram
Console.WriteLine("ENCAPSULATION CONCEPT DIAGRAM:");
Console.WriteLine("═══════════════════════════════\n");

Console.WriteLine("┌─────────────────────────────────────────────────────────────┐");
Console.WriteLine("│                      ENCAPSULATION                          │");
Console.WriteLine("│                                                             │");
Console.WriteLine("│   \"Bundling data and methods together while hiding         │");
Console.WriteLine("│    internal details from the outside world\"                │");
Console.WriteLine("└─────────────────────────────────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("          ┌─────────────────────────────────────┐");
Console.WriteLine("          │            CLASS                     │");
Console.WriteLine("          │  ┌─────────────────────────────┐    │");
Console.WriteLine("          │  │     🔒 PRIVATE DATA         │    │");
Console.WriteLine("          │  │   • Hidden from outside     │    │");
Console.WriteLine("          │  │   • Only class can access   │    │");
Console.WriteLine("          │  │   • Implementation details  │    │");
Console.WriteLine("          │  └─────────────────────────────┘    │");
Console.WriteLine("          │                                      │");
Console.WriteLine("          │  ┌─────────────────────────────┐    │");
Console.WriteLine("          │  │     🔓 PUBLIC INTERFACE     │    │");
Console.WriteLine("          │  │   • Methods (behaviors)     │    │");
Console.WriteLine("          │  │   • Properties (controlled) │    │");
Console.WriteLine("          │  │   • Validation & rules      │    │");
Console.WriteLine("          │  └─────────────────────────────┘    │");
Console.WriteLine("          └─────────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("BANK ACCOUNT CLASS - ENCAPSULATION STRUCTURE:");
Console.WriteLine("═════════════════════════════════════════════\n");

Console.WriteLine("┌───────────────────────────────────────────────────────────┐");
Console.WriteLine("│                    BankAccount Class                      │");
Console.WriteLine("├───────────────────────────────────────────────────────────┤");
Console.WriteLine("│  🔒 PRIVATE FIELDS (Hidden Data):                        │");
Console.WriteLine("│    - accountNumber: string                                │");
Console.WriteLine("│    - balance: decimal                                     │");
Console.WriteLine("│    - transactionHistory: List<string>                     │");
Console.WriteLine("│    - MinimumBalance: const decimal                        │");
Console.WriteLine("├───────────────────────────────────────────────────────────┤");
Console.WriteLine("│  🔓 PUBLIC PROPERTIES (Controlled Access):               │");
Console.WriteLine("│    + AccountNumber { get; private set; }                 │");
Console.WriteLine("│    + Balance { get; private set; }                       │");
Console.WriteLine("│    + AccountHolderName { get; set; } // with validation  │");
Console.WriteLine("├───────────────────────────────────────────────────────────┤");
Console.WriteLine("│  🔓 PUBLIC METHODS (Controlled Operations):              │");
Console.WriteLine("│    + Deposit(amount) // validates amount > 0             │");
Console.WriteLine("│    + Withdraw(amount) // checks balance & limits         │");
Console.WriteLine("│    + GetTransactionHistory() // returns copy, not original│");
Console.WriteLine("│    + TransferTo(account, amount) // complex operation    │");
Console.WriteLine("├───────────────────────────────────────────────────────────┤");
Console.WriteLine("│  🔒 PRIVATE METHODS (Internal Logic):                    │");
Console.WriteLine("│    - AddToTransactionHistory(transaction)                │");
Console.WriteLine("│    - ValidateAmount(amount)                              │");
Console.WriteLine("└───────────────────────────────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("KEY ENCAPSULATION PRINCIPLES:");
Console.WriteLine("════════════════════════════\n");

Console.WriteLine("┌─────────────────────────────────────────────────────────────────────┐");
Console.WriteLine("│ 1. DATA HIDING: Private fields cannot be accessed directly         │");
Console.WriteLine("│ 2. CONTROLLED ACCESS: Public methods/properties control data access│");
Console.WriteLine("│ 3. VALIDATION: All data modifications go through validation        │");
Console.WriteLine("│ 4. MAINTAIN INVARIANTS: Object always remains in valid state      │");
Console.WriteLine("│ 5. IMPLEMENTATION FLEXIBILITY: Internal changes don't break code   │");
Console.WriteLine("└─────────────────────────────────────────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("\n══════════════════════════════════════════════════════════════");
Console.WriteLine("                 ENCAPSULATION IN ACTION");
Console.WriteLine("══════════════════════════════════════════════════════════════\n");

try
{
    // DEMONSTRATION 1: Creating objects with validation
    Console.WriteLine("1. CREATING BANK ACCOUNT (Constructor Validation):");
    Console.WriteLine("─────────────────────────────────────────────────");
    
    // This will succeed
    var account1 = new BankAccount("1234567890", "John Doe", 1000m);
    Console.WriteLine("✓ Account created successfully");
    Console.WriteLine(account1.GetAccountSummary());
    
    Console.WriteLine("\nTrying to create account with invalid data:");
    try
    {
        // This will fail - initial deposit too low
        var invalidAccount = new BankAccount("0987654321", "Jane Doe", 5m);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"✗ Failed: {ex.Message}");
    }
    
    // DEMONSTRATION 2: Property Access Control
    Console.WriteLine("\n\n2. PROPERTY ACCESS CONTROL:");
    Console.WriteLine("───────────────────────────");
    
    Console.WriteLine($"Reading account number: {account1.AccountNumber}");
    Console.WriteLine("Trying to modify account number directly...");
    // account1.AccountNumber = "9999999999"; // This would cause compilation error
    Console.WriteLine("✗ Cannot modify - AccountNumber has private setter!");
    
    Console.WriteLine("\nModifying account holder name (with validation):");
    account1.AccountHolderName = "John Smith";
    Console.WriteLine($"✓ Name changed to: {account1.AccountHolderName}");
    
    try
    {
        account1.AccountHolderName = ""; // This will fail
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"✗ Failed to set empty name: {ex.Message}");
    }
    
    // DEMONSTRATION 3: Method-Based Access Control
    Console.WriteLine("\n\n3. CONTROLLED OPERATIONS (Method Encapsulation):");
    Console.WriteLine("────────────────────────────────────────────────");
    
    Console.WriteLine($"Initial balance: ${account1.Balance:F2}");
    
    // Deposit money
    account1.Deposit(500m);
    Console.WriteLine($"After deposit of $500: ${account1.Balance:F2}");
    
    // Try invalid deposit
    try
    {
        account1.Deposit(-100m);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"✗ Invalid deposit rejected: {ex.Message}");
    }
    
    // Withdraw money
    account1.Withdraw(200m);
    Console.WriteLine($"After withdrawal of $200: ${account1.Balance:F2}");
    
    // Try to overdraw
    try
    {
        account1.Withdraw(2000m);
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"✗ Overdraft prevented: {ex.Message}");
    }
    
    // DEMONSTRATION 4: Data Protection
    Console.WriteLine("\n\n4. DATA PROTECTION (Defensive Copying):");
    Console.WriteLine("───────────────────────────────────────");
    
    var history = account1.GetTransactionHistory();
    Console.WriteLine($"Transaction count: {history.Count}");
    Console.WriteLine("Recent transactions:");
    foreach (var transaction in history.Take(5))
    {
        Console.WriteLine($"  • {transaction}");
    }
    
    Console.WriteLine("\nTrying to modify returned history list...");
    history.Clear(); // This clears the copy, not the original!
    Console.WriteLine($"History cleared in local copy: {history.Count} items");
    Console.WriteLine($"Original history intact: {account1.GetTransactionHistory().Count} items");
    
    // DEMONSTRATION 5: Complex Encapsulated Operations
    Console.WriteLine("\n\n5. COMPLEX OPERATIONS WITH ENCAPSULATION:");
    Console.WriteLine("─────────────────────────────────────────");
    
    var account2 = new BankAccount("0987654321", "Jane Smith", 500m);
    Console.WriteLine($"Account 1 balance: ${account1.Balance:F2}");
    Console.WriteLine($"Account 2 balance: ${account2.Balance:F2}");
    
    Console.WriteLine("\nTransferring $100 from Account 1 to Account 2...");
    account1.TransferTo(account2, 100m);
    
    Console.WriteLine($"Account 1 new balance: ${account1.Balance:F2}");
    Console.WriteLine($"Account 2 new balance: ${account2.Balance:F2}");
    
    // DEMONSTRATION 6: Customer Class with Different Encapsulation Patterns
    Console.WriteLine("\n\n6. CUSTOMER CLASS - MODERN ENCAPSULATION:");
    Console.WriteLine("──────────────────────────────────────────");
    
    var customer = new Customer("CUST001", "john", "doe", "john.doe@email.com", 25);
    Console.WriteLine(customer.GetCustomerInfo());
    
    Console.WriteLine("\nAdding bank accounts to customer...");
    // First, update account holder names to match
    account1.AccountHolderName = customer.FullName;
    account2.AccountHolderName = customer.FullName;
    
    customer.AddAccount(account1);
    customer.AddAccount(account2);
    
    Console.WriteLine($"Total balance across all accounts: ${customer.GetTotalBalance():F2}");
    Console.WriteLine($"Number of accounts: {customer.GetAccounts().Count}");
    
    // Update credit score
    Console.WriteLine("\nImproving credit score...");
    customer.UpdateCreditScore(100);
    Console.WriteLine(customer.GetCustomerInfo());
}
catch (Exception ex)
{
    Console.WriteLine($"\nUnexpected error: {ex.Message}");
}

Console.WriteLine("\n\nENCAPSULATION BENEFITS VISUALIZATION:");
Console.WriteLine("═════════════════════════════════════\n");

Console.WriteLine("┌────────────────────────────────────────────────────────────┐");
Console.WriteLine("│                WITHOUT ENCAPSULATION                       │");
Console.WriteLine("├────────────────────────────────────────────────────────────┤");
Console.WriteLine("│  account.balance = -1000;  // 💥 Invalid state!          │");
Console.WriteLine("│  account.accountNumber = \"ABC\";  // 💥 Invalid format!    │");
Console.WriteLine("│  account.transactions.Clear();  // 💥 Lost history!       │");
Console.WriteLine("│                                                            │");
Console.WriteLine("│  Problems:                                                 │");
Console.WriteLine("│  • No validation                                           │");
Console.WriteLine("│  • Direct access to internals                             │");
Console.WriteLine("│  • Easy to break invariants                               │");
Console.WriteLine("│  • No audit trail                                         │");
Console.WriteLine("└────────────────────────────────────────────────────────────┘");
Console.WriteLine();
Console.WriteLine("                         🔽 VS 🔽");
Console.WriteLine();
Console.WriteLine("┌────────────────────────────────────────────────────────────┐");
Console.WriteLine("│                 WITH ENCAPSULATION                         │");
Console.WriteLine("├────────────────────────────────────────────────────────────┤");
Console.WriteLine("│  account.Withdraw(100);  // ✓ Validated                   │");
Console.WriteLine("│  account.AccountNumber;  // ✓ Read-only                   │");
Console.WriteLine("│  account.GetHistory();   // ✓ Returns safe copy           │");
Console.WriteLine("│                                                            │");
Console.WriteLine("│  Benefits:                                                 │");
Console.WriteLine("│  • All changes validated                                   │");
Console.WriteLine("│  • Implementation hidden                                   │");
Console.WriteLine("│  • Invariants maintained                                   │");
Console.WriteLine("│  • Complete audit trail                                    │");
Console.WriteLine("└────────────────────────────────────────────────────────────┘");

Console.WriteLine("\n\n╔══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║           ENCAPSULATION: Your Data's Security Guard! 🛡️          ║");
Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝");