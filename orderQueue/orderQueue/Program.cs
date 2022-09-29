namespace orderQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order o in ReceiveOrdersFromBranch1())
            {
                //add each order to the queue
                ordersQueue.Enqueue(o); 
            }

            foreach (Order o in ReceiveOrdersFromBranch2())


                // add each order to the queue
                ordersQueue.Enqueue(o);
            {

            }

            // as long as the order is not empty
            while(ordersQueue.Count > 0)
            {
                // remove the order at the front of the queue
                // and store ut in a variable called currentOrder

                Order currentOrder = ordersQueue.Dequeue();

                // process the order
                currentOrder.ProcessOrder();
            }

        }
        



        static Order[] ReceiveOrdersFromBranch1()
        {

            Order[] orders = new Order[]
            {
                // creating new orders array and initializing it with some objects of type order

                new Order(1,5),
                new Order(2,4),
                new Order(6,10),
            };
            // return the array of orders that we created
            return orders;
        }

        static Order[] ReceiveOrdersFromBranch2()
        {

            Order[] orders = new Order[]
            {
                // creating new orders array and initializing it with some objects of type order

                new Order(3,5),
                new Order(4,4),
                new Order(5,10),
            };
            // return the array of orders that we created
            return orders;
        }

    }
    
}