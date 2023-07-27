namespace homework_3_27_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the pascal triangle number : ");
            int.TryParse(Console.ReadLine(), out int number);

            for(int i = 0; i<number; i++)
            {
                for(int j = 0; j<number; j++)
                {
                    if(j >= number-1-i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}