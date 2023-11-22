namespace powerOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double powered = 1;

            for (int i= 1; i <= power; i++)
            {
               powered *= number;
            }
            Console.WriteLine(powered);
        }
    }
}