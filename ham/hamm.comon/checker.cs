using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamm.comon
{
    public static class checker
    {
        public static bool checkinput(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            input = input.Trim();
            if (!int.TryParse(input, out int value))
            {
                return false;
            }
            int ninput = int.Parse(Console.ReadLine());
            if (ninput > int.MaxValue)
            {
                return false;
            }
            return true;
        }
    }
}
