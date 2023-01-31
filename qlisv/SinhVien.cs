using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.qlisv
{
    public class SinhVien
    {
        private int id;
        private string ten;
        private string gioiTinh;
        private int tuoi;
        private int dtoan;
        private int dli;
        private int dhoa;
        private float dtrungbinh;
        private string hocluc;
        public SinhVien()
        {

        }

        public SinhVien(int id, string ten, string gioiTinh, int tuoi, int dtoan, int dli, int dhoa, float dtrungbinh, string hocluc)
        {
            Id = id;
            Ten = ten;
            GioiTinh = gioiTinh;
            Tuoi = tuoi;
            Dtoan = dtoan;
            Dli = dli;
            Dhoa = dhoa;
            Dtrungbinh = dtrungbinh;
            Hocluc = hocluc;
        }

        public int Id
        {
            get { return id; }  
            set { id = value; }
        }
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public int Tuoi
        {
            get { return tuoi; }
            set { tuoi = value; }
        }
        public int Dtoan { 
            get { return dtoan; }
            set { dtoan = value; } 
        }
        public int Dli
        {
            get { return dli; }
            set { dli = value; }
        }
        public int Dhoa
        {
            get { return dhoa; }
            set { dhoa = value; }
        }
        public float Dtrungbinh
        {
            get { return dtrungbinh; }
            set { dtrungbinh = value;}
        }
        public string Hocluc
        {
            get { return hocluc; }
            set { hocluc = value; } 
        }

        public void Tb()
        {
             Dtrungbinh = (float)(Dtoan + Dli + Dhoa) / 3;
        }
        public void Hl()
        {
            if (Dtrungbinh >= 8)
            {
                Hocluc = "Gioi";
            }
            else if (Dtrungbinh<8 && Dtrungbinh >= 6.5)
            {
                Hocluc = "Kha";
            }
            else if(Dtrungbinh<6.5 && Dtrungbinh >= 5)
            {
                Hocluc = "Trung Binh";
            }
            else
            {
                Hocluc = "Yeu";
            }
        }
   }
}
