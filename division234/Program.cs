namespace division234
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int division2 = 0;
            int division3 = 0;
            int division4 = 0;

            for (int i = 0; i < number; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input % 2 == 0)
                {
                    division2++;
                }
                if (input % 3 == 0)
                {
                    division3++;
                }
                if (input % 4 == 0)
                {
                    division4++;
                }
            }
            Console.WriteLine($"{(double)division2 / number * 100:f2}%");
            Console.WriteLine($"{(double)division3 / number * 100:f2}%");
            Console.WriteLine($"{(double)division4 / number * 100:f2}%");
        }
    }
}