using System.Collections;
namespace hashTableChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hashtable studentsTable = new Hashtable();

            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Louise", 73);
            students[4] = new Student(4, "levi", 58);

            foreach (Student s in students)
            {
                if (!studentsTable.Contains(s.Id))
                {
                    studentsTable.Add(s.Id, s);
                    Console.WriteLine("Student with id {0} is Inserted!",s.Id);
                }
                else
                {
                    Console.WriteLine("The student with the same id already exists {0}",s.Id);

                }

            }
        }

        
    }
}