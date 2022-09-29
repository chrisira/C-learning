namespace nestedLoopin2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                {1,2,3 },
                {4,5,6},
                {7,8,9}
            };

            foreach (int item in matrix)
            {
                Console.Write(item + " ");
               

            }
            Console.WriteLine("\n the value of 2D array is:");
            // nested for loop
            // outer for loop
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //printing the diagonal(1,5,9)
                    if (i == j)
                        
                    {
                        //replacing the actual value to default value specified
                       // matrix[i, j] = 1;
                       // Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    // printing the diagonal(3,5,7)   0,2  1,1   2,0

                    if (i == 0 && i==j && j==0)

                    {
                        
                       // matrix[i, j] = 1;
                        Console.Write(matrix[i, j] + " ");
                    }

                    



                }

            }
        }
    }
}