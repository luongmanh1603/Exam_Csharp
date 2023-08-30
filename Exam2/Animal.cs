using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal class Animal
    {
        protected double Weight { get; set; }
        protected string Name { get; set; }

        public Animal(double weight, string name)
        {
            Weight = weight;
            Name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {Name}, Weight: {Weight} kg");
        }

        public void SetMe(double weight, string name)
        {
            Weight = weight;
            Name = name;
        }
    }
}
