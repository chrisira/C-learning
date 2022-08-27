
namespace constructor_properties1
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(2,3);
            System.Console.WriteLine("Box surface is "  + box.frontSurface);
            

            box.DisplayInfo();
        }
    }
}