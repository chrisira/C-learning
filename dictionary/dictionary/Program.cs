namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employees[] employees =
            {
                new Employees("CEO","Gwyn",95,200),
                new Employees("Manager","Joe",35,25),
                new Employees("HR","Lora",32,21),
                new Employees("Secretary","Petra",28,18),
                new Employees("Lead developer","Artorias",55,35),
                new Employees("Intern","Ernest",22,8),
            };


            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {1,"one" },
                {2,"two"},
                {3,"three" }
            };

            Dictionary<string, Employees> employeesDirectory = new Dictionary<string, Employees>();

            foreach (Employees emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);

            }


            //update entry in the dictionary
            string keyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(keyToUpdate))
            {
                employeesDirectory[keyToUpdate] = new Employees("HR", "Eleka", 26, 18);
                Console.WriteLine("Employee with the role/key {0} was updated !",keyToUpdate);
            }
            else
            {
                Console.WriteLine("The employee with the key not found!");
            }

            string keyToRemove = "Intern";

            if (employeesDirectory.Remove(keyToRemove))
            {
                Console.WriteLine("Employee Role with the Key {0} was removed ", keyToRemove);
            }
            else
            {
                Console.WriteLine("No Role found with the key specified {0}",keyToRemove);
            }
            string key = "Intern";
            if (employeesDirectory.ContainsKey(key))
            {
                Employees emp1 = employeesDirectory[key];

                Console.WriteLine("Employee Name : {0}, Role : {1}, Salary : {2}", emp1.Name, emp1.Role, emp1.salary);

            }
            else
            {
                Console.WriteLine("No key found for the entered value");
            }

            // using another approach to catch the errors

            Employees resut = null;
            if(employeesDirectory.TryGetValue("Intern",out resut))
            {
                Console.WriteLine("Value retrieved!");
                Console.WriteLine("Employee Name : {0}",resut.Name);
                Console.WriteLine("Employee Role : {0}", resut.Role);
                Console.WriteLine("Employee Age : {0}", resut.Age);
                Console.WriteLine("Employee Salary : {0}", resut.salary);

            }
            else
            {
                Console.WriteLine("The key wasn't retrieved");
            }


            //using the for loop to get the elements from the dictionary using indexes

            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                // using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string,Employees> keyValuePair = employeesDirectory.ElementAt(i);
                // print the key
                Console.WriteLine("Key : {0}",keyValuePair.Key);
                //storing the value in an employee object

                Employees employeeValue = keyValuePair.Value;
                // printing the properties of the employee object
                Console.WriteLine("the Employee Name is {0} ",employeeValue.Name);
                Console.WriteLine("the Employee Role is {0} ",employeeValue.Role);
                Console.WriteLine("the Employee Age is {0} ",employeeValue.Age);
                Console.WriteLine("the Employee Salary is {0} ",employeeValue.salary);

            }
            
            
        }
    }
}