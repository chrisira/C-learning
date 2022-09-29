namespace challengeArrayParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] hapiness = new int[] { 2, 4, 5, 6, 8 };

            SunisShining(hapiness);

            foreach(int y in hapiness)
            {
                Console.WriteLine(y);
                
            }
        }

        static void SunisShining(int[] x)
        {
            for(int i = 0; i < x.Length; i++)
            {
                x[i] += 2;
            }
        }
    }
}

