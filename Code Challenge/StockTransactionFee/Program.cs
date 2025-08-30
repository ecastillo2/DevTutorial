namespace StockTransactionFee;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║        BEST TIME TO BUY AND SELL STOCK WITH TRANSACTION FEE          ║");
        Console.WriteLine("║                         Coding Challenge                              ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine();

        Console.WriteLine("PROBLEM DESCRIPTION:");
        Console.WriteLine("════════════════════");
        Console.WriteLine("Given an array 'prices' where prices[i] is the stock price on day i,");
        Console.WriteLine("and an integer 'fee' representing a transaction fee:");
        Console.WriteLine("• Find the maximum profit you can achieve");
        Console.WriteLine("• You can complete as many transactions as you like");
        Console.WriteLine("• You must pay the transaction fee for each transaction");
        Console.WriteLine("• You cannot hold multiple stocks (must sell before buying again)");
        Console.WriteLine();

        Console.WriteLine("APPROACH - DYNAMIC PROGRAMMING:");
        Console.WriteLine("═══════════════════════════════");
        Console.WriteLine("We'll use a state machine approach with two states:");
        Console.WriteLine("• HOLD: Currently holding a stock");
        Console.WriteLine("• SOLD: Not holding any stock");
        Console.WriteLine();

        Console.WriteLine("STATE TRANSITIONS:");
        Console.WriteLine("┌─────────────────────────────────────────────────────────────┐");
        Console.WriteLine("│  SOLD ──(buy)──> HOLD ──(sell)──> SOLD                     │");
        Console.WriteLine("│    ↑                                ↓                       │");
        Console.WriteLine("│    └────────────(pay fee)───────────┘                      │");
        Console.WriteLine("└─────────────────────────────────────────────────────────────┘");
        Console.WriteLine();

        // Example 1 from problem statement
        RunTestCase(new int[] {1, 3, 2, 8, 4, 9}, 2, 1);

        // Example 2: No profitable transactions
        RunTestCase(new int[] {1, 3, 7, 5, 10, 3}, 3, 2);

        // Example 3: Single transaction
        RunTestCase(new int[] {1, 5}, 1, 3);

        // Example 4: Multiple transactions
        RunTestCase(new int[] {1, 3, 7, 5, 10, 3, 6, 9, 2}, 2, 4);

        // Example 5: Decreasing prices
        RunTestCase(new int[] {9, 8, 7, 6, 5, 4, 3, 2, 1}, 2, 5);

        // Example 6: All same prices
        RunTestCase(new int[] {5, 5, 5, 5, 5}, 2, 6);

        Console.WriteLine("\n\n╔═══════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                    ALGORITHM EXPLANATION                      ║");
        Console.WriteLine("╚═══════════════════════════════════════════════════════════════╝");

        Console.WriteLine("\nKEY INSIGHTS:");
        Console.WriteLine("═════════════");
        Console.WriteLine("1. STATE MACHINE APPROACH:");
        Console.WriteLine("   • Two states: HOLD (owning stock) and SOLD (no stock)");
        Console.WriteLine("   • Track maximum profit in each state");
        Console.WriteLine();

        Console.WriteLine("2. STATE TRANSITIONS:");
        Console.WriteLine("   • sold[i] = max(sold[i-1], hold[i-1] + prices[i] - fee)");
        Console.WriteLine("     - Either stay in sold state or sell today");
        Console.WriteLine("   • hold[i] = max(hold[i-1], sold[i-1] - prices[i])");
        Console.WriteLine("     - Either keep holding or buy today");
        Console.WriteLine();

        Console.WriteLine("3. OPTIMIZATION:");
        Console.WriteLine("   • Only need previous state values");
        Console.WriteLine("   • Can reduce space from O(n) to O(1)");
        Console.WriteLine();

        Console.WriteLine("TIME & SPACE COMPLEXITY:");
        Console.WriteLine("═══════════════════════");
        Console.WriteLine("• Time Complexity: O(n) - single pass through prices");
        Console.WriteLine("• Space Complexity: O(1) - only two variables needed");
        Console.WriteLine();

        Console.WriteLine("SIMILAR PROBLEMS:");
        Console.WriteLine("═════════════════");
        Console.WriteLine("• Best Time to Buy and Sell Stock (single transaction)");
        Console.WriteLine("• Best Time to Buy and Sell Stock II (unlimited transactions)");
        Console.WriteLine("• Best Time to Buy and Sell Stock III (at most 2 transactions)");
        Console.WriteLine("• Best Time to Buy and Sell Stock IV (at most k transactions)");
        Console.WriteLine("• Best Time to Buy and Sell with Cooldown");
        Console.WriteLine();

        Console.WriteLine("╔═══════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║         Dynamic Programming: Breaking Complex Problems        ║");
        Console.WriteLine("║                  Into Manageable States! 📈                   ║");
        Console.WriteLine("╚═══════════════════════════════════════════════════════════════╝");
    }

    static void RunTestCase(int[] prices, int fee, int testNumber)
    {
        Console.WriteLine($"\n╔═══════════════════════════════════════════════════════════════╗");
        Console.WriteLine($"║                        TEST CASE {testNumber}                            ║");
        Console.WriteLine($"╚═══════════════════════════════════════════════════════════════╝");
        
        Console.WriteLine($"Input: prices = [{string.Join(",", prices)}], fee = {fee}");
        
        // Optimized solution
        int maxProfit = StockTrader.MaxProfitOptimized(prices, fee);
        Console.WriteLine($"Maximum Profit: {maxProfit}");
        
        // Detailed solution with transactions
        var (profit, transactions) = StockTrader.MaxProfitWithDetails(prices, fee);
        Console.WriteLine("\nTransaction Details:");
        foreach (var transaction in transactions)
        {
            Console.WriteLine($"  • {transaction}");
        }
        
        // Show the DP array evolution for educational purposes
        if (prices.Length <= 10)
        {
            Console.WriteLine("\nDP State Evolution:");
            Console.WriteLine("Day | Price | Sold | Hold");
            Console.WriteLine("----+-------+------+------");
            
            int sold = 0, hold = -prices[0];
            Console.WriteLine($"  0 |   {prices[0],3} |   {sold,3} | {hold,4}");
            
            for (int i = 1; i < prices.Length; i++)
            {
                int prevSold = sold;
                sold = Math.Max(sold, hold + prices[i] - fee);
                hold = Math.Max(hold, prevSold - prices[i]);
                Console.WriteLine($"  {i} |   {prices[i],3} |   {sold,3} | {hold,4}");
            }
        }
    }
}

