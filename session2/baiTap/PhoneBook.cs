using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.session2.baiTap
{
    public class PhoneBook : Phone
    {
        List<PhoneNumber> phoneList = new List<PhoneNumber>();
        public override void InsertPhone(string name, string phone)
        {
          for(int i = 0; i< phoneList.Count; i++)
            {
                if (phoneList[i].name.Equals(name))
                {
                    for(int j = 0; j < phoneList[i].Numbers.Count;j++)
                    {
                        if (!phoneList[i].Numbers[j].Equals(phone))
                        {
                            phoneList[i].Numbers.Add(phone);                             
                        }
                    }
                }
                else
                {

                }
            }
        }

        public override void RemovePhone(string name)
        {
           
        }

        public override Phone SearchPhone(string name)
        {
            throw new NotImplementedException();
        }

        public override void Sort()
        {
            throw new NotImplementedException();
        }

        public override void UpdatePhone(string name, string oldPhone, string newPhone)
        {
            throw new NotImplementedException();
        }
    }
}
