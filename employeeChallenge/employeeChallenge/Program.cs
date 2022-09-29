namespace employeeChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee maxman = new Employee("Maxman", "Chris", 30000);
            maxman.Working();
            maxman.Pause();

            Boss Chris = new Boss("Ferrari", "Max", "Dude", 300000);
            Chris.Lead();

        }
    }
}