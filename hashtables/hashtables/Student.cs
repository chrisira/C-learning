using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtables
{
    internal class Student
    {

        //property called Id
        public int Id { get; set; }
        //property called name
        public string Name { get; set; }

        // property called GPA
        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }   
    }
}
