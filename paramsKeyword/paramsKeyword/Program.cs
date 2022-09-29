namespace paramsKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParamsMethod("this is weird", "i am so damned", "Hope it will reach out this line too");

            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "The Hobbit";

            ParamsMethod2(price,pi,at,book);
        }
        public static void ParamsMethod(params string[] sentence)
        {
            for(int i = 0; i < sentence.Length; i++)
            {
                Console.WriteLine(sentence[i]); 
            }
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            for (int i = 0; i < stuff.Length; i++)
            {
                Console.WriteLine(stuff[i]);
            }
        }
    }
}