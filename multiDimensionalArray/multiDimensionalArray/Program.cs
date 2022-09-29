namespace multiDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        // declare a 2D array
        {
            string[,] matrix;

            //3D array

            int[,,] threeD;

            // two dimensional array

            int[,] array2D = new int[,]
            {
                {1, 2, 3}, //row 0
                {4,5, 6}, // row 1
                {7,8,9} // row 2
            };
            Console.WriteLine("Central value is {0}", array2D[2, 0]);

            string[,,] array3D = new string[,,]
            {
                    {
                        {"000", "001"},
                        {"010", "011" },
                        {"hey there","whats up" }
                    },

                    {
                        { "100","101"},
                        { "110","111"},
                        {"another","last value" }
                }
             };
            Console.WriteLine("Thw value is {0}", array3D[0,2,0]);

            string[,] array2Dstring = new string[3, 2] {
                { "one", "two" },
                { "three", "Four" },
                { "five", "six" }
            };

            array2Dstring[1, 1] = "Chicken";

            Console.WriteLine("The new value is {0}", array2Dstring[1,1]);

            //determining the dimension of an array
            int dimensions = array2Dstring.Rank;
            Console.WriteLine("The dimension is {0}", dimensions);

            //declaring an array without specifying the input

            int[,] array2D2 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, };
}

        }
    }
