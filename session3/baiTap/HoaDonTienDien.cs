using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.session3.baiTap
{
    public class HoaDonTienDien
    {     
        private int id;
        private string name;
        private string nxhd;
        private int soluong;
        private float thanhtien;

        public HoaDonTienDien(int id,string name,  string nxhd, int soluong)
        {   
            this.id = id;
            this.name = name;
            this.nxhd = nxhd;
            this.soluong = soluong;

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nxhd
        {
            get { return nxhd; }
            set { nxhd = value; }
        }
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public float Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
    }
}
