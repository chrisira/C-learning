using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    //child class
    internal class Radio:ElectricalDevice
    {

        public Radio(bool isOn,string brand):base(isOn,brand)
        {
           
        }
        
        //switch on the radio

        public void ListenRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to the radio");
            }
            else
            {
                Console.WriteLine("The radio is off, please turn it on to start listening");
            }
        }

    }
}
