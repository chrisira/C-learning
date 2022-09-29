namespace queuesAndstacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            Console.WriteLine("The top value of the stack is {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("The Top value of the stack is {0}", stack.Peek());
            stack.Push(3);
            while (stack.Count > 0)
            {
                stack.Pop();
            }
            //int myStackItem = stack.Pop();

            if (stack.Count > 0)
            {
                Console.WriteLine("the current top value is {0}", stack.Peek());
            }
            else
            {
                Console.WriteLine("stack is empty");
            }

            //reversing an array using stacks

            int[] number = new int[] { 8, 2, 3, 4, 7, 6, 2 };

            Stack<int> input = new Stack<int>();

            foreach (int item in number) {

                Console.Write(item + " ");

                input.Push(item);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Numbers in reverse");

            while(input.Count > 0)
            {
                // Pop it and store it in a variable

                int variable = input.Pop();
                Console.Write(variable + " ");
            }

            




        }
    }
} 