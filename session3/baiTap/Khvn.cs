using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.session3.baiTap
{
    public class Khvn : HoaDonTienDien
    {
        private string dtkh;
        public string Dtkh
        {
            get { return dtkh; }
            set { dtkh = value; }
        }
        public Khvn(int id ,string name, string nxhd, int soluong,string dtkh) : base( id,name,nxhd, soluong)
        {
            this.Dtkh = dtkh;
        }
        public float tinhtiendien()
        {
            
            if (Soluong <= 50)
            
                Thanhtien = Soluong * 1000;
            
            else if (Soluong <= 100)
            
                Thanhtien = 50 * 1000 + (Soluong - 50) * 1200;
            
             else if (Soluong <= 200)
            
                Thanhtien = 50 * 1000 + 50 * 1200 + (Soluong - 100) * 1500;
            
            else
            
                Thanhtien = 50 * 1000 + 50 * 1200 + 100 * 1500 + (Soluong - 200) * 2000;
            
            
            
            return Thanhtien;
        }
    }
}
