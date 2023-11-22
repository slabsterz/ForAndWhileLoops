namespace multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++) 
            {
                int calculation = 0;
                calculation = number * i;
                Console.WriteLine($"{number} x {i} = {calculation}");
            }
        }
    }
}