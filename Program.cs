using System.Security.Cryptography.X509Certificates;
using T2204M.session1;
using T2204M.session1.baiTap;
using T2204M.session3;
using T2204M.session3.baiTap;
using T2204M.session4;
using T2204M.session4.baitap;

public class program
{
    public static void Main(string[] args)
    {
        News n = new News(1, "abcd", "13-12-2003", "Nguyen van a", "CDEF");
        n[0] = 1;
        n[1] = 2;
        n[2] = 3;
        n.Calculate();
        n.DisPlay();
    }
        public static void Main4(string[] args)
    {
        //DemoDelegate.Alert("Cam thanh vien duoi 18 tuoi");
        //DemoDelegate d = new DemoDelegate();
        //d.ShowMessage("Canh bao lan thu nhat");
        PrintString ps = new PrintString(ShowDanger);
        ps += (s) =>
        {
            Console.WriteLine("Anonymus:" + s);

        };
         

        
    }
    public static void ShowDanger(string mg)
    {
        Console.WriteLine("Anonymus:" + mg);
    }
    public static void Main2(String[] args)
    {
        Car c = new Car() { Brand = "Toyota", Type = "Sedan" };
        Console.WriteLine(c.machines[0]);
        Console.WriteLine(c[1]);
        c.machines.Add("Loa");
    }
    public static void Main3(String[] args)
    {
        Khvn vn = new Khvn(01, "Nguyen Thi A", "12-12-2003", 110,"san xuat");
        Console.WriteLine(vn.tinhtiendien());
        Khnn nn = new Khnn(01, "Mr.Hoa", "23-4-3006", 200, "Nuoc Ngoai");
        Console.WriteLine(nn.thanhtoan());
      
        
    }
    public static void Main1(String[]args)
    {
        //  int x = 10;
        //  double y = 3.14;
        // Console.WriteLine("Hello world:" + x);
        // String s = "T2204M";

        //int[] ns = new int[3];
        //ns[0] = 15;
        //ns[1] = 20;
        //ns[2] = 25;
        //foreach(int n in ns)
        //{
        //nqcxzA
        //}   
        //for (int i = 0;i< ns.Length; i++)
        //{
        //ns[i] d
        //       string input = Console.ReadLine();
        //     int num = Convert.ToInt32(input);
        //   Console.WriteLine("num =" + num);
        // Hument h = new Hument();
        //h.Run();
        //  }

        Console.Write("Nhap vao tu so: ");
        string ts;
        ts = Console.ReadLine();
        Console.Write("Nhap vao mau so: ");
        string ms;
        ms = Console.ReadLine();
            try
            {
                PhanSo PS = new PhanSo(int.Parse(ts), int.Parse(ms));
                Console.Write("Phan so ban dang co la: ");
                PS.InPS();
                PS.RutGonPS();
                Console.Write("Phan so sau khi rut gon la: ");
                PS.InPS();
          
            }
            catch (Exception ignored)
            {
                Console.WriteLine("Phan so không hop le!");
            }

    }
}
