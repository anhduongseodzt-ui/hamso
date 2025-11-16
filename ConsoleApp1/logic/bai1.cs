using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace logic
{
    public static class bai1
    {
        // 4. Tính giai thừa
        public static void TinhGiaiThua()
        {
            int n = ham.checker.GetValidNumber("Nhập n để tính giai thừa: ");

            if (n < 0)
            {
                Console.WriteLine("❌ Không tính giai thừa cho số âm!");
                return;
            }

            long gt = 1;
            for (int i = 1; i <= n; i++)
                gt *= i;

            Console.WriteLine($"➡ Giai thừa của {n} là: {gt}");
        }

        // 5. Liệt kê số nguyên tố nhỏ hơn n
        public static void LietKeSNT_NhoHonN()
        {
            int n = ham.checker.GetValidNumber("Nhập n để liệt kê số nguyên tố nhỏ hơn n: ");

            Console.Write($"➡ Các số nguyên tố nhỏ hơn {n}: ");
            for (int i = 2; i < n; i++)
            {
                if (LaSoNguyenTo(i))
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // 6. Kiểm tra số chẵn/lẻ
        public static void KiemTraChanLe()
        {
            int n = ham.checker.GetValidNumber("Nhập n để kiểm tra chẵn/lẻ: ");

            if (n % 2 == 0)
                Console.WriteLine($"➡ {n} là số chẵn");
            else
                Console.WriteLine($"➡ {n} là số lẻ");
        }

        // 7. Kiểm tra số nguyên tố
        public static void KiemTraSoNguyenTo()
        {
            int n = ham.checker.GetValidNumber("Nhập n để kiểm tra số nguyên tố: ");

            if (LaSoNguyenTo(n))
                Console.WriteLine($"➡ {n} là số nguyên tố");
            else
                Console.WriteLine($"➡ {n} KHÔNG phải số nguyên tố");
        }

        // Hàm kiểm tra SNT phụ trợ
        public static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        // 8. Hiển thị số bằng chữ
        // 8. Hiển thị số bằng chữ (cách khác)
        public static void DocSoBangChu()
        {
            int n = ham.checker.GetValidNumber("Nhập số (0–9) để đọc bằng chữ: ");

            string[] chuSo = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };

            if (n >= 0 && n <= 9)
            {
                Console.WriteLine($"➡ {n} đọc là: {chuSo[n]}");
            }
            else
            {
                Console.WriteLine("❌ Chỉ hỗ trợ số từ 0 đến 9.");
            }
        }

    }
}
