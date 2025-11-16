using System;
using System.Text;

class Program
{
    // Bài 4: Tính giai thừa của một số nguyên dương
    public static void TinhGiaiThua()
    {
        Console.Write("Nhập một số nguyên dương: ");
        int n = int.Parse(Console.ReadLine()); // Nhập số nguyên từ bàn phím
        long giaiThua = 1; // Biến lưu kết quả giai thừa

        for (int i = 1; i <= n; i++)
        {
            giaiThua *= i; // Nhân dồn để tính giai thừa
        }

        Console.WriteLine($"Giai thừa của {n} là: {giaiThua}");
    }

    // Bài 5: Liệt kê tất cả các số nguyên tố nhỏ hơn n
    public static void LietKeSoNguyenTo()
    {
        Console.Write("Nhập số nguyên n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Các số nguyên tố nhỏ hơn {n} là:");
        for (int i = 2; i < n; i++)
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
        Console.Write("Nhập một số nguyên: ");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
            Console.WriteLine($"{n} là số chẵn.");
        else
            Console.WriteLine($"{n} là số lẻ.");
    }

    // Bài 7: Kiểm tra số nguyên tố
    public static void KiemTraSoNguyenTo()
    {
        Console.Write("Nhập một số nguyên: ");
        int n = int.Parse(Console.ReadLine());

        if (LaSoNguyenTo(n))
            Console.WriteLine($"{n} là số nguyên tố.");
        else
            Console.WriteLine($"{n} không phải là số nguyên tố.");
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
        int n = int.Parse(Console.ReadLine());

        // Mảng chứa cách đọc của các số từ 0 đến 9
        string[] SoChuDoc = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };

        if (n >= 0 && n <= 9)
            Console.WriteLine($"Số {n} đọc là: {SoChuDoc[n]}"); // Hiển thị cách đọc tương ứng
        else
            Console.WriteLine("Vui lòng nhập số từ 0 đến 9.");
    }

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
                    TinhGiaiThua(); // Gọi hàm tính giai thừa
                    break;
                case 2:
                    LietKeSoNguyenTo(); // Gọi hàm liệt kê số nguyên tố
                    break;
                case 3:
                    KiemTraChanLe(); // Gọi hàm kiểm tra số chẵn lẻ
                    break;
                case 4:
                    KiemTraSoNguyenTo(); // Gọi hàm kiểm tra số nguyên tố
                    break;
                case 5:
                    HienThiSoBangChu(); // Gọi hàm hiển thị số bằng chữ
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