using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()

        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("\nChọn Bài Tập:");
                Console.WriteLine("4. Tính giai thừa");
                Console.WriteLine("5. Liệt kê số nguyên tố nhỏ hơn n");
                Console.WriteLine("6. Kiểm tra số chẵn/lẻ");
                Console.WriteLine("7. Kiểm tra số nguyên tố");
                Console.WriteLine("8. Hiển thị số bằng chữ");
                Console.WriteLine("0. Thoát");
                Console.Write("Nhập lựa chọn của bạn: ");

                string choiceInput = Console.ReadLine();

                // Kiểm tra input có phải số không
                if (!ham.checker.checkinput(choiceInput, out int choice))
                {
                    Console.WriteLine("Lỗi: Bạn phải nhập một số hợp lệ!");
                    continue;
                }

                // Thoát chương trình
                if (choice == 0)
                {
                    Console.WriteLine("Đã thoát chương trình.");
                    break;
                }

                // Xử lý menu
                switch (choice)
                {
                    case 4:
                        logic.bai1.TinhGiaiThua();
                        break;
                    case 5:
                        logic.bai1.LietKeSNT_NhoHonN();
                        break;
                    case 6:
                        logic.bai1.KiemTraChanLe();
                        break;
                    case 7:
                        logic.bai1.KiemTraSoNguyenTo();
                        break;
                    case 8:
                        logic.bai1.DocSoBangChu();
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng nhập từ 0–8.");
                        break;
                }
            }


        }
    }
}