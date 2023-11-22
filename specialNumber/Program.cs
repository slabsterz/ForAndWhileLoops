namespace specialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int currentDigit = 0;
            while (true)
            {
                string numberToString = number.ToString();
                
                int digit = int.Parse(numberToString[currentDigit].ToString());
                currentDigit++;

                if (number % digit != 0)
                {
                    Console.WriteLine($"{number} is not special");
                    break;
                }
                
                if (currentDigit >= numberToString.Length)
                {
                    Console.WriteLine($"{number} is special");
                    break;
                }
            }
        }
    }
}