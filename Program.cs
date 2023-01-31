using System.Security.Cryptography.X509Certificates;
using System.Text;
using T2204M.session1;
using T2204M.session1.baiTap;
using T2204M.session3;
using T2204M.session3.baiTap;
using T2204M.session4;
using T2204M.session4.baitap;
using System.Net.Http;
using T2204M.session5;
using Newtonsoft.Json;
using T2204M.qlisv;

public class program
{
   public static void Main(string[] args)
    {
        QuanLiSV ql = new QuanLiSV();
        int option = 0;
        while (option != 9)
        {
            Console.WriteLine("1.Them Sinh Vien.");
            Console.WriteLine("2.Cap nhat thong tin sinh vien boi ID.");
            Console.WriteLine("3.Xoa sinh vien boi ID");
            Console.WriteLine("4.Tim kiem sinh vien theo ten");
            Console.WriteLine("5.Sap xep sinh vien theo Diem trung binh.");
            Console.WriteLine("6.Sap xep sinh vien theo ten.");
            Console.WriteLine("7.Sap xep sinh vien theo id.");
            Console.WriteLine("8.Hien thi");
            Console.WriteLine("9.thoat");

            Console.WriteLine("Xin moi lua chon: ");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ql.ThemSV();
                    break;
                case 2:
                    ql.updateID();
                    break;
                case 3:
                    ql.XoaSvTheoID();
                    break;
                case 4:
                    ql.SeachName(); 
                    break;
                case 5:
                    ql.sapxepTb();
                    break;
                case 6:
                    ql.sapxepTen(); 
                    break;
                case 7:
                    ql.sapxepID();
                    break;
                case 8:
                    ql.Display(ql.qliSV);
                    break;
                default:
                    break;
            }
        }
    }

public static void Main6(string[] args)
    {
        Thread t = new Thread(RunThread);
        t.Start("Xin Chao");
        Thread t2 = new Thread(delegate ()
        {
            Console.WriteLine("Demo anonymous function");
        });
        t2.Start();
        Console.WriteLine("Main done");
    }

     static async Task<Root>CallApi()
    {
        string url = "https://api.openweathermap.org/data/2.5/weather?q=Hanoi,vietnam&appid=09a71427c59d38d6a34f89b47d75975c&units=metric";
        HttpClient http = new HttpClient();
        var rs = await http.GetAsync(url);    // Lấy data về 
        if(rs.StatusCode == System.Net.HttpStatusCode.OK)
        {
            string content = await rs.Content.ReadAsStringAsync();
            Root r = JsonConvert.DeserializeObject<Root>(content);
            return r;
        }
        return null;
    }
    static void RunThread(object o)
    {
        for(int i= 0;i<20;i++)
        {
            Console.WriteLine(o+":"+i);
            try
            {
                Thread.Sleep(1000);
            }   catch(Exception e)
            {

            } 
        }
    }
        
    public static void Main5(string[] args)
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
        PhanSo PS = new PhanSo();
                Console.Write("Phan so co dang la: ");
                PS.InPS();
                PS.RutGonPS();
                Console.Write("Phan so sau khi rut gon la: ");
                PS.InPS();        ms = Console.ReadLine();
            try
            {
                PhanSo PS1 = new PhanSo(int.Parse(ts), int.Parse(ms));

          
            }
            catch (Exception ignored)
            {
                Console.WriteLine("Phan so không hop le!");
            }

    }
}
