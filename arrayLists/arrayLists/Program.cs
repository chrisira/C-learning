using System.Collections;

namespace arrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring an arraylist

            ArrayList myArraylist = new ArrayList();
            // declaring an arraylist with defined amount of object
            ArrayList myArraylist2 = new ArrayList(100);

            myArraylist.Add(25);
            myArraylist.Add("Hello");
            myArraylist.Add(13.37);
            myArraylist.Add(13);
            myArraylist.Add(128);
            myArraylist.Add(25.3);
            myArraylist.Add(13);


            // delete element with specific value from the arraylist

            myArraylist.Remove(13);

            // delete element with specfic index from the arraylist

            myArraylist.RemoveAt(0);

            //counting the number of entries in the arraylist

            Console.WriteLine("There are {0} entries in the arraylist",myArraylist.Count);

            // using foreach to iterale through the objects in the arraylist

            double sum = 0;

            foreach (object obj in myArraylist)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                } else if (obj is double)
                {
                    sum += (double)obj;
                }

                else
                {
                    Console.WriteLine("The string in value is {0}",obj);
                }

            }
            Console.WriteLine("the sum is {0}",sum);
           
           
        }
    }
}