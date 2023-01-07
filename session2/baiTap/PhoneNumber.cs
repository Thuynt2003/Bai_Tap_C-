using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.session2.baiTap
{
    public class PhoneNumber
    {
        public string name;
        public List<string> Numbers;
        public PhoneNumber() { }

        public PhoneNumber(string name, List<string> numbers)
        {
            this.name = name;
            Numbers = numbers;
        }
    }
}