using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.session3.baiTap
{
    public class Khnn : HoaDonTienDien
    {
        private string qtich;
        public string Qtich
        {
            get { return qtich; }
            set { qtich = value; }
        }
        public Khnn(int id, string name, string nxhd, int soluong, string qtich) : base(id, name, nxhd, soluong) {
            this.Qtich = qtich;
        }
        public float thanhtoan()
        {
            Thanhtien = Soluong * 2000;
            return Thanhtien;
        }
    }

    }

