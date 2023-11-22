namespace biggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;

            for (int i = 0; i < number; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input > maxNumber)
                {
                    maxNumber = input;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}