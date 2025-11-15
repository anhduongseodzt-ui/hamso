using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ham
{
    public static class Program
    {
       
        

        // Hàm chính của chương trình
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8; // Đảm bảo hiển thị tiếng Việt đúng cách

            int choice; // Biến lưu lựa chọn của người dùng
            do
            {
                // Hiển thị menu chọn bài tập
                Console.WriteLine("\nChọn Bài Tập:");
                Console.WriteLine("4. Tính giai thừa");
                Console.WriteLine("5. Liệt kê số nguyên tố nhỏ hơn n");
                Console.WriteLine("6. Kiểm tra số chẵn/lẻ");
                Console.WriteLine("7. Kiểm tra số nguyên tố");
                Console.WriteLine("8. Hiển thị số bằng chữ");
                Console.WriteLine("0. Thoát");
                Console.Write("Nhập lựa chọn của bạn: ");

                choice = int.Parse(Console.ReadLine()); // Nhận lựa chọn từ người dùng

                switch (choice)
                {
                    case 1:
                        BE.Dataacces.Bai2.TinhGiaiThua(); // Gọi hàm tính giai thừa
                        break;
                    case 2:
                        BE.Dataacces.Bai2.LietKeSoNguyenTo(); // Gọi hàm liệt kê số nguyên tố
                        break;
                    case 3:
                        BE.Dataacces.Bai2.KiemTraChanLe(); // Gọi hàm kiểm tra số chẵn lẻ
                        break;
                    case 4:
                        BE.Dataacces.Bai2.KiemTraSoNguyenTo(); // Gọi hàm kiểm tra số nguyên tố
                        break;
                    case 5:
                        BE.Dataacces.Bai2.HienThiSoBangChu(); // Gọi hàm hiển thị số bằng chữ
                        break;
                    case 0:
                        Console.WriteLine("Thoát Bài Tập."); // Thoát Bài Tập Hoàn Thành
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại."); // Thông báo nhập sai
                        break;
                }

            } while (choice != 0); // Lặp lại cho đến khi người dùng chọn 0 để thoát
        }
    }
}
