using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Tv:ElectricalDevice
    {
        
        public Tv(bool isOn, string brand):base(isOn,brand)
        {
           
        }

        

        public void WatchTv()
        {
            if (IsOn)
            {
                Console.WriteLine("watching the Tv");
            }
            else
            {
                Console.WriteLine("The Tv is off, please turn it on to start watching");
            }
        }
    }
}
