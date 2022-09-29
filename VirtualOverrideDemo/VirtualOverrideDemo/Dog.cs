using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    internal class Dog : Animals
    {
        public bool IsHappy { get; set; }
        public Dog(string name,int age):base(name,age)
        {
            this.IsHappy = true;
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Wooooooo");
        }

        public override void Play()
        {
            if (IsHappy) {
                base.Play();
            
            }
        }



    }
}
