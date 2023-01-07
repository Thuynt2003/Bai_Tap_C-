using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.session2
{
    public class Dog : Animal,IAnimal
    {
        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Color
        {
            get => Color;
            set => Color = value;
        }

        public Dog(string kind,double weight) :base(kind) 
        {
        this.Weight = weight;  
        }
        public void Info()
        {
            Console.WriteLine(GetKind());
        }
    }
}
