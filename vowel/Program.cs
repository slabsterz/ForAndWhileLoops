namespace vowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());                      
            int sum = 0;
            
            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "a": sum += 1; break;
                    case "e": sum += 2; break;
                    case "i": sum += 3; break;
                    case "o": sum += 4; break;
                    case "u": sum += 5; break;
                }
            }
            Console.WriteLine(sum);

        }
    }
}