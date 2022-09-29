namespace minValueParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = MinimumValue(3, 243, 32, 324, 45, 54, 234, -3, 31);
            Console.WriteLine("The minimum value is {0}",min);
        }

        public static int MinimumValue(params int [] numbers)
        {
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                if(number < min)
                {
                    min = number;
                }
            }
            return min;

        }

        

    }
}