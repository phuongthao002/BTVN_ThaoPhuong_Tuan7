using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapvenha
{
    internal class Program
    {
        static void Main(string[] args)
        
            {
                TuDien tuDien = new TuDien();
                bool Run = true;

                while (Run)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("========================Chao mung ban den voi chuong trinh Tu Dien Viet - Anh===============");
                    Console.WriteLine("\n0.Thoat chuong trinh");
                    Console.WriteLine("\n1.Them tu vao tu dien");
                    Console.WriteLine("\n2.Duyet danh sach tu dien");
                    Console.WriteLine("\n3.Tim tu co trong tu dien");
                    Console.Write("\nBan hay chon chuc nang ma ban muon: ");
                    int Choice = Convert.ToInt32(Console.ReadLine());

                    switch (Choice)
                    {
                        case 0:
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("==========Doumo Arigatou Gozaimasu! See u later!============");
                                Console.WriteLine("==========Chuong trinh tu dien Viet - Anh ket thuc==========");
                                Run = false;
                                break;
                            }
                        case 1:
                            {
                                Console.WriteLine("==========Them tu vao tu dien Viet - Anh============");
                                tuDien.ThemTu();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("==========Duyet danh sach tu dien Viet - Anh==========");
                                tuDien.DuyetDanhSach();
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("=========Tim tu vung trong tu dien Viet - Anh==========");
                                tuDien.TimTu();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Vui long nhap lai!");
                                break;
                            }
                    }
                }

                Console.ReadLine();
            }

        }
    
}
