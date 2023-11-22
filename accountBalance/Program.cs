namespace accountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalSum = 0;

            while (true)
            {
                
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                double amount = double.Parse(input);

                if (amount > 0)
                {
                    totalSum += amount;
                    Console.WriteLine($"Increase: {amount:f2}");
                }
                 else 
                {
                    totalSum -= Math.Abs(amount);
                    Console.WriteLine($"Decrease: {Math.Abs(amount):f2}");
                }
            }
            Console.WriteLine($"Balance: {totalSum:f2}");
        }
    }
}