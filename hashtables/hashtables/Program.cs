using System.Collections;

namespace hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating a new hashtable
            Hashtable studentTable = new Hashtable();

            // creating objects from the class

            Student stud1 = new Student(1, "Christian", 98);
            Student stud2 = new Student(2, "Egide", 76);
            Student stud3 = new Student(3, "Franz", 43);
            Student stud4 = new Student(4, "Niel", 55);

            //assigning values to the hashtable

            studentTable.Add(stud1.Id, stud1);
            studentTable.Add(stud2.Id, stud2);
            studentTable.Add(stud3.Id, stud3);
            studentTable.Add(stud4.Id, stud4);

            // retrieving data from a hashtable with known ID

            Student storedStudent1 = (Student)studentTable[stud4.Id];
            Console.WriteLine("Student ID : {0}, Name : {1} , GPA : {2}",storedStudent1.Id,storedStudent1.Name,storedStudent1.GPA);

            // retrieving all the stored values using dictionary entry

            foreach (DictionaryEntry entry in studentTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID : {0}",temp.Id);
                Console.WriteLine("Student Name : {0}", temp.Name);
                Console.WriteLine("Student GPA : {0}", temp.GPA);


            }

            // we can also simplify the foreach loop in this way

            foreach (Student value in studentTable.Values)
            {
                Console.WriteLine("Student ID : {0}", value.Id);
                Console.WriteLine("Student Name : {0}", value.Name);
                Console.WriteLine("Student GPA : {0}", value.GPA);

            }


        }
    }
}