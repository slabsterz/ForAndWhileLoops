namespace specialBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int previous = 0;

            while (true)
            {
                int input = int.Parse(Console.ReadLine()) ;

                if (input == number)
                {
                    double upgraded = previous * 1.2;
                    Console.WriteLine(upgraded);
                    break;
                }
                previous = input;
            }
        }
    }
}