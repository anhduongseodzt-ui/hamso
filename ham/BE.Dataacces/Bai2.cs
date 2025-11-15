using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Dataacces
{
    public static class Bai2
    {
        public static void TinhGiaiThua()
        {
            Console.Write("Nhập một số nguyên dương: ");
            var number = Console.ReadLine();
            var check = hamm.comon.checker.checkinput(number);
            if (!hamm.comon.checker.checkinput(number))
            {
                Console.WriteLine("nhap sai , nhap lai");
            }


            long giaiThua = 1; // Biến lưu kết quả giai thừa

            for (int i = 1; i <= int.Parse(number); i++)
            {
                giaiThua *= i; // Nhân dồn để tính giai thừa
            }

            Console.WriteLine($"Giai thừa của {int.Parse(number)} là: {giaiThua}");
        }

        // Bài 5: Liệt kê tất cả các số nguyên tố nhỏ hơn n
        public static void LietKeSoNguyenTo()
        {
            Console.Write("Nhập một số nguyên dương: ");
            var number = Console.ReadLine();
            var check = hamm.comon.checker.checkinput(number);
            if (!hamm.comon.checker.checkinput(number))
            {
                Console.WriteLine("nhap sai , nhap lai");
            }
            Console.WriteLine($"Các số nguyên tố nhỏ hơn {int.Parse(number)} là:");
            for (int i = 2; i < int.Parse(number); i++)
            {
                if (LaSoNguyenTo(i)) // Kiểm tra xem số i có phải số nguyên tố không
                {
                    Console.Write(i + " "); // In ra số nguyên tố
                }
            }
            Console.WriteLine();
        }

        // Bài 6: Kiểm tra số chẵn hay lẻ
        public static void KiemTraChanLe()
        {
            Console.Write("Nhập một số nguyên dương: ");
            var number = Console.ReadLine();
            var check = hamm.comon.checker.checkinput(number);
            if (!hamm.comon.checker.checkinput(number))
            {
                Console.WriteLine("nhap sai , nhap lai");
            }

            if (int.Parse(number) % 2 == 0)
                Console.WriteLine($"{int.Parse(number)} là số chẵn.");
            else
                Console.WriteLine($"{int.Parse(number)} là số lẻ.");
        }

        // Bài 7: Kiểm tra số nguyên tố
        public static void KiemTraSoNguyenTo()
        {
            Console.Write("Nhập một số nguyên dương: ");
            var number = Console.ReadLine();
            var check = hamm.comon.checker.checkinput(number);
            if (!hamm.comon.checker.checkinput(number))
            {
                Console.WriteLine("nhap sai , nhap lai");
            }

            if (LaSoNguyenTo(int.Parse(number)))
                Console.WriteLine($"{int.Parse(number)} là số nguyên tố.");
            else
                Console.WriteLine($"{int.Parse(number)} không phải là số nguyên tố.");
        }

        // Hàm kiểm tra số nguyên tố
        public static bool LaSoNguyenTo(int num)
        {
            if (num < 2) // Số nhỏ hơn 2 không phải số nguyên tố
                return false;
            for (int i = 2; i <= Math.Sqrt(num); i++) // Kiểm tra từ 2 đến căn bậc hai của số đó
            {
                if (num % i == 0) // Nếu chia hết cho bất kỳ số nào trong khoảng trên thì không phải số nguyên tố
                    return false;
            }
            return true; // Nếu không tìm thấy ước số nào thì là số nguyên tố
        }

        // Bài 8: Hiển thị số bằng chữ (0-9)
        public static void HienThiSoBangChu()
        {
            Console.Write("Nhập một số (0-9): ");

            var number = Console.ReadLine();
            var check = hamm.comon.checker.checkinput(number);
            if (!hamm.comon.checker.checkinput(number))
            {
                Console.WriteLine("nhap sai , nhap lai");
            }

            // Mảng chứa cách đọc của các số từ 0 đến 9
            string[] SoChuDoc = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };

            if (int.Parse(number) >= 0 && int.Parse(number) <= 9)
                Console.WriteLine($"Số {int.Parse(number)} đọc là: {SoChuDoc[int.Parse(number)]}"); // Hiển thị cách đọc tương ứng
            else
                Console.WriteLine("Vui lòng nhập số từ 0 đến 9.");
        }
    }
}