// Solution class with multiple approaches
public class StockTrader
{
    /// <summary>
    /// Dynamic Programming approach - O(n) time, O(1) space
    /// Uses state machine with two states: hold and sold
    /// </summary>
    public static int MaxProfitOptimized(int[] prices, int fee)
    {
        if (prices == null || prices.Length <= 1) return 0;
        
        // State variables
        int sold = 0;                    // Max profit when not holding stock
        int hold = -prices[0];           // Max profit when holding stock (bought at day 0)
        
        for (int i = 1; i < prices.Length; i++)
        {
            int prevSold = sold;
            
            // Either keep previous sold state or sell today (from hold state)
            sold = Math.Max(sold, hold + prices[i] - fee);
            
            // Either keep holding or buy today (from sold state)
            hold = Math.Max(hold, prevSold - prices[i]);
        }
        
        // We end without holding any stock
        return sold;
    }
    
    /// <summary>
    /// Dynamic Programming with arrays - O(n) time, O(n) space
    /// Easier to understand but uses more memory
    /// </summary>
    public static int MaxProfitWithArrays(int[] prices, int fee)
    {
        if (prices == null || prices.Length <= 1) return 0;
        
        int n = prices.Length;
        int[] sold = new int[n];  // Max profit on day i without stock
        int[] hold = new int[n];  // Max profit on day i with stock
        
        hold[0] = -prices[0];     // Buy stock on day 0
        sold[0] = 0;              // No transaction on day 0
        
        for (int i = 1; i < n; i++)
        {
            // To be in sold state: either was sold before, or sell today
            sold[i] = Math.Max(sold[i-1], hold[i-1] + prices[i] - fee);
            
            // To be in hold state: either was holding before, or buy today
            hold[i] = Math.Max(hold[i-1], sold[i-1] - prices[i]);
        }
        
        return sold[n-1];
    }
    
    /// <summary>
    /// Detailed solution with transaction tracking
    /// </summary>
    public static (int profit, List<string> transactions) MaxProfitWithDetails(int[] prices, int fee)
    {
        if (prices == null || prices.Length <= 1) 
            return (0, new List<string> { "No transactions possible" });
        
        int n = prices.Length;
        int[] sold = new int[n];
        int[] hold = new int[n];
        int[] parent = new int[n];  // Track decisions
        
        hold[0] = -prices[0];
        parent[0] = -1;
        
        for (int i = 1; i < n; i++)
        {
            if (sold[i-1] >= hold[i-1] + prices[i] - fee)
            {
                sold[i] = sold[i-1];
                parent[i] = 0; // No action
            }
            else
            {
                sold[i] = hold[i-1] + prices[i] - fee;
                parent[i] = 2; // Sell
            }
            
            if (hold[i-1] >= sold[i-1] - prices[i])
            {
                hold[i] = hold[i-1];
            }
            else
            {
                hold[i] = sold[i-1] - prices[i];
                if (parent[i] == 0) parent[i] = 1; // Buy
            }
        }
        
        // Reconstruct transactions
        List<string> transactions = new List<string>();
        int buyDay = -1;
        bool holding = false;
        
        for (int i = 0; i < n; i++)
        {
            // Check if we should buy
            if (!holding && i < n - 1 && 
                hold[i] == (i > 0 ? sold[i-1] : 0) - prices[i])
            {
                buyDay = i;
                holding = true;
                transactions.Add($"Buy at day {i} (price = {prices[i]})");
            }
            // Check if we should sell
            else if (holding && i > 0 && 
                sold[i] == hold[i-1] + prices[i] - fee)
            {
                holding = false;
                int profit = prices[i] - prices[buyDay] - fee;
                transactions.Add($"Sell at day {i} (price = {prices[i]}, profit = {profit})");
            }
        }
        
        if (transactions.Count == 0)
            transactions.Add("No profitable transactions");
            
        return (sold[n-1], transactions);
    }
}