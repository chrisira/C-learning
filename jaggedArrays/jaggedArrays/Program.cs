namespace jaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare a jagged array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];    
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2,3,5,7,11};
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            //alternaive way

            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 2, 3, 5,7,11 },
                new int[] { 1, 2, 3 },
            };

            Console.WriteLine("the value in the middle of the array is {0}", jaggedArray[0][2]);
            for(int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine("Element {0}",i);


                for(int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine("{0}", jaggedArray[i][j]);
                }
            }

          
            
        }
    }
}