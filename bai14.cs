using System;
using System.Globalization;
using System.Threading;

namespace BT14_obj04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Đặt mã hóa đầu ra của Console để hiển thị tiếng Việt
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            // Khai báo số thực x 4 byte
            float x = 0;

            // Gọi hàm để nhập giá trị của x
            x = NhapSoThuc4Byte();

            // In ra màn hình giá trị được nhập
            Console.WriteLine($"Giá trị đã nhập: {x}");
        }

        static float NhapSoThuc4Byte()
        {
            float result;
            while (true)
            {
                Console.Write("Nhập vào một số thực (4 byte): ");
                string input = Console.ReadLine();

                if (float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out result))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nỏ hợp lệ, yêu cầu nhập lại!!");
                }
            }
            return result;
        }
    }
}
