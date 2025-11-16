using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ham
{

    
        public static class checker
        {
            public static bool checkinput(string input, out int value)
            {
                value = 0;

                if (string.IsNullOrWhiteSpace(input))
                    return false;

                input = input.Trim();

                if (!int.TryParse(input, out value))
                    return false;

                return true; // hợp lệ
            }

            // Hàm nhập số có kiểm tra
            public static int GetValidNumber(string message)
            {
                int n;
                while (true)
                {
                    Console.Write(message);
                    string input = Console.ReadLine();

                    if (checkinput(input, out n))
                        return n;

                    Console.WriteLine("❌ Lỗi: Giá trị nhập không hợp lệ. Vui lòng nhập số nguyên!");
                }
            }
        }
    }


