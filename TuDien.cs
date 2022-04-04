using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapvenha
{
    internal class TuDien
    {


        public Dictionary<string, string> DIC = new Dictionary<string, string>();

        public void ThemTu(string a, string b)
        {
            this.DIC.Add(a, b);
        }
        public void ThemTu()
        {
            int n;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Nhập số lượng từ muốn thêm đi người bạn:");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                n = 1;
            }
            finally
            {
                Console.WriteLine("Ok bạn hiền, giờ thì nhập từ vào nhé!");
            }
            for (int i = 0; i < n; i++)
            {
                string a, b;
                Console.Write("Bạn muốn thêm từ tiếng Việt: ");
                a = Console.ReadLine();
                Console.WriteLine("Từ này trong tiếng Anh có nghĩa là: ");
                b = Console.ReadLine();
                this.DIC.Add(a, b);
            }
        }

        public void DuyetDanhSach()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (KeyValuePair<string, string> item in DIC)
            {
                Console.WriteLine(item.Key + "\t||\t" + item.Value);
            }
        }
        public void TimTu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string a;
            Console.WriteLine("Nhập từ bạn muốn dịch sang tiếng Anh:");
            a = Console.ReadLine();
            try
            {
                Console.Write("Trong tiếng Anh có nghĩa là: ");
                Console.WriteLine(DIC[a]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Chắc là có gì đó không ổn rồi! Hệ thống k thể tìm thấy từ!");
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }
    }
}
