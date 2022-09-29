namespace Helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            numbers chris = new numbers();

            chris.Length = 12;
            chris.Width = 13;

            chris.DisplayInfo();
        }
    }
}