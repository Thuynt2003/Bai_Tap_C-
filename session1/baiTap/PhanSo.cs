using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.session1.baiTap
{
    public class PhanSo
    {
        int ts;
        int ms;

        public PhanSo(int ts,int ms)
        {
            this.ts = ts;
            this.ms = ms;
        }

        public void InPS()
        {
            Console.WriteLine(this.ts + "/" + this.ms);
        }
        public void RutGonPS()
        {
            List<int> ucTS = new List<int>();
            List<int> ucMS = new List<int>();
            int ucln = 0;

            for(int i = 1; i <= this.ts; i++)
            {
                if(this.ts % i ==0)
                {
                    ucTS.Add(i);
                }
            }

            for (int i = 1; i <= this.ms; i++)
            {
                if (this.ms % i == 0)
                {
                    ucMS.Add(i);
                }
            }

            for(int i = 0; i < ucTS.Count(); i++)
            {
                for(int j = 0; j < ucMS.Count(); j++)
                {
                    if(ucTS[i] == ucMS[j])
                    {
                        ucln = ucTS[i];
                    }
                } 
            }
            this.ts /= ucln;
            this.ms /= ucln;
        }
   
    }
    }
