using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.session2
{
    public class Animal
    {
        private string kind;

        public Animal(string kind)
        {
            this.kind = kind;
        }

        public void SetKind(string k)
        {
            kind= k;
        }
        public string GetKind()
        { return kind; }
    }
}
