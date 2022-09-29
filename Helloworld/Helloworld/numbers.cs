using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class numbers
    {

        public int Width { get; set; }
        public int Length { get; set; }
        public int Name { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine("the width is {0} the length is {1} and the area is {2}",Width,Length,Width * Length);
        }


    }
}
