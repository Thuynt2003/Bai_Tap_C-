using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.session1
{
    public class Hument
    {
        public string name;
        public int age;
        public void Eat()
        {
            Console.WriteLine("Eating....");
        }
        public void Run()
        {
            Console.WriteLine(this.name + "running.....");

        }
    }
}
