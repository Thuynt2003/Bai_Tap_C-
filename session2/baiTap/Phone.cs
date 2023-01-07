using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.session2.baiTap
{
    public abstract class Phone
    {
        public abstract void InsertPhone(string name, string phone);
        public abstract void RemovePhone(String name);
        public abstract void UpdatePhone(String name, String oldPhone, String newPhone);
        public abstract Phone SearchPhone(String name);
        public abstract void Sort();
    }
}
