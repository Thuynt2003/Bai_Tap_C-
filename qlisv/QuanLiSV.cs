using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.qlisv
{
    public class QuanLiSV
    {
       public List<SinhVien> qliSV = new List<SinhVien>(); 
        public void ThemSV()
        {
            SinhVien sv = new SinhVien();
            Console.Write("nhap id :");
            sv.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap ten sinh vien :");
            sv.Ten = Console.ReadLine();
            Console.Write("gioi tinh :");
            sv.GioiTinh = Console.ReadLine();
            Console.Write("Tuoi :");
            sv.Tuoi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Diem toan :");
            sv.Dtoan = Convert.ToInt32(Console.ReadLine());
            Console.Write("Diem li :");
            sv.Dli = Convert.ToInt32(Console.ReadLine());
            Console.Write("Diem Hoa :");
            sv.Dhoa = Convert.ToInt32(Console.ReadLine());
            sv.Tb();
            sv.Hl();
            qliSV.Add(sv);
        }
        public void XoaSvTheoID()
        {
            Console.Write("nhap ID :");
            int deleteID = Convert.ToInt32(Console.ReadLine());
            qliSV.Remove(qliSV.Find(sv => sv.Id.Equals(deleteID))!);
            Display(qliSV);
        } 
        public void updateID()
        {
            Console.WriteLine("nhap id can update:");
            int id = Convert.ToInt32(Console.ReadLine());
            qliSV.ForEach(sv =>
            {
                if(sv.Id.Equals(id))
                {
                    Console.WriteLine("1.chinh sưa ten");
                    Console.WriteLine("2.chinh sưa gioi tinh");
                    Console.WriteLine("3.chinh sưa tuoi");
                    Console.WriteLine("4.chinh sưa diem toan");
                    Console.WriteLine("5.chinh sưa diem li");
                    Console.WriteLine("6.chinh sưa diem hoa");
                    Console.WriteLine("nhap lua chon: ");
                    int choose = Convert.ToInt32(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            Console.WriteLine("nhap ten :");
                            string chinhsuaTen = Console.ReadLine();
                            if (!sv.Ten.Equals(chinhsuaTen))
                            {
                                sv.Ten = chinhsuaTen;
                            }
                            break;
                        case 2:
                            Console.WriteLine("nhap gioi tinh :");
                            string chinhsuaGioiTinh = Console.ReadLine();
                            if (!sv.GioiTinh.Equals(chinhsuaGioiTinh))
                            {
                                sv.GioiTinh = chinhsuaGioiTinh;
                            }
                            break;
                        case 3:
                            Console.WriteLine("nhap tuoi :");
                            int chinhsuaTuoi = Convert.ToInt32(Console.ReadLine());
                            if (!sv.Tuoi.Equals(chinhsuaTuoi))
                            {
                                sv.Tuoi = chinhsuaTuoi;
                            }
                            break;
                        case 4:
                            Console.WriteLine("nhap diem toan :");
                            int chinhsuaDiemToan = Convert.ToInt32(Console.ReadLine());
                            if (!sv.Dtoan.Equals(chinhsuaDiemToan))
                            {
                                sv.Dtoan = chinhsuaDiemToan;
                            }
                            break;
                        case 5:
                            Console.WriteLine("nhap diem li :");
                            int chinhsuaDiemLi = Convert.ToInt32(Console.ReadLine());
                            if (!sv.Dtoan.Equals(chinhsuaDiemLi))
                            {
                                sv.Dli = chinhsuaDiemLi;
                            }
                            break;
                        case 6:
                            Console.WriteLine("nhap diem hoa :");
                            int chinhsuaDiemHoa = Convert.ToInt32(Console.ReadLine());
                            if (!sv.Dtoan.Equals(chinhsuaDiemHoa))
                            {
                                sv.Dhoa = chinhsuaDiemHoa;
                            }
                            break;
                        default:
                            break;
                    }

                }
            });
        }
        public void SeachName()
        {
           List<SinhVien> svnew = new List<SinhVien>();
            Console.Write("nhap ten can tim kiem :");
            string name = Console.ReadLine();
            qliSV.ForEach(sv =>
            {
                if(sv.Ten.Contains(name)) { 
                svnew.Add(sv);
            }
               
            });
            Display(svnew);
        }
        public void sapxepTen() 
        {
            qliSV.Sort((sv1, sv2) => sv1.Ten.CompareTo(sv2.Ten));
            Display(qliSV);
        }
        public void sapxepTb()
        {
            qliSV.Sort((sv1, sv2) => sv1.Dtrungbinh.CompareTo(sv2.Dtrungbinh));
            Display(qliSV);
        }
        public void sapxepID()
        {
            qliSV.Sort((sv1, sv2) => sv1.Id.CompareTo(sv2.Id));
            Display(qliSV);
        }
        public void Display(List<SinhVien> l)
        {
            Console.WriteLine("{0, 5} {1, 20} {2,10 } {3, 20} {4, 5} {5, 5} {6, 5} {7, 10} {8, 10}",
                 "ID", "Ten", "Gioi Tinh", "Tuoi", "Toan", "Ly", "Hoa", "Diem TB", "Hoc Luc");
            l.ForEach(sv =>
            {
                Console.WriteLine("{0, 5} {1, 20} {2,10 } {3, 20} {4, 5} {5, 5} {6, 5} {7, 10} {8, 10}",
                                        sv.Id, sv.Ten, sv.GioiTinh, sv.Tuoi, sv.Dtoan, sv.Dli, sv.Dhoa,
                                        sv.Dtrungbinh, sv.Hocluc);

            });

        }
    }
}
