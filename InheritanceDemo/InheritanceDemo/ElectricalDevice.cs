using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{

    // parent class
    internal class ElectricalDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;  
        }


        // switch on the electrical device
        public void SwitchOn()
        {
            IsOn = true;
        }
        // swittch off the electrical device
        public void SwitchOff()
        {
            IsOn = false;
        }
    }

}
