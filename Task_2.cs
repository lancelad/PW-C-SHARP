namespace Task_2
{
    public class NubmersCheker
    {
        private int number = 0;
        public bool CheckNumber(int InputNumber)
        {
            if (InputNumber == number + 1)
            {
                number = InputNumber;
                return true;
            }
            else
            {
                number = 0;
                return false;
            }

        }
        public int GetNumber()
        {
            return number + 1;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            NubmersCheker numberView = new NubmersCheker();

            while (true)
            {
                Console.Write("Введите натуральное число: ");
                int input = Convert.ToInt32(Console.ReadLine());

                if ( input > 0 ) 
                { 

                if (numberView.CheckNumber(input))
                {
                    Console.WriteLine("Верно. Ожидаемое число будет: " + numberView.GetNumber());
                }
                else
                {
                    Console.WriteLine("Вы сбились со счета... Давайте начнем сначала!");
                }
                }
                else { 
                    Console.WriteLine("Вы ввели не натуральное число!");
                }
            }
        }
    }
}

