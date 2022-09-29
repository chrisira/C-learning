namespace arraysAsParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] studentsGrades = new int[] { 23, 43, 54, 32, 34, 22, 21 };

            double AverageResult = GetAverage(studentsGrades);

            foreach(int grade in studentsGrades)
            {
                Console.WriteLine("{0}",grade);
            }

            Console.WriteLine("The average is {0}",AverageResult);
        
        }

        static double GetAverage(int[] GradesArray)
        {
            int size = GradesArray.Length;
            double average;
            int sum = 0;

            for(int i = 0; i < size; i++)
            {
                sum += GradesArray[i];

            }
            average = (double)sum / size;
            return average;

        }
    }
}