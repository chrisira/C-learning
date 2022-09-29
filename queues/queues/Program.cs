namespace queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();

            string[] customerList = new string[] { "Christian", "Elysee", "Ben", "Feza", "Faith" };

            foreach (string customer in customerList)
            {
                customers.Enqueue(customer);    

            }
            Console.WriteLine("The first customer in the list is {0}",customers.Peek());
            Console.WriteLine("Total customers are {0}",customers.Count);
            string firstToGo = customers.Dequeue();

            Console.WriteLine("The first  customer to go  is {0}",firstToGo);
            Console.WriteLine("The second  customer to go  is {0}", customers.Dequeue());
            Console.WriteLine("The third  customer to go  is {0}", customers.Dequeue());
            Console.WriteLine("The fouth  customer to go  is {0}", customers.Dequeue());

        }
    }
}