using System;
using System.Text;

namespace BT13_obj04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Chương trình nhập số nguyên 1 byte không dấu trong khoảng 2 đến 10:");

            byte n = NhapSoNguyen();
            Console.WriteLine($"Số được nhập: {n}");
        }

        static byte NhapSoNguyen()
        {
            byte SoNguyen;
            while (true)
            {
                Console.Write("Nhập vào một số nguyên 1 byte không dấu (2 đến 10): ");
                string input = Console.ReadLine();

                if (byte.TryParse(input, out SoNguyen) && SoNguyen >= 2 && SoNguyen <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Giá trị không hợp lệ, nhập lại đi!!");
                }
            }
            return SoNguyen;
        }
    }
}
