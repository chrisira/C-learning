namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Panasonic");
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            Tv myTv = new Tv(false, "Sony");
            myTv.SwitchOn();
            myTv.WatchTv();
        }
    }
}