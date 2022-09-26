namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                DisplayText();
                CalculateAndDisplay(ReadAndValidate());
            } while (CalculateAgain());

        }
        public static void DisplayText()
        {
            Console.WriteLine("Multiplication Table \n");
            SleepAndClear();
            Console.WriteLine("Enter the number between 1 to 10");
        }
        public static int ReadAndValidate()
        {
            int userNumber;
            while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber > 10)
            {
                Console.WriteLine("Invalid input, try again");
            }
            SleepAndClear();
            return userNumber;
        }
        public static void CalculateAndDisplay(int userNumber)
        {
            for (int x = 1; x <= userNumber; x++)
            {
                for (int y = 1; y <= userNumber; y++)
                {
                    int value = x * y;
                    Console.Write("{0}, ", value);
                }
                Console.WriteLine();
            }
        }
        public static void SleepAndClear()
        {
            Thread.Sleep(1000);
            Console.Clear();
        }
        public static bool CalculateAgain()
        {
            Thread.Sleep(1500);
            Console.WriteLine("\nIf you want to continue press y, if not press another button");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                return true;
            }
            return false;
        }
    }
}
